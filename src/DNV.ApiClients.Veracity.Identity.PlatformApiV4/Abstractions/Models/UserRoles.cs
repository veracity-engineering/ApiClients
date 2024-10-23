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
    /// Represent the user admin roles within the tenant.
    /// </summary>
    public partial class UserRoles
    {
        /// <summary>
        /// Initializes a new instance of the UserRoles class.
        /// </summary>
        public UserRoles()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserRoles class.
        /// </summary>
        /// <param name="name">The name of the tenant entity.</param>
        /// <param name="tenantId">The ID of the tenant.</param>
        /// <param name="accessHubTenantHomeUrl">get the url to the tenants
        /// home page in access hub</param>
        public UserRoles(bool? isTenantAdmin = default, bool? isUserAdmin = default, IEnumerable<AdminItem> adminOfApplications = default, IEnumerable<AdminItem> adminOfGroups = default, string id = default, object email = default, string userId = default, string name = default, System.Guid? tenantId = default, string accessHubTenantHomeUrl = default)
        {
            IsTenantAdmin = isTenantAdmin;
            IsUserAdmin = isUserAdmin;
            AdminOfApplications = adminOfApplications;
            AdminOfGroups = adminOfGroups;
            Id = id;
            Email = email;
            UserId = userId;
            Name = name;
            TenantId = tenantId;
            AccessHubTenantHomeUrl = accessHubTenantHomeUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isTenantAdmin")]
        public bool? IsTenantAdmin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isUserAdmin")]
        public bool? IsUserAdmin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adminOfApplications")]
        public IEnumerable<AdminItem> AdminOfApplications { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adminOfGroups")]
        public IEnumerable<AdminItem> AdminOfGroups { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public object Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

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
        /// Gets or sets get the url to the tenants home page in access hub
        /// </summary>
        [JsonProperty(PropertyName = "accessHubTenantHomeUrl")]
        public string AccessHubTenantHomeUrl { get; set; }

    }
}