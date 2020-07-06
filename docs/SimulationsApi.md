# PollinationSDK.Api.SimulationsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSimulation**](SimulationsApi.md#createsimulation) | **POST** /projects/{owner}/{name}/simulations | Schedule a simulation
[**GetSimulation**](SimulationsApi.md#getsimulation) | **GET** /projects/{owner}/{name}/simulations/{simulation_id} | Get a Simulation
[**GetSimulationInputs**](SimulationsApi.md#getsimulationinputs) | **GET** /projects/{owner}/{name}/simulations/{simulation_id}/inputs | Get simulation inputs
[**GetSimulationLogs**](SimulationsApi.md#getsimulationlogs) | **GET** /projects/{owner}/{name}/simulations/{simulation_id}/logs | Get simulation logs
[**GetSimulationOutputs**](SimulationsApi.md#getsimulationoutputs) | **GET** /projects/{owner}/{name}/simulations/{simulation_id}/outputs | Get simulation outputs
[**GetSimulationTaskLogs**](SimulationsApi.md#getsimulationtasklogs) | **GET** /projects/{owner}/{name}/simulations/{simulation_id}/task/{task_id}/logs | Get a simulation task&#39;s logs
[**ListSimulations**](SimulationsApi.md#listsimulations) | **GET** /projects/{owner}/{name}/simulations | List simulations
[**ResumeSimulation**](SimulationsApi.md#resumesimulation) | **PUT** /projects/{owner}/{name}/simulations/{simulation_id}/resume | resume a simulation
[**SuspendSimulation**](SimulationsApi.md#suspendsimulation) | **PUT** /projects/{owner}/{name}/simulations/{simulation_id}/suspend | Suspend a simulation



## CreateSimulation

> CreatedContent CreateSimulation (string owner, string name, SubmitSimulationDto submitSimulationDto, string authorization = null)

Schedule a simulation

Create a new simulation.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class CreateSimulationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Compulsory Auth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";

            var apiInstance = new SimulationsApi(Configuration.Default);
            var owner = owner_example;  // string | 
            var name = name_example;  // string | 
            var submitSimulationDto = new SubmitSimulationDto(); // SubmitSimulationDto | 
            var authorization = authorization_example;  // string |  (optional) 

            try
            {
                // Schedule a simulation
                CreatedContent result = apiInstance.CreateSimulation(owner, name, submitSimulationDto, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SimulationsApi.CreateSimulation: " + e.Message );
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
 **owner** | **string**|  | 
 **name** | **string**|  | 
 **submitSimulationDto** | [**SubmitSimulationDto**](SubmitSimulationDto.md)|  | 
 **authorization** | **string**|  | [optional] 

### Return type

[**CreatedContent**](CreatedContent.md)

### Authorization

[Compulsory Auth](../README.md#Compulsory Auth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSimulation

> SimulationStatus GetSimulation (string owner, string name, string simulationId)

Get a Simulation

Retrieve a simulation.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class GetSimulationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Optional Auth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";

            var apiInstance = new SimulationsApi(Configuration.Default);
            var owner = owner_example;  // string | 
            var name = name_example;  // string | 
            var simulationId = simulationId_example;  // string | 

            try
            {
                // Get a Simulation
                SimulationStatus result = apiInstance.GetSimulation(owner, name, simulationId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SimulationsApi.GetSimulation: " + e.Message );
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
 **owner** | **string**|  | 
 **name** | **string**|  | 
 **simulationId** | **string**|  | 

### Return type

[**SimulationStatus**](SimulationStatus.md)

### Authorization

[Optional Auth](../README.md#Optional Auth)

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


## GetSimulationInputs

> Object GetSimulationInputs (string owner, string name, string simulationId)

Get simulation inputs

get simulation inputs

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class GetSimulationInputsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Optional Auth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";

            var apiInstance = new SimulationsApi(Configuration.Default);
            var owner = owner_example;  // string | 
            var name = name_example;  // string | 
            var simulationId = simulationId_example;  // string | 

            try
            {
                // Get simulation inputs
                Object result = apiInstance.GetSimulationInputs(owner, name, simulationId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SimulationsApi.GetSimulationInputs: " + e.Message );
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
 **owner** | **string**|  | 
 **name** | **string**|  | 
 **simulationId** | **string**|  | 

### Return type

**Object**

### Authorization

[Optional Auth](../README.md#Optional Auth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Access forbidden |  -  |
| **500** | Server error |  -  |
| **400** | Invalid request |  -  |
| **404** | Not found |  -  |
| **200** | Retrieved |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSimulationLogs

> Object GetSimulationLogs (string owner, string name, string simulationId)

Get simulation logs

get simulation logs

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class GetSimulationLogsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Optional Auth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";

            var apiInstance = new SimulationsApi(Configuration.Default);
            var owner = owner_example;  // string | 
            var name = name_example;  // string | 
            var simulationId = simulationId_example;  // string | 

            try
            {
                // Get simulation logs
                Object result = apiInstance.GetSimulationLogs(owner, name, simulationId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SimulationsApi.GetSimulationLogs: " + e.Message );
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
 **owner** | **string**|  | 
 **name** | **string**|  | 
 **simulationId** | **string**|  | 

### Return type

**Object**

### Authorization

[Optional Auth](../README.md#Optional Auth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Access forbidden |  -  |
| **500** | Server error |  -  |
| **400** | Invalid request |  -  |
| **404** | Not found |  -  |
| **200** | Retrieved |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSimulationOutputs

> Object GetSimulationOutputs (string owner, string name, string simulationId)

Get simulation outputs

get simulation outputs

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class GetSimulationOutputsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Optional Auth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";

            var apiInstance = new SimulationsApi(Configuration.Default);
            var owner = owner_example;  // string | 
            var name = name_example;  // string | 
            var simulationId = simulationId_example;  // string | 

            try
            {
                // Get simulation outputs
                Object result = apiInstance.GetSimulationOutputs(owner, name, simulationId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SimulationsApi.GetSimulationOutputs: " + e.Message );
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
 **owner** | **string**|  | 
 **name** | **string**|  | 
 **simulationId** | **string**|  | 

### Return type

**Object**

### Authorization

[Optional Auth](../README.md#Optional Auth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Access forbidden |  -  |
| **500** | Server error |  -  |
| **400** | Invalid request |  -  |
| **404** | Not found |  -  |
| **200** | Retrieved |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSimulationTaskLogs

> string GetSimulationTaskLogs (string owner, string name, string simulationId, string taskId)

Get a simulation task's logs

get simulation task logs

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class GetSimulationTaskLogsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Optional Auth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";

            var apiInstance = new SimulationsApi(Configuration.Default);
            var owner = owner_example;  // string | 
            var name = name_example;  // string | 
            var simulationId = simulationId_example;  // string | 
            var taskId = taskId_example;  // string | 

            try
            {
                // Get a simulation task's logs
                string result = apiInstance.GetSimulationTaskLogs(owner, name, simulationId, taskId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SimulationsApi.GetSimulationTaskLogs: " + e.Message );
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
 **owner** | **string**|  | 
 **name** | **string**|  | 
 **simulationId** | **string**|  | 
 **taskId** | **string**|  | 

### Return type

**string**

### Authorization

[Optional Auth](../README.md#Optional Auth)

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


## ListSimulations

> SimulationList ListSimulations (string owner, string name, int page = null, int perPage = null, List<string> id = null, List<string> status = null)

List simulations

Retrieve a list of simulations.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class ListSimulationsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Optional Auth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";

            var apiInstance = new SimulationsApi(Configuration.Default);
            var owner = owner_example;  // string | 
            var name = name_example;  // string | 
            var page = 56;  // int | Page number starting from 1 (optional)  (default to 1)
            var perPage = 56;  // int | Number of items per page (optional)  (default to 25)
            var id = new List<string>(); // List<string> | The ID of a simulation to search for (optional) 
            var status = new List<string>(); // List<string> | The status of the simulation to filter by (optional) 

            try
            {
                // List simulations
                SimulationList result = apiInstance.ListSimulations(owner, name, page, perPage, id, status);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SimulationsApi.ListSimulations: " + e.Message );
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
 **owner** | **string**|  | 
 **name** | **string**|  | 
 **page** | **int**| Page number starting from 1 | [optional] [default to 1]
 **perPage** | **int**| Number of items per page | [optional] [default to 25]
 **id** | [**List&lt;string&gt;**](string.md)| The ID of a simulation to search for | [optional] 
 **status** | [**List&lt;string&gt;**](string.md)| The status of the simulation to filter by | [optional] 

### Return type

[**SimulationList**](SimulationList.md)

### Authorization

[Optional Auth](../README.md#Optional Auth)

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


## ResumeSimulation

> Accepted ResumeSimulation (string owner, string name, string simulationId)

resume a simulation

resume a simulation

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class ResumeSimulationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Compulsory Auth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";

            var apiInstance = new SimulationsApi(Configuration.Default);
            var owner = owner_example;  // string | 
            var name = name_example;  // string | 
            var simulationId = simulationId_example;  // string | 

            try
            {
                // resume a simulation
                Accepted result = apiInstance.ResumeSimulation(owner, name, simulationId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SimulationsApi.ResumeSimulation: " + e.Message );
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
 **owner** | **string**|  | 
 **name** | **string**|  | 
 **simulationId** | **string**|  | 

### Return type

[**Accepted**](Accepted.md)

### Authorization

[Compulsory Auth](../README.md#Compulsory Auth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SuspendSimulation

> Accepted SuspendSimulation (string owner, string name, string simulationId)

Suspend a simulation

Suspend a simulation.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class SuspendSimulationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Compulsory Auth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";

            var apiInstance = new SimulationsApi(Configuration.Default);
            var owner = owner_example;  // string | 
            var name = name_example;  // string | 
            var simulationId = simulationId_example;  // string | 

            try
            {
                // Suspend a simulation
                Accepted result = apiInstance.SuspendSimulation(owner, name, simulationId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SimulationsApi.SuspendSimulation: " + e.Message );
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
 **owner** | **string**|  | 
 **name** | **string**|  | 
 **simulationId** | **string**|  | 

### Return type

[**Accepted**](Accepted.md)

### Authorization

[Compulsory Auth](../README.md#Compulsory Auth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

