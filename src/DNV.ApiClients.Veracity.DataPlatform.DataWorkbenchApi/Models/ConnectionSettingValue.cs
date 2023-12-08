// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataWorkbenchApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ConnectionSettingValue
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionSettingValue class.
        /// </summary>
        public ConnectionSettingValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionSettingValue class.
        /// </summary>
        public ConnectionSettingValue(string key = default, string value = default)
        {
            Key = key;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
