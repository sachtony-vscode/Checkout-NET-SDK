using System;
using CheckoutNetsdk.Core;
using BraintreeHttp;
namespace CheckoutNetsdk.Test
{
    public class TestHarness
    {
        private class TestEnvironment: BraintreeHttp.Environment
        {
            public string BaseUrl()
            {
                return System.Environment.GetEnvironmentVariable("BASE_URL");
            }
        }

        public static HttpClient client()
        {
            return new CheckoutNetsdkHttpClient(new TestEnvironment());
        }
    }
}


