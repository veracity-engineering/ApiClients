// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.Identity.ServicesApi.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// CompaniesDirectory operations.
    /// </summary>
    public partial interface ICompaniesDirectory
    {
        /// <summary>
        /// CompaniesDirectory_CompanyById
        /// </summary>
        /// <remarks>
        /// Get the detailed company description
        /// </remarks>
        /// <param name='id'>
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<CompanyInfo,CompaniesDirectoryCompanyByIdHeaders>> CompanyByIdWithHttpMessagesAsync(string id, string xSupportCode = default, string ocpApimSubscriptionKey = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// CompaniesDirectory_GetUsersByCompany
        /// </summary>
        /// <remarks>
        /// Get users affiliated with the company. Paged query: uses 0 based
        /// page index
        /// </remarks>
        /// <param name='id'>
        /// </param>
        /// <param name='page'>
        /// Format - int32.
        /// </param>
        /// <param name='pageSize'>
        /// Format - int32.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IEnumerable<UserReference>,CompaniesDirectoryGetUsersByCompanyHeaders>> GetUsersByCompanyWithHttpMessagesAsync(string id, int page, int pageSize, string xSupportCode = default, string ocpApimSubscriptionKey = default, Dictionary<string, IList<string>> customHeaders = null, CancellationToken cancellationToken = default);
    }
}