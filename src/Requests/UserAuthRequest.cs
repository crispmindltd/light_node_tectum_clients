using System.Text.Json.Serialization;

namespace Tectum.TectumLNodeClient.Requests
{
    /// <summary>
    /// User authorizate in Tectum System
    /// </summary>
    public class UserAuthRequest
    {
        [JsonPropertyName("login")]
        public string Login { get; set; } = null!;

        [JsonPropertyName("password")]
        public string Password { get; set; } = null!;
    }
}
