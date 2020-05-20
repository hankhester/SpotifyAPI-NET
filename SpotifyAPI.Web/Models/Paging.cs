using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class Paging<T> : BasicModel
  {
    [JsonPropertyName("href")]
    public string Href { get; set; }

    [JsonPropertyName("items")]
    public List<T> Items { get; set; }

    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    [JsonPropertyName("next")]
    public string Next { get; set; }

    [JsonPropertyName("offset")]
    public int Offset { get; set; }

    [JsonPropertyName("previous")]
    public string Previous { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }

    public bool HasNextPage()
    {
      return Next != null;
    }

    public bool HasPreviousPage()
    {
      return Previous != null;
    }
  }
}