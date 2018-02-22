using System.Collections.Generic;

namespace ConceptaApi.Models.Response
{
    /// <summary>
    /// TicketServiceAvailableModalityResponse
    /// </summary>
    public class AvailableModalityResponse
    {
        /// <summary>
        /// Code
        /// </summary>
        public string Code { get; set; } = "0#CNX09/19";

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = "3 Days";

        /// <summary>
        /// Contract
        /// </summary>
        public string Contract { get; set; } = "2015WDWEURTO";

        /// <summary>
        /// ServicePrice
        /// </summary>
        public double ServicePrice { get; set; } = 656.08;

        /// <summary>
        /// OperationDateList
        /// </summary>
        public ICollection<OperationDateListResponse> OperationDateList { get; set; } = new List<OperationDateListResponse> { new OperationDateListResponse { }, new OperationDateListResponse { } };
    }
}