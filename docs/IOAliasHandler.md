
# PollinationSDK.Model.IOAliasHandler

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Language** | **string** | Declare the language (e.g. python, csharp, etc.). This option allows the recipe to be flexible on handling different programming languages. | 
**Module** | **string** | Target module or namespace to load the alias function. | 
**Function** | **string** | Name of the function. The input value will be passed to this function as the first argument. | 
**Type** | **string** |  | [optional] [readonly] [default to "IOAliasHandler"]
**Annotations** | **Dictionary&lt;string, string&gt;** | An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries. | [optional] 
**Index** | **int** | An integer to set the index for the order of execution. This input is only useful when there are more than one handler for the same platform and the output of one handler should be passed to another handler. This is also called chained handlers. By default all the handlers are indexed as 0 assuming they are not chained. | [optional] [default to 0]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

