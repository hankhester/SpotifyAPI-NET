using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class FullTrack : BasicModel
  {
    [JsonPropertyName("album")]
    public SimpleAlbum Album { get; set; }

    [JsonPropertyName("artists")]
    public List<SimpleArtist> Artists { get; set; }

    [JsonPropertyName("available_markets")]
    public List<string> AvailableMarkets { get; set; }

    [JsonPropertyName("disc_number")]
    public int DiscNumber { get; set; }

    [JsonPropertyName("duration_ms")]
    public int DurationMs { get; set; }

    [JsonPropertyName("explicit")]
    public bool Explicit { get; set; }

    [JsonPropertyName("external_ids")]
    public Dictionary<string, string> ExternalIds { get; set; }

    [JsonPropertyName("external_urls")]
    public Dictionary<string, string> ExternUrls { get; set; }

    [JsonPropertyName("href")]
    public string Href { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("popularity")]
    public int Popularity { get; set; }

    [JsonPropertyName("preview_url")]
    public string PreviewUrl { get; set; }

    [JsonPropertyName("track_number")]
    public int TrackNumber { get; set; }

    [JsonPropertyName("restrictions")]
    public Dictionary<string, string> Restrictions { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("uri")]
    public string Uri { get; set; }

    /// <summary>
    ///     Only filled when the "market"-parameter was supplied!
    /// </summary>
    [JsonPropertyName("is_playable")]
    public bool? IsPlayable { get; set; }

    /// <summary>
    ///     Only filled when the "market"-parameter was supplied!
    /// </summary>
    [JsonPropertyName("linked_from")]
    public LinkedFrom LinkedFrom { get; set; }
  }
}