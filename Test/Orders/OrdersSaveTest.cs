using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPalCheckoutSdk.Test;
using static PayPalCheckoutSdk.Test.TestHarness;


namespace PayPalCheckoutSdk.Orders.Test
{
    [Collection("Orders")]
    public class OrdersSaveTest
    {

        [Fact(Skip = "This test is an example. In production, you will need payer approval")]
        public async void TestOrdersSaveRequest()
        {
            OrdersSaveRequest request = new OrdersSaveRequest("ORDER-ID");

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(201, (int) response.StatusCode);
            Assert.NotNull(response.Result<Order>());
        }
    }
}
