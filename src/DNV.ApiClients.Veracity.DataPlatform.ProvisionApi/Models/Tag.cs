// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.ProvisionApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Tag
    {
        /// <summary>
        /// Initializes a new instance of the Tag class.
        /// </summary>
        public Tag()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Tag class.
        /// </summary>
        /// <param name="type">Possible values include: 'userTag',
        /// 'systemTag'</param>
        public Tag(System.Guid? id = default, string title = default, TagType? type = default)
        {
            Id = id;
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
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'userTag', 'systemTag'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public TagType? Type { get; set; }

    }
}
