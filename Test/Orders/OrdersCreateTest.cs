using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using BraintreeHttp;
using Xunit;
using Xunit.Abstractions;
using CheckoutNetsdk.Test;
using static CheckoutNetsdk.Test.TestHarness;


namespace CheckoutNetsdk.Orders.Test
{
    [Collection("Orders")]
    public class OrdersCreateTest
    {
        private static OrderRequest buildRequestBody()
        {
            var order = new OrderRequest() {
                Intent = "CAPTURE",
                PurchaseUnits = new List<PurchaseUnitRequest>()
                {
                    new PurchaseUnitRequest()
                    {
                        ReferenceId = "test_ref_id1",
                        Amount = new AmountWithBreakdown()
                        {
                            CurrencyCode = "USD",
                            Value = "100.00"
                        }
                    }
                }, 
                ApplicationContext = new ApplicationContext()
                {
                    ReturnUrl = "https://www.example.com",
                    CancelUrl = "https://www.example.com"
                }
            };
            return order;
        }
        public async static Task<HttpResponse> CreateOrder() 
        {
            var request = new OrdersCreateRequest();
            request.Prefer("return=representation");
            request.RequestBody(buildRequestBody());
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestOrdersCreateRequest()
        {
            var response = await CreateOrder();

            Assert.Equal(201, (int) response.StatusCode);
            Assert.NotNull(response.Result<Order>());

            Order createdOrder = response.Result<Order>();
            Assert.NotNull(createdOrder.Id);
            Assert.NotNull(createdOrder.PurchaseUnits);
            Assert.Single(createdOrder.PurchaseUnits);

            PurchaseUnit firstPurchaseUnit = createdOrder.PurchaseUnits[0];
            Assert.Equal("test_ref_id1", firstPurchaseUnit.ReferenceId);
            Assert.Equal("USD", firstPurchaseUnit.Amount.CurrencyCode);
            Assert.Equal("100.00", firstPurchaseUnit.Amount.Value);

            Assert.NotNull(createdOrder.CreateTime);

            Assert.NotNull(createdOrder.Links);
            bool foundApproveURL = false;
            foreach (var linkDescription in createdOrder.Links) {
                if ("approve".Equals(linkDescription.Rel)) {
                    foundApproveURL = true;
                    Assert.NotNull(linkDescription.Href);
                    Assert.Equal("GET", linkDescription.Method);
                    Console.WriteLine(linkDescription.Href);
                }
            }

            Console.WriteLine(createdOrder.Id);
            Assert.True(foundApproveURL);
            Assert.Equal("CREATED", createdOrder.Status);
        }
    }
}
