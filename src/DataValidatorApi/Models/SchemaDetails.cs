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

    public partial class SchemaDetails
    {
        /// <summary>
        /// Initializes a new instance of the SchemaDetails class.
        /// </summary>
        public SchemaDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SchemaDetails class.
        /// </summary>
        public SchemaDetails(System.Guid? schemaId = default, string name = default, string shortName = default, string description = default, bool? isPredefined = default, System.Guid? workspaceId = default, SchemaVersionReadDTO activeVersion = default, IList<SchemaVersionReadDTO> versions = default)
        {
            SchemaId = schemaId;
            Name = name;
            ShortName = shortName;
            Description = description;
            IsPredefined = isPredefined;
            WorkspaceId = workspaceId;
            ActiveVersion = activeVersion;
            Versions = versions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schemaId")]
        public System.Guid? SchemaId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shortName")]
        public string ShortName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isPredefined")]
        public bool? IsPredefined { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workspaceId")]
        public System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activeVersion")]
        public SchemaVersionReadDTO ActiveVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versions")]
        public IList<SchemaVersionReadDTO> Versions { get; set; }

    }
}
