// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.Identity.PlatformApiV4.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ManagementModes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ManagementModes
    {
        [EnumMember(Value = "Legacy")]
        Legacy,
        [EnumMember(Value = "VeracityManaged")]
        VeracityManaged,
        [EnumMember(Value = "Hybrid")]
        Hybrid,
        [EnumMember(Value = "ServiceManaged")]
        ServiceManaged
    }
    internal static class ManagementModesEnumExtension
    {
        internal static string ToSerializedValue(this ManagementModes? value)
        {
            return value == null ? null : ((ManagementModes)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ManagementModes value)
        {
            switch( value )
            {
                case ManagementModes.Legacy:
                    return "Legacy";
                case ManagementModes.VeracityManaged:
                    return "VeracityManaged";
                case ManagementModes.Hybrid:
                    return "Hybrid";
                case ManagementModes.ServiceManaged:
                    return "ServiceManaged";
            }
            return null;
        }

        internal static ManagementModes? ParseManagementModes(this string value)
        {
            switch( value )
            {
                case "Legacy":
                    return ManagementModes.Legacy;
                case "VeracityManaged":
                    return ManagementModes.VeracityManaged;
                case "Hybrid":
                    return ManagementModes.Hybrid;
                case "ServiceManaged":
                    return ManagementModes.ServiceManaged;
            }
            return null;
        }
    }
}
