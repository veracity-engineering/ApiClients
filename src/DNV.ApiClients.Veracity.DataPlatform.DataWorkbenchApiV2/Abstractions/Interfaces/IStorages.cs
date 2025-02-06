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
    /// Storages operations.
    /// </summary>
    public partial interface IStorages
    {
        /// <summary>
        /// Get storage sas token by share id
        /// </summary>
        /// <param name='workspaceId'>
        /// The id of the workspace
        /// </param>
        /// <param name='shareId'>
        /// Share id of the dataset
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
        Task<HttpOperationResponse<string>> GetSASTokenForStorageDatasetByShareIdWithHttpMessagesAsync(System.Guid workspaceId, System.Guid shareId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get storage sas token by share id
        /// </summary>
        /// <param name='workspaceId'>
        /// The id of the workspace
        /// </param>
        /// <param name='shareId'>
        /// Share id of the dataset
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<string> GetSASTokenForStorageDatasetByShareIdAsync(System.Guid workspaceId, System.Guid shareId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get storage sas token for current workspace
        /// </summary>
        /// <remarks>
        /// Sample request For Storage Sas Token:
        ///
        /// POST {workspaceId}/storages/sas
        /// {
        /// "path": "18a4a7ab-022c-4964-9d1b-6cc77e252a67/test.csv",
        /// "readOrWritePermission": "Read",
        /// "startsOn": "2024-05-14T09:04:12.297Z",
        /// "expiresOn": "2024-05-14T09:04:12.297Z",
        /// "storageName": "StorageDataset"
        /// }
        /// * Path – string, path of the resource you want to generate the SAS
        /// Token for. It is optional, if it is left empty or not provided, the
        /// default path of internal storage will be considered.(which means
        /// ContainerName which was specified while creating the internal
        /// storage). If provided, it should be valid path pointing to a
        /// resource.
        /// * ReadOrWritePermission – string, type of permission you want to
        /// give on the resource, it can only have values Read/Write.
        /// * StartsOn – DateTime, datetime from which the SAS Token will be
        /// valid. It is optional, if not provided current UTC date time will
        /// be considered. If provided, it should not be a past date time.
        /// * ExpiresOn – DateTime, datetime till when the SAS Token will be
        /// valid.It should not be a past date time and should be greater than
        /// StartsOn.
        /// * StorageName - string, name of the storage for which the SAS token
        /// needs to be generated. It is optional, if not provided the default
        /// internal storage dataset will be considered. If it is provided it
        /// should be a valid storage dataset name.
        ///
        /// Notes -
        /// * A user of Workspace who has role of Reader can only generate
        /// tokens with Read permission, if he tries to generate token with
        /// Write permission, he will be unauthorized.
        /// * A user of Workspace who has role of Administrator can generate
        /// tokens with both Read/Write permissions.
        /// * Service Accounts should generate only Read token. If they need to
        /// generate Write SAS Token, they need to get access for it.
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
        Task<HttpOperationResponse<string>> GetSASTokenForStorageDatasetWithHttpMessagesAsync(StorageQueryDto body, System.Guid workspaceId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get storage sas token for current workspace
        /// </summary>
        /// <remarks>
        /// Sample request For Storage Sas Token:
        ///
        /// POST {workspaceId}/storages/sas
        /// {
        /// "path": "18a4a7ab-022c-4964-9d1b-6cc77e252a67/test.csv",
        /// "readOrWritePermission": "Read",
        /// "startsOn": "2024-05-14T09:04:12.297Z",
        /// "expiresOn": "2024-05-14T09:04:12.297Z",
        /// "storageName": "StorageDataset"
        /// }
        /// * Path – string, path of the resource you want to generate the SAS
        /// Token for. It is optional, if it is left empty or not provided, the
        /// default path of internal storage will be considered.(which means
        /// ContainerName which was specified while creating the internal
        /// storage). If provided, it should be valid path pointing to a
        /// resource.
        /// * ReadOrWritePermission – string, type of permission you want to
        /// give on the resource, it can only have values Read/Write.
        /// * StartsOn – DateTime, datetime from which the SAS Token will be
        /// valid. It is optional, if not provided current UTC date time will
        /// be considered. If provided, it should not be a past date time.
        /// * ExpiresOn – DateTime, datetime till when the SAS Token will be
        /// valid.It should not be a past date time and should be greater than
        /// StartsOn.
        /// * StorageName - string, name of the storage for which the SAS token
        /// needs to be generated. It is optional, if not provided the default
        /// internal storage dataset will be considered. If it is provided it
        /// should be a valid storage dataset name.
        ///
        /// Notes -
        /// * A user of Workspace who has role of Reader can only generate
        /// tokens with Read permission, if he tries to generate token with
        /// Write permission, he will be unauthorized.
        /// * A user of Workspace who has role of Administrator can generate
        /// tokens with both Read/Write permissions.
        /// * Service Accounts should generate only Read token. If they need to
        /// generate Write SAS Token, they need to get access for it.
        /// </remarks>
        /// <param name='body'>
        /// </param>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<string> GetSASTokenForStorageDatasetAsync(StorageQueryDto body, System.Guid workspaceId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets Storage DataSets by workspaceId
        /// </summary>
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
        Task<HttpOperationResponse<DataCatalogReadDtoV2PaginatedResult>> GetStorageDatasetsByWorkspaceIdWithHttpMessagesAsync(System.Guid workspaceId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets Storage DataSets by workspaceId
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<DataCatalogReadDtoV2PaginatedResult> GetStorageDatasetsByWorkspaceIdAsync(System.Guid workspaceId, CancellationToken cancellationToken = default);

    }
}
