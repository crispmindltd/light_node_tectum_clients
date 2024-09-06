using System.Text.Json.Serialization;

namespace Tectum.TectumLNodeClient.Responses
{
    public class GetKeyPublicResponse : BaseResponse
    {
        [JsonPropertyName("public_key")]
        public string? PublicKey { get; set; }
    }
}
