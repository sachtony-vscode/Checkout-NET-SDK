// This class was generated on Tue, 04 Sep 2018 12:18:45 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// PurchaseUnit.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace CheckoutNetsdk.Orders
{
    /// <summary>
    /// The purchase unit details. Used to capture required information for the payment contract.
    /// </summary>
    [DataContract]
    public class PurchaseUnit
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PurchaseUnit() {}

        /// <summary>
        /// The total order amount with an optional breakdown that provides details, such as the total item amount, total tax amount, shipping, handling, insurance, and discounts, if any.<br/>If you specify `amount.breakdown`, the amount equals `item_total` plus `tax_total` plus `shipping` plus `handling` plus `insurance` minus `shipping_discount`.<br/>The amount must be a positive number with decimal precision and a PayPal-supported <a href="https://developer.paypal.com/docs/integration/direct/rest/currency-codes/">currency</a>.
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public AmountWithBreakdown Amount;

        /// <summary>
        /// The API caller-provided external ID. Used to reconcile API caller-initiated transactions with PayPal transactions. Appears in transaction and settlement reports.
        /// </summary>
        [DataMember(Name="custom_id", EmitDefaultValue = false)]
        public string CustomId;

        /// <summary>
        /// The purchase description.
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue = false)]
        public string Description;

        /// <summary>
        /// The API caller-provided external invoice ID for this order..
        /// </summary>
        [DataMember(Name="invoice_id", EmitDefaultValue = false)]
        public string InvoiceId;

        /// <summary>
        /// An array of items that the customer is purchasing from the merchant.
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue = false)]
        public List<Item> Items;

        /// <summary>
        /// The merchant who receives the funds and fulfills the order. The merchant is also known as the payee.
        /// </summary>
        [DataMember(Name="payee", EmitDefaultValue = false)]
        public Payee Payee;

        /// <summary>
        /// Any additional payment instructions for PayPal for Partner customers. Enables features for partners and marketplaces, such as delayed disbursement and collection of a platform fee. Applies during order creation for captured payments or during capture of authorized payments.
        /// </summary>
        [DataMember(Name="payment_instruction", EmitDefaultValue = false)]
        public PaymentInstruction PaymentInstruction;

        /// <summary>
        /// The collection of payments, or transactions, for a purchase unit in an order. For example, authorized payments, captured payments, and refunds.
        /// </summary>
        [DataMember(Name="payments", EmitDefaultValue = false)]
        public PaymentCollection Payments;

        /// <summary>
        /// The API caller-provided external ID for the purchase unit. Required for multiple purchase units when you must update the order through `PATCH`.
        /// </summary>
        [DataMember(Name="reference_id", EmitDefaultValue = false)]
        public string ReferenceId;

        /// <summary>
        /// The shipping details.
        /// </summary>
        [DataMember(Name="shipping", EmitDefaultValue = false)]
        public ShippingDetails Shipping;

        /// <summary>
        /// The payment descriptor on the customer's credit card statement of account transactions.
        /// </summary>
        [DataMember(Name="soft_descriptor", EmitDefaultValue = false)]
        public string SoftDescriptor;
    }
}

