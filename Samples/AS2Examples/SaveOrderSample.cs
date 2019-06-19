using System;
using System.Collections.Generic;
using System.Threading.Tasks;
//1. Import the PayPal SDK client that was created in `Set up the Server SDK`.
using Samples;
using PayPalCheckoutSdk.Orders;
using BraintreeHttp;

namespace Samples.DelayedAuthCaptureExamples
{
    public class SaveOrderSample
    {
        //2. Set up your server to receive a call from the client
        //This function can be used to perform save on the approved order. Please add a body as leaving it blank would cause an "UNSUPPORTED_MEDIA_TYPE" error.
        public async static Task<HttpResponse> SaveOrder(string OrderId, bool debug = false)
        {
            var request = new OrdersSaveRequest(OrderId);
            request.Prefer("return=representation");
            request.Body = new OrderRequest();
            //3. Call PayPal to save the order
            var response = await PayPalClient.client().Execute(request);

            if (debug)
            {
                var result = response.Result<Order>();
                Console.WriteLine("Status: {0}", result.Status);
                Console.WriteLine("Order Id: {0}", result.Id);
                Console.WriteLine("Intent: {0}", result.CheckoutPaymentIntent);
                Console.WriteLine("Links:");
                foreach (LinkDescription link in result.Links)
                {
                    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                }
                AmountWithBreakdown amount = result.PurchaseUnits[0].AmountWithBreakdown;
                Console.WriteLine("Buyer:");
                Console.WriteLine("\tEmail Address: {0}", result.Payer.Email);
                Console.WriteLine("Response JSON: \n {0}", PayPalClient.ObjectToJSONString(result));
            }

            return response;
        }

        static void Main(string[] args)
        {
            string AuthId = "<<REPLACE-WITH-APPROVED-ORDER-ID>>";
            SaveOrder(AuthId, true).Wait();
        }
    }
}
