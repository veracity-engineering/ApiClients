// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracity.DataWorkbench.Tenant.ApiClient.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ScopeTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ScopeTypeEnum
    {
        [EnumMember(Value = "Tenant")]
        Tenant,
        [EnumMember(Value = "Workspace")]
        Workspace,
        [EnumMember(Value = "Dataset")]
        Dataset
    }
    internal static class ScopeTypeEnumEnumExtension
    {
        internal static string ToSerializedValue(this ScopeTypeEnum? value)
        {
            return value == null ? null : ((ScopeTypeEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ScopeTypeEnum value)
        {
            switch( value )
            {
                case ScopeTypeEnum.Tenant:
                    return "Tenant";
                case ScopeTypeEnum.Workspace:
                    return "Workspace";
                case ScopeTypeEnum.Dataset:
                    return "Dataset";
            }
            return null;
        }

        internal static ScopeTypeEnum? ParseScopeTypeEnum(this string value)
        {
            switch( value )
            {
                case "Tenant":
                    return ScopeTypeEnum.Tenant;
                case "Workspace":
                    return ScopeTypeEnum.Workspace;
                case "Dataset":
                    return ScopeTypeEnum.Dataset;
            }
            return null;
        }
    }
}
