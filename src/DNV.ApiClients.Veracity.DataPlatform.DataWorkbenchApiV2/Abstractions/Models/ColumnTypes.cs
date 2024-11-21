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
    /// Defines values for ColumnTypes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ColumnTypes
    {
        [EnumMember(Value = "String")]
        String,
        [EnumMember(Value = "Boolean")]
        Boolean,
        [EnumMember(Value = "Int32")]
        Int32,
        [EnumMember(Value = "Decimal")]
        Decimal,
        [EnumMember(Value = "DateOnly")]
        DateOnly,
        [EnumMember(Value = "DateTime")]
        DateTime,
        [EnumMember(Value = "Uri")]
        Uri,
        [EnumMember(Value = "Int64")]
        Int64,
        [EnumMember(Value = "Float")]
        Float,
        [EnumMember(Value = "Guid")]
        Guid
    }
    internal static class ColumnTypesEnumExtension
    {
        internal static string ToSerializedValue(this ColumnTypes? value)
        {
            return value == null ? null : ((ColumnTypes)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ColumnTypes value)
        {
            switch( value )
            {
                case ColumnTypes.String:
                    return "String";
                case ColumnTypes.Boolean:
                    return "Boolean";
                case ColumnTypes.Int32:
                    return "Int32";
                case ColumnTypes.Decimal:
                    return "Decimal";
                case ColumnTypes.DateOnly:
                    return "DateOnly";
                case ColumnTypes.DateTime:
                    return "DateTime";
                case ColumnTypes.Uri:
                    return "Uri";
                case ColumnTypes.Int64:
                    return "Int64";
                case ColumnTypes.Float:
                    return "Float";
                case ColumnTypes.Guid:
                    return "Guid";
            }
            return null;
        }

        internal static ColumnTypes? ParseColumnTypes(this string value)
        {
            switch( value )
            {
                case "String":
                    return ColumnTypes.String;
                case "Boolean":
                    return ColumnTypes.Boolean;
                case "Int32":
                    return ColumnTypes.Int32;
                case "Decimal":
                    return ColumnTypes.Decimal;
                case "DateOnly":
                    return ColumnTypes.DateOnly;
                case "DateTime":
                    return ColumnTypes.DateTime;
                case "Uri":
                    return ColumnTypes.Uri;
                case "Int64":
                    return ColumnTypes.Int64;
                case "Float":
                    return ColumnTypes.Float;
                case "Guid":
                    return ColumnTypes.Guid;
            }
            return null;
        }
    }
}