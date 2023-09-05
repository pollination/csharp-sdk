
# PollinationSDK.Model.Application

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeploymentConfig** | [**DeploymentConfig**](DeploymentConfig.md) | The deployment configuration for the application | [optional] 
**Description** | **string** | A description of the application | [optional] [default to ""]
**Id** | **string** | The application ID | 
**Image** | **string** | An image associated with the application | [optional] [default to "https://picsum.photos/400"]
**IsPaid** | **bool** | Whether or not the application is paid | [optional] [default to false]
**Keywords** | **List&lt;string&gt;** | A list of keywords associated with the application | [optional] 
**License** | **string** | The license of the application | [optional] 
**Name** | **string** | The name of the application. Must be unique to a given owner | 
**Owner** | [**AccountPublic**](AccountPublic.md) | The application owner | 
**Permissions** | [**UserPermission**](UserPermission.md) |  | 
**Public** | **bool** | Whether or not a application is publicly viewable | [optional] [default to true]
**Sdk** | **SDKEnum** | The SDK used to build the application | [optional] 
**Slug** | **string** | The application name in slug format | 
**Source** | **string** | A link to the source code of the application | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

