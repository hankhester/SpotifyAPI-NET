using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class Snapshot : BasicModel
  {
    [JsonPropertyName("snapshot_id")]
    public string SnapshotId { get; set; }
  }
}