using lib.Models;
using lib.Utils;
using Microsoft.Extensions.Configuration;
using System.Text.Json.Nodes;

namespace lib.Services;

public class SteamApiService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;

    public SteamApiService(HttpClient httpClient, IConfiguration config)
    {
        _httpClient = httpClient;
        _apiKey = config["SteamApiKey"] ?? string.Empty;
    }

    public async Task<SteamPlayerSummary?> GetPlayerSummary(string steamId)
    {
        try
        {
            using var response = await _httpClient.GetAsync($"/ISteamUser/GetPlayerSummaries/v2/?key={_apiKey}&steamids={steamId}");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var jsonContent = JsonNode.Parse(content);

            var item = JsonUtils.DeserializeObject<SteamPlayerSummary>(jsonContent["response"]["players"][0].ToJsonString());
            return item;
        }
        catch
        {
            return null;
        }
    }
}