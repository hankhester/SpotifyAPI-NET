using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class SeveralAudioFeatures : BasicModel
  {
    [JsonPropertyName("audio_features")]
    public List<AudioFeatures> AudioFeatures { get; set; }
  }
}