using ConceptaApi.Models.Request;
using ConceptaApi.Models.Response;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Globalization;

namespace ConceptaApi.Services
{
    /// <summary>
    /// Ticket Search Service
    /// </summary>
    public class TicketSearchService : ITicketSearchService
    {
        private readonly ITicketsSearchApiClient client;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="_client"></param>
        public TicketSearchService(ITicketsSearchApiClient _client)
        {
            client = _client;
        }

        /// <summary>
        /// GetTickets
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<IEnumerable<TicketServiceResponse>> GetTickets(TicketServiceRequest request)
        {
            var bearerResponse = await client.GetBearerToken();
            if (bearerResponse.Success)
            {
                var access_token = bearerResponse.Data.access_token;
                var ticketsResponse = await client.GetTickets(request, access_token);
                if (ticketsResponse.Success)
                {
                    return ticketsResponse.Data.Result.ToList().Select(t => new TicketServiceResponse
                    {
                        Destination = t.TicketInfo.Destination.Code,
                        Code = t.TicketInfo.Code,
                        Classification = t.TicketInfo.Classification.Value,
                        Name = t.TicketInfo.Name,
                        Description = t.TicketInfo.DescriptionList.FirstOrDefault().Value,
                        ImageThumb = t.TicketInfo.ImageList.Where(i => i.Type.Equals("S")).OrderByDescending(i => i.Order).FirstOrDefault().Url,
                        ImageFull = t.TicketInfo.ImageList.Where(i => i.Type.Equals("L")).OrderByDescending(i => i.Order).FirstOrDefault().Url,
                        AvailableModality = AvailableModality(t.AvailableModality).ToList(),
                    }).ToList();
                }
            }
            return null;  
        }

        private IEnumerable<AvailableModalityResponse> AvailableModality(ICollection<TicketSearchAvailableModalityResult> availableModality)
        {
            foreach (var item in availableModality)
            {
                yield return new AvailableModalityResponse
                {
                    Code = item.Code,
                    Contract = item.Contract.Name,
                    Name = item.Name,
                    ServicePrice = Math.Round(item.PriceList.Sum(p => p.Amount), 2),
                    OperationDateList = OperationDateList(item.OperationDateList).ToList()
                };
            }            
        }

        private IEnumerable<OperationDateListResponse> OperationDateList(ICollection<TicketSearchOperationDateListResult> operationDateList)
        {
            foreach (var item in operationDateList)
            {
                var data = DateTime.ParseExact(item.Date, "yyyyMMdd", CultureInfo.InvariantCulture);
                yield return new OperationDateListResponse
                {                    
                    To = data.AddDays(item.MaximumDuration).ToString("MM/dd/yyyy"),
                    From = data.ToString("MM/dd/yyyy"),
                };
            }
        }
    }
}