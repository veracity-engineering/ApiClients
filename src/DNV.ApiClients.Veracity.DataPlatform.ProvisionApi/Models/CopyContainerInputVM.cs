// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Linq;

namespace DNV.ApiClients.Veracity.DataPlatform.ProvisionApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    /// <summary>
    /// An input for provisioning a copy container
    /// </summary>
    public partial class CopyContainerInputVM
    {
        /// <summary>
        /// Initializes a new instance of the CopyContainerInputVM class.
        /// </summary>
        public CopyContainerInputVM()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CopyContainerInputVM class.
        /// </summary>
        /// <param name="sourceResourceId">GUID for source resource</param>
        /// <param name="copyResourceMayContainPersonalData">Indicates whether
        /// the user has accepted that the container will not contain personal
        /// data. Required to be true for a user to upload a container</param>
        /// <param name="groupId">ID of the group that copy container will be
        /// included once it is created.</param>
        /// <param name="copyResourceShortName">5-32 character short name used
        /// to distinguish between storage containers. The name needs to be
        /// lowercase and alphanumeric. The full name of the container will
        /// comprise of this shortname plus a unique Guid genarated by the
        /// system. Note - storage containers can not be renamed</param>
        /// <param name="copyResourceTitle">A title of the container</param>
        /// <param name="copyResourceDescription">A description of the
        /// container</param>
        /// <param name="copyResourceTags">List of container tags</param>
        public CopyContainerInputVM(System.Guid sourceResourceId, bool copyResourceMayContainPersonalData, System.Guid? groupId = default, string copyResourceShortName = default, string copyResourceTitle = default, string copyResourceDescription = default, Icon copyResourceIcon = default, IEnumerable<MetadataTag> copyResourceTags = default)
        {
            SourceResourceId = sourceResourceId;
            GroupId = groupId;
            CopyResourceShortName = copyResourceShortName;
            CopyResourceMayContainPersonalData = copyResourceMayContainPersonalData;
            CopyResourceTitle = copyResourceTitle;
            CopyResourceDescription = copyResourceDescription;
            CopyResourceIcon = copyResourceIcon;
            CopyResourceTags = copyResourceTags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets GUID for source resource
        /// </summary>
        [JsonProperty(PropertyName = "sourceResourceId")]
        public System.Guid SourceResourceId { get; set; }

        /// <summary>
        /// Gets or sets ID of the group that copy container will be included
        /// once it is created.
        /// </summary>
        [JsonProperty(PropertyName = "groupId")]
        public System.Guid? GroupId { get; set; }

        /// <summary>
        /// Gets or sets 5-32 character short name used to distinguish between
        /// storage containers. The name needs to be lowercase and
        /// alphanumeric. The full name of the container will comprise of this
        /// shortname plus a unique Guid genarated by the system. Note -
        /// storage containers can not be renamed
        /// </summary>
        [JsonProperty(PropertyName = "copyResourceShortName")]
        public string CopyResourceShortName { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the user has accepted that the
        /// container will not contain personal data. Required to be true for a
        /// user to upload a container
        /// </summary>
        [JsonProperty(PropertyName = "copyResourceMayContainPersonalData")]
        public bool CopyResourceMayContainPersonalData { get; set; }

        /// <summary>
        /// Gets or sets a title of the container
        /// </summary>
        [JsonProperty(PropertyName = "copyResourceTitle")]
        public string CopyResourceTitle { get; set; }

        /// <summary>
        /// Gets or sets a description of the container
        /// </summary>
        [JsonProperty(PropertyName = "copyResourceDescription")]
        public string CopyResourceDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "copyResourceIcon")]
        public Icon CopyResourceIcon { get; set; }

        /// <summary>
        /// Gets or sets list of container tags
        /// </summary>
        [JsonProperty(PropertyName = "copyResourceTags")]
        public IEnumerable<MetadataTag> CopyResourceTags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
