// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataApi
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for V10Users.
    /// </summary>
    public static partial class V10UsersExtensions
    {
            /// <summary>
            /// Returns information about the current user.
            /// </summary>
            /// <remarks>
            /// Returns information about the current user.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static User Me(this IV10Users operations)
            {
                return operations.MeAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about the current user.
            /// </summary>
            /// <remarks>
            /// Returns information about the current user.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<User> MeAsync(this IV10Users operations, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.MeWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about an user.
            /// </summary>
            /// <remarks>
            /// Gets information about an user.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// Format - uuid. My DNV GL Id
            /// </param>
            public static User Get(this IV10Users operations, string userId)
            {
                return operations.GetAsync(userId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about an user.
            /// </summary>
            /// <remarks>
            /// Gets information about an user.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// Format - uuid. My DNV GL Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<User> GetAsync(this IV10Users operations, string userId, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(userId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the list of the users with whom storage accounts shared.
            /// </summary>
            /// <remarks>
            /// Get the list of the users with whom storage accounts shared.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// Format - uuid. My DNV GL Id
            /// </param>
            public static ResourceDistributedUser ResourceDistributionList(this IV10Users operations, string userId)
            {
                return operations.ResourceDistributionListAsync(userId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of the users with whom storage accounts shared.
            /// </summary>
            /// <remarks>
            /// Get the list of the users with whom storage accounts shared.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// Format - uuid. My DNV GL Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceDistributedUser> ResourceDistributionListAsync(this IV10Users operations, string userId, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.ResourceDistributionListWithHttpMessagesAsync(userId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}