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
    /// Datasets operations.
    /// </summary>
    public partial class Datasets : IServiceOperations<DataWorkbenchApiV2Client>, IDatasets
    {
        /// <summary>
        /// Initializes a new instance of the Datasets class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public Datasets(DataWorkbenchApiV2Client client)
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
        /// Download Statement of Compliance PDF file based on workspaceId, datasetId
        /// and documentId
        /// </summary>
        /// <param name='body'>
        /// </param>
        /// <param name='workspaceId'>
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
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse> SocDownloadWithHttpMessagesAsync(DocumentRefDTO body, System.Guid workspaceId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "body");
            }
            // Construct URL
            var _baseUrl = Client.HttpClient.BaseAddress?.AbsoluteUri ?? Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "workspaces/{workspaceId}/datasets/documents/download").ToString();
            _url = _url.Replace("{workspaceId}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(workspaceId, Client.SerializationSettings).Trim('"')));
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
        /// Download Statement of Compliance PDF file based on workspaceId, datasetId
        /// and documentId
        /// </summary>
        /// <param name='body'>
        /// </param>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task SocDownloadAsync(DocumentRefDTO body, System.Guid workspaceId, CancellationToken cancellationToken = default)
        {
            (await SocDownloadWithHttpMessagesAsync(body, workspaceId, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Get all data sets for a specific workspace. Supports pagination, enhanced
        /// filtering and sorting.
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='body'>
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
        public async Task<HttpOperationResponse<DataCatalogReadDtoV2PaginatedResult>> GetDataCatalogsQueryWithHttpMessagesAsync(System.Guid workspaceId, DataCatalogQueryDto body = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            // Construct URL
            var _baseUrl = Client.HttpClient.BaseAddress?.AbsoluteUri ?? Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "workspaces/{workspaceId}/datasets/query").ToString();
            _url = _url.Replace("{workspaceId}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(workspaceId, Client.SerializationSettings).Trim('"')));
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
            var _result = new HttpOperationResponse<DataCatalogReadDtoV2PaginatedResult>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<DataCatalogReadDtoV2PaginatedResult>(_responseContent, Client.DeserializationSettings);
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
        /// Get all data sets for a specific workspace. Supports pagination, enhanced
        /// filtering and sorting.
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<DataCatalogReadDtoV2PaginatedResult> GetDataCatalogsQueryAsync(System.Guid workspaceId, DataCatalogQueryDto body = default, CancellationToken cancellationToken = default)
        {
            using (var _result = await GetDataCatalogsQueryWithHttpMessagesAsync(workspaceId, body, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Gets a specific data set by Workspace Id and DataSet Id
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='datasetId'>
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
        public async Task<HttpOperationResponse<DataCatalogReadDtoV2>> GetDataCatalogByIdV2WithHttpMessagesAsync(System.Guid workspaceId, System.Guid datasetId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            // Construct URL
            var _baseUrl = Client.HttpClient.BaseAddress?.AbsoluteUri ?? Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "workspaces/{workspaceId}/datasets/{datasetId}").ToString();
            _url = _url.Replace("{workspaceId}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(workspaceId, Client.SerializationSettings).Trim('"')));
            _url = _url.Replace("{datasetId}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(datasetId, Client.SerializationSettings).Trim('"')));
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
            var _result = new HttpOperationResponse<DataCatalogReadDtoV2>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<DataCatalogReadDtoV2>(_responseContent, Client.DeserializationSettings);
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
        /// Gets a specific data set by Workspace Id and DataSet Id
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='datasetId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<DataCatalogReadDtoV2> GetDataCatalogByIdV2Async(System.Guid workspaceId, System.Guid datasetId, CancellationToken cancellationToken = default)
        {
            using (var _result = await GetDataCatalogByIdV2WithHttpMessagesAsync(workspaceId, datasetId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

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
        public async Task<HttpOperationResponse<LedgerDtoPaginatedResult>> GetDataCatalogLedgerWithHttpMessagesAsync(System.Guid workspaceId, System.Guid datasetId, int? pageSize = default, int? pageIndex = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            // Construct URL
            var _baseUrl = Client.HttpClient.BaseAddress?.AbsoluteUri ?? Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "workspaces/{workspaceId}/datasets/{datasetId}/ledger").ToString();
            _url = _url.Replace("{workspaceId}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(workspaceId, Client.SerializationSettings).Trim('"')));
            _url = _url.Replace("{datasetId}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(datasetId, Client.SerializationSettings).Trim('"')));
            IList<string> _queryParameters = new List<string>();
            if (pageSize != null)
            {
                _queryParameters.Add(string.Format("PageSize={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(pageSize, Client.SerializationSettings).Trim('"'))));
            }
            if (pageIndex != null)
            {
                _queryParameters.Add(string.Format("PageIndex={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(pageIndex, Client.SerializationSettings).Trim('"'))));
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
            var _result = new HttpOperationResponse<LedgerDtoPaginatedResult>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<LedgerDtoPaginatedResult>(_responseContent, Client.DeserializationSettings);
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
        public async Task<LedgerDtoPaginatedResult> GetDataCatalogLedgerAsync(System.Guid workspaceId, System.Guid datasetId, int? pageSize = default, int? pageIndex = default, CancellationToken cancellationToken = default)
        {
            using (var _result = await GetDataCatalogLedgerWithHttpMessagesAsync(workspaceId, datasetId, pageSize, pageIndex, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

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
        public async Task<HttpOperationResponse<QueryData>> QueryDataSetWithHttpMessagesAsync(System.Guid workspaceId, System.Guid datasetId, QuerySpecificationV2 body = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            // Construct URL
            var _baseUrl = Client.HttpClient.BaseAddress?.AbsoluteUri ?? Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "workspaces/{workspaceId}/datasets/{datasetId}/query").ToString();
            _url = _url.Replace("{workspaceId}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(workspaceId, Client.SerializationSettings).Trim('"')));
            _url = _url.Replace("{datasetId}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(datasetId, Client.SerializationSettings).Trim('"')));
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
            var _result = new HttpOperationResponse<QueryData>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<QueryData>(_responseContent, Client.DeserializationSettings);
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
        public async Task<QueryData> QueryDataSetAsync(System.Guid workspaceId, System.Guid datasetId, QuerySpecificationV2 body = default, CancellationToken cancellationToken = default)
        {
            using (var _result = await QueryDataSetWithHttpMessagesAsync(workspaceId, datasetId, body, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

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
        public async Task<HttpOperationResponse<string>> GetDatasetFolderReadonlyTokenWithHttpMessagesAsync(System.Guid workspaceId, System.Guid datasetId, int durationInMinutes, string type, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            if (durationInMinutes > 1440)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "durationInMinutes", 1440);
            }
            if (durationInMinutes < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "durationInMinutes", 1);
            }
            if (type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "type");
            }
            // Construct URL
            var _baseUrl = Client.HttpClient.BaseAddress?.AbsoluteUri ?? Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "workspaces/{workspaceId}/datasets/{datasetId}/sas").ToString();
            _url = _url.Replace("{workspaceId}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(workspaceId, Client.SerializationSettings).Trim('"')));
            _url = _url.Replace("{datasetId}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(datasetId, Client.SerializationSettings).Trim('"')));
            IList<string> _queryParameters = new List<string>();
            _queryParameters.Add(string.Format("durationInMinutes={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(durationInMinutes, Client.SerializationSettings).Trim('"'))));
            if (type != null)
            {
                _queryParameters.Add(string.Format("type={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(type, Client.SerializationSettings).Trim('"'))));
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
            var _result = new HttpOperationResponse<string>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<string>(_responseContent, Client.DeserializationSettings);
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
        public async Task<string> GetDatasetFolderReadonlyTokenAsync(System.Guid workspaceId, System.Guid datasetId, int durationInMinutes, string type, CancellationToken cancellationToken = default)
        {
            using (var _result = await GetDatasetFolderReadonlyTokenWithHttpMessagesAsync(workspaceId, datasetId, durationInMinutes, type, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}
