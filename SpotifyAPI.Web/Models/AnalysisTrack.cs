using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class AnalysisTrack
  {
    [JsonPropertyName("num_samples")]
    public int NumSamples { get; set; }

    [JsonPropertyName("duration")]
    public double Duration { get; set; }

    [JsonPropertyName("sample_md5")]
    public string SampleMD5 { get; set; }

    [JsonPropertyName("offset_seconds")]
    public double OffsetSeconds { get; set; }

    [JsonPropertyName("window_seconds")]
    public double WindowSeconds { get; set; }

    [JsonPropertyName("analysis_sample_rate")]
    public float AnalysisSampleRate { get; set; }

    [JsonPropertyName("analysis_channels")]
    public int AnalysisChannels { get; set; }

    [JsonPropertyName("end_of_fade_in")]
    public double EndOfFadeIn { get; set; }

    [JsonPropertyName("start_of_fade_out")]
    public double StartOfFadeOut { get; set; }

    [JsonPropertyName("loudness")]
    public double Loudness { get; set; }

    [JsonPropertyName("tempo")]
    public double Tempo { get; set; }

    [JsonPropertyName("tempo_confidence")]
    public double TempoConfidence { get; set; }

    [JsonPropertyName("time_signature")]
    public double TimeSignature { get; set; }

    [JsonPropertyName("time_signature_confidence")]
    public double TimeSignatureConfidence { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    [JsonPropertyName("key_confidence")]
    public double KeyConfidence { get; set; }

    [JsonPropertyName("mode")]
    public int Mode { get; set; }

    [JsonPropertyName("mode_confidence")]
    public double ModeConfidence { get; set; }

    [JsonPropertyName("codestring")]
    public string Codestring { get; set; }

    [JsonPropertyName("code_version")]
    public double CodeVersion { get; set; }

    [JsonPropertyName("echoprintstring")]
    public string Echoprintstring { get; set; }

    [JsonPropertyName("echoprint_version")]
    public double EchoprintVersion { get; set; }

    [JsonPropertyName("synchstring")]
    public string Synchstring { get; set; }

    [JsonPropertyName("synch_version")]
    public double SynchVersion { get; set; }

    [JsonPropertyName("rhythmstring")]
    public string Rhythmstring { get; set; }

    [JsonPropertyName("rhythm_version")]
    public double RhythmVersion { get; set; }

  }
}