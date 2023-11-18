// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.ProvisionApi.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DeleteContainerSubscriptionRequestVm
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DeleteContainerSubscriptionRequestVm class.
        /// </summary>
        public DeleteContainerSubscriptionRequestVm()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DeleteContainerSubscriptionRequestVm class.
        /// </summary>
        public DeleteContainerSubscriptionRequestVm(string subscriptionName, System.Guid containerId)
        {
            SubscriptionName = subscriptionName;
            ContainerId = containerId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionName")]
        public string SubscriptionName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "containerId")]
        public System.Guid ContainerId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SubscriptionName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SubscriptionName");
            }
        }
    }
}
