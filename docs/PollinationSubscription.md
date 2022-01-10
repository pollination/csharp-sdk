
# PollinationSDK.Model.PollinationSubscription

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CancelAtPeriodEnd** | **bool** |  | 
**CurrentPeriodStart** | **DateTime** |  | 
**CurrentPeriodEnd** | **DateTime** |  | 
**Customer** | **string** |  | 
**Items** | [**SubscriptionItemList**](SubscriptionItemList.md) |  | 
**LatestInvoice** | **string** |  | 
**DefaultPaymentMethod** | **string** |  | [optional] 
**Schedule** | **string** |  | [optional] 
**Discount** | [**Discount**](Discount.md) |  | [optional] 
**AccountId** | **Guid** | The ID of the account this subscription applies to | 
**SubscriptionPlan** | [**SubscriptionPlan**](SubscriptionPlan.md) | A subscription plan | 
**ExternalId** | **string** | The ID of this subscription | [optional] 
**QuotaExtensions** | [**List&lt;QuotaExtension&gt;**](QuotaExtension.md) | A list of quota extension plans for a given subscription | [optional] 
**Type** | **string** |  | [optional] [readonly] [default to "PollinationSubscription"]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

