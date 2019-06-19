using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Samples;
using PayPalCheckoutSdk.Orders;
using BraintreeHttp;

/**
 * NOTE:
 * Order can be voided only in the following scenarios:
 *  1. After Save
 *  2. After Authorize
 *  3. After Non-final capture
 *  4. Before Final capture
 *
 *  After final capture, user will receive an error when the user tries to void the order.
 */

namespace Samples.AS2Examples
{
    public class VoidOrderSample
    {

        //This function can be used to perform authorization on the approved order. Please add a body as leaving it blank would cause an "UNSUPPORTED_MEDIA_TYPE" error.
        public async static Task<HttpResponse> VoidOrder(string OrderId, bool debug = false)
        {
            var request = new OrdersVoidRequest(OrderId);
            request.Prefer("return=representation");
            request.Body = new OrderRequest();
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
//
//        static void Main(string[] args)
//        {
//            string OrderId = "7SP91606ET928374M";
//            VoidOrder(OrderId, true).Wait();
//        }
    }
}
