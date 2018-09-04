// This class was generated on Tue, 04 Sep 2018 11:48:14 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// AddressDetails.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/7xVTW/bSAy9768gdJa1WezNtyDBYrG7yAZB2ktb2JSGsomOhipnxo5Q5L8Xow87ih0UQYrcJHL48d48cr5n911L2TK7NEbJe7imgGx9lmcfURlLSzfYpANZnv1L3fHnmnyl3AYWly2z+y2BE7doRUMKAjSGkw9t+uxTmyE1hC0GQCXw0lDghjw4IkMGalGopGkto6soB2X/NQdRkLAlBV+RQ2XxsN+SEtTsaLFRZHeowa4WbTBVhoY32wAljdkLuJEAhwb3HLapWCMOwpbVQIsaOkBnQFpyXqJWVMAdmegMujBF9IXJGl/AX6JAD9i0lnJYjz2sphLFZLDsaPXHGthD9BGt7QBT6ZLd0KnUx+iRpcIHJQorF5uSdN23tZ5s2NDcErqW1kWWZ5eq2A1XepFnd4Tmf2e7bFmj9ZQM3yIrmYPhVqUlDUw+W346iMEHZbc51UAZ2Rp2m76DmSCee+bquIRkNmCl6gGPGlBqlTy5kP4JWqWGPRXw4UDSlLaPT0IY6IBeJ9ZSNdE3HfTDLeF0s/O4Zzf2OV5c/FlVYqj/oivFHTn4W6IfLNXvR+db2XXR2sf8pxQbsrwj7VaedMfVnOUzztMxnA7BeKiAW/EBpK65IijlIYcSNyMj/XS1T/yJsHeC+kTNM5Rz+ynAwT90Cv9EH2B9rVG7NbAbP+E/dG8fiFfi6Ak9i2TyvIxlkOe79pt2xrluR/uLvSb/s0FKYxMph1KipR2qyUEFTS8uekhD7vfYvRe8WK6mdTDHN3ecAqxZfViIGlIgFzh0UJKVPeC4vw7rSPSwy86uMh/LxZl15tltLB3TpF2VHq9XLLMCrtClRw2hthhy8EG0y6G2Ippol6anHdNr1pALv4T1L4+//QAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace CheckoutNetsdk.Orders
{
    /// <summary>
    /// The non-portable additional address details that are sometimes needed for compliance, risk, or other scenarios where fine-grain address information might be needed. Not portable with common third party and opensource. Redundant with core fields. For example, `address_portable.address_line_1` is usually a combination of `address_details.street_number` and `street_name` and `street_type`.
    /// </summary>
    [DataContract]
    public class AddressDetails
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public AddressDetails() {}

        /// <summary>
        /// A named locations that represents the premise. Usually a building name or number or collection of buildings with a common name or number. For example, <code>Craven House</code>.
        /// </summary>
        [DataMember(Name="building_name", EmitDefaultValue = false)]
        public string BuildingName;

        /// <summary>
        /// The delivery service. Post office box, bag number, or post office name.
        /// </summary>
        [DataMember(Name="delivery_service", EmitDefaultValue = false)]
        public string DeliveryService;

        /// <summary>
        /// The street name. Just `Drury` in `Drury Lane`.
        /// </summary>
        [DataMember(Name="street_name", EmitDefaultValue = false)]
        public string StreetName;

        /// <summary>
        /// The street number.
        /// </summary>
        [DataMember(Name="street_number", EmitDefaultValue = false)]
        public string StreetNumber;

        /// <summary>
        /// The street type. For example, avenue, boulevard, road, or expressway.
        /// </summary>
        [DataMember(Name="street_type", EmitDefaultValue = false)]
        public string StreetType;

        /// <summary>
        /// The first-order entity below a named building or location that represents the sub-premise. Usually a single building within a collection of buildings with a common name. Can be a flat, story, floor, room, or apartment.
        /// </summary>
        [DataMember(Name="sub_building", EmitDefaultValue = false)]
        public string SubBuilding;
    }
}

