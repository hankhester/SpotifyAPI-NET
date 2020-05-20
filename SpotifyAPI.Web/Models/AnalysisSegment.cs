using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class AnalysisSegment
  {
    [JsonPropertyName("start")]
    public double Start { get; set; }

    [JsonPropertyName("duration")]
    public double Duration { get; set; }

    [JsonPropertyName("confidence")]
    public double Confidence { get; set; }

    [JsonPropertyName("loudness_start")]
    public double LoudnessStart { get; set; }

    [JsonPropertyName("loudness_max_time")]
    public double LoudnessMaxTime { get; set; }

    [JsonPropertyName("loudness_max")]
    public double LoudnessMax { get; set; }

    [JsonPropertyName("loudness_end")]
    public double LoudnessEnd { get; set; }

    [JsonPropertyName("pitches")]
    public List<double> Pitches { get; set; }

    [JsonPropertyName("timbre")]
    public List<double> Timbre { get; set; }
  }
}