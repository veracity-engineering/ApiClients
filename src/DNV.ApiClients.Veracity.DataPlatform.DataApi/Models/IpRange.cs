// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IpRange
    {
        /// <summary>
        /// Initializes a new instance of the IpRange class.
        /// </summary>
        public IpRange()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IpRange class.
        /// </summary>
        public IpRange(string startIp = default, string endIp = default)
        {
            StartIp = startIp;
            EndIp = endIp;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startIp")]
        public string StartIp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "endIp")]
        public string EndIp { get; set; }

    }
}