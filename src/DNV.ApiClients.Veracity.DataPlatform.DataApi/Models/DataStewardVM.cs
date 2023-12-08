// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DataStewardVM
    {
        /// <summary>
        /// Initializes a new instance of the DataStewardVM class.
        /// </summary>
        public DataStewardVM()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataStewardVM class.
        /// </summary>
        public DataStewardVM(System.Guid userId, System.Guid resourceId, System.Guid grantedBy, string comment = default)
        {
            UserId = userId;
            ResourceId = resourceId;
            GrantedBy = grantedBy;
            Comment = comment;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public System.Guid UserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public System.Guid ResourceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "grantedBy")]
        public System.Guid GrantedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}