// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataWorkbenchApiV2.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Shares operations.
    /// </summary>
    public partial interface IShares
    {
        /// <summary>
        /// Get share owner info by dataset ID list
        /// </summary>
        /// <remarks>
        /// Sample response for shared owner info:
        ///
        /// [
        /// {
        /// "datasetId": "f80b0de1-3b1d-4a64-aa4d-88d6073ff1cd",    // Id of
        /// the dataset
        /// "sharedBy": {
        /// "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",   // Id of the shared
        /// user
        /// "sharedByType": "User",
        /// "name": "User Name"  // Name of the shared user
        /// }
        /// },
        /// {
        /// "datasetId": "6113fcaa-a29e-4804-b9a9-dac331676ee8",    // Id of
        /// the dataset
        /// "sharedBy": {
        /// "id": "a1d9ef10-39c3-4d3a-8c33-241a0b1138a1",   // Id of the shared
        /// workspace
        /// "sharedByType": "Workspace",
        /// "name": "Workspace Name"  // Name of the shared workspace
        /// }
        /// }
        /// ]
        /// </remarks>
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
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IEnumerable<SharedByInfoResultDTO>>> QuerySharedBysWithHttpMessagesAsync(SharedBysQueryDTO body, System.Guid workspaceId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get share owner info by dataset ID list
        /// </summary>
        /// <remarks>
        /// Sample response for shared owner info:
        ///
        /// [
        /// {
        /// "datasetId": "f80b0de1-3b1d-4a64-aa4d-88d6073ff1cd",    // Id of
        /// the dataset
        /// "sharedBy": {
        /// "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",   // Id of the shared
        /// user
        /// "sharedByType": "User",
        /// "name": "User Name"  // Name of the shared user
        /// }
        /// },
        /// {
        /// "datasetId": "6113fcaa-a29e-4804-b9a9-dac331676ee8",    // Id of
        /// the dataset
        /// "sharedBy": {
        /// "id": "a1d9ef10-39c3-4d3a-8c33-241a0b1138a1",   // Id of the shared
        /// workspace
        /// "sharedByType": "Workspace",
        /// "name": "Workspace Name"  // Name of the shared workspace
        /// }
        /// }
        /// ]
        /// </remarks>
        /// <param name='body'>
        /// </param>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<IEnumerable<SharedByInfoResultDTO>> QuerySharedBysAsync(SharedBysQueryDTO body, System.Guid workspaceId, CancellationToken cancellationToken = default);

    }
}
