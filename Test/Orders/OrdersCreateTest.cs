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
    public class OrdersCreateTest
    {
        private OrderRequest buildRequestBody()
        {
            var jsonContent = new StringContent("{\"intent\":\"0L1g3OOGqML9USDAq7\",\"payer\":{\"external_id\":\"L D6M1tUETPXW\",\"name\":{\"prefix\":\"QgKaFT722cSHT\",\"suffix\":\"SVrR7NPLzi3Srup\",\"surname\":\"u2xbtJ hIq\",\"alternate_full_name\":\"Vic VH h43I \",\"full_name\":\"g206sWNE Pca\",\"given_name\":\"HJAicDsbYaC1a\",\"middle_name\":\"6sebpQrxGZbDf\"},\"payer_id\":\" SJpgIh1hpP\",\"phone\":{\"phone_number\":{\"country_code\":\"EJgI3Oe5fQ03d \",\"extension_number\":\"3fAMDsyRT9c\",\"national_number\":\"XuChh1stqP 3g3 hOI\"},\"phone_type\":\"3Fu zPic J175uHLbOd\"},\"tax_info\":{\"tax_id\":\"ErUL3fr4NV\",\"tax_id_type\":\"Z2hVLibIrAZwA\"},\"address\":{\"address_line_3\":\"EgbzgzFvvI\",\"admin_area_2\":\"pgLINu7UTeg92t\",\"admin_area_3\":\"FJ6Z2yyXDWCJ\",\"admin_area_4\":\"T4gL6BxdcU\",\"postal_code\":\"iVy4dJ0cD6\",\"address_details\":{\"delivery_service\":\"vZ10Jhv45TDMv\",\"street_name\":\"ttwNfHFD3Sa\",\"street_number\":\"MAiitu7fVCZ9r\",\"street_type\":\"thIMX1b4Xxf5RNFzLpR\",\"sub_building\":\"zDrvPr963X\",\"building_name\":\"8xgOPALghMNb3J1VyBd\"},\"address_line_1\":\"eiDLGiY3r4Fez\",\"country_code\":\"7XLcSr1aA \",\"address_line_2\":\"ueG1UGLRU6HWA7CiRO\",\"admin_area_1\":\"XaMzCzVGgySVyMN6\"},\"birth_date\":\"WRWpKwCHg3\",\"email_address\":\"BBI0XF4Xw2iQW3q5Y\"},\"purchase_units\":{\"payee\":{\"client_id\":\"VFB3vOya524Li\",\"display_data\":{\"business_phone\":{\"extension_number\":\"LU3i3EW fDwrPDwx\",\"national_number\":\"sKdqh0GBMhX0Q3M3\",\"country_code\":\"H7UaJt4bPM3\"},\"brand_name\":\"vPPqf9cDxub31rAyM5b\",\"business_email\":\"sPJE3cuTS4hw\"},\"email_address\":\"vc7f4ivQYU\",\"merchant_id\":\"e0tZbcJau9 hJxOqB\"},\"payment_instruction\":{\"disbursement_mode\":\"ZE1tqwqWI19e\",\"platform_fees\":{\"amount\":{\"currency_code\":\"XEHTgaG0UHcR6pfFCVU\",\"value\":\"x3dWcXYaq9PVM\"},\"payee\":{\"client_id\":\"HV9TRzqdy2eA9zZv\",\"email_address\":\"J2UDJa98JhgF\",\"merchant_id\":\"EbLz0Nbit HuiKY\"}}},\"reference_id\":\"Yar1AH4FHyCsSt6c5Nt\",\"shipping\":{\"address\":{\"address_details\":{\"building_name\":\"yTNftqIrYrcG\",\"delivery_service\":\"68eILMOw7SxbNFeCL\",\"street_name\":\"4E9b752vKGYTT1dTC\",\"street_number\":\"Zqs6XOhE6hvp\",\"street_type\":\"Ti0W7B83aQI\",\"sub_building\":\"JHUpi0FsPIptrW\"},\"address_line_1\":\"YFFCdGCHaAcDDV\",\"address_line_2\":\"YrSOz9PB1JAR4idO7S\",\"address_line_3\":\"3t0 G9I3v1tJfgzROwD\",\"admin_area_1\":\"V0Cc0a4RqWS\",\"admin_area_2\":\"EZfFtUvA1x8EWM\",\"admin_area_3\":\"ErTs5S0SBGH0G  \",\"admin_area_4\":\"aP 1c4DFDVhdKLq1\",\"country_code\":\"OeKLFST K8\",\"postal_code\":\"X51c2BGQrKAP3Ix0PxY\"},\"name\":{\"suffix\":\"UDhTYLYMcLUx\",\"surname\":\"K0BzHtGFiBYA\",\"alternate_full_name\":\"Hac0Kdtg2ufwfJxYE9x\",\"full_name\":\"dxzf6xwexBNLUeQc1c\",\"given_name\":\" W637uATXrb\",\"middle_name\":\"ypVb4UwZ4ScRxxVhOT\",\"prefix\":\"xbK iY9piKWJ\"}},\"custom_id\":\"G1WpGqbvfarv\",\"description\":\"Hpu1KfEb5 hKB\",\"invoice_id\":\"WHYpAYTA9687E24O\",\"items\":{\"sku\":\"Ed2HTU9cdtHRfpV6xF\",\"tax\":{\"currency_code\":\"dvEadsi5hyvJ742P\",\"value\":\"e8La4eiaCXxAhJ14DO\"},\"unit_amount\":{\"currency_code\":\"14zLyFDFDhg\",\"value\":\"NdO2NucHhbcr5qJa\"},\"url\":\"0CJBf6URFy\",\"category\":\"Ew98sDhLRN1XpeJ0Azv\",\"description\":\"ALBMJs4hu88\",\"name\":\"abXPO5YTdgJ\",\"quantity\":\"FDLx99eNrpyit Mrdz\"},\"soft_descriptor\":\"pILJBe9I6CHK1\",\"amount\":{\"breakdown\":{\"tax_total\":{\"currency_code\":\" 9xid7fuV3g18\",\"value\":\"PraqWqU5ODAKVZxD\"},\"handling\":{\"value\":\"TavAb6pp1q\",\"currency_code\":\"PsGELuc6CWgfaaIh1DO\"},\"insurance\":{\"currency_code\":\"SwcNdVVcf4gXzwV\",\"value\":\"gT2uQ1W ZRcq\"},\"item_total\":{\"currency_code\":\"BeB qYiMuVX\",\"value\":\"tN8facPYIvArwT\"},\"shipping\":{\"value\":\"Z22OBvpvxYB8TTvaaY1\",\"currency_code\":\" ePi tcIvs8bSAh9Sc\"},\"shipping_discount\":{\"value\":\"rLeE5KLFQ50vbv\",\"currency_code\":\"5aIdI6MX9X9\"}},\"currency_code\":\"TYa1NG9VHyW8H4C\",\"value\":\"6LQ255eYQMtOhR8Ve\"}},\"application_context\":{\"locale\":\"FSKRVC8FD3Lc3NBpIH\",\"payment_method\":{\"payee_preferred\":\"xuC2O6pAOIu 9\",\"payer_selected\":\"72et9re9xpcY3wOYtv\"},\"payment_token\":\"v6bzvbdJH28eNVZXVq\",\"return_url\":\"xDqFATYiOaw5Mhz9\",\"user_action\":\"CJA EcW1H5ahfCv\",\"brand_name\":\"Qs1fycBwU2HJG28YL4\",\"cancel_url\":\"ePGs5ezrQE1TWZPDIUX\",\"landing_page\":\"1QIp7TOSEp\",\"shipping_preference\":\" Bqb55fP1 f4cuv33\"}}", Encoding.UTF8, "application/json");
            return (OrderRequest) new JsonSerializer().DeserializeResponse(jsonContent, typeof(OrderRequest));
        }

        [Fact]
        public async void TestOrdersCreateRequest()
        {
            OrdersCreateRequest request = new OrdersCreateRequest()
                .Authorization("AbrK9p8fI0GyrOZc3Y")
                .PayPalPartnerAttributionId("MSZTYH2G Cd0MA")
                .Prefer("bQA0wpf ag");
            request.RequestBody(buildRequestBody());

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal((int) response.StatusCode, 201);
            Assert.NotNull(response.Result<Order>());

            // Add your own checks here
        }
    }
}
