using System.Text.Json.Serialization;

namespace Tectum.TectumLNodeClient.Requests
{
    public class GetTokensBalanceTickerRequest
    {
        /// <summary>
        /// Address of main coin TET
        /// </summary>
        [JsonPropertyName("address_tet")]
        public string AddressTet { get; set; } = null!;
        
        /// <summary>
        /// Token ticker
        /// </summary>
        [JsonPropertyName("ticker")]
        public string Ticker { get; set; } = null!;
    }
}