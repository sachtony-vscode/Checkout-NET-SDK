// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// FlightLeg.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/+xYX28bRw5/v09B6F4SQH+SOHeH85uRILhc0SRojRaFa8jUDFc79ezMlsOVvS3y3QvO7tqWVm6bNlWA1E+2htzh/x/J+Xly2tY0OZ4U3q1LWXpaT6aTb5Adrjy9wWpE+4La/ngynbykZNjV4mKYHE9OSwJLgs4niAVISdB9Cp7W88l0csKMbSfwyXTyFaF9G3w7OS7QJ9KDHxvHZG8O3nGsicVRmhyf3aiahF3YoyZa61QT9MsQBfXftKXwPQzbRpwEoGAjJ6ooCEQGJpVolA4xZLPEmUuSOewwGwywIsAAuKZg2hlaSxYGYXoZQoXBokRuYR03xCF/yb3pN7xTSI0pARMgbNA31N8leD2Hky2dnPJ4V7leygoT2RtN25o0GAUy3b2zswCunJT6q2SimcUWKhdc1VSQBNs/G7LQeP9++ttxY3Yb9Et0XEeW7ZCNaOOU62lgoqWpWmepcIEsrFo4e31yenL+qBSp0/FicXV1NXcoOI+8XtTNyjvTpcHiHa4pLfSKWSJkU84x1dePD+wCcRXttb8njI1XwhRcF+yyPK4qePYc/sdQRK5QDqS/UT2Jl+q/Lf13CGP9NT4gV3HmSYQY0JjYBHFhneMJUqKAsxTEFY5SNrO/9FC2xfBDE3KpLbuqWYamWhFvG/orXDsAM9SeC3DnK+hqETBEKYl7pilclc6UIHFN+bjCS4KmBoTkwtqTXiGMRrTIs2NwTQfyjKUaWRqmvaW7j/pZFu+toRaF7vFBTxo7IAkGO0MfA4Ey5WI+ex2EOJDkI8Bgc6H3RX3rEonRp7kjKbJTSqn8ggtzdHT0338mynk1+9f834/ncBqBqWZK2m1STcah17aMvmsv6W5zyEJjASvHUk6hjQ2kMjbeQpM6LVOXrSECphSNQ6Fexcj57+yn3iCcw7clBdoQQx1TcitP03yPDNYjW7jQWzPMXeSeNYfT0iVgWjceGehadU9aJzZS0japervOPd53Ss3hVVRerGoV8opW3CC3cPRUm2Tmz77UElOEcQkuQ7wKgKvY6JSCNbSEnA6eOSPgH5E+NfR/GQO1e2ZD5G3F+4OxuqZh1qEoRwArRXnVFBAKFzDkhBTGkNDsDkAr9BhMzq0a2zww2Yb++olyUHlPX9uhjM0962YqU6KiMzG8/vrt7Pmzp/+5dYR+e/5oYaNJCxeE1pzxbGEdk5GFzniLgXmmzGnxeH9D7Jk+yCPCzR/L2owXW94YTsZeyJShiVV5F1jR8ffNkydHpvH5L3W/vOt+nQTIvqCcx4Npaql3lwQX/3/33UXnBGTKOCBt7Qx630LBXe6gn3eXLoZbd2SAJeMq9Ddf7Jd1+ublHVmpWVm3cTqFuyARpIxNwmClTPvFLQYLFZU0TrdTfh4NFGIHRWqPhlJfEFsZMoVEBGcvhrMXmggfmjYfIzPOf0duaPUvV5hcGtfMmLYHJHTma1LX/9Gxd4FA4pDwraKFxiKvNQokFFT6DWsSLIquXzJuyOdFTJJeUTg91Sg0vve0aIvpd7nDoCXtuIQesPIBKx+w8u+Jld2z2hgnt87HedK/qd365TatP8pL205q9xl2r/57luFdyie34b4QJOKNM7Q0HtP2W+EuZc/i1nFA5tAG02/q5W036hd9rGvv6FBLRZJYx82+x5hdytimGGh4iLnz+hKsbtq685XdI4TaWGNKFBR6XAJFWPG6AsbuhQJhEHaYxip4vWVq9/uhsT401ofG+pk11vP3//gFAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The details of the flight leg.
    /// </summary>
    [DataContract]
    public class FlightLeg
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public FlightLeg() {}

        /// <summary>
        /// An endorsement or restriction on the ticket. An endorsement can be an agency-added notation or a mandatory government required notation, such as a value-added tax. A restriction is a limitation based on the type of fare, such as a ticket with a three-day minimum stay.
        /// </summary>
        [DataMember(Name="additional_notations", EmitDefaultValue = false)]
        public string AdditionalNotations;

        /// <summary>
        /// The airport code, as defined by [IATA](https://www.iata.org/publications/Pages/code-search.aspx).
        /// </summary>
        [DataMember(Name="arrival_airport", EmitDefaultValue = false)]
        public string ArrivalAirport;

        /// <summary>
        /// The time, in the hh:mm 24 Hr format.
        /// </summary>
        [DataMember(Name="arrival_time", EmitDefaultValue = false)]
        public string ArrivalTime;

        /// <summary>
        /// The IATA two-letter accounting code that identifies the carrier.
        /// </summary>
        [DataMember(Name="carrier_code", EmitDefaultValue = false)]
        public string CarrierCode;

        /// <summary>
        /// A ticket in conjunction  with  another ticket, which together make up a single contract of carriage.
        /// </summary>
        [DataMember(Name="conjunction_ticket_number", EmitDefaultValue = false)]
        public string ConjunctionTicketNumber;

        /// <summary>
        /// The airport code, as defined by [IATA](https://www.iata.org/publications/Pages/code-search.aspx).
        /// </summary>
        [DataMember(Name="departure_airport", EmitDefaultValue = false)]
        public string DepartureAirport;

        /// <summary>
        /// The stand-alone date, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). To represent special legal values, such as a date of birth, you should use dates with no associated time or time-zone data. Whenever possible, use the standard `date_time` type. This regular expression does not validate all dates. For example, February 31 is valid and nothing is known about leap years.
        /// </summary>
        [DataMember(Name="departure_date", EmitDefaultValue = false)]
        public string DepartureDate;

        /// <summary>
        /// The time, in the hh:mm 24 Hr format.
        /// </summary>
        [DataMember(Name="departure_time", EmitDefaultValue = false)]
        public string DepartureTime;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="fare", EmitDefaultValue = false)]
        public Money Fare;

        /// <summary>
        /// The code used by airline to identify a fare type and enable airline staff and travel agents to find the rules for this ticket.
        /// </summary>
        [DataMember(Name="fare_basis_code", EmitDefaultValue = false)]
        public string FareBasisCode;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="fee", EmitDefaultValue = false)]
        public Money Fee;

        /// <summary>
        /// The flight number of the current leg.
        /// </summary>
        [DataMember(Name="flight_code", EmitDefaultValue = false)]
        public string FlightCode;

        /// <summary>
        /// The flight number of the current leg.
        /// </summary>
        [DataMember(Name="flight_number", EmitDefaultValue = false)]
        public int? FlightNumber;

        /// <summary>
        /// The service class to which the airline ticket applies.
        /// </summary>
        [DataMember(Name="service_class", EmitDefaultValue = false)]
        public string ServiceClass;

        /// <summary>
        /// The one-letter code that indicates whether the passenger is entitled to make a stopover.
        /// </summary>
        [DataMember(Name="stopover_code", EmitDefaultValue = false)]
        public string StopoverCode;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="tax", EmitDefaultValue = false)]
        public Money Tax;
    }
}

