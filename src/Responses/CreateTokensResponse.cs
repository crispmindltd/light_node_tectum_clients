using System.Text.Json.Serialization;

namespace Tectum.TectumLNodeClient.Responses
{
    public class CreateTokensResponse : BaseResponse
    {
        [JsonPropertyName("transaction_hash")] 
        public byte[]? TransactionHash { get; set; }

        [JsonPropertyName("smartcontract_ID")]
        public long? Id { get; set; }
    }
}