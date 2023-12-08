// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.Identity.ServicesApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ItemReference
    {
        /// <summary>
        /// Initializes a new instance of the ItemReference class.
        /// </summary>
        public ItemReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ItemReference class.
        /// </summary>
        /// <param name="identity">The relative path to the resource
        /// details</param>
        public ItemReference(string name = default, string id = default, string description = default, string identity = default)
        {
            Name = name;
            Id = id;
            Description = description;
            Identity = identity;
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
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the relative path to the resource details
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public string Identity { get; private set; }

    }
}