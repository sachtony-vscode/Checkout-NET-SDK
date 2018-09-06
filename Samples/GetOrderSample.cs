using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;
using static Samples.SampleSkeleton;
using CheckoutNetsdk.Orders;
using System.Threading.Tasks;
using Samples.CaptureIntentExamples;

namespace Samples
{
    public class GetOrderSample : SampleSkeleton
    {
        public async static Task<HttpResponse> GetOrder(string orderId, bool debug=false)
        {
            OrdersGetRequest request = new OrdersGetRequest(orderId);

            var response = await SampleSkeleton.client().Execute(request);
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
            Console.WriteLine("Total Amount: {0} {1}", amount.CurrencyCode, amount.Value);

            return response;
        }

        //static void Main(string[] args)
        //{
        //    HttpResponse createdResponse = CreateOrderSample.CreateOrder().Result;
        //    GetOrder(createdResponse.Result<Order>().Id).Wait();
        //}
    }
}
