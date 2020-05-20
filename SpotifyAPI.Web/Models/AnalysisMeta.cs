using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class AnalysisMeta
  {
    [JsonPropertyName("analyzer_version")]
    public string AnalyzerVersion { get; set; }

    [JsonPropertyName("platform")]
    public string Platform { get; set; }

    [JsonPropertyName("status_code")]
    public int StatusCode { get; set; }

    [JsonPropertyName("detailed_status")]
    public string DetailedStatus { get; set; }

    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; }

    [JsonPropertyName("analysis_time")]
    public double AnalysisTime { get; set; }

    [JsonPropertyName("input_process")]
    public string InputProcess { get; set; }
  }
}