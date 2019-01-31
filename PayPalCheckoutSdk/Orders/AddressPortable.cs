// This class was generated on Tue, 04 Sep 2018 12:18:45 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// AddressPortable.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
    /// </summary>
    [DataContract]
    public class AddressPortable
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public AddressPortable() {}

        /// <summary>
        /// The non-portable additional address details that are sometimes needed for compliance, risk, or other scenarios where fine-grain address information might be needed. Not portable with common third party and openPayPalCheckoutSdk. Redundant with core fields. For example, `address_portable.address_line_1` is usually a combination of `address_details.street_number` and `street_name` and `street_type`.
        /// </summary>
        [DataMember(Name="address_details", EmitDefaultValue = false)]
        public AddressDetails AddressDetails;

        /// <summary>
        /// The first line of the address. For example, number or street. For example, `173 Drury Lane`. Required for data entry and compliance and risk checks. Must contain the full address.
        /// </summary>
        [DataMember(Name="address_line_1", EmitDefaultValue = false)]
        public string AddressLine1;

        /// <summary>
        /// The second line of the address. For example, suite or apartment number.
        /// </summary>
        [DataMember(Name="address_line_2", EmitDefaultValue = false)]
        public string AddressLine2;

        /// <summary>
        /// The third line of the address, if needed. For example, a street complement for Brazil, direction text, such as `next to Walmart`, or a landmark in an Indian address.
        /// </summary>
        [DataMember(Name="address_line_3", EmitDefaultValue = false)]
        public string AddressLine3;

        /// <summary>
        /// The highest level sub-division in a country, which is usually a province, state, or ISO-3166-2 subdivision. Format for postal delivery. For example, `CA` and not `California`. Value, by country, is:<ul><li>UK. A county.</li><li>US. A state.</li><li>Canada. A province.</li><li>Japan. A prefecture.</li><li>Switzerland. A kanton.</li></ul>
        /// </summary>
        [DataMember(Name="admin_area_1", EmitDefaultValue = false)]
        public string AdminArea1;

        /// <summary>
        /// A city, town, or village. Smaller than `admin_area_level_1`.
        /// </summary>
        [DataMember(Name="admin_area_2", EmitDefaultValue = false)]
        public string AdminArea2;

        /// <summary>
        /// A sub-locality, suburb, neighborhood, or district. Smaller than `admin_area_level_2`. Value is:<ul><li>Brazil. Suburb, bairro, or neighborhood.</li><li>India. Sub-locality or district. Street name information is not always available but a sub-locality or district can be a very small area.</li></ul>
        /// </summary>
        [DataMember(Name="admin_area_3", EmitDefaultValue = false)]
        public string AdminArea3;

        /// <summary>
        /// The neighborhood, ward, or district. Smaller than `admin_area_level_3` or `sub_locality`. Value is:<ul><li>The postal sorting code that is used in Guernsey and many French territories, such as French Guiana.</li><li>The fine-grained administrative levels in China.</li></ul>
        /// </summary>
        [DataMember(Name="admin_area_4", EmitDefaultValue = false)]
        public string AdminArea4;

        /// <summary>
        /// REQUIRED
        /// The [two-character ISO 3166-1 code](/docs/integration/direct/rest/country-codes/) that identifies the country or region.<blockquote><strong>Note:</strong> The country code for Great Britain is <code>GB</code> and not <code>UK</code> as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.</blockquote>
        /// </summary>
        [DataMember(Name="country_code", EmitDefaultValue = false)]
        public string CountryCode;

        /// <summary>
        /// The postal code, which is the zip code or equivalent. Typically required for countries with a postal code or an equivalent. See [postal code](https://en.wikipedia.org/wiki/Postal_code).
        /// </summary>
        [DataMember(Name="postal_code", EmitDefaultValue = false)]
        public string PostalCode;
    }
}

