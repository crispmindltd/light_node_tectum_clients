using System.Text.Json.Serialization;

namespace Tectum.TectumLNodeClient.Responses
{
    public class GetTokensAddressResponse : BaseResponse
    {
        [JsonPropertyName("smart_address")]
        public string? TokenAddress { get; set; }
    }
}