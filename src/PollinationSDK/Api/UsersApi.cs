/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.38.0
 * Contact: info@pollination.cloud
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace PollinationSDK.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Check if a username is already taken
        /// </summary>
        /// <remarks>
        /// Check if a username is already taken by a user or an org
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <returns>object</returns>
        object CheckUsername (string username);

        /// <summary>
        /// Check if a username is already taken
        /// </summary>
        /// <remarks>
        /// Check if a username is already taken by a user or an org
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <returns>ApiResponse of object</returns>
        ApiResponse<object> CheckUsernameWithHttpInfo (string username);
        /// <summary>
        /// Get a specific user profile
        /// </summary>
        /// <remarks>
        /// Get a specific user profile by name
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <returns>UserPublic</returns>
        UserPublic GetOneUser (string name);

        /// <summary>
        /// Get a specific user profile
        /// </summary>
        /// <remarks>
        /// Get a specific user profile by name
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <returns>ApiResponse of UserPublic</returns>
        ApiResponse<UserPublic> GetOneUserWithHttpInfo (string name);
        /// <summary>
        /// List Users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search string to find users (optional)</param>
        /// <param name="page">Page number starting from 1 (optional, default to 1)</param>
        /// <param name="perPage">Number of items per page (optional, default to 25)</param>
        /// <returns>UserPublicList</returns>
        UserPublicList ListUsers (string search = default, int? page = default, int? perPage = default);

        /// <summary>
        /// List Users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search string to find users (optional)</param>
        /// <param name="page">Page number starting from 1 (optional, default to 1)</param>
        /// <param name="perPage">Number of items per page (optional, default to 25)</param>
        /// <returns>ApiResponse of UserPublicList</returns>
        ApiResponse<UserPublicList> ListUsersWithHttpInfo (string search = default, int? page = default, int? perPage = default);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Check if a username is already taken
        /// </summary>
        /// <remarks>
        /// Check if a username is already taken by a user or an org
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of object</returns>
        System.Threading.Tasks.Task<object> CheckUsernameAsync (string username, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Check if a username is already taken
        /// </summary>
        /// <remarks>
        /// Check if a username is already taken by a user or an org
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (object)</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> CheckUsernameWithHttpInfoAsync (string username, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a specific user profile
        /// </summary>
        /// <remarks>
        /// Get a specific user profile by name
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of UserPublic</returns>
        System.Threading.Tasks.Task<UserPublic> GetOneUserAsync (string name, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get a specific user profile
        /// </summary>
        /// <remarks>
        /// Get a specific user profile by name
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (UserPublic)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPublic>> GetOneUserWithHttpInfoAsync (string name, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List Users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search string to find users (optional)</param>
        /// <param name="page">Page number starting from 1 (optional, default to 1)</param>
        /// <param name="perPage">Number of items per page (optional, default to 25)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of UserPublicList</returns>
        System.Threading.Tasks.Task<UserPublicList> ListUsersAsync (string search = default, int? page = default, int? perPage = default, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List Users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search string to find users (optional)</param>
        /// <param name="page">Page number starting from 1 (optional, default to 1)</param>
        /// <param name="perPage">Number of items per page (optional, default to 25)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (UserPublicList)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPublicList>> ListUsersWithHttpInfoAsync (string search = default, int? page = default, int? perPage = default, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UsersApi : IUsersApi
    {
        private PollinationSDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
        {
            this.Configuration = new PollinationSDK.Client.Configuration { BasePath = basePath };

            ExceptionFactory = PollinationSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// </summary>
        /// <returns></returns>
        public UsersApi()
        {
            this.Configuration = PollinationSDK.Client.Configuration.Default;

            ExceptionFactory = PollinationSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsersApi(PollinationSDK.Client.Configuration configuration = null)
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
        /// Check if a username is already taken Check if a username is already taken by a user or an org
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <returns>object</returns>
        public object CheckUsername (string username)
        {
             ApiResponse<object> localVarResponse = CheckUsernameWithHttpInfo(username);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Check if a username is already taken Check if a username is already taken by a user or an org
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <returns>ApiResponse of object</returns>
        public ApiResponse<object> CheckUsernameWithHttpInfo (string username)
        {
            // verify the required parameter 'username' is set
            if (username == null)
                throw new ApiException(400, "Missing required parameter 'username' when calling UsersApi->CheckUsername");

            var localVarPath = "/users/check_username/{username}";
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

            if (username != null) localVarPathParams.Add("username", this.Configuration.ApiClient.ParameterToString(username)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CheckUsername", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)));
        }

        /// <summary>
        /// Check if a username is already taken Check if a username is already taken by a user or an org
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of object</returns>
        public async System.Threading.Tasks.Task<object> CheckUsernameAsync (string username, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<object> localVarResponse = await CheckUsernameWithHttpInfoAsync(username, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Check if a username is already taken Check if a username is already taken by a user or an org
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<object>> CheckUsernameWithHttpInfoAsync (string username, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'username' is set
            if (username == null)
                throw new ApiException(400, "Missing required parameter 'username' when calling UsersApi->CheckUsername");

            var localVarPath = "/users/check_username/{username}";
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

            if (username != null) localVarPathParams.Add("username", this.Configuration.ApiClient.ParameterToString(username)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CheckUsername", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)));
        }

        /// <summary>
        /// Get a specific user profile Get a specific user profile by name
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <returns>UserPublic</returns>
        public UserPublic GetOneUser (string name)
        {
             ApiResponse<UserPublic> localVarResponse = GetOneUserWithHttpInfo(name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a specific user profile Get a specific user profile by name
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <returns>ApiResponse of UserPublic</returns>
        public ApiResponse<UserPublic> GetOneUserWithHttpInfo (string name)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling UsersApi->GetOneUser");

            var localVarPath = "/users/{name}";
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
                Exception exception = ExceptionFactory("GetOneUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserPublic>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (UserPublic) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPublic)));
        }

        /// <summary>
        /// Get a specific user profile Get a specific user profile by name
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of UserPublic</returns>
        public async System.Threading.Tasks.Task<UserPublic> GetOneUserAsync (string name, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<UserPublic> localVarResponse = await GetOneUserWithHttpInfoAsync(name, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a specific user profile Get a specific user profile by name
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (UserPublic)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPublic>> GetOneUserWithHttpInfoAsync (string name, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling UsersApi->GetOneUser");

            var localVarPath = "/users/{name}";
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
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOneUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserPublic>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (UserPublic) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPublic)));
        }

        /// <summary>
        /// List Users 
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search string to find users (optional)</param>
        /// <param name="page">Page number starting from 1 (optional, default to 1)</param>
        /// <param name="perPage">Number of items per page (optional, default to 25)</param>
        /// <returns>UserPublicList</returns>
        public UserPublicList ListUsers (string search = default, int? page = default, int? perPage = default)
        {
             ApiResponse<UserPublicList> localVarResponse = ListUsersWithHttpInfo(search, page, perPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Users 
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search string to find users (optional)</param>
        /// <param name="page">Page number starting from 1 (optional, default to 1)</param>
        /// <param name="perPage">Number of items per page (optional, default to 25)</param>
        /// <returns>ApiResponse of UserPublicList</returns>
        public ApiResponse<UserPublicList> ListUsersWithHttpInfo (string search = default, int? page = default, int? perPage = default)
        {

            var localVarPath = "/users";
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

            if (search != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "search", search)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (perPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per-page", perPage)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListUsers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserPublicList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (UserPublicList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPublicList)));
        }

        /// <summary>
        /// List Users 
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search string to find users (optional)</param>
        /// <param name="page">Page number starting from 1 (optional, default to 1)</param>
        /// <param name="perPage">Number of items per page (optional, default to 25)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of UserPublicList</returns>
        public async System.Threading.Tasks.Task<UserPublicList> ListUsersAsync (string search = default, int? page = default, int? perPage = default, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<UserPublicList> localVarResponse = await ListUsersWithHttpInfoAsync(search, page, perPage, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Users 
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search string to find users (optional)</param>
        /// <param name="page">Page number starting from 1 (optional, default to 1)</param>
        /// <param name="perPage">Number of items per page (optional, default to 25)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (UserPublicList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPublicList>> ListUsersWithHttpInfoAsync (string search = default, int? page = default, int? perPage = default, CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/users";
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

            if (search != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "search", search)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (perPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per-page", perPage)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListUsers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserPublicList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (UserPublicList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPublicList)));
        }

    }
}
