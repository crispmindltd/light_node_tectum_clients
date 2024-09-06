using System.Text.Json.Serialization;

namespace Tectum.TectumLNodeClient.Responses
{
    /// <summary>
    /// Created transaction
    /// </summary>
    public class CreateCoinsTransferResponse : BaseResponse
    {
        [JsonPropertyName("hash")]
        public byte[]? Hash { get; set; }
    }
}