## Endpoints ##

The Light Node supports the following types of requests:

### Token operations: ###

-   GET /tokens: Retrieve a list of all tokens
-   POST /tokens: Create a new token
-   GET /tokens/fee: Retrieve fee of creating token
-   GET /tokens/ticker: Retrieve information about a specific token
-   POST /tokens/transfer: Transfer tokens
-   GET /tokens/transfer/fee: Retrieve fee of token transfer
-   GET /tokens/transfers: Retrieve token transfer history
-   GET /tokens/address/byid: Retrieve the smart contract address by ID
-   GET /tokens/address/byticker: Retrieve the smart contract address by ticker
-   GET /tokens/balance/byaddress: Retrieve token balance by address
-   GET /tokens/balance/byticker: Retrieve token balance by ticker

### TET operations: ###

-   GET /coins/balances: Retrieve balances for multiple tokens
-   POST /coins/transfer: Transfer TET
-   GET /coins/transfers: Retrieve TET transfer history
-   GET /coins/transfers/user: Retrieve TET transfer history for user
-   GET /coins/transfers/fee: Retrieve fee for transfer

### User management: ###

-   POST /user/auth: User authentication
-   POST /user/registration: Register a new user

### Key management: ###

-   POST /keys/generate: Generate new keys
-   POST /keys/recover: Recover keys using a seed phrase
-   GET /keys/public/byuserid: Retrieve the public key by user ID
-   GET /keys/public/byskey: Retrieve the public key by session key

### Blocks: ###

-   GET /blockscount: Retrieve count of blocks

