// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataValidatorApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SchemaColumnDefinitionDto
    {
        /// <summary>
        /// Initializes a new instance of the SchemaColumnDefinitionDto class.
        /// </summary>
        public SchemaColumnDefinitionDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SchemaColumnDefinitionDto class.
        /// </summary>
        /// <param name="metaType">Possible values include: 'NotApplicable',
        /// 'FileName', 'UploadTime', 'RowCorrection'</param>
        public SchemaColumnDefinitionDto(string name = default, bool? mustBePresent = default, string metaFormat = default, IDictionary<string, string> rules = default, string metaType = default)
        {
            Name = name;
            MustBePresent = mustBePresent;
            MetaFormat = metaFormat;
            Rules = rules;
            MetaType = metaType;
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
        [JsonProperty(PropertyName = "mustBePresent")]
        public bool? MustBePresent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metaFormat")]
        public string MetaFormat { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IDictionary<string, string> Rules { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'NotApplicable', 'FileName',
        /// 'UploadTime', 'RowCorrection'
        /// </summary>
        [JsonProperty(PropertyName = "metaType")]
        public string MetaType { get; set; }

    }
}
