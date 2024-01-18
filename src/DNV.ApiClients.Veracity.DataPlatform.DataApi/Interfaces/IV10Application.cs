// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataApi.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// V10Application operations.
    /// </summary>
    public partial interface IV10Application
    {
        /// <summary>
        /// Returns information about the current application.
        /// </summary>
        /// <remarks>
        /// Returns information about the current application.
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
        Task<HttpOperationResponse<Application>> MeWithHttpMessagesAsync(Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a new application to Veracity data fabric.
        /// </summary>
        /// <remarks>
        /// Needs to have the role "DataAdmin" to perform this action
        /// </remarks>
        /// <param name='body'>
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
        Task<HttpOperationResponse> CreateWithHttpMessagesAsync(Application body = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets information about an application in Veracity data fabric.
        /// </summary>
        /// <remarks>
        /// Gets information about an application in Veracity data fabric.
        /// </remarks>
        /// <param name='applicationId'>
        /// Format - uuid. AAD B2C Application Id
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Application>> GetWithHttpMessagesAsync(string applicationId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update role of a application on Veracity data fabric.
        /// </summary>
        /// <remarks>
        /// Needs to have the role "DataAdmin" to perform this action
        /// </remarks>
        /// <param name='applicationId'>
        /// Format - uuid. AAD B2C Application Id
        /// </param>
        /// <param name='role'>
        /// Role name. Possible values include: 'none', 'manager', 'consumer',
        /// 'fullAll', 'identity', 'dataAdmin'
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
        Task<HttpOperationResponse> UpdateRoleWithHttpMessagesAsync(string applicationId, string role, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);
    }
}
