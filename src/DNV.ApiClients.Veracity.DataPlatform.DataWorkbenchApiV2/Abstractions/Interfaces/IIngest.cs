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
    /// Ingest operations.
    /// </summary>
    public partial interface IIngest
    {
        /// <summary>
        /// Get data ingest endpoint for current workspace
        /// </summary>
        /// <remarks>
        /// Sample request
        ///
        /// dfs:
        /// POST {workspaceId}/Ingest?type=dfs
        /// POST
        /// {workspaceId}/Ingest?datasetId=be072260-78d9-4e14-ac16-942284026577&amp;type=dfs
        /// blob:
        /// POST {workspaceId}/Ingest?type=blob
        /// POST
        /// {workspaceId}/Ingest?datasetId=be072260-78d9-4e14-ac16-942284026577&amp;type=blob
        ///
        /// Sample response
        ///
        /// dfs:
        /// https://{domain}.dfs.core.windows.net/196a8ff4-dfbc-4ee7-ae08-4f38b84d9c86/a16d1d0d-2b92-4e71-b2a1-2931ce61c863/Raw?sv=2023-11-03&amp;spr=https&amp;st=2024-07-12T01%3A55%3A12Z&amp;se=2024-07-12T02%3A10%3A12Z&amp;sr=d&amp;sp=cw&amp;sdd=2&amp;sig=%2BaxD8B250vI0bJn9u8KHRv7duvLjqXlhOfVBOCi5Cqo%3D
        /// blob:
        /// https://{domain}.blob.core.windows.net/196a8ff4-dfbc-4ee7-ae08-4f38b84d9c86/f5a0ef4c-e76f-4d1c-9b0d-947c8b7923ff/Raw?sv=2023-11-03&amp;spr=https&amp;st=2024-07-12T01%3A56%3A01Z&amp;se=2024-07-12T02%3A11%3A01Z&amp;sr=d&amp;sp=cw&amp;sdd=2&amp;sig=EzfaySpQ5hAN2eLEAPp4vhRIyvMUDikD4iFKDmagpKM%3D
        /// </remarks>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='datasetId'>
        /// </param>
        /// <param name='type'>
        /// Possible values include: 'dfs', 'blob'
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
        Task<HttpOperationResponse<string>> GenerateByodStorageWithHttpMessagesAsync(System.Guid workspaceId, System.Guid? datasetId = default, string type = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get data ingest endpoint for current workspace
        /// </summary>
        /// <remarks>
        /// Sample request
        ///
        /// dfs:
        /// POST {workspaceId}/Ingest?type=dfs
        /// POST
        /// {workspaceId}/Ingest?datasetId=be072260-78d9-4e14-ac16-942284026577&amp;type=dfs
        /// blob:
        /// POST {workspaceId}/Ingest?type=blob
        /// POST
        /// {workspaceId}/Ingest?datasetId=be072260-78d9-4e14-ac16-942284026577&amp;type=blob
        ///
        /// Sample response
        ///
        /// dfs:
        /// https://{domain}.dfs.core.windows.net/196a8ff4-dfbc-4ee7-ae08-4f38b84d9c86/a16d1d0d-2b92-4e71-b2a1-2931ce61c863/Raw?sv=2023-11-03&amp;spr=https&amp;st=2024-07-12T01%3A55%3A12Z&amp;se=2024-07-12T02%3A10%3A12Z&amp;sr=d&amp;sp=cw&amp;sdd=2&amp;sig=%2BaxD8B250vI0bJn9u8KHRv7duvLjqXlhOfVBOCi5Cqo%3D
        /// blob:
        /// https://{domain}.blob.core.windows.net/196a8ff4-dfbc-4ee7-ae08-4f38b84d9c86/f5a0ef4c-e76f-4d1c-9b0d-947c8b7923ff/Raw?sv=2023-11-03&amp;spr=https&amp;st=2024-07-12T01%3A56%3A01Z&amp;se=2024-07-12T02%3A11%3A01Z&amp;sr=d&amp;sp=cw&amp;sdd=2&amp;sig=EzfaySpQ5hAN2eLEAPp4vhRIyvMUDikD4iFKDmagpKM%3D
        /// </remarks>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='datasetId'>
        /// </param>
        /// <param name='type'>
        /// Possible values include: 'dfs', 'blob'
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<string> GenerateByodStorageAsync(System.Guid workspaceId, System.Guid? datasetId = default, string type = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Import a dataset to the workspace
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
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<DataCatalogReadDtoV2>> ImportDatasetWithHttpMessagesAsync(ImportDatasetDTO body, System.Guid workspaceId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Import a dataset to the workspace
        /// </summary>
        /// <param name='body'>
        /// </param>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<DataCatalogReadDtoV2> ImportDatasetAsync(ImportDatasetDTO body, System.Guid workspaceId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve the content of the BYOD status file
        /// </summary>
        /// <remarks>
        /// Sample Response
        ///
        /// {
        /// "status": "Started",
        /// "correlationId": "203bfa0b-86c3-4467-a3b0-d2eb415a96cc",
        /// "fileName": "TestUpload.csv"
        /// }
        ///
        /// {
        /// "status": "Completed",
        /// "correlationId": "203bfa0b-86c3-4467-a3b0-d2eb415a96cc",
        /// "fileName": "TestUpload.csv",
        /// "dataSetName": "TestUploadLILN"
        /// }
        /// </remarks>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='requestId'>
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
        Task<HttpOperationResponse<StatusLogModel>> GetStatusLogWithHttpMessagesAsync(System.Guid workspaceId, System.Guid requestId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve the content of the BYOD status file
        /// </summary>
        /// <remarks>
        /// Sample Response
        ///
        /// {
        /// "status": "Started",
        /// "correlationId": "203bfa0b-86c3-4467-a3b0-d2eb415a96cc",
        /// "fileName": "TestUpload.csv"
        /// }
        ///
        /// {
        /// "status": "Completed",
        /// "correlationId": "203bfa0b-86c3-4467-a3b0-d2eb415a96cc",
        /// "fileName": "TestUpload.csv",
        /// "dataSetName": "TestUploadLILN"
        /// }
        /// </remarks>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='requestId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<StatusLogModel> GetStatusLogAsync(System.Guid workspaceId, System.Guid requestId, CancellationToken cancellationToken = default);

    }
}
