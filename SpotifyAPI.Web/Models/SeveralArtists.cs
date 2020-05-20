using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class SeveralArtists : BasicModel
  {
    [JsonPropertyName("artists")]
    public List<FullArtist> Artists { get; set; }
  }
}