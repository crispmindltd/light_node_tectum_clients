namespace Tectum.TectumLNodeClient.Responses
{
    public class GetTokensFeeResponse : BaseResponse
    {
        /// <summary>
        /// Amount of fee
        /// </summary>
        public decimal Fee { get; set; }
    }
}