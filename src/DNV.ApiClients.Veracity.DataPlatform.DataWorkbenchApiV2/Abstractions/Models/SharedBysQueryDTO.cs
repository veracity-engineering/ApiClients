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
    public partial class SharedBysQueryDTO
    {
        /// <summary>
        /// Initializes a new instance of the SharedBysQueryDTO class.
        /// </summary>
        public SharedBysQueryDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SharedBysQueryDTO class.
        /// </summary>
        public SharedBysQueryDTO(IEnumerable<System.Guid> datasetIds = default)
        {
            DatasetIds = datasetIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datasetIds")]
        public IEnumerable<System.Guid> DatasetIds { get; set; }

    }
}