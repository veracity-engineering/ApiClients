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
    /// DataOrders operations.
    /// </summary>
    public partial class DataOrders : IServiceOperations<DataWorkbenchApiV2Client>, IDataOrders
    {
        /// <summary>
        /// Initializes a new instance of the DataOrders class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DataOrders(DataWorkbenchApiV2Client client)
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
        /// Create Data Order
        /// </summary>
        /// <remarks>
        /// Sample request For GPM Provider:
        ///
        /// POST {workspaceId}/DataOrder
        /// {
        /// "datasetName":"string",
        /// "providerType":"GPM",
        /// "properties":{
        /// "portfolioId" : "b259ccb2-5c07-46f8-afa2-ed0f21d912e4",
        /// "siteId": "EnergySite",
        /// "deviceParameters": [
        /// {
        /// "deviceIds": [
        /// "1234-5",
        /// "b1c80fc9-f548-47c7-a8a0-d41c635f6949"
        /// ],
        /// "parameters": [
        /// {
        /// "Name": "Energy",
        /// "Aggregation": "DEFAULT"
        /// },
        /// {
        /// "Name": "Power",
        /// "Aggregation": "LAST"
        /// }
        /// ]
        /// }
        /// ],
        /// "granularity": 1,
        /// "granularityUnit": "Hour",
        /// "interval": {
        /// "start": "2023-01-01T15:00:00",
        /// "end": "2023-01-01T20:00:00"
        /// }
        /// }
        /// }
        /// </remarks>
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
        public async Task<HttpOperationResponse<OrderReadDto>> CreateOrderWithHttpMessagesAsync(OrderWriteDto body, System.Guid workspaceId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "body");
            }
            // Construct URL
            var _baseUrl = Client.HttpClient.BaseAddress?.AbsoluteUri ?? Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "workspaces/{workspaceId}/dataorders").ToString();
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
            var _result = new HttpOperationResponse<OrderReadDto>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<OrderReadDto>(_responseContent, Client.DeserializationSettings);
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
        /// Create Data Order
        /// </summary>
        /// <remarks>
        /// Sample request For GPM Provider:
        ///
        /// POST {workspaceId}/DataOrder
        /// {
        /// "datasetName":"string",
        /// "providerType":"GPM",
        /// "properties":{
        /// "portfolioId" : "b259ccb2-5c07-46f8-afa2-ed0f21d912e4",
        /// "siteId": "EnergySite",
        /// "deviceParameters": [
        /// {
        /// "deviceIds": [
        /// "1234-5",
        /// "b1c80fc9-f548-47c7-a8a0-d41c635f6949"
        /// ],
        /// "parameters": [
        /// {
        /// "Name": "Energy",
        /// "Aggregation": "DEFAULT"
        /// },
        /// {
        /// "Name": "Power",
        /// "Aggregation": "LAST"
        /// }
        /// ]
        /// }
        /// ],
        /// "granularity": 1,
        /// "granularityUnit": "Hour",
        /// "interval": {
        /// "start": "2023-01-01T15:00:00",
        /// "end": "2023-01-01T20:00:00"
        /// }
        /// }
        /// }
        /// </remarks>
        /// <param name='body'>
        /// </param>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<OrderReadDto> CreateOrderAsync(OrderWriteDto body, System.Guid workspaceId, CancellationToken cancellationToken = default)
        {
            using (var _result = await CreateOrderWithHttpMessagesAsync(body, workspaceId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Get Order By Id
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='orderId'>
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
        public async Task<HttpOperationResponse<OrderReadDto>> GetOrderWithHttpMessagesAsync(System.Guid workspaceId, System.Guid orderId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            // Construct URL
            var _baseUrl = Client.HttpClient.BaseAddress?.AbsoluteUri ?? Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "workspaces/{workspaceId}/dataorders/{orderId}").ToString();
            _url = _url.Replace("{workspaceId}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(workspaceId, Client.SerializationSettings).Trim('"')));
            _url = _url.Replace("{orderId}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(orderId, Client.SerializationSettings).Trim('"')));
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
            var _result = new HttpOperationResponse<OrderReadDto>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<OrderReadDto>(_responseContent, Client.DeserializationSettings);
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
        /// Get Order By Id
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='orderId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<OrderReadDto> GetOrderAsync(System.Guid workspaceId, System.Guid orderId, CancellationToken cancellationToken = default)
        {
            using (var _result = await GetOrderWithHttpMessagesAsync(workspaceId, orderId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}
