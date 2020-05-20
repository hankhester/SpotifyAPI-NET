using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class Recommendations : BasicModel
  {
    [JsonPropertyName("seeds")]
    public List<RecommendationSeed> Seeds { get; set; }

    [JsonPropertyName("tracks")]
    public List<SimpleTrack> Tracks { get; set; }
  }
}