// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.Identity.PlatformApiV4.Models
{
    using Newtonsoft.Json;
    /// <summary>
    /// Describes an error that occured during the processing of a request
    /// </summary>
    public partial class ErrorDetail
    {
        /// <summary>
        /// Initializes a new instance of the ErrorDetail class.
        /// </summary>
        public ErrorDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorDetail class.
        /// </summary>
        /// <param name="correlationId">This is the correlation id for the
        /// request, it can be used to track the request in the logs. You can
        /// control the value by setting the request-id header in the
        /// request</param>
        /// <param name="supportCode">this will be deprecated in the future,
        /// use CorrelationId instead</param>
        /// <param name="subCode">an additional code that can be used to
        /// identify the error, pass this code to the support team when
        /// reporting the error</param>
        /// <param name="message">A human readable message that describes the
        /// error</param>
        /// <param name="information">Additional information about the
        /// error</param>
        public ErrorDetail(string correlationId = default, string supportCode = default, int? subCode = default, string message = default, string information = default)
        {
            CorrelationId = correlationId;
            SupportCode = supportCode;
            SubCode = subCode;
            Message = message;
            Information = information;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets this is the correlation id for the request, it can be used to
        /// track the request in the logs. You can control the value by setting
        /// the request-id header in the request
        /// </summary>
        [JsonProperty(PropertyName = "correlationId")]
        public string CorrelationId { get; private set; }

        /// <summary>
        /// Gets this will be deprecated in the future, use CorrelationId
        /// instead
        /// </summary>
        [JsonProperty(PropertyName = "supportCode")]
        public string SupportCode { get; private set; }

        /// <summary>
        /// Gets an additional code that can be used to identify the error,
        /// pass this code to the support team when reporting the error
        /// </summary>
        [JsonProperty(PropertyName = "subCode")]
        public int? SubCode { get; private set; }

        /// <summary>
        /// Gets a human readable message that describes the error
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets additional information about the error
        /// </summary>
        [JsonProperty(PropertyName = "information")]
        public string Information { get; private set; }

    }
}
