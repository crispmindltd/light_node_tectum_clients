using System.Text.Json.Serialization;

namespace Tectum.TectumLNodeClient.Responses
{
    public class CreateTokensTransferResponse : BaseResponse
    {
        [JsonPropertyName("Hash")]
        public byte[]? Hash { get; set; }
    }
}
