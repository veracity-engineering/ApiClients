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
    /// Defines values for SASType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SASType
    {
        [EnumMember(Value = "dfs")]
        Dfs,
        [EnumMember(Value = "blob")]
        Blob
    }
    internal static class SASTypeEnumExtension
    {
        internal static string ToSerializedValue(this SASType? value)
        {
            return value == null ? null : ((SASType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SASType value)
        {
            switch( value )
            {
                case SASType.Dfs:
                    return "dfs";
                case SASType.Blob:
                    return "blob";
            }
            return null;
        }

        internal static SASType? ParseSASType(this string value)
        {
            switch( value )
            {
                case "dfs":
                    return SASType.Dfs;
                case "blob":
                    return SASType.Blob;
            }
            return null;
        }
    }
}