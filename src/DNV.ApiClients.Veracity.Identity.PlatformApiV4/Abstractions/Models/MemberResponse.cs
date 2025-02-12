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
    /// Represents a member response.
    /// </summary>
    public partial class MemberResponse
    {
        /// <summary>
        /// Initializes a new instance of the MemberResponse class.
        /// </summary>
        public MemberResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MemberResponse class.
        /// </summary>
        /// <param name="userId">The veracity user id for profile members and
        /// the group id for group members</param>
        /// <param name="objectId">The profile id for profile members and the
        /// group id for group members</param>
        /// <param name="email">Only used for profile entities</param>
        /// <param name="isServicePrincipal">Value indicating if the user is a
        /// service principal</param>
        /// <param name="memberType">Possible values include: 'profile',
        /// 'userGroup'</param>
        /// <param name="isGroupAdmin">Indicates that the user can add/remove
        /// members of this group.</param>
        /// <param name="groupId">The ID of the group.</param>
        /// <param name="accessHubGroupUrl">Get the url to the group page in
        /// access hub</param>
        /// <param name="accessHubProfileUrl">Get the url to the member profile
        /// page in access hub, this is only valid for profile members</param>
        /// <param name="accessHubMemberGroupUrl">Get the url to the group
        /// member page in access hub, this is only valid for group
        /// members</param>
        /// <param name="name">The name of the tenant entity.</param>
        /// <param name="tenantId">The ID of the tenant.</param>
        /// <param name="properties">The extension properties of the tenant
        /// entity. extension properties are case sensitive and shall user
        /// {appPrefix}_{propertyName} format, appPrefixes are defined in
        /// developer.veracity.com.</param>
        /// <param name="accessHubTenantHomeUrl">get the url to the tenants
        /// home page in access hub</param>
        public MemberResponse(System.Guid? userId = default, System.Guid? objectId = default, string email = default, bool? isServicePrincipal = default, EntityTypes? memberType = default, bool? isGroupAdmin = default, System.Guid? groupId = default, string accessHubGroupUrl = default, string accessHubProfileUrl = default, string accessHubMemberGroupUrl = default, string name = default, System.Guid? tenantId = default, Metadata metadata = default, IEnumerable<ExtensionProperty> properties = default, string accessHubTenantHomeUrl = default)
        {
            UserId = userId;
            ObjectId = objectId;
            Email = email;
            IsServicePrincipal = isServicePrincipal;
            MemberType = memberType;
            IsGroupAdmin = isGroupAdmin;
            GroupId = groupId;
            AccessHubGroupUrl = accessHubGroupUrl;
            AccessHubProfileUrl = accessHubProfileUrl;
            AccessHubMemberGroupUrl = accessHubMemberGroupUrl;
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
        /// Gets or sets the veracity user id for profile members and the group
        /// id for group members
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public System.Guid? UserId { get; set; }

        /// <summary>
        /// Gets or sets the profile id for profile members and the group id
        /// for group members
        /// </summary>
        [JsonProperty(PropertyName = "objectId")]
        public System.Guid? ObjectId { get; set; }

        /// <summary>
        /// Gets or sets only used for profile entities
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets value indicating if the user is a service principal
        /// </summary>
        [JsonProperty(PropertyName = "isServicePrincipal")]
        public bool? IsServicePrincipal { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'profile', 'userGroup'
        /// </summary>
        [JsonProperty(PropertyName = "memberType")]
        public EntityTypes? MemberType { get; set; }

        /// <summary>
        /// Gets or sets indicates that the user can add/remove members of this
        /// group.
        /// </summary>
        [JsonProperty(PropertyName = "isGroupAdmin")]
        public bool? IsGroupAdmin { get; set; }

        /// <summary>
        /// Gets or sets the ID of the group.
        /// </summary>
        [JsonProperty(PropertyName = "groupId")]
        public System.Guid? GroupId { get; set; }

        /// <summary>
        /// Gets or sets get the url to the group page in access hub
        /// </summary>
        [JsonProperty(PropertyName = "accessHubGroupUrl")]
        public string AccessHubGroupUrl { get; set; }

        /// <summary>
        /// Gets or sets get the url to the member profile page in access hub,
        /// this is only valid for profile members
        /// </summary>
        [JsonProperty(PropertyName = "accessHubProfileUrl")]
        public string AccessHubProfileUrl { get; set; }

        /// <summary>
        /// Gets or sets get the url to the group member page in access hub,
        /// this is only valid for group members
        /// </summary>
        [JsonProperty(PropertyName = "accessHubMemberGroupUrl")]
        public string AccessHubMemberGroupUrl { get; set; }

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
