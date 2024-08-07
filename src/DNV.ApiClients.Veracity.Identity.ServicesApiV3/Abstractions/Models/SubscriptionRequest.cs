// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.Identity.ServicesApiV3.Models
{
    using Newtonsoft.Json;
    public partial class SubscriptionRequest
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionRequest class.
        /// </summary>
        public SubscriptionRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionRequest class.
        /// </summary>
        /// <param name="serviceId">Mandatory, The service id to create the
        /// subscription for</param>
        /// <param name="role">Optional, the access level</param>
        /// <param name="sku">Optional, define the sku if applicable</param>
        /// <param name="overrideNotificationSettings">Optional, only to use if
        /// you need to override the service configuration. Possible values
        /// include: 'send', 'suppress', 'none'</param>
        public SubscriptionRequest(string serviceId = default, string role = default, string sku = default, OverrideTypes? overrideNotificationSettings = default)
        {
            ServiceId = serviceId;
            Role = role;
            Sku = sku;
            OverrideNotificationSettings = overrideNotificationSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets mandatory, The service id to create the subscription
        /// for
        /// </summary>
        [JsonProperty(PropertyName = "serviceId")]
        public string ServiceId { get; set; }

        /// <summary>
        /// Gets or sets optional, the access level
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        /// <summary>
        /// Gets or sets optional, define the sku if applicable
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or sets optional, only to use if you need to override the
        /// service configuration. Possible values include: 'send', 'suppress',
        /// 'none'
        /// </summary>
        [JsonProperty(PropertyName = "overrideNotificationSettings")]
        public OverrideTypes? OverrideNotificationSettings { get; set; }

    }
}
