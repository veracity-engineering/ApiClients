// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.Identity.PlatformApiV4.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    /// <summary>
    /// A paged list of items. This class is used to represent the result of a
    /// paged query.
    /// </summary>
    public partial class UserResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the UserResponseModel class.
        /// </summary>
        public UserResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserResponseModel class.
        /// </summary>
        /// <param name="items">The items in the current page</param>
        /// <param name="pageCount">The number of items in the current
        /// page</param>
        /// <param name="totalCount">The total number of items in the result
        /// set. This value is only present if the result set is paged.</param>
        /// <param name="nextPageUrl">Contains the relative url to the next
        /// page of the result set. The url is only present if there are more
        /// results to fetch. It assumes a constant page size.</param>
        public UserResponseModel(IEnumerable<UserResponse> items = default, int? pageCount = default, long? totalCount = default, string nextPageUrl = default)
        {
            Items = items;
            PageCount = pageCount;
            TotalCount = totalCount;
            NextPageUrl = nextPageUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the items in the current page
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IEnumerable<UserResponse> Items { get; set; }

        /// <summary>
        /// Gets the number of items in the current page
        /// </summary>
        [JsonProperty(PropertyName = "pageCount")]
        public int? PageCount { get; private set; }

        /// <summary>
        /// Gets the total number of items in the result set. This value is
        /// only present if the result set is paged.
        /// </summary>
        [JsonProperty(PropertyName = "totalCount")]
        public long? TotalCount { get; private set; }

        /// <summary>
        /// Gets or sets contains the relative url to the next page of the
        /// result set. The url is only present if there are more results to
        /// fetch. It assumes a constant page size.
        /// </summary>
        [JsonProperty(PropertyName = "nextPageUrl")]
        public string NextPageUrl { get; set; }

    }
}
