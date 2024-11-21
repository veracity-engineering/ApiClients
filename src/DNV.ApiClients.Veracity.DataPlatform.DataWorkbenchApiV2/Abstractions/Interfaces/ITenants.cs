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
    /// Tenants operations.
    /// </summary>
    public partial interface ITenants
    {
        /// <summary>
        /// Get users with role scopes in specified tenant
        /// </summary>
        /// <remarks>
        /// Sample response for paginated result of user role scopes info:
        ///
        /// {
        /// "result": [
        /// {
        /// "userId": "ddbf7526-abc3-45e2-bfd9-a2223a431a12",
        /// "email": "Jane.Yao@dnv.com",
        /// "name": "Jane Yao",
        /// "isServicePrincipal": false,
        /// "roleScope": {
        /// "role": "administrator",
        /// "scopeType": "Tenant",
        /// "scopeRef": "c39867d7-a4c0-4ae2-8281-7d45936a3bec"
        /// }
        /// },
        /// {
        /// "userId": "e574383d-994e-4a3d-9a7d-5d76755552e1",
        /// "email": "Jork.Cao@dnv.com",
        /// "name": "Jork Cao",
        /// "isServicePrincipal": false,
        /// "roleScope": {
        /// "role": "reader",
        /// "scopeType": "Tenant",
        /// "scopeRef": "c39867d7-a4c0-4ae2-8281-7d45936a3bec"
        /// }
        /// }
        /// ],
        /// "pageIndex": 1,
        /// "pageSize": 2,
        /// "totalCount": 65,
        /// "totalPages": 33
        /// }
        /// </remarks>
        /// <param name='tenantId'>
        /// The tenant id which you want to get user role scopes
        /// </param>
        /// <param name='pageIndex'>
        /// Index of the current page (optional)
        /// </param>
        /// <param name='pageSize'>
        /// Number of items per page (optional)
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
        Task<HttpOperationResponse> QueryTenantUserRoleScopesWithHttpMessagesAsync(System.Guid tenantId, int? pageIndex = default, int? pageSize = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get users with role scopes in specified tenant
        /// </summary>
        /// <remarks>
        /// Sample response for paginated result of user role scopes info:
        ///
        /// {
        /// "result": [
        /// {
        /// "userId": "ddbf7526-abc3-45e2-bfd9-a2223a431a12",
        /// "email": "Jane.Yao@dnv.com",
        /// "name": "Jane Yao",
        /// "isServicePrincipal": false,
        /// "roleScope": {
        /// "role": "administrator",
        /// "scopeType": "Tenant",
        /// "scopeRef": "c39867d7-a4c0-4ae2-8281-7d45936a3bec"
        /// }
        /// },
        /// {
        /// "userId": "e574383d-994e-4a3d-9a7d-5d76755552e1",
        /// "email": "Jork.Cao@dnv.com",
        /// "name": "Jork Cao",
        /// "isServicePrincipal": false,
        /// "roleScope": {
        /// "role": "reader",
        /// "scopeType": "Tenant",
        /// "scopeRef": "c39867d7-a4c0-4ae2-8281-7d45936a3bec"
        /// }
        /// }
        /// ],
        /// "pageIndex": 1,
        /// "pageSize": 2,
        /// "totalCount": 65,
        /// "totalPages": 33
        /// }
        /// </remarks>
        /// <param name='tenantId'>
        /// The tenant id which you want to get user role scopes
        /// </param>
        /// <param name='pageIndex'>
        /// Index of the current page (optional)
        /// </param>
        /// <param name='pageSize'>
        /// Number of items per page (optional)
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task QueryTenantUserRoleScopesAsync(System.Guid tenantId, int? pageIndex = default, int? pageSize = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get workspace list which the current user has access to for a
        /// specified tenant
        /// </summary>
        /// <remarks>
        /// Sample response for Workspace list info:
        ///
        /// [
        /// {
        /// "id": "6113fcaa-a29e-4804-b9a9-dac331676008",
        /// "name": "Workspace Name1",
        /// "description": "Workspace created by test1",
        /// "region": "EU"
        /// },
        /// {
        /// "id": "89a1fcaa-D43e-9802-c879-cad886785129",
        /// "name": "Workspace Name2",
        /// "description": "Workspace created by test2",
        /// "region": "EU"
        /// }
        /// ]
        /// </remarks>
        /// <param name='tenantId'>
        /// The tenant id of the workspaces that you want to get
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
        Task<HttpOperationResponse<IEnumerable<WorkspaceDto>>> RetrieveAllWorkspacesWithHttpMessagesAsync(System.Guid tenantId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get workspace list which the current user has access to for a
        /// specified tenant
        /// </summary>
        /// <remarks>
        /// Sample response for Workspace list info:
        ///
        /// [
        /// {
        /// "id": "6113fcaa-a29e-4804-b9a9-dac331676008",
        /// "name": "Workspace Name1",
        /// "description": "Workspace created by test1",
        /// "region": "EU"
        /// },
        /// {
        /// "id": "89a1fcaa-D43e-9802-c879-cad886785129",
        /// "name": "Workspace Name2",
        /// "description": "Workspace created by test2",
        /// "region": "EU"
        /// }
        /// ]
        /// </remarks>
        /// <param name='tenantId'>
        /// The tenant id of the workspaces that you want to get
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<IEnumerable<WorkspaceDto>> RetrieveAllWorkspacesAsync(System.Guid tenantId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Add a new workspace to the specified tenant
        /// </summary>
        /// <remarks>
        /// Sample response for created workspace info:
        ///
        /// {
        /// "id": "196a8ff4-dfbc-4ee7-ae08-4f38b84d9c86",
        /// "name": "SHANGHAI",
        /// "description": "WS SHANGHAI",
        /// "region": "EU"
        /// }
        /// </remarks>
        /// <param name='body'>
        /// </param>
        /// <param name='tenantId'>
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
        Task<HttpOperationResponse<WorkspaceDto>> CreateWorkspaceV2WithHttpMessagesAsync(WorkspaceCreationDtoV2 body, System.Guid tenantId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Add a new workspace to the specified tenant
        /// </summary>
        /// <remarks>
        /// Sample response for created workspace info:
        ///
        /// {
        /// "id": "196a8ff4-dfbc-4ee7-ae08-4f38b84d9c86",
        /// "name": "SHANGHAI",
        /// "description": "WS SHANGHAI",
        /// "region": "EU"
        /// }
        /// </remarks>
        /// <param name='body'>
        /// </param>
        /// <param name='tenantId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<WorkspaceDto> CreateWorkspaceV2Async(WorkspaceCreationDtoV2 body, System.Guid tenantId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get workspace by id
        /// </summary>
        /// <remarks>
        /// Sample response for Workspace info:
        ///
        /// {
        /// "id": "6113fcaa-a29e-4804-b9a9-dac331676008",
        /// "name": "Workspace Name1",
        /// "description": "Workspace created by test1",
        /// "region": "EU"
        /// }
        /// </remarks>
        /// <param name='workspaceId'>
        /// The workspace id of the workspace that you want to get
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
        Task<HttpOperationResponse<WorkspaceDto>> RetrieveWorkspaceWithHttpMessagesAsync(System.Guid workspaceId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get workspace by id
        /// </summary>
        /// <remarks>
        /// Sample response for Workspace info:
        ///
        /// {
        /// "id": "6113fcaa-a29e-4804-b9a9-dac331676008",
        /// "name": "Workspace Name1",
        /// "description": "Workspace created by test1",
        /// "region": "EU"
        /// }
        /// </remarks>
        /// <param name='workspaceId'>
        /// The workspace id of the workspace that you want to get
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<WorkspaceDto> RetrieveWorkspaceAsync(System.Guid workspaceId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get users with role scopes in specified workspace
        /// </summary>
        /// <remarks>
        /// Sample response for paginated result of user role scopes info:
        ///
        /// {
        /// "result": [
        /// {
        /// "userId": "3e4d0494-0bad-41fb-aa1f-0c2e53516171",
        /// "email": "Nana.Ouyang@dnv.com",
        /// "name": "Nana Ouyang",
        /// "isServicePrincipal": false,
        /// "roleScope": {
        /// "role": "administrator",
        /// "scopeType": "Workspace",
        /// "scopeRef": "961a8ff4-dfbc-4ee7-ae08-4f38b84d9c86"
        /// }
        /// },
        /// {
        /// "userId": "cc4c079a-5411-6899-8dd4-b8783f9417a8",
        /// "email": "Ina.Zhang@dnv.com",
        /// "name": "Ina Zhang",
        /// "isServicePrincipal": false,
        /// "roleScope": {
        /// "role": "reader",
        /// "scopeType": "Workspace",
        /// "scopeRef": "961a8ff4-dfbc-4ee7-ae08-4f38b84d9c86"
        /// }
        /// }
        /// ],
        /// "pageIndex": 1,
        /// "pageSize": 2,
        /// "totalCount": 53,
        /// "totalPages": 27
        /// }
        /// </remarks>
        /// <param name='workspaceId'>
        /// The workspace id which you want to get user role scopes
        /// </param>
        /// <param name='pageIndex'>
        /// Index of the current page (optional)
        /// </param>
        /// <param name='pageSize'>
        /// Number of items per page (optional)
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
        Task<HttpOperationResponse> QueryWorkspaceUserRoleScopesWithHttpMessagesAsync(System.Guid workspaceId, int? pageIndex = default, int? pageSize = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get users with role scopes in specified workspace
        /// </summary>
        /// <remarks>
        /// Sample response for paginated result of user role scopes info:
        ///
        /// {
        /// "result": [
        /// {
        /// "userId": "3e4d0494-0bad-41fb-aa1f-0c2e53516171",
        /// "email": "Nana.Ouyang@dnv.com",
        /// "name": "Nana Ouyang",
        /// "isServicePrincipal": false,
        /// "roleScope": {
        /// "role": "administrator",
        /// "scopeType": "Workspace",
        /// "scopeRef": "961a8ff4-dfbc-4ee7-ae08-4f38b84d9c86"
        /// }
        /// },
        /// {
        /// "userId": "cc4c079a-5411-6899-8dd4-b8783f9417a8",
        /// "email": "Ina.Zhang@dnv.com",
        /// "name": "Ina Zhang",
        /// "isServicePrincipal": false,
        /// "roleScope": {
        /// "role": "reader",
        /// "scopeType": "Workspace",
        /// "scopeRef": "961a8ff4-dfbc-4ee7-ae08-4f38b84d9c86"
        /// }
        /// }
        /// ],
        /// "pageIndex": 1,
        /// "pageSize": 2,
        /// "totalCount": 53,
        /// "totalPages": 27
        /// }
        /// </remarks>
        /// <param name='workspaceId'>
        /// The workspace id which you want to get user role scopes
        /// </param>
        /// <param name='pageIndex'>
        /// Index of the current page (optional)
        /// </param>
        /// <param name='pageSize'>
        /// Number of items per page (optional)
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task QueryWorkspaceUserRoleScopesAsync(System.Guid workspaceId, int? pageIndex = default, int? pageSize = default, CancellationToken cancellationToken = default);

    }
}
