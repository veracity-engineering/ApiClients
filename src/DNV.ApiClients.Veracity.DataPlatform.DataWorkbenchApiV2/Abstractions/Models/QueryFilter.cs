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
    public partial class QueryFilter
    {
        /// <summary>
        /// Initializes a new instance of the QueryFilter class.
        /// </summary>
        public QueryFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryFilter class.
        /// </summary>
        /// <param name="filterType">Possible values include: 'List', 'Equals',
        /// 'Greater', 'GreaterOrEqual', 'Less', 'LessOrEqual', 'NonFromList',
        /// 'StringContains'</param>
        public QueryFilter(string column = default, QueryFilterType? filterType = default, IEnumerable<string> filterValues = default)
        {
            Column = column;
            FilterType = filterType;
            FilterValues = filterValues;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "column")]
        public string Column { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'List', 'Equals', 'Greater',
        /// 'GreaterOrEqual', 'Less', 'LessOrEqual', 'NonFromList',
        /// 'StringContains'
        /// </summary>
        [JsonProperty(PropertyName = "filterType")]
        public QueryFilterType? FilterType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filterValues")]
        public IEnumerable<string> FilterValues { get; set; }

    }
}
