// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.ProvisionApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Icon
    {
        /// <summary>
        /// Initializes a new instance of the Icon class.
        /// </summary>
        public Icon()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Icon class.
        /// </summary>
        public Icon(string id = default, string backgroundColor = default)
        {
            Id = id;
            BackgroundColor = backgroundColor;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "backgroundColor")]
        public string BackgroundColor { get; set; }

    }
}