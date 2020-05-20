using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class SeveralAlbums : BasicModel
  {
    [JsonPropertyName("albums")]
    public List<FullAlbum> Albums { get; set; }
  }
}