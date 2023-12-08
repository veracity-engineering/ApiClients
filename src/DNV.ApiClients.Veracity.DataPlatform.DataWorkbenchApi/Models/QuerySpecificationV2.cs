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

    public partial class QuerySpecificationV2
    {
        /// <summary>
        /// Initializes a new instance of the QuerySpecificationV2 class.
        /// </summary>
        public QuerySpecificationV2()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QuerySpecificationV2 class.
        /// </summary>
        public QuerySpecificationV2(int pageIndex = default, int pageSize = default, IEnumerable<QueryFilter> queryFilters = default, IEnumerable<string> columnFilter = default, Sorting sorting = default)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            QueryFilters = queryFilters;
            ColumnFilter = columnFilter;
            Sorting = sorting;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pageIndex")]
        public int PageIndex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pageSize")]
        public int PageSize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queryFilters")]
        public IEnumerable<QueryFilter> QueryFilters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "columnFilter")]
        public IEnumerable<string> ColumnFilter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sorting")]
        public Sorting Sorting { get; set; }

    }
}
