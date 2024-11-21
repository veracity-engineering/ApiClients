// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataWorkbenchApiV2.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Schemas operations.
    /// </summary>
    public partial interface ISchemas
    {
        /// <summary>
        /// Gets a list of workspace schemas for a specific workspace
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='includeDefaultSchemaVersion'>
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
        Task<HttpOperationResponse<IEnumerable<SchemaReadDto>>> GetWorkspaceSchemasWithHttpMessagesAsync(System.Guid workspaceId, bool? includeDefaultSchemaVersion = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of workspace schemas for a specific workspace
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='includeDefaultSchemaVersion'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<IEnumerable<SchemaReadDto>> GetWorkspaceSchemasAsync(System.Guid workspaceId, bool? includeDefaultSchemaVersion = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// create a new schema
        /// </summary>
        /// <param name='body'>
        /// </param>
        /// <param name='workspaceId'>
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
        Task<HttpOperationResponse<IEnumerable<SchemaVersionReadDto>>> AddSchemaWithHttpMessagesAsync(SchemaWriteDto body, System.Guid workspaceId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// create a new schema
        /// </summary>
        /// <param name='body'>
        /// </param>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<IEnumerable<SchemaVersionReadDto>> AddSchemaAsync(SchemaWriteDto body, System.Guid workspaceId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get multiple schema versions
        /// </summary>
        /// <param name='body'>
        /// </param>
        /// <param name='workspaceId'>
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
        Task<HttpOperationResponse<IEnumerable<SchemaVersionReadDto>>> GetSchemaVersionsWithHttpMessagesAsync(IEnumerable<System.Guid?> body, System.Guid workspaceId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get multiple schema versions
        /// </summary>
        /// <param name='body'>
        /// </param>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<IEnumerable<SchemaVersionReadDto>> GetSchemaVersionsAsync(IEnumerable<System.Guid?> body, System.Guid workspaceId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Add a new schema version
        /// </summary>
        /// <param name='body'>
        /// </param>
        /// <param name='workspaceId'>
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
        Task<HttpOperationResponse<SchemaVersionReadDto>> AddSchemaVersionWithHttpMessagesAsync(SchemaVersionWriteDto body, System.Guid workspaceId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Add a new schema version
        /// </summary>
        /// <param name='body'>
        /// </param>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<SchemaVersionReadDto> AddSchemaVersionAsync(SchemaVersionWriteDto body, System.Guid workspaceId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a specific schema version
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='schemaVersionId'>
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
        Task<HttpOperationResponse<IEnumerable<SchemaVersionReadDto>>> GetSchemaVersionByIdWithHttpMessagesAsync(System.Guid workspaceId, System.Guid schemaVersionId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a specific schema version
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='schemaVersionId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<IEnumerable<SchemaVersionReadDto>> GetSchemaVersionByIdAsync(System.Guid workspaceId, System.Guid schemaVersionId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of column validators by workspace Id
        /// </summary>
        /// <remarks>
        /// Sample response:
        ///
        /// [
        /// {
        /// "id": "10ffec78-4792-4364-babd-e9c45b6f94ab",
        /// "workspaceId": "196a8ff4-dfbc-4ee7-ae08-4f38b84d9c86",
        /// "name": "string 3",
        /// "notEmpty": true,
        /// "dataFormat": "String",
        /// "minimum": 0,
        /// "maximum": 1,
        /// "exclusiveMinimum": true,
        /// "exclusiveMaximum": true,
        /// "minLength": 0,
        /// "maxLength": 1,
        /// "pattern": "string",
        /// "errorMessage": "string",
        /// "fallbackValue": "string",
        /// "createdBy": "61cecec8-629b-4779-b593-6505e2b9443b",
        /// "createdOn": "2024-06-26T14:20:50.1444566Z",
        /// "lastModifiedBy": "61cecec8-629b-4779-b593-6505e2b9443b",
        /// "lastModifiedOn": "2024-06-26T14:20:50.1444566Z"
        /// },
        /// {
        /// "id": "834c7130-92bf-428e-acb2-c5567a540106",
        /// "workspaceId": "196a8ff4-dfbc-4ee7-ae08-4f38b84d9c86",
        /// "name": "string",
        /// "notEmpty": true,
        /// "dataFormat": "String",
        /// "minimum": 1,
        /// "maximum": 3,
        /// "exclusiveMinimum": true,
        /// "exclusiveMaximum": true,
        /// "minLength": 1,
        /// "maxLength": 3,
        /// "pattern": "string",
        /// "errorMessage": "string",
        /// "fallbackValue": "string",
        /// "createdBy": "61cecec8-629b-4779-b593-6505e2b9443b",
        /// "createdOn": "2024-06-27T09:55:58.1032117Z",
        /// "lastModifiedBy": "61cecec8-629b-4779-b593-6505e2b9443b",
        /// "lastModifiedOn": "2024-06-27T09:55:58.1032117Z"
        /// }
        /// ]
        /// </remarks>
        /// <param name='workspaceId'>
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
        Task<HttpOperationResponse<IEnumerable<ColumnValidatorReadDto>>> GetValidatorsListByWorkspaceWithHttpMessagesAsync(System.Guid workspaceId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of column validators by workspace Id
        /// </summary>
        /// <remarks>
        /// Sample response:
        ///
        /// [
        /// {
        /// "id": "10ffec78-4792-4364-babd-e9c45b6f94ab",
        /// "workspaceId": "196a8ff4-dfbc-4ee7-ae08-4f38b84d9c86",
        /// "name": "string 3",
        /// "notEmpty": true,
        /// "dataFormat": "String",
        /// "minimum": 0,
        /// "maximum": 1,
        /// "exclusiveMinimum": true,
        /// "exclusiveMaximum": true,
        /// "minLength": 0,
        /// "maxLength": 1,
        /// "pattern": "string",
        /// "errorMessage": "string",
        /// "fallbackValue": "string",
        /// "createdBy": "61cecec8-629b-4779-b593-6505e2b9443b",
        /// "createdOn": "2024-06-26T14:20:50.1444566Z",
        /// "lastModifiedBy": "61cecec8-629b-4779-b593-6505e2b9443b",
        /// "lastModifiedOn": "2024-06-26T14:20:50.1444566Z"
        /// },
        /// {
        /// "id": "834c7130-92bf-428e-acb2-c5567a540106",
        /// "workspaceId": "196a8ff4-dfbc-4ee7-ae08-4f38b84d9c86",
        /// "name": "string",
        /// "notEmpty": true,
        /// "dataFormat": "String",
        /// "minimum": 1,
        /// "maximum": 3,
        /// "exclusiveMinimum": true,
        /// "exclusiveMaximum": true,
        /// "minLength": 1,
        /// "maxLength": 3,
        /// "pattern": "string",
        /// "errorMessage": "string",
        /// "fallbackValue": "string",
        /// "createdBy": "61cecec8-629b-4779-b593-6505e2b9443b",
        /// "createdOn": "2024-06-27T09:55:58.1032117Z",
        /// "lastModifiedBy": "61cecec8-629b-4779-b593-6505e2b9443b",
        /// "lastModifiedOn": "2024-06-27T09:55:58.1032117Z"
        /// }
        /// ]
        /// </remarks>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<IEnumerable<ColumnValidatorReadDto>> GetValidatorsListByWorkspaceAsync(System.Guid workspaceId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new column validator
        /// </summary>
        /// <remarks>
        /// Example of request body:
        ///
        /// {
        /// "name": "Can be empty",
        /// "notEmpty": false,
        /// "errorMessage": "Can be empty"
        /// }
        ///
        /// Sample response:
        ///
        /// {
        /// "id": "d4ab697e-23f8-403b-82cd-3ead39deb0c3",
        /// "workspaceId": "196a8ff4-dfbc-4ee7-ae08-4f38b84d9c86",
        /// "name": "Can be empty",
        /// "notEmpty": false,
        /// "errorMessage": "Can be empty",
        /// "createdBy": "61cecec8-629b-4779-b593-6505e2b9443b",
        /// "createdOn": "2024-07-05T09:52:48.8341034Z",
        /// "lastModifiedBy": "61cecec8-629b-4779-b593-6505e2b9443b",
        /// "lastModifiedOn": "2024-07-05T09:52:48.8341034Z"
        /// }
        /// </remarks>
        /// <param name='body'>
        /// </param>
        /// <param name='workspaceId'>
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
        Task<HttpOperationResponse<ColumnValidatorReadDto>> CreateValidatorWithWorkspaceWithHttpMessagesAsync(ColumnValidatorWriteDto body, System.Guid workspaceId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new column validator
        /// </summary>
        /// <remarks>
        /// Example of request body:
        ///
        /// {
        /// "name": "Can be empty",
        /// "notEmpty": false,
        /// "errorMessage": "Can be empty"
        /// }
        ///
        /// Sample response:
        ///
        /// {
        /// "id": "d4ab697e-23f8-403b-82cd-3ead39deb0c3",
        /// "workspaceId": "196a8ff4-dfbc-4ee7-ae08-4f38b84d9c86",
        /// "name": "Can be empty",
        /// "notEmpty": false,
        /// "errorMessage": "Can be empty",
        /// "createdBy": "61cecec8-629b-4779-b593-6505e2b9443b",
        /// "createdOn": "2024-07-05T09:52:48.8341034Z",
        /// "lastModifiedBy": "61cecec8-629b-4779-b593-6505e2b9443b",
        /// "lastModifiedOn": "2024-07-05T09:52:48.8341034Z"
        /// }
        /// </remarks>
        /// <param name='body'>
        /// </param>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<ColumnValidatorReadDto> CreateValidatorWithWorkspaceAsync(ColumnValidatorWriteDto body, System.Guid workspaceId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get list of global validators
        /// </summary>
        /// <remarks>
        /// Sample response:
        ///
        /// [
        /// {
        /// "id": "10ffec78-4792-4364-babd-e9c45b6f94ab",
        /// "workspaceId": "196a8ff4-dfbc-4ee7-ae08-4f38b84d9c86",
        /// "name": "string 3",
        /// "notEmpty": true,
        /// "dataFormat": "String",
        /// "minimum": 0,
        /// "maximum": 1,
        /// "exclusiveMinimum": true,
        /// "exclusiveMaximum": true,
        /// "minLength": 0,
        /// "maxLength": 1,
        /// "pattern": "string",
        /// "errorMessage": "string",
        /// "fallbackValue": "string",
        /// "createdBy": "61cecec8-629b-4779-b593-6505e2b9443b",
        /// "createdOn": "2024-06-26T14:20:50.1444566Z",
        /// "lastModifiedBy": "61cecec8-629b-4779-b593-6505e2b9443b",
        /// "lastModifiedOn": "2024-06-26T14:20:50.1444566Z"
        /// },
        /// {
        /// "id": "834c7130-92bf-428e-acb2-c5567a540106",
        /// "workspaceId": "196a8ff4-dfbc-4ee7-ae08-4f38b84d9c86",
        /// "name": "string",
        /// "notEmpty": true,
        /// "dataFormat": "String",
        /// "minimum": 1,
        /// "maximum": 3,
        /// "exclusiveMinimum": true,
        /// "exclusiveMaximum": true,
        /// "minLength": 1,
        /// "maxLength": 3,
        /// "pattern": "string",
        /// "errorMessage": "string",
        /// "fallbackValue": "string",
        /// "createdBy": "61cecec8-629b-4779-b593-6505e2b9443b",
        /// "createdOn": "2024-06-27T09:55:58.1032117Z",
        /// "lastModifiedBy": "61cecec8-629b-4779-b593-6505e2b9443b",
        /// "lastModifiedOn": "2024-06-27T09:55:58.1032117Z"
        /// }
        /// ]
        /// </remarks>
        /// <param name='workspaceId'>
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
        Task<HttpOperationResponse<IEnumerable<ColumnValidatorReadDto>>> GetValidatorsListWithHttpMessagesAsync(string workspaceId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get list of global validators
        /// </summary>
        /// <remarks>
        /// Sample response:
        ///
        /// [
        /// {
        /// "id": "10ffec78-4792-4364-babd-e9c45b6f94ab",
        /// "workspaceId": "196a8ff4-dfbc-4ee7-ae08-4f38b84d9c86",
        /// "name": "string 3",
        /// "notEmpty": true,
        /// "dataFormat": "String",
        /// "minimum": 0,
        /// "maximum": 1,
        /// "exclusiveMinimum": true,
        /// "exclusiveMaximum": true,
        /// "minLength": 0,
        /// "maxLength": 1,
        /// "pattern": "string",
        /// "errorMessage": "string",
        /// "fallbackValue": "string",
        /// "createdBy": "61cecec8-629b-4779-b593-6505e2b9443b",
        /// "createdOn": "2024-06-26T14:20:50.1444566Z",
        /// "lastModifiedBy": "61cecec8-629b-4779-b593-6505e2b9443b",
        /// "lastModifiedOn": "2024-06-26T14:20:50.1444566Z"
        /// },
        /// {
        /// "id": "834c7130-92bf-428e-acb2-c5567a540106",
        /// "workspaceId": "196a8ff4-dfbc-4ee7-ae08-4f38b84d9c86",
        /// "name": "string",
        /// "notEmpty": true,
        /// "dataFormat": "String",
        /// "minimum": 1,
        /// "maximum": 3,
        /// "exclusiveMinimum": true,
        /// "exclusiveMaximum": true,
        /// "minLength": 1,
        /// "maxLength": 3,
        /// "pattern": "string",
        /// "errorMessage": "string",
        /// "fallbackValue": "string",
        /// "createdBy": "61cecec8-629b-4779-b593-6505e2b9443b",
        /// "createdOn": "2024-06-27T09:55:58.1032117Z",
        /// "lastModifiedBy": "61cecec8-629b-4779-b593-6505e2b9443b",
        /// "lastModifiedOn": "2024-06-27T09:55:58.1032117Z"
        /// }
        /// ]
        /// </remarks>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<IEnumerable<ColumnValidatorReadDto>> GetValidatorsListAsync(string workspaceId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a column validator by Id
        /// </summary>
        /// <remarks>
        /// Sample response:
        ///
        /// {
        /// "id": "10ffec78-4792-4364-babd-e9c45b6f94ab",
        /// "workspaceId": "196a8ff4-dfbc-4ee7-ae08-4f38b84d9c86",
        /// "name": "string 3",
        /// "notEmpty": true,
        /// "dataFormat": "String",
        /// "minimum": 0,
        /// "maximum": 1,
        /// "exclusiveMinimum": true,
        /// "exclusiveMaximum": true,
        /// "minLength": 0,
        /// "maxLength": 1,
        /// "pattern": "string",
        /// "errorMessage": "string",
        /// "fallbackValue": "string",
        /// "createdBy": "80737649-9108-49ff-9811-a419be7c1862",
        /// "createdOn": "2024-06-26T14:20:50.1444566Z",
        /// "lastModifiedBy": "80737649-9108-49ff-9811-a419be7c1862",
        /// "lastModifiedOn": "2024-06-26T14:20:50.1444566Z"
        /// }
        /// </remarks>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='validatorId'>
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
        Task<HttpOperationResponse<ColumnValidatorReadDto>> GetValidatorByIdWithWorkspaceWithHttpMessagesAsync(System.Guid workspaceId, System.Guid validatorId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a column validator by Id
        /// </summary>
        /// <remarks>
        /// Sample response:
        ///
        /// {
        /// "id": "10ffec78-4792-4364-babd-e9c45b6f94ab",
        /// "workspaceId": "196a8ff4-dfbc-4ee7-ae08-4f38b84d9c86",
        /// "name": "string 3",
        /// "notEmpty": true,
        /// "dataFormat": "String",
        /// "minimum": 0,
        /// "maximum": 1,
        /// "exclusiveMinimum": true,
        /// "exclusiveMaximum": true,
        /// "minLength": 0,
        /// "maxLength": 1,
        /// "pattern": "string",
        /// "errorMessage": "string",
        /// "fallbackValue": "string",
        /// "createdBy": "80737649-9108-49ff-9811-a419be7c1862",
        /// "createdOn": "2024-06-26T14:20:50.1444566Z",
        /// "lastModifiedBy": "80737649-9108-49ff-9811-a419be7c1862",
        /// "lastModifiedOn": "2024-06-26T14:20:50.1444566Z"
        /// }
        /// </remarks>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='validatorId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<ColumnValidatorReadDto> GetValidatorByIdWithWorkspaceAsync(System.Guid workspaceId, System.Guid validatorId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates column validator by Id
        /// </summary>
        /// <remarks>
        /// Example of request body:
        ///
        /// {
        /// "name": "Not Empty",
        /// "notEmpty": true,
        /// "errorMessage": "Cannot be empty"
        /// }
        /// </remarks>
        /// <param name='body'>
        /// </param>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='validatorId'>
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
        Task<HttpOperationResponse<ColumnValidatorReadDto>> UpdateValidatorByIdWithWorkspaceWithHttpMessagesAsync(ColumnValidatorWriteDto body, System.Guid workspaceId, System.Guid validatorId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates column validator by Id
        /// </summary>
        /// <remarks>
        /// Example of request body:
        ///
        /// {
        /// "name": "Not Empty",
        /// "notEmpty": true,
        /// "errorMessage": "Cannot be empty"
        /// }
        /// </remarks>
        /// <param name='body'>
        /// </param>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='validatorId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<ColumnValidatorReadDto> UpdateValidatorByIdWithWorkspaceAsync(ColumnValidatorWriteDto body, System.Guid workspaceId, System.Guid validatorId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the column validator with the specified ID.
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='validatorId'>
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
        Task<HttpOperationResponse> DeleteValidatorByIdWithWorkspaceWithHttpMessagesAsync(System.Guid workspaceId, System.Guid validatorId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the column validator with the specified ID.
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='validatorId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task DeleteValidatorByIdWithWorkspaceAsync(System.Guid workspaceId, System.Guid validatorId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a specific schema
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='schemaId'>
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
        Task<HttpOperationResponse<SchemaReadDto>> GetSchemaByIdWithHttpMessagesAsync(System.Guid workspaceId, System.Guid schemaId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a specific schema
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='schemaId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<SchemaReadDto> GetSchemaByIdAsync(System.Guid workspaceId, System.Guid schemaId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Patch Schema
        /// </summary>
        /// <param name='body'>
        /// The input describing the schema
        /// </param>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='schemaId'>
        /// Schema Id to edit
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
        Task<HttpOperationResponse<SchemaReadDto>> UpdateSchemaWithHttpMessagesAsync(SchemaPatchDto body, System.Guid workspaceId, System.Guid schemaId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Patch Schema
        /// </summary>
        /// <param name='body'>
        /// The input describing the schema
        /// </param>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='schemaId'>
        /// Schema Id to edit
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<SchemaReadDto> UpdateSchemaAsync(SchemaPatchDto body, System.Guid workspaceId, System.Guid schemaId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Make schema version default
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='schemaId'>
        /// </param>
        /// <param name='schemaVersionId'>
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
        Task<HttpOperationResponse<SchemaVersionReadDto>> MakeSchemaVersionDefaultWithHttpMessagesAsync(System.Guid workspaceId, System.Guid schemaId, System.Guid schemaVersionId, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Make schema version default
        /// </summary>
        /// <param name='workspaceId'>
        /// </param>
        /// <param name='schemaId'>
        /// </param>
        /// <param name='schemaVersionId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<SchemaVersionReadDto> MakeSchemaVersionDefaultAsync(System.Guid workspaceId, System.Guid schemaId, System.Guid schemaVersionId, CancellationToken cancellationToken = default);

    }
}
