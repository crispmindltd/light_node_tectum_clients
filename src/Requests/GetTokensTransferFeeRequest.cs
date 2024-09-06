namespace Tectum.TectumLNodeClient.Requests
{
    public class GetTokensTransferFeeRequest
    {
        /// <summary>
        /// Ticker of token
        /// </summary>
        public string Ticker { get; set; } = null!;
        
        /// <summary>
        /// Amount of transaction
        /// </summary>
        public decimal Amount { get; set; }
    }
}