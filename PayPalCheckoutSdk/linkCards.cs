using System;
using System.io;
using PayPalCheckoutSdk.Core;
using PayPalCheckoutSdk.Orders;
using PayPalHttp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Program
{

    class Paypal
    {
        static void Main(string[] args)
        {
            const string ClientID = "";
            const string Secret = "";
            
            var card = {
              "virtual Cards",
              "Physical cards"         
            }
            var identity = "Card";
            var Merchant = "MerchantID";
            var verification = Paypal.Service.VerificationResource.Create(
                to: "Number Phone",
                channel: "sms",
                pathClientID: "");
                
             var token = new Token(ClientID, Secret, identity: identity, Merchant: MerchantID);
             
              // Serialize the token as a JWT
             Console.WriteLine(token.ToJwt());

        }
        

    }
    
}
