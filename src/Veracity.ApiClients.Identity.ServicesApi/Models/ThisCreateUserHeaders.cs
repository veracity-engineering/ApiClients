// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracity.ApiClients.Identity.ServicesApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for CreateUser operation.
    /// </summary>
    public partial class ThisCreateUserHeaders
    {
        /// <summary>
        /// Initializes a new instance of the ThisCreateUserHeaders class.
        /// </summary>
        public ThisCreateUserHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ThisCreateUserHeaders class.
        /// </summary>
        /// <param name="xSupportCode">correlation token for log
        /// lookup.</param>
        public ThisCreateUserHeaders(string xSupportCode = default(string))
        {
            XSupportCode = xSupportCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets correlation token for log lookup.
        /// </summary>
        [JsonProperty(PropertyName = "x-supportCode")]
        public string XSupportCode { get; set; }

    }
}
