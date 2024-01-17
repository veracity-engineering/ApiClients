// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.Identity.ServicesApi.Models
{
    using Newtonsoft.Json;
    /// <summary>
    /// The state of the subscription
    /// </summary>
    public partial class SubscriptionState
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionState class.
        /// </summary>
        public SubscriptionState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionState class.
        /// </summary>
        /// <param name="state">Subscription state. Possible values include:
        /// 'subscribing', 'pending', 'rejected', 'notSubscribing', 'null',
        /// 'error'</param>
        public SubscriptionState(SubscriptionStateTypes state)
        {
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets subscription state. Possible values include:
        /// 'subscribing', 'pending', 'rejected', 'notSubscribing', 'null',
        /// 'error'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public SubscriptionStateTypes State { get; set; }

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
