// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.DataPlatform.DataWorkbenchApiV2.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    public partial class SasPolicyReadDTO
    {
        /// <summary>
        /// Initializes a new instance of the SasPolicyReadDTO class.
        /// </summary>
        public SasPolicyReadDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SasPolicyReadDTO class.
        /// </summary>
        public SasPolicyReadDTO(string name = default, IEnumerable<string> permissions = default)
        {
            Name = name;
            Permissions = permissions;
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
        [JsonProperty(PropertyName = "permissions")]
        public IEnumerable<string> Permissions { get; set; }

    }
}
