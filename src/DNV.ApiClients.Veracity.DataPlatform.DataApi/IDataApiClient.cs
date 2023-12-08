// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataApi
{
    using Models;
    using Newtonsoft.Json;

/// <summary>
    /// </summary>
    public partial interface IDataApiClient : System.IDisposable
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
        /// Gets the IV10Access.
        /// </summary>
        IV10Access V10Access { get; }

        /// <summary>
        /// Gets the IV10Application.
        /// </summary>
        IV10Application V10Application { get; }

        /// <summary>
        /// Gets the IV10DataStewards.
        /// </summary>
        IV10DataStewards V10DataStewards { get; }

        /// <summary>
        /// Gets the IV10KeyTemplates.
        /// </summary>
        IV10KeyTemplates V10KeyTemplates { get; }

        /// <summary>
        /// Gets the IV10Ledger.
        /// </summary>
        IV10Ledger V10Ledger { get; }

        /// <summary>
        /// Gets the IV10Resources.
        /// </summary>
        IV10Resources V10Resources { get; }

        /// <summary>
        /// Gets the IV10Tags.
        /// </summary>
        IV10Tags V10Tags { get; }

        /// <summary>
        /// Gets the IV10Users.
        /// </summary>
        IV10Users V10Users { get; }

        /// <summary>
        /// Gets the IV10Groups.
        /// </summary>
        IV10Groups V10Groups { get; }

    }
}
