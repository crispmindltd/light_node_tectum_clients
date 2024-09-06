using System.Text.Json.Serialization;

namespace Tectum.TectumLNodeClient.Requests
{
    public class GetTokensBalanceAddressRequest
    {
        /// <summary>
        /// Address of main coin TET
        /// </summary>
        [JsonPropertyName("address_tet")]
        public string AddressTet { get; set; } = null!;
        
        /// <summary>
        /// Main address of token
        /// </summary>
        [JsonPropertyName("smart_address")]
        public string AddressToken { get; set; } = null!;
    }
}