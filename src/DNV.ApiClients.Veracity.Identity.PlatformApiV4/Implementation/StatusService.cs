// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;
using System.IO;
using Microsoft.Rest;
using DNV.ApiClients.Veracity.Identity.PlatformApiV4.Interfaces;

namespace DNV.ApiClients.Veracity.Identity.PlatformApiV4
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
    /// StatusService operations.
    /// </summary>
    public partial class StatusService : IServiceOperations<PlatformApiV4Client>, IStatusService
    {
        /// <summary>
        /// Initializes a new instance of the StatusService class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public StatusService(PlatformApiV4Client client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the PlatformApiV4Client
        /// </summary>
        public PlatformApiV4Client Client { get; private set; }

        /// <summary>
        /// Returns 200 when all dependencies are ok, 424 if there are some non
        /// essential dependency failures and 500 when essential dependencies are
        /// unreachable or the service is down&lt;br/&gt;
        /// </summary>
        /// <param name='requestId'>
        /// A correlation token to use when looking in the logs.
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
        public async Task<HttpOperationResponse<HealthStatus>> GetServiceHealthStatusWithHttpMessagesAsync(string requestId = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            // Construct URL
            var _baseUrl = Client.HttpClient.BaseAddress?.AbsoluteUri ?? Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "health").ToString();
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (requestId != null)
            {
                if (_httpRequest.Headers.Contains("request-id"))
                {
                    _httpRequest.Headers.Remove("request-id");
                }
                _httpRequest.Headers.TryAddWithoutValidation("request-id", requestId);
            }


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
            var _result = new HttpOperationResponse<HealthStatus>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<HealthStatus>(_responseContent, Client.DeserializationSettings);
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
        /// Returns 200 when all dependencies are ok, 424 if there are some non
        /// essential dependency failures and 500 when essential dependencies are
        /// unreachable or the service is down&lt;br/&gt;
        /// </summary>
        /// <param name='requestId'>
        /// A correlation token to use when looking in the logs.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<HealthStatus> GetServiceHealthStatusAsync(string requestId = default, CancellationToken cancellationToken = default)
        {
            using (var _result = await GetServiceHealthStatusWithHttpMessagesAsync(requestId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}
