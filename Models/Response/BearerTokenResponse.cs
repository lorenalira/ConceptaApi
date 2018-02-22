namespace ConceptaApi.Models.Response
{
    /// <summary>
    /// BearerTokenResponse
    /// </summary>
    public sealed class BearerTokenResponse
    {
        /// <summary>
        /// access_token
        /// </summary>
        public string access_token { get; set; }

        /// <summary>
        /// token_type
        /// </summary>
        public string token_type { get; set; }

        /// <summary>
        /// expires_in
        /// </summary>
        public int expires_in { get; set; }

        /// <summary>
        /// userName
        /// </summary>
        public string userName { get; set; }
    }
}