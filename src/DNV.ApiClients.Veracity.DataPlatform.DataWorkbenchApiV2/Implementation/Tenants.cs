// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;
using System.IO;
using Microsoft.Rest;
using DNV.ApiClients.Veracity.DataPlatform.DataWorkbenchApiV2.Interfaces;

namespace DNV.ApiClients.Veracity.DataPlatform.DataWorkbenchApiV2
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Tenants operations.
    /// </summary>
    public partial class Tenants : IServiceOperations<DataWorkbenchApiV2Client>, ITenants
    {
        /// <summary>
        /// Initializes a new instance of the Tenants class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public Tenants(DataWorkbenchApiV2Client client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the DataWorkbenchApiV2Client
        /// </summary>
        public DataWorkbenchApiV2Client Client { get; private set; }

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
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse> QueryTenantUserRoleScopesWithHttpMessagesAsync(System.Guid tenantId, int? pageIndex = default, int? pageSize = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            // Construct URL
            var _baseUrl = Client.HttpClient.BaseAddress?.AbsoluteUri ?? Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "tenants/{tenantId}/users/roles").ToString();
            _url = _url.Replace("{tenantId}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(tenantId, Client.SerializationSettings).Trim('"')));
            IList<string> _queryParameters = new List<string>();
            if (pageIndex != null)
            {
                _queryParameters.Add(string.Format("pageIndex={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(pageIndex, Client.SerializationSettings).Trim('"'))));
            }
            if (pageSize != null)
            {
                _queryParameters.Add(string.Format("pageSize={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(pageSize, Client.SerializationSettings).Trim('"'))));
            }
            if (_queryParameters.Any())
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Send Request
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                if (_httpResponse.Content != null) {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
                else {
                    _responseContent = string.Empty;
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            return _result;
        }
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
        public async Task QueryTenantUserRoleScopesAsync(System.Guid tenantId, int? pageIndex = default, int? pageSize = default, CancellationToken cancellationToken = default)
        {
            (await QueryTenantUserRoleScopesWithHttpMessagesAsync(tenantId, pageIndex, pageSize, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Get workspace list which the current user has access to for a specified
        /// tenant
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
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<IEnumerable<WorkspaceDto>>> RetrieveAllWorkspacesWithHttpMessagesAsync(System.Guid tenantId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            // Construct URL
            var _baseUrl = Client.HttpClient.BaseAddress?.AbsoluteUri ?? Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "tenants/{tenantId}/workspaces").ToString();
            _url = _url.Replace("{tenantId}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(tenantId, Client.SerializationSettings).Trim('"')));
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Send Request
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                if (_httpResponse.Content != null) {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
                else {
                    _responseContent = string.Empty;
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<IEnumerable<WorkspaceDto>>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<IEnumerable<WorkspaceDto>>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            return _result;
        }
        /// <summary>
        /// Get workspace list which the current user has access to for a specified
        /// tenant
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
        public async Task<IEnumerable<WorkspaceDto>> RetrieveAllWorkspacesAsync(System.Guid tenantId, CancellationToken cancellationToken = default)
        {
            using (var _result = await RetrieveAllWorkspacesWithHttpMessagesAsync(tenantId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

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
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<WorkspaceDto>> CreateWorkspaceV2WithHttpMessagesAsync(WorkspaceCreationDtoV2 body, System.Guid tenantId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "body");
            }
            // Construct URL
            var _baseUrl = Client.HttpClient.BaseAddress?.AbsoluteUri ?? Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "tenants/{tenantId}/workspaces").ToString();
            _url = _url.Replace("{tenantId}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(tenantId, Client.SerializationSettings).Trim('"')));
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("POST");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            if(body != null)
            {
                _requestContent = Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(body, Client.SerializationSettings);
                _httpRequest.Content = new StringContent(_requestContent, System.Text.Encoding.UTF8);
                _httpRequest.Content.Headers.ContentType =System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            }
            // Send Request
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 201)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                if (_httpResponse.Content != null) {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
                else {
                    _responseContent = string.Empty;
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<WorkspaceDto>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 201)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<WorkspaceDto>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            return _result;
        }
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
        public async Task<WorkspaceDto> CreateWorkspaceV2Async(WorkspaceCreationDtoV2 body, System.Guid tenantId, CancellationToken cancellationToken = default)
        {
            using (var _result = await CreateWorkspaceV2WithHttpMessagesAsync(body, tenantId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

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
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<WorkspaceDto>> RetrieveWorkspaceWithHttpMessagesAsync(System.Guid workspaceId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            // Construct URL
            var _baseUrl = Client.HttpClient.BaseAddress?.AbsoluteUri ?? Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "workspaces/{workspaceId}").ToString();
            _url = _url.Replace("{workspaceId}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(workspaceId, Client.SerializationSettings).Trim('"')));
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Send Request
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                if (_httpResponse.Content != null) {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
                else {
                    _responseContent = string.Empty;
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<WorkspaceDto>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<WorkspaceDto>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            return _result;
        }
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
        public async Task<WorkspaceDto> RetrieveWorkspaceAsync(System.Guid workspaceId, CancellationToken cancellationToken = default)
        {
            using (var _result = await RetrieveWorkspaceWithHttpMessagesAsync(workspaceId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

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
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse> QueryWorkspaceUserRoleScopesWithHttpMessagesAsync(System.Guid workspaceId, int? pageIndex = default, int? pageSize = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            // Construct URL
            var _baseUrl = Client.HttpClient.BaseAddress?.AbsoluteUri ?? Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "workspaces/{workspaceId}/users/roles").ToString();
            _url = _url.Replace("{workspaceId}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(workspaceId, Client.SerializationSettings).Trim('"')));
            IList<string> _queryParameters = new List<string>();
            if (pageIndex != null)
            {
                _queryParameters.Add(string.Format("pageIndex={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(pageIndex, Client.SerializationSettings).Trim('"'))));
            }
            if (pageSize != null)
            {
                _queryParameters.Add(string.Format("pageSize={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(pageSize, Client.SerializationSettings).Trim('"'))));
            }
            if (_queryParameters.Any())
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Send Request
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                if (_httpResponse.Content != null) {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
                else {
                    _responseContent = string.Empty;
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            return _result;
        }
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
        public async Task QueryWorkspaceUserRoleScopesAsync(System.Guid workspaceId, int? pageIndex = default, int? pageSize = default, CancellationToken cancellationToken = default)
        {
            (await QueryWorkspaceUserRoleScopesWithHttpMessagesAsync(workspaceId, pageIndex, pageSize, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

    }
}
