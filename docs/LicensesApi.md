# PollinationSDK.Api.LicensesApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAvailablePools**](LicensesApi.md#getavailablepools) | **GET** /licenses/pools | Get Available Pools
[**GetPoolLicense**](LicensesApi.md#getpoollicense) | **GET** /licenses/pools/{pool_id}/license | Get Pool License
[**GrantAccessToPool**](LicensesApi.md#grantaccesstopool) | **PATCH** /licenses/pools/{pool_id}/permissions | Grant Pool Access
[**RevokeAccessToPool**](LicensesApi.md#revokeaccesstopool) | **DELETE** /licenses/pools/{pool_id}/permissions | Delete Pool Access



## GetAvailablePools

> AnyType GetAvailablePools (List<string> owner = null)

Get Available Pools

Get license pools available to authenticated user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class GetAvailablePoolsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: APIKeyAuth
            Configuration.Default.AddApiKey("x-pollination-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-pollination-token", "Bearer");
            // Configure HTTP bearer authorization: JWTAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicensesApi(Configuration.Default);
            var owner = new List<string>(); // List<string> | Owner of the project (optional) 

            try
            {
                // Get Available Pools
                AnyType result = apiInstance.GetAvailablePools(owner);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LicensesApi.GetAvailablePools: " + e.Message );
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
 **owner** | [**List&lt;string&gt;**](string.md)| Owner of the project | [optional] 

### Return type

[**AnyType**](AnyType.md)

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


## GetPoolLicense

> LicensePublic GetPoolLicense (Guid poolId)

Get Pool License

Get the license associated with a pool

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class GetPoolLicenseExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: APIKeyAuth
            Configuration.Default.AddApiKey("x-pollination-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-pollination-token", "Bearer");
            // Configure HTTP bearer authorization: JWTAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicensesApi(Configuration.Default);
            var poolId = new Guid(); // Guid | 

            try
            {
                // Get Pool License
                LicensePublic result = apiInstance.GetPoolLicense(poolId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LicensesApi.GetPoolLicense: " + e.Message );
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
 **poolId** | [**Guid**](Guid.md)|  | 

### Return type

[**LicensePublic**](LicensePublic.md)

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


## GrantAccessToPool

> LicensePoolPublic GrantAccessToPool (Guid poolId, LicensePoolAccessPolicy licensePoolAccessPolicy)

Grant Pool Access

Grant access to the license pool

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class GrantAccessToPoolExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: APIKeyAuth
            Configuration.Default.AddApiKey("x-pollination-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-pollination-token", "Bearer");
            // Configure HTTP bearer authorization: JWTAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicensesApi(Configuration.Default);
            var poolId = new Guid(); // Guid | 
            var licensePoolAccessPolicy = new LicensePoolAccessPolicy(); // LicensePoolAccessPolicy | 

            try
            {
                // Grant Pool Access
                LicensePoolPublic result = apiInstance.GrantAccessToPool(poolId, licensePoolAccessPolicy);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LicensesApi.GrantAccessToPool: " + e.Message );
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
 **poolId** | [**Guid**](Guid.md)|  | 
 **licensePoolAccessPolicy** | [**LicensePoolAccessPolicy**](LicensePoolAccessPolicy.md)|  | 

### Return type

[**LicensePoolPublic**](LicensePoolPublic.md)

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


## RevokeAccessToPool

> LicensePoolPublic RevokeAccessToPool (Guid poolId, LicensePoolPolicySubject licensePoolPolicySubject)

Delete Pool Access

Revoke access to the license pool

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class RevokeAccessToPoolExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: APIKeyAuth
            Configuration.Default.AddApiKey("x-pollination-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-pollination-token", "Bearer");
            // Configure HTTP bearer authorization: JWTAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicensesApi(Configuration.Default);
            var poolId = new Guid(); // Guid | 
            var licensePoolPolicySubject = new LicensePoolPolicySubject(); // LicensePoolPolicySubject | 

            try
            {
                // Delete Pool Access
                LicensePoolPublic result = apiInstance.RevokeAccessToPool(poolId, licensePoolPolicySubject);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LicensesApi.RevokeAccessToPool: " + e.Message );
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
 **poolId** | [**Guid**](Guid.md)|  | 
 **licensePoolPolicySubject** | [**LicensePoolPolicySubject**](LicensePoolPolicySubject.md)|  | 

### Return type

[**LicensePoolPublic**](LicensePoolPublic.md)

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

