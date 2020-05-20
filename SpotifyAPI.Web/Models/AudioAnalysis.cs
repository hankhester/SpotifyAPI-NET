using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class AudioAnalysis : BasicModel
  {
    [JsonPropertyName("bars")]
    public List<AnalysisTimeSlice> Bars { get; set; }

    [JsonPropertyName("beats")]
    public List<AnalysisTimeSlice> Beats { get; set; }

    [JsonPropertyName("meta")]
    public AnalysisMeta Meta { get; set; }

    [JsonPropertyName("sections")]
    public List<AnalysisSection> Sections { get; set; }

    [JsonPropertyName("segments")]
    public List<AnalysisSegment> Segments { get; set; }

    [JsonPropertyName("tatums")]
    public List<AnalysisTimeSlice> Tatums { get; set; }

    [JsonPropertyName("track")]
    public AnalysisTrack Track { get; set; }
  }
}