// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracity.ApiClients.DataPlatform.DataValidatorApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class WorkspaceReadDTO
    {
        /// <summary>
        /// Initializes a new instance of the WorkspaceReadDTO class.
        /// </summary>
        public WorkspaceReadDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkspaceReadDTO class.
        /// </summary>
        public WorkspaceReadDTO(System.Guid? workspaceId = default(System.Guid?), string name = default(string), string description = default(string), System.Guid? createdBy = default(System.Guid?), System.DateTime? createdOn = default(System.DateTime?), System.Guid? lastModifiedBy = default(System.Guid?), System.DateTime? lastModifiedOn = default(System.DateTime?), System.Guid? owner = default(System.Guid?), IList<WorkspaceUserReadDTO> workspaceUsers = default(IList<WorkspaceUserReadDTO>))
        {
            WorkspaceId = workspaceId;
            Name = name;
            Description = description;
            CreatedBy = createdBy;
            CreatedOn = createdOn;
            LastModifiedBy = lastModifiedBy;
            LastModifiedOn = lastModifiedOn;
            Owner = owner;
            WorkspaceUsers = workspaceUsers;
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
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdBy")]
        public System.Guid? CreatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdOn")]
        public System.DateTime? CreatedOn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedBy")]
        public System.Guid? LastModifiedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedOn")]
        public System.DateTime? LastModifiedOn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public System.Guid? Owner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workspaceUsers")]
        public IList<WorkspaceUserReadDTO> WorkspaceUsers { get; set; }

    }
}
