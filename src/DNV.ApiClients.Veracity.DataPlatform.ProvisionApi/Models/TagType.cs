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
    /// Defines values for TagType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TagType
    {
        [EnumMember(Value = "userTag")]
        UserTag,
        [EnumMember(Value = "systemTag")]
        SystemTag
    }
    internal static class TagTypeEnumExtension
    {
        internal static string ToSerializedValue(this TagType? value)
        {
            return value == null ? null : ((TagType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TagType value)
        {
            switch( value )
            {
                case TagType.UserTag:
                    return "userTag";
                case TagType.SystemTag:
                    return "systemTag";
            }
            return null;
        }

        internal static TagType? ParseTagType(this string value)
        {
            switch( value )
            {
                case "userTag":
                    return TagType.UserTag;
                case "systemTag":
                    return TagType.SystemTag;
            }
            return null;
        }
    }
}