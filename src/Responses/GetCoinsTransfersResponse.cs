using System.Collections.Generic;
using Tectum.TectumLNodeClient.Responses.Dtos;

namespace Tectum.TectumLNodeClient.Responses
{
    public class GetCoinsTransfersResponse : BaseResponse
    {
        public List<CoinTransferDto>? Transactions { get; set; }
    }
}