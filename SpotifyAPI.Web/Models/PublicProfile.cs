using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class PublicProfile : BasicModel
  {
    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; }

    [JsonPropertyName("external_urls")]
    public Dictionary<string, string> ExternalUrls { get; set; }

    [JsonPropertyName("followers")]
    public Followers Followers { get; set; }

    [JsonPropertyName("href")]
    public string Href { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("images")]
    public List<Image> Images { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("uri")]
    public string Uri { get; set; }
  }
}