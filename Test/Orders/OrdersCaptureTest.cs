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
    public class OrdersCaptureTest
    {
        private OrderActionRequest buildRequestBody()
        {
            var jsonContent = new StringContent("{\"payment_source\":{\"card\":{\"expiry\":\"bvubAGG4XrxVSVDPqH\",\"id\":\"A6QI48ONIN0IfiI2\",\"last_digits\":\"BZf77MzbdFG44bps\",\"name\":\"WPvdPJ2bGB\",\"number\":\"BvpHK69sOh66y0KN\",\"security_code\":\"ED7FMs6QD7XaVs54K4\",\"billing_address\":{\"country_code\":\"C wf6LxV7wLe0SNHzV\",\"postal_code\":\"A8KtcQAMiBqaVX\",\"address_line_3\":\"FVwYYgBOsHgsRP\",\"admin_area_1\":\"PrabyNfpOrzU2\",\"admin_area_2\":\"dXV9T22dNtAELTN\",\"admin_area_3\":\"qyFF5w71K51a4BSQ\",\"admin_area_4\":\"PdqfeiYf7uPFE\",\"address_details\":{\"building_name\":\"tzOJ3s8bcfeYAU0\",\"delivery_service\":\"vUvS0069iG4XhQ02\",\"street_name\":\"z7DGgv 5xEA9\",\"street_number\":\"6 Tfes7IJ5P\",\"street_type\":\"4Ua2LB9y5 \",\"sub_building\":\"bqzRBbECLCuSPE\"},\"address_line_1\":\"GKSdi4CSrXX\",\"address_line_2\":\"BHDIL39pvcL QICut\"},\"card_type\":\"9EaD OzfrNZK6h5TO\"},\"token\":{\"type\":\"DZf7vIAzy5V4QI\",\"id\":\"NQdbXvX1v1Mqyzv\"}}}", Encoding.UTF8, "application/json");
            return (OrderActionRequest) new JsonSerializer().DeserializeResponse(jsonContent, typeof(OrderActionRequest));
        }

        [Fact]
        public async void TestOrdersCaptureRequest()
        {
            OrdersCaptureRequest request = new OrdersCaptureRequest("vA U6zM7DiQ")
                .Authorization("324GPssAiu")
                .PayPalClientMetadataId("eyi9fy261tigE9")
                .PayPalRequestId("gzW4FEXXU9XwsDba9r")
                .Prefer("2ZdyHWYiK2 YJM45D0P");
            request.RequestBody(buildRequestBody());

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal((int) response.StatusCode, 201);
            Assert.NotNull(response.Result<Order>());

            // Add your own checks here
        }
    }
}
