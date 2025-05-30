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
    /// Defines values for SharedByTypesDTO.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SharedByTypesDTO
    {
        [EnumMember(Value = "User")]
        User,
        [EnumMember(Value = "Workspace")]
        Workspace
    }
    internal static class SharedByTypesDTOEnumExtension
    {
        internal static string ToSerializedValue(this SharedByTypesDTO? value)
        {
            return value == null ? null : ((SharedByTypesDTO)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SharedByTypesDTO value)
        {
            switch( value )
            {
                case SharedByTypesDTO.User:
                    return "User";
                case SharedByTypesDTO.Workspace:
                    return "Workspace";
            }
            return null;
        }

        internal static SharedByTypesDTO? ParseSharedByTypesDTO(this string value)
        {
            switch( value )
            {
                case "User":
                    return SharedByTypesDTO.User;
                case "Workspace":
                    return SharedByTypesDTO.Workspace;
            }
            return null;
        }
    }
}
