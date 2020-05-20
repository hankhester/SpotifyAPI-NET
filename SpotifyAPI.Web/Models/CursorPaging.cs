using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class CursorPaging<T> : BasicModel
  {
    [JsonPropertyName("href")]
    public string Href { get; set; }

    [JsonPropertyName("items")]
    public List<T> Items { get; set; }

    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    [JsonPropertyName("next")]
    public string Next { get; set; }

    [JsonPropertyName("cursors")]
    public Cursor Cursors { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }

    public bool HasNext()
    {
      return !string.IsNullOrEmpty(Next);
    }
  }
}