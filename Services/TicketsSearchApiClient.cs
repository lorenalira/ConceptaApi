using ConceptaApi.Models.Request;
using ConceptaApi.Models.Response;
using ConceptaApi.Models.Result;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConceptaApi.Services
{
    /// <summary>
    /// TicketsSearchApiClient
    /// </summary>
    public class TicketsSearchApiClient : ApiClient, ITicketsSearchApiClient
    {
        /// <summary>
        /// constructor
        /// </summary>
        public TicketsSearchApiClient() : base("http://travellogix.api.test.conceptsol.com") { }

        private static volatile ITicketsSearchApiClient _instance;
        private static object syncRoot = new object();


        /// <summary>
        /// GetTickets
        /// </summary>
        /// <param name="requestInfo"></param>
        /// <param name="access_token"></param>
        /// <returns></returns>
        public async Task<BaseApiResult<TicketSearchRawResult>> GetTickets(TicketServiceRequest requestInfo, string access_token)
        {
            var json = JsonConvert.SerializeObject(requestInfo, Formatting.Indented);
            using (var content = new StringContent(json, Encoding.UTF8, "application/json"))
            {
                return await Current.PostAsync<TicketSearchRawResult>("api/Ticket/Search", content, access_token);
            }
        }

        /// <summary>
        /// GetBearerToken
        /// </summary>
        /// <returns></returns>
        public async Task<BaseApiResult<BearerTokenResponse>> GetBearerToken()
        {
            var content = new StringContent("grant_type=password&username=test1%40test2.com&password=Aa234567%21", Encoding.UTF8, "application/json");
            return await Current.PostAsync<BearerTokenResponse>("Token", content);
        }

        /// <summary>
        /// Current Singleton Instance
        /// </summary>
        public static ITicketsSearchApiClient Current
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        _instance = new TicketsSearchApiClient();
                    }
                }
                return _instance;
            }
        }
    }
}