// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataWorkbenchApi
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Analysis operations.
    /// </summary>
    public partial interface IAnalysis
    {
        /// <summary>
        /// Execute Python on a dataset, upon completion a notificaiton will be
        /// triggered to user
        /// </summary>
        /// <param name='body'>
        /// </param>
        /// <param name='workspaceId'>
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
        Task<HttpOperationResponse> ExecutePythonWithHttpMessagesAsync(ExecutionWriteDTO body, System.Guid workspaceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default);
    }
}
