// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.Identity.ServicesApiV3.Models
{
    using Newtonsoft.Json;
    public partial class ConfirmationRequest
    {
        /// <summary>
        /// Initializes a new instance of the ConfirmationRequest class.
        /// </summary>
        public ConfirmationRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConfirmationRequest class.
        /// </summary>
        public ConfirmationRequest(string activationCode = default, string address = default)
        {
            ActivationCode = activationCode;
            Address = address;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activationCode")]
        public string ActivationCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

    }
}
