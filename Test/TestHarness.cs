using System;
using PayPalCheckoutSdk.Core;
using BraintreeHttp;
using Xunit;
[assembly: CollectionBehavior(MaxParallelThreads = -1)]

namespace PayPalCheckoutSdk.Test
{
    public class TestHarness
    {

        public static PayPalEnvironment environment()
        {
            return new SandboxEnvironment("<<PAYPAL-CLIENT-ID>>", "<<PAYPAL-CLIENT-SECRET>>");
        }

        public static HttpClient client()
        {
            return new PayPalHttpClient(environment());
        }

        public static HttpClient client(string refreshToken)
        {
            return new PayPalHttpClient(environment(), refreshToken);
        }
    }
}
