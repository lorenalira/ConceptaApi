using ConceptaApi.Models.Response;
using System.Collections.Generic;

namespace ConceptaApi.Models
{
    /// <summary>
    /// TicketServiceResult
    /// </summary>
    public class TicketServiceResult : BaseResult<IEnumerable<TicketServiceResponse>>
    {
        /// <summary>
        /// empty constructor
        /// </summary>
        public TicketServiceResult() : base() { }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="_result"></param>
        public TicketServiceResult(IEnumerable<TicketServiceResponse> _result) : base(_result) { }

        /// <summary>
        /// Success
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public virtual TicketServiceResult Success(IEnumerable<TicketServiceResponse> result)
        {
            return new TicketServiceResult(result);
        }

        /// <summary>
        /// Error
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public virtual TicketServiceResult Error(string message)
        {
            return new TicketServiceResult(default(IEnumerable<TicketServiceResponse>));
        }
    }
}