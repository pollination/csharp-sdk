# PollinationSDK.Api.UsersApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOneUser**](UsersApi.md#getoneuser) | **GET** /users/{name} | Get a specific user profile
[**ListUsers**](UsersApi.md#listusers) | **GET** /users | List Users



## GetOneUser

> UserPublic GetOneUser (string name)

Get a specific user profile

Get a specific user profile by name

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class GetOneUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new UsersApi(Configuration.Default);
            var name = name_example;  // string | 

            try
            {
                // Get a specific user profile
                UserPublic result = apiInstance.GetOneUser(name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UsersApi.GetOneUser: " + e.Message );
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
 **name** | **string**|  | 

### Return type

[**UserPublic**](UserPublic.md)

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


## ListUsers

> UserPublicList ListUsers (string search = null, int? page = null, int? perPage = null)

List Users

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class ListUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new UsersApi(Configuration.Default);
            var search = search_example;  // string | Search string to find users (optional) 
            var page = 56;  // int? | Page number starting from 1 (optional)  (default to 1)
            var perPage = 56;  // int? | Number of items per page (optional)  (default to 25)

            try
            {
                // List Users
                UserPublicList result = apiInstance.ListUsers(search, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UsersApi.ListUsers: " + e.Message );
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
 **search** | **string**| Search string to find users | [optional] 
 **page** | **int?**| Page number starting from 1 | [optional] [default to 1]
 **perPage** | **int?**| Number of items per page | [optional] [default to 25]

### Return type

[**UserPublicList**](UserPublicList.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Retrieved |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

