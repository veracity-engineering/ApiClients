// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataWorkbenchApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ConnectionsSchemaVersion
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionsSchemaVersion class.
        /// </summary>
        public ConnectionsSchemaVersion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionsSchemaVersion class.
        /// </summary>
        public ConnectionsSchemaVersion(System.Guid id = default, string schemaVersionName = default)
        {
            Id = id;
            SchemaVersionName = schemaVersionName;
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

    }
}
