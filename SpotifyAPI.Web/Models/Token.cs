using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Web.Models
{
  public class Token
  {
    public Token()
    {
      CreateDate = DateTime.Now;
    }

    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }

    [JsonPropertyName("token_type")]
    public string TokenType { get; set; }

    [JsonPropertyName("expires_in")]
    public double ExpiresIn { get; set; }

    [JsonPropertyName("refresh_token")]
    public string RefreshToken { get; set; }

    [JsonPropertyName("error")]
    public string Error { get; set; }

    [JsonPropertyName("error_description")]
    public string ErrorDescription { get; set; }

    public DateTime CreateDate { get; set; }

    /// <summary>
    ///     Checks if the token has expired
    /// </summary>
    /// <returns></returns>
    public bool IsExpired()
    {
      return CreateDate.Add(TimeSpan.FromSeconds(ExpiresIn)) <= DateTime.Now;
    }

    public bool HasError()
    {
      return Error != null;
    }
  }
}