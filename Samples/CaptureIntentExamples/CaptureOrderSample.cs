using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using CheckoutNetsdk.Orders;
using BraintreeHttp;

namespace Samples.CaptureIntentExamples
{
    public class CaptureOrderSample : SampleSkeleton
    {

        public async static Task<HttpResponse> CaptureOrder(string OrderId, bool debug = false)
        {
            var request = new OrdersCaptureRequest(OrderId);
            request.Prefer("return=representation");
            request.RequestBody(new OrderActionRequest());
            var response = await SampleSkeleton.client().Execute(request);

            if (debug)
            {
                var result = response.Result<Order>();
                Console.WriteLine("Status: {0}", result.Status);
                Console.WriteLine("Order Id: {0}", result.Id);
                Console.WriteLine("Intent: {0}", result.Intent);
                Console.WriteLine("Links:");
                foreach (LinkDescription link in result.Links)
                {
                    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                }
                AmountWithBreakdown amount = result.PurchaseUnits[0].Amount;
                Console.WriteLine("Buyer:");
                Console.WriteLine("\tEmail Address: {0}\n\tName: {1}\n\tPhone Number: {2}{3}", result.Payer.EmailAddress, result.Payer.Name.FullName, result.Payer.Phone.CountryCode, result.Payer.Phone.NationalNumber);
            }

            return response;
        }

        //static void Main(string[] args)
        //{
        //    string OrderId = "0FG2496500642503G";
        //    CaptureOrder(OrderId, true).Wait();
        //}
    }
}
