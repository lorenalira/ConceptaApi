namespace ConceptaApi.Models
{
    /// <summary>
    /// BaseResult
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    public class BaseResult<TResult> where TResult : class
    {
        /// <summary>
        /// result
        /// </summary>
        public TResult result { get; set; }

        /// <summary>
        /// empty constructor
        /// </summary>
        public BaseResult() { }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="_result"></param>
        public BaseResult(TResult _result)
        {
            result = _result;
        }
    }
}