// This class was generated on Tue, 04 Sep 2018 12:18:45 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// PurchaseUnitRequest.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The purchase unit request. Includes required information for the payment contract.
    /// </summary>
    [DataContract]
    public class PurchaseUnitRequest
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PurchaseUnitRequest() {}

        /// <summary>
        /// REQUIRED
        /// The total order amount with an optional breakdown that provides details, such as the total item amount, total tax amount, shipping, handling, insurance, and discounts, if any.<br/>If you specify `amount.breakdown`, the amount equals `item_total` plus `tax_total` plus `shipping` plus `handling` plus `insurance` minus `shipping_discount`.<br/>The amount must be a positive number with decimal precision and a PayPal-supported <a href="https://developer.paypal.com/docs/integration/direct/rest/currency-codes/">currency</a>.
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public AmountWithBreakdown Amount;

        /// <summary>
        /// The API caller-provided external ID. Used to reconcile client transactions with PayPal transactions. Appears in transaction and settlement reports but is not visible to the payer.
        /// </summary>
        [DataMember(Name="custom_id", EmitDefaultValue = false)]
        public string CustomId;

        /// <summary>
        /// The purchase description.
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue = false)]
        public string Description;

        /// <summary>
        /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
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
        /// The ID for the purchase unit. Required for multiple `purchase_units` or if an order must be updated by using `PATCH`.
        /// </summary>
        [DataMember(Name="reference_id", EmitDefaultValue = false)]
        public string ReferenceId;

        /// <summary>
        /// The shipping details.
        /// </summary>
        [DataMember(Name="shipping", EmitDefaultValue = false)]
        public ShippingDetails Shipping;

        /// <summary>
        /// The payment descriptor on the payer's credit card statement.
        /// </summary>
        [DataMember(Name="soft_descriptor", EmitDefaultValue = false)]
        public string SoftDescriptor;
    }
}

