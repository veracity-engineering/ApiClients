// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.Identity.ServicesApiV3.Models
{
    using Newtonsoft.Json;
    public partial class TokenWrapper
    {
        /// <summary>
        /// Initializes a new instance of the TokenWrapper class.
        /// </summary>
        public TokenWrapper()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TokenWrapper class.
        /// </summary>
        /// <param name="expiry">The expiry time of the issued token in unix
        /// epoch</param>
        /// <param name="issued">The issued time of the token in unix
        /// epoch</param>
        /// <param name="authToken">The auth token to be included in
        /// 'me/pending/activation' and 'me/activate'</param>
        /// <param name="issuedBy">A unique string representing the issuer of
        /// the token</param>
        public TokenWrapper(long expiry, long issued, string authToken = default, string issuedBy = default)
        {
            Expiry = expiry;
            Issued = issued;
            AuthToken = authToken;
            IssuedBy = issuedBy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the expiry time of the issued token in unix epoch
        /// </summary>
        [JsonProperty(PropertyName = "expiry")]
        public long Expiry { get; set; }

        /// <summary>
        /// Gets or sets the issued time of the token in unix epoch
        /// </summary>
        [JsonProperty(PropertyName = "issued")]
        public long Issued { get; set; }

        /// <summary>
        /// Gets or sets the auth token to be included in
        /// 'me/pending/activation' and 'me/activate'
        /// </summary>
        [JsonProperty(PropertyName = "authToken")]
        public string AuthToken { get; set; }

        /// <summary>
        /// Gets or sets a unique string representing the issuer of the token
        /// </summary>
        [JsonProperty(PropertyName = "issuedBy")]
        public string IssuedBy { get; set; }

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