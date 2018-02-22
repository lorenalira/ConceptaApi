using ConceptaApi.Models.Request;
using ConceptaApi.Models.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConceptaApi.Services
{
    /// <summary>
    /// ITicketSearchService
    /// </summary>
    public interface ITicketSearchService
    {
        /// <summary>
        /// GetTickets
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<IEnumerable<TicketServiceResponse>> GetTickets(TicketServiceRequest request);
    }
}