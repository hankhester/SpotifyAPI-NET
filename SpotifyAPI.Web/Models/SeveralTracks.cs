using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class SeveralTracks : BasicModel
  {
    [JsonPropertyName("tracks")]
    public List<FullTrack> Tracks { get; set; }
  }
}