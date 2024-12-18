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
    /// Represents a response containing user details.
    /// </summary>
    public partial class UserDetailsResponse
    {
        /// <summary>
        /// Initializes a new instance of the UserDetailsResponse class.
        /// </summary>
        public UserDetailsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserDetailsResponse class.
        /// </summary>
        /// <param name="firstName">The first name of the user.</param>
        /// <param name="lastName">The last name of the user.</param>
        /// <param name="phoneNumber">The phone number of the user.</param>
        /// <param name="profileId">The globally unique identifier (GUID) for
        /// the user (across all tenants)¨.</param>
        /// <param name="accessHubProfileUrl">Get the url to the member profile
        /// page in access hub, this is only valid for profile members</param>
        /// <param name="email">The email of the user.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="isServicePrincipal">Value indicating whether the user
        /// is a service principal.</param>
        /// <param name="name">The name of the tenant entity.</param>
        /// <param name="tenantId">The ID of the tenant.</param>
        /// <param name="properties">The extension properties of the tenant
        /// entity. extension properties are case sensitive and shall user
        /// {appPrefix}_{propertyName} format, appPrefixes are defined in
        /// developer.veracity.com.</param>
        /// <param name="accessHubTenantHomeUrl">get the url to the tenants
        /// home page in access hub</param>
        public UserDetailsResponse(string firstName = default, string lastName = default, string phoneNumber = default, System.Guid? profileId = default, string accessHubProfileUrl = default, string email = default, System.Guid? userId = default, bool? isServicePrincipal = default, string name = default, System.Guid? tenantId = default, Metadata metadata = default, IEnumerable<ExtensionProperty> properties = default, string accessHubTenantHomeUrl = default)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            ProfileId = profileId;
            AccessHubProfileUrl = accessHubProfileUrl;
            Email = email;
            UserId = userId;
            IsServicePrincipal = isServicePrincipal;
            Name = name;
            TenantId = tenantId;
            Metadata = metadata;
            Properties = properties;
            AccessHubTenantHomeUrl = accessHubTenantHomeUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the first name of the user.
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the user.
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the user.
        /// </summary>
        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the globally unique identifier (GUID) for the user
        /// (across all tenants)¨.
        /// </summary>
        [JsonProperty(PropertyName = "profileId")]
        public System.Guid? ProfileId { get; set; }

        /// <summary>
        /// Gets or sets get the url to the member profile page in access hub,
        /// this is only valid for profile members
        /// </summary>
        [JsonProperty(PropertyName = "accessHubProfileUrl")]
        public string AccessHubProfileUrl { get; set; }

        /// <summary>
        /// Gets or sets the email of the user.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user.
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public System.Guid? UserId { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether the user is a service
        /// principal.
        /// </summary>
        [JsonProperty(PropertyName = "isServicePrincipal")]
        public bool? IsServicePrincipal { get; set; }

        /// <summary>
        /// Gets or sets the name of the tenant entity.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the ID of the tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public System.Guid? TenantId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

        /// <summary>
        /// Gets or sets the extension properties of the tenant entity.
        /// extension properties are case sensitive and shall user
        /// {appPrefix}_{propertyName} format, appPrefixes are defined in
        /// developer.veracity.com.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IEnumerable<ExtensionProperty> Properties { get; set; }

        /// <summary>
        /// Gets or sets get the url to the tenants home page in access hub
        /// </summary>
        [JsonProperty(PropertyName = "accessHubTenantHomeUrl")]
        public string AccessHubTenantHomeUrl { get; set; }

    }
}
