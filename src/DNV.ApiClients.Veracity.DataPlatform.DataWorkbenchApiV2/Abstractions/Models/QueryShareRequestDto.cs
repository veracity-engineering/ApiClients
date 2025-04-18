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
    public partial class QueryShareRequestDto
    {
        /// <summary>
        /// Initializes a new instance of the QueryShareRequestDto class.
        /// </summary>
        public QueryShareRequestDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryShareRequestDto class.
        /// </summary>
        /// <param name="sortDirection">Possible values include: 'Ascending',
        /// 'Descending'</param>
        public QueryShareRequestDto(int? pageIndex = default, int? pageSize = default, string sortColumn = default, SortDirection? sortDirection = default, bool? isRequestor = default, IEnumerable<System.Guid?> schemaIds = default, IEnumerable<System.Guid?> schemaVersionIds = default, IEnumerable<System.Guid?> workspaceIds = default, IEnumerable<ShareRequestStatusDto?> statuses = default)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            SortColumn = sortColumn;
            SortDirection = sortDirection;
            IsRequestor = isRequestor;
            SchemaIds = schemaIds;
            SchemaVersionIds = schemaVersionIds;
            WorkspaceIds = workspaceIds;
            Statuses = statuses;
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
        [JsonProperty(PropertyName = "sortColumn")]
        public string SortColumn { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Ascending', 'Descending'
        /// </summary>
        [JsonProperty(PropertyName = "sortDirection")]
        public SortDirection? SortDirection { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isRequestor")]
        public bool? IsRequestor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schemaIds")]
        public IEnumerable<System.Guid?> SchemaIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schemaVersionIds")]
        public IEnumerable<System.Guid?> SchemaVersionIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workspaceIds")]
        public IEnumerable<System.Guid?> WorkspaceIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuses")]
        public IEnumerable<ShareRequestStatusDto?> Statuses { get; set; }

    }
}
