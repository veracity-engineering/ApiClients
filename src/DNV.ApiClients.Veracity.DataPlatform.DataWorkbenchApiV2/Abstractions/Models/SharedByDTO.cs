// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.DataPlatform.DataWorkbenchApiV2.Models
{
    using Newtonsoft.Json;
    public partial class SharedByDTO
    {
        /// <summary>
        /// Initializes a new instance of the SharedByDTO class.
        /// </summary>
        public SharedByDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SharedByDTO class.
        /// </summary>
        /// <param name="sharedByType">Possible values include: 'User',
        /// 'Workspace'</param>
        public SharedByDTO(System.Guid? id = default, SharedByTypesDTO? sharedByType = default, string name = default)
        {
            Id = id;
            SharedByType = sharedByType;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'User', 'Workspace'
        /// </summary>
        [JsonProperty(PropertyName = "sharedByType")]
        public SharedByTypesDTO? SharedByType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}