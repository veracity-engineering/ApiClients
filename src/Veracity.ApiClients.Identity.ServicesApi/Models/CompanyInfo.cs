// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracity.ApiClients.Identity.ServicesApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class CompanyInfo
    {
        /// <summary>
        /// Initializes a new instance of the CompanyInfo class.
        /// </summary>
        public CompanyInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CompanyInfo class.
        /// </summary>
        public CompanyInfo(int employee, int requests, string name = default(string), string url = default(string), string usersUrl = default(string), IList<string> addressLines = default(IList<string>), string id = default(string), string city = default(string), string country = default(string), string countryCode = default(string), string zipCode = default(string), string domains = default(string), string email = default(string), string internalId = default(string), string vat = default(string))
        {
            Name = name;
            Url = url;
            UsersUrl = usersUrl;
            AddressLines = addressLines;
            Id = id;
            City = city;
            Country = country;
            CountryCode = countryCode;
            ZipCode = zipCode;
            Employee = employee;
            Domains = domains;
            Email = email;
            Requests = requests;
            InternalId = internalId;
            Vat = vat;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "usersUrl")]
        public string UsersUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addressLines")]
        public IList<string> AddressLines { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "zipCode")]
        public string ZipCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "#employee")]
        public int Employee { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "domains")]
        public string Domains { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "#requests")]
        public int Requests { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "internalId")]
        public string InternalId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "vat")]
        public string Vat { get; set; }

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
