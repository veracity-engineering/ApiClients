// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.Identity.ServicesApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    public partial class UserReferences
    {
        /// <summary>
        /// Initializes a new instance of the UserReferences class.
        /// </summary>
        public UserReferences()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserReferences class.
        /// </summary>
        public UserReferences(IEnumerable<CompanyReference> userCompanies = default, IEnumerable<string> adminForCompanies = default, IEnumerable<ServiceReference> services = default, IEnumerable<SubscriptionDetails> subscriptions = default)
        {
            UserCompanies = userCompanies;
            AdminForCompanies = adminForCompanies;
            Services = services;
            Subscriptions = subscriptions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserCompanies")]
        public IEnumerable<CompanyReference> UserCompanies { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AdminForCompanies")]
        public IEnumerable<string> AdminForCompanies { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Services")]
        public IEnumerable<ServiceReference> Services { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Subscriptions")]
        public IEnumerable<SubscriptionDetails> Subscriptions { get; set; }

    }
}
