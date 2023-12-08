// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Resource
    {
        /// <summary>
        /// Initializes a new instance of the Resource class.
        /// </summary>
        public Resource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Resource class.
        /// </summary>
        /// <param name="accessLevel">Possible values include: 'owner',
        /// 'dataSteward', 'consumer'</param>
        /// <param name="keyStatus">Possible values include: 'noKeys',
        /// 'expired', 'available', 'active'</param>
        /// <param name="mayContainPersonalData">Possible values include:
        /// 'unknown', 'true', 'false'</param>
        public Resource(System.Guid? id = default, string reference = default, string url = default, System.DateTime? lastModifiedUTC = default, System.DateTime? creationDateTimeUTC = default, System.Guid? ownerId = default, ResourceAccessLevel? accessLevel = default, string region = default, ResourceKeyStatus? keyStatus = default, ResourceMayContainPersonalData? mayContainPersonalData = default, ResourceMetadata metadata = default)
        {
            Id = id;
            Reference = reference;
            Url = url;
            LastModifiedUTC = lastModifiedUTC;
            CreationDateTimeUTC = creationDateTimeUTC;
            OwnerId = ownerId;
            AccessLevel = accessLevel;
            Region = region;
            KeyStatus = keyStatus;
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
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reference")]
        public string Reference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

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
        /// Gets or sets possible values include: 'owner', 'dataSteward',
        /// 'consumer'
        /// </summary>
        [JsonProperty(PropertyName = "accessLevel")]
        public ResourceAccessLevel? AccessLevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'noKeys', 'expired',
        /// 'available', 'active'
        /// </summary>
        [JsonProperty(PropertyName = "keyStatus")]
        public ResourceKeyStatus? KeyStatus { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'unknown', 'true', 'false'
        /// </summary>
        [JsonProperty(PropertyName = "mayContainPersonalData")]
        public ResourceMayContainPersonalData? MayContainPersonalData { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public ResourceMetadata Metadata { get; set; }

    }
}
