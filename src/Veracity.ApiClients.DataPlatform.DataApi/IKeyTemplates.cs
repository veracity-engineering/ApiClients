// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracity.ApiClients.DataPlatform.DataApi
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// KeyTemplates operations.
    /// </summary>
    public partial interface IKeyTemplates
    {
        /// <summary>
        /// Returns the templates for the different types of keys you can
        /// generate.
        /// </summary>
        /// <remarks>
        /// Returns the template for the different types of keys you can
        /// generate.
        /// Blob Storage is the only storage type supported at the moment.
        ///
        /// Supported access types for the Blob Storage types are as follows:
        /// 1. Write key
        /// 2. Read and list key
        /// 3. Read, write and list key
        /// 4. Read, write, delete and list key
        /// For Each access type there are key templates that lasts 1 h, 8 h, 1
        /// month, 2 months, 3 months, 4 months, 5 months and 6 months.
        ///
        /// Note : "IsSystemKey" field in the result data is not relevant for
        /// the functionality currently supported. Please ignore that field.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<IList<KeyTemplateVM>>> GetStorageKeyTemplatesWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
