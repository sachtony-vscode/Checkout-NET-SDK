// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// ProductExperience.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/7yUQasUMQzH736K0PMgnvcm6EnQQRYvIkteJ/Na7KQ1zaBF3neXdvbt7DAuHnzssWma/H//pv1tjiWROZhe4jBbhfe/EokntmQ68wXF40OgjzjVHNOZD1TWxTvKVnxSH9kczNERpHMVulTJoA4VEOZMAjZOKZBShsiA0GPpMYAKckZb67w2nXkrgmWR9aYznwmHTxyKOYwYMtXAj9kLDZdALzGRqKdsDl8vQFnF8+MewjpkprBhWWN/QcIyESuMIf6EcyJoSfS/UnkO4an7p15ilXJK0bNuNG/jt3VPpC4OZ/tdzAQaISuKgl6lJYmWcr4T1LnraRG34dptbdH6HdZQgZ4HqzFdzxMcnc9gkSHHidRPlOGBYPDjSFILqUNup5qh0AwFPz4bhvxYOzjyApPnAYa5IrUT1pH9HudlNu7l3PLCTrXl1rftxu232Qb5jgNcjTytH8Je+Y2EPUG7kjVxIRmjtMt4+b+k8X17evUHAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The product experiences that a user completes on a PayPal transaction.
    /// </summary>
    [DataContract]
    public class ProductExperience
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ProductExperience() {}

        /// <summary>
        /// The payment flow channel type.
        /// </summary>
        [DataMember(Name="channel", EmitDefaultValue = false)]
        public string Channel;

        /// <summary>
        /// The payment method user chose to start the payment process.
        /// </summary>
        [DataMember(Name="entry_point", EmitDefaultValue = false)]
        public string EntryPoint;

        /// <summary>
        /// Payment method used to complete the transaction. This can sometimes be different than the entry point if user changed their mind during the checkout flow.
        /// </summary>
        [DataMember(Name="payment_method", EmitDefaultValue = false)]
        public string PaymentMethod;

        /// <summary>
        /// The product flow type.
        /// </summary>
        [DataMember(Name="product_flow", EmitDefaultValue = false)]
        public string ProductFlow;

        /// <summary>
        /// The user experience flow for the PayPal transaction.
        /// </summary>
        [DataMember(Name="user_experience_flow", EmitDefaultValue = false)]
        public string UserExperienceFlow;
    }
}

