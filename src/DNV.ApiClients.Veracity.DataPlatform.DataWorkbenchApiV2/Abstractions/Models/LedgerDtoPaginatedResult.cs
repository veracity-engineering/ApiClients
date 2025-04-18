// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.DataPlatform.DataWorkbenchApiV2.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    public partial class LedgerDtoPaginatedResult
    {
        /// <summary>
        /// Initializes a new instance of the LedgerDtoPaginatedResult class.
        /// </summary>
        public LedgerDtoPaginatedResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LedgerDtoPaginatedResult class.
        /// </summary>
        public LedgerDtoPaginatedResult(int? pageIndex = default, int? pageSize = default, int? totalCount = default, int? totalPages = default, IEnumerable<LedgerDto> result = default)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = totalCount;
            TotalPages = totalPages;
            Result = result;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pageIndex")]
        public int? PageIndex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalCount")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalPages")]
        public int? TotalPages { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public IEnumerable<LedgerDto> Result { get; set; }

    }
}
