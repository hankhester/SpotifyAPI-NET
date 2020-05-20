using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class AnalysisTimeSlice
  {
    [JsonPropertyName("start")]
    public double Start { get; set; }

    [JsonPropertyName("duration")]
    public double Duration { get; set; }

    [JsonPropertyName("confidence")]
    public double Confidence { get; set; }
  }
}