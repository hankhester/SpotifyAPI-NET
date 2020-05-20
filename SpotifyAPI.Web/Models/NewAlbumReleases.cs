using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class NewAlbumReleases : BasicModel
  {
    [JsonPropertyName("albums")]
    public Paging<SimpleAlbum> Albums { get; set; }
  }
}