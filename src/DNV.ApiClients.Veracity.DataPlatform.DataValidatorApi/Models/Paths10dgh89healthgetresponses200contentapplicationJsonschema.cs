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
    public partial class Paths10dgh89healthgetresponses200contentapplicationJsonschema
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Paths10dgh89healthgetresponses200contentapplicationJsonschema
        /// class.
        /// </summary>
        public Paths10dgh89healthgetresponses200contentapplicationJsonschema()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Paths10dgh89healthgetresponses200contentapplicationJsonschema
        /// class.
        /// </summary>
        public Paths10dgh89healthgetresponses200contentapplicationJsonschema(string status = default, IEnumerable<Get200ApplicationJsonPropertiesItemsItem> results = default)
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
        public IEnumerable<Get200ApplicationJsonPropertiesItemsItem> Results { get; set; }

    }
}