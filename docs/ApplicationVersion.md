
# PollinationSDK.Model.ApplicationVersion

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The application version ID | 
**Author** | [**AccountPublic**](AccountPublic.md) | The author that created the application version | 
**Tag** | **string** | The tag for this version of the application | 
**BuildStatus** | [**BuildStatus**](BuildStatus.md) | The status of the application version build | 
**ReleaseNotes** | **string** | The release notes for the application version | [optional] [default to ""]
**CreatedAt** | **DateTime** | The time the application version was created | [optional] 
**Type** | **string** |  | [optional] [readonly] [default to "ApplicationVersion"]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

