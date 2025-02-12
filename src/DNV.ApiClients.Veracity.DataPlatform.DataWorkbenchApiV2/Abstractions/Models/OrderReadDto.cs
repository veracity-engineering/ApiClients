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
    public partial class OrderReadDto
    {
        /// <summary>
        /// Initializes a new instance of the OrderReadDto class.
        /// </summary>
        public OrderReadDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrderReadDto class.
        /// </summary>
        /// <param name="provider">Possible values include: 'GPM'</param>
        public OrderReadDto(System.Guid id = default, System.Guid workspaceId = default, string datasetName = default, string status = default, ProviderType? provider = default, System.DateTime createdDate = default, System.DateTime lastModifiedDate = default, IEnumerable<string> createdDatasetsId = default, object properties = default)
        {
            Id = id;
            WorkspaceId = workspaceId;
            DatasetName = datasetName;
            Status = status;
            Provider = provider;
            CreatedDate = createdDate;
            LastModifiedDate = lastModifiedDate;
            CreatedDatasetsId = createdDatasetsId;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workspaceId")]
        public System.Guid WorkspaceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datasetName")]
        public string DatasetName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'GPM'
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public ProviderType? Provider { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdDate")]
        public System.DateTime CreatedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedDate")]
        public System.DateTime LastModifiedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdDatasetsId")]
        public IEnumerable<string> CreatedDatasetsId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public object Properties { get; set; }

    }
}
