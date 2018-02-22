using System.Collections.Generic;

namespace ConceptaApi.Models.Response
{
    /// <summary>
    /// TicketSearchRawItemResponse
    /// </summary>
    public class TicketSearchRawItemResult
    {
        /// <summary>
        /// AvailableModality
        /// </summary>
        public ICollection<TicketSearchAvailableModalityResult> AvailableModality { get; set; }

        /// <summary>
        /// TicketInfo
        /// </summary>
        public TicketSearchTicketInfoResult TicketInfo { get; set; }
    }

    /// <summary>
    /// TicketSearchAvailableModalityResult
    /// </summary>
    public class TicketSearchAvailableModalityResult
    {
        /// <summary>
        /// Code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Contract
        /// </summary>
        public TicketSearchContractResult Contract { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// OperationDateList
        /// </summary>
        public ICollection<TicketSearchOperationDateListResult> OperationDateList { get; set; }

        /// <summary>
        /// PriceList
        /// </summary>
        public ICollection<TicketSearchPriceListResult> PriceList { get; set; }
    }

    /// <summary>
    /// TicketSearchOperationDateListResult
    /// </summary>
    public class TicketSearchOperationDateListResult
    {
        /// <summary>
        /// MaximumDuration
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// MinimumDuration
        /// </summary>
        public int MinimumDuration { get; set; }

        /// <summary>
        /// MaximumDuration
        /// </summary>
        public int MaximumDuration { get; set; }
    }

    /// <summary>
    /// TicketSearchPriceListResult
    /// </summary>
    public class TicketSearchPriceListResult
    {
        /// <summary>
        /// Amount
        /// </summary>
        public double Amount { get; set; }
    }

    /// <summary>
    /// TicketSearchContractResult
    /// </summary>
    public class TicketSearchContractResult
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }
    }

    /// <summary>
    /// TicketSearchTicketInfoResult
    /// </summary>
    public class TicketSearchTicketInfoResult
    {
        /// <summary>
        /// Code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Classification
        /// </summary>
        public TicketSearchClassificationResult Classification { get; set; }

        /// <summary>
        /// Destination
        /// </summary>
        public TicketSearchDestinationResult Destination { get; set; }

        /// <summary>
        /// TicketSearchDescriptionListResult
        /// </summary>
        public ICollection<TicketSearchDescriptionListResult> DescriptionList { get; set; }

        /// <summary>
        /// TicketSearchImageListResult
        /// </summary>
        public ICollection<TicketSearchImageListResult> ImageList { get; set; }
    }

    /// <summary>
    /// TicketSearchImageListResult
    /// </summary>
    public class TicketSearchImageListResult
    {
        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Order
        /// </summary>
        public int Order { get; set; }
    }

    /// <summary>
    /// TicketSearchDescriptionListResult
    /// </summary>
    public class TicketSearchDescriptionListResult
    {
        /// <summary>
        /// Value
        /// </summary>
        public string Value { get; set; }
    }

    /// <summary>
    /// TicketSearchDestinationResult
    /// </summary>
    public class TicketSearchDestinationResult
    {
        /// <summary>
        /// Code
        /// </summary>
        public string Code { get; set; }
    }

    /// <summary>
    /// TicketSearchClassificationResult
    /// </summary>
    public class TicketSearchClassificationResult
    {
        /// <summary>
        /// Value
        /// </summary>
        public string Value { get; set; }
    }
}