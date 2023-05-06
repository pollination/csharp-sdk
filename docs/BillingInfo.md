
# PollinationSDK.Model.BillingInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CancelUrl** | **string** | The url to cancel the subscription | 
**LastPayment** | [**SubscriptionPayment**](SubscriptionPayment.md) | The last payment made | 
**NextPayment** | [**SubscriptionPayment**](SubscriptionPayment.md) | The last payment made | [optional] 
**PausedAt** | **DateTime** | The date the subscription was paused | [optional] 
**PausedFrom** | **DateTime** | The date the subscription will be paused from | [optional] 
**PausedReason** | **PausedReason** | The reason the subscription was paused | [optional] 
**PaymentInformation** | [**PaymentMethod**](PaymentMethod.md) | The payment method used | 
**SignupDate** | **DateTime** | The date the subscription was created | 
**UpdateUrl** | **string** | The url to update the billing info | 
**UserEmail** | **string** | The email used for billing on this subscription | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

