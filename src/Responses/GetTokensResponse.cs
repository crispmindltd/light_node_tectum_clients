using System.Collections.Generic;
using Tectum.TectumLNodeClient.Responses.Dtos;

namespace Tectum.TectumLNodeClient.Responses
{
    public class GetTokensResponse : BaseResponse
    {
        public List<TokenDto>? Tokens { get; set; }
    }
}