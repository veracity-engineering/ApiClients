// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracity.ApiClients.DataPlatform.DataApi
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Ledger.
    /// </summary>
    public static partial class LedgerExtensions
    {
            /// <summary>
            /// Returns a list of ledger records
            /// </summary>
            /// <remarks>
            /// Endpoint returns a list of ledger records.
            /// A ledger record is an action done to a container, ex; creating a file,
            /// sharing a key.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// Format - uuid. Veracity resource id
            /// </param>
            public static IList<ReadLedger> Get(this ILedger operations, string resourceId)
            {
                return operations.GetAsync(resourceId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of ledger records
            /// </summary>
            /// <remarks>
            /// Endpoint returns a list of ledger records.
            /// A ledger record is an action done to a container, ex; creating a file,
            /// sharing a key.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// Format - uuid. Veracity resource id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ReadLedger>> GetAsync(this ILedger operations, string resourceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
