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
    public partial class Paths1t4jlxnhealthgetresponses200contenttextJsonschema
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Paths1t4jlxnhealthgetresponses200contenttextJsonschema class.
        /// </summary>
        public Paths1t4jlxnhealthgetresponses200contenttextJsonschema()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Paths1t4jlxnhealthgetresponses200contenttextJsonschema class.
        /// </summary>
        public Paths1t4jlxnhealthgetresponses200contenttextJsonschema(string status = default, IEnumerable<Get200TextJsonPropertiesItemsItem> results = default)
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
        public IEnumerable<Get200TextJsonPropertiesItemsItem> Results { get; set; }

    }
}
