using System.Text.Json.Serialization;

namespace Ainimals.io.ImagineAPI;

public record Payload
{
    public string Id { get; set; }
    public string Prompt { get; set; }
    public string? Results { get; set; }
    public string ResultsUrl => $"https://demo.imagineapi.dev/assets/{Results}";
    public string UserCreated => User_Created;
    public  string DateCreated => Date_Created;
    public string Status { get; set; }
    public int? Progress { get; set; }
    public string? Url { get; set; } 
    public object? Errors { get; set; }
    public IEnumerable<string>? UpscaledUrls => Upscaled_Urls;
    public IEnumerable<string> Upscaled { get; set; }
        
    [JsonPropertyName("user_created")]
    public string User_Created { get; set; }
        
    [JsonPropertyName("date_created")]
    public string Date_Created { get; set; }

    [JsonPropertyName("upscaled_urls")]
    public IEnumerable<string>? Upscaled_Urls { get; set; }
}