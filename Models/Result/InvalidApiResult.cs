using System;

namespace ConceptaApi.Models.Result
{
    /// <summary>
    /// InvalidApiResult T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class InvalidApiResult<T> : BaseApiResult<T>
    {
        /// <summary>
        /// constructor
        /// </summary>
        public InvalidApiResult() : base()
        {
            Success = false;
        }

        /// <summary>
        /// InvalidApiResult
        /// </summary>
        /// <param name="ex"></param>
        public InvalidApiResult(Exception ex) : base()
        {
            Success = false;
            Message = ex.Message;
        }
    }
}