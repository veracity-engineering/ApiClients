// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataValidatorApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ValidationSummaryWriteDTO
    {
        /// <summary>
        /// Initializes a new instance of the ValidationSummaryWriteDTO class.
        /// </summary>
        public ValidationSummaryWriteDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ValidationSummaryWriteDTO class.
        /// </summary>
        public ValidationSummaryWriteDTO(string region = default(string), System.DateTime? createdOn = default(System.DateTime?), System.Guid? schemaId = default(System.Guid?), int? recordsProcessed = default(int?), int? recordsFailed = default(int?), int? failedValidations = default(int?), int? validationsCount = default(int?))
        {
            Region = region;
            CreatedOn = createdOn;
            SchemaId = schemaId;
            RecordsProcessed = recordsProcessed;
            RecordsFailed = recordsFailed;
            FailedValidations = failedValidations;
            ValidationsCount = validationsCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdOn")]
        public System.DateTime? CreatedOn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schemaId")]
        public System.Guid? SchemaId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recordsProcessed")]
        public int? RecordsProcessed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recordsFailed")]
        public int? RecordsFailed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "failedValidations")]
        public int? FailedValidations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "validationsCount")]
        public int? ValidationsCount { get; set; }

    }
}