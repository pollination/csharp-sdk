# PollinationSDK.Api.SubscriptionsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSubscription**](SubscriptionsApi.md#createsubscription) | **POST** /subscriptions/ | Cython Function Or Method
[**GetSubscription**](SubscriptionsApi.md#getsubscription) | **GET** /subscriptions/{subscription_id} | Cython Function Or Method
[**ListPollinationSubscriptions**](SubscriptionsApi.md#listpollinationsubscriptions) | **GET** /subscriptions/ | Cython Function Or Method
[**ListSubscriptionPayments**](SubscriptionsApi.md#listsubscriptionpayments) | **GET** /subscriptions/{subscription_id}/payments | Cython Function Or Method
[**ListSubscriptionQuotas**](SubscriptionsApi.md#listsubscriptionquotas) | **GET** /subscriptions/{subscription_id}/quotas | Cython Function Or Method
[**UpdateSubscription**](SubscriptionsApi.md#updatesubscription) | **PUT** /subscriptions/{subscription_id} | Cython Function Or Method
[**UpdateSubscriptionPreivew**](SubscriptionsApi.md#updatesubscriptionpreivew) | **PUT** /subscriptions/{subscription_id}/preview | Cython Function Or Method



## CreateSubscription

> PayLink CreateSubscription (SubscriptionCreate subscriptionCreate)

Cython Function Or Method

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

            var apiInstance = new SubscriptionsApi(Configuration.Default);
            var subscriptionCreate = new SubscriptionCreate(); // SubscriptionCreate | 

            try
            {
                // Cython Function Or Method
                PayLink result = apiInstance.CreateSubscription(subscriptionCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.CreateSubscription: " + e.Message );
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
 **subscriptionCreate** | [**SubscriptionCreate**](SubscriptionCreate.md)|  | 

### Return type

[**PayLink**](PayLink.md)

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


## GetSubscription

> Subscription GetSubscription (Guid subscriptionId)

Cython Function Or Method

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

            var apiInstance = new SubscriptionsApi(Configuration.Default);
            var subscriptionId = new Guid(); // Guid | 

            try
            {
                // Cython Function Or Method
                Subscription result = apiInstance.GetSubscription(subscriptionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GetSubscription: " + e.Message );
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
 **subscriptionId** | [**Guid**](Guid.md)|  | 

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


## ListPollinationSubscriptions

> List&lt;Subscription&gt; ListPollinationSubscriptions (string account = null)

Cython Function Or Method

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class ListPollinationSubscriptionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: APIKeyAuth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";
            // Configure OAuth2 access token for authorization: JWTAuth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";

            var apiInstance = new SubscriptionsApi(Configuration.Default);
            var account = account_example;  // string |  (optional) 

            try
            {
                // Cython Function Or Method
                List<Subscription> result = apiInstance.ListPollinationSubscriptions(account);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.ListPollinationSubscriptions: " + e.Message );
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
 **account** | **string**|  | [optional] 

### Return type

[**List&lt;Subscription&gt;**](Subscription.md)

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


## ListSubscriptionPayments

> List&lt;Payment&gt; ListSubscriptionPayments (Guid subscriptionId)

Cython Function Or Method

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class ListSubscriptionPaymentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: APIKeyAuth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";
            // Configure OAuth2 access token for authorization: JWTAuth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";

            var apiInstance = new SubscriptionsApi(Configuration.Default);
            var subscriptionId = new Guid(); // Guid | 

            try
            {
                // Cython Function Or Method
                List<Payment> result = apiInstance.ListSubscriptionPayments(subscriptionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.ListSubscriptionPayments: " + e.Message );
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
 **subscriptionId** | [**Guid**](Guid.md)|  | 

### Return type

[**List&lt;Payment&gt;**](Payment.md)

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


## ListSubscriptionQuotas

> List&lt;Quota&gt; ListSubscriptionQuotas (Guid subscriptionId)

Cython Function Or Method

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class ListSubscriptionQuotasExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: APIKeyAuth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";
            // Configure OAuth2 access token for authorization: JWTAuth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";

            var apiInstance = new SubscriptionsApi(Configuration.Default);
            var subscriptionId = new Guid(); // Guid | 

            try
            {
                // Cython Function Or Method
                List<Quota> result = apiInstance.ListSubscriptionQuotas(subscriptionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.ListSubscriptionQuotas: " + e.Message );
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
 **subscriptionId** | [**Guid**](Guid.md)|  | 

### Return type

[**List&lt;Quota&gt;**](Quota.md)

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


## UpdateSubscription

> Subscription UpdateSubscription (Guid subscriptionId, SubscriptionUpdate subscriptionUpdate)

Cython Function Or Method

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class UpdateSubscriptionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: APIKeyAuth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";
            // Configure OAuth2 access token for authorization: JWTAuth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";

            var apiInstance = new SubscriptionsApi(Configuration.Default);
            var subscriptionId = new Guid(); // Guid | 
            var subscriptionUpdate = new SubscriptionUpdate(); // SubscriptionUpdate | 

            try
            {
                // Cython Function Or Method
                Subscription result = apiInstance.UpdateSubscription(subscriptionId, subscriptionUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.UpdateSubscription: " + e.Message );
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
 **subscriptionId** | [**Guid**](Guid.md)|  | 
 **subscriptionUpdate** | [**SubscriptionUpdate**](SubscriptionUpdate.md)|  | 

### Return type

[**Subscription**](Subscription.md)

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


## UpdateSubscriptionPreivew

> SubscriptionUpdateDryRun UpdateSubscriptionPreivew (Guid subscriptionId, SubscriptionUpdate subscriptionUpdate)

Cython Function Or Method

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class UpdateSubscriptionPreivewExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: APIKeyAuth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";
            // Configure OAuth2 access token for authorization: JWTAuth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";

            var apiInstance = new SubscriptionsApi(Configuration.Default);
            var subscriptionId = new Guid(); // Guid | 
            var subscriptionUpdate = new SubscriptionUpdate(); // SubscriptionUpdate | 

            try
            {
                // Cython Function Or Method
                SubscriptionUpdateDryRun result = apiInstance.UpdateSubscriptionPreivew(subscriptionId, subscriptionUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.UpdateSubscriptionPreivew: " + e.Message );
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
 **subscriptionId** | [**Guid**](Guid.md)|  | 
 **subscriptionUpdate** | [**SubscriptionUpdate**](SubscriptionUpdate.md)|  | 

### Return type

[**SubscriptionUpdateDryRun**](SubscriptionUpdateDryRun.md)

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

