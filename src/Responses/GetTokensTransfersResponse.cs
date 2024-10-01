using System.Collections.Generic;
using Tectum.TectumLNodeClient.Responses.Dtos;

namespace Tectum.TectumLNodeClient.Responses
{
    /// <summary>
    /// List of transaction token 
    /// </summary>
    public class GetTokensTransfersResponse: BaseResponse
    {
        /// <summary>
        /// Ticker token
        /// </summary>
        public string Ticker { get; set; } =null!;
        
        /// <summary>
        /// List of transactions
        /// </summary>
        public List<TokenTransferDto>? Transactions { get; set; }
    }
}