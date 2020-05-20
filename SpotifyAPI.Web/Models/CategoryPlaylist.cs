using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class CategoryPlaylist : BasicModel
  {
    [JsonPropertyName("playlists")]
    public Paging<SimplePlaylist> Playlists { get; set; }
  }
}