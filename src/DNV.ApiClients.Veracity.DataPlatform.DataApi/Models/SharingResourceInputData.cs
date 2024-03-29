// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.DataPlatform.DataApi.Models
{
    using Newtonsoft.Json;
    /// <summary>
    /// Type that contains required fields to perform a Resource Sharing
    /// </summary>
    public partial class SharingResourceInputData
    {
        /// <summary>
        /// Initializes a new instance of the SharingResourceInputData class.
        /// </summary>
        public SharingResourceInputData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SharingResourceInputData class.
        /// </summary>
        /// <param name="userId">Id of the target user</param>
        /// <param name="accessKeyTemplateId">Id of the sharing template from
        /// GET /api/1/keytemplates</param>
        /// <param name="comment">Optional comment field</param>
        public SharingResourceInputData(System.Guid userId, System.Guid accessKeyTemplateId, string comment = default, IpRange ipRange = default)
        {
            UserId = userId;
            AccessKeyTemplateId = accessKeyTemplateId;
            Comment = comment;
            IpRange = ipRange;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of the target user
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public System.Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets id of the sharing template from GET
        /// /api/1/keytemplates
        /// </summary>
        [JsonProperty(PropertyName = "accessKeyTemplateId")]
        public System.Guid AccessKeyTemplateId { get; set; }

        /// <summary>
        /// Gets or sets optional comment field
        /// </summary>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipRange")]
        public IpRange IpRange { get; set; }

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
