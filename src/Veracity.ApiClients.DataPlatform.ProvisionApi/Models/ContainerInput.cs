// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracity.ApiClients.DataPlatform.ProvisionApi.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An input for provisioning a container
    /// </summary>
    public partial class ContainerInput
    {
        /// <summary>
        /// Initializes a new instance of the ContainerInput class.
        /// </summary>
        public ContainerInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerInput class.
        /// </summary>
        /// <param name="storageLocation">The Location which a storage
        /// container will be provisioned. Containers can only be created in
        /// supported regions</param>
        /// <param name="mayContainPersonalData">Indicates whether the user has
        /// accepted that the container will not contain personal data.
        /// Required to be true for a user to upload a container</param>
        /// <param name="containerShortName">5-32 character short name used to
        /// distinguish between storage containers. The name needs to be
        /// lowercase and alphanumeric. The full name of the container will
        /// comprise of this shortname plus a unique Guid genarated by the
        /// system. Note - storage containers can not be renamed</param>
        /// <param name="title">A title of the container</param>
        /// <param name="description">A description of the container</param>
        /// <param name="tags">List of container tags</param>
        public ContainerInput(string storageLocation, bool mayContainPersonalData, string containerShortName = default(string), string title = default(string), string description = default(string), Icon icon = default(Icon), IList<MetadataTag> tags = default(IList<MetadataTag>))
        {
            StorageLocation = storageLocation;
            ContainerShortName = containerShortName;
            MayContainPersonalData = mayContainPersonalData;
            Title = title;
            Description = description;
            Icon = icon;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Location which a storage container will be
        /// provisioned. Containers can only be created in supported regions
        /// </summary>
        [JsonProperty(PropertyName = "storageLocation")]
        public string StorageLocation { get; set; }

        /// <summary>
        /// Gets or sets 5-32 character short name used to distinguish between
        /// storage containers. The name needs to be lowercase and
        /// alphanumeric. The full name of the container will comprise of this
        /// shortname plus a unique Guid genarated by the system. Note -
        /// storage containers can not be renamed
        /// </summary>
        [JsonProperty(PropertyName = "containerShortName")]
        public string ContainerShortName { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the user has accepted that the
        /// container will not contain personal data. Required to be true for a
        /// user to upload a container
        /// </summary>
        [JsonProperty(PropertyName = "mayContainPersonalData")]
        public bool MayContainPersonalData { get; set; }

        /// <summary>
        /// Gets or sets a title of the container
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets a description of the container
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "icon")]
        public Icon Icon { get; set; }

        /// <summary>
        /// Gets or sets list of container tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<MetadataTag> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageLocation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageLocation");
            }
        }
    }
}
