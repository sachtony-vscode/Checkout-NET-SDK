// This class was generated on Tue, 04 Sep 2018 11:48:14 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// Customer.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace CheckoutNetsdk.Orders
{
    /// <summary>
    /// The customer who approves and pays for the order. The customer is also known as the payer.
    /// </summary>
    [DataContract]
    public class Customer
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Customer() {}

        /// <summary>
        /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue = false)]
        public PortablePostalAddress(MediumGrained) Address;

        /// <summary>
        /// The stand-alone date, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). To represent special legal values, such as a date of birth, you should use dates with no associated time or time-zone data. Whenever possible, use the standard `date_time` type. This regular expression does not validate all dates. For example, February 31 is valid and nothing is known about leap years.
        /// </summary>
        [DataMember(Name="birth_date", EmitDefaultValue = false)]
        public string BirthDate;

        /// <summary>
        /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
        /// </summary>
        [DataMember(Name="email_address", EmitDefaultValue = false)]
        public string EmailAddress;

        /// <summary>
        /// The externally-provided ID of the customer.
        /// </summary>
        [DataMember(Name="external_id", EmitDefaultValue = false)]
        public string ExternalId;

        /// <summary>
        /// The name of the party.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public Name Name;

        /// <summary>
        /// The PayPal payer ID, which is a masked version of the PayPal account number intended for use with third parties. The account number is reversibly encrypted and a proprietary variant of Base32 is used to encode the result.
        /// </summary>
        [DataMember(Name="payer_id", EmitDefaultValue = false)]
        public string PayerId;

        /// <summary>
        /// The phone information.
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue = false)]
        public Phone Phone;

        /// <summary>
        /// The tax ID of the customer. The customer is also known as the payer. Both `tax_id` and `tax_id_type` are required.
        /// </summary>
        [DataMember(Name="tax_info", EmitDefaultValue = false)]
        public TaxInformation TaxInfo;
    }
}

