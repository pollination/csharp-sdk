/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.22.0
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
    public interface ISubscriptionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Subscription
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName"></param>
        /// <returns>PollinationSubscription</returns>
        PollinationSubscription GetPollinationSubscription (string accountName);

        /// <summary>
        /// Get Subscription
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName"></param>
        /// <returns>ApiResponse of PollinationSubscription</returns>
        ApiResponse<PollinationSubscription> GetPollinationSubscriptionWithHttpInfo (string accountName);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get Subscription
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PollinationSubscription</returns>
        System.Threading.Tasks.Task<PollinationSubscription> GetPollinationSubscriptionAsync (string accountName, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Subscription
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PollinationSubscription)</returns>
        System.Threading.Tasks.Task<ApiResponse<PollinationSubscription>> GetPollinationSubscriptionWithHttpInfoAsync (string accountName, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SubscriptionsApi : ISubscriptionsApi
    {
        private PollinationSDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SubscriptionsApi(String basePath)
        {
            this.Configuration = new PollinationSDK.Client.Configuration { BasePath = basePath };

            ExceptionFactory = PollinationSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsApi"/> class
        /// </summary>
        /// <returns></returns>
        public SubscriptionsApi()
        {
            this.Configuration = PollinationSDK.Client.Configuration.Default;

            ExceptionFactory = PollinationSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SubscriptionsApi(PollinationSDK.Client.Configuration configuration = null)
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
        /// Get Subscription 
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName"></param>
        /// <returns>PollinationSubscription</returns>
        public PollinationSubscription GetPollinationSubscription (string accountName)
        {
             ApiResponse<PollinationSubscription> localVarResponse = GetPollinationSubscriptionWithHttpInfo(accountName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Subscription 
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName"></param>
        /// <returns>ApiResponse of PollinationSubscription</returns>
        public ApiResponse<PollinationSubscription> GetPollinationSubscriptionWithHttpInfo (string accountName)
        {
            // verify the required parameter 'accountName' is set
            if (accountName == null)
                throw new ApiException(400, "Missing required parameter 'accountName' when calling SubscriptionsApi->GetPollinationSubscription");

            var localVarPath = "/subscriptions/{account_name}";
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

            if (accountName != null) localVarPathParams.Add("account_name", this.Configuration.ApiClient.ParameterToString(accountName)); // path parameter

            // authentication (APIKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-pollination-token")))
            {
                localVarHeaderParams["x-pollination-token"] = this.Configuration.GetApiKeyWithPrefix("x-pollination-token");
            }
            // authentication (JWTAuth) required
            // http beerer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPollinationSubscription", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PollinationSubscription>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PollinationSubscription) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PollinationSubscription)));
        }

        /// <summary>
        /// Get Subscription 
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PollinationSubscription</returns>
        public async System.Threading.Tasks.Task<PollinationSubscription> GetPollinationSubscriptionAsync (string accountName, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<PollinationSubscription> localVarResponse = await GetPollinationSubscriptionWithHttpInfoAsync(accountName, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Subscription 
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PollinationSubscription)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PollinationSubscription>> GetPollinationSubscriptionWithHttpInfoAsync (string accountName, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'accountName' is set
            if (accountName == null)
                throw new ApiException(400, "Missing required parameter 'accountName' when calling SubscriptionsApi->GetPollinationSubscription");

            var localVarPath = "/subscriptions/{account_name}";
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

            if (accountName != null) localVarPathParams.Add("account_name", this.Configuration.ApiClient.ParameterToString(accountName)); // path parameter

            // authentication (APIKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-pollination-token")))
            {
                localVarHeaderParams["x-pollination-token"] = this.Configuration.GetApiKeyWithPrefix("x-pollination-token");
            }
            // authentication (JWTAuth) required
            // http bearer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPollinationSubscription", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PollinationSubscription>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PollinationSubscription) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PollinationSubscription)));
        }

    }
}
