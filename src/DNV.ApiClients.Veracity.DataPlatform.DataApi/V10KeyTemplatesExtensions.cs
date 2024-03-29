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
    /// Extension methods for V10KeyTemplates.
    /// </summary>
    public static partial class V10KeyTemplatesExtensions
    {
            /// <summary>
            /// Returns the templates for the different types of keys you can generate.
            /// </summary>
            /// <remarks>
            /// Returns the template for the different types of keys you can generate.
            /// Blob Storage is the only storage type supported at the moment.
            ///
            /// Supported access types for the Blob Storage types are as follows:
            /// 1. Write key
            /// 2. Read and list key
            /// 3. Read, write and list key
            /// 4. Read, write, delete and list key
            /// For Each access type there are key templates that lasts 1 h, 8 h, 1 month,
            /// 2 months, 3 months, 4 months, 5 months and 6 months.
            ///
            /// Note : "IsSystemKey" field in the result data is not relevant for the
            /// functionality currently supported. Please ignore that field.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IEnumerable<KeyTemplateVM> GetStorageKeyTemplates(this IV10KeyTemplates operations)
            {
                return operations.GetStorageKeyTemplatesAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the templates for the different types of keys you can generate.
            /// </summary>
            /// <remarks>
            /// Returns the template for the different types of keys you can generate.
            /// Blob Storage is the only storage type supported at the moment.
            ///
            /// Supported access types for the Blob Storage types are as follows:
            /// 1. Write key
            /// 2. Read and list key
            /// 3. Read, write and list key
            /// 4. Read, write, delete and list key
            /// For Each access type there are key templates that lasts 1 h, 8 h, 1 month,
            /// 2 months, 3 months, 4 months, 5 months and 6 months.
            ///
            /// Note : "IsSystemKey" field in the result data is not relevant for the
            /// functionality currently supported. Please ignore that field.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<KeyTemplateVM>> GetStorageKeyTemplatesAsync(this IV10KeyTemplates operations, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.GetStorageKeyTemplatesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
