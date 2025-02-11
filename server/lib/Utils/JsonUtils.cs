using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace lib.Utils;

public static class JsonUtils
{
    static JsonUtils()
    {
        JsonSettings = ConfigureJsonSettings(new());
    }

    public static JsonSerializerOptions JsonSettings;

    public static JsonSerializerOptions ConfigureJsonSettings(JsonSerializerOptions options, JsonNamingPolicy? jsonNamingPolicy = null)
    {
        options.PropertyNamingPolicy = jsonNamingPolicy ?? JsonNamingPolicy.CamelCase;
        options.PropertyNameCaseInsensitive = true;
        options.NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.AllowNamedFloatingPointLiterals;
        options.IncludeFields = true;
        options.AllowTrailingCommas = true;
        options.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
        return options;
    }

    public static string SerializeObject<T>(T o, JsonSerializerOptions? jsonSerializerOptions = null)
    {
        return (o is null) ? null : JsonSerializer.Serialize(o, jsonSerializerOptions ?? JsonSettings);
    }

    public static T DeserializeObject<T>(string payload, JsonSerializerOptions? jsonSerializerOptions = null)
    {
        return string.IsNullOrEmpty(payload) ? default : JsonSerializer.Deserialize<T>(payload, jsonSerializerOptions ?? JsonSettings);
    }

    public static object DeserializeObject(string payload, Type type, JsonSerializerOptions? jsonSerializerOptions = null)
    {
        return string.IsNullOrEmpty(payload) ? default : JsonSerializer.Deserialize(payload, type, jsonSerializerOptions ?? JsonSettings);
    }
}