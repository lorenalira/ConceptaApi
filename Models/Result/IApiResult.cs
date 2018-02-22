namespace ConceptaApi.Models.Result
{
    /// <summary>
    /// IApiResult
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IApiResult<T> : IApiMinify
    {
        /// <summary>
        /// Success
        /// </summary>
        bool Success { get; set; }

        /// <summary>
        /// T Data
        /// </summary>
        T Data { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// ModelState
        /// </summary>
        object ModelState { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        string Url { get; set; }
    }
}