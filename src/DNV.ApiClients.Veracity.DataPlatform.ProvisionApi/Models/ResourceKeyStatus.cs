// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.ProvisionApi.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ResourceKeyStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResourceKeyStatus
    {
        [EnumMember(Value = "noKeys")]
        NoKeys,
        [EnumMember(Value = "expired")]
        Expired,
        [EnumMember(Value = "available")]
        Available,
        [EnumMember(Value = "active")]
        Active
    }
    internal static class ResourceKeyStatusEnumExtension
    {
        internal static string ToSerializedValue(this ResourceKeyStatus? value)
        {
            return value == null ? null : ((ResourceKeyStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ResourceKeyStatus value)
        {
            switch( value )
            {
                case ResourceKeyStatus.NoKeys:
                    return "noKeys";
                case ResourceKeyStatus.Expired:
                    return "expired";
                case ResourceKeyStatus.Available:
                    return "available";
                case ResourceKeyStatus.Active:
                    return "active";
            }
            return null;
        }

        internal static ResourceKeyStatus? ParseResourceKeyStatus(this string value)
        {
            switch( value )
            {
                case "noKeys":
                    return ResourceKeyStatus.NoKeys;
                case "expired":
                    return ResourceKeyStatus.Expired;
                case "available":
                    return ResourceKeyStatus.Available;
                case "active":
                    return ResourceKeyStatus.Active;
            }
            return null;
        }
    }
}
