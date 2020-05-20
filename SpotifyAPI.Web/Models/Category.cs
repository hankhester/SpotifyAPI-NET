using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class Category : BasicModel
  {
    [JsonPropertyName("href")]
    public string Href { get; set; }

    [JsonPropertyName("icons")]
    public List<Image> Icons { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
  }
}