// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracity.ApiClients.MyServices.MyServicesV3Api
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Options.
    /// </summary>
    public static partial class OptionsExtensions
    {
            /// <summary>
            /// Options_ServiceStatus
            /// </summary>
            /// <remarks>
            /// Get the status of the service container.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xSupportCode'>
            /// Provide a correlation token for log lookup. This is optional.
            /// </param>
            /// <param name='ocpApimSubscriptionKey'>
            /// Veracity api management subscription key
            /// </param>
            public static IDictionary<string, string> ServiceStatus(this IOptions operations, string xSupportCode = default(string), string ocpApimSubscriptionKey = default(string))
            {
                return operations.ServiceStatusAsync(xSupportCode, ocpApimSubscriptionKey).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Options_ServiceStatus
            /// </summary>
            /// <remarks>
            /// Get the status of the service container.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xSupportCode'>
            /// Provide a correlation token for log lookup. This is optional.
            /// </param>
            /// <param name='ocpApimSubscriptionKey'>
            /// Veracity api management subscription key
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IDictionary<string, string>> ServiceStatusAsync(this IOptions operations, string xSupportCode = default(string), string ocpApimSubscriptionKey = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ServiceStatusWithHttpMessagesAsync(xSupportCode, ocpApimSubscriptionKey, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Options_InvalidateCache
            /// </summary>
            /// <remarks>
            /// Invalidate the cached item with the provided id
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='xSupportCode'>
            /// Provide a correlation token for log lookup. This is optional.
            /// </param>
            /// <param name='ocpApimSubscriptionKey'>
            /// Veracity api management subscription key
            /// </param>
            public static OptionsInvalidateCacheHeaders InvalidateCache(this IOptions operations, string id, string xSupportCode = default(string), string ocpApimSubscriptionKey = default(string))
            {
                return operations.InvalidateCacheAsync(id, xSupportCode, ocpApimSubscriptionKey).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Options_InvalidateCache
            /// </summary>
            /// <remarks>
            /// Invalidate the cached item with the provided id
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='xSupportCode'>
            /// Provide a correlation token for log lookup. This is optional.
            /// </param>
            /// <param name='ocpApimSubscriptionKey'>
            /// Veracity api management subscription key
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OptionsInvalidateCacheHeaders> InvalidateCacheAsync(this IOptions operations, string id, string xSupportCode = default(string), string ocpApimSubscriptionKey = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.InvalidateCacheWithHttpMessagesAsync(id, xSupportCode, ocpApimSubscriptionKey, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

    }
}
