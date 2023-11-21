// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracity.DataWorkbench.Tenant.ApiClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UserInviteDto
    {
        /// <summary>
        /// Initializes a new instance of the UserInviteDto class.
        /// </summary>
        public UserInviteDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserInviteDto class.
        /// </summary>
        public UserInviteDto(string email = default, string firstName = default, string lastName = default, string roleName = default)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            RoleName = roleName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roleName")]
        public string RoleName { get; set; }

    }
}
