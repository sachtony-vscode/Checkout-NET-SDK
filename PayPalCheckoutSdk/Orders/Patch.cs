// This class was generated on Tue, 04 Sep 2018 12:18:45 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// Patch.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/7STwWrjMBCG7/sUg84m7Nm3hT3tQhLa0EspZCJPYhXZo47GKabk3YuUxME1pbRpj/o1Y38fM3oxqz6QKc0S1damMHcoDjee5tik2BTmP/WXw1+KVlxQx60pzaom+He7mENI3cCbR7IKyoAh+B4Cijr00IUKlWK6EIrciaU4M4X5I4L98f+/C3NDWC1a35tyiz5SCp46J1QNwVI4kKijaMr7gTyquHY3Rd8KNyP8U/CeArtWSRKk1gSKsiOFim3XUKvg2WJqgfQVeK6drVNpw3vK9Xv0Hc3gzAxblpyvU8UaEnjuv9a77bw/FB/Kcxip5+NUfKBKKpab4EnpU4Qq3dcAA2o9QjwFV04H9TKbs1Du+KkBHHd+6pf3YSR4TqaG+WZ4NjNI2VrozeZAxRShZQU58gGetu47jB4Ov14BAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The JSON patch object to apply partial updates to rePayPalCheckoutSdks.
    /// </summary>
    [DataContract]
    public class Patch<T>
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Patch() {}

        /// <summary>
        /// The JSON pointer to the target document location from which to move the value. Required for the `move` operation.
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue = false)]
        public string From;

        /// <summary>
        /// REQUIRED
        /// The operation to complete.
        /// </summary>
        [DataMember(Name="op", EmitDefaultValue = false)]
        public string Op;

        /// <summary>
        /// The JSON pointer to the target document location at which to complete the operation.
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue = false)]
        public string Path;

        /// <summary>
        /// The value to apply. The `remove` operation does not require a value.
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue = false)]
        public T Value;
    }
}

