// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.Identity.ServicesApiV3.Models
{
    using Newtonsoft.Json;
    /// <summary>
    /// Defines headers for ActivateUserAccount operation.
    /// </summary>
    public partial class UsersDirectoryActivateUserAccountHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UsersDirectoryActivateUserAccountHeaders class.
        /// </summary>
        public UsersDirectoryActivateUserAccountHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// UsersDirectoryActivateUserAccountHeaders class.
        /// </summary>
        /// <param name="xSupportCode">correlation token for log
        /// lookup.</param>
        public UsersDirectoryActivateUserAccountHeaders(string xSupportCode = default)
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
