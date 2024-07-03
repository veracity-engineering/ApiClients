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
    public partial class UserReference
    {
        /// <summary>
        /// Initializes a new instance of the UserReference class.
        /// </summary>
        public UserReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserReference class.
        /// </summary>
        /// <param name="identity">The relative path to the resource
        /// details</param>
        public UserReference(bool activated, string identity = default, string email = default, string tenantId = default, string name = default, string id = default)
        {
            Identity = identity;
            Email = email;
            Activated = activated;
            TenantId = tenantId;
            Name = name;
            Id = id;
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
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activated")]
        public bool Activated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

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
