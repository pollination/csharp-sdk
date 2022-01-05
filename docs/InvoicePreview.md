
# PollinationSDK.Model.InvoicePreview

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoAdvance** | **bool** |  | [optional] 
**CollectionMethod** | **string** |  | 
**Currency** | **string** |  | 
**Customer** | **string** |  | 
**Description** | **string** |  | [optional] 
**Discounts** | [**List&lt;Discount&gt;**](Discount.md) |  | [optional] 
**HostedInvoiceUrl** | **string** |  | [optional] 
**Lines** | [**LineItemList**](LineItemList.md) |  | 
**PaymentMethod** | [**CardPublic**](CardPublic.md) | The payment method that will be billed when this invoice is due. | [optional] 
**PeriodEnd** | **DateTime** |  | 
**PeriodStart** | **DateTime** |  | 
**Status** | **InvoiceStatus** |  | 
**StatusTransitions** | [**InvoiceStatusTransitions**](InvoiceStatusTransitions.md) |  | 
**Subscription** | **string** |  | [optional] 
**Subtotal** | **int** |  | 
**Total** | **int** |  | 
**TotalDiscountAmounts** | [**List&lt;DiscountAmount&gt;**](DiscountAmount.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

