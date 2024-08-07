// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.Identity.ServicesApiV3.Models
{
    using Newtonsoft.Json;
    /// <summary>
    /// Contians the name, id and relative uri to the resource detilas
    /// </summary>
    public partial class ServiceReference
    {
        /// <summary>
        /// Initializes a new instance of the ServiceReference class.
        /// </summary>
        public ServiceReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceReference class.
        /// </summary>
        /// <param name="identity">The relative path to the resource
        /// details</param>
        public ServiceReference(bool productionService, string identity = default, string name = default, string id = default, string description = default)
        {
            Identity = identity;
            ProductionService = productionService;
            Name = name;
            Id = id;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the relative path to the resource details
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public string Identity { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductionService")]
        public bool ProductionService { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
