// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.DataPlatform.DataValidatorApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    public partial class Paths1x2z2hihealthgetresponses503contenttextPlainschema
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Paths1x2z2hihealthgetresponses503contenttextPlainschema class.
        /// </summary>
        public Paths1x2z2hihealthgetresponses503contenttextPlainschema()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Paths1x2z2hihealthgetresponses503contenttextPlainschema class.
        /// </summary>
        public Paths1x2z2hihealthgetresponses503contenttextPlainschema(string status = default, IEnumerable<Get503TextPlainPropertiesItemsItem> results = default)
        {
            Status = status;
            Results = results;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IEnumerable<Get503TextPlainPropertiesItemsItem> Results { get; set; }

    }
}