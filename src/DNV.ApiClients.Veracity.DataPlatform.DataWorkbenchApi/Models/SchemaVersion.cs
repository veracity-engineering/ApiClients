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

    public partial class SchemaVersion
    {
        /// <summary>
        /// Initializes a new instance of the SchemaVersion class.
        /// </summary>
        public SchemaVersion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SchemaVersion class.
        /// </summary>
        public SchemaVersion(System.Guid id = default, string schemaVersionName = default, IEnumerable<KeyValueSetting> settings = default)
        {
            Id = id;
            SchemaVersionName = schemaVersionName;
            Settings = settings;
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
        [JsonProperty(PropertyName = "schemaVersionName")]
        public string SchemaVersionName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings")]
        public IEnumerable<KeyValueSetting> Settings { get; set; }

    }
}
