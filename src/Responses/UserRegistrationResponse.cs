using System.Text.Json.Serialization;

namespace Tectum.TectumLNodeClient.Responses
{
    public class UserRegistrationResponse : BaseResponse
    {
        [JsonPropertyName("client_ID")]
        public int ClientId { get; set; }

        [JsonPropertyName("login")]
        public string? Login { get; set; }

        [JsonPropertyName("password")]
        public string? Password { get; set; }

        [JsonPropertyName("address")]
        public string? Address { get; set; }

        [JsonPropertyName("private_key")]
        public string? PrivateKey { get; set; }

        [JsonPropertyName("public_key")]
        public string? PublicKey { get; set; }
    }
}
