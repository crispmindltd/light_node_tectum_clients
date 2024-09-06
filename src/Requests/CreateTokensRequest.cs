using System.Text.Json.Serialization;

namespace Tectum.TectumLNodeClient.Requests
{
    public class CreateTokensRequest
    {
        [JsonPropertyName("session_key")]
        public string SessionKey { get; set; } = null!;

        [JsonPropertyName("full_name")]
        public string FullName {  get; set; } = null!;

        [JsonPropertyName("short_name")]
        public string ShortName { get; set; } = null!;

        [JsonPropertyName("ticker")]
        public string Ticker { get; set; } = null!;

        [JsonPropertyName("token_amount")]
        public int TokenAmount { get; set; }

        [JsonPropertyName("decimals")]
        public int Decimals { get; set; }
    }
}
