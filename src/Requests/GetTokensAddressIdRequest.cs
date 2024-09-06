using System.Text.Json.Serialization;

namespace Tectum.TectumLNodeClient.Requests
{
    public class GetTokensAddressIdRequest
    {
        /// <summary>
        /// Get address token by id token
        /// </summary>
        [JsonPropertyName("smart_id")]
        public long TokenId { get; set; }
    }
}