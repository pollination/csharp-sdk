# PollinationSDK.Api.PaymentsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPaymentMethodPaymentsAccountNameMethodsPost**](PaymentsApi.md#addpaymentmethodpaymentsaccountnamemethodspost) | **POST** /payments/{account_name}/methods | Add Payment Method
[**CreateSubscriptionPaymentsAccountNameSubscriptionPost**](PaymentsApi.md#createsubscriptionpaymentsaccountnamesubscriptionpost) | **POST** /payments/{account_name}/subscription | Create Subscription
[**GetInventoryPaymentsInventoryGet**](PaymentsApi.md#getinventorypaymentsinventoryget) | **GET** /payments/inventory | Get Inventory
[**GetPaymentMethodsPaymentsAccountNameMethodsGet**](PaymentsApi.md#getpaymentmethodspaymentsaccountnamemethodsget) | **GET** /payments/{account_name}/methods | Get Payment Methods
[**GetSubscriptionPaymentsAccountNameSubscriptionGet**](PaymentsApi.md#getsubscriptionpaymentsaccountnamesubscriptionget) | **GET** /payments/{account_name}/subscription | Get Subscription



## AddPaymentMethodPaymentsAccountNameMethodsPost

> PaymentSetup AddPaymentMethodPaymentsAccountNameMethodsPost (string accountName, PaymentCreate paymentCreate)

Add Payment Method

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class AddPaymentMethodPaymentsAccountNameMethodsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: APIKeyAuth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";
            // Configure OAuth2 access token for authorization: JWTAuth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";

            var apiInstance = new PaymentsApi(Configuration.Default);
            var accountName = accountName_example;  // string | 
            var paymentCreate = new PaymentCreate(); // PaymentCreate | 

            try
            {
                // Add Payment Method
                PaymentSetup result = apiInstance.AddPaymentMethodPaymentsAccountNameMethodsPost(accountName, paymentCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentsApi.AddPaymentMethodPaymentsAccountNameMethodsPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountName** | **string**|  | 
 **paymentCreate** | [**PaymentCreate**](PaymentCreate.md)|  | 

### Return type

[**PaymentSetup**](PaymentSetup.md)

### Authorization

[APIKeyAuth](../README.md#APIKeyAuth), [JWTAuth](../README.md#JWTAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateSubscriptionPaymentsAccountNameSubscriptionPost

> CreatedContent CreateSubscriptionPaymentsAccountNameSubscriptionPost (string accountName, SubscriptionCreate subscriptionCreate)

Create Subscription

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class CreateSubscriptionPaymentsAccountNameSubscriptionPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: APIKeyAuth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";
            // Configure OAuth2 access token for authorization: JWTAuth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";

            var apiInstance = new PaymentsApi(Configuration.Default);
            var accountName = accountName_example;  // string | 
            var subscriptionCreate = new SubscriptionCreate(); // SubscriptionCreate | 

            try
            {
                // Create Subscription
                CreatedContent result = apiInstance.CreateSubscriptionPaymentsAccountNameSubscriptionPost(accountName, subscriptionCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentsApi.CreateSubscriptionPaymentsAccountNameSubscriptionPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountName** | **string**|  | 
 **subscriptionCreate** | [**SubscriptionCreate**](SubscriptionCreate.md)|  | 

### Return type

[**CreatedContent**](CreatedContent.md)

### Authorization

[APIKeyAuth](../README.md#APIKeyAuth), [JWTAuth](../README.md#JWTAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetInventoryPaymentsInventoryGet

> Inventory GetInventoryPaymentsInventoryGet ()

Get Inventory

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class GetInventoryPaymentsInventoryGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new PaymentsApi(Configuration.Default);

            try
            {
                // Get Inventory
                Inventory result = apiInstance.GetInventoryPaymentsInventoryGet();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetInventoryPaymentsInventoryGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**Inventory**](Inventory.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPaymentMethodsPaymentsAccountNameMethodsGet

> PaymentMethodList GetPaymentMethodsPaymentsAccountNameMethodsGet (string accountName)

Get Payment Methods

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class GetPaymentMethodsPaymentsAccountNameMethodsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: APIKeyAuth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";
            // Configure OAuth2 access token for authorization: JWTAuth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";

            var apiInstance = new PaymentsApi(Configuration.Default);
            var accountName = accountName_example;  // string | 

            try
            {
                // Get Payment Methods
                PaymentMethodList result = apiInstance.GetPaymentMethodsPaymentsAccountNameMethodsGet(accountName);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetPaymentMethodsPaymentsAccountNameMethodsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountName** | **string**|  | 

### Return type

[**PaymentMethodList**](PaymentMethodList.md)

### Authorization

[APIKeyAuth](../README.md#APIKeyAuth), [JWTAuth](../README.md#JWTAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSubscriptionPaymentsAccountNameSubscriptionGet

> Subscription GetSubscriptionPaymentsAccountNameSubscriptionGet (string accountName)

Get Subscription

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class GetSubscriptionPaymentsAccountNameSubscriptionGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: APIKeyAuth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";
            // Configure OAuth2 access token for authorization: JWTAuth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";

            var apiInstance = new PaymentsApi(Configuration.Default);
            var accountName = accountName_example;  // string | 

            try
            {
                // Get Subscription
                Subscription result = apiInstance.GetSubscriptionPaymentsAccountNameSubscriptionGet(accountName);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetSubscriptionPaymentsAccountNameSubscriptionGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountName** | **string**|  | 

### Return type

[**Subscription**](Subscription.md)

### Authorization

[APIKeyAuth](../README.md#APIKeyAuth), [JWTAuth](../README.md#JWTAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

