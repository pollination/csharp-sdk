
# PollinationSDK.Model.SubscriptionPlan

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **PlanType** | The type of plan | [readonly] 
**Slug** | **string** | A slug of the config plan used to create this subscription | 
**Name** | **string** | A name of the config plan used to create this subscription | 
**AccountTypes** | [**List&lt;AccountType&gt;**](AccountType.md) | The types of account to which the plan can be applied | 
**Quotas** | [**List&lt;QuotaPlan&gt;**](QuotaPlan.md) | A list of quota plans for a given subscription | [optional] 
**BillingOptions** | [**List&lt;BillingOption&gt;**](BillingOption.md) | The billing options for this plan | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

