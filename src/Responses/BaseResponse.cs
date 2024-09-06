using System.Text.Json.Serialization;

namespace Tectum.TectumLNodeClient.Responses
{
    public class BaseResponse
    {
        [JsonPropertyName("error")]
        public string? Error { get; set; }
        
        [JsonPropertyName("message")]
        public string? Message { get; set; }

        public bool HasError => !string.IsNullOrEmpty(Error);
    }
}