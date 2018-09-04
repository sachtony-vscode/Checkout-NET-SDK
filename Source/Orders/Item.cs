// This class was generated on Tue, 04 Sep 2018 12:18:45 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// Item.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/+yXTU/8NhDG7/0Uo1z6Rwob+iJV2hsCVaKUF8FSqaIIZu3ZjbWOHewxNKr47pXzsiSEFYKiVQ+cohlP7N/MPn6U/SeZVSUl0+SIqUjS5A90CueaTrGI2SRNjql6Dg7JC6dKVtYk02SWE0hiVNrDwjrgnEAxFR7YwpygDE7k6ElOkjTZdw6r5rC9NLkglGdGV8l0gdpTTNwH5UiuE+fOluRYkU+m12tMz06Z5RhUINPSumoA3EuOwSModBXAVUn/ldIErZ/SN1FlD6VPO8xvmjTJhrxXvSVuEx994DaxYbRxFaIoFOv3jZZd+BjhfUDDioci6CU3kHYVEzgJnqNwER5zqwlMKObktgPvV2HA3cRjZM9WrGBFVCqzhGAUw7fL46udwQ38ZEmcWEPVGJnx7wFyE4+RRXCOjKgAjQQsbDBc0yIslEEjFGpgh8ajiG+l4IPIAT0gzFGjEbWQSqwKMgwy0Bb8pEW+FVYOVf9yZdzuNeeOaFfk6FAwOTi6PNv9+ccffnkeRHz35lsmrfCZMkxLh3GDTCpHgjNHnrOueDcW+2wHOEcGJcmwWijy9Y/dFW1How+ow3AaXWY8hXolhcdciRwKtczjzZr+Ffb2fhJB109qIq2aaN9APQtytTra1mKnWq0I7n47//OuGQI6AmM5urYSqHUFC9doB/Wk2TTrdn1xBkgSqkC9fuP1s2anh72zfJhL9aBkNF/DFji3waORnPvXj8u6Dn9tL6Vrh99aCtjFGqTUKMi3F2KgkBQ8EVwfdLmDKIT3yuYzlHHzthdEI7pt7vZAIMP8/80bxv1+WcOXNXxZw8esYZM2gtNDT6jjsS6uLn6P/xzqjzJlFtYVdQ8TmOXK16tYloTOgzKtxD3bgtz3vu8RkCvP1lWf8hF08/TdvwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace CheckoutNetsdk.Orders
{
    /// <summary>
    /// The details for the items to be purchased.
    /// </summary>
    [DataContract]
    public class Item
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Item() {}

        /// <summary>
        /// The item category type.
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue = false)]
        public string Category;

        /// <summary>
        /// The detailed item description.
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue = false)]
        public string Description;

        /// <summary>
        /// REQUIRED
        /// The item name or title.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public string Name;

        /// <summary>
        /// REQUIRED
        /// The item quantity. Must be a whole number.
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue = false)]
        public string Quantity;

        /// <summary>
        /// The stock keeping unit (SKU) for the item.
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue = false)]
        public string Sku;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="tax", EmitDefaultValue = false)]
        public Money Tax;

        /// <summary>
        /// REQUIRED
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="unit_amount", EmitDefaultValue = false)]
        public Money UnitAmount;

        /// <summary>
        /// The URL to item information. This URL appears in the customer's transaction history.
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue = false)]
        public string Url;
    }
}

