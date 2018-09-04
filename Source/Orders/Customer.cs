// This class was generated on Tue, 04 Sep 2018 12:18:45 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
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
        public AddressPortable AddressPortable;

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

