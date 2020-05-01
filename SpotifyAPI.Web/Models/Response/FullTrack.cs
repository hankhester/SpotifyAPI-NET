using System.Collections.Generic;

namespace SpotifyAPI.Web
{
  public class FullTrack : IPlaylistElement
  {
    public SimpleAlbum Album { get; set; }
    public List<SimpleArtist> Artists { get; set; }
    public List<string> AvailableMarkets { get; set; }
    public int DiscNumber { get; set; }
    public int DurationMs { get; set; }
    public bool Explicit { get; set; }
    public Dictionary<string, string> ExternalIds { get; set; }
    public Dictionary<string, string> ExternalUrls { get; set; }
    public string Href { get; set; }
    public string Id { get; set; }
    public bool IsPlayable { get; set; }
    public LinkedTrack LinkedFrom { get; set; }
    public Dictionary<string, string> Restrictions { get; set; }
    public string Name { get; set; }
    public int Popularity { get; set; }
    public string PreviewUrl { get; set; }
    public int TrackNumber { get; set; }
    public PlaylistElementType Type { get; set; }
    public string Uri { get; set; }
    public bool IsLocal { get; set; }
  }
}