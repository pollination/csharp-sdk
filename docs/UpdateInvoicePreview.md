
# PollinationSDK.Model.UpdateInvoicePreview

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Immediate** | [**InvoicePreview**](InvoicePreview.md) | The invoice that will be finalized right after changes are applied | 
**Upcoming** | [**InvoicePreview**](InvoicePreview.md) | The invoice that will be finalized at the end of the current billing cycle | 
**PaymentMethod** | [**CardPublic**](CardPublic.md) | The payment method that will be billed when this invoice is due. | [optional] 
**ExceededQuotas** | [**List&lt;Quota&gt;**](Quota.md) | A list of quotas that would be exceeded by the update | [optional] 
**Type** | **string** |  | [optional] [readonly] [default to "UpdateInvoicePreview"]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

