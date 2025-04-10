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
    public partial class RevokePoliciesExternalDTO
    {
        /// <summary>
        /// Initializes a new instance of the RevokePoliciesExternalDTO class.
        /// </summary>
        public RevokePoliciesExternalDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RevokePoliciesExternalDTO class.
        /// </summary>
        public RevokePoliciesExternalDTO(ConnectionSettingsDTO settings = default, IEnumerable<string> policies = default)
        {
            Settings = settings;
            Policies = policies;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings")]
        public ConnectionSettingsDTO Settings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "policies")]
        public IEnumerable<string> Policies { get; set; }

    }
}
