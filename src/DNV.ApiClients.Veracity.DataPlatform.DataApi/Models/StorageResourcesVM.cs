// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.DataPlatform.DataApi.Models
{
    using Newtonsoft.Json;
    public partial class StorageResourcesVM
    {
        /// <summary>
        /// Initializes a new instance of the StorageResourcesVM class.
        /// </summary>
        public StorageResourcesVM()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageResourcesVM class.
        /// </summary>
        /// <param name="mayContainPersonalData">Possible values include:
        /// 'unknown', 'true', 'false'</param>
        public StorageResourcesVM(System.Guid? resourceId = default, string resourceName = default, string resourceUrl = default, System.DateTime? lastModifiedUTC = default, System.DateTime? creationDateTimeUTC = default, System.Guid? ownerId = default, string resourceType = default, string resourceRegion = default, StorageResourcesVMMayContainPersonalData? mayContainPersonalData = default, ResourceMetadata metadata = default)
        {
            ResourceId = resourceId;
            ResourceName = resourceName;
            ResourceUrl = resourceUrl;
            LastModifiedUTC = lastModifiedUTC;
            CreationDateTimeUTC = creationDateTimeUTC;
            OwnerId = ownerId;
            ResourceType = resourceType;
            ResourceRegion = resourceRegion;
            MayContainPersonalData = mayContainPersonalData;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public System.Guid? ResourceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceUrl")]
        public string ResourceUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedUTC")]
        public System.DateTime? LastModifiedUTC { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "creationDateTimeUTC")]
        public System.DateTime? CreationDateTimeUTC { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerId")]
        public System.Guid? OwnerId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceRegion")]
        public string ResourceRegion { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'unknown', 'true', 'false'
        /// </summary>
        [JsonProperty(PropertyName = "mayContainPersonalData")]
        public StorageResourcesVMMayContainPersonalData? MayContainPersonalData { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public ResourceMetadata Metadata { get; set; }

    }
}
