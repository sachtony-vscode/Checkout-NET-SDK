// This class was generated on Tue, 04 Sep 2018 12:18:45 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// AmountWithBreakdown.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/+yYX2vkNhTF3/spLn5qwRmnf6Aw0Id0l8K2dDe0oVCSkLkjXcdiZcl7JSVrSr97sTWyPTNpuyl56uhtdG1JR0fn/kj8R3HVd1Ssi4vWBuPhUfkGvmfC99I+mqIsfkNWuNX0FtvhtaIsfqJ+HrwmJ1h1XllTrIurhsBbjxosS2LAxaJowI7voYZt2gB8gx46tg9KkgNJHpV2JbggGkAHflpQeWp365W7ksePU8U1quuUuS+hQSP1+EsZFxiNoBLQSJDKieFlV4KqAU2/ugnn51+LLVfjD3pTQ28DuI6EqnvYxLVXk9hNOerZHYo+BNQONoOwu1HQBjodHGw8ftwvJHFpnCSm8SR0A60yyxl3SfTmUOzVrKQNzsOWAKGzTnn1QGBCuyWOxksSqkUNHZNQTlkzuoFwif0l6jMXus6yJwlxB4SGqf7upmi879y6qiQ9kLYd8arDvkO9EratpBWuUsbTPeNwqZVUTMJXTM5XIjCTEf2ZsJJcdVNEyakc96kwVldFWVwwYx+DeF4WvxDKd0b3xbpG7WgofAiKSU6FSx70eEWuWF8fRvgf0rtdPJpjvKwe53nOqq0X97+a9znK7xzf/xrde1V7eGTsPiHFL+bfz9ZQf2xaUrXn2aJ4bFm66Bi0eCu1ZUColUEj1OAAo3EohllzuyNsUQ9nBcvQYd+S8SDDC2bEeY6qDw6ZJN8Nkd076eGT4+Ne+4aJzkSDjMITw5tf351989WX385GDHNvP39W13wR2agkGa9qRRGG6aVnOeI5HBhigtZ/lv/qygPqsO9Gqhy7MD4p4bFRooFW3TcDk9ax14OOvR5HWsXRhYHRC+IxHbujDSfV6j3B5sfL3zfRBGQCYz34vlMCte6h5pgd1DswVmnVgz0m/KUZT+919fb1Yi8XtlINLS0HhRZ8Y4NDI33jnt6uSif8wfJ4T7wzP5HY1jOHNQpyu4bYS0gJjgiuX6XaqyEIz43NSyTjdpGNv6HChKW9eCyrmQuZC5kLJ8eF6c/hfTAsy5kMmQyZDKdGhvR/zl46FsVMhUyFTIVTpcL0petJPCyfZk5kTmROnBonpo/qe/FYVjMXMhcyF/5nXLj9hHTknsk9k3tm7pnP/gIAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The total order amount with an optional breakdown that provides details, such as the total item amount, total tax amount, shipping, handling, insurance, and discounts, if any.<br/>If you specify `amount.breakdown`, the amount equals `item_total` plus `tax_total` plus `shipping` plus `handling` plus `insurance` minus `shipping_discount`.<br/>The amount must be a positive number with decimal precision and a PayPal-supported <a href="https://developer.paypal.com/docs/integration/direct/rest/currency-codes/">currency</a>.
    /// </summary>
    [DataContract]
    public class AmountWithBreakdown
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public AmountWithBreakdown() {}

        /// <summary>
        /// The breakdown of the amount. Breakdown provides details such as total item amount, total tax amount, shipping, handling, gift wrap, insurance, and discounts, if any.
        /// </summary>
        [DataMember(Name="breakdown", EmitDefaultValue = false)]
        public AmountBreakdown Breakdown;

        /// <summary>
        /// REQUIRED
        /// The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/) that identifies the currency.
        /// </summary>
        [DataMember(Name="currency_code", EmitDefaultValue = false)]
        public string CurrencyCode;

        /// <summary>
        /// REQUIRED
        /// The value, which might be:<ul><li>An integer for currencies like `JPY` that are not typically fractional.</li><li>A decimal fraction for currencies like `TND` that are subdivided into thousandths.</li></ul>For the required number of decimal places for a currency code, see [Currency Codes](/docs/integration/direct/rest/currency-codes/).
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue = false)]
        public string Value;
    }
}

