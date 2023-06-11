// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.Identity.ServicesApi
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// </summary>
    public partial interface IServicesApiClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the ICompaniesDirectory.
        /// </summary>
        ICompaniesDirectory CompaniesDirectory { get; }

        /// <summary>
        /// Gets the IDataContainerService.
        /// </summary>
        IDataContainerService DataContainerService { get; }

        /// <summary>
        /// Gets the IMy.
        /// </summary>
        IMy My { get; }

        /// <summary>
        /// Gets the IOptions.
        /// </summary>
        IOptions Options { get; }

        /// <summary>
        /// Gets the IServicesDirectory.
        /// </summary>
        IServicesDirectory ServicesDirectory { get; }

        /// <summary>
        /// Gets the IStatusService.
        /// </summary>
        IStatusService StatusService { get; }

        /// <summary>
        /// Gets the IThisModel.
        /// </summary>
        IThisModel ThisModel { get; }

        /// <summary>
        /// Gets the IUsersDirectory.
        /// </summary>
        IUsersDirectory UsersDirectory { get; }

        /// <summary>
        /// ServicesDirectory_GetServiceSubscriptions
        /// </summary>
        /// <param name='id'>
        /// </param>
        /// <param name='filter'>
        /// </param>
        /// <param name='pageNo'>
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
        Task<HttpOperationResponse<IList<SubscriptionDetails>,SixThreefSevenSixedffTwoFiveTwoTwoeOneEightcEightdThreebZeroFiveFiveHyphenMinusHeaders>> SixThreefSevenSixedffTwoFiveTwoTwoeOneEightcEightdThreebZeroFiveFiveWithHttpMessagesAsync(string id, string filter, int pageNo, string xSupportCode = default(string), string ocpApimSubscriptionKey = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}