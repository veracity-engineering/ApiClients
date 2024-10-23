// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.Identity.PlatformApiV4.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    /// <summary>
    /// Represents a license request.
    /// </summary>
    public partial class LicenseRequest
    {
        /// <summary>
        /// Initializes a new instance of the LicenseRequest class.
        /// </summary>
        public LicenseRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LicenseRequest class.
        /// </summary>
        /// <param name="entityId">The veracity user id for profile members and
        /// the group id for group members</param>
        /// <param name="licenseType">Possible values include: 'profile',
        /// 'userGroup'</param>
        /// <param name="accessLevel">Optional: used when provisioning
        /// applications that support accessLevels</param>
        /// <param name="isApplicationAdmin">Grant the users to manage licenses
        /// for this application</param>
        /// <param name="canAddUsersToTenant">Grant the user the ability to add
        /// users to the tenant</param>
        /// <param name="properties">The extension properties. Extra
        /// information kept on the object.</param>
        public LicenseRequest(System.Guid entityId, EntityTypes licenseType, string accessLevel = default, bool? isApplicationAdmin = default, bool? canAddUsersToTenant = default, IEnumerable<ExtensionProperty> properties = default)
        {
            EntityId = entityId;
            LicenseType = licenseType;
            AccessLevel = accessLevel;
            IsApplicationAdmin = isApplicationAdmin;
            CanAddUsersToTenant = canAddUsersToTenant;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the veracity user id for profile members and the group
        /// id for group members
        /// </summary>
        [JsonProperty(PropertyName = "entityId")]
        public System.Guid EntityId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'profile', 'userGroup'
        /// </summary>
        [JsonProperty(PropertyName = "licenseType")]
        public EntityTypes LicenseType { get; set; }

        /// <summary>
        /// Gets or sets optional: used when provisioning applications that
        /// support accessLevels
        /// </summary>
        [JsonProperty(PropertyName = "accessLevel")]
        public string AccessLevel { get; set; }

        /// <summary>
        /// Gets or sets grant the users to manage licenses for this
        /// application
        /// </summary>
        [JsonProperty(PropertyName = "isApplicationAdmin")]
        public bool? IsApplicationAdmin { get; set; }

        /// <summary>
        /// Gets or sets grant the user the ability to add users to the tenant
        /// </summary>
        [JsonProperty(PropertyName = "canAddUsersToTenant")]
        public bool? CanAddUsersToTenant { get; set; }

        /// <summary>
        /// Gets or sets the extension properties. Extra information kept on
        /// the object.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IEnumerable<ExtensionProperty> Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}