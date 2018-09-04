// This class was generated on Tue, 04 Sep 2018 12:18:45 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// AmountBreakdown.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/+yYT2vbTBDG7++nGHR6C0qU/oGCb2lCoS1NQhsKJQ3JeHdkLVntqrOjJKLkuxdJliPZLiWQU72nZJ/dmZ15PPph+Vdy3lSUzJLD0tdO4B0T3mh/55I0+YZscG7pBMv2RJImn6h5XBxTUGwqMd4ls+S8IJgPweBzkIIAu6T7j1mhYn9rNAXQJGhsgFCrAjCAeEELRqhcRqVLSfB+pYTCVJVxixQKdNp2/y1MLnDHWKVgXKgZnaIU0GnQJqg2LqRgckDX7CdpcsiMTd/zQZp8IdSnzjbJLEcbqBV+1oZJr4Qz9hWxGArJ7GLl1mfvqNm0aKhqYtVI3LRM1czkVNMV3LcJuWdAyI1Dp0zrAKMLqNqodOUXwhxt2yt4hgqbkpyArun5egzCfdVrTQ4lXymvadLp+s5muxdSMNGeKpBRCTF8+Hq69+bVy7ePRrSxl/9n2quQGSe0YGwTZNowKcmYgmTD4b32cMhegBQoYDQ5Mbmh0A3fcOhJjgjXa4a42tqH9K+u3KKtp24MyqYL3U4Kd4VRBZRmUQjMafajPjh4rWrb/aV+ZU2/OnTQeUHcTceytbZTa24Irj+efb/uTUAmcF5AmsootLaBnPvZQbvfJ82GrGt3gCZlSrSriO13nZ8cj+4K9Vyb9pHWbYUepPB1QKelCNuvy4YO33vuPidemg+uLufELTuGQiqLisLygZhMSAqBCC6OBu2oHYSnjs1zTMblaDb+QIUVlibjMVYjFyIXIhd2jgtC5VX3JWcKhrEcyRDJEMmwa2QY3nMm0zESIxUiFSIVdpUKV8MPG1vxMN6NnIiciJzYNU4I3m95rRirkQuRC5EL/xgXLh/++w0AAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace CheckoutNetsdk.Orders
{
    /// <summary>
    /// The breakdown of the amount. Breakdown provides details such as total item amount, total tax amount, shipping, handling, gift wrap, insurance, and discounts, if any.
    /// </summary>
    [DataContract]
    public class AmountBreakdown
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public AmountBreakdown() {}

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="handling", EmitDefaultValue = false)]
        public Money Handling;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="insurance", EmitDefaultValue = false)]
        public Money Insurance;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="item_total", EmitDefaultValue = false)]
        public Money ItemTotal;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="shipping", EmitDefaultValue = false)]
        public Money Shipping;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="shipping_discount", EmitDefaultValue = false)]
        public Money ShippingDiscount;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="tax_total", EmitDefaultValue = false)]
        public Money TaxTotal;
    }
}

