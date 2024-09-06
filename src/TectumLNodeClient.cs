using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Tectum.TectumLNodeClient.Requests;
using Tectum.TectumLNodeClient.Responses;

namespace Tectum.TectumLNodeClient
{
    public class TectumLNodeClient : BaseHttpClient, ITectumLNodeClient
    {
        public TectumLNodeClient(HttpClient httpClient) : base(httpClient)
        {
        }

        public TectumLNodeClient(HttpClient httpClient, JsonSerializerOptions jsonSerializerOptions) : base(httpClient,
            jsonSerializerOptions)
        {
        }

        public Task<GetCoinBalancesResponse?> GetCoinBalancesAsync(GetCoinsBalancesRequest request,
            CancellationToken cancellationToken = default)
        {
            var param = new Dictionary<string, string>
            {
                { "address_tet", request.AddressTet }
            };
            return GetAsync<GetCoinBalancesResponse>("coins/balances", param, cancellationToken);
        }

        public Task<CreateCoinsTransferResponse?> CreateCoinTransferAsync(CreateCoinsTransferRequest request,
            CancellationToken cancellationToken = default)
        {
            return SendRequestAsync<CreateCoinsTransferResponse>("coins/transfer", HttpMethod.Post, request,
                cancellationToken);
        }

        public Task<GetCoinsTransfersResponse?> GetCoinTransfersAsync(GetCoinsTransfersRequest request,
            CancellationToken cancellationToken = default)
        {
            var param = new Dictionary<string, string>
            {
                { "rows", request.Rows.ToString() },
                { "skip", request.Skip.ToString() }
            };
            return GetAsync<GetCoinsTransfersResponse>("coins/transfers", param, cancellationToken);
        }

        public Task<GetCoinsTransfersResponse?> GetCoinTransfersUserAsync(GetCoinsTransfersUserRequest request,
            CancellationToken cancellationToken = default)
        {
            var param = new Dictionary<string, string>
            {
                { "rows", request.Rows.ToString() },
                { "skip", request.Skip.ToString() },
                { "session_key", request.SessionKey }
            };
            return GetAsync<GetCoinsTransfersResponse>("coins/transfers/user", param, cancellationToken);
        }

        public Task<GetCoinsTransferFeeResponse?> GetCoinTransferFeeAsync(CancellationToken cancellationToken = default)
        {
            return GetAsync<GetCoinsTransferFeeResponse>("coins/transfers/fee", new Dictionary<string, string>(),
                cancellationToken);
        }

        public Task<GetBlocksCountResponse?> GetBlocksCountAsync(CancellationToken cancellationToken = default)
        {
            return GetAsync<GetBlocksCountResponse>("blockscount", new Dictionary<string, string>(), cancellationToken);
        }

        public Task<UserRegistrationResponse?> UserRegistrationAsync(UserRegistrationRequest request,
            CancellationToken cancellationToken = default)
        {
            return SendRequestAsync<UserRegistrationResponse>("user/registration", HttpMethod.Post, request,
                cancellationToken);
        }

        public Task<UserAuthResponse?> UserAuthAsync(UserAuthRequest request,
            CancellationToken cancellationToken = default)
        {
            return SendRequestAsync<UserAuthResponse>("user/auth", HttpMethod.Post, request,
                cancellationToken);
        }

        public Task<KeyRecoverResponse?> KeyRecoverAsync(KeyRecoverRequest request,
            CancellationToken cancellationToken = default)
        {
            return SendRequestAsync<KeyRecoverResponse>("keys/recover", HttpMethod.Post, request,
                cancellationToken);
        }

        public Task<GetKeyPublicResponse?> GetKeyPublicUserAsync(GetKeyPublicUserRequest request,
            CancellationToken cancellationToken = default)
        {
            var param = new Dictionary<string, string>
            {
                { "user_id", request.UserId.ToString() }
            };

            return GetAsync<GetKeyPublicResponse>("keys/public/byuserid", param, cancellationToken);
        }

        public Task<GetKeyPublicResponse?> GetKeyPublicSessionKeyAsync(GetKeyPublicSessionKeyRequest request,
            CancellationToken cancellationToken = default)
        {
            var param = new Dictionary<string, string>
            {
                { "session_key", request.SessionKey }
            };

            return GetAsync<GetKeyPublicResponse>("keys/public/byskey", param, cancellationToken);
        }

        public Task<GetTokensResponse?> GetTokensAsync(CancellationToken cancellationToken = default)
        {
            return GetAsync<GetTokensResponse>("tokens", new Dictionary<string, string>(), cancellationToken);
        }

        public Task<CreateTokensResponse?> CreateTokensAsync(CreateTokensRequest request,
            CancellationToken cancellationToken = default)
        {
            return SendRequestAsync<CreateTokensResponse>("tokens", HttpMethod.Post, request, cancellationToken);
        }

        public Task<GetTokensFeeResponse?> GetTokensFeeAsync(GetTokensFeeRequest request,
            CancellationToken cancellationToken = default)
        {
            var param = new Dictionary<string, string>
            {
                { "token_amount", request.Amount.ToString() },
                { "decimals", request.Decimals.ToString() }
            };

            return GetAsync<GetTokensFeeResponse>("tokens/fee", param, cancellationToken);
        }

        public Task<CreateTokensTransferResponse?> CreateTokensTransferAsync(CreateTokensTransferRequest request,
            CancellationToken cancellationToken = default)
        {
            return SendRequestAsync<CreateTokensTransferResponse>("tokens/transfer", HttpMethod.Post, request,
                cancellationToken);
        }

        public Task<GetTokensTransferFeeResponse?> GetTokensTransferFeeAsync(GetTokensTransferFeeRequest request,
            CancellationToken cancellationToken = default)
        {
            var param = new Dictionary<string, string>
            {
                { "ticker", request.Ticker },
                { "amount", request.Amount.ToString(CultureInfo.InvariantCulture) }
            };

            return GetAsync<GetTokensTransferFeeResponse>("tokens/transfer/fee", param, cancellationToken);
        }

        public Task<GetTokensBalanceAddressResponse?> GetTokensBalanceAddressAsync(
            GetTokensBalanceAddressRequest request,
            CancellationToken cancellationToken = default)
        {
            var param = new Dictionary<string, string>
            {
                { "address_tet", request.AddressTet },
                { "smart_address", request.AddressToken }
            };

            return GetAsync<GetTokensBalanceAddressResponse>("tokens/balance/byaddress", param, cancellationToken);
        }

        public Task<GetTokensBalanceAddressResponse?> GetTokensBalanceTickerAsync(GetTokensBalanceTickerRequest request,
            CancellationToken cancellationToken = default)
        {
            var param = new Dictionary<string, string>
            {
                { "address_tet", request.AddressTet },
                { "ticker", request.Ticker }
            };

            return GetAsync<GetTokensBalanceAddressResponse>("tokens/balance/byticker", param, cancellationToken);
        }

        public Task<GetTokensAddressResponse?> GetTokensAddressIdAsync(GetTokensAddressIdRequest request,
            CancellationToken cancellationToken = default)
        {
            var param = new Dictionary<string, string>
            {
                { "smart_id", request.TokenId.ToString() }
            };

            return GetAsync<GetTokensAddressResponse>("tokens/address/byid", param, cancellationToken);
        }

        public Task<GetTokensAddressResponse?> GetTokensAddressTickerAsync(GetTokensAddressTickerRequest request,
            CancellationToken cancellationToken = default)
        {
            var param = new Dictionary<string, string>
            {
                { "ticker", request.Ticker }
            };

            return GetAsync<GetTokensAddressResponse>("tokens/address/byticker", param, cancellationToken);
        }
    }
}