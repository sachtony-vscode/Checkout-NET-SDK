using System;

using System.IO;

using System.Text;

using System.Net.Http;

using System.Collections.Generic;

using PayPalHttp;

using Xunit;

using PayPalCheckoutSdk.Test;

using static PayPalCheckoutSdk.Test.TestHarness;





namespace PayPalCheckoutSdk.Deposits.Test

{

    [Collection("Deposits")]

    public class DepositsPatchTest

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

        public async void TestDepositsPatchRequest()

        {   

            var response = await DepositsCreateTest.CreateDeposit();

            Deposit createdDeposit = response.Result<Deposit>();

            DepositsPatchRequest<string> request = new DepositsPatchRequest<string>(createdDeposit.Id);

            request.RequestBody(buildRequestBody());



            response = await TestHarness.client().Execute(request);

            Assert.Equal(204, (int) response.StatusCode);



            response = await TestHarness.client().Execute(new DepositsGetRequest(createdDeposit.Id));

            Assert.Equal(200, (int) response.StatusCode);



            Deposit getDeposit = response.Result<Deposit>();



            PurchaseUnit firstPurchaseUnit = getDeposit.PurchaseUnits[0];

            Assert.Equal("test_ref_id1", firstPurchaseUnit.ReferenceId);

            Assert.Equal("USD", firstPurchaseUnit.AmountWithBreakdown.CurrencyCode);

            Assert.Equal("150,000,000.00", firstPurchaseUnit.AmountWithBreakdown.Value);

            Assert.Equal("added_description", firstPurchaseUnit.Description);



        }

    }

}
