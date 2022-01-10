
# PollinationSDK.Model.Invoice

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CollectionMethod** | **string** |  | 
**Currency** | **string** |  | 
**Customer** | **string** |  | 
**Lines** | [**LineItemList**](LineItemList.md) |  | 
**PeriodStart** | **DateTime** |  | 
**PeriodEnd** | **DateTime** |  | 
**Status** | [**InvoiceStatus**](InvoiceStatus.md) |  | 
**StatusTransitions** | [**InvoiceStatusTransitions**](InvoiceStatusTransitions.md) |  | 
**Subtotal** | **int** |  | 
**Total** | **int** |  | 
**AutoAdvance** | **bool** |  | [optional] 
**Description** | **string** |  | [optional] 
**HostedInvoiceUrl** | **string** |  | [optional] 
**Subscription** | **string** |  | [optional] 
**Discount** | [**Discount**](Discount.md) |  | [optional] 
**TotalDiscountAmounts** | [**List&lt;DiscountAmount&gt;**](DiscountAmount.md) |  | [optional] 
**PaymentMethod** | [**CardPublic**](CardPublic.md) | The payment method that will be billed when this invoice is due. | [optional] 
**Type** | **string** |  | [optional] [readonly] [default to "Invoice"]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

