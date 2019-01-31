// This class was generated on Tue, 04 Sep 2018 12:18:45 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// PaymentCollection.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The collection of payments, or transactions, for a purchase unit in an order. For example, authorized payments, captured payments, and refunds.
    /// </summary>
    [DataContract]
    public class PaymentCollection
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentCollection() {}

        /// <summary>
        /// An array of authorized payments for a purchase unit. A purchase unit can have zero or more authorized payments.
        /// </summary>
        [DataMember(Name="authorizations", EmitDefaultValue = false)]
        public List<Authorization> Authorizations;

        /// <summary>
        /// An array of captured payments for a purchase unit. A purchase unit can have zero or more captured payments.
        /// </summary>
        [DataMember(Name="captures", EmitDefaultValue = false)]
        public List<Capture> Captures;

        /// <summary>
        /// An array of refunds for a purchase unit. A purchase unit can have zero or more refunds.
        /// </summary>
        [DataMember(Name="refunds", EmitDefaultValue = false)]
        public List<Refund> Refunds;
    }
}

