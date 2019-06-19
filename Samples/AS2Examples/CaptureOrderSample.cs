using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Samples;
using PayPalCheckoutSdk.Payments;
using BraintreeHttp;

namespace Samples.AS2Examples
{
    public class CaptureOrderSample
    {
        //This method  can be used to capture the payment on the approved authorization.
        public async static Task<HttpResponse> CaptureOrder(string AuthorizationId, bool debug = false)
        {
            var request = new AuthorizationsCaptureRequest(AuthorizationId);
            request.Prefer("return=representation");
            
            // Non final capture request
            request.RequestBody(new CaptureRequest()
            {
                FinalCapture = false,
                Amount = new Money()
                {
                    CurrencyCode = "USD",
                    Value = "2.00"
                }
            });
            var response = await PayPalClient.client().Execute(request);
        
            if (debug)
            {
                Console.WriteLine("Non final capture response:");
                var result = response.Result<Capture>();
                Console.WriteLine("Status: {0}", result.Status);
                Console.WriteLine("Order Id: {0}", result.Id);
                Console.WriteLine("Links:");
                foreach (LinkDescription link in result.Links)
                {
                    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                }
                Console.WriteLine("Response JSON: \n {0}", PayPalClient.ObjectToJSONString(result));
            }
            
            // Non final capture request
            request.RequestBody(new CaptureRequest()
            {
                FinalCapture = true,
                Amount = new Money()
                {
                    CurrencyCode = "USD",
                    Value = "2.00"
                }
            });
            response = await PayPalClient.client().Execute(request);
        
            if (debug)
            {
                Console.WriteLine("Final capture response:");
                var result = response.Result<Capture>();
                Console.WriteLine("Status: {0}", result.Status);
                Console.WriteLine("Order Id: {0}", result.Id);
                Console.WriteLine("Links:");
                foreach (LinkDescription link in result.Links)
                {
                    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                }
                Console.WriteLine("Response JSON: \n {0}", PayPalClient.ObjectToJSONString(result));
            }

            return response;
        }

        static void Main(string[] args)
        {
            string OrderId = "4AC975290U000110K";
            CaptureOrder(OrderId, true).Wait();
        }
    }
}
