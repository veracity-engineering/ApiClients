// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataValidatorApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ColumnValidatorReadDTO
    {
        /// <summary>
        /// Initializes a new instance of the ColumnValidatorReadDTO class.
        /// </summary>
        public ColumnValidatorReadDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ColumnValidatorReadDTO class.
        /// </summary>
        /// <param name="validationType">Possible values include: 'Length',
        /// 'Range', 'Regex', 'Required', 'Type'</param>
        public ColumnValidatorReadDTO(int? columnValidatorId = default, string message = default, string name = default, bool? isPredefined = default, System.Guid? workspaceId = default, Schemas166? validationType = default, double? max = default, double? min = default, string regex = default, string type = default, System.Guid? createdBy = default, System.DateTime? createdOn = default)
        {
            ColumnValidatorId = columnValidatorId;
            Message = message;
            Name = name;
            IsPredefined = isPredefined;
            WorkspaceId = workspaceId;
            ValidationType = validationType;
            Max = max;
            Min = min;
            Regex = regex;
            Type = type;
            CreatedBy = createdBy;
            CreatedOn = createdOn;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "columnValidatorId")]
        public int? ColumnValidatorId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isPredefined")]
        public bool? IsPredefined { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workspaceId")]
        public System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Length', 'Range', 'Regex',
        /// 'Required', 'Type'
        /// </summary>
        [JsonProperty(PropertyName = "validationType")]
        public Schemas166? ValidationType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "max")]
        public double? Max { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "min")]
        public double? Min { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regex")]
        public string Regex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdBy")]
        public System.Guid? CreatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdOn")]
        public System.DateTime? CreatedOn { get; set; }

    }
}
