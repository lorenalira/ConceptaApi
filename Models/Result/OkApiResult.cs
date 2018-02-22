namespace ConceptaApi.Models.Result
{
    /// <summary>
    /// OkApiResult T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class OkApiResult<T> : BaseApiResult<T>
    {
        /// <summary>
        /// constructor
        /// </summary>
        public OkApiResult()
        {
            Success = false;
            ModelState = null;
            Id = null;
        }

        /// <summary>
        /// OkApiResult
        /// </summary>
        /// <param name="data"></param>
        public OkApiResult(T data)
            : this()
        {
            Success = true;
            Data = data;
        }
    }
}