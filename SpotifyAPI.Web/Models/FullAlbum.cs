using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class FullAlbum : BasicModel
  {
    [JsonPropertyName("album_type")]
    public string AlbumType { get; set; }

    [JsonPropertyName("artists")]
    public List<SimpleArtist> Artists { get; set; }

    [JsonPropertyName("available_markets")]
    public List<string> AvailableMarkets { get; set; }

    [JsonPropertyName("copyrights")]
    public List<Copyright> Copyrights { get; set; }

    [JsonPropertyName("external_ids")]
    public Dictionary<string, string> ExternalIds { get; set; }

    [JsonPropertyName("external_urls")]
    public Dictionary<string, string> ExternalUrls { get; set; }

    [JsonPropertyName("genres")]
    public List<string> Genres { get; set; }

    [JsonPropertyName("href")]
    public string Href { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("images")]
    public List<Image> Images { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("popularity")]
    public int Popularity { get; set; }

    [JsonPropertyName("release_date")]
    public string ReleaseDate { get; set; }

    [JsonPropertyName("release_date_precision")]
    public string ReleaseDatePrecision { get; set; }

    [JsonPropertyName("tracks")]
    public Paging<SimpleTrack> Tracks { get; set; }

    [JsonPropertyName("restrictions")]
    public Dictionary<string, string> Restrictions { get; set; }

    [JsonPropertyName("total_tracks")]
    public int TotalTracks { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("uri")]
    public string Uri { get; set; }
  }
}