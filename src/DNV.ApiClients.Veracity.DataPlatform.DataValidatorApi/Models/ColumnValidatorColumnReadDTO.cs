// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.DataPlatform.DataValidatorApi.Models
{
    using Newtonsoft.Json;
    public partial class ColumnValidatorColumnReadDTO
    {
        /// <summary>
        /// Initializes a new instance of the ColumnValidatorColumnReadDTO
        /// class.
        /// </summary>
        public ColumnValidatorColumnReadDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ColumnValidatorColumnReadDTO
        /// class.
        /// </summary>
        /// <param name="severity">Possible values include: 'Error', 'Warning',
        /// 'Correction'</param>
        public ColumnValidatorColumnReadDTO(int? schemaColumnId = default, int? columnValidatorId = default, string validatorName = default, Severity? severity = default)
        {
            SchemaColumnId = schemaColumnId;
            ColumnValidatorId = columnValidatorId;
            ValidatorName = validatorName;
            Severity = severity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schemaColumnId")]
        public int? SchemaColumnId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "columnValidatorId")]
        public int? ColumnValidatorId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "validatorName")]
        public string ValidatorName { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Error', 'Warning',
        /// 'Correction'
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public Severity? Severity { get; set; }

    }
}
