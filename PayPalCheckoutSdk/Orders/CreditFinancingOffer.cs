// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// CreditFinancingOffer.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/+xVXWvsRgx9768QfmrBG6cfUNi3kFBIS5PQhkJJw0Y7I6+HjGdcjZxgLvnvl/HXZteb3IS79yXsk7Gk0eicOZI+JddNRck8UUzayCI3Dp0ybrXweU6cpMk/yAaXli6wfDXuD2r6kCRNzigoNpUY75J5cl0QaBI0NgAufS0gBUGFDfEskCUlpKFLDGNiaBMfJWlywoxNV+ZxmvxFqC+dbZJ5jjZQNPxfGyY9Gq7YV8RiKCTzmxHguQuC1pbkBM66YqbozDpoocegNbTd/inaDhtWFfsH0vDsWHR1X4tuYGV/KP/0jpoprv7Sha5pA8+mfYpD1czkVAPoNGDpayeQewYc3gktCKMLqOKpFEKtCsAACEu06BSB5xGyrml/SIOwcasdAu1LXiivN8Fue6Zwb6RgopkqkFEJMZz/fTn75acff10TEc/efp9pr0JmnNCKMSbItGFSkjEFyYbgWQwO2Q8gBQoYTU5Mbii08h+C3sWIcL1FiKutfUq/yMoD2q2nHyxTFlpPCo+FUQWUZlUILGn+X318/LOqbful7s+a7u/EQcsFcauOHlpEas09wd3vV//edSQgEzgvIE1lFFrbQM6ddtAedUmzIevWHaBJmRLteGL3XdcXZ8/uCvVSmwej2yYUD1L4OqDTUoTd12UDwt88t+/EPfng6nJJDD4fC6ksKgp9Q2woJIVABDeng+00CuG9stmHMm7foI2K2Hi9ORcG01QdeSSkBfVopOhVMs5zKGLzr5hIg3go8Z4GZxwBX9v+b8ZkQqi31tJommLqXPFp2878Jptoq1H7fplWLsTlRt294aUlMy7Qdb3xRArGQeldFPp+K39hxYgXtIsIK4p5E8G267BoDovmsGg+7KJ5dUL0PbpjQKw9h/lwmA+H+fDB5sPt03efAQAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The details about the payer-selected credit financing offer.
    /// </summary>
    [DataContract]
    public class CreditFinancingOffer
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CreditFinancingOffer() {}

        /// <summary>
        /// The payer-approved installment payment plan details.
        /// </summary>
        [DataMember(Name="installment_details", EmitDefaultValue = false)]
        public InstallmentDetails InstallmentDetails;

        /// <summary>
        /// The issuer of the credit financing offer.
        /// </summary>
        [DataMember(Name="issuer", EmitDefaultValue = false)]
        public string Issuer;

        /// <summary>
        /// The payer-selected financing term, in months.
        /// </summary>
        [DataMember(Name="term", EmitDefaultValue = false)]
        public int? Term;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="total_interest", EmitDefaultValue = false)]
        public Money TotalInterest;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="total_payment", EmitDefaultValue = false)]
        public Money TotalPayment;
    }
}

