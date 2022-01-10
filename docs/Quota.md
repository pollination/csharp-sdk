
# PollinationSDK.Model.Quota

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **QuotaType** | The type of resource | [readonly] 
**Owner** | [**AccountPublic**](AccountPublic.md) | The quota owner | 
**Id** | **Guid** | The unique ID for this Quota | [optional] 
**PeriodStart** | **DateTime** | The start of the quota usage tracking period | [optional] 
**Limit** | **double** | The maximum amount of a resource the account can consume | [optional] 
**Usage** | **double** | The current amount of a resource allocated to the account linked to the subscription | [optional] 
**Resets** | **bool** | Whether consumption is reset to 0 every billing period | [optional] [default to false]
**Enforced** | **bool** | Whether the limit triggers a blocking response from the server | [optional] [default to false]
**Exceeded** | **bool** | Whether the resource usage is greater than or equal to the limit | [optional] [default to false]
**DisplayName** | **string** | The human-readable name | [optional] 
**Description** | **string** | The description | [optional] 
**Unit** | **string** | The unit in which the usage and limit are measured | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

