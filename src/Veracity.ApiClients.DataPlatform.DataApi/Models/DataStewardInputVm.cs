// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracity.ApiClients.DataPlatform.DataApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DataStewardInputVm
    {
        /// <summary>
        /// Initializes a new instance of the DataStewardInputVm class.
        /// </summary>
        public DataStewardInputVm()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataStewardInputVm class.
        /// </summary>
        public DataStewardInputVm(string comment = default(string))
        {
            Comment = comment;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

    }
}
