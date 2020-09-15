/* 
 * Pollination Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.8.8
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace PollinationSDK.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get an account by name
        /// </summary>
        /// <remarks>
        /// Retrieve an account by name
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <returns>AccountPublic</returns>
        AccountPublic GetAccount (string name);

        /// <summary>
        /// Get an account by name
        /// </summary>
        /// <remarks>
        /// Retrieve an account by name
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <returns>ApiResponse of AccountPublic</returns>
        ApiResponse<AccountPublic> GetAccountWithHttpInfo (string name);
        /// <summary>
        /// List Accounts on the Pollination platform
        /// </summary>
        /// <remarks>
        /// List accounts
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number starting from 1 (optional, default to 1)</param>
        /// <param name="perPage">Number of items per page (optional, default to 25)</param>
        /// <param name="search">Search string to find accounts (optional)</param>
        /// <param name="type">Whether the account is for a user or an org (optional)</param>
        /// <returns>PublicAccountList</returns>
        PublicAccountList ListAccounts (int? page = 1, int? perPage = 25, string search = default, string type = default);

        /// <summary>
        /// List Accounts on the Pollination platform
        /// </summary>
        /// <remarks>
        /// List accounts
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number starting from 1 (optional, default to 1)</param>
        /// <param name="perPage">Number of items per page (optional, default to 25)</param>
        /// <param name="search">Search string to find accounts (optional)</param>
        /// <param name="type">Whether the account is for a user or an org (optional)</param>
        /// <returns>ApiResponse of PublicAccountList</returns>
        ApiResponse<PublicAccountList> ListAccountsWithHttpInfo (int? page = 1, int? perPage = 25, string search = default, string type = default);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get an account by name
        /// </summary>
        /// <remarks>
        /// Retrieve an account by name
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <returns>Task of AccountPublic</returns>
        System.Threading.Tasks.Task<AccountPublic> GetAccountAsync (string name);

        /// <summary>
        /// Get an account by name
        /// </summary>
        /// <remarks>
        /// Retrieve an account by name
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <returns>Task of ApiResponse (AccountPublic)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountPublic>> GetAccountAsyncWithHttpInfo (string name);
        /// <summary>
        /// List Accounts on the Pollination platform
        /// </summary>
        /// <remarks>
        /// List accounts
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number starting from 1 (optional, default to 1)</param>
        /// <param name="perPage">Number of items per page (optional, default to 25)</param>
        /// <param name="search">Search string to find accounts (optional)</param>
        /// <param name="type">Whether the account is for a user or an org (optional)</param>
        /// <returns>Task of PublicAccountList</returns>
        System.Threading.Tasks.Task<PublicAccountList> ListAccountsAsync (int? page = 1, int? perPage = 25, string search = default, string type = default);

        /// <summary>
        /// List Accounts on the Pollination platform
        /// </summary>
        /// <remarks>
        /// List accounts
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number starting from 1 (optional, default to 1)</param>
        /// <param name="perPage">Number of items per page (optional, default to 25)</param>
        /// <param name="search">Search string to find accounts (optional)</param>
        /// <param name="type">Whether the account is for a user or an org (optional)</param>
        /// <returns>Task of ApiResponse (PublicAccountList)</returns>
        System.Threading.Tasks.Task<ApiResponse<PublicAccountList>> ListAccountsAsyncWithHttpInfo (int? page = 1, int? perPage = 25, string search = default, string type = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AccountsApi : IAccountsApi
    {
        private PollinationSDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountsApi(String basePath)
        {
            this.Configuration = new PollinationSDK.Client.Configuration { BasePath = basePath };

            ExceptionFactory = PollinationSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class
        /// </summary>
        /// <returns></returns>
        public AccountsApi()
        {
            this.Configuration = PollinationSDK.Client.Configuration.Default;

            ExceptionFactory = PollinationSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccountsApi(PollinationSDK.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = PollinationSDK.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = PollinationSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

      
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public PollinationSDK.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public PollinationSDK.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get an account by name Retrieve an account by name
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <returns>AccountPublic</returns>
        public AccountPublic GetAccount (string name)
        {
             ApiResponse<AccountPublic> localVarResponse = GetAccountWithHttpInfo(name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an account by name Retrieve an account by name
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <returns>ApiResponse of AccountPublic</returns>
        public ApiResponse<AccountPublic> GetAccountWithHttpInfo (string name)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling AccountsApi->GetAccount");

            var localVarPath = "/accounts/{name}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", this.Configuration.ApiClient.ParameterToString(name)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountPublic>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AccountPublic) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountPublic)));
        }

        /// <summary>
        /// Get an account by name Retrieve an account by name
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <returns>Task of AccountPublic</returns>
        public async System.Threading.Tasks.Task<AccountPublic> GetAccountAsync (string name)
        {
             ApiResponse<AccountPublic> localVarResponse = await GetAccountAsyncWithHttpInfo(name);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an account by name Retrieve an account by name
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <returns>Task of ApiResponse (AccountPublic)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountPublic>> GetAccountAsyncWithHttpInfo (string name)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling AccountsApi->GetAccount");

            var localVarPath = "/accounts/{name}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", this.Configuration.ApiClient.ParameterToString(name)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountPublic>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AccountPublic) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountPublic)));
        }

        /// <summary>
        /// List Accounts on the Pollination platform List accounts
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number starting from 1 (optional, default to 1)</param>
        /// <param name="perPage">Number of items per page (optional, default to 25)</param>
        /// <param name="search">Search string to find accounts (optional)</param>
        /// <param name="type">Whether the account is for a user or an org (optional)</param>
        /// <returns>PublicAccountList</returns>
        public PublicAccountList ListAccounts (int? page = 1, int? perPage = 25, string search = default, string type = default)
        {
             ApiResponse<PublicAccountList> localVarResponse = ListAccountsWithHttpInfo(page, perPage, search, type);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Accounts on the Pollination platform List accounts
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number starting from 1 (optional, default to 1)</param>
        /// <param name="perPage">Number of items per page (optional, default to 25)</param>
        /// <param name="search">Search string to find accounts (optional)</param>
        /// <param name="type">Whether the account is for a user or an org (optional)</param>
        /// <returns>ApiResponse of PublicAccountList</returns>
        public ApiResponse<PublicAccountList> ListAccountsWithHttpInfo (int? page = 1, int? perPage = 25, string search = default, string type = default)
        {

            var localVarPath = "/accounts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (perPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per-page", perPage)); // query parameter
            if (search != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "search", search)); // query parameter
            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListAccounts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PublicAccountList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PublicAccountList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PublicAccountList)));
        }

        /// <summary>
        /// List Accounts on the Pollination platform List accounts
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number starting from 1 (optional, default to 1)</param>
        /// <param name="perPage">Number of items per page (optional, default to 25)</param>
        /// <param name="search">Search string to find accounts (optional)</param>
        /// <param name="type">Whether the account is for a user or an org (optional)</param>
        /// <returns>Task of PublicAccountList</returns>
        public async System.Threading.Tasks.Task<PublicAccountList> ListAccountsAsync (int? page = 1, int? perPage = 25, string search = default, string type = default)
        {
             ApiResponse<PublicAccountList> localVarResponse = await ListAccountsAsyncWithHttpInfo(page, perPage, search, type);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Accounts on the Pollination platform List accounts
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number starting from 1 (optional, default to 1)</param>
        /// <param name="perPage">Number of items per page (optional, default to 25)</param>
        /// <param name="search">Search string to find accounts (optional)</param>
        /// <param name="type">Whether the account is for a user or an org (optional)</param>
        /// <returns>Task of ApiResponse (PublicAccountList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PublicAccountList>> ListAccountsAsyncWithHttpInfo (int? page = 1, int? perPage = 25, string search = default, string type = default)
        {

            var localVarPath = "/accounts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (perPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per-page", perPage)); // query parameter
            if (search != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "search", search)); // query parameter
            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListAccounts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PublicAccountList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PublicAccountList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PublicAccountList)));
        }

    }
}
