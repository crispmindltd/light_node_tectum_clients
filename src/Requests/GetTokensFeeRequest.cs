using System.Text.Json.Serialization;

namespace Tectum.TectumLNodeClient.Requests
{
    /// <summary>
    /// Get fee for creating token
    /// </summary>
    public class GetTokensFeeRequest
    {
        /// <summary>
        /// Amount
        /// </summary>
        [JsonPropertyName("token_amount")]
        public long Amount { get; set; }
        
        /// <summary>
        /// Count decimal after comma
        /// </summary>
        [JsonPropertyName("decimals")]
        public int Decimals { get; set; }
    }
}