// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DNV.ApiClients.Veracity.Identity.ServicesApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for 63f76edff2522e18c8d3b055 operation.
    /// </summary>
    public partial class SixThreefSevenSixedffTwoFiveTwoTwoeOneEightcEightdThreebZeroFiveFiveHyphenMinusHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SixThreefSevenSixedffTwoFiveTwoTwoeOneEightcEightdThreebZeroFiveFiveHyphenMinusHeaders
        /// class.
        /// </summary>
        public SixThreefSevenSixedffTwoFiveTwoTwoeOneEightcEightdThreebZeroFiveFiveHyphenMinusHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SixThreefSevenSixedffTwoFiveTwoTwoeOneEightcEightdThreebZeroFiveFiveHyphenMinusHeaders
        /// class.
        /// </summary>
        /// <param name="xSupportCode">correlation token for log
        /// lookup.</param>
        public SixThreefSevenSixedffTwoFiveTwoTwoeOneEightcEightdThreebZeroFiveFiveHyphenMinusHeaders(string xSupportCode = default(string))
        {
            XSupportCode = xSupportCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets correlation token for log lookup.
        /// </summary>
        [JsonProperty(PropertyName = "x-supportCode")]
        public string XSupportCode { get; set; }

    }
}