// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracity.ApiClients.DataPlatform.DataApi
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Tags operations.
    /// </summary>
    public partial interface ITags
    {
        /// <summary>
        /// Retrieve metadata tags in Veracity.
        /// </summary>
        /// <remarks>
        /// Default returns approved and non deleted tags.
        /// Use Query parameters to includes non approved and deleted (needs to
        /// be DataAdmin to perform this action)
        /// </remarks>
        /// <param name='includeDeleted'>
        /// </param>
        /// <param name='includeNonVeracityApproved'>
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
        Task<HttpOperationResponse<IList<Tag>>> GetTagsWithHttpMessagesAsync(bool? includeDeleted = default(bool?), bool? includeNonVeracityApproved = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Inserts tags and returns the inserted new inserted tags with ID's
        /// &lt;remarks&gt;
        /// Id is not required for the input
        /// &lt;/remarks&gt;
        /// </summary>
        /// <remarks>
        /// Inserts tags and returns the inserted new inserted tags with ID's
        /// &lt;remarks&gt;
        /// Id is not required for the input
        /// &lt;/remarks&gt;
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
        Task<HttpOperationResponse<IList<Tag>>> InsertTagsWithHttpMessagesAsync(IList<Tag> body = default(IList<Tag>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
