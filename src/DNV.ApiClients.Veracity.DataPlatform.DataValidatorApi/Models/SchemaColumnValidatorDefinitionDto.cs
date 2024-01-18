// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.DataPlatform.DataValidatorApi.Models
{
    using Newtonsoft.Json;
    public partial class SchemaColumnValidatorDefinitionDto
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SchemaColumnValidatorDefinitionDto class.
        /// </summary>
        public SchemaColumnValidatorDefinitionDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SchemaColumnValidatorDefinitionDto class.
        /// </summary>
        /// <param name="validationType">Possible values include: 'Length',
        /// 'Range', 'Regex', 'Required', 'Type'</param>
        public SchemaColumnValidatorDefinitionDto(string name = default, string message = default, ValidationType? validationType = default, double? max = default, double? min = default, string regex = default, string type = default)
        {
            Name = name;
            Message = message;
            ValidationType = validationType;
            Max = max;
            Min = min;
            Regex = regex;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Length', 'Range', 'Regex',
        /// 'Required', 'Type'
        /// </summary>
        [JsonProperty(PropertyName = "validationType")]
        public ValidationType? ValidationType { get; set; }

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

    }
}
