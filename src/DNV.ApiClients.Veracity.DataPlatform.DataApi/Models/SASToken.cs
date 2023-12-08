// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SASToken
    {
        /// <summary>
        /// Initializes a new instance of the SASToken class.
        /// </summary>
        public SASToken()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SASToken class.
        /// </summary>
        public SASToken(string sasKey = default, string sasuRi = default, string fullKey = default, System.DateTime? sasKeyExpiryTimeUTC = default, bool? isKeyExpired = default, bool? autoRefreshed = default, IpRange ipRange = default)
        {
            SasKey = sasKey;
            SasuRi = sasuRi;
            FullKey = fullKey;
            SasKeyExpiryTimeUTC = sasKeyExpiryTimeUTC;
            IsKeyExpired = isKeyExpired;
            AutoRefreshed = autoRefreshed;
            IpRange = ipRange;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sasKey")]
        public string SasKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sasuRi")]
        public string SasuRi { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fullKey")]
        public string FullKey { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sasKeyExpiryTimeUTC")]
        public System.DateTime? SasKeyExpiryTimeUTC { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isKeyExpired")]
        public bool? IsKeyExpired { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "autoRefreshed")]
        public bool? AutoRefreshed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipRange")]
        public IpRange IpRange { get; set; }

    }
}
