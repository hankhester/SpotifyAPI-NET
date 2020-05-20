using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class FeaturedPlaylists : BasicModel
  {
    [JsonPropertyName("message")]
    public string Message { get; set; }

    [JsonPropertyName("playlists")]
    public Paging<SimplePlaylist> Playlists { get; set; }
  }
}