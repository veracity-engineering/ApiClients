// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracity.ApiClients.MyServices.MyServicesV3Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for GetUsersIn operation.
    /// </summary>
    public partial class UsersDirectoryGetUsersInHeaders
    {
        /// <summary>
        /// Initializes a new instance of the UsersDirectoryGetUsersInHeaders
        /// class.
        /// </summary>
        public UsersDirectoryGetUsersInHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UsersDirectoryGetUsersInHeaders
        /// class.
        /// </summary>
        /// <param name="xSupportCode">correlation token for log
        /// lookup.</param>
        public UsersDirectoryGetUsersInHeaders(string xSupportCode = default(string))
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
