// This class was generated on Tue, 04 Sep 2018 12:18:45 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// ShippingDetails.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace CheckoutNetsdk.Orders
{
    /// <summary>
    /// The shipping details.
    /// </summary>
    [DataContract]
    public class ShippingDetails
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ShippingDetails() {}

        /// <summary>
        /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue = false)]
        public AddressPortable AddressPortable;

        /// <summary>
        /// The name of the party.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public Name Name;
    }
}

