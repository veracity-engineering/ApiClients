// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataValidatorApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SASDTO
    {
        /// <summary>
        /// Initializes a new instance of the SASDTO class.
        /// </summary>
        public SASDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SASDTO class.
        /// </summary>
        public SASDTO(string url = default)
        {
            Url = url;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

    }
}