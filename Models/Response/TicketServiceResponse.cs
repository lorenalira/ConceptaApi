using System.Collections.Generic;

namespace ConceptaApi.Models.Response
{
    /// <summary>
    /// TicketServiceResponse
    /// </summary>
    public class TicketServiceResponse
    {
        /// <summary>
        /// Destination
        /// </summary>
        public string Destination { get; set; } = "";

        /// <summary>
        /// Code
        /// </summary>
        public string Code { get; set; } = "";

        /// <summary>
        /// Classification
        /// </summary>
        public string Classification { get; set; } = "";

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; } = "";

        /// <summary>
        /// ImageThumb
        /// </summary>
        public string ImageThumb { get; set; } = "";

        /// <summary>
        /// ImageFull
        /// </summary>
        public string ImageFull { get; set; } = "";

        /// <summary>
        /// AvailableModality
        /// </summary>
        public ICollection<AvailableModalityResponse> AvailableModality { get; set; } = new List<AvailableModalityResponse> { new AvailableModalityResponse { }, new AvailableModalityResponse { } };
    }
}