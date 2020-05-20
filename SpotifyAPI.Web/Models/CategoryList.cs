using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class CategoryList : BasicModel
  {
    [JsonPropertyName("categories")]
    public Paging<Category> Categories { get; set; }
  }
}