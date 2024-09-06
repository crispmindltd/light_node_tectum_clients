using System.Text.Json.Serialization;

namespace Tectum.TectumLNodeClient.Requests
{
    public class CreateTokensTransferRequest
    {
        [JsonPropertyName("from")]
        public string From { get; set; } = null!;

        [JsonPropertyName("to")]
        public string To { get; set; } = null!;

        [JsonPropertyName("smart_address")]
        public string SmartAddress { get; set; } = null!;

        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }

        [JsonPropertyName("private_key")]
        public string PrivateKey { get; set; } = null!;

        [JsonPropertyName("public_key")]
        public string PublicKey { get; set; } = null!;
    }
}
