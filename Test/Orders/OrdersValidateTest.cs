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
    public class OrdersValidateTest
    {
        private OrderActionRequest buildRequestBody()
        {
            var jsonContent = new StringContent("{\"payment_source\":{\"card\":{\"name\":\"5wyQfAf2MVX1cCA\",\"number\":\"AO7hy16d0XsOr00qAF0\",\"security_code\":\"DaawbXA5MLdVE6rEq\",\"billing_address\":{\"address_details\":{\"delivery_service\":\"PHwvagXebJi79G\",\"street_name\":\"O0RfaMFhxFESVLXCe\",\"street_number\":\"g9aX9t8cyGYP\",\"street_type\":\"yh0sdZK51dO\",\"sub_building\":\"scB8Kt7tpUMP\",\"building_name\":\"8SI10wyBqT1tzdf\"},\"address_line_2\":\"wYNyyaG9Agce8zeu\",\"admin_area_1\":\"bG4tuv40bpX7tc\",\"country_code\":\"xZ6QXKH5U7\",\"postal_code\":\"8ZDfFvAEQSAt\",\"address_line_1\":\"e6cLR2MMyQ\",\"address_line_3\":\"MYABUFziZQODJRuA\",\"admin_area_2\":\"ED3t cc7x5xT\",\"admin_area_3\":\"Yhy6iwu1UXYFXDbp\",\"admin_area_4\":\"izCgXyXMNqg6uBgagV\"},\"card_type\":\"2PCOhhM1DbeYW\",\"expiry\":\"0I9VB0M22VUIEEpV9\",\"id\":\"TCeOs0yLG6GuyVE3g\",\"last_digits\":\"8cG8wxRbqWf3Ttx\"},\"token\":{\"id\":\"LOsGi iYDSOgY6O WD8\",\"type\":\"4StTNB6Ke22eC\"}}}", Encoding.UTF8, "application/json");
            return (OrderActionRequest) new JsonSerializer().DeserializeResponse(jsonContent, typeof(OrderActionRequest));
        }

        [Fact]
        public async void TestOrdersValidateRequest()
        {
            OrdersValidateRequest request = new OrdersValidateRequest("cQqGLpw0CPQ")
                .Authorization("0GFH SbuFw")
                .PayPalClientMetadataId("OY1dCYeQFNMafyFxN3");
            request.RequestBody(buildRequestBody());

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal((int) response.StatusCode, 200);
            Assert.NotNull(response.Result<Order>());

            // Add your own checks here
        }
    }
}
