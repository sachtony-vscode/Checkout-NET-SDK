using BraintreeHttp;

namespace CheckoutNetsdk.Core
{
    public class CheckoutNetsdkEnvironment : Environment
    {
        private string baseUrl;

        public CheckoutNetsdkEnvironment(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        public string BaseUrl()
        {
            return this.baseUrl;
        }
    }
}
