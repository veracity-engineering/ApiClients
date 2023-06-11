// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ProviderAccessVM
    {
        /// <summary>
        /// Initializes a new instance of the ProviderAccessVM class.
        /// </summary>
        public ProviderAccessVM()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProviderAccessVM class.
        /// </summary>
        public ProviderAccessVM(System.Guid? userId = default(System.Guid?), System.Guid? ownerId = default(System.Guid?), System.Guid? grantedById = default(System.Guid?), System.Guid? accessSharingId = default(System.Guid?), bool? keyCreated = default(bool?), bool? autoRefreshed = default(bool?), System.DateTime? keyCreatedTimeUTC = default(System.DateTime?), System.DateTime? keyExpiryTimeUTC = default(System.DateTime?), string resourceType = default(string), int? accessHours = default(int?), System.Guid? accessKeyTemplateId = default(System.Guid?), bool? attribute1 = default(bool?), bool? attribute2 = default(bool?), bool? attribute3 = default(bool?), bool? attribute4 = default(bool?), System.Guid? resourceId = default(System.Guid?), IpRange ipRange = default(IpRange), string comment = default(string))
        {
            UserId = userId;
            OwnerId = ownerId;
            GrantedById = grantedById;
            AccessSharingId = accessSharingId;
            KeyCreated = keyCreated;
            AutoRefreshed = autoRefreshed;
            KeyCreatedTimeUTC = keyCreatedTimeUTC;
            KeyExpiryTimeUTC = keyExpiryTimeUTC;
            ResourceType = resourceType;
            AccessHours = accessHours;
            AccessKeyTemplateId = accessKeyTemplateId;
            Attribute1 = attribute1;
            Attribute2 = attribute2;
            Attribute3 = attribute3;
            Attribute4 = attribute4;
            ResourceId = resourceId;
            IpRange = ipRange;
            Comment = comment;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public System.Guid? UserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerId")]
        public System.Guid? OwnerId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "grantedById")]
        public System.Guid? GrantedById { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accessSharingId")]
        public System.Guid? AccessSharingId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "keyCreated")]
        public bool? KeyCreated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "autoRefreshed")]
        public bool? AutoRefreshed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "keyCreatedTimeUTC")]
        public System.DateTime? KeyCreatedTimeUTC { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "keyExpiryTimeUTC")]
        public System.DateTime? KeyExpiryTimeUTC { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accessHours")]
        public int? AccessHours { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accessKeyTemplateId")]
        public System.Guid? AccessKeyTemplateId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attribute1")]
        public bool? Attribute1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attribute2")]
        public bool? Attribute2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attribute3")]
        public bool? Attribute3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attribute4")]
        public bool? Attribute4 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public System.Guid? ResourceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipRange")]
        public IpRange IpRange { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

    }
}