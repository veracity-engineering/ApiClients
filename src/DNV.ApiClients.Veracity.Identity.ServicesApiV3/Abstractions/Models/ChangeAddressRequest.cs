// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.Identity.ServicesApiV3.Models
{
    using Newtonsoft.Json;
    public partial class ChangeAddressRequest
    {
        /// <summary>
        /// Initializes a new instance of the ChangeAddressRequest class.
        /// </summary>
        public ChangeAddressRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ChangeAddressRequest class.
        /// </summary>
        public ChangeAddressRequest(string oldAddress = default, string newAddress = default)
        {
            OldAddress = oldAddress;
            NewAddress = newAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "oldAddress")]
        public string OldAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "newAddress")]
        public string NewAddress { get; set; }

    }
}
