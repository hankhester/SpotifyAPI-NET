using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class AvailabeDevices : BasicModel
  {
    [JsonPropertyName("devices")]
    public List<Device> Devices { get; set; }
  }
}