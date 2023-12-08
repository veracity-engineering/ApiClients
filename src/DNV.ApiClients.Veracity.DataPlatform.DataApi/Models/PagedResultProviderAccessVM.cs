// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataApi.Models
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
        public PagedResultProviderAccessVM(IEnumerable<ProviderAccessVM> results = default, int? page = default, int? resultsPerPage = default, int? totalPages = default, long? totalResults = default)
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
        public IEnumerable<ProviderAccessVM> Results { get; private set; }

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
