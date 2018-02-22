namespace ConceptaApi.Models.Result
{
    /// <summary>
    /// BaseApiResult
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseApiResult<T> : IApiResult<T>
    {
        /// <summary>
        /// constructor
        /// </summary>
        public BaseApiResult() { }

        /// <summary>
        /// T Data
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// ModelState
        /// </summary>
        public object ModelState { get; set; }

        /// <summary>
        /// Success
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Minify
        /// </summary>
        /// <returns></returns>
        public virtual object Minify() => this;
    }
}