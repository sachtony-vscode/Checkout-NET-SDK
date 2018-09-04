// This class was generated on Tue, 04 Sep 2018 12:18:45 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// PaymentSource.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/8xa33PbNhJ+v79iR324eEY/YqvN9fzmKtc0bZN6asc3mVzGWpIrcccgwAKgZeam//vNAqQkmlISJz5NX1ILi1/f7reLD2D/O7isSxqcDs6xLkh7uDCVTWkwHFyhZUwUvcZC7IPh4BeqNz+ek0stl56NHpwOLnOCspnBhRkgowVrFvt4MBycWYt1XOrpcPA7YfabVvXgdIHKkTT8UbGlbN1wbk1J1jO5wem79SZnaLP+1tLYutle07B/i9IBvIHKkfxnUekMsLWOYYYaEgKE1FLGHoyFjBKO4x4PzVmWWXIOzo31AqePbEePDcqElWK9vMbYaTfgZiCw9mQ1igkVlMZ5VNCMHMMrLJ044l2z4BUqzkLnV+QxQ4/vn+Tel+50Mlmyz6tknJpisjRmqYiPv9cTxUkzG+uy8pMV3/Bk72xHgDqDny5f/QrfjY/h3VnlzSLCgYWxBaRGe2uUOwWfE2DlTWqKUpEnQO8tJ5WnzZZWq9V4NR0bu5xc/j7JfaG+O544SkcylxtLwze4WSI0j9olRj6n0fYKo/UKR48f6+fkkZXrh7rx3nW27rCJdN/Wj7Q2erSONmYZN6FuxkIzFnyOHtASOFOQ54IcaKKMMnE8BB8w6pSGYNndDIX7xudkwaWk0bJxsMrJEixY02hpkfV6Ddbi2RBpKHiZe8miOPsYXhu/oeOKfS6LFUaDz9lmUKL1daCFKUnHGjKG3ymrdIbatyPCwqQyN4YfjQW6QwnaEOatj9olxm2DYk3Xx3NgB5WrUKlaEtsUCcd0ALPYjG68NHbeEvlrXRUJ2XnY1rxtw4K6Lb4uaf54VHHesl72GZJUrDJJeNlBtxLcs3TZcQbSnIEyaQDccMBSacmR9i7kWGmpYEdjeLN2UjttGC9EiO6AwBOlKG3d13Z0MUrYRrY77l7E/lM9fTpNU5NR+ItmFm9Jw0+mcrElnWyMX+tdXSn15/CTLs5I8S3Z+tqRveW06+Udxn4atp2g6TSGc+M8mMWCU4LE3A0hwWXjkZBd5ZZdHHYgqFts7qDstvcBRnvcKfxcOQ/z57ay9RxYN3/Cr6i/PiEeiCM4dCeS1rIfS6TnQfcrNWPXbpv2vXsV+71EkrSpaAiJqRTdos2GYA1mgVx0J0nuVlgfCl6VXLfloIuva+gDXLB1fmRsRhZIe/Y1JKTMCrCpX+tyZOy6lu0sZa5KRjvKmWO9VLSZRmqVHF4PKGZb0nCh0A/BeWPrISyUMVbcborgdpTTLGjJx/D6+8/we/e026ke1qY9vgfpIB4IkquVhh2qbQ6ASMf7h/DxP6awXQKgBRfEhSg/Ca2N5/xGa4SfIjcgzSm9EUEqhUUUmsgL2c+iUhu9ehgqd/x2st+lJ7vzlVKjs8/wqavYU4c0hy1IHSzT/TCnO2FG8bYD5RB4sdZ+3XrV1rIouANioccPFj+wGkLGtslGT3eSY1WaAzqYa7rzckv5N6oCrZ/HVAOFOivQ3sgBhBpe6oxRH5wrBetrtIS95OsY+g7MeZmTJB/dkgqlK+NbdgK/KU6VZMwQVjmneVfFltbcctDqzqOn4I+XF7+NpsfPno1OZLJ2rhCCAqOjm9tfK1XuJ/HsLMpbbTzMZ6h4YaxmnI/hClU4aOrNrtidRrFWqajU4i/F8debX8ZwFnvX40bVtbZ7PS+kZ8Dx8Y4z1JihdG7hf7z/z1iijt1pQamv7CcGXKzYfyArtJJhN6i90buHTFrUB2fZyT6WnezQ/yn7egjerHSgyC0rhUsaw0WBSpGVQ1TLHWg9SSDj9fH88Nkz3YdrugOXZIsoARXwuSqpbDIETbzME2NzY6IIylgWTv0nAZ+0HP8UrWOpGsNFs2SCbK0Ji22v/nGehUIV5liDuLfbjdTuXK3ZhdxEtcLaAd4iq3CpTiovxXXPfJC20iXeT8QVIOD/atT+dh8Fvt398NEJ9yro34cEfTqX7nPRp63bPpcG8YUtFFNnrBdRKVfWKEpDpaZMqviLiqx2FGVPgbqGHy3pNAdP1rI3lsltzrnG9qJi1PhxCkXt1r7DUAYBnSBHz7cUDxUnW5jlrP8akW6OjmvxVPfVtmvoR/qdX5lRmqPF1FM46SCcdMfB6++fTDKTuglrT0sbMmUSpcTEkvOTZvqR9HWToyZImVw1Fkzx5tD0EUJYWvK67CfKpDd/VMbTtuOct0YvY8tr46nhymS7HS63pg3kkBP4hSX08IPloG/Z9R5DXvzQewJZn8n3+775ZUffDfkElzflKAqMzBSypNQUF7YS3NBsUG5LFAbMZyfz/rYDiWBlrMpW3LSJiEMb6k+lmzdVRRmUllOCJ7M350dQkM8lORPUN+ENfRgvANY4N0rilc9b1A6D7nMtT++7/SEE9bb6Mn7GhO7Ts9u+66k9FAKxb4k1ceYHLqMPRWb9UfEtqvCZ4bIuOQ1Szm5fk6LbhZLNBXRr5qB4dWeWCyJ4t9Vl8yxOerziGy5Jzhljl/FR/nyD4+hg11MJev/NY7u179DwkUaTXxl7I7gTGxVZWaqQr6b5PDOMH2eGsOSFj8za/s5zqCsA3ZVs6w6+dVMfXE1o43FgtM+Hkqii3L9/9vQY5m/fvn07evVqLjfmkGUFtoF+Gb7jkI8mmcBz0fbZhN4bo9yYyS9C4HNfqIldpNPp9J/fuHi7Gn03fvYwAnxxSnH38xzv/jh3jvU5qtGSNFn0lMHL502Fokf58PaZm1Xo/HXGS/bdjzDd9v72xQ7R3l6Ft2l4oN333nP3PuSG9MqNysj+3UWRiQ7YA5YloXVg9KFdv+MR9yOvt6XlAm0NmIaK2T5OPTk/e320Js4Xh+CLye4orSz7HQLnvmXXa4olGkmxW5jKjgKboB3WHACLTVTgTDkDN9qstMRO2mdXV0OYXc3kn9fyz7+CGp69fP7otf7S3JDu4/dN8wZ327IDr1j4A2X3/+eB/kf5//vnta8vUgHNYUjWO0r3nqKNi5uPskGIRc23ajWiN9DCCTAeSJU9GN7/+f7Pv/0PAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace CheckoutNetsdk.Orders
{
    /// <summary>
    /// The payment source definition.
    /// </summary>
    [DataContract]
    public class PaymentSource
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentSource() {}

        /// <summary>
        /// The payment card to use to fund a payment. Can be a credit or debit card.
        /// </summary>
        [DataMember(Name="card", EmitDefaultValue = false)]
        public Card Card;

        /// <summary>
        /// The tokenized payment source to fund a payment.
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue = false)]
        public Token Token;
    }
}

