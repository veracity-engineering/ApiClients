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
    /// Defines values for OperationType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OperationType
    {
        [EnumMember(Value = "Add")]
        Add,
        [EnumMember(Value = "Remove")]
        Remove,
        [EnumMember(Value = "Replace")]
        Replace,
        [EnumMember(Value = "Move")]
        Move,
        [EnumMember(Value = "Copy")]
        Copy,
        [EnumMember(Value = "Test")]
        Test,
        [EnumMember(Value = "Invalid")]
        Invalid
    }
    internal static class OperationTypeEnumExtension
    {
        internal static string ToSerializedValue(this OperationType? value)
        {
            return value == null ? null : ((OperationType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OperationType value)
        {
            switch( value )
            {
                case OperationType.Add:
                    return "Add";
                case OperationType.Remove:
                    return "Remove";
                case OperationType.Replace:
                    return "Replace";
                case OperationType.Move:
                    return "Move";
                case OperationType.Copy:
                    return "Copy";
                case OperationType.Test:
                    return "Test";
                case OperationType.Invalid:
                    return "Invalid";
            }
            return null;
        }

        internal static OperationType? ParseOperationType(this string value)
        {
            switch( value )
            {
                case "Add":
                    return OperationType.Add;
                case "Remove":
                    return OperationType.Remove;
                case "Replace":
                    return OperationType.Replace;
                case "Move":
                    return OperationType.Move;
                case "Copy":
                    return OperationType.Copy;
                case "Test":
                    return OperationType.Test;
                case "Invalid":
                    return OperationType.Invalid;
            }
            return null;
        }
    }
}
