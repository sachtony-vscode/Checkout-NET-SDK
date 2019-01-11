# REST API SDK for Dotnet V2

![Home Image](homepage.jpg)

__Welcome to PayPal Dotnet SDK__. This repository contains PayPal's Dotnet SDK and samples for REST API.

This is a part of the next major PayPal SDK. It includes a simplified interface to only provide simple model objects and blueprints for HTTP calls. This repo currently contains functionality for PayPal Checkout APIs which includes Orders V2 and Payments V2.

## Prerequisites

.NET 4.0 or later

An environment which supports TLS 1.2 (see the TLS-update site for more information)

## Usage

### Setting up credentials
Get client ID and client secret by going to https://developer.paypal.com/developer/applications and generating a REST API app. Get <b>Client ID</b> and <b>Secret</b> from there.

```dotnet
using CheckoutNetsdk.Core;

public class Credentials {
    static String clientId = "CLIENT-ID";
    static String secret = "CLIENT-SECRET";
    
    // Creating a sandbox environment
    var environment = new SandboxEnvironment(clientId, secret);
    
    // Creating a client for the environment
    var client = new PayPalHttpClient(environment);
}
```

## Examples
### Creating an Order
This will create an order and print order id for the created order

```dotnet
using CheckoutNetsdk.Orders;

public class CreateOrderExample {
    static void main(String[] args){
        
        // Construct a request object and set desired parameters
        // Here, OrdersCreateRequest() creates a POST request to /v2/checkout/orders
        var order = new OrderRequest() {
                Intent = "CAPTURE",
                PurchaseUnits = new List<PurchaseUnitRequest>()
                {
                    new PurchaseUnitRequest()
                    {
                        ReferenceId = "test_ref_id1",
                        Amount = new AmountWithBreakdown()
                        {
                            CurrencyCode = "USD",
                            Value = "100.00"
                        }
                    }
                }, 
                ApplicationContext = new ApplicationContext()
                {
                    ReturnUrl = "https://www.example.com",
                    CancelUrl = "https://www.example.com"
                }
            };
        
        
            // Call API with your client and get a response for your call
            var request = new OrdersCreateRequest();
            request.Prefer("return=representation");
            request.RequestBody(order);
            try 
            {
              HttpResponse response = await client().Execute(request);
              var statusCode = response.StatusCode;
              Order result = response.Result<Payment>();
            } 
            catch(HttpException httpException) 
            {
              var statusCode = httpException.StatusCode;
              var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();
            }
    }
}
```

### Capturing an Order
This will capture an order
```dotnet
using CheckoutNetsdk.Orders;

public class CaptureOrderExample {
    static void main(String[] args){
        
            // Construct a request object and set desired parameters
            // Here, OrdersCaptureRequest() creates a POST request to /v2/checkout/orders
            // Replace ORDER-ID with the order id from create order
            var request = new OrdersCaptureRequest("ORDER-ID");
            
            request.RequestBody(order);
            try 
            {
              HttpResponse response = await client().Execute(request);
              var statusCode = response.StatusCode;
              Order result = response.Result<Payment>();
            } 
            catch(HttpException httpException) 
            {
              var statusCode = httpException.StatusCode;
              var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();
            }
    }
}
```
## Running tests

To run integration tests using your client id and secret, run the `test` gradle command with the `-Pintegration` flag
```sh
$ dotnet test -v normal
```

You may use the client id and secret above for demonstration purposes.


*NOTE*: This SDK is still in beta, is subject to change, and should not be used in production.

## Samples

You can start off by trying out [creating and capturing an order](/Samples/CaptureIntentExamples/RunAll.java).

To try out different samples for both create and authorize intent head to [this link](/Samples).
