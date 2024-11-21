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
    /// Datasets operations.
    /// </summary>
    public partial interface IDatasets
    {
        /// <summary>
        /// Download Statement of Compliance PDF file based on workspaceId,
        /// datasetId and documentId
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
        Task<HttpOperationResponse> SocDownloadWithHttpMessagesAsync(DocumentRefDTO body, System.Guid workspaceId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Download Statement of Compliance PDF file based on workspaceId,
        /// datasetId and documentId
        /// </summary>
        /// <param name='body'>
        /// </param>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task SocDownloadAsync(DocumentRefDTO body, System.Guid workspaceId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get all data sets for a specific workspace. Supports pagination,
        /// enhanced filtering and sorting.
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
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
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<DataCatalogReadDtoV2PaginatedResult>> GetDataCatalogsQueryWithHttpMessagesAsync(System.Guid workspaceId, DataCatalogQueryDto body = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get all data sets for a specific workspace. Supports pagination,
        /// enhanced filtering and sorting.
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<DataCatalogReadDtoV2PaginatedResult> GetDataCatalogsQueryAsync(System.Guid workspaceId, DataCatalogQueryDto body = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a specific data set by Workspace Id and DataSet Id
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='datasetId'>
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
        Task<HttpOperationResponse<DataCatalogReadDtoV2>> GetDataCatalogByIdV2WithHttpMessagesAsync(System.Guid workspaceId, System.Guid datasetId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a specific data set by Workspace Id and DataSet Id
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='datasetId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<DataCatalogReadDtoV2> GetDataCatalogByIdV2Async(System.Guid workspaceId, System.Guid datasetId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets Dataset Ledger based on workspaceId and datasetId
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='datasetId'>
        /// </param>
        /// <param name='pageSize'>
        /// </param>
        /// <param name='pageIndex'>
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
        Task<HttpOperationResponse<LedgerDtoPaginatedResult>> GetDataCatalogLedgerWithHttpMessagesAsync(System.Guid workspaceId, System.Guid datasetId, int? pageSize = default, int? pageIndex = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets Dataset Ledger based on workspaceId and datasetId
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='datasetId'>
        /// </param>
        /// <param name='pageSize'>
        /// </param>
        /// <param name='pageIndex'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<LedgerDtoPaginatedResult> GetDataCatalogLedgerAsync(System.Guid workspaceId, System.Guid datasetId, int? pageSize = default, int? pageIndex = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Query for data by Workspace Id and DataSet Id with optional filters
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='datasetId'>
        /// </param>
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
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<QueryData>> QueryDataSetWithHttpMessagesAsync(System.Guid workspaceId, System.Guid datasetId, QuerySpecificationV2 body = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Query for data by Workspace Id and DataSet Id with optional filters
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='datasetId'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<QueryData> QueryDataSetAsync(System.Guid workspaceId, System.Guid datasetId, QuerySpecificationV2 body = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a readonly SAS token for a given workspace dataset
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='datasetId'>
        /// </param>
        /// <param name='durationInMinutes'>
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<string>> GetDatasetFolderReadonlyTokenWithHttpMessagesAsync(System.Guid workspaceId, System.Guid datasetId, int durationInMinutes, string type, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a readonly SAS token for a given workspace dataset
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='datasetId'>
        /// </param>
        /// <param name='durationInMinutes'>
        /// </param>
        /// <param name='type'>
        /// Possible values include: 'dfs', 'blob'
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<string> GetDatasetFolderReadonlyTokenAsync(System.Guid workspaceId, System.Guid datasetId, int durationInMinutes, string type, CancellationToken cancellationToken = default);

    }
}
