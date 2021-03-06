
# PollinationSDK.Model.DAGNumberInputAlias

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Input name. | 
**Annotations** | **Dictionary&lt;string, string&gt;** | An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries. | [optional] 
**Description** | **string** | Optional description for input. | [optional] 
**Platform** | **List&lt;string&gt;** | Name of the client platform (e.g. Grasshopper, Revit, etc). The value can be any strings as long as it has been agreed between client-side developer and author of the recipe. | 
**Handler** | [**List&lt;IOAliasHandler&gt;**](IOAliasHandler.md) | List of process actions to process the input or output value. | 
**Default** | **double** | Default value to use for an input if a value was not supplied. | [optional] 
**Required** | **bool** | A field to indicate if this input is required. This input needs to be set explicitly even when a default value is provided. | [optional] [default to false]
**Spec** | **Object** | An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec. | [optional] 
**Type** | **string** |  | [optional] [readonly] [default to "DAGNumberInputAlias"]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

