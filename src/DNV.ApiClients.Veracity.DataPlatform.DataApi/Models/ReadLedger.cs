// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ReadLedger
    {
        /// <summary>
        /// Initializes a new instance of the ReadLedger class.
        /// </summary>
        public ReadLedger()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReadLedger class.
        /// </summary>
        public ReadLedger(string entityId = default, string entityType = default, string companyId = default, string containerName = default, System.DateTime? dateOfEvent = default, string category = default, string ledgerSubCategory = default, string description = default, string region = default, string affectedEntityId = default, string affectedEntityType = default, string affectedCompanyId = default, string fileName = default, string ipAddress = default)
        {
            EntityId = entityId;
            EntityType = entityType;
            CompanyId = companyId;
            ContainerName = containerName;
            DateOfEvent = dateOfEvent;
            Category = category;
            LedgerSubCategory = ledgerSubCategory;
            Description = description;
            Region = region;
            AffectedEntityId = affectedEntityId;
            AffectedEntityType = affectedEntityType;
            AffectedCompanyId = affectedCompanyId;
            FileName = fileName;
            IpAddress = ipAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityId")]
        public string EntityId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityType")]
        public string EntityType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "companyId")]
        public string CompanyId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "containerName")]
        public string ContainerName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateOfEvent")]
        public System.DateTime? DateOfEvent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ledgerSubCategory")]
        public string LedgerSubCategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "affectedEntityId")]
        public string AffectedEntityId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "affectedEntityType")]
        public string AffectedEntityType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "affectedCompanyId")]
        public string AffectedCompanyId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fileName")]
        public string FileName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

    }
}
