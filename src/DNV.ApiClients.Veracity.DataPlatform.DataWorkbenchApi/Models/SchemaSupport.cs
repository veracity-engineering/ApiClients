// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataWorkbenchApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SchemaSupport
    {
        /// <summary>
        /// Initializes a new instance of the SchemaSupport class.
        /// </summary>
        public SchemaSupport()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SchemaSupport class.
        /// </summary>
        public SchemaSupport(IEnumerable<SchemaVersion> supportedSchemaVersions = default)
        {
            SupportedSchemaVersions = supportedSchemaVersions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "supportedSchemaVersions")]
        public IEnumerable<SchemaVersion> SupportedSchemaVersions { get; set; }

    }
}
