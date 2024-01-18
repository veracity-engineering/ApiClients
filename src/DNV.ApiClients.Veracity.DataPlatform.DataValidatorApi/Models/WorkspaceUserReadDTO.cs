// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.DataPlatform.DataValidatorApi.Models
{
    using Newtonsoft.Json;
    public partial class WorkspaceUserReadDTO
    {
        /// <summary>
        /// Initializes a new instance of the WorkspaceUserReadDTO class.
        /// </summary>
        public WorkspaceUserReadDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkspaceUserReadDTO class.
        /// </summary>
        /// <param name="role">Possible values include: 'Admin', 'Contributor',
        /// 'Reader'</param>
        public WorkspaceUserReadDTO(System.Guid? workspaceId = default, System.Guid? userId = default, string name = default, string email = default, Role? role = default)
        {
            WorkspaceId = workspaceId;
            UserId = userId;
            Name = name;
            Email = email;
            Role = role;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workspaceId")]
        public System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public System.Guid? UserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Admin', 'Contributor',
        /// 'Reader'
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public Role? Role { get; set; }

    }
}
