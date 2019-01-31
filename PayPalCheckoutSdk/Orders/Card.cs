// This class was generated on Tue, 04 Sep 2018 12:18:45 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// Card.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The payment card to use to fund a payment. Can be a credit or debit card.
    /// </summary>
    [DataContract]
    public class Card
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Card() {}

        /// <summary>
        /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
        /// </summary>
        [DataMember(Name="billing_address", EmitDefaultValue = false)]
        public AddressPortable AddressPortable;

        /// <summary>
        /// The card network or brand. Applies to credit, debit, gift, and payment cards.
        /// </summary>
        [DataMember(Name="card_type", EmitDefaultValue = false)]
        public string CardType;

        /// <summary>
        /// REQUIRED
        /// The year and month, in ISO-8601 `YYYY-MM` date format. See [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="expiry", EmitDefaultValue = false)]
        public string Expiry;

        /// <summary>
        /// The PayPal-generated ID for the card.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id;

        /// <summary>
        /// The last digits of the payment card.
        /// </summary>
        [DataMember(Name="last_digits", EmitDefaultValue = false)]
        public string LastDigits;

        /// <summary>
        /// The card holder's name as it appears on the card.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public string Name;

        /// <summary>
        /// REQUIRED
        /// The primary account number (PAN) for the payment card.
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue = false)]
        public string Number;

        /// <summary>
        /// The three- or four-digit security code of the card. Also known as the CVV, CVC, CVN, CVE, or CID.
        /// </summary>
        [DataMember(Name="security_code", EmitDefaultValue = false)]
        public string SecurityCode;
    }
}

