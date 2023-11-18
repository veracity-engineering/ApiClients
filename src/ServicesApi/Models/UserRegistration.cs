// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.Identity.ServicesApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UserRegistration
    {
        /// <summary>
        /// Initializes a new instance of the UserRegistration class.
        /// </summary>
        public UserRegistration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserRegistration class.
        /// </summary>
        public UserRegistration(string firstName = default(string), string lastName = default(string), string email = default(string), string phone = default(string), string countryCode = default(string), RegistrationOptions options = default(RegistrationOptions))
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            CountryCode = countryCode;
            Options = options;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

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
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public RegistrationOptions Options { get; set; }

    }
}