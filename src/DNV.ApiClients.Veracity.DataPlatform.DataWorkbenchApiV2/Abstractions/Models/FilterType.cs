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
    /// Defines values for FilterType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FilterType
    {
        [EnumMember(Value = "List")]
        List,
        [EnumMember(Value = "From")]
        From,
        [EnumMember(Value = "To")]
        To,
        [EnumMember(Value = "Equals")]
        Equals,
        [EnumMember(Value = "Greater")]
        Greater,
        [EnumMember(Value = "GreaterOrEqual")]
        GreaterOrEqual,
        [EnumMember(Value = "Less")]
        Less,
        [EnumMember(Value = "LessOrEqual")]
        LessOrEqual,
        [EnumMember(Value = "NonFromList")]
        NonFromList,
        [EnumMember(Value = "StringContains")]
        StringContains
    }
    internal static class FilterTypeEnumExtension
    {
        internal static string ToSerializedValue(this FilterType? value)
        {
            return value == null ? null : ((FilterType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this FilterType value)
        {
            switch( value )
            {
                case FilterType.List:
                    return "List";
                case FilterType.From:
                    return "From";
                case FilterType.To:
                    return "To";
                case FilterType.Equals:
                    return "Equals";
                case FilterType.Greater:
                    return "Greater";
                case FilterType.GreaterOrEqual:
                    return "GreaterOrEqual";
                case FilterType.Less:
                    return "Less";
                case FilterType.LessOrEqual:
                    return "LessOrEqual";
                case FilterType.NonFromList:
                    return "NonFromList";
                case FilterType.StringContains:
                    return "StringContains";
            }
            return null;
        }

        internal static FilterType? ParseFilterType(this string value)
        {
            switch( value )
            {
                case "List":
                    return FilterType.List;
                case "From":
                    return FilterType.From;
                case "To":
                    return FilterType.To;
                case "Equals":
                    return FilterType.Equals;
                case "Greater":
                    return FilterType.Greater;
                case "GreaterOrEqual":
                    return FilterType.GreaterOrEqual;
                case "Less":
                    return FilterType.Less;
                case "LessOrEqual":
                    return FilterType.LessOrEqual;
                case "NonFromList":
                    return FilterType.NonFromList;
                case "StringContains":
                    return FilterType.StringContains;
            }
            return null;
        }
    }
}