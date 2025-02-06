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
    public partial class ColumnValidatorBasicDto
    {
        /// <summary>
        /// Initializes a new instance of the ColumnValidatorBasicDto class.
        /// </summary>
        public ColumnValidatorBasicDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ColumnValidatorBasicDto class.
        /// </summary>
        /// <param name="dataFormat">Possible values include: 'String',
        /// 'Boolean', 'Int32', 'Int64', 'Float', 'Double', 'DateTime'</param>
        public ColumnValidatorBasicDto(System.Guid id = default, string name = default, bool? notEmpty = default, DataFormat? dataFormat = default, double? minimum = default, double? maximum = default, bool? exclusiveMinimum = default, bool? exclusiveMaximum = default, int? minLength = default, int? maxLength = default, string pattern = default, IEnumerable<string> enumProperty = default, string errorMessage = default, string fallbackValue = default)
        {
            Id = id;
            Name = name;
            NotEmpty = notEmpty;
            DataFormat = dataFormat;
            Minimum = minimum;
            Maximum = maximum;
            ExclusiveMinimum = exclusiveMinimum;
            ExclusiveMaximum = exclusiveMaximum;
            MinLength = minLength;
            MaxLength = maxLength;
            Pattern = pattern;
            EnumProperty = enumProperty;
            ErrorMessage = errorMessage;
            FallbackValue = fallbackValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "notEmpty")]
        public bool? NotEmpty { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'String', 'Boolean', 'Int32',
        /// 'Int64', 'Float', 'Double', 'DateTime'
        /// </summary>
        [JsonProperty(PropertyName = "dataFormat")]
        public DataFormat? DataFormat { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minimum")]
        public double? Minimum { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maximum")]
        public double? Maximum { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exclusiveMinimum")]
        public bool? ExclusiveMinimum { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exclusiveMaximum")]
        public bool? ExclusiveMaximum { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minLength")]
        public int? MinLength { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maxLength")]
        public int? MaxLength { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pattern")]
        public string Pattern { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enum")]
        public IEnumerable<string> EnumProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fallbackValue")]
        public string FallbackValue { get; set; }

    }
}
