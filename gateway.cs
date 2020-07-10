BraintreeGateway gateway = new BraintreeGateway(access_token$sandbox$59yr785rb2vgqqq2$f6a81d76e015ed93e5bd108a95c42a02);

// You can create a transaction using a PaymentMethodNonce and an Amount
TransactionRequest request = new TransactionRequest
{
    Amount = 1000.0M,
    MerchantAccountId = "USD",
    PaymentMethodNonce = Request.Form["payment_method_nonce"],
    OrderID = "Mapped to PayPal Invoice Number",
    Descriptor = new DescriptorRequest
    {
      Name = "Descriptor displayed in customer CC statements. 22 char max"
    },
    ShippingAddress = new AddressRequest
    {
        FirstName = "Jen",
        LastName = "Smith",
        Company = "Braintree",
        StreetAddress = "1 E 1st St",
        ExtendedAddress = "Suite 403",
        Locality = "Bartlett",
        Region = "IL",
        PostalCode = "60103",
        CountryCodeAlpha2 = "US"
    },
    Options = new TransactionOptionsRequest
    {
      PayPal = new TransactionOptionsPayPalRequest
      {
        CustomField = "PayPal custom field",
        Description = "Description for PayPal email receipt",
      },
      SubmitForSettlement = true
    }
};

Result<Transaction> result = gateway.Transaction.Sale(request);

if (result.IsSuccess())
{
    System.Console.WriteLine("Transaction ID: " + transaction.Id);
}
else
{
    System.Console.WriteLine(result.Message);
}
