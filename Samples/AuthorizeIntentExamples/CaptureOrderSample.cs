using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using CheckoutNetsdk.Payments;
using BraintreeHttp;

namespace Samples.AuthorizeIntentExamples
{
    public class CaptureOrderSample : SampleSkeleton
    {

        public async static Task<HttpResponse> CaptureOrder(string AuthorizationId, bool debug = false)
        {
            var request = new AuthorizationsCaptureRequest(AuthorizationId);
            request.Prefer("return=representation");
            request.RequestBody(new CaptureRequest());
            var response = await SampleSkeleton.client().Execute(request);

            if (debug)
            {
                var result = response.Result<Capture>();
                Console.WriteLine("Status: {0}", result.Status);
                Console.WriteLine("Order Id: {0}", result.Id);
                Console.WriteLine("Links:");
                foreach (LinkDescription link in result.Links)
                {
                    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                }
            }

            return response;
        }

        static void Main(string[] args)
        {
            string OrderId = "1B753033X77480819";
            CaptureOrder(OrderId, true).Wait();
        }
    }
}
