using System.Text.Json.Serialization;

namespace Tectum.TectumLNodeClient.Responses.Dtos
{
    public class TokenDto
    {
        public long Id { get; set; }
        
        [JsonPropertyName("owner_id")]
        public long OwnerId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        [JsonPropertyName("date")]
        public long Date { get; set; }

        [JsonPropertyName("ticker")]
        public string Ticker { get; set; } = null!;

        [JsonPropertyName("amount")]
        public long Amount { get; set; }
        
        [JsonPropertyName("decimals")]
        public long Decimals { get; set; }
        
        [JsonPropertyName("info")]
        public long Info { get; set; }
    }
}