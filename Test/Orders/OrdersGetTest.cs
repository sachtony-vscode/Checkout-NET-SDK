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
    public class OrdersGetTest
    {

        [Fact]
        public async void TestOrdersGetRequest()
        {
            OrdersGetRequest request = new OrdersGetRequest("eXxYVhO1s930Bs2w0K")
                .Authorization("0qqEP0YwRwv82TIKdc");

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal((int) response.StatusCode, 200);
            Assert.NotNull(response.Result<Order>());

            // Add your own checks here
        }
    }
}
