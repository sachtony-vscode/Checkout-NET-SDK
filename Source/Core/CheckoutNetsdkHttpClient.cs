using BraintreeHttp;


namespace CheckoutNetsdk.Core
{
    public class CheckoutNetsdkHttpClient : HttpClient 
    {
        public CheckoutNetsdkHttpClient(Environment environment) : base(environment) {}

        protected override string GetUserAgent() {
            return "CheckoutNetsdk HttpClient"; // TODO: Change me
        }
    }
}
