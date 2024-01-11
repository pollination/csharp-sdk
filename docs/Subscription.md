
# PollinationSDK.Model.Subscription

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The unique ID of this subscription | 
**Owner** | [**AccountPublic**](AccountPublic.md) | The owner of the repository | 
**Type** | **PlanType** | The type of subscription | [readonly] 
**PeriodStart** | **DateTime** | The start of the current subscription period | 
**PeriodEnd** | **DateTime** | The end of the current subscription period | 
**PlanSlug** | **string** | The slug of the plan used to create this subscription | 
**ExternalId** | **string** | The ID of this subscription | [optional] 
**PlanMultiplier** | **int** | The number of times to multiply the plan limit by | [optional] [default to 1]
**BillingInfo** | [**BillingInfo**](BillingInfo.md) | The billing info for the subscription | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

