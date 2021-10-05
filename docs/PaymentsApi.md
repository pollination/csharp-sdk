# PollinationSDK.Api.PaymentsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePaymentMethod**](PaymentsApi.md#createpaymentmethod) | **POST** /payments/{account_name}/methods | Add Payment Method
[**CreateSubscription**](PaymentsApi.md#createsubscription) | **POST** /payments/{account_name}/subscription | Create Subscription
[**GetInventory**](PaymentsApi.md#getinventory) | **GET** /payments/inventory | Get Inventory
[**GetSubscription**](PaymentsApi.md#getsubscription) | **GET** /payments/{account_name}/subscription | Get Subscription
[**ListPaymentMethods**](PaymentsApi.md#listpaymentmethods) | **GET** /payments/{account_name}/methods | Get Payment Methods



## CreatePaymentMethod

> PaymentSetup CreatePaymentMethod (string accountName, PaymentCreate paymentCreate)

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
    public class CreatePaymentMethodExample
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
                PaymentSetup result = apiInstance.CreatePaymentMethod(accountName, paymentCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentsApi.CreatePaymentMethod: " + e.Message );
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


## CreateSubscription

> CreatedContent CreateSubscription (string accountName, SubscriptionCreate subscriptionCreate)

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
    public class CreateSubscriptionExample
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
                CreatedContent result = apiInstance.CreateSubscription(accountName, subscriptionCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentsApi.CreateSubscription: " + e.Message );
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


## GetInventory

> Inventory GetInventory ()

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
    public class GetInventoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new PaymentsApi(Configuration.Default);

            try
            {
                // Get Inventory
                Inventory result = apiInstance.GetInventory();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetInventory: " + e.Message );
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


## GetSubscription

> Subscription GetSubscription (string accountName)

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
    public class GetSubscriptionExample
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
                Subscription result = apiInstance.GetSubscription(accountName);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetSubscription: " + e.Message );
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


## ListPaymentMethods

> PaymentMethodList ListPaymentMethods (string accountName)

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
    public class ListPaymentMethodsExample
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
                PaymentMethodList result = apiInstance.ListPaymentMethods(accountName);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentsApi.ListPaymentMethods: " + e.Message );
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

