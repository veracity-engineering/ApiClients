// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataValidatorApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class WorkspaceWriteDTO
    {
        /// <summary>
        /// Initializes a new instance of the WorkspaceWriteDTO class.
        /// </summary>
        public WorkspaceWriteDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkspaceWriteDTO class.
        /// </summary>
        public WorkspaceWriteDTO(string name = default, string description = default)
        {
            Name = name;
            Description = description;
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
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
