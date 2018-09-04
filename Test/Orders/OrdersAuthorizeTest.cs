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
    public class OrdersAuthorizeTest
    {
        private OrderActionRequest buildRequestBody()
        {
            var jsonContent = new StringContent("{\"payment_source\":{\"card\":{\"name\":\"uGAXYMbWVpuvzq8XZMG\",\"number\":\"sG8qI5K6dUdtcRr8i\",\"security_code\":\"B3uB1 vH2UR9\",\"billing_address\":{\"address_details\":{\"building_name\":\"uDqqyMJOw7Wvt\",\"delivery_service\":\"PqiL4YCSteTaac6H6\",\"street_name\":\"gNaLN9N1JGXB87p4Tg\",\"street_number\":\"IGe6SrvA0VQ5\",\"street_type\":\"5c3P9YhrzQ\",\"sub_building\":\"dV69uyHDYuzS\"},\"address_line_2\":\"Pc2L1 t0036M\",\"admin_area_2\":\"Hrs2LRgNGGFgHKFbc\",\"admin_area_3\":\"VEQ4xxUvS3eVO1d5VR\",\"admin_area_4\":\"ca4KtG351QLzdZM\",\"address_line_1\":\"0t3BxV1Z4pZ\",\"address_line_3\":\"N7JscVHN7whyN\",\"admin_area_1\":\"J4yzp2YOMrvSdFxz\",\"country_code\":\"EfB9ypUpxtTP3F3gWI\",\"postal_code\":\"gDiL31J4Z2UI1KAw\"},\"card_type\":\"gYR9TPxFWciFuYBvNr\",\"expiry\":\"xrttV 6KudK3P0\",\"id\":\"XZfUbWv5FpKZAvQu\",\"last_digits\":\"K4aWb42yWwNTM\"},\"token\":{\"id\":\"9GGYX37xQrBBO7i34T\",\"type\":\"3ttSRJQ81V2\"}}}", Encoding.UTF8, "application/json");
            return (OrderActionRequest) new JsonSerializer().DeserializeResponse(jsonContent, typeof(OrderActionRequest));
        }

        [Fact]
        public async void TestOrdersAuthorizeRequest()
        {
            OrdersAuthorizeRequest request = new OrdersAuthorizeRequest("7X25IiLHpyG")
                .Authorization("2eVSpJA5qaBYWq1fgUT")
                .PayPalClientMetadataId("pWfd6MMNQ0LS9JCOys")
                .PayPalRequestId(" tF1EXreHICGuUPeJ")
                .Prefer("hhpirWA7FR");
            request.RequestBody(buildRequestBody());

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal((int) response.StatusCode, 201);
            Assert.NotNull(response.Result<Order>());

            // Add your own checks here
        }
    }
}
