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
    public partial class DependencyState
    {
        /// <summary>
        /// Initializes a new instance of the DependencyState class.
        /// </summary>
        public DependencyState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DependencyState class.
        /// </summary>
        /// <param name="status">Possible values include: 'Pass', 'Warn',
        /// 'Fail'</param>
        public DependencyState(string componentId = default, string componentType = default, object observedValue = default, string observedUnit = default, HealthStateTypes? status = default, IEnumerable<string> affectedEndpoints = default, System.DateTime? time = default, string output = default, int? weight = default, bool? critical = default)
        {
            ComponentId = componentId;
            ComponentType = componentType;
            ObservedValue = observedValue;
            ObservedUnit = observedUnit;
            Status = status;
            AffectedEndpoints = affectedEndpoints;
            Time = time;
            Output = output;
            Weight = weight;
            Critical = critical;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentId")]
        public string ComponentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentType")]
        public string ComponentType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "observedValue")]
        public object ObservedValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "observedUnit")]
        public string ObservedUnit { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Pass', 'Warn', 'Fail'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public HealthStateTypes? Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "affectedEndpoints")]
        public IEnumerable<string> AffectedEndpoints { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public System.DateTime? Time { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "output")]
        public string Output { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "critical")]
        public bool? Critical { get; set; }

    }
}