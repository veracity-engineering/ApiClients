// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataValidatorApi
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Schema.
    /// </summary>
    public static partial class SchemaExtensions
    {
            /// <summary>
            /// Gets a list of pre-defined schemas
            /// </summary>
            /// <remarks>
            /// Gets a list of pre-defined schemas
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<SchemaReadDTO> GetPredefinedList(this ISchema operations)
            {
                return operations.GetPredefinedListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of pre-defined schemas
            /// </summary>
            /// <remarks>
            /// Gets a list of pre-defined schemas
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<SchemaReadDTO>> GetPredefinedListAsync(this ISchema operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPredefinedListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Adds a pre-defined schema with all the details
            /// </summary>
            /// <remarks>
            /// Adds a pre-defined schema with all the details
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static SchemaReadDTO AddPredefined(this ISchema operations, SchemaWithVersionWriteDTO body = default(SchemaWithVersionWriteDTO))
            {
                return operations.AddPredefinedAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a pre-defined schema with all the details
            /// </summary>
            /// <remarks>
            /// Adds a pre-defined schema with all the details
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SchemaReadDTO> AddPredefinedAsync(this ISchema operations, SchemaWithVersionWriteDTO body = default(SchemaWithVersionWriteDTO), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddPredefinedWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a pre-defined schema
            /// </summary>
            /// <remarks>
            /// Gets a pre-defined schema
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='schemaId'>
            /// Format - uuid.
            /// </param>
            public static SchemaDetails GetPredefined(this ISchema operations, string schemaId)
            {
                return operations.GetPredefinedAsync(schemaId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a pre-defined schema
            /// </summary>
            /// <remarks>
            /// Gets a pre-defined schema
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='schemaId'>
            /// Format - uuid.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SchemaDetails> GetPredefinedAsync(this ISchema operations, string schemaId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPredefinedWithHttpMessagesAsync(schemaId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the specified schema column
            /// </summary>
            /// <remarks>
            /// Gets the specified schema column
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid.
            /// </param>
            /// <param name='columnId'>
            /// Format - int32.
            /// </param>
            public static SchemaColumnReadDTO GetSchemaColumn(this ISchema operations, string id, int columnId)
            {
                return operations.GetSchemaColumnAsync(id, columnId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified schema column
            /// </summary>
            /// <remarks>
            /// Gets the specified schema column
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid.
            /// </param>
            /// <param name='columnId'>
            /// Format - int32.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SchemaColumnReadDTO> GetSchemaColumnAsync(this ISchema operations, string id, int columnId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSchemaColumnWithHttpMessagesAsync(id, columnId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all workspace schemas
            /// </summary>
            /// <remarks>
            /// List all workspace schemas
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            public static IList<SchemaReadDTO> GetSchemaList(this ISchema operations, string id)
            {
                return operations.GetSchemaListAsync(id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all workspace schemas
            /// </summary>
            /// <remarks>
            /// List all workspace schemas
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
            public static async Task<IList<SchemaReadDTO>> GetSchemaListAsync(this ISchema operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSchemaListWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a new schema with all the details
            /// </summary>
            /// <remarks>
            /// Create a new schema with all the details
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='body'>
            /// </param>
            public static SchemaDetails Add(this ISchema operations, string id, SchemaWithVersionWriteDTO body = default(SchemaWithVersionWriteDTO))
            {
                return operations.AddAsync(id, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new schema with all the details
            /// </summary>
            /// <remarks>
            /// Create a new schema with all the details
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
            public static async Task<SchemaDetails> AddAsync(this ISchema operations, string id, SchemaWithVersionWriteDTO body = default(SchemaWithVersionWriteDTO), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddWithHttpMessagesAsync(id, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the specified schema with the details of its active version
            /// </summary>
            /// <remarks>
            /// Gets the specified schema with the details of its active version
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='schemaId'>
            /// Format - uuid.
            /// </param>
            public static SchemaDetails Get(this ISchema operations, string id, string schemaId)
            {
                return operations.GetAsync(id, schemaId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified schema with the details of its active version
            /// </summary>
            /// <remarks>
            /// Gets the specified schema with the details of its active version
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='schemaId'>
            /// Format - uuid.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SchemaDetails> GetAsync(this ISchema operations, string id, string schemaId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(id, schemaId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a schema
            /// </summary>
            /// <remarks>
            /// Request sample
            ///
            /// {
            /// "op": "replace",
            /// "path": "name",
            /// "value": "new name",
            /// "operationType": null,  // not used
            /// "from": null            // not used
            /// }
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='schemaId'>
            /// Format - uuid.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static SchemaReadDTO Patch(this ISchema operations, string id, string schemaId, IList<Operation> body = default(IList<Operation>))
            {
                return operations.PatchAsync(id, schemaId, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a schema
            /// </summary>
            /// <remarks>
            /// Request sample
            ///
            /// {
            /// "op": "replace",
            /// "path": "name",
            /// "value": "new name",
            /// "operationType": null,  // not used
            /// "from": null            // not used
            /// }
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='schemaId'>
            /// Format - uuid.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SchemaReadDTO> PatchAsync(this ISchema operations, string id, string schemaId, IList<Operation> body = default(IList<Operation>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchWithHttpMessagesAsync(id, schemaId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Removes a schema
            /// </summary>
            /// <remarks>
            /// Removes a schema
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='schemaId'>
            /// Format - uuid.
            /// </param>
            public static void Remove(this ISchema operations, string id, string schemaId)
            {
                operations.RemoveAsync(id, schemaId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Removes a schema
            /// </summary>
            /// <remarks>
            /// Removes a schema
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='schemaId'>
            /// Format - uuid.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RemoveAsync(this ISchema operations, string id, string schemaId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RemoveWithHttpMessagesAsync(id, schemaId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a schema version details
            /// </summary>
            /// <remarks>
            /// Gets a schema version details
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='versionId'>
            /// Format - uuid.
            /// </param>
            public static SchemaVersionReadDTO GetSchemaVersion(this ISchema operations, string id, string versionId)
            {
                return operations.GetSchemaVersionAsync(id, versionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a schema version details
            /// </summary>
            /// <remarks>
            /// Gets a schema version details
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='versionId'>
            /// Format - uuid.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SchemaVersionReadDTO> GetSchemaVersionAsync(this ISchema operations, string id, string versionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSchemaVersionWithHttpMessagesAsync(id, versionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates schema version
            /// </summary>
            /// <remarks>
            /// Request sample
            ///
            /// {
            /// "op": "replace",
            /// "path": "name",
            /// "value": "new name",
            /// "operationType": null,  // not used
            /// "from": null            // not used
            /// }
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid.
            /// </param>
            /// <param name='versionId'>
            /// Format - uuid.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static SchemaVersionReadDTO PatchSchemaVersion(this ISchema operations, string id, string versionId, IList<Operation> body = default(IList<Operation>))
            {
                return operations.PatchSchemaVersionAsync(id, versionId, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates schema version
            /// </summary>
            /// <remarks>
            /// Request sample
            ///
            /// {
            /// "op": "replace",
            /// "path": "name",
            /// "value": "new name",
            /// "operationType": null,  // not used
            /// "from": null            // not used
            /// }
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid.
            /// </param>
            /// <param name='versionId'>
            /// Format - uuid.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SchemaVersionReadDTO> PatchSchemaVersionAsync(this ISchema operations, string id, string versionId, IList<Operation> body = default(IList<Operation>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchSchemaVersionWithHttpMessagesAsync(id, versionId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Toogles the active status of schema version
            /// </summary>
            /// <remarks>
            /// Toogles the active status of schema version
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='versionId'>
            /// Format - uuid.
            /// </param>
            public static SchemaVersionReadDTO UpdateSchemaVersionIsActive(this ISchema operations, string id, string versionId)
            {
                return operations.UpdateSchemaVersionIsActiveAsync(id, versionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Toogles the active status of schema version
            /// </summary>
            /// <remarks>
            /// Toogles the active status of schema version
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='versionId'>
            /// Format - uuid.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SchemaVersionReadDTO> UpdateSchemaVersionIsActiveAsync(this ISchema operations, string id, string versionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateSchemaVersionIsActiveWithHttpMessagesAsync(id, versionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets columns by schema version Id
            /// </summary>
            /// <remarks>
            /// Gets columns by schema version Id
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='versionId'>
            /// Format - uuid.
            /// </param>
            public static IList<SchemaColumnReadDTO> GetColumnList(this ISchema operations, string id, string versionId)
            {
                return operations.GetColumnListAsync(id, versionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets columns by schema version Id
            /// </summary>
            /// <remarks>
            /// Gets columns by schema version Id
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='versionId'>
            /// Format - uuid.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<SchemaColumnReadDTO>> GetColumnListAsync(this ISchema operations, string id, string versionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetColumnListWithHttpMessagesAsync(id, versionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the row validators by schema version Id
            /// </summary>
            /// <remarks>
            /// Gets all the row validators by schema version Id
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='versionId'>
            /// Format - uuid.
            /// </param>
            public static IList<RowValidatorReadDTO> GetRowValidatorList(this ISchema operations, string id, string versionId)
            {
                return operations.GetRowValidatorListAsync(id, versionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the row validators by schema version Id
            /// </summary>
            /// <remarks>
            /// Gets all the row validators by schema version Id
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='versionId'>
            /// Format - uuid.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<RowValidatorReadDTO>> GetRowValidatorListAsync(this ISchema operations, string id, string versionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRowValidatorListWithHttpMessagesAsync(id, versionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Adds a version to a pre-defined schema
            /// </summary>
            /// <remarks>
            /// Adds a version to a pre-defined schema
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='schemaId'>
            /// Format - uuid.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static SchemaVersionReadDTO AddPredefinedSchemaVersion(this ISchema operations, string schemaId, SchemaVersionWriteDTO body = default(SchemaVersionWriteDTO))
            {
                return operations.AddPredefinedSchemaVersionAsync(schemaId, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a version to a pre-defined schema
            /// </summary>
            /// <remarks>
            /// Adds a version to a pre-defined schema
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='schemaId'>
            /// Format - uuid.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SchemaVersionReadDTO> AddPredefinedSchemaVersionAsync(this ISchema operations, string schemaId, SchemaVersionWriteDTO body = default(SchemaVersionWriteDTO), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddPredefinedSchemaVersionWithHttpMessagesAsync(schemaId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a pre-defined schema version details
            /// </summary>
            /// <remarks>
            /// Gets a pre-defined schema version details
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='versionId'>
            /// Format - uuid.
            /// </param>
            public static SchemaVersionReadDTO GetPredefinedSchemaVersion(this ISchema operations, string versionId)
            {
                return operations.GetPredefinedSchemaVersionAsync(versionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a pre-defined schema version details
            /// </summary>
            /// <remarks>
            /// Gets a pre-defined schema version details
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='versionId'>
            /// Format - uuid.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SchemaVersionReadDTO> GetPredefinedSchemaVersionAsync(this ISchema operations, string versionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPredefinedSchemaVersionWithHttpMessagesAsync(versionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Adds a new schema version
            /// </summary>
            /// <remarks>
            /// Adds a new schema version
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='schemaId'>
            /// Format - uuid.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static SchemaVersionReadDTO AddSchemaVersion(this ISchema operations, string id, string schemaId, SchemaVersionWriteDTO body = default(SchemaVersionWriteDTO))
            {
                return operations.AddSchemaVersionAsync(id, schemaId, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a new schema version
            /// </summary>
            /// <remarks>
            /// Adds a new schema version
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='schemaId'>
            /// Format - uuid.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SchemaVersionReadDTO> AddSchemaVersionAsync(this ISchema operations, string id, string schemaId, SchemaVersionWriteDTO body = default(SchemaVersionWriteDTO), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddSchemaVersionWithHttpMessagesAsync(id, schemaId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Removes a schema version
            /// </summary>
            /// <remarks>
            /// Removes a schema version
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='schemaVersionId'>
            /// Format - uuid.
            /// </param>
            public static void RemoveSchemaVersion(this ISchema operations, string id, string schemaVersionId)
            {
                operations.RemoveSchemaVersionAsync(id, schemaVersionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Removes a schema version
            /// </summary>
            /// <remarks>
            /// Removes a schema version
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Format - uuid. workspace Id
            /// </param>
            /// <param name='schemaVersionId'>
            /// Format - uuid.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RemoveSchemaVersionAsync(this ISchema operations, string id, string schemaVersionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RemoveSchemaVersionWithHttpMessagesAsync(id, schemaVersionId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
