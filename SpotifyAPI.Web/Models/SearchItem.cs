using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class SearchItem : BasicModel
  {
    [JsonPropertyName("artists")]
    public Paging<FullArtist> Artists { get; set; }

    [JsonPropertyName("albums")]
    public Paging<SimpleAlbum> Albums { get; set; }

    [JsonPropertyName("tracks")]
    public Paging<FullTrack> Tracks { get; set; }

    [JsonPropertyName("playlists")]
    public Paging<SimplePlaylist> Playlists { get; set; }
  }
}