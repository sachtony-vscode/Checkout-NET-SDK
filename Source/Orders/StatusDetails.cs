// This class was generated on Tue, 04 Sep 2018 11:48:14 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// StatusDetails.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/6yPwUoDMRCG7z7FMOdFPO+tkCpFWYsWLyJkNLMmEJN1JkGC9N2lXViVXnv8v5+Z+eYbd21i7PGxUKkKhguFqNjhE0mg18gDfRx67PCW228wrG8SphJywh53nsHNo5BHKJ5BeKzJgR73XmKHKxFq87WrDh+Y3H2KDfuRovIBfNYg7BawlTyxlMCK/fPiqUVCej/1EybN6Z/lgk5d5wq+fPvr6kmP0W7Xg9kMNxaygL1ebe7Wxp7pk1Rj3L/sL34AAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace CheckoutNetsdk.Orders
{
    /// <summary>
    /// The details of the refund status.
    /// </summary>
    [DataContract]
    public class StatusDetails
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public StatusDetails() {}

        /// <summary>
        /// The reason why the refund has the `PENDING` or `FAILED` status.
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue = false)]
        public string Reason;
    }
}

