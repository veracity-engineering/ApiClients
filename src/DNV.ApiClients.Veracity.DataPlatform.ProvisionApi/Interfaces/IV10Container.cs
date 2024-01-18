// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.ProvisionApi.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// V10Container operations.
    /// </summary>
    public partial interface IV10Container
    {
        /// <summary>
        /// Create blob storage container
        /// </summary>
        /// <remarks>
        /// Provision a blob storage container, requires a short name and
        /// storage container
        /// To return correct values for "StorageLocation" use GET api/regions
        /// and use the "azureName"
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
        Task<HttpOperationResponse<System.Guid?>> ProvisionAzureBlobContainerWithHttpMessagesAsync(ContainerInput body = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Metadata
        /// </summary>
        /// <remarks>
        /// JSON Patch (https://tools.ietf.org/html/rfc6902) defines a JSON
        /// document structure for expressing a sequence of operations to apply
        /// to a JavaScript Object Notation (JSON) document; it is suitable for
        /// use with the HTTP PATCH method. The "application/json-patch+json"
        /// media type is used to identify such patch documents.
        ///
        /// Example in this case:
        /// {
        /// "value": "My new container name",
        /// "path": "Title",
        /// "op": "replace"
        /// },
        /// This operation would replace the title
        ///
        ///
        /// A other example for update of tags (NOTE: remember to update the
        /// list of tags with all the tags)
        /// {
        /// "value": [
        /// {
        /// "Title" :"First tag"
        /// },
        /// {
        /// "Title" : "Second tag"
        /// }
        ///
        /// ],
        /// "path": "Tags",
        /// "op": "replace"
        /// }
        /// This operation would replace the tags
        /// </remarks>
        /// <param name='id'>
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
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Resource>> UpdateMetadataWithHttpMessagesAsync(string id, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete blob storage container
        /// </summary>
        /// <remarks>
        /// Deletes the blob storage container&lt;br /&gt;
        /// You need to be the owner of the resource to be able to delete the
        /// container.&lt;br /&gt;
        /// What happens when the container is deleted: All active keys will
        /// stop working.&lt;br /&gt;
        /// All content on the container will be deleted and this action is not
        /// reversible &lt;br /&gt;
        /// </remarks>
        /// <param name='id'>
        /// Format - uuid. Resource id (GUID)
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
        Task<HttpOperationResponse> DeleteAzureBlobContainerWithHttpMessagesAsync(string id, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Copy container
        /// </summary>
        /// <remarks>
        /// Copies a given Container with its content with access sharing ID.
        /// For successful requests, Returns 202 Accepted without waiting for
        /// container create or content copy is finished.
        /// </remarks>
        /// <param name='accessId'>
        /// Format - uuid. Access Id
        /// </param>
        /// <param name='body'>
        /// Values required to copy a container.
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
        Task<HttpOperationResponse<System.Guid?>> CopyContainerWithHttpMessagesAsync(string accessId, CopyContainerInputVM body = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Create subscription to changes in blob container
        /// </summary>
        /// <remarks>
        /// Provision a blob storage container subscription, requires container
        /// id, call back url and subscription name
        /// Subscription name must be unique through the entire application
        /// </remarks>
        /// <param name='body'>
        /// Subscription request
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
        Task<HttpOperationResponse> SubscribeToAzureBlobContainerEventsWithHttpMessagesAsync(ContainerSystemSubscriptionRequestVm body = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete subscription to changes in blob container
        /// </summary>
        /// <remarks>
        /// Deletes a blob storage container subscription, requires
        /// subscription name
        /// </remarks>
        /// <param name='body'>
        /// Subscription deleting request
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
        Task<HttpOperationResponse> UnsubscribeFromCustomEventsWithHttpMessagesAsync(DeleteContainerSubscriptionRequestVm body = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete subscription to changes in blob container
        /// </summary>
        /// <remarks>
        /// Deletes a blob storage container subscription, requires
        /// subscription name
        /// </remarks>
        /// <param name='body'>
        /// Subscription deleting request
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
        Task<HttpOperationResponse> UnsubscribeFromAzureBlobContainerEventsWithHttpMessagesAsync(DeleteContainerSubscriptionRequestVm body = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Create subscription for custom events
        /// </summary>
        /// <remarks>
        /// Provision custom event subscription for a specific topic, call back
        /// url and subscription name
        /// Subscription name must be unique through the entire application
        /// </remarks>
        /// <param name='body'>
        /// Subscription request
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
        Task<HttpOperationResponse> SubscribeToCustomEventsWithHttpMessagesAsync(ContainerCustomSubscriptionRequestVm body = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);
    }
}