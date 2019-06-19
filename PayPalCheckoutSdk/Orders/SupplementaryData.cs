// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// SupplementaryData.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/+wcXZPbtvG9v2JHfXA8Q0lxnLrTe7ucnfSa1vG4l2Y6rke3ApYieiBAA+DJTCf/vYMPiqRInRNHUWYSvXgsLD52F/uN5f1vdtNUNLuY2bqqJJWkHJpmxdHhLJv9C43AtaSXWB6c8zU1CTzLZs/JMiMqJ7SaXcxuCoLBGvBrFrNsdmkMNvHkT7PZa0L+jZLN7CJHackPvKuFIb4beGV0RcYJsrOLNzucn09iOcIrDYxxE4rX1plmbitiIhcs4gdfagP0HstKUgYih9t24so1Fd2CsHB7ef3679cvX9xm4AqCWxRGCkUr4YQig0aQvQX0VEJZWwdrgkpXtURHHFBxQClBu4IMVDvawmGomgzQEIiN0ob48di1j2Mz5t0EGQNWTsOHnL1UiXCdQ5oPvfmPApMzEIrJmgu1ASfYHbkMKrSW1IZMFjmU1nJyKKTd48Ozn8+H3XmH+dCf0nGhPzqWqhbv3awDFPyMm7TOCLUZo810rbyYMs1pgPEeYIz0G7fVc1agQebIwPU/v4GnT549mz8Bv+TtJ0uumV0K5Whj0K9bcmGIuaUh65Zp+7mfa5ePwRXoQHBSTuSCbFCRNAe0AUMbodXiP/Wnnz5la6nZ3btaOwq/47/MOqPVJo681I4u4vCyPw43vW390ZBrA18ZQgdfGOFQKK+qcaWHx2VffZH26oaCvCntRnO//XpiroXaEgehAl1OV3NJ9ySB69IfqbAkG1AJbEgILuBbS9FWXH12O0b7qhAKYauN5FuRxpguKzT+fqFWTCtntJTEoTKCEXxy9e2rx1CSKzTPYI3qDhgaHpWHGW3tfK0NJwPOoLLI/LXZxPXlPtt/pmyqWsofsg8LaG2dLslMSOgeZCyinjgotORk5sGrCOKRf04HxpZkWIHKLeAKlbe44Zo8I70qekuTriw39K4m5SCXDRlQdbkm481VkNOEyOI0HOHoaKXz1VoYV+y7rQFkwrc6VHyOUnsric47KwVvrpUjo8iFoSAMTpRBoEp0bz8pnKvsxXLptJZ2IcjlC202y8KVcmly9vTp07/80VIQlvmfFs8eL+BGg6HKkPUsC64SJUjaoIR7lLX3W7ZmhVcMjIfqHALWGTS6BlvoWnJ/GwFqYStcAUoDWquZCC4xoOhVRpQ0/z4RhAv4riBF995LamvF2jvkOulRoN7LxG3glF95C95BL+CmENZbmVqi9+Qedyu0Aq7JBj2/Rykie6SMSO15/S9pbWofsTx94m1ImN9aiSKIkoU7pbcKcK1rB5KwgobQ2CPLTRCGkdSoONoJSxoYy4gHtKJdoXHNL++FUHoB9HeS11KuRrhOw4eoP3/x6vWLq8ubF88XwcwH1B9Z2K0NhO00HWFdW6HI2jCegRLsLv5PGx9SpVgrcCOaZVReENYEtpLCgVBOQy6MdRlItC7t37ICtgWpjon++rszT2Qqprl5mIffTaBckbFaZd3wIwt+h0juaejYiHtSY0IGwx9HSdgiXHm6yRNSVQrOJY3JGo5/HF1xjySSPo5AabV3e9ZpQ1DW0olKUn+e7QfYYSsfOTWlYJE/6PXhkc0Ge5+GU5WhXLwfRtTt0NiARVAWnYPztjm5+5Y5J8Tc1vk+5ruhqdTXg1Ik+Cvha0by2I19nCym9VGISiGbJJaXXiSTS4wR/481o/GUBwU7Hbov1OVQqEvdCnWafxQ2v/3hbY/VbWYYk9bDmeMO3nF+NzQWlZQh7mSlzSHjkuO57H9oRRNpf45mz6nEgYkgvDaGFGtihl76LCYgjZALhSqEhr10ox8ZrlGiYkFwKmxKH0zymk6QFCeUp3KOIWQqLS4M0TAxnn/+2ZM/d4z4Uflxmvxwgpwm/SSOOFN/nGkIkfuAG+3ImAsBksG2EKyAUmwKHzeljLyW/bRdivjrUkHgBZmYyEbSPKVS3BHc/u3Vv28jE9BQiMhdUwmGUjaQmyg7KNtctd117wzgxESJcrdi+qybl897Z9l6zcW94CGBD55E1xYVd4WdPm7ZUvhl0k3T2rIub2wRqSSylPvjUEIysETw5qodu/KC8FPF5hiS0bdlh6wB7RkDOtuCsy0424LftC04JBvC2ppWHN1QQAbD58rU77Ey9ZDECLVZMTRGTJV6D0yYrPj6CbHIm2pYMSKGIH+nqtFG5R7W29qhg+8/84AibxFuDYSB6+dHRnuttSRUY7y94TCCOeJT6cgUdEjNteKCRb0oKNTPBjcA3Q5HpuhAYOJwmHvH3+fA5ByYnAOT311g4gzek1zhZlptJsFjqbm+vLlMPMpi8eny9VXPWF++vlr25sTHiFqJdzUlt7R7P2xrN/FkiCcnJUquwDv/45R0fqQCDbkwqgVOgh9+Q3qIOjomcX0ZSGo6YTYloQmxhDfyQ7u5DxrS5RUlinHXpNJJeOYvlYxguwfmZAeb9ObvUPZUq6tThodlRtCeDoaYNhxKshY3ZPuRZQg2EaxQG0mAtSu0Ed+H84P+knULuKwqKVjoAXC6O4hh5Wrj99ugUNYBquEOC7iOhVaGNlxeOiYtPLgurAm2tI2O1wRPjiyuH77PlpHTV9qDHulWCVlx6NJi24C2kZchGOrXpnerujs2IXzXW+JQkdkx2CtJF3ac/m6zA5cbavdZNE8R2vasSbLe76Pydo7e1T5wiq8vO6qDeh1ZPnLp/fdK0tQr6A62SlXzYbFqCny4Qa1fbN/1xfkU8oj9ZgffyTkXMYZYKe3CDe11201PGFFDimtjQ5NlbK+KYbnX5qTQyS7D3mSWXs9Vsudz5D7maA8Lb+dQ+mTWadPARt+TUWFlF1+kuf0gOshQ2svh+wVcDnAKjz5SlCKdskZLfIdpUwWRztFQf8+UdSSbGSNejg2UQomyLn3O3ZzIqfqs9B7lCoWptBl6nTFsMkH0sBRyoQVOuVDEYd3AGx9sdKWQ7Xa7EOgwFEKqeu3NRRCD5StvaUJb2twSGlYs0FbvH5+YBU7s93YMAWPiPSBrG7GK4qIs4bPP4a8mVYFOhP/B2sQHaxIhGHRbPZfkfK6FLBjAaAk5TSdNcdNT0abVf2sVVC0l9quJAsZDs/YMzC7jV9BbBVEXAVVsrWm7eGMC5vQmVgxKvCOoqy7OCX2MyJxX8sAY3JzqOZxThcZ7yEnVnYL+JpW3I3RU1h2BzqXdc2l3SnJGhn8E+rVN/7nV4VxFPFcRz1XED/TUoqHVGq2wY50ZwyaMhI/5wncG66br2uoVFjBkMjGt8YaEVMj326nWYZ5Hf9kV1pyF0IysYlHN1HL3QckvVUA8t4KcbeXZVp5t5YO2MpbWxnZyMD6WkwgffWblifAx7OZUxeWE50QyvA/51Wk42NBN5l4wWjGJdlgr3IdMJG5xBoQZ3sGkTH3UbgwYPq47VVJhna70/VQxZh8ypkkragsxverLZNtC9zmusOAtrJM+BdSxQoHQHnZuZTg71rNjPTvWoznWt3tfkBzsm+v/kYlhw9weZKK0kl5N2pmBJZ19H/8RDm8EU3XtSN1bb3/4w/8BAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The supplementary data.
    /// </summary>
    [DataContract]
    public class SupplementaryData
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public SupplementaryData() {}

        /// <summary>
        /// The industry-specific data. For example, if `industry_type` is `AIRLINE`, the `airline_itineraries` array must be populated and all other properties, if any, are ignored.
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue = false)]
        public Data Data;

        /// <summary>
        /// The type of industry for which the supplementary data is presented.
        /// </summary>
        [DataMember(Name="industry_type", EmitDefaultValue = false)]
        public string IndustryType;
    }
}

