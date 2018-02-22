using ConceptaApi.Models.Request;
using ConceptaApi.Models.Response;
using ConceptaApi.Models.Result;
using System.Threading.Tasks;

namespace ConceptaApi.Services
{
    /// <summary>
    /// ITicketsSearchApiClient
    /// </summary>
    public interface ITicketsSearchApiClient : IApiClient
    {
        /// <summary>
        /// GetTickets
        /// </summary>
        /// <param name="requestInfo"></param>
        /// <param name="access_token"></param>
        /// <returns></returns>
        Task<BaseApiResult<TicketSearchRawResult>> GetTickets(TicketServiceRequest requestInfo, string access_token);

        /// <summary>
        /// GetBearerToken
        /// </summary>
        /// <returns></returns>
        Task<BaseApiResult<BearerTokenResponse>> GetBearerToken();
    }
}