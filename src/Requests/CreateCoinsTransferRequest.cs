using System.Text.Json.Serialization;

namespace Tectum.TectumLNodeClient.Requests
{
    public class CreateCoinsTransferRequest
    {
        [JsonPropertyName("session_key")] 
        public string SessionKey { get; set; } = null!;

        /// <summary>
        /// Address reciever
        /// </summary>
        [JsonPropertyName("to")]
        public string AddressTo { get; set; } = null!;

        /// <summary>
        /// Transaction amount
        /// </summary>
        [JsonPropertyName("amount")]
        public double Amount { get; set; }
    }
}
