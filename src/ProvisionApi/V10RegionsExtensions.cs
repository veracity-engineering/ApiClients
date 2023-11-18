// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.ProvisionApi
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for V10Regions.
    /// </summary>
    public static partial class V10RegionsExtensions
    {
            /// <summary>
            /// List Active Regions
            /// </summary>
            /// <remarks>
            /// Returns list of active regions supported by Veracity
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<StorageRegion> Get(this IV10Regions operations)
            {
                return operations.GetAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Active Regions
            /// </summary>
            /// <remarks>
            /// Returns list of active regions supported by Veracity
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<StorageRegion>> GetAsync(this IV10Regions operations, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
