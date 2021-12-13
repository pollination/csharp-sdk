[![Build](https://github.com/ladybug-tools/honeybee-schema-dotnet/workflows/CD/badge.svg)](https://github.com/ladybug-tools/honeybee-schema-dotnet/actions) [![NuGet Version and Downloads count](https://buildstats.info/nuget/PollinationSDK?dWidth=50)](https://www.nuget.org/packages/PollinationSDK)

# PollinationSDK - the C# library for the pollination-server

Pollination Server OpenAPI Definition

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v0.20.0
- SDK version: v0.20.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://pollination.cloud](https://pollination.cloud)

## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out PollinationSDK.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: APIKeyAuth
            Configuration.Default.ApiKey.Add("x-pollination-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-pollination-token", "Bearer");
            // Configure HTTP bearer authorization: JWTAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new APITokensApi(Configuration.Default);
            var aPITokenCreate = new APITokenCreate(); // APITokenCreate | 

            try
            {
                // Create a new API token
                APITokenPrivate result = apiInstance.CreateToken(aPITokenCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling APITokensApi.CreateToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*APITokensApi* | [**CreateToken**](docs/APITokensApi.md#createtoken) | **POST** /tokens | Create a new API token
*APITokensApi* | [**DeleteToken**](docs/APITokensApi.md#deletetoken) | **DELETE** /tokens/{token_id} | Delete an API Token
*APITokensApi* | [**ListTokens**](docs/APITokensApi.md#listtokens) | **GET** /tokens | List user API tokens
*APITokensApi* | [**RegenerateToken**](docs/APITokensApi.md#regeneratetoken) | **PUT** /tokens/{token_id} | Regenerate an API token
*AccountsApi* | [**CheckAccountName**](docs/AccountsApi.md#checkaccountname) | **GET** /accounts/check/{name} | Check if an account with this name exists
*AccountsApi* | [**GetAccount**](docs/AccountsApi.md#getaccount) | **GET** /accounts/{name} | Get an account by name
*AccountsApi* | [**ListAccounts**](docs/AccountsApi.md#listaccounts) | **GET** /accounts | List Accounts on the Pollination platform
*AccountsApi* | [**ListQuotas**](docs/AccountsApi.md#listquotas) | **GET** /accounts/{name}/quotas | List Quotas
*ArtifactsApi* | [**CreateArtifact**](docs/ArtifactsApi.md#createartifact) | **POST** /projects/{owner}/{name}/artifacts | Get an Artifact upload link.
*ArtifactsApi* | [**DeleteArtifact**](docs/ArtifactsApi.md#deleteartifact) | **DELETE** /projects/{owner}/{name}/artifacts | Delete one or many artifacts by key/prefix
*ArtifactsApi* | [**DownloadArtifact**](docs/ArtifactsApi.md#downloadartifact) | **GET** /projects/{owner}/{name}/artifacts/download | Download an artifact from the project folder
*ArtifactsApi* | [**ListArtifacts**](docs/ArtifactsApi.md#listartifacts) | **GET** /projects/{owner}/{name}/artifacts | List artifacts in a project folder
*JobsApi* | [**CancelJob**](docs/JobsApi.md#canceljob) | **PUT** /projects/{owner}/{name}/jobs/{job_id}/cancel | Cancel a Job
*JobsApi* | [**CreateJob**](docs/JobsApi.md#createjob) | **POST** /projects/{owner}/{name}/jobs | Schedule a job
*JobsApi* | [**DeleteJob**](docs/JobsApi.md#deletejob) | **DELETE** /projects/{owner}/{name}/jobs/{job_id} | Delete a Job
*JobsApi* | [**DownloadJobArtifact**](docs/JobsApi.md#downloadjobartifact) | **GET** /projects/{owner}/{name}/jobs/{job_id}/artifacts/download | Download an artifact from the job folder
*JobsApi* | [**GetJob**](docs/JobsApi.md#getjob) | **GET** /projects/{owner}/{name}/jobs/{job_id} | Get a Job
*JobsApi* | [**ListJobs**](docs/JobsApi.md#listjobs) | **GET** /projects/{owner}/{name}/jobs | List Jobs
*JobsApi* | [**SearchJobFolder**](docs/JobsApi.md#searchjobfolder) | **GET** /projects/{owner}/{name}/jobs/{job_id}/artifacts | List files/folders in a job folder
*OrgsApi* | [**CreateOrg**](docs/OrgsApi.md#createorg) | **POST** /orgs | Create an Org
*OrgsApi* | [**DeleteOrg**](docs/OrgsApi.md#deleteorg) | **DELETE** /orgs/{name} | Delete an Org
*OrgsApi* | [**DeleteOrgMember**](docs/OrgsApi.md#deleteorgmember) | **DELETE** /orgs/{name}/members/{username} | Remove an Org member
*OrgsApi* | [**GetOrg**](docs/OrgsApi.md#getorg) | **GET** /orgs/{name} | Get an Org
*OrgsApi* | [**GetOrgMembers**](docs/OrgsApi.md#getorgmembers) | **GET** /orgs/{name}/members | List organization members
*OrgsApi* | [**ListOrgs**](docs/OrgsApi.md#listorgs) | **GET** /orgs | List Orgs
*OrgsApi* | [**UpdateOrg**](docs/OrgsApi.md#updateorg) | **PUT** /orgs/{name} | Update an Org
*OrgsApi* | [**UpsertOrgMember**](docs/OrgsApi.md#upsertorgmember) | **PATCH** /orgs/{name}/members/{username}/{role} | Add or update the role of an Org Member
*PaymentsApi* | [**CancelSubscription**](docs/PaymentsApi.md#cancelsubscription) | **DELETE** /payments/{account_name}/subscription | Cancel Subscription
*PaymentsApi* | [**CreatePaymentMethod**](docs/PaymentsApi.md#createpaymentmethod) | **POST** /payments/{account_name}/methods | Add Payment Method
*PaymentsApi* | [**CreateSubscription**](docs/PaymentsApi.md#createsubscription) | **POST** /payments/{account_name}/subscription | Create Subscription
*PaymentsApi* | [**GetDefaultPaymentMethod**](docs/PaymentsApi.md#getdefaultpaymentmethod) | **GET** /payments/{account_name}/methods/default | Get Default Payment Method
*PaymentsApi* | [**GetFailedPayment**](docs/PaymentsApi.md#getfailedpayment) | **GET** /payments/{account_name}/failed | Get Failed Payment
*PaymentsApi* | [**GetInventory**](docs/PaymentsApi.md#getinventory) | **GET** /payments/{account_name}/inventory | Get Inventory
*PaymentsApi* | [**GetInvoiceList**](docs/PaymentsApi.md#getinvoicelist) | **GET** /payments/{account_name}/invoices | Get Invoice List
*PaymentsApi* | [**GetNextInvoice**](docs/PaymentsApi.md#getnextinvoice) | **GET** /payments/{account_name}/invoices/next | Get Next Invoice
*PaymentsApi* | [**GetStatus**](docs/PaymentsApi.md#getstatus) | **GET** /payments/{account_name}/status | Get Status
*PaymentsApi* | [**GetSubscription**](docs/PaymentsApi.md#getsubscription) | **GET** /payments/{account_name}/subscription | Get Subscription
*PaymentsApi* | [**GetUnfilteredInventory**](docs/PaymentsApi.md#getunfilteredinventory) | **GET** /payments/inventory | Get Unfiltered Inventory
*PaymentsApi* | [**ListPaymentMethods**](docs/PaymentsApi.md#listpaymentmethods) | **GET** /payments/{account_name}/methods | Get Payment Methods
*PaymentsApi* | [**PreviewUpdateSubscription**](docs/PaymentsApi.md#previewupdatesubscription) | **PUT** /payments/{account_name}/subscription/preview | Preview Update Subscription
*PaymentsApi* | [**Subscribe**](docs/PaymentsApi.md#subscribe) | **POST** /payments/{account_name}/subscribe | Subscribe
*PaymentsApi* | [**UpdateSubscription**](docs/PaymentsApi.md#updatesubscription) | **PUT** /payments/{account_name}/subscription | Update Subscription
*PluginsApi* | [**CreatePlugin**](docs/PluginsApi.md#createplugin) | **POST** /plugins/{owner} | Create a Plugin
*PluginsApi* | [**CreatePluginPackage**](docs/PluginsApi.md#createpluginpackage) | **POST** /plugins/{owner}/{name}/tags | Create a new Plugin package
*PluginsApi* | [**DeletePlugin**](docs/PluginsApi.md#deleteplugin) | **DELETE** /plugins/{owner}/{name} | Delete a Plugin
*PluginsApi* | [**DeletePluginOrgPermission**](docs/PluginsApi.md#deletepluginorgpermission) | **DELETE** /plugins/{owner}/{name}/permissions | Remove a Repository permissions
*PluginsApi* | [**GetPlugin**](docs/PluginsApi.md#getplugin) | **GET** /plugins/{owner}/{name} | Get a plugin
*PluginsApi* | [**GetPluginAccessPermissions**](docs/PluginsApi.md#getpluginaccesspermissions) | **GET** /plugins/{owner}/{name}/permissions | Get plugin access permissions
*PluginsApi* | [**GetPluginByTag**](docs/PluginsApi.md#getpluginbytag) | **GET** /plugins/{owner}/{name}/tags/{tag} | Get a plugin tag
*PluginsApi* | [**ListPluginTags**](docs/PluginsApi.md#listplugintags) | **GET** /plugins/{owner}/{name}/tags | Get a plugin tags
*PluginsApi* | [**ListPlugins**](docs/PluginsApi.md#listplugins) | **GET** /plugins | List plugins
*PluginsApi* | [**UpdatePlugin**](docs/PluginsApi.md#updateplugin) | **PUT** /plugins/{owner}/{name} | Update a Plugin
*PluginsApi* | [**UpsertPluginPermission**](docs/PluginsApi.md#upsertpluginpermission) | **PATCH** /plugins/{owner}/{name}/permissions | Upsert a new permission to a plugin
*ProjectsApi* | [**CreateProject**](docs/ProjectsApi.md#createproject) | **POST** /projects/{owner} | Create a Project
*ProjectsApi* | [**CreateProjectRecipeFilter**](docs/ProjectsApi.md#createprojectrecipefilter) | **POST** /projects/{owner}/{name}/recipes/filters | Upsert a recipe filter to a project
*ProjectsApi* | [**DeleteProject**](docs/ProjectsApi.md#deleteproject) | **DELETE** /projects/{owner}/{name} | Delete a Project
*ProjectsApi* | [**DeleteProjectOrgPermission**](docs/ProjectsApi.md#deleteprojectorgpermission) | **DELETE** /projects/{owner}/{name}/permissions | Remove a Project permissions
*ProjectsApi* | [**DeleteProjectRecipeFilter**](docs/ProjectsApi.md#deleteprojectrecipefilter) | **DELETE** /projects/{owner}/{name}/recipes/filters | Remove a Project recipe filter
*ProjectsApi* | [**GetProject**](docs/ProjectsApi.md#getproject) | **GET** /projects/{owner}/{name} | Get a project
*ProjectsApi* | [**GetProjectAccessPermissions**](docs/ProjectsApi.md#getprojectaccesspermissions) | **GET** /projects/{owner}/{name}/permissions | Get project access permissions
*ProjectsApi* | [**GetProjectRecipeFilters**](docs/ProjectsApi.md#getprojectrecipefilters) | **GET** /projects/{owner}/{name}/recipes/filters | Get project recipe filters
*ProjectsApi* | [**GetProjectRecipes**](docs/ProjectsApi.md#getprojectrecipes) | **GET** /projects/{owner}/{name}/recipes | Get project recipes
*ProjectsApi* | [**ListProjects**](docs/ProjectsApi.md#listprojects) | **GET** /projects | List Projects
*ProjectsApi* | [**Update**](docs/ProjectsApi.md#update) | **PUT** /projects/{owner}/{name} | Update a Project
*ProjectsApi* | [**UpsertProjectPermission**](docs/ProjectsApi.md#upsertprojectpermission) | **PATCH** /projects/{owner}/{name}/permissions | Upsert a new permission to a project
*RecipesApi* | [**CreateRecipe**](docs/RecipesApi.md#createrecipe) | **POST** /recipes/{owner} | Create a Recipe
*RecipesApi* | [**CreateRecipePackage**](docs/RecipesApi.md#createrecipepackage) | **POST** /recipes/{owner}/{name}/tags | Create a new Recipe package
*RecipesApi* | [**DeleteRecipe**](docs/RecipesApi.md#deleterecipe) | **DELETE** /recipes/{owner}/{name} | Delete a Recipe
*RecipesApi* | [**DeleteRecipeOrgPermission**](docs/RecipesApi.md#deleterecipeorgpermission) | **DELETE** /recipes/{owner}/{name}/permissions | Remove a Repository permissions
*RecipesApi* | [**GetRecipe**](docs/RecipesApi.md#getrecipe) | **GET** /recipes/{owner}/{name} | Get a recipe
*RecipesApi* | [**GetRecipeAccessPermissions**](docs/RecipesApi.md#getrecipeaccesspermissions) | **GET** /recipes/{owner}/{name}/permissions | Get recipe access permissions
*RecipesApi* | [**GetRecipeByTag**](docs/RecipesApi.md#getrecipebytag) | **GET** /recipes/{owner}/{name}/tags/{tag} | Get a recipe tag
*RecipesApi* | [**ListRecipeTags**](docs/RecipesApi.md#listrecipetags) | **GET** /recipes/{owner}/{name}/tags | Get a recipe tags
*RecipesApi* | [**ListRecipes**](docs/RecipesApi.md#listrecipes) | **GET** /recipes | List recipes
*RecipesApi* | [**UpdateRecipe**](docs/RecipesApi.md#updaterecipe) | **PUT** /recipes/{owner}/{name} | Update a Recipe
*RecipesApi* | [**UpsertRecipePermission**](docs/RecipesApi.md#upsertrecipepermission) | **PATCH** /recipes/{owner}/{name}/permissions | Upsert a new permission to a recipe
*RegistriesApi* | [**GetPackage**](docs/RegistriesApi.md#getpackage) | **GET** /registries/{owner}/{type}/{name}/{digest} | Get Package
*RegistriesApi* | [**GetPackageJson**](docs/RegistriesApi.md#getpackagejson) | **GET** /registries/{owner}/{type}/{name}/{digest}/json | Get Package in JSON format
*RegistriesApi* | [**GetRegistryIndex**](docs/RegistriesApi.md#getregistryindex) | **GET** /registries/{owner}/index.json | Get Registry Index
*RegistriesApi* | [**PostPlugin**](docs/RegistriesApi.md#postplugin) | **POST** /registries/{owner}/plugins | Push a plugin to the registry
*RegistriesApi* | [**PostRecipe**](docs/RegistriesApi.md#postrecipe) | **POST** /registries/{owner}/recipes | Push an Recipe to the registry
*RunsApi* | [**CancelRun**](docs/RunsApi.md#cancelrun) | **PUT** /projects/{owner}/{name}/runs/{run_id}/cancel | Cancel a run
*RunsApi* | [**DownloadRunArtifact**](docs/RunsApi.md#downloadrunartifact) | **GET** /projects/{owner}/{name}/runs/{run_id}/artifacts/download | Download an artifact from the run folder
*RunsApi* | [**GetRun**](docs/RunsApi.md#getrun) | **GET** /projects/{owner}/{name}/runs/{run_id} | Get a Run
*RunsApi* | [**GetRunOutput**](docs/RunsApi.md#getrunoutput) | **GET** /projects/{owner}/{name}/runs/{run_id}/outputs/{output_name} | Get run output by name
*RunsApi* | [**GetRunStepLogs**](docs/RunsApi.md#getrunsteplogs) | **GET** /projects/{owner}/{name}/runs/{run_id}/steps/{step_id}/logs | Get the logs of a specific step of the run
*RunsApi* | [**GetRunSteps**](docs/RunsApi.md#getrunsteps) | **GET** /projects/{owner}/{name}/runs/{run_id}/steps | Query the steps of a run
*RunsApi* | [**ListRunArtifacts**](docs/RunsApi.md#listrunartifacts) | **GET** /projects/{owner}/{name}/runs/{run_id}/artifacts | List artifacts in a run folder
*RunsApi* | [**ListRuns**](docs/RunsApi.md#listruns) | **GET** /projects/{owner}/{name}/runs | List runs
*RunsApi* | [**QueryResults**](docs/RunsApi.md#queryresults) | **GET** /projects/{owner}/{name}/results | Query run results
*SubscriptionsApi* | [**GetPollinationSubscription**](docs/SubscriptionsApi.md#getpollinationsubscription) | **GET** /subscriptions/{account_name} | Get Subscription
*TeamsApi* | [**CreateTeam**](docs/TeamsApi.md#createteam) | **POST** /orgs/{org_name}/teams | Create a Team
*TeamsApi* | [**DeleteOrgTeamMember**](docs/TeamsApi.md#deleteorgteammember) | **DELETE** /orgs/{org_name}/teams/{team_slug}/members/{username} | Remove a team member
*TeamsApi* | [**DeleteTeam**](docs/TeamsApi.md#deleteteam) | **DELETE** /orgs/{org_name}/teams/{team_slug} | Delete a Team
*TeamsApi* | [**GetOrgTeamMembers**](docs/TeamsApi.md#getorgteammembers) | **GET** /orgs/{org_name}/teams/{team_slug}/members | List team members
*TeamsApi* | [**GetTeam**](docs/TeamsApi.md#getteam) | **GET** /orgs/{org_name}/teams/{team_slug} | Get a Team
*TeamsApi* | [**ListOrgTeams**](docs/TeamsApi.md#listorgteams) | **GET** /orgs/{org_name}/teams | List Teams
*TeamsApi* | [**UpdateTeam**](docs/TeamsApi.md#updateteam) | **PUT** /orgs/{org_name}/teams/{team_slug} | Update a Team
*TeamsApi* | [**UpsertOrgTeamMember**](docs/TeamsApi.md#upsertorgteammember) | **PATCH** /orgs/{org_name}/teams/{team_slug}/members/{username}/{role} | Add or update the role of an Team Member
*UserApi* | [**CreateUser**](docs/UserApi.md#createuser) | **POST** /user | Register a new user
*UserApi* | [**GetMe**](docs/UserApi.md#getme) | **GET** /user | Get authenticated user profile.
*UserApi* | [**GetRoles**](docs/UserApi.md#getroles) | **GET** /user/roles | Get the authenticated user roles
*UserApi* | [**UpdateUserProfile**](docs/UserApi.md#updateuserprofile) | **PUT** /user | Update the authenticated user
*UsersApi* | [**GetOneUser**](docs/UsersApi.md#getoneuser) | **GET** /users/{name} | Get a specific user profile
*UsersApi* | [**ListUsers**](docs/UsersApi.md#listusers) | **GET** /users | List Users


## Documentation for Models

 - [Model.APIToken](docs/APIToken.md)
 - [Model.APITokenCreate](docs/APITokenCreate.md)
 - [Model.APITokenList](docs/APITokenList.md)
 - [Model.APITokenPrivate](docs/APITokenPrivate.md)
 - [Model.AccountPublic](docs/AccountPublic.md)
 - [Model.AccountType](docs/AccountType.md)
 - [Model.BakedRecipe](docs/BakedRecipe.md)
 - [Model.BodyPostPluginOwnerPluginsPost](docs/BodyPostPluginOwnerPluginsPost.md)
 - [Model.BodyPostRecipeOwnerRecipesPost](docs/BodyPostRecipeOwnerRecipesPost.md)
 - [Model.CardPublic](docs/CardPublic.md)
 - [Model.CloudJob](docs/CloudJob.md)
 - [Model.CloudJobList](docs/CloudJobList.md)
 - [Model.CreatedContent](docs/CreatedContent.md)
 - [Model.DAG](docs/DAG.md)
 - [Model.DAGArrayInput](docs/DAGArrayInput.md)
 - [Model.DAGArrayInputAlias](docs/DAGArrayInputAlias.md)
 - [Model.DAGArrayOutput](docs/DAGArrayOutput.md)
 - [Model.DAGArrayOutputAlias](docs/DAGArrayOutputAlias.md)
 - [Model.DAGBooleanInput](docs/DAGBooleanInput.md)
 - [Model.DAGBooleanInputAlias](docs/DAGBooleanInputAlias.md)
 - [Model.DAGBooleanOutput](docs/DAGBooleanOutput.md)
 - [Model.DAGBooleanOutputAlias](docs/DAGBooleanOutputAlias.md)
 - [Model.DAGFileInput](docs/DAGFileInput.md)
 - [Model.DAGFileInputAlias](docs/DAGFileInputAlias.md)
 - [Model.DAGFileOutput](docs/DAGFileOutput.md)
 - [Model.DAGFileOutputAlias](docs/DAGFileOutputAlias.md)
 - [Model.DAGFolderInput](docs/DAGFolderInput.md)
 - [Model.DAGFolderInputAlias](docs/DAGFolderInputAlias.md)
 - [Model.DAGFolderOutput](docs/DAGFolderOutput.md)
 - [Model.DAGFolderOutputAlias](docs/DAGFolderOutputAlias.md)
 - [Model.DAGGenericInput](docs/DAGGenericInput.md)
 - [Model.DAGGenericInputAlias](docs/DAGGenericInputAlias.md)
 - [Model.DAGGenericOutput](docs/DAGGenericOutput.md)
 - [Model.DAGGenericOutputAlias](docs/DAGGenericOutputAlias.md)
 - [Model.DAGIntegerInput](docs/DAGIntegerInput.md)
 - [Model.DAGIntegerInputAlias](docs/DAGIntegerInputAlias.md)
 - [Model.DAGIntegerOutput](docs/DAGIntegerOutput.md)
 - [Model.DAGIntegerOutputAlias](docs/DAGIntegerOutputAlias.md)
 - [Model.DAGJSONObjectInput](docs/DAGJSONObjectInput.md)
 - [Model.DAGJSONObjectInputAlias](docs/DAGJSONObjectInputAlias.md)
 - [Model.DAGJSONObjectOutput](docs/DAGJSONObjectOutput.md)
 - [Model.DAGJSONObjectOutputAlias](docs/DAGJSONObjectOutputAlias.md)
 - [Model.DAGLinkedInputAlias](docs/DAGLinkedInputAlias.md)
 - [Model.DAGLinkedOutputAlias](docs/DAGLinkedOutputAlias.md)
 - [Model.DAGNumberInput](docs/DAGNumberInput.md)
 - [Model.DAGNumberInputAlias](docs/DAGNumberInputAlias.md)
 - [Model.DAGNumberOutput](docs/DAGNumberOutput.md)
 - [Model.DAGNumberOutputAlias](docs/DAGNumberOutputAlias.md)
 - [Model.DAGPathInput](docs/DAGPathInput.md)
 - [Model.DAGPathInputAlias](docs/DAGPathInputAlias.md)
 - [Model.DAGPathOutput](docs/DAGPathOutput.md)
 - [Model.DAGPathOutputAlias](docs/DAGPathOutputAlias.md)
 - [Model.DAGStringInput](docs/DAGStringInput.md)
 - [Model.DAGStringInputAlias](docs/DAGStringInputAlias.md)
 - [Model.DAGStringOutput](docs/DAGStringOutput.md)
 - [Model.DAGStringOutputAlias](docs/DAGStringOutputAlias.md)
 - [Model.DAGTask](docs/DAGTask.md)
 - [Model.DAGTaskLoop](docs/DAGTaskLoop.md)
 - [Model.DailyUsage](docs/DailyUsage.md)
 - [Model.Dependency](docs/Dependency.md)
 - [Model.DependencyKind](docs/DependencyKind.md)
 - [Model.DockerConfig](docs/DockerConfig.md)
 - [Model.FileMeta](docs/FileMeta.md)
 - [Model.FileReference](docs/FileReference.md)
 - [Model.FolderReference](docs/FolderReference.md)
 - [Model.Function](docs/Function.md)
 - [Model.FunctionArrayInput](docs/FunctionArrayInput.md)
 - [Model.FunctionArrayOutput](docs/FunctionArrayOutput.md)
 - [Model.FunctionBooleanInput](docs/FunctionBooleanInput.md)
 - [Model.FunctionBooleanOutput](docs/FunctionBooleanOutput.md)
 - [Model.FunctionFileInput](docs/FunctionFileInput.md)
 - [Model.FunctionFileOutput](docs/FunctionFileOutput.md)
 - [Model.FunctionFolderInput](docs/FunctionFolderInput.md)
 - [Model.FunctionFolderOutput](docs/FunctionFolderOutput.md)
 - [Model.FunctionIntegerInput](docs/FunctionIntegerInput.md)
 - [Model.FunctionIntegerOutput](docs/FunctionIntegerOutput.md)
 - [Model.FunctionJSONObjectInput](docs/FunctionJSONObjectInput.md)
 - [Model.FunctionJSONObjectOutput](docs/FunctionJSONObjectOutput.md)
 - [Model.FunctionNumberInput](docs/FunctionNumberInput.md)
 - [Model.FunctionNumberOutput](docs/FunctionNumberOutput.md)
 - [Model.FunctionPathInput](docs/FunctionPathInput.md)
 - [Model.FunctionPathOutput](docs/FunctionPathOutput.md)
 - [Model.FunctionStringInput](docs/FunctionStringInput.md)
 - [Model.FunctionStringOutput](docs/FunctionStringOutput.md)
 - [Model.HTTP](docs/HTTP.md)
 - [Model.HTTPValidationError](docs/HTTPValidationError.md)
 - [Model.IOAliasHandler](docs/IOAliasHandler.md)
 - [Model.InputFileReference](docs/InputFileReference.md)
 - [Model.InputFolderReference](docs/InputFolderReference.md)
 - [Model.InputPathReference](docs/InputPathReference.md)
 - [Model.InputReference](docs/InputReference.md)
 - [Model.Inventory](docs/Inventory.md)
 - [Model.Invoice](docs/Invoice.md)
 - [Model.InvoiceList](docs/InvoiceList.md)
 - [Model.InvoicePreview](docs/InvoicePreview.md)
 - [Model.InvoiceStatus](docs/InvoiceStatus.md)
 - [Model.InvoiceStatusTransitions](docs/InvoiceStatusTransitions.md)
 - [Model.ItemReference](docs/ItemReference.md)
 - [Model.ItemType](docs/ItemType.md)
 - [Model.Job](docs/Job.md)
 - [Model.JobArgument](docs/JobArgument.md)
 - [Model.JobPathArgument](docs/JobPathArgument.md)
 - [Model.JobStatus](docs/JobStatus.md)
 - [Model.JobStatusEnum](docs/JobStatusEnum.md)
 - [Model.KeyRequest](docs/KeyRequest.md)
 - [Model.License](docs/License.md)
 - [Model.LineItem](docs/LineItem.md)
 - [Model.LineItemList](docs/LineItemList.md)
 - [Model.LocalConfig](docs/LocalConfig.md)
 - [Model.Maintainer](docs/Maintainer.md)
 - [Model.MetaData](docs/MetaData.md)
 - [Model.NewPluginPackage](docs/NewPluginPackage.md)
 - [Model.NewRecipePackage](docs/NewRecipePackage.md)
 - [Model.NewSubscriptionItem](docs/NewSubscriptionItem.md)
 - [Model.Organization](docs/Organization.md)
 - [Model.OrganizationCreate](docs/OrganizationCreate.md)
 - [Model.OrganizationList](docs/OrganizationList.md)
 - [Model.OrganizationMember](docs/OrganizationMember.md)
 - [Model.OrganizationMemberList](docs/OrganizationMemberList.md)
 - [Model.OrganizationRoleEnum](docs/OrganizationRoleEnum.md)
 - [Model.OrganizationUpdate](docs/OrganizationUpdate.md)
 - [Model.PackageSortKey](docs/PackageSortKey.md)
 - [Model.PackageVersion](docs/PackageVersion.md)
 - [Model.PaymentCreate](docs/PaymentCreate.md)
 - [Model.PaymentIntent](docs/PaymentIntent.md)
 - [Model.PaymentMethodList](docs/PaymentMethodList.md)
 - [Model.PaymentSetup](docs/PaymentSetup.md)
 - [Model.Period](docs/Period.md)
 - [Model.Permission](docs/Permission.md)
 - [Model.Plugin](docs/Plugin.md)
 - [Model.PluginConfig](docs/PluginConfig.md)
 - [Model.PluginPackage](docs/PluginPackage.md)
 - [Model.PluginPackageList](docs/PluginPackageList.md)
 - [Model.PolicySubject](docs/PolicySubject.md)
 - [Model.PollinationSubscription](docs/PollinationSubscription.md)
 - [Model.Price](docs/Price.md)
 - [Model.PriceRecurrence](docs/PriceRecurrence.md)
 - [Model.PriceTier](docs/PriceTier.md)
 - [Model.PriceType](docs/PriceType.md)
 - [Model.ProductFamily](docs/ProductFamily.md)
 - [Model.Project](docs/Project.md)
 - [Model.ProjectAccessPolicy](docs/ProjectAccessPolicy.md)
 - [Model.ProjectAccessPolicyList](docs/ProjectAccessPolicyList.md)
 - [Model.ProjectCreate](docs/ProjectCreate.md)
 - [Model.ProjectFolder](docs/ProjectFolder.md)
 - [Model.ProjectList](docs/ProjectList.md)
 - [Model.ProjectPolicySubject](docs/ProjectPolicySubject.md)
 - [Model.ProjectRecipeFilter](docs/ProjectRecipeFilter.md)
 - [Model.ProjectRecipeFilterList](docs/ProjectRecipeFilterList.md)
 - [Model.ProjectSortKey](docs/ProjectSortKey.md)
 - [Model.ProjectUpdate](docs/ProjectUpdate.md)
 - [Model.PublicAccountList](docs/PublicAccountList.md)
 - [Model.Quota](docs/Quota.md)
 - [Model.QuotaExtension](docs/QuotaExtension.md)
 - [Model.QuotaList](docs/QuotaList.md)
 - [Model.QuotaPlan](docs/QuotaPlan.md)
 - [Model.QuotaType](docs/QuotaType.md)
 - [Model.Recipe](docs/Recipe.md)
 - [Model.RecipeInterface](docs/RecipeInterface.md)
 - [Model.RecipeInterfaceList](docs/RecipeInterfaceList.md)
 - [Model.RecipePackage](docs/RecipePackage.md)
 - [Model.RecipePackageList](docs/RecipePackageList.md)
 - [Model.Repository](docs/Repository.md)
 - [Model.RepositoryAccessPolicy](docs/RepositoryAccessPolicy.md)
 - [Model.RepositoryAccessPolicyList](docs/RepositoryAccessPolicyList.md)
 - [Model.RepositoryCreate](docs/RepositoryCreate.md)
 - [Model.RepositoryIndex](docs/RepositoryIndex.md)
 - [Model.RepositoryList](docs/RepositoryList.md)
 - [Model.RepositoryMetadata](docs/RepositoryMetadata.md)
 - [Model.RepositoryPolicySubject](docs/RepositoryPolicySubject.md)
 - [Model.RepositorySortKey](docs/RepositorySortKey.md)
 - [Model.RepositoryUpdate](docs/RepositoryUpdate.md)
 - [Model.RepositoryUserPermissions](docs/RepositoryUserPermissions.md)
 - [Model.ResourcesDuration](docs/ResourcesDuration.md)
 - [Model.RoleEnum](docs/RoleEnum.md)
 - [Model.Run](docs/Run.md)
 - [Model.RunList](docs/RunList.md)
 - [Model.RunMeta](docs/RunMeta.md)
 - [Model.RunProgress](docs/RunProgress.md)
 - [Model.RunResultList](docs/RunResultList.md)
 - [Model.RunStatus](docs/RunStatus.md)
 - [Model.RunStatusEnum](docs/RunStatusEnum.md)
 - [Model.S3](docs/S3.md)
 - [Model.S3UploadRequest](docs/S3UploadRequest.md)
 - [Model.SortEnum](docs/SortEnum.md)
 - [Model.Status](docs/Status.md)
 - [Model.StatusType](docs/StatusType.md)
 - [Model.StepArrayInput](docs/StepArrayInput.md)
 - [Model.StepArrayOutput](docs/StepArrayOutput.md)
 - [Model.StepBooleanInput](docs/StepBooleanInput.md)
 - [Model.StepBooleanOutput](docs/StepBooleanOutput.md)
 - [Model.StepFileInput](docs/StepFileInput.md)
 - [Model.StepFileOutput](docs/StepFileOutput.md)
 - [Model.StepFolderInput](docs/StepFolderInput.md)
 - [Model.StepFolderOutput](docs/StepFolderOutput.md)
 - [Model.StepIntegerInput](docs/StepIntegerInput.md)
 - [Model.StepIntegerOutput](docs/StepIntegerOutput.md)
 - [Model.StepJSONObjectInput](docs/StepJSONObjectInput.md)
 - [Model.StepJSONObjectOutput](docs/StepJSONObjectOutput.md)
 - [Model.StepList](docs/StepList.md)
 - [Model.StepNumberInput](docs/StepNumberInput.md)
 - [Model.StepNumberOutput](docs/StepNumberOutput.md)
 - [Model.StepPathInput](docs/StepPathInput.md)
 - [Model.StepPathOutput](docs/StepPathOutput.md)
 - [Model.StepStatus](docs/StepStatus.md)
 - [Model.StepStatusEnum](docs/StepStatusEnum.md)
 - [Model.StepStringInput](docs/StepStringInput.md)
 - [Model.StepStringOutput](docs/StepStringOutput.md)
 - [Model.SubjectType](docs/SubjectType.md)
 - [Model.Subscribe](docs/Subscribe.md)
 - [Model.Subscription](docs/Subscription.md)
 - [Model.SubscriptionCreate](docs/SubscriptionCreate.md)
 - [Model.SubscriptionItem](docs/SubscriptionItem.md)
 - [Model.SubscriptionItemPublic](docs/SubscriptionItemPublic.md)
 - [Model.SubscriptionItemPublicList](docs/SubscriptionItemPublicList.md)
 - [Model.SubscriptionPlan](docs/SubscriptionPlan.md)
 - [Model.SubscriptionUpdate](docs/SubscriptionUpdate.md)
 - [Model.TaskArgument](docs/TaskArgument.md)
 - [Model.TaskFileReference](docs/TaskFileReference.md)
 - [Model.TaskFolderReference](docs/TaskFolderReference.md)
 - [Model.TaskPathArgument](docs/TaskPathArgument.md)
 - [Model.TaskPathReference](docs/TaskPathReference.md)
 - [Model.TaskPathReturn](docs/TaskPathReturn.md)
 - [Model.TaskReference](docs/TaskReference.md)
 - [Model.TaskReturn](docs/TaskReturn.md)
 - [Model.Team](docs/Team.md)
 - [Model.TeamCreate](docs/TeamCreate.md)
 - [Model.TeamList](docs/TeamList.md)
 - [Model.TeamMember](docs/TeamMember.md)
 - [Model.TeamMemberList](docs/TeamMemberList.md)
 - [Model.TeamRoleEnum](docs/TeamRoleEnum.md)
 - [Model.TeamUpdate](docs/TeamUpdate.md)
 - [Model.TemplateFunction](docs/TemplateFunction.md)
 - [Model.UpdateAccepted](docs/UpdateAccepted.md)
 - [Model.UpdateInvoicePreview](docs/UpdateInvoicePreview.md)
 - [Model.Usage](docs/Usage.md)
 - [Model.UserCreate](docs/UserCreate.md)
 - [Model.UserPermission](docs/UserPermission.md)
 - [Model.UserPrivate](docs/UserPrivate.md)
 - [Model.UserPublic](docs/UserPublic.md)
 - [Model.UserPublicList](docs/UserPublicList.md)
 - [Model.UserUpdate](docs/UserUpdate.md)
 - [Model.ValidationError](docs/ValidationError.md)
 - [Model.ValueFileReference](docs/ValueFileReference.md)
 - [Model.ValueFolderReference](docs/ValueFolderReference.md)
 - [Model.ValueListReference](docs/ValueListReference.md)
 - [Model.ValueReference](docs/ValueReference.md)


## Documentation for Authorization


### APIKeyAuth

- **Type**: API key

- **API key parameter name**: x-pollination-token
- **Location**: HTTP header


### JWTAuth


- **Type**: HTTP bearer authentication

