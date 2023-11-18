// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataValidatorApi
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ColumnValidator operations.
    /// </summary>
    public partial interface IColumnValidator
    {
        /// <summary>
        /// Lists all pre-defined column validators
        /// </summary>
        /// <remarks>
        /// Lists all pre-defined column validators
        /// </remarks>
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
        Task<HttpOperationResponse<IList<ColumnValidatorReadDTO>>> GetListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Adds a new pre-defined column validator
        /// </summary>
        /// <remarks>
        /// Adds a new pre-defined column validator
        /// </remarks>
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
        Task<HttpOperationResponse<ColumnValidatorReadDTO>> AddWithHttpMessagesAsync(ColumnValidatorWriteDTO body = default, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets a pre-defined column validator
        /// </summary>
        /// <remarks>
        /// Gets a pre-defined column validator
        /// </remarks>
        /// <param name='id'>
        /// Format - int32. column validator Id
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
        Task<HttpOperationResponse<ColumnValidatorReadDTO>> GetWithHttpMessagesAsync(int id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a pre-defined column validator
        /// </summary>
        /// <remarks>
        /// Updates a pre-defined column validator
        /// </remarks>
        /// <param name='id'>
        /// Format - int32.
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
        Task<HttpOperationResponse<ColumnValidatorReadDTO>> UpdateWithHttpMessagesAsync(int id, ColumnValidatorWriteDTO body = default, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a pre-defined column validator
        /// </summary>
        /// <remarks>
        /// Remove a pre-defined column validator
        /// </remarks>
        /// <param name='id'>
        /// Format - int32. column validator Id
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
        Task<HttpOperationResponse> RemoveWithHttpMessagesAsync(int id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Lists all column validators by workspace Id
        /// </summary>
        /// <remarks>
        /// Lists all column validators by workspace Id
        /// </remarks>
        /// <param name='id'>
        /// Format - uuid. workspace Id
        /// </param>
        /// <param name='includesPredefined'>
        /// includes predefine validators in the response
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
        Task<HttpOperationResponse<IList<ColumnValidatorReadDTO>>> GetColumnValidatorListWithHttpMessagesAsync(string id, bool? includesPredefined = false, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a column validator to a workspace
        /// </summary>
        /// <remarks>
        /// Add a column validator to a workspace
        /// </remarks>
        /// <param name='id'>
        /// Format - uuid. workspace Id
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ColumnValidatorReadDTO>> AddColumnValidatorWithHttpMessagesAsync(string id, ColumnValidatorWriteDTO body = default, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a column validator
        /// </summary>
        /// <remarks>
        /// Updates a column validator
        /// </remarks>
        /// <param name='id'>
        /// Format - uuid. workspace Id
        /// </param>
        /// <param name='validatorId'>
        /// Format - int32.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ColumnValidatorReadDTO>> UpdateColumnValidatorWithHttpMessagesAsync(string id, int validatorId, ColumnValidatorWriteDTO body = default, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets a column validator
        /// </summary>
        /// <remarks>
        /// Gets a column validator
        /// </remarks>
        /// <param name='id'>
        /// Format - uuid. workspace Id
        /// </param>
        /// <param name='validatorId'>
        /// Format - int32.
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
        Task<HttpOperationResponse<ColumnValidatorReadDTO>> GetColumnValidatorWithHttpMessagesAsync(string id, int validatorId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Removes a column validator
        /// </summary>
        /// <remarks>
        /// Removes a column validator
        /// </remarks>
        /// <param name='id'>
        /// Format - uuid. workspace Id
        /// </param>
        /// <param name='validatorId'>
        /// Format - int32.
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
        Task<HttpOperationResponse> RemoveColumnValidatorWithHttpMessagesAsync(string id, int validatorId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default);
    }
}
