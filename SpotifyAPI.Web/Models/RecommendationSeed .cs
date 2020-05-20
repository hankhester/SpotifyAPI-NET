using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class RecommendationSeed
  {
    [JsonPropertyName("afterFilteringSize")]
    public int AfterFilteringSize { get; set; }

    [JsonPropertyName("afterRelinkingSize")]
    public int AfterRelinkingSize { get; set; }

    [JsonPropertyName("href")]
    public string Href { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("initialPoolSize")]
    public int InitialPoolSize { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
  }
}