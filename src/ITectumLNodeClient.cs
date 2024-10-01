using System.Threading;
using System.Threading.Tasks;
using Tectum.TectumLNodeClient.Requests;
using Tectum.TectumLNodeClient.Responses;

namespace Tectum.TectumLNodeClient
{
    /// <summary>
    /// Interface of methods to access to Tectum light node
    /// </summary>
    public interface ITectumLNodeClient
    {
        #region /coins

        /// <summary>
        /// Retrieve balances for multiple tokens: GET /coins/balances 
        /// </summary>
        /// <param name="request">Data of coin address</param>
        /// <param name="cancellationToken"></param>
        /// <returns>All tokens balances for current address</returns>
        Task<GetCoinBalancesResponse?> GetCoinBalancesAsync(
            GetCoinsBalancesRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Create transaction of TET coin: POST /coins/transfer
        /// </summary>
        /// <param name="request">Data of transaction</param>
        /// <param name="cancellationToken"></param>
        /// <returns>Hash of success transaction</returns>
        Task<CreateCoinsTransferResponse?> CreateCoinTransferAsync(
            CreateCoinsTransferRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Get list of transactions of TET coin: GET /coins/transfers
        /// </summary>
        /// <param name="request">Filter options</param>
        /// <param name="cancellationToken"></param>
        /// <returns>List of transactions</returns>
        Task<GetCoinsTransfersResponse?> GetCoinTransfersAsync(
            GetCoinsTransfersRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Get list of transactions of TET coin: GET /coins/transfers/user
        /// </summary>
        /// <param name="request">Filter options</param>
        /// <param name="cancellationToken"></param>
        /// <returns>List of transactions</returns>
        Task<GetCoinsTransfersResponse?> GetCoinTransfersUserAsync(
            GetCoinsTransfersUserRequest request,
            CancellationToken cancellationToken = default);


        /// <summary>
        /// Get transaction  fee of TET coin: GET /coins/transfers/fee
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>Fee of transaction</returns>
        Task<GetCoinsTransferFeeResponse?> GetCoinTransferFeeAsync(
            CancellationToken cancellationToken = default);

        #endregion

        #region Block

        /// <summary>
        /// Get count of blokcs in TET coin blockchain: POST /coins/transfer/fee
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>Fee of transaction</returns>
        Task<GetBlocksCountResponse?> GetBlocksCountAsync(
            CancellationToken cancellationToken = default);

        #endregion

        #region User

        /// <summary>
        /// Create new user in Tectum system: POST /user/registration
        /// </summary>
        /// <param name="request">Information about user</param>
        /// <param name="cancellationToken"></param>
        /// <returns>Get full information about user like public key, private key and so on</returns>
        Task<UserRegistrationResponse?> UserRegistrationAsync(
            UserRegistrationRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Get session key for user in Tectum system: POST /user/auth
        /// </summary>
        /// <param name="request">Information about user</param>
        /// <param name="cancellationToken"></param>
        /// <returns>Get session key for net operations</returns>
        Task<UserAuthResponse?> UserAuthAsync(
            UserAuthRequest request,
            CancellationToken cancellationToken = default);

        #endregion

        #region Keys

        /// <summary>
        /// Recovery private and public keys to access to Tectum system: POST /keys/recover
        /// </summary>
        /// <param name="request">Information about key</param>
        /// <param name="cancellationToken"></param>
        /// <returns>Get keys for</returns>
        Task<KeyRecoverResponse?> KeyRecoverAsync(
            KeyRecoverRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Get public key for user: GET /keys/public/byuserid
        /// </summary>
        /// <param name="request">Information about key</param>
        /// <param name="cancellationToken"></param>
        /// <returns>Get keys for</returns>
        Task<GetKeyPublicResponse?> GetKeyPublicUserAsync(
            GetKeyPublicUserRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Get public key for session key: GET /keys/public/byskey
        /// </summary>
        /// <param name="request">Information about key</param>
        /// <param name="cancellationToken"></param>
        /// <returns>Get keys for</returns>
        Task<GetKeyPublicResponse?> GetKeyPublicSessionKeyAsync(
            GetKeyPublicSessionKeyRequest request,
            CancellationToken cancellationToken = default);

        #endregion

        #region Tokens

        /// <summary>
        /// Get token information: GET /tokens
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>Get keys for</returns>
        Task<GetTokensResponse?> GetTokensAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get token's transactions information: GET /tokens/transfers
        /// </summary>
        /// <param name="request">Filter transactions</param>
        /// <param name="cancellationToken"></param>
        /// <returns>Get keys for</returns>
        Task<GetTokensTransfersResponse?> GetTokensTransfersAsync(GetTokensTransfersRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Create new token: POST /tokens
        /// </summary>
        /// <param name="request">Information about key</param>
        /// <param name="cancellationToken"></param>
        /// <returns>Get keys for</returns>
        Task<CreateTokensResponse?> CreateTokensAsync(
            CreateTokensRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Get fee for create token: GET /tokens/fee
        /// </summary>
        /// <param name="request">Information </param>
        /// <param name="cancellationToken"></param>
        /// <returns>Get fee</returns>
        Task<GetTokensFeeResponse?> GetTokensFeeAsync(GetTokensFeeRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Create transfer token: POST /tokens/transfer
        /// </summary>
        /// <param name="request">Information </param>
        /// <param name="cancellationToken"></param>
        /// <returns>Get fee</returns>
        Task<CreateTokensTransferResponse?> CreateTokensTransferAsync(CreateTokensTransferRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Get fee for transfer tokens: GET /tokens/transfer/fee
        /// </summary>
        /// <param name="request">Information of transaction</param>
        /// <param name="cancellationToken"></param>
        /// <returns>Get fee</returns>
        Task<GetTokensTransferFeeResponse?> GetTokensTransferFeeAsync(GetTokensTransferFeeRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Get balance by address: GET /tokens/balance/byaddress
        /// </summary>
        /// <param name="request">Information of address</param>
        /// <param name="cancellationToken"></param>
        /// <returns>Get balance</returns>
        Task<GetTokensBalanceAddressResponse?> GetTokensBalanceAddressAsync(GetTokensBalanceAddressRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Get balance by ticker token: GET /tokens/balance/byticker
        /// </summary>
        /// <param name="request">Ticker information</param>
        /// <param name="cancellationToken"></param>
        /// <returns>Get balance</returns>
        Task<GetTokensBalanceAddressResponse?> GetTokensBalanceTickerAsync(GetTokensBalanceTickerRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Get address by ticker token: GET /tokens/address/byid
        /// </summary>
        /// <param name="request">Id token</param>
        /// <param name="cancellationToken"></param>
        /// <returns>Get address</returns>
        Task<GetTokensAddressResponse?> GetTokensAddressIdAsync(GetTokensAddressIdRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Get address by ticker token: GET /tokens/address/byticker
        /// </summary>
        /// <param name="request">Id token</param>
        /// <param name="cancellationToken"></param>
        /// <returns>Get address</returns>
        Task<GetTokensAddressResponse?> GetTokensAddressTickerAsync(GetTokensAddressTickerRequest request,
            CancellationToken cancellationToken = default);

        #endregion
    }
}