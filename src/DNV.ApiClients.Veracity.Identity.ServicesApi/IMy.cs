// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.Identity.ServicesApi
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// My operations.
    /// </summary>
    public partial interface IMy
    {
        /// <summary>
        /// My_Info
        /// </summary>
        /// <remarks>
        /// Retreives the profile of the current logged in user. Note that we
        /// will remove the company node from the result in the future
        /// </remarks>
        /// <param name='xSupportCode'>
        /// Provide a correlation token for log lookup. This is optional.
        /// </param>
        /// <param name='ocpApimSubscriptionKey'>
        /// Veracity api management subscription key
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
        Task<HttpOperationResponse<MyUserInfo,MyInfoHeaders>> InfoWithHttpMessagesAsync(string xSupportCode = default(string), string ocpApimSubscriptionKey = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// My_ProfilePicture
        /// </summary>
        /// <remarks>
        /// Retreives the profile picture of the current logegd in user if one
        /// is set, otherwise a 404 is returned
        /// </remarks>
        /// <param name='xSupportCode'>
        /// Provide a correlation token for log lookup. This is optional.
        /// </param>
        /// <param name='ocpApimSubscriptionKey'>
        /// Veracity api management subscription key
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
        Task<HttpOperationResponse<ProfilePicture,MyProfilePictureHeaders>> ProfilePictureMethodWithHttpMessagesAsync(string xSupportCode = default(string), string ocpApimSubscriptionKey = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// My_GetMessageCount
        /// </summary>
        /// <remarks>
        /// Get the current loged in users unread messages count
        /// </remarks>
        /// <param name='xSupportCode'>
        /// Provide a correlation token for log lookup. This is optional.
        /// </param>
        /// <param name='ocpApimSubscriptionKey'>
        /// Veracity api management subscription key
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
        Task<HttpOperationResponse<int?,MyGetMessageCountHeaders>> GetMessageCountWithHttpMessagesAsync(string xSupportCode = default(string), string ocpApimSubscriptionKey = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// My_GetMessagesAsync
        /// </summary>
        /// <remarks>
        /// Read the users messages. All: include read messages
        /// </remarks>
        /// <param name='all'>
        /// </param>
        /// <param name='xSupportCode'>
        /// Provide a correlation token for log lookup. This is optional.
        /// </param>
        /// <param name='ocpApimSubscriptionKey'>
        /// Veracity api management subscription key
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
        Task<HttpOperationResponse<IList<MessageReference>,MyGetMessagesAsyncHeaders>> GetMessagesAsyncWithHttpMessagesAsync(bool all, string xSupportCode = default(string), string ocpApimSubscriptionKey = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// My_MarkAllMessagesAsRead
        /// </summary>
        /// <remarks>
        /// Marks all unread messages as read
        /// </remarks>
        /// <param name='xSupportCode'>
        /// Provide a correlation token for log lookup. This is optional.
        /// </param>
        /// <param name='ocpApimSubscriptionKey'>
        /// Veracity api management subscription key
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
        Task<HttpOperationHeaderResponse<MyMarkAllMessagesAsReadHeaders>> MarkAllMessagesAsReadWithHttpMessagesAsync(string xSupportCode = default(string), string ocpApimSubscriptionKey = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// My_GetMyCompanies
        /// </summary>
        /// <remarks>
        /// Get all companies related to the current user
        /// </remarks>
        /// <param name='xSupportCode'>
        /// Provide a correlation token for log lookup. This is optional.
        /// </param>
        /// <param name='ocpApimSubscriptionKey'>
        /// Veracity api management subscription key
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
        Task<HttpOperationResponse<IList<CompanyReference>,MyGetMyCompaniesHeaders>> GetMyCompaniesWithHttpMessagesAsync(string xSupportCode = default(string), string ocpApimSubscriptionKey = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// My_ValidatePolicy
        /// </summary>
        /// <remarks>
        /// Validates all myDnvgl policies and returns a list of the policies
        /// that needs attention
        /// </remarks>
        /// <param name='serviceId'>
        /// </param>
        /// <param name='returnUrl'>
        /// </param>
        /// <param name='skipSubscriptionCheck'>
        /// </param>
        /// <param name='xSupportCode'>
        /// Provide a correlation token for log lookup. This is optional.
        /// </param>
        /// <param name='ocpApimSubscriptionKey'>
        /// Veracity api management subscription key
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationHeaderResponse<MyValidatePolicyHeaders>> ValidatePolicyWithHttpMessagesAsync(string serviceId, string returnUrl = default(string), string skipSubscriptionCheck = default(string), string xSupportCode = default(string), string ocpApimSubscriptionKey = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// My_ValidatePolicies
        /// </summary>
        /// <remarks>
        /// Validates all myDnvgl policies and returns a list of the policies
        /// that needs attention
        /// </remarks>
        /// <param name='returnUrl'>
        /// </param>
        /// <param name='xSupportCode'>
        /// Provide a correlation token for log lookup. This is optional.
        /// </param>
        /// <param name='ocpApimSubscriptionKey'>
        /// Veracity api management subscription key
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
        Task<HttpOperationHeaderResponse<MyValidatePoliciesHeaders>> ValidatePoliciesWithHttpMessagesAsync(string returnUrl = default(string), string xSupportCode = default(string), string ocpApimSubscriptionKey = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// My_MyServices
        /// </summary>
        /// <remarks>
        /// Returns all services for the user
        /// </remarks>
        /// <param name='xSupportCode'>
        /// Provide a correlation token for log lookup. This is optional.
        /// </param>
        /// <param name='ocpApimSubscriptionKey'>
        /// Veracity api management subscription key
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
        Task<HttpOperationResponse<IList<MyServiceReference>,MyMyServicesHeaders>> MyServicesWithHttpMessagesAsync(string xSupportCode = default(string), string ocpApimSubscriptionKey = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// My_GetMyWidgets
        /// </summary>
        /// <remarks>
        /// Returns all widgets for the user. Mainly intended to be used by the
        /// Veracity Mobile app.
        /// </remarks>
        /// <param name='xSupportCode'>
        /// Provide a correlation token for log lookup. This is optional.
        /// </param>
        /// <param name='ocpApimSubscriptionKey'>
        /// Veracity api management subscription key
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
        Task<HttpOperationResponse<IList<Widget>,MyGetMyWidgetsHeaders>> GetMyWidgetsWithHttpMessagesAsync(string xSupportCode = default(string), string ocpApimSubscriptionKey = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}