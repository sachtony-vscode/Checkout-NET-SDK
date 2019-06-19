// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// ExchangeRate.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/+STQWvVQBDH736KYU8KeY0VRXg3QQURrGjxUkoZd/8vO5Dsvs5Ongbpd5e8NHmUFLz05jHzn8zu78fOH3c57OG2Dr995NTgRtngKveDVfhniy/cPRZ/xnCfuMq9R/Eqe5Oc3NZdRtDcTmM7WWSjAIN2klDIIoi73Ccjy+RzOkCNdpo7ygnke1UkP4whp2wRutTOXOXeqfIwXftl5b6Bw0VqB7fdcVswFm57UYSl8FXzHmqC4rZXC3AxldSsSUvu1eNmPvAB6zpbo19ZVGDjIyt7g9Kn7xeb16/O3564fA64fl6H7EstydAojwPqIApvtaJYPTdvxuZSv5gkSkAy2cm9xKeykvq2vav+qcZYG9jjatbZf6XmwG3/cC/mylrDpOrEPK3CGX247eXALaa1GDehT2KUd0eg6e2duOhj1o7NEIgLHV1BKSsFeOm4peMF6JdYPM6yTOdvKEgjVsaPcaZKE5cD5v/2WZI9ibbru2d/AQAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The exchange rate that determines the amount to convert from one currency to another currency.
    /// </summary>
    [DataContract]
    public class ExchangeRate
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ExchangeRate() {}

        /// <summary>
        /// The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/) that identifies the currency.
        /// </summary>
        [DataMember(Name="source_currency", EmitDefaultValue = false)]
        public string SourceCurrency;

        /// <summary>
        /// The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/) that identifies the currency.
        /// </summary>
        [DataMember(Name="target_currency", EmitDefaultValue = false)]
        public string TargetCurrency;

        /// <summary>
        /// The target currency amount. Equivalent to one unit of the source currency. Formatted as integer or decimal value with one to 15 digits to the right of the decimal point.
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue = false)]
        public string Value;
    }
}

