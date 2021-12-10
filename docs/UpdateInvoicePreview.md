
# PollinationSDK.Model.UpdateInvoicePreview

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExceededQuotas** | [**List&lt;AppDomainsQuotasEntitiesQuota&gt;**](AppDomainsQuotasEntitiesQuota.md) | A list of quotas that would be exceeded by the update | [optional] 
**Immediate** | [**AppDomainsPaymentsEntitiesInvoicePreview**](AppDomainsPaymentsEntitiesInvoicePreview.md) | The invoice that will be finalized right after changes are applied | 
**PaymentMethod** | [**CardPublic**](CardPublic.md) | The payment method that will be billed when this invoice is due. | [optional] 
**Upcoming** | [**AppDomainsPaymentsEntitiesInvoicePreview**](AppDomainsPaymentsEntitiesInvoicePreview.md) | The invoice that will be finalized at the end of the current billing cycle | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

