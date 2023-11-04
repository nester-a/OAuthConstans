namespace OAuthConstans
{
    /// <summary>Represents error code from error response</summary>
    public static class ErrorResponseErrorCode
    {
        public const string AccessDenied = "access_denied";
        public const string InvalidRequest = "invalid_request";
        public const string InvalidClient = "invalid_client";
        public const string InvalidGrant = "invalid_grant";
        public const string UnauthorizedClient = "unauthorized_client";
        public const string UnsupportedGrantType = "unsupported_grant_type";
        public const string UnsupportedResponseType = "unsupported_response_type";
        public const string UnsupportedTokenType = "unsupported_token_type";
        public const string InvalidScope = "invalid_scope";
        public const string ServerError = "server_error";
        public const string TemporarilyUnavailable = "temporarily_unavailable";
    }
}
