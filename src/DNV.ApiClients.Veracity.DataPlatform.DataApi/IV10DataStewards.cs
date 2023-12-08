// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataApi
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// V10DataStewards operations.
    /// </summary>
    public partial interface IV10DataStewards
    {
        /// <summary>
        /// Retrieve a list of data stewards for the resource
        /// </summary>
        /// <remarks>
        /// Retrieve a list of data stewards for the resource
        /// </remarks>
        /// <param name='resourceId'>
        /// Format - uuid. The Id of the resource
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
        Task<HttpOperationResponse<IEnumerable<DataStewardVM>>> GetDataStewardsByResourceIdWithHttpMessagesAsync(string resourceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Transfer the ownership of the Azure resource to a specified user.
        /// Both previous and the new owner should be affiliated with the same
        /// company.
        /// </summary>
        /// <remarks>
        /// Returns the Azure resource with updated OwnerId field.
        /// </remarks>
        /// <param name='resourceId'>
        /// Format - uuid. The Id of the resource
        /// </param>
        /// <param name='userId'>
        /// Format - uuid. The Id of the user with role of Data Manager that
        /// ownership will be transfered to.
        /// </param>
        /// <param name='keepAccessAsDataSteward'>
        /// The endpoint specified below will be updated with an Input flag.
        /// When the "SetPreviousOwnerAsDataSteward" flag is set to true. If it
        /// is false, then the previous owner will not be assigned as Data
        /// Steward.
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
        Task<HttpOperationResponse<StorageResourcesVM>> TransferOwnershipWithHttpMessagesAsync(string resourceId, string userId, bool? keepAccessAsDataSteward = default, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delegate the rights to use the Azure resource to another Veracity
        /// user.
        /// </summary>
        /// <remarks>
        /// If a DataSteward with this user id exist on this resource, it will
        /// be updated.
        /// Returns the Users that DataSteward for the provided resource was
        /// assigned to.
        /// </remarks>
        /// <param name='resourceId'>
        /// Format - uuid. The Id of the resource
        /// </param>
        /// <param name='userId'>
        /// Format - uuid. A Data Steward user Id
        /// </param>
        /// <param name='body'>
        /// Data-stewardship optional details
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
        Task<HttpOperationResponse<DataStewardVM>> PostWithHttpMessagesAsync(string resourceId, string userId, DataStewardInputVm body = default, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a data stewards
        /// </summary>
        /// <remarks>
        /// The user must be the owner of the resource to be able to delete
        /// datastewards
        /// </remarks>
        /// <param name='resourceId'>
        /// Format - uuid. The Id of the resource
        /// </param>
        /// <param name='userId'>
        /// Format - uuid.
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
        Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string resourceId, string userId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default);
    }
}