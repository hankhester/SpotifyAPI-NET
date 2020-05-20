using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class AnalysisSection
  {
    [JsonPropertyName("start")]
    public double Start { get; set; }

    [JsonPropertyName("duration")]
    public double Duration { get; set; }

    [JsonPropertyName("confidence")]
    public double Confidence { get; set; }

    [JsonPropertyName("loudness")]
    public double Loudness { get; set; }

    [JsonPropertyName("tempo")]
    public double Tempo { get; set; }

    [JsonPropertyName("tempo_confidence")]
    public double TempoConfidence { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    [JsonPropertyName("key_confidence")]
    public double KeyConfidence { get; set; }

    [JsonPropertyName("mode")]
    public int Mode { get; set; }

    [JsonPropertyName("mode_confidence")]
    public double ModeConfidence { get; set; }

    [JsonPropertyName("time_signature")]
    public int TimeSignature { get; set; }

    [JsonPropertyName("time_signature_confidence")]
    public double TimeSignatureConfidence { get; set; }
  }
}