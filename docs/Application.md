
# PollinationSDK.Model.Application

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the application. Must be unique to a given owner | 
**Id** | **string** | The application ID | 
**Owner** | [**AccountPublic**](AccountPublic.md) | The application owner | 
**Permissions** | [**UserPermission**](UserPermission.md) |  | 
**Slug** | **string** | The application name in slug format | 
**HasBeenDeployed** | **bool** | Whether or not the application has been deployed | 
**Description** | **string** | A description of the application | [optional] [default to ""]
**Public** | **bool** | Whether or not a application is publicly viewable | [optional] [default to true]
**Keywords** | **List&lt;string&gt;** | A list of keywords associated with the application | [optional] 
**Image** | **string** | An image associated with the application | [optional] [default to "https://picsum.photos/400"]
**Source** | **string** | A link to the source code of the application | [optional] 
**License** | **string** | The license of the application | [optional] 
**Sdk** | **SDKEnum** | The SDK used to build the application | [optional] 
**IsPaid** | **bool** | Whether or not the application is paid | [optional] [default to false]
**DeploymentConfig** | [**DeploymentConfig**](DeploymentConfig.md) | The deployment configuration for the application | [optional] 
**Url** | **string** | The URL of the application deployment | [optional] 
**Type** | **string** |  | [optional] [readonly] [default to "Application"]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

