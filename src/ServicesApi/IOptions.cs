// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.Identity.ServicesApi
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Options operations.
    /// </summary>
    public partial interface IOptions
    {
        /// <summary>
        /// Options_ServiceStatus
        /// </summary>
        /// <remarks>
        /// Get the status of the service container.
        /// </remarks>
        /// <param name='xSupportCode'>
        /// Provide a correlation token for log lookup. This is optional.
        /// </param>
        /// <param name='ocpApimSubscriptionKey'>
        /// Veracity api management subscription key
        /// </param>
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
        Task<HttpOperationResponse<IDictionary<string, string>,OptionsServiceStatusHeaders>> ServiceStatusWithHttpMessagesAsync(string xSupportCode = default(string), string ocpApimSubscriptionKey = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Options_InvalidateCache
        /// </summary>
        /// <remarks>
        /// Invalidate the cached item with the provided id
        /// </remarks>
        /// <param name='id'>
        /// </param>
        /// <param name='xSupportCode'>
        /// Provide a correlation token for log lookup. This is optional.
        /// </param>
        /// <param name='ocpApimSubscriptionKey'>
        /// Veracity api management subscription key
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationHeaderResponse<OptionsInvalidateCacheHeaders>> InvalidateCacheWithHttpMessagesAsync(string id, string xSupportCode = default(string), string ocpApimSubscriptionKey = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}