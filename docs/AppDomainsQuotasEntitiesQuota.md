
# PollinationSDK.Model.AppDomainsQuotasEntitiesQuota

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **Guid** | The ID of the account this quota relates to | 
**Enforced** | **bool** | Whether the limit triggers a blocking response from the server | [optional] [default to false]
**Id** | **Guid** | The unique ID for this Quota | [optional] 
**Limit** | **double** | The maximum amount of a resource that a subscription allows | [optional] 
**PeriodStart** | **DateTime** | The start of the quota usage tracking period | [optional] 
**Resets** | **bool** | Whether consumption is reset to 0 every billing period | [optional] [default to false]
**StripeProduct** | **string** | The ID of the stripe product this quota refers to | [optional] 
**StripeSubscriptionItem** | **string** | The ID of the stripe subscription item this quota refers to | [optional] 
**Type** | **QuotaType** | The type of resource | [readonly] 
**Usage** | **double** | The current amount of a resource allocated to the account linked to the subscription | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

