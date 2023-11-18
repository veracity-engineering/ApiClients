// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataApi
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Resources.
    /// </summary>
    public static partial class ResourcesExtensions
    {
            /// <summary>
            /// Fetches all storage resources that you can claim keys for
            /// </summary>
            /// <remarks>
            /// Fetches all storage resources that you can claim keys for
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Resource> Get(this IResources operations)
            {
                return operations.GetAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Fetches all storage resources that you can claim keys for
            /// </summary>
            /// <remarks>
            /// Fetches all storage resources that you can claim keys for
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Resource>> GetAsync(this IResources operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a single resource
            /// </summary>
            /// <remarks>
            /// Returns a single resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// Format - uuid. Resource Id
            /// </param>
            public static Resource GetById(this IResources operations, string resourceId)
            {
                return operations.GetByIdAsync(resourceId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a single resource
            /// </summary>
            /// <remarks>
            /// Returns a single resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// Format - uuid. Resource Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Resource> GetByIdAsync(this IResources operations, string resourceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(resourceId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Fetch a SAS key to access a storage item shared with you
            /// Deprecated. Please use PUT
            /// /api/resources/{resourceId}/accesses/{accessId}/key
            /// </summary>
            /// <remarks>
            /// Fetch a SAS key to access a storage item shared with you
            /// Deprecated. Please use PUT
            /// /api/resources/{resourceId}/accesses/{accessId}/key
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// Format - uuid. Storage resource Id
            /// </param>
            /// <param name='accessSharingId'>
            /// Format - uuid. The Id for the key you want to return
            /// </param>
            public static SASToken FetchKeyForStorageContainer(this IResources operations, string resourceId, string accessSharingId)
            {
                return operations.FetchKeyForStorageContainerAsync(resourceId, accessSharingId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Fetch a SAS key to access a storage item shared with you
            /// Deprecated. Please use PUT
            /// /api/resources/{resourceId}/accesses/{accessId}/key
            /// </summary>
            /// <remarks>
            /// Fetch a SAS key to access a storage item shared with you
            /// Deprecated. Please use PUT
            /// /api/resources/{resourceId}/accesses/{accessId}/key
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// Format - uuid. Storage resource Id
            /// </param>
            /// <param name='accessSharingId'>
            /// Format - uuid. The Id for the key you want to return
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SASToken> FetchKeyForStorageContainerAsync(this IResources operations, string resourceId, string accessSharingId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.FetchKeyForStorageContainerWithHttpMessagesAsync(resourceId, accessSharingId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}