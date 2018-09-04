// This class was generated on Tue, 04 Sep 2018 11:48:14 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// ShippingDetails.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/8xZX3PbRg5/v0+B0T0knqGk2G57N35znDRt06Se2EkfchkLJCERo+Uus7uUrNz0u99gl5REicq/5tS+WbvgLoD9AfgB/u/gdlXR4GJwU3BVsZ7BE/LIyg2SwRu0jKmil1iKxCAZPKfV5scTcpnlyrPRg4vBbUHg2jPyeMZokAwurcVVvONRMnhFmP+m1WpwMUXlSBbe12wpXy9cW1OR9UxucPF2rd21sV5UgWvjPCq4zHNLzsHDF5RzXQ6fWWRN+cm+1hglO8pv1vZtqNqbWHuyGmULFVTx3ubLEbzAyoE38LbR5A0qzoPwC/KYo8d3DwvvK3cxHs/YF3U6ykw5nhkzU8Sn/9ZjxWlzGuuq9uMlz3l88LQTQJ3DT7cvfoXvR6fw9rL2ZspKibenxpaQGe2tUe4CfEGAtTeZKStFngC9t5zWnjYqLZfL0fJ8ZOxsfPtqXPhSfX86dpQN5Sw3koV/4uaKsDxsrxj6gobbNwzXN5x8uydvn/ggHhvv3eVrgb0X3trbf2lt9HD92pjn3Dx1820LYvAFekBL4ExJnktyoIlyysXxEHzAqDNKwLKbJ2AsGF+QBZeRRsvGwbIgSzBlTcOZIHV9B2vxbHhpKHlWeEipOX0EL43fwHHJvpDLSqPBF2xzqND6VYCFqUg7U9uMRvCK8lrnqH37RbiYVO5G8KOxQPcoj5bApPVRe8WoXVCs6e50AuygdjUqtQKUq1OO4QBmuvm6DXXnLZG/03WZkp0EtSbtGpbUXfGriibfDirOW9azfYSkNauc9Sxo0MHH7k4XHZcgyzkokwWDGwxYqiw50t6FGKsslexoBK/XTmqPDd8LEKI7IOBEKcpa97WCLr4Sti/b/W7nxf5TP3p0nmUmp/AXXVlckIafTO3iSjbebP5Z7+paqT+ST7o4J8ULsqs7R3bBWdfLPZv7YdgKQSM0CjkezHTKGUFq7hNIcdZ4JERXtbUvDjuSqVto7ljZXe+pimE/agq/1M7D5Imt7WoCrJs/4VfUfz4gvtCO4NBeS9qdw7ZEeB5VX8kZfdo26wd1lf2dQJKwqSmB1NSKFmjzBKzBPICL7iXI3RJXxzKvTu/adNC1r7uxb+CUrfNDY3OyQNqzX0FKyiwBm/y1TkfGrnNZbypzdTrsSWeO9UzR5hjJVVK8viCZjeAKtRQ1hKlCn4Dzxq4SmCpjrLjdlMHtKNWsJO2/idfffYbfu9Wulz2stw74HkRAPBAoV0sNO1DbFIAIx90ifPqvc9hOAdAaF8iFMD95Whvr/IZrhJ9CNyArKJsLIZXEIgxN6IXoM63Vhq8eB8odv50ddulZf7xSZnT+GT51NXvqgOa4Caljy/lhM897zYzkrcfKBHi65n7dfNXmski4g8UCj8cWP7BKIGfbRKOne4mxOisAHUw03XvpUn5HVaL1kxhqoFDnJdq5FCDU8LPOGfXRsVKyvkNLuBd8nY19BxY8K0iCjxakQurKecFOzG+SUy0Rk8Cy4KzostjKmgUHru48egr++Pnmt+H56Q8/DM/ksPas8AQlRkc33V9LVXaD+Ooy0lttPEyuUPHUWM04GcEbVKHQrDZasbuIZK1WkanFX4rjr9fPR3AZpVejhtW1ezuSNyIZ7Pi44BVqzFGEW/M/Lv8LVqijOE0p87X9xAc3S/YfyAqs5LM5am90/yfj1uqjo+zsEMrOevh/xn6VgDdLHSCyYKVwRiO4KVEpslJEtfRA60MCGO9OJ8ePnvNDdp332CXRIkxABftcndY2TUATz4rU2MKYSIJylosz/0mDz1qMfwrWMVWN4Ka5MkW21oTLtm//OM5CogpnrI3Y0XZDtTutNbsQm6iWuHKAC2QVmuq09pJcD5wHWUtdYn8irgAx/u8G7e8OQeC7/sFH57mXgf9+yaOfT0R8Ivy0ddvnwiBO2EIydcZ6IZXSskZSGjI15ZLFn9VktaNIe0rUK/jRks4K8GQte2OZ3KbONXvPakaNH4dQ5G7tHIZyCNaJ5eh5QbGoOFHhqmD993jppnTciac6L72zsf/Sb/3SDLMCLWaeQqWDUOlOg9ffPRznJnNj1p5mNkTKOFKJsSXnx83xQ5F145PmkXJpNaZMsXNoZAQQlma8TvupMtn8fW08bTvOeWv0LK68NJ4arIy31+F269gADqnAzyyhh8eWA79ltzcMefZ4bwSyrsm7sq+f98huwCd2eVMNI8HITSlXSk5xQZXghkZB6ZYofDC5Opvsqx1ABEtjVb7kZk1IHNqQf2rdzFQV5VBZzggeXr2+PoGSfCHBmaKeQxYiNDQA1jg3TGPL5y1qh4H3uRanu27/EoB6W38dPmNA78Ozu943ag+JQPa3yJo48wNX0YdCs97XvEAlrSHcrirOApWz221SdLtAsmlAt04OjFd3TrkhgrdbIpuxOOnRkudckdQZY2dxKH+9sePkm7enL+PYaMele0Omg9OlODGMjUSYCP//x6qo4n9G6E56zP2BWP9+V/UnT69fPb26vH36ZBQCPqj+wMH6293pQVo71uRcWE9AczaPf4X3XTUj9+CNGKCoJfRTAlcp9sDam9i1J6DQtfO4dbu9LEhvnChA3Nx5JFLX783DPvy9R+WKrDM62Sw/cHEScMRB6YwXpPcN6Sx/nSXhiPDkzUse0aqS81zRvlnd9a+zK57RQFIqCipnpHF33liCslaeK0XbcsJRMlWHuVw8SmroquQs+gclHh64pHP2cTwlbSPfd0tBu9RTBcJWUNqzl37am45zjjnir6e7mq+XegZWYavhBH+Rvnb/3xHrta/DYvN9BFHJatXA8lIgOddmqYUryRefm0bjLR8FdnPpLqjLLqhL04K6kf9G1fjdH//4HwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace CheckoutNetsdk.Orders
{
    /// <summary>
    /// The shipping details.
    /// </summary>
    [DataContract]
    public class ShippingDetails
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ShippingDetails() {}

        /// <summary>
        /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue = false)]
        public PortablePostalAddress(MediumGrained) Address;

        /// <summary>
        /// The name of the party.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public Name Name;
    }
}

