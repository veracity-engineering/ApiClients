// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.Identity.ServicesApiV3.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ActivationTypes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActivationTypes
    {
        [EnumMember(Value = "emailLink")]
        EmailLink,
        [EnumMember(Value = "otp")]
        Otp
    }
    internal static class ActivationTypesEnumExtension
    {
        internal static string ToSerializedValue(this ActivationTypes? value)
        {
            return value == null ? null : ((ActivationTypes)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ActivationTypes value)
        {
            switch( value )
            {
                case ActivationTypes.EmailLink:
                    return "emailLink";
                case ActivationTypes.Otp:
                    return "otp";
            }
            return null;
        }

        internal static ActivationTypes? ParseActivationTypes(this string value)
        {
            switch( value )
            {
                case "emailLink":
                    return ActivationTypes.EmailLink;
                case "otp":
                    return ActivationTypes.Otp;
            }
            return null;
        }
    }
}
