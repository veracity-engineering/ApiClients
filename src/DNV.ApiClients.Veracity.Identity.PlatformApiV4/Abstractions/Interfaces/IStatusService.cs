// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.Identity.PlatformApiV4.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// StatusService operations.
    /// </summary>
    public partial interface IStatusService
    {
        /// <summary>
        /// Returns 200 when all dependencies are ok, 424 if there are some non
        /// essential dependency failures and 500 when essential dependencies
        /// are unreachable or the service is down&lt;br/&gt;
        /// </summary>
        /// <param name='requestId'>
        /// A correlation token to use when looking in the logs.
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
        Task<HttpOperationResponse<HealthStatus>> GetServiceHealthStatusWithHttpMessagesAsync(string requestId = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns 200 when all dependencies are ok, 424 if there are some non
        /// essential dependency failures and 500 when essential dependencies
        /// are unreachable or the service is down&lt;br/&gt;
        /// </summary>
        /// <param name='requestId'>
        /// A correlation token to use when looking in the logs.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HealthStatus> GetServiceHealthStatusAsync(string requestId = default, CancellationToken cancellationToken = default);

    }
}
