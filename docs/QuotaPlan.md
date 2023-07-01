
# PollinationSDK.Model.QuotaPlan

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | The description | [optional] 
**DisplayName** | **string** | The human-readable name | [optional] 
**Enforced** | **bool** | Whether the limit is triggers a blocking response from the server | [optional] [default to false]
**Limit** | **double** | The maximum amount of a resource that a subscription allows | [optional] 
**MaxLimit** | **double** | The maximum amount of a resource that a subscription allows | [optional] 
**Resets** | **bool** | Whether consumption is reset to 0 every month | [optional] [default to false]
**Type** | **QuotaType** | The name of the quota | [readonly] 
**Unit** | **string** | The unit in which the usage and limit are measured | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

