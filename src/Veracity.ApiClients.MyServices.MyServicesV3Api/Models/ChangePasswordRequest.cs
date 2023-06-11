// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracity.ApiClients.MyServices.MyServicesV3Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ChangePasswordRequest
    {
        /// <summary>
        /// Initializes a new instance of the ChangePasswordRequest class.
        /// </summary>
        public ChangePasswordRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ChangePasswordRequest class.
        /// </summary>
        public ChangePasswordRequest(string oldPassword = default(string), string newPassword = default(string), string newPasswordRepeat = default(string))
        {
            OldPassword = oldPassword;
            NewPassword = newPassword;
            NewPasswordRepeat = newPasswordRepeat;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "oldPassword")]
        public string OldPassword { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "newPassword")]
        public string NewPassword { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "newPasswordRepeat")]
        public string NewPasswordRepeat { get; set; }

    }
}
