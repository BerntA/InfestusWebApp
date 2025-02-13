using lib.Models;
using lib.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Primitives;
using System.Net;
using System.Text.RegularExpressions;

namespace app.Controllers;

[ApiController]
[Route("api/steam-auth")]
public class SteamAuthController : ControllerBase
{
    private readonly HttpClient _httpClient;
    private readonly SteamApiService _steamApiService;
    private readonly KeyAuthService _keyAuthService;
    private readonly string _hostName;

    private const string SteamLogin = "https://steamcommunity.com/openid/login";
    private const string OpenIdNs = "http://specs.openid.net/auth/2.0";
    private const string SteamUrlValidationRegex = "^(http|https)://steamcommunity.com/openid/id/[0-9]{15,25}$";
    private const string SteamIdExtractRegex = "\\D+";

    public SteamAuthController(HttpClient httpClient, SteamApiService steamApiService, KeyAuthService keyAuthService, IConfiguration config)
    {
        _httpClient = httpClient;
        _steamApiService = steamApiService;
        _keyAuthService = keyAuthService;
        _hostName = config["HostName"] ?? string.Empty;
    }

    [HttpGet]
    public async Task<IActionResult> FetchSteamKey()
    {
        var steamId64 = await AuthenticateSteamUser();

        if (string.IsNullOrEmpty(steamId64))
        {
            return new OkObjectResult(new SteamAuthResponse
            {
                Result = string.Empty,
                Error = "Steam authentication failed!",
                StatusCode = (int)HttpStatusCode.Unauthorized,
            });
        }

        var steamId64Num = Convert.ToUInt64(steamId64);
        var steamKey = await _keyAuthService.GetSteamKeyForUser(steamId64Num);

        if (string.IsNullOrEmpty(steamKey))
        {
            var summary = await _steamApiService.GetPlayerSummary(steamId64);
            if (summary is null || summary.ProfileState <= 0) // must have a configured profile!
            {
                return new OkObjectResult(new SteamAuthResponse
                {
                    Result = string.Empty,
                    Error = "Unable to retrieve Steam profile data!",
                    StatusCode = (int)HttpStatusCode.NotFound,
                });
            }
            steamKey = await _keyAuthService.RegisterSteamKeyForUser(steamId64Num);
        }

        return new OkObjectResult(new SteamAuthResponse
        {
            Result = string.IsNullOrEmpty(steamKey) ? string.Empty : steamKey,
            Error = string.IsNullOrEmpty(steamKey) ? "Unable to fetch/register a Steam key!" : string.Empty,
            StatusCode = string.IsNullOrEmpty(steamKey) ? (int)HttpStatusCode.InternalServerError : (int)HttpStatusCode.OK,
        });
    }

    [HttpGet("keys")]
    public async Task<IActionResult> GetNumKeysLeft()
    {
        return new OkObjectResult(
            await _keyAuthService.GetNumFreeSteamKeys()
        );
    }

    private async Task<string?> AuthenticateSteamUser()
    {
        var data = new Dictionary<string, StringValues>();

        if (HttpContext.Request.Query is not null)
            data = HttpContext.Request.Query.ToDictionary();
        else if (HttpContext.Request.Form is not null)
        {
            var form = await HttpContext.Request.ReadFormAsync();
            data = form.ToDictionary();
        }

        if (!data.TryGetValue("openid.mode", out var mode) || mode != "id_res")
            return null;

        if (!data.TryGetValue("openid.return_to", out var returnUrl) || !IsHostValid(returnUrl.ToString()))
            return null;

        var formDict = new Dictionary<string, string>
        {
            { "openid.assoc_handle", data["openid.assoc_handle"].ToString() },
            { "openid.signed", data["openid.signed"].ToString() },
            { "openid.sig", data["openid.sig"].ToString() },
            { "openid.ns", data["openid.ns"].ToString() },
        };

        var split = data["openid.signed"].ToString().Split(',');

        foreach (var item in split)
        {
            var key = $"openid.{item}";

            if (formDict.ContainsKey(key))
                continue;

            if (!data.TryGetValue(key, out var value))
                return null;

            formDict.Add(key, value.ToString());
        }

        formDict.Add("openid.mode", "check_authentication");

        var queryString = QueryHelpers.AddQueryString(SteamLogin, formDict!);
        using var response = await _httpClient.GetAsync(queryString);

        response.EnsureSuccessStatusCode();
        var result = await response.Content.ReadAsStringAsync();

        if (!result.StartsWith($"ns:{OpenIdNs}") || !result.EndsWith("is_valid:true\n"))
            return null;

        if (!data.TryGetValue("openid.claimed_id", out var openIdUrl))
            return null;

        if (!Regex.IsMatch(openIdUrl, SteamUrlValidationRegex))
            return null;

        return Regex.Replace(openIdUrl, SteamIdExtractRegex, "");
    }

    private bool IsHostValid(string host)
    {
        var localHost = HttpContext.Request.Host.Host;
        return host.Contains(localHost, StringComparison.OrdinalIgnoreCase) || host.Contains(_hostName, StringComparison.OrdinalIgnoreCase);
    }
}