// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using DNV.ApiClients.Veracity.DataPlatform.DataApi.Interfaces;

namespace DNV.ApiClients.Veracity.DataPlatform.DataApi
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for V10DataStewards.
    /// </summary>
    public static partial class V10DataStewardsExtensions
    {
            /// <summary>
            /// Retrieve a list of data stewards for the resource
            /// </summary>
            /// <remarks>
            /// Retrieve a list of data stewards for the resource
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// Format - uuid. The Id of the resource
            /// </param>
            public static IEnumerable<DataStewardVM> GetDataStewardsByResourceId(this IV10DataStewards operations, string resourceId)
            {
                return operations.GetDataStewardsByResourceIdAsync(resourceId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of data stewards for the resource
            /// </summary>
            /// <remarks>
            /// Retrieve a list of data stewards for the resource
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// Format - uuid. The Id of the resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<DataStewardVM>> GetDataStewardsByResourceIdAsync(this IV10DataStewards operations, string resourceId, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.GetDataStewardsByResourceIdWithHttpMessagesAsync(resourceId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Transfer the ownership of the Azure resource to a specified user.
            /// Both previous and the new owner should be affiliated with the same company.
            /// </summary>
            /// <remarks>
            /// Returns the Azure resource with updated OwnerId field.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// Format - uuid. The Id of the resource
            /// </param>
            /// <param name='userId'>
            /// Format - uuid. The Id of the user with role of Data Manager that ownership
            /// will be transfered to.
            /// </param>
            /// <param name='keepAccessAsDataSteward'>
            /// The endpoint specified below will be updated with an Input flag. When the
            /// "SetPreviousOwnerAsDataSteward" flag is set to true. If it is false, then
            /// the previous owner will not be assigned as Data Steward.
            /// </param>
            public static StorageResourcesVM TransferOwnership(this IV10DataStewards operations, string resourceId, string userId, bool? keepAccessAsDataSteward = default)
            {
                return operations.TransferOwnershipAsync(resourceId, userId, keepAccessAsDataSteward).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Transfer the ownership of the Azure resource to a specified user.
            /// Both previous and the new owner should be affiliated with the same company.
            /// </summary>
            /// <remarks>
            /// Returns the Azure resource with updated OwnerId field.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// Format - uuid. The Id of the resource
            /// </param>
            /// <param name='userId'>
            /// Format - uuid. The Id of the user with role of Data Manager that ownership
            /// will be transfered to.
            /// </param>
            /// <param name='keepAccessAsDataSteward'>
            /// The endpoint specified below will be updated with an Input flag. When the
            /// "SetPreviousOwnerAsDataSteward" flag is set to true. If it is false, then
            /// the previous owner will not be assigned as Data Steward.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageResourcesVM> TransferOwnershipAsync(this IV10DataStewards operations, string resourceId, string userId, bool? keepAccessAsDataSteward = default, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.TransferOwnershipWithHttpMessagesAsync(resourceId, userId, keepAccessAsDataSteward, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delegate the rights to use the Azure resource to another Veracity user.
            /// </summary>
            /// <remarks>
            /// If a DataSteward with this user id exist on this resource, it will be
            /// updated.
            /// Returns the Users that DataSteward for the provided resource was assigned
            /// to.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// Format - uuid. The Id of the resource
            /// </param>
            /// <param name='userId'>
            /// Format - uuid. A Data Steward user Id
            /// </param>
            /// <param name='body'>
            /// Data-stewardship optional details
            /// </param>
            public static DataStewardVM Post(this IV10DataStewards operations, string resourceId, string userId, DataStewardInputVm body = default)
            {
                return operations.PostAsync(resourceId, userId, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delegate the rights to use the Azure resource to another Veracity user.
            /// </summary>
            /// <remarks>
            /// If a DataSteward with this user id exist on this resource, it will be
            /// updated.
            /// Returns the Users that DataSteward for the provided resource was assigned
            /// to.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// Format - uuid. The Id of the resource
            /// </param>
            /// <param name='userId'>
            /// Format - uuid. A Data Steward user Id
            /// </param>
            /// <param name='body'>
            /// Data-stewardship optional details
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataStewardVM> PostAsync(this IV10DataStewards operations, string resourceId, string userId, DataStewardInputVm body = default, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(resourceId, userId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a data stewards
            /// </summary>
            /// <remarks>
            /// The user must be the owner of the resource to be able to delete
            /// datastewards
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// Format - uuid. The Id of the resource
            /// </param>
            /// <param name='userId'>
            /// Format - uuid.
            /// </param>
            public static void Delete(this IV10DataStewards operations, string resourceId, string userId)
            {
                operations.DeleteAsync(resourceId, userId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a data stewards
            /// </summary>
            /// <remarks>
            /// The user must be the owner of the resource to be able to delete
            /// datastewards
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// Format - uuid. The Id of the resource
            /// </param>
            /// <param name='userId'>
            /// Format - uuid.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IV10DataStewards operations, string resourceId, string userId, CancellationToken cancellationToken = default)
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceId, userId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
