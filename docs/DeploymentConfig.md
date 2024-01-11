
# PollinationSDK.Model.DeploymentConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoginRequired** | **bool** | Whether the application requires login. | [optional] [default to true]
**CpuLimit** | **int** | The maximum number of CPU cores that can be used by the application. | [optional] [default to 1]
**MemoryLimit** | **int** | The maximum amount of memory that can be used by the application. | [optional] [default to 2000]
**ScaleToZero** | **bool** | A boolean toggle to scale deployments down to zero replicas when not used. | [optional] [default to true]
**EntrypointFile** | **string** | The Streamlit python file to use as an entrypoint to the app | [optional] [default to "app.py"]
**Type** | **string** |  | [optional] [readonly] [default to "DeploymentConfig"]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

