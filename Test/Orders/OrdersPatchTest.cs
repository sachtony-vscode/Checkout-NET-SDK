using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using CheckoutNetsdk.Test;
using static CheckoutNetsdk.Test.TestHarness;


namespace CheckoutNetsdk.Orders.Test
{
    [Collection("Orders")]
    public class OrdersPatchTest
    {
        private List<Patch<string>> buildRequestBody()
        {
            return new List<Patch<string>>()
            {
                new Patch<string>()
                {
                    Op = "add",
                    Path = "/purchase_units/@reference_id=='test_ref_id1'/description",
                    Value = "added_description"
                }
            };
        }

        [Fact]
        public async void TestOrdersPatchRequest()
        {   
            var response = await OrdersCreateTest.CreateOrder();
            Order createdOrder = response.Result<Order>();
            OrdersPatchRequest<string> request = new OrdersPatchRequest<string>(createdOrder.Id);
            request.RequestBody(buildRequestBody());

            response = await TestHarness.client().Execute(request);
            Assert.Equal(204, (int) response.StatusCode);

            response = await TestHarness.client().Execute(new OrdersGetRequest(createdOrder.Id));
            Assert.Equal(200, (int) response.StatusCode);

            Order getOrder = response.Result<Order>();

            PurchaseUnit firstPurchaseUnit = getOrder.PurchaseUnits[0];
            Assert.Equal("test_ref_id1", firstPurchaseUnit.ReferenceId);
            Assert.Equal("USD", firstPurchaseUnit.Amount.CurrencyCode);
            Assert.Equal("100.00", firstPurchaseUnit.Amount.Value);
            Assert.Equal("added_description", firstPurchaseUnit.Description);

        }
    }
}
