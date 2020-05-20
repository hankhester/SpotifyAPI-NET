using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class FollowedArtists : BasicModel
  {
    [JsonPropertyName("artists")]
    public CursorPaging<FullArtist> Artists { get; set; }
  }
}