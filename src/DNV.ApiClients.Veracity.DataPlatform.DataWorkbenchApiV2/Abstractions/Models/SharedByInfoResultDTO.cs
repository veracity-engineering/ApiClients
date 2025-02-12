// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.DataPlatform.DataWorkbenchApiV2.Models
{
    using Newtonsoft.Json;
    public partial class SharedByInfoResultDTO
    {
        /// <summary>
        /// Initializes a new instance of the SharedByInfoResultDTO class.
        /// </summary>
        public SharedByInfoResultDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SharedByInfoResultDTO class.
        /// </summary>
        public SharedByInfoResultDTO(System.Guid? datasetId = default, SharedByDTO sharedBy = default)
        {
            DatasetId = datasetId;
            SharedBy = sharedBy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datasetId")]
        public System.Guid? DatasetId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sharedBy")]
        public SharedByDTO SharedBy { get; set; }

    }
}
