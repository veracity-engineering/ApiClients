// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracity.ApiClients.Identity.ServicesApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ErrorDetail
    {
        /// <summary>
        /// Initializes a new instance of the ErrorDetail class.
        /// </summary>
        public ErrorDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorDetail class.
        /// </summary>
        public ErrorDetail(int subCode, string message = default(string), string information = default(string), string supportCode = default(string))
        {
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
            //Nothing to validate
        }
    }
}
