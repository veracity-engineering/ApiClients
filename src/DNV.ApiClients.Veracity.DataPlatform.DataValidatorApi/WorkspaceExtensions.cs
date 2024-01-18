// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using DNV.ApiClients.Veracity.DataPlatform.DataValidatorApi.Interfaces;

namespace DNV.ApiClients.Veracity.DataPlatform.DataValidatorApi
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Workspace.
    /// </summary>
    public static partial class WorkspaceExtensions
    {
            /// <summary>
            /// List all my workspaces
            /// </summary>
            /// <remarks>
            /// List all my workspaces
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IEnumerable<WorkspaceReadDTO> GetList(this IWorkspace operations)
            {
                return operations.GetListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all my workspaces
            /// </summary>
            /// <remarks>
            /// List all my workspaces
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<WorkspaceReadDTO>> GetListAsync(this IWorkspace operations, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.GetListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a new workspace
            /// </summary>
            /// <remarks>
            /// Create a new workspace
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static WorkspaceReadDTO Add(this IWorkspace operations, WorkspaceWriteDTO body = default)
            {
                return operations.AddAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new workspace
            /// </summary>
            /// <remarks>
            /// Create a new workspace
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkspaceReadDTO> AddAsync(this IWorkspace operations, WorkspaceWriteDTO body = default, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.AddWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Show workspace details
            /// </summary>
            /// <remarks>
            /// Show workspace details
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            public static WorkspaceReadDTO Get(this IWorkspace operations, string id)
            {
                return operations.GetAsync(id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Show workspace details
            /// </summary>
            /// <remarks>
            /// Show workspace details
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkspaceReadDTO> GetAsync(this IWorkspace operations, string id, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update workspace
            /// </summary>
            /// <remarks>
            /// Sample request body:
            ///
            /// {
            /// "name": "string",
            /// "description": "string"
            /// }
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='body'>
            /// </param>
            public static WorkspaceReadDTO UpdateWorkspace(this IWorkspace operations, string id, WorkspaceWriteDTO body = default)
            {
                return operations.UpdateWorkspaceAsync(id, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update workspace
            /// </summary>
            /// <remarks>
            /// Sample request body:
            ///
            /// {
            /// "name": "string",
            /// "description": "string"
            /// }
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkspaceReadDTO> UpdateWorkspaceAsync(this IWorkspace operations, string id, WorkspaceWriteDTO body = default, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.UpdateWorkspaceWithHttpMessagesAsync(id, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update data collect SAS URL
            /// </summary>
            /// <remarks>
            /// Update data collect SAS URL
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static bool? UpdateDataCollectSAS(this IWorkspace operations, string id, SASDTO body = default)
            {
                return operations.UpdateDataCollectSASAsync(id, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update data collect SAS URL
            /// </summary>
            /// <remarks>
            /// Update data collect SAS URL
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<bool?> UpdateDataCollectSASAsync(this IWorkspace operations, string id, SASDTO body = default, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.UpdateDataCollectSASWithHttpMessagesAsync(id, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get data collect SAS URL
            /// </summary>
            /// <remarks>
            /// Get data collect SAS URL
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid.
            /// </param>
            public static SASDTO GetDataCollectSAS(this IWorkspace operations, string id)
            {
                return operations.GetDataCollectSASAsync(id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get data collect SAS URL
            /// </summary>
            /// <remarks>
            /// Get data collect SAS URL
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SASDTO> GetDataCollectSASAsync(this IWorkspace operations, string id, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.GetDataCollectSASWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
