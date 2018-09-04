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
        private List<Patch<T>> buildRequestBody()
        {
            var jsonContent = new StringContent("{\"from\":\"ph9z4uJ9p VM\",\"op\":\"GVhBtswKSCqs9XzfxH\",\"path\":\"H8K0TeYAWUr Zru4Dh\",\"value\":{}}", Encoding.UTF8, "application/json");
            return (List<Patch<T>>) new JsonSerializer().DeserializeResponse(jsonContent, typeof(List<Patch<T>>));
        }

        [Fact]
        public async void TestOrdersPatchRequest()
        {
            OrdersPatchRequest request = new OrdersPatchRequest("yXrU5B3ZF8c")
                .Authorization("Fvh2uVJ9RdTC2ai7");
            request.RequestBody(buildRequestBody());

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal((int) response.StatusCode, 204);

            // Add your own checks here
        }
    }
}
