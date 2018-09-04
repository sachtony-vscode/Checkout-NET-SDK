// This class was generated on Tue, 04 Sep 2018 11:48:14 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// PurchaseUnitRequest.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace CheckoutNetsdk.Orders
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

