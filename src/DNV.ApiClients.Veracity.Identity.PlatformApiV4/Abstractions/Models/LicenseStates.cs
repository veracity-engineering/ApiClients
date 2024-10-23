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
    /// Defines values for LicenseStates.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LicenseStates
    {
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Active")]
        Active
    }
    internal static class LicenseStatesEnumExtension
    {
        internal static string ToSerializedValue(this LicenseStates? value)
        {
            return value == null ? null : ((LicenseStates)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this LicenseStates value)
        {
            switch( value )
            {
                case LicenseStates.Pending:
                    return "Pending";
                case LicenseStates.Active:
                    return "Active";
            }
            return null;
        }

        internal static LicenseStates? ParseLicenseStates(this string value)
        {
            switch( value )
            {
                case "Pending":
                    return LicenseStates.Pending;
                case "Active":
                    return LicenseStates.Active;
            }
            return null;
        }
    }
}
