// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracity.ApiClients.DataPlatform.DataApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class PagedResultProviderAccessVM
    {
        /// <summary>
        /// Initializes a new instance of the PagedResultProviderAccessVM
        /// class.
        /// </summary>
        public PagedResultProviderAccessVM()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PagedResultProviderAccessVM
        /// class.
        /// </summary>
        public PagedResultProviderAccessVM(IList<ProviderAccessVM> results = default(IList<ProviderAccessVM>), int? page = default(int?), int? resultsPerPage = default(int?), int? totalPages = default(int?), long? totalResults = default(long?))
        {
            Results = results;
            Page = page;
            ResultsPerPage = resultsPerPage;
            TotalPages = totalPages;
            TotalResults = totalResults;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<ProviderAccessVM> Results { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "page")]
        public int? Page { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resultsPerPage")]
        public int? ResultsPerPage { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalPages")]
        public int? TotalPages { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalResults")]
        public long? TotalResults { get; private set; }

    }
}
