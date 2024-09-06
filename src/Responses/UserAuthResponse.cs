using System.Text.Json.Serialization;

namespace Tectum.TectumLNodeClient.Responses
{
    public class UserAuthResponse : BaseResponse
    {
        [JsonPropertyName("session_key")]
        public string? SessionKey { get; set; }
    }
}