// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataWorkbenchApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Connector
    {
        /// <summary>
        /// Initializes a new instance of the Connector class.
        /// </summary>
        public Connector()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Connector class.
        /// </summary>
        public Connector(System.Guid connectorId = default, string name = default, string connectorType = default, string description = default, string dataProvider = default, ConnectorConfiguration connectorConfiguration = default, SchemaSupport schemaSupport = default)
        {
            ConnectorId = connectorId;
            Name = name;
            ConnectorType = connectorType;
            Description = description;
            DataProvider = dataProvider;
            ConnectorConfiguration = connectorConfiguration;
            SchemaSupport = schemaSupport;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectorId")]
        public System.Guid ConnectorId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectorType")]
        public string ConnectorType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dataProvider")]
        public string DataProvider { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectorConfiguration")]
        public ConnectorConfiguration ConnectorConfiguration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schemaSupport")]
        public SchemaSupport SchemaSupport { get; set; }

    }
}
