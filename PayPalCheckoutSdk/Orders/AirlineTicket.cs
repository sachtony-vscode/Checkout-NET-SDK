// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// AirlineTicket.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/+xY3W4bNxO9/55isN9NAqy0Tt0fVHeCjQBu0SRwhRaFa8gjcqQlTJGb4dD2tsi7F9wfxeuV2wQVetHqytjhkHPm8PCQ1u/Zoq4om2Vo2BpHSzHqliTLs5+QDa4svcHt3vHvqe6Gsjw7p6DYVGK8y2bZoiTQJGhsgLVnkJKgmw/t/GmWZ3NmrNvqJ3l2SajfOltnszXaQCnwPhomvQu8Y18Ri6GQza52uH/wjuox3DUyDUB2gTFQFZnJqRrQacCtj04a0Ahr49ApgxaE0QVUaVYOIaoSMADCCi06ReAZKqy35AR0pMP1FoSN24yb6yEvldfDLp+OjNu9kpKJJqpERiXEcPHj28mXX7z65iMRae71i0J7FQrjhDaMaYFCGyYlBVOQok+epORQvAQpUcBocmLWhkKz533SZzEiHJ8Q4qK1H/K/ZOUObRyy0UfGLDQjOdyXRpWwNZtSYEWzX+PJyamKtvlL7Zc17dfcQcMFcaOOrrXUqTW3BDffvfvlpiUBmcB5Aakro9DaGtbcagfttF206Fd9UgM0KbNFu5uxv9bizfmjWiGutLkzmnRC6EFKHwM6LWXYX67oO3zdnU3uyAcXtyti8OsdkMqiotAdiIFCcghEcHXWx86SED5XNodQxvUjbTznBvTEDOjoBUcvOHrBv9oLntOGCSHSUqMMBTIIj1USBJ2eoPWOICXlYBxcXTghdiRNqHENMVtKFG1Rrl+UIlWYFYV4b8PUkKynnjdFKVtb8Fqdnp5++/9Aze5Ovpp+/XIKCw9MFVNIBhIqaizH0gZtq9Pw2HOaon4NK8NS5lD7CKH00WqIoUUZ4N5ICc4DhuCVQaEOYtpus6XJb11DOIWfS3J0RwyVD8GsLOXNOtJ3j6zhJq26TDNvkqhpCovSBGDaRIsM9JCwh6RW7Sk02r9Da1p6rG1BTSGpjR5wW6Uir2nFEbmG01dgQpvfcOm8lMZtUvDW+XsHuPJRwBJWUBNy+Lv2+olukqRh3GapkNkQj632mYQ9F0yb0ByatHOJ2/ZFDI3++B/qqD3cgx52oTHq7u0+aSDqHnBvEAwX5weGvfLeErox7mQcbJSQ3vePyL7RYTcXThvVnouSpCQe7gB8XOHAHT3zMBF8GHTQfh8fJseHyfFh8p97mAjjHdklbvYfm73DY9VczBfzjqMc0AYP88uzR2Y9vzwrHuWkC5wgOvM+UnctcZ/d/3bTVoa2cneIuqsgXf6H+UnnEw/QkAWXgs+T1A2PSUoDu/v3T7qjQzZ3/eF/fwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The details for the airline ticket.
    /// </summary>
    [DataContract]
    public class AirlineTicket
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public AirlineTicket() {}

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="fare", EmitDefaultValue = false)]
        public Money Fare;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="fee", EmitDefaultValue = false)]
        public Money Fee;

        /// <summary>
        /// The stand-alone date, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). To represent special legal values, such as a date of birth, you should use dates with no associated time or time-zone data. Whenever possible, use the standard `date_time` type. This regular expression does not validate all dates. For example, February 31 is valid and nothing is known about leap years.
        /// </summary>
        [DataMember(Name="issue_date", EmitDefaultValue = false)]
        public string IssueDate;

        /// <summary>
        /// The carrier code of the ticket issuer.
        /// </summary>
        [DataMember(Name="issuing_carrier_code", EmitDefaultValue = false)]
        public string IssuingCarrierCode;

        /// <summary>
        /// The airline-issued ticket number or ID.
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue = false)]
        public string Number;

        /// <summary>
        /// Indicates whether the ticket is restricted.
        /// </summary>
        [DataMember(Name="restricted_ticket", EmitDefaultValue = false)]
        public bool? RestrictedTicket;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="tax", EmitDefaultValue = false)]
        public Money Tax;

        /// <summary>
        /// The IATA number, also ARC number or ARC/IATA number. The unique code or number for the travel agency that issued this ticket.
        /// </summary>
        [DataMember(Name="travel_agency_code", EmitDefaultValue = false)]
        public string TravelAgencyCode;

        /// <summary>
        /// The name of the travel agency that issued the ticket.
        /// </summary>
        [DataMember(Name="travel_agency_name", EmitDefaultValue = false)]
        public string TravelAgencyName;
    }
}

