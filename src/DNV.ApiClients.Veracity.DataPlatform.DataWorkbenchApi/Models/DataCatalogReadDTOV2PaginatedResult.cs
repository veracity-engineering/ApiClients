// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataWorkbenchApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class DataCatalogReadDTOV2PaginatedResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DataCatalogReadDTOV2PaginatedResult class.
        /// </summary>
        public DataCatalogReadDTOV2PaginatedResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DataCatalogReadDTOV2PaginatedResult class.
        /// </summary>
        public DataCatalogReadDTOV2PaginatedResult(int? pageIndex = default, int? pageSize = default, int? totalCount = default, int? totalPages = default, IEnumerable<DataCatalogReadDTOV2> result = default)
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
        public IEnumerable<DataCatalogReadDTOV2> Result { get; set; }

    }
}
