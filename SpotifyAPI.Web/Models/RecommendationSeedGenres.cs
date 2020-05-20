using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class RecommendationSeedGenres : BasicModel
  {
    [JsonPropertyName("genres")]
    public List<string> Genres { get; set; }
  }
}