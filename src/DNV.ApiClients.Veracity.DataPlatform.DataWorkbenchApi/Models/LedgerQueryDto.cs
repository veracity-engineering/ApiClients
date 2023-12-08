// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataWorkbenchApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LedgerQueryDto
    {
        /// <summary>
        /// Initializes a new instance of the LedgerQueryDto class.
        /// </summary>
        public LedgerQueryDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LedgerQueryDto class.
        /// </summary>
        public LedgerQueryDto(int? pageSize = default, int? pageIndex = default)
        {
            PageSize = pageSize;
            PageIndex = pageIndex;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pageIndex")]
        public int? PageIndex { get; set; }

    }
}
