// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.Identity.ServicesApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ValidationError
    {
        /// <summary>
        /// Initializes a new instance of the ValidationError class.
        /// </summary>
        public ValidationError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ValidationError class.
        /// </summary>
        public ValidationError(int subCode, string url = default(string), IList<string> violatedPolicies = default(IList<string>), bool? subscriptionMissing = default(bool?), string message = default(string), string information = default(string), string supportCode = default(string))
        {
            Url = url;
            ViolatedPolicies = violatedPolicies;
            SubscriptionMissing = subscriptionMissing;
            Message = message;
            Information = information;
            SubCode = subCode;
            SupportCode = supportCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "violatedPolicies")]
        public IList<string> ViolatedPolicies { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubscriptionMissing")]
        public bool? SubscriptionMissing { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "information")]
        public string Information { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subCode")]
        public int SubCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "supportCode")]
        public string SupportCode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}