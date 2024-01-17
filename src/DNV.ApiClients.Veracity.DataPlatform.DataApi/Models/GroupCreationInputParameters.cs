// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.DataPlatform.DataApi.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    public partial class GroupCreationInputParameters
    {
        /// <summary>
        /// Initializes a new instance of the GroupCreationInputParameters
        /// class.
        /// </summary>
        public GroupCreationInputParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GroupCreationInputParameters
        /// class.
        /// </summary>
        public GroupCreationInputParameters(string title, string description, IEnumerable<System.Guid?> resourceIds, double? sortingOrder = default)
        {
            Title = title;
            Description = description;
            ResourceIds = resourceIds;
            SortingOrder = sortingOrder;
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
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceIds")]
        public IEnumerable<System.Guid?> ResourceIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sortingOrder")]
        public double? SortingOrder { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Title == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Title");
            }
            if (Description == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Description");
            }
            if (ResourceIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceIds");
            }
        }
    }
}
