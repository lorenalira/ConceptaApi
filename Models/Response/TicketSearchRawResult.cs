using System.Collections.Generic;

namespace ConceptaApi.Models.Response
{
    /// <summary>
    /// TicketSearchRawResult
    /// </summary>
    public class TicketSearchRawResult
    {
        /// <summary>
        /// Code
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// ErrorMessage
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Result
        /// </summary>
        public ICollection<TicketSearchRawItemResult> Result { get; set; }
    }
}