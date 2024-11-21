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
    /// Defines values for StoragePermissionType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StoragePermissionType
    {
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Write")]
        Write
    }
    internal static class StoragePermissionTypeEnumExtension
    {
        internal static string ToSerializedValue(this StoragePermissionType? value)
        {
            return value == null ? null : ((StoragePermissionType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this StoragePermissionType value)
        {
            switch( value )
            {
                case StoragePermissionType.Read:
                    return "Read";
                case StoragePermissionType.Write:
                    return "Write";
            }
            return null;
        }

        internal static StoragePermissionType? ParseStoragePermissionType(this string value)
        {
            switch( value )
            {
                case "Read":
                    return StoragePermissionType.Read;
                case "Write":
                    return StoragePermissionType.Write;
            }
            return null;
        }
    }
}