// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.Identity.PlatformApiV4.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Groups operations.
    /// </summary>
    public partial interface IGroups
    {
        /// <summary>
        /// Get groups in the tenant
        ///
        /// query sample:
        /// tenants/be0c84cb-7a4a-4114-aa17-9c0224b084cf/groups?$filter=name eq
        /// 'AN_Techleads'&amp;$top=1&amp;$skip=0&lt;br/&gt;Retrieve groups and
        /// group members to determine access rights within your application
        ///
        /// tenantId can be the guid or the dnvCustomerId for the tenant
        /// </summary>
        /// <param name='tenantId'>
        /// </param>
        /// <param name='odata'>
        /// </param>
        /// <param name='requestId'>
        /// A correlation token to use when looking in the logs.
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
        Task<HttpOperationResponse<GroupResponseModel>> GetGroupsWithHttpMessagesAsync(string tenantId, IDictionary<string, string> odata = default, string requestId = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get groups in the tenant
        ///
        /// query sample:
        /// tenants/be0c84cb-7a4a-4114-aa17-9c0224b084cf/groups?$filter=name eq
        /// 'AN_Techleads'&amp;$top=1&amp;$skip=0&lt;br/&gt;Retrieve groups and
        /// group members to determine access rights within your application
        ///
        /// tenantId can be the guid or the dnvCustomerId for the tenant
        /// </summary>
        /// <param name='tenantId'>
        /// </param>
        /// <param name='odata'>
        /// </param>
        /// <param name='requestId'>
        /// A correlation token to use when looking in the logs.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<GroupResponseModel> GetGroupsAsync(string tenantId, IDictionary<string, string> odata = default, string requestId = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get group by id&lt;br/&gt;Retrieve groups and group members to
        /// determine access rights within your application
        ///
        /// tenantId can be the guid or the dnvCustomerId for the tenant
        /// </summary>
        /// <param name='tenantId'>
        /// </param>
        /// <param name='groupId'>
        /// </param>
        /// <param name='requestId'>
        /// A correlation token to use when looking in the logs.
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
        Task<HttpOperationResponse<GroupResponse>> GetGroupWithHttpMessagesAsync(string tenantId, System.Guid groupId, string requestId = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get group by id&lt;br/&gt;Retrieve groups and group members to
        /// determine access rights within your application
        ///
        /// tenantId can be the guid or the dnvCustomerId for the tenant
        /// </summary>
        /// <param name='tenantId'>
        /// </param>
        /// <param name='groupId'>
        /// </param>
        /// <param name='requestId'>
        /// A correlation token to use when looking in the logs.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<GroupResponse> GetGroupAsync(string tenantId, System.Guid groupId, string requestId = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update extension properties for a group. Extension properties have
        /// the name format {prefix}_property name. Prefixes are registered in
        /// developer.veracity.com. Pleas note that the order of operations can
        /// impact the result&lt;br/&gt;Retrieve groups and group members to
        /// determine access rights within your application
        ///
        /// tenantId can be the guid or the dnvCustomerId for the tenant
        /// </summary>
        /// <param name='tenantId'>
        /// </param>
        /// <param name='groupId'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='requestId'>
        /// A correlation token to use when looking in the logs.
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
        Task<HttpOperationResponse<GroupResponse>> PatchGroupWithHttpMessagesAsync(string tenantId, System.Guid groupId, IEnumerable<Operation> body = default, string requestId = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update extension properties for a group. Extension properties have
        /// the name format {prefix}_property name. Prefixes are registered in
        /// developer.veracity.com. Pleas note that the order of operations can
        /// impact the result&lt;br/&gt;Retrieve groups and group members to
        /// determine access rights within your application
        ///
        /// tenantId can be the guid or the dnvCustomerId for the tenant
        /// </summary>
        /// <param name='tenantId'>
        /// </param>
        /// <param name='groupId'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='requestId'>
        /// A correlation token to use when looking in the logs.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<GroupResponse> PatchGroupAsync(string tenantId, System.Guid groupId, IEnumerable<Operation> body = default, string requestId = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get all direct users and groups&lt;br/&gt;Retrieve groups and group
        /// members to determine access rights within your application
        ///
        /// tenantId can be the guid or the dnvCustomerId for the tenant
        /// </summary>
        /// <param name='tenantId'>
        /// </param>
        /// <param name='groupId'>
        /// </param>
        /// <param name='memberType'>
        /// Represents the type of entity. Possible values include: 'profile',
        /// 'userGroup'
        /// </param>
        /// <param name='requestId'>
        /// A correlation token to use when looking in the logs.
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
        Task<HttpOperationResponse<IEnumerable<MemberResponse>>> GetGroupMembersWithHttpMessagesAsync(string tenantId, System.Guid groupId, string memberType = default, string requestId = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get all direct users and groups&lt;br/&gt;Retrieve groups and group
        /// members to determine access rights within your application
        ///
        /// tenantId can be the guid or the dnvCustomerId for the tenant
        /// </summary>
        /// <param name='tenantId'>
        /// </param>
        /// <param name='groupId'>
        /// </param>
        /// <param name='memberType'>
        /// Represents the type of entity. Possible values include: 'profile',
        /// 'userGroup'
        /// </param>
        /// <param name='requestId'>
        /// A correlation token to use when looking in the logs.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<IEnumerable<MemberResponse>> GetGroupMembersAsync(string tenantId, System.Guid groupId, string memberType = default, string requestId = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get all users including inherited from groups&lt;br/&gt;Retrieve
        /// groups and group members to determine access rights within your
        /// application
        ///
        /// tenantId can be the guid or the dnvCustomerId for the tenant
        /// </summary>
        /// <param name='tenantId'>
        /// </param>
        /// <param name='groupId'>
        /// </param>
        /// <param name='requestId'>
        /// A correlation token to use when looking in the logs.
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
        Task<HttpOperationResponse<IEnumerable<UserResponse>>> GetMembersExplodedWithHttpMessagesAsync(string tenantId, System.Guid groupId, string requestId = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get all users including inherited from groups&lt;br/&gt;Retrieve
        /// groups and group members to determine access rights within your
        /// application
        ///
        /// tenantId can be the guid or the dnvCustomerId for the tenant
        /// </summary>
        /// <param name='tenantId'>
        /// </param>
        /// <param name='groupId'>
        /// </param>
        /// <param name='requestId'>
        /// A correlation token to use when looking in the logs.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<IEnumerable<UserResponse>> GetMembersExplodedAsync(string tenantId, System.Guid groupId, string requestId = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update extension properties  for a group membership. extension
        /// properties have the name format {prefix}_property name. Prefixes
        /// are registered in developer.veracity.com&lt;br/&gt;Retrieve groups
        /// and group members to determine access rights within your
        /// application
        ///
        /// tenantId can be the guid or the dnvCustomerId for the tenant
        /// </summary>
        /// <param name='tenantId'>
        /// </param>
        /// <param name='groupId'>
        /// </param>
        /// <param name='entityId'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='entityType'>
        /// Represents the type of entity. Possible values include: 'profile',
        /// 'userGroup'
        /// </param>
        /// <param name='requestId'>
        /// A correlation token to use when looking in the logs.
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
        Task<HttpOperationResponse<MemberResponse>> PatchMemberWithHttpMessagesAsync(string tenantId, System.Guid groupId, System.Guid entityId, IEnumerable<Operation> body = default, string entityType = default, string requestId = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update extension properties  for a group membership. extension
        /// properties have the name format {prefix}_property name. Prefixes
        /// are registered in developer.veracity.com&lt;br/&gt;Retrieve groups
        /// and group members to determine access rights within your
        /// application
        ///
        /// tenantId can be the guid or the dnvCustomerId for the tenant
        /// </summary>
        /// <param name='tenantId'>
        /// </param>
        /// <param name='groupId'>
        /// </param>
        /// <param name='entityId'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='entityType'>
        /// Represents the type of entity. Possible values include: 'profile',
        /// 'userGroup'
        /// </param>
        /// <param name='requestId'>
        /// A correlation token to use when looking in the logs.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<MemberResponse> PatchMemberAsync(string tenantId, System.Guid groupId, System.Guid entityId, IEnumerable<Operation> body = default, string entityType = default, string requestId = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// List all groups this group is a member of&lt;br/&gt;Retrieve groups
        /// and group members to determine access rights within your
        /// application
        ///
        /// tenantId can be the guid or the dnvCustomerId for the tenant
        /// </summary>
        /// <param name='tenantId'>
        /// </param>
        /// <param name='groupId'>
        /// </param>
        /// <param name='requestId'>
        /// A correlation token to use when looking in the logs.
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
        Task<HttpOperationResponse<IEnumerable<GroupResponse>>> GetMemberOfWithHttpMessagesAsync(string tenantId, System.Guid groupId, string requestId = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// List all groups this group is a member of&lt;br/&gt;Retrieve groups
        /// and group members to determine access rights within your
        /// application
        ///
        /// tenantId can be the guid or the dnvCustomerId for the tenant
        /// </summary>
        /// <param name='tenantId'>
        /// </param>
        /// <param name='groupId'>
        /// </param>
        /// <param name='requestId'>
        /// A correlation token to use when looking in the logs.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<IEnumerable<GroupResponse>> GetMemberOfAsync(string tenantId, System.Guid groupId, string requestId = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get all applications this group has a license
        /// for&lt;br/&gt;Retrieve groups and group members to determine access
        /// rights within your application
        ///
        /// tenantId can be the guid or the dnvCustomerId for the tenant
        /// </summary>
        /// <param name='tenantId'>
        /// </param>
        /// <param name='groupId'>
        /// </param>
        /// <param name='requestId'>
        /// A correlation token to use when looking in the logs.
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
        Task<HttpOperationResponse<IEnumerable<ApplicationResponse>>> GetApplicationsWithHttpMessagesAsync(string tenantId, System.Guid groupId, string requestId = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get all applications this group has a license
        /// for&lt;br/&gt;Retrieve groups and group members to determine access
        /// rights within your application
        ///
        /// tenantId can be the guid or the dnvCustomerId for the tenant
        /// </summary>
        /// <param name='tenantId'>
        /// </param>
        /// <param name='groupId'>
        /// </param>
        /// <param name='requestId'>
        /// A correlation token to use when looking in the logs.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<IEnumerable<ApplicationResponse>> GetApplicationsAsync(string tenantId, System.Guid groupId, string requestId = default, CancellationToken cancellationToken = default);

    }
}
