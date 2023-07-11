# PollinationSDK.Api.SubscriptionPlansApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListSubscriptionPlans**](SubscriptionPlansApi.md#listsubscriptionplans) | **GET** /subscription-plans/ | List Subscription Plans



## ListSubscriptionPlans

> List&lt;SubscriptionPlan&gt; ListSubscriptionPlans (PlanType? planType = null)

List Subscription Plans

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class ListSubscriptionPlansExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new SubscriptionPlansApi(Configuration.Default);
            var planType = ;  // PlanType? | Plan Type (optional) 

            try
            {
                // List Subscription Plans
                List<SubscriptionPlan> result = apiInstance.ListSubscriptionPlans(planType);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubscriptionPlansApi.ListSubscriptionPlans: " + e.Message );
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
 **planType** | **PlanType?**| Plan Type | [optional] 

### Return type

[**List&lt;SubscriptionPlan&gt;**](SubscriptionPlan.md)

### Authorization

No authorization required

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

