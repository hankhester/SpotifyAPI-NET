using System.Text.Json;
using System.Text.Json.Serialization;
using SpotifyAPI.Web.Enums;

namespace SpotifyAPI.Web.Models
{
  public class PlaybackContext : BasicModel
  {
    [JsonPropertyName("device")]
    public Device Device { get; set; }

    [JsonPropertyName("repeat_state")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public RepeatState RepeatState { get; set; }

    [JsonPropertyName("shuffle_state")]
    public bool ShuffleState { get; set; }

    [JsonPropertyName("context")]
    public Context Context { get; set; }

    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; }

    [JsonPropertyName("progress_ms")]
    public int ProgressMs { get; set; }

    [JsonPropertyName("is_playing")]
    public bool IsPlaying { get; set; }

    [JsonPropertyName("item")]
    public FullTrack Item { get; set; }

    [JsonPropertyName("currently_playing_type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TrackType CurrentlyPlayingType { get; set; }
  }
}