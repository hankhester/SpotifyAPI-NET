using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class PlayHistory : BasicModel
  {
    [JsonPropertyName("track")]
    public SimpleTrack Track { get; set; }

    [JsonPropertyName("played_at")]
    public DateTime PlayedAt { get; set; }

    [JsonPropertyName("context")]
    public Context Context { get; set; }
  }
}