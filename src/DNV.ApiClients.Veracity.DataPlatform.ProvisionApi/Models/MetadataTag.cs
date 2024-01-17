// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.DataPlatform.ProvisionApi.Models
{
    using Newtonsoft.Json;
    public partial class MetadataTag
    {
        /// <summary>
        /// Initializes a new instance of the MetadataTag class.
        /// </summary>
        public MetadataTag()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetadataTag class.
        /// </summary>
        /// <param name="type">Possible values include: 'userTag',
        /// 'systemTag'</param>
        public MetadataTag(string title = default, MetadataTagType? type = default)
        {
            Title = title;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'userTag', 'systemTag'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public MetadataTagType? Type { get; set; }

    }
}
