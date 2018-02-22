namespace ConceptaApi.Models.Request
{
    /// <summary>
    /// TicketServiceOccupancyRequest
    /// </summary>
    public class TicketServiceOccupancyRequest
    {
        /// <summary>
        /// AdultCount
        /// </summary>
        public int AdultCount { get; set; }

        /// <summary>
        /// ChildCount
        /// </summary>
        public int ChildCount { get; set; }

        /// <summary>
        /// ChildAges
        /// </summary>
        public int[] ChildAges { get; set; }
    }
}