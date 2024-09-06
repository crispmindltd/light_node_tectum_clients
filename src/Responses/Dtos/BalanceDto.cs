using System.Text.Json.Serialization;

namespace Tectum.TectumLNodeClient.Responses.Dtos
{
    /// <summary>
    /// Information about balance for token
    /// </summary>
    public class BalanceDto
    {
        /// <summary>
        /// Token ticker
        /// </summary>
        [JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Balance of current token
        /// </summary>
        [JsonPropertyName("balance")]
        public decimal? Balance { get; set; }

        /// <summary>
        /// Address token
        /// </summary>
        [JsonPropertyName("address_body")]
        public string? Address { get; set; }
    }
}
