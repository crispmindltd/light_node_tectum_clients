namespace Tectum.TectumLNodeClient.Requests
{
    /// <summary>
    /// Request get all transactions of token
    /// </summary>
    public class GetTokensTransfersRequest
    {
        /// <summary>
        /// Ticker 
        /// </summary>
        public string Ticker { get; set; } = null!;
        
        /// <summary>
        /// How many rows need to send
        /// </summary>
        public int Rows { get; set; }
        
        /// <summary>
        /// How many rows need to skip
        /// </summary>
        public long Skip { get; set; }
    }
}