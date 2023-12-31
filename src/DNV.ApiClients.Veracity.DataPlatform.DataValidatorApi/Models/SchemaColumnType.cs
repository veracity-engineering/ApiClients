// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.DataPlatform.DataValidatorApi.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SchemaColumnType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SchemaColumnType
    {
        [EnumMember(Value = "Validation")]
        Validation,
        [EnumMember(Value = "Metadata")]
        Metadata
    }
    internal static class SchemaColumnTypeEnumExtension
    {
        internal static string ToSerializedValue(this SchemaColumnType? value)
        {
            return value == null ? null : ((SchemaColumnType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SchemaColumnType value)
        {
            switch( value )
            {
                case SchemaColumnType.Validation:
                    return "Validation";
                case SchemaColumnType.Metadata:
                    return "Metadata";
            }
            return null;
        }

        internal static SchemaColumnType? ParseSchemaColumnType(this string value)
        {
            switch( value )
            {
                case "Validation":
                    return SchemaColumnType.Validation;
                case "Metadata":
                    return SchemaColumnType.Metadata;
            }
            return null;
        }
    }
}
