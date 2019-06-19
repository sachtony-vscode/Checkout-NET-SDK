// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// AirlinePassenger.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/8RWXW/VRhO+f3/FyO8FIPn4QKMiNXcQPoSQANFQLmiUjO3x8SrrHTMzTnAr/nu1a58TThzaitL0JsqZr33mmWdn/Xt2PPaUHWboxLtApz2qUtiQZHn2C4rD0tMr7L4W8pLG2Zvl2RPSSlxvjkN2mB23BHMK7FKgJkPntcjy7JEIjtPx9/PsLWH9OvgxO2zQK0XDx8EJ1TvDG+GexBxpdvhhB1xNXNgs0VY8BJPxtOKa9oBecyxBf7BLXlUtClZGAi9+fg0HDx4+XD2AmHJyd11zpWsXjDaCMW9dO6HK1kJq67n8Ksbq+h5YiwaupmCucaRgLcEcAywgtHEcil+H+/cPqtJzdf5xYKP0e/pbqQmHzWR5xUaHk3n9pR2Ovygbj4aGBZ4LocFjcYYugFOYMqN/Snv+eK51ZQIMNQS2Rey7lzfEKgxKNbiQ+jLuV54uyEPNXTwyYEeaoCQaZoAFvFNKCWdHP5wtYR+1LiBcsvj60s22irseJc4XhlBxMGHvqYZeXEVw9+jdm3vQkbVc51BiOIcKpc5TM5Ww6qpkqUnABINiFcemM+vr67T/Q22GwfvP+V8LdFDjjuQGhV7zLCUam4OWfU2y0qHvvaN64s84EduRVC0GK+AIA5Q0jSkSGa+iC5vtyBqhjwMFg8aPJBCGriQBbiadzkCK22GkRqNTbk5LJ9buMXLds2REDUO9Qs+BIEbnscEPL4KRBLJkSmIw1yVBdWgnd1uzXg/Xa2P2WjiypmDZrFvr/Fqa6uDg4Kf/KyWxrH4sHt4r4JhBqBfSSJn2VDn04GmDHi7QD6Q56FC18WLgdCg3kFDnMPIA2vLg6ziN5FW4dNZCYEBVrhwazRDjlXEdrX6bG8IC3rcU6IIEelZ1pac81bFt91ETZ4mpmHkGNvZUwHHrNG6ZwaMAfYrY1XGAmknTPb9A7yZ6vJ9AFfCMYyx2fTzkGZUyoIxw8CDukBS/3RJtkpLCeeDLAFjyYOAJexgJRb+zbpIYFqoJk/VKLLNhqZHo2Eq7R7Hx33+F0EcBxpk0g/enC6w3+/ehP3n65u3To0fHT58Uac0n6HcUdrmpsd1NRygHdYFUkz2H4Krz6T8WwDACWxuvemRjWssYohBKAu29M3DBGBonajl4VJvrb6mAy5bCFYlx/Fdn3tKquJnNr3P4/gbIPYlyyK/MdxRihand2+lj4y4oLBvZM39bJ6lEGvk8yVvsqnN17WnZ1r792/qaasySjN8R6JXjs6fGQtAN3lzv6cs4BRcqP9RxV02l4pfT2Llq4gfjfbij+V7t22GqF2rcpz2SdqblAptc+fQ4WNzN83O/JecWkevQXEe+M93wPCfX/CX4H+GVhR6vbN+mxTl/ElHn/DjL8lGU5PwkTl/8f3eNTqf8qbDnQ6+LutsXdcdbUc/x34Xmk88nn//3BwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The airline passenger details.
    /// </summary>
    [DataContract]
    public class AirlinePassenger
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public AirlinePassenger() {}

        /// <summary>
        /// The [two-character ISO 3166-1 code](/docs/integration/direct/rest/country-codes/) that identifies the country or region.<blockquote><strong>Note:</strong> The country code for Great Britain is <code>GB</code> and not <code>UK</code> as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.</blockquote>
        /// </summary>
        [DataMember(Name="country_code", EmitDefaultValue = false)]
        public string CountryCode;

        /// <summary>
        /// The card holder-supplied code to the merchant. Can be used for passing in the frequent flyer number of the customer.
        /// </summary>
        [DataMember(Name="customer_code", EmitDefaultValue = false)]
        public string CustomerCode;

        /// <summary>
        /// The stand-alone date, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). To represent special legal values, such as a date of birth, you should use dates with no associated time or time-zone data. Whenever possible, use the standard `date_time` type. This regular expression does not validate all dates. For example, February 31 is valid and nothing is known about leap years.
        /// </summary>
        [DataMember(Name="date_of_birth", EmitDefaultValue = false)]
        public string DateOfBirth;

        /// <summary>
        /// The name of the party.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public Name Name;
    }
}

