// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataWorkbenchApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Sorting
    {
        /// <summary>
        /// Initializes a new instance of the Sorting class.
        /// </summary>
        public Sorting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Sorting class.
        /// </summary>
        /// <param name="order">Possible values include: 'Ascending',
        /// 'Descending'</param>
        public Sorting(string column = default, SortingOrder? order = default)
        {
            Column = column;
            Order = order;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "column")]
        public string Column { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Ascending', 'Descending'
        /// </summary>
        [JsonProperty(PropertyName = "order")]
        public SortingOrder? Order { get; set; }

    }
}
