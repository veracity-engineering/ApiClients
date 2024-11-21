// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataWorkbenchApiV2.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ProviderType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProviderType
    {
        [EnumMember(Value = "GPM")]
        GPM
    }
    internal static class ProviderTypeEnumExtension
    {
        internal static string ToSerializedValue(this ProviderType? value)
        {
            return value == null ? null : ((ProviderType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ProviderType value)
        {
            switch( value )
            {
                case ProviderType.GPM:
                    return "GPM";
            }
            return null;
        }

        internal static ProviderType? ParseProviderType(this string value)
        {
            switch( value )
            {
                case "GPM":
                    return ProviderType.GPM;
            }
            return null;
        }
    }
}