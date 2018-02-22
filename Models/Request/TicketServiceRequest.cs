using System;

namespace ConceptaApi.Models.Request
{
    /// <summary>
    /// TicketServiceRequest
    /// </summary>
    public class TicketServiceRequest
    {
        /// <summary>
        /// Language
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// destination
        /// </summary>
        public string destination { get; set; }

        /// <summary>
        /// DataFrom
        /// </summary>
        public DateTime DateFrom { get; set; }

        /// <summary>
        /// DateTO
        /// </summary>
        public DateTime DateTO { get; set; }

        /// <summary>
        /// Occupancy
        /// </summary>
        public TicketServiceOccupancyRequest Occupancy { get; set; }
    }
}