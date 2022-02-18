/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.26.1
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
    public interface ISubscriptionPlansApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List Subscription Plans
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="planType">Plan Type (optional)</param>
        /// <returns>List&lt;SubscriptionPlan&gt;</returns>
        List<SubscriptionPlan> ListSubscriptionPlans (PlanType? planType = default);

        /// <summary>
        /// List Subscription Plans
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="planType">Plan Type (optional)</param>
        /// <returns>ApiResponse of List&lt;SubscriptionPlan&gt;</returns>
        ApiResponse<List<SubscriptionPlan>> ListSubscriptionPlansWithHttpInfo (PlanType? planType = default);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// List Subscription Plans
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="planType">Plan Type (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;SubscriptionPlan&gt;</returns>
        System.Threading.Tasks.Task<List<SubscriptionPlan>> ListSubscriptionPlansAsync (PlanType? planType = default, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List Subscription Plans
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="planType">Plan Type (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;SubscriptionPlan&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SubscriptionPlan>>> ListSubscriptionPlansWithHttpInfoAsync (PlanType? planType = default, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SubscriptionPlansApi : ISubscriptionPlansApi
    {
        private PollinationSDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPlansApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SubscriptionPlansApi(String basePath)
        {
            this.Configuration = new PollinationSDK.Client.Configuration { BasePath = basePath };

            ExceptionFactory = PollinationSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPlansApi"/> class
        /// </summary>
        /// <returns></returns>
        public SubscriptionPlansApi()
        {
            this.Configuration = PollinationSDK.Client.Configuration.Default;

            ExceptionFactory = PollinationSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPlansApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SubscriptionPlansApi(PollinationSDK.Client.Configuration configuration = null)
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
        /// List Subscription Plans 
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="planType">Plan Type (optional)</param>
        /// <returns>List&lt;SubscriptionPlan&gt;</returns>
        public List<SubscriptionPlan> ListSubscriptionPlans (PlanType? planType = default)
        {
             ApiResponse<List<SubscriptionPlan>> localVarResponse = ListSubscriptionPlansWithHttpInfo(planType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Subscription Plans 
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="planType">Plan Type (optional)</param>
        /// <returns>ApiResponse of List&lt;SubscriptionPlan&gt;</returns>
        public ApiResponse<List<SubscriptionPlan>> ListSubscriptionPlansWithHttpInfo (PlanType? planType = default)
        {

            var localVarPath = "/subscription-plans/";
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

            if (planType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "plan-type", planType)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListSubscriptionPlans", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SubscriptionPlan>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<SubscriptionPlan>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SubscriptionPlan>)));
        }

        /// <summary>
        /// List Subscription Plans 
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="planType">Plan Type (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;SubscriptionPlan&gt;</returns>
        public async System.Threading.Tasks.Task<List<SubscriptionPlan>> ListSubscriptionPlansAsync (PlanType? planType = default, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<SubscriptionPlan>> localVarResponse = await ListSubscriptionPlansWithHttpInfoAsync(planType, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Subscription Plans 
        /// </summary>
        /// <exception cref="PollinationSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="planType">Plan Type (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;SubscriptionPlan&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SubscriptionPlan>>> ListSubscriptionPlansWithHttpInfoAsync (PlanType? planType = default, CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/subscription-plans/";
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

            if (planType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "plan-type", planType)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListSubscriptionPlans", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SubscriptionPlan>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<SubscriptionPlan>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SubscriptionPlan>)));
        }

    }
}
