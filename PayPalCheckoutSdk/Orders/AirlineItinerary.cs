// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// AirlineItinerary.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The airline itinerary details.
    /// </summary>
    [DataContract]
    public class AirlineItinerary
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public AirlineItinerary() {}

        /// <summary>
        /// The airline passenger details.
        /// </summary>
        [DataMember(Name="passenger", EmitDefaultValue = false)]
        public AirlinePassenger AirlinePassenger;

        /// <summary>
        /// The details for the airline ticket.
        /// </summary>
        [DataMember(Name="ticket", EmitDefaultValue = false)]
        public AirlineTicket AirlineTicket;

        /// <summary>
        /// For direct airline integration, numeric code to identify the total number of multiple sequence clearing record messages associated with a single authorization request. Applicable to multiple captures against an authorization. In the case of single capture against an authorization the value should be 1.
        /// </summary>
        [DataMember(Name="clearing_count", EmitDefaultValue = false)]
        public int? ClearingCount;

        /// <summary>
        /// For direct airline integration, numeric code to identify each clearing record message in those cases where multiple clearing messages are allowed per authorized transaction. Applicable to multiple captures against an authorization. In the case of single capture against an authorization, the value should be 1. Also, this value must be less than or equal to the clearing count.
        /// </summary>
        [DataMember(Name="clearing_sequence", EmitDefaultValue = false)]
        public int? ClearingSequence;

        /// <summary>
        /// An array of the airline itinerary legs.
        /// </summary>
        [DataMember(Name="flight_leg_details", EmitDefaultValue = false)]
        public List<FlightLeg> FlightLegDetails;
    }
}

