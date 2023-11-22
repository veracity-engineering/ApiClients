// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.Identity.ServicesApi.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for UserCreationOptionTypes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserCreationOptionTypes
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "onlyInvited")]
        OnlyInvited,
        [EnumMember(Value = "onlyNew")]
        OnlyNew
    }
    internal static class UserCreationOptionTypesEnumExtension
    {
        internal static string ToSerializedValue(this UserCreationOptionTypes? value)
        {
            return value == null ? null : ((UserCreationOptionTypes)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this UserCreationOptionTypes value)
        {
            switch( value )
            {
                case UserCreationOptionTypes.All:
                    return "all";
                case UserCreationOptionTypes.OnlyInvited:
                    return "onlyInvited";
                case UserCreationOptionTypes.OnlyNew:
                    return "onlyNew";
            }
            return null;
        }

        internal static UserCreationOptionTypes? ParseUserCreationOptionTypes(this string value)
        {
            switch( value )
            {
                case "all":
                    return UserCreationOptionTypes.All;
                case "onlyInvited":
                    return UserCreationOptionTypes.OnlyInvited;
                case "onlyNew":
                    return UserCreationOptionTypes.OnlyNew;
            }
            return null;
        }
    }
}
