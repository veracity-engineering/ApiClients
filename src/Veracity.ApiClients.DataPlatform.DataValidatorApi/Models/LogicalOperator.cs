// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracity.ApiClients.DataPlatform.DataValidatorApi.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for LogicalOperator.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LogicalOperator
    {
        [EnumMember(Value = "And")]
        And,
        [EnumMember(Value = "Or")]
        Or
    }
    internal static class LogicalOperatorEnumExtension
    {
        internal static string ToSerializedValue(this LogicalOperator? value)
        {
            return value == null ? null : ((LogicalOperator)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this LogicalOperator value)
        {
            switch( value )
            {
                case LogicalOperator.And:
                    return "And";
                case LogicalOperator.Or:
                    return "Or";
            }
            return null;
        }

        internal static LogicalOperator? ParseLogicalOperator(this string value)
        {
            switch( value )
            {
                case "And":
                    return LogicalOperator.And;
                case "Or":
                    return LogicalOperator.Or;
            }
            return null;
        }
    }
}
