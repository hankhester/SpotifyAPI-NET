using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class Image
  {
    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("width")]
    public int Width { get; set; }

    [JsonPropertyName("height")]
    public int Height { get; set; }
  }

  public class ErrorResponse : BasicModel
  { }

  public class Error
  {
    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }
  }

  public class PlaylistTrackCollection
  {
    [JsonPropertyName("href")]
    public string Href { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }
  }

  public class Followers
  {
    [JsonPropertyName("href")]
    public string Href { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }
  }

  public class PlaylistTrack
  {
    [JsonPropertyName("added_at")]
    public DateTime AddedAt { get; set; }

    [JsonPropertyName("added_by")]
    public PublicProfile AddedBy { get; set; }

    [JsonPropertyName("track")]
    public FullTrack Track { get; set; }

    [JsonPropertyName("is_local")]
    public bool IsLocal { get; set; }
  }

  public class DeleteTrackUri
  {
    /// <summary>
    ///     Delete-Track Wrapper
    /// </summary>
    /// <param name="uri">An Spotify-URI</param>
    /// <param name="positions">Optional positions</param>
    public DeleteTrackUri(string uri, params int[] positions)
    {
      Positions = positions.ToList();
      Uri = uri;
    }

    [JsonPropertyName("uri")]
    public string Uri { get; set; }

    [JsonPropertyName("positions")]
    public List<int> Positions { get; set; }

    public bool ShouldSerializePositions()
    {
      return Positions.Count > 0;
    }
  }

  public class Copyright
  {
    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
  }

  public class LinkedFrom
  {
    [JsonPropertyName("external_urls")]
    public Dictionary<string, string> ExternalUrls { get; set; }

    [JsonPropertyName("href")]
    public string Href { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("uri")]
    public string Uri { get; set; }
  }

  public class SavedTrack
  {
    [JsonPropertyName("added_at")]
    public DateTime AddedAt { get; set; }

    [JsonPropertyName("track")]
    public FullTrack Track { get; set; }
  }

  public class SavedAlbum
  {
    [JsonPropertyName("added_at")]
    public DateTime AddedAt { get; set; }

    [JsonPropertyName("album")]
    public FullAlbum Album { get; set; }
  }

  public class Cursor
  {
    [JsonPropertyName("after")]
    public string After { get; set; }

    [JsonPropertyName("before")]
    public string Before { get; set; }
  }

  public class Context
  {
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("href")]
    public string Href { get; set; }

    [JsonPropertyName("external_urls")]
    public Dictionary<string, string> ExternalUrls { get; set; }

    [JsonPropertyName("uri")]
    public string Uri { get; set; }
  }
}