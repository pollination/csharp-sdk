
# PollinationSDK.Model.LicensePoolPublic

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The ID of the pool | 
**LicenseId** | **string** | The ID of the license to which the pool provides access | 
**Owner** | [**AccountPublic**](AccountPublic.md) | The account that owns the license | 
**Permissions** | [**UserPermission**](UserPermission.md) |  | 
**Product** | **string** | The pollination product to which this pool provides access | 
**Accessors** | [**List&lt;Accessor&gt;**](Accessor.md) | The entities that can access the license though the pool | [optional] 
**Description** | **string** | The description of the pool | [optional] 
**Type** | **string** |  | [optional] [readonly] [default to "LicensePoolPublic"]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

