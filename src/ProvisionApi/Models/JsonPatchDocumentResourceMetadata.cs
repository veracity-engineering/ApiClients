// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.ProvisionApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class JsonPatchDocumentResourceMetadata
    {
        /// <summary>
        /// Initializes a new instance of the JsonPatchDocumentResourceMetadata
        /// class.
        /// </summary>
        public JsonPatchDocumentResourceMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JsonPatchDocumentResourceMetadata
        /// class.
        /// </summary>
        public JsonPatchDocumentResourceMetadata(IList<OperationResourceMetadata> operations = default)
        {
            Operations = operations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operations")]
        public IList<OperationResourceMetadata> Operations { get; private set; }

    }
}
