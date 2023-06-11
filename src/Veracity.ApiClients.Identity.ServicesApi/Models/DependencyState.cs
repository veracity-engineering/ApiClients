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

    public partial class DependencyState
    {
        /// <summary>
        /// Initializes a new instance of the DependencyState class.
        /// </summary>
        public DependencyState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DependencyState class.
        /// </summary>
        /// <param name="status">status (optional) has the exact same meaning
        /// as the top-level
        /// "output" element, but for the sub-component/downstream dependency
        /// represented by the details object. Possible values include: 'pass',
        /// 'warn', 'fail'</param>
        /// <param name="weight">A numeric value (1,2 or 3) to represent the
        /// weighting of the dependency in the overall sla calculation</param>
        /// <param name="componentId">componentId: (optional) is a unique
        /// identifier of an instance of a
        /// specific sub-component/dependency of a service.Multiple objects
        /// with the same componentID MAY appear in the details, if they are
        /// from
        /// different nodes. Use well know references to 1st party veracity
        /// components like "v3" if you are probing the V3 connection.</param>
        /// <param name="componentType"> componentType: (optional) SHOULD be
        /// present if componentName is
        /// present.It's a type of the component and could be one of:
        ///
        /// o Pre-defined value from this spec.Pre-defined values include:
        ///
        /// *  component
        ///
        /// * datastore
        ///
        /// *  system
        ///
        /// o  A common and standard term from a well-known source such as
        ///
        /// schema.org, IANA or microformats.
        ///
        /// o A URI that indicates extra semantics and processing rules that
        /// MAY
        ///
        /// be provided by a resource at the other end of the URI.  URIs do
        ///
        /// not have to be dereferenceable, however.They are just a
        /// namespace, and the meaning of a namespace CAN be provided by any
        /// convenient means(e.g.publishing an RFC, Swagger document or a
        /// nicely printed book).</param>
        /// <param name="observedValue">observedValue: (optional) could be any
        /// valid JSON value, such as:
        /// string, number, object, array or literal.</param>
        /// <param name="observedUnit">observedUnit (optional) SHOULD be
        /// present if observedValue is
        /// present.Clarifies the unit of measurement in which observedUnit is
        /// reported, e.g. for a time-based value it is important to know
        /// whether
        /// the time is reported in seconds, minutes, hours or something else.
        /// To make sure unit is denoted by a well-understood name or an
        /// abbreviation, it SHOULD be one of:
        ///
        /// - A common and standard term from a well-known source such as
        /// schema.org, IANA, microformats, or a standards document such as
        /// [RFC3339].
        ///
        /// - A URI that indicates extra semantics and processing rules that
        /// MAY
        /// be provided by a resource at the other end of the URI.URIs do
        /// not have to be dereferenceable, however.They are just a
        /// namespace, and the meaning of a namespace CAN be provided by any
        /// convenient means(e.g.publishing an RFC, Swagger document or a
        /// nicely printed book).</param>
        /// <param name="affectedEndpoints">affectedEndpoints (optional) is a
        /// JSON array containing URI Templates
        /// as defined by[RFC6570].  This field SHOULD be omitted if the
        /// "status" field is present and has value equal to "pass".  A typical
        /// API has many URI endpoints.Most of the time we are interested in
        /// the overall health of the API, without diving into details.That
        /// said, sometimes operational and resilience middleware needs to know
        /// more details about the health of the API(which is why "checks"
        /// property provides details).  In such cases, we often need to
        /// indicate
        /// which particular endpoints are affected by a particular check's
        /// troubles vs.other endpoints that may be fine.</param>
        /// <param name="time">time (optional) is the date-time, in ISO8601
        /// format, at which the
        /// reading of the observedValue was recorded.This assumes that the
        /// value can be cached and the reading typically doesn't happen in
        /// real
        ///
        /// time, for performance and scalability purposes.</param>
        /// <param name="output">output (optional) has the exact same meaning
        /// as the top-level
        /// "output" element, but for the sub-component/downstream dependency
        /// represented by the details object.  As is the case for the
        /// top-level
        /// element, this field SHOULD be omitted for "pass" state of a
        /// downstream dependency.</param>
        public DependencyState(HealthStateTypes status, int weight, bool critical, string componentId = default(string), string componentType = default(string), object observedValue = default(object), string observedUnit = default(string), IList<string> affectedEndpoints = default(IList<string>), System.DateTime? time = default(System.DateTime?), string output = default(string))
        {
            ComponentId = componentId;
            ComponentType = componentType;
            ObservedValue = observedValue;
            ObservedUnit = observedUnit;
            Status = status;
            AffectedEndpoints = affectedEndpoints;
            Time = time;
            Output = output;
            Weight = weight;
            Critical = critical;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets componentId: (optional) is a unique identifier of an
        /// instance of a
        /// specific sub-component/dependency of a service.Multiple objects
        /// with the same componentID MAY appear in the details, if they are
        /// from
        /// different nodes. Use well know references to 1st party veracity
        /// components like "v3" if you are probing the V3 connection.
        /// </summary>
        [JsonProperty(PropertyName = "componentId")]
        public string ComponentId { get; set; }

        /// <summary>
        /// Gets or sets  componentType: (optional) SHOULD be present if
        /// componentName is
        /// present.It's a type of the component and could be one of:
        ///
        /// o Pre-defined value from this spec.Pre-defined values include:
        ///
        /// *  component
        ///
        /// * datastore
        ///
        /// *  system
        ///
        /// o  A common and standard term from a well-known source such as
        ///
        /// schema.org, IANA or microformats.
        ///
        /// o A URI that indicates extra semantics and processing rules that
        /// MAY
        ///
        /// be provided by a resource at the other end of the URI.  URIs do
        ///
        /// not have to be dereferenceable, however.They are just a
        /// namespace, and the meaning of a namespace CAN be provided by any
        /// convenient means(e.g.publishing an RFC, Swagger document or a
        /// nicely printed book).
        /// </summary>
        [JsonProperty(PropertyName = "componentType")]
        public string ComponentType { get; set; }

        /// <summary>
        /// Gets or sets observedValue: (optional) could be any valid JSON
        /// value, such as:
        /// string, number, object, array or literal.
        /// </summary>
        [JsonProperty(PropertyName = "observedValue")]
        public object ObservedValue { get; set; }

        /// <summary>
        /// Gets or sets observedUnit (optional) SHOULD be present if
        /// observedValue is
        /// present.Clarifies the unit of measurement in which observedUnit is
        /// reported, e.g. for a time-based value it is important to know
        /// whether
        /// the time is reported in seconds, minutes, hours or something else.
        /// To make sure unit is denoted by a well-understood name or an
        /// abbreviation, it SHOULD be one of:
        ///
        /// - A common and standard term from a well-known source such as
        /// schema.org, IANA, microformats, or a standards document such as
        /// [RFC3339].
        ///
        /// - A URI that indicates extra semantics and processing rules that
        /// MAY
        /// be provided by a resource at the other end of the URI.URIs do
        /// not have to be dereferenceable, however.They are just a
        /// namespace, and the meaning of a namespace CAN be provided by any
        /// convenient means(e.g.publishing an RFC, Swagger document or a
        /// nicely printed book).
        /// </summary>
        [JsonProperty(PropertyName = "observedUnit")]
        public string ObservedUnit { get; set; }

        /// <summary>
        /// Gets or sets status (optional) has the exact same meaning as the
        /// top-level
        /// "output" element, but for the sub-component/downstream dependency
        /// represented by the details object. Possible values include: 'pass',
        /// 'warn', 'fail'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public HealthStateTypes Status { get; set; }

        /// <summary>
        /// Gets or sets affectedEndpoints (optional) is a JSON array
        /// containing URI Templates
        /// as defined by[RFC6570].  This field SHOULD be omitted if the
        /// "status" field is present and has value equal to "pass".  A typical
        /// API has many URI endpoints.Most of the time we are interested in
        /// the overall health of the API, without diving into details.That
        /// said, sometimes operational and resilience middleware needs to know
        /// more details about the health of the API(which is why "checks"
        /// property provides details).  In such cases, we often need to
        /// indicate
        /// which particular endpoints are affected by a particular check's
        /// troubles vs.other endpoints that may be fine.
        /// </summary>
        [JsonProperty(PropertyName = "affectedEndpoints")]
        public IList<string> AffectedEndpoints { get; set; }

        /// <summary>
        /// Gets or sets time (optional) is the date-time, in ISO8601 format,
        /// at which the
        /// reading of the observedValue was recorded.This assumes that the
        /// value can be cached and the reading typically doesn't happen in
        /// real
        ///
        /// time, for performance and scalability purposes.
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public System.DateTime? Time { get; set; }

        /// <summary>
        /// Gets or sets output (optional) has the exact same meaning as the
        /// top-level
        /// "output" element, but for the sub-component/downstream dependency
        /// represented by the details object.  As is the case for the
        /// top-level
        /// element, this field SHOULD be omitted for "pass" state of a
        /// downstream dependency.
        /// </summary>
        [JsonProperty(PropertyName = "output")]
        public string Output { get; set; }

        /// <summary>
        /// Gets or sets a numeric value (1,2 or 3) to represent the weighting
        /// of the dependency in the overall sla calculation
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public int Weight { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "critical")]
        public bool Critical { get; set; }

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
