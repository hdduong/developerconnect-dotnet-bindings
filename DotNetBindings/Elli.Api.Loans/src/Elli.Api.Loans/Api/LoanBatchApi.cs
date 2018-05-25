/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/

/* 
 * Loan
 *
 * Returns the entire loan or specific entities of a loan.
 *
 * OpenAPI spec version: 1.2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Elli.Api.Loans.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILoanBatchApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Request ID</param>
        /// <returns></returns>
        void BatchUpdateRequestStatus (string requestId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Request ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> BatchUpdateRequestStatusWithHttpInfo (string requestId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanBatchUpdateContract"> (optional)</param>
        /// <returns></returns>
        void BatchUpdateRequests (LoanBatchUpdateRequestContract loanBatchUpdateContract = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanBatchUpdateContract"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> BatchUpdateRequestsWithHttpInfo (LoanBatchUpdateRequestContract loanBatchUpdateContract = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Request ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task BatchUpdateRequestStatusAsync (string requestId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Request ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> BatchUpdateRequestStatusAsyncWithHttpInfo (string requestId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanBatchUpdateContract"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task BatchUpdateRequestsAsync (LoanBatchUpdateRequestContract loanBatchUpdateContract = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanBatchUpdateContract"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> BatchUpdateRequestsAsyncWithHttpInfo (LoanBatchUpdateRequestContract loanBatchUpdateContract = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LoanBatchApi : ILoanBatchApi
    {
        private Elli.Api.Loans.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoanBatchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LoanBatchApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Elli.Api.Loans.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoanBatchApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LoanBatchApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Elli.Api.Loans.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Elli.Api.Loans.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Request ID</param>
        /// <returns></returns>
        public void BatchUpdateRequestStatus (string requestId)
        {
             BatchUpdateRequestStatusWithHttpInfo(requestId);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Request ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> BatchUpdateRequestStatusWithHttpInfo (string requestId)
        {
            // verify the required parameter 'requestId' is set
            if (requestId == null)
                throw new ApiException(400, "Missing required parameter 'requestId' when calling LoanBatchApi->BatchUpdateRequestStatus");

            var localVarPath = "/encompass/v1/loanBatch/updateRequests/{requestId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (requestId != null) localVarPathParams.Add("requestId", Configuration.ApiClient.ParameterToString(requestId)); // path parameter

            // authentication (bearerAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BatchUpdateRequestStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Request ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task BatchUpdateRequestStatusAsync (string requestId)
        {
             await BatchUpdateRequestStatusAsyncWithHttpInfo(requestId);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Request ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> BatchUpdateRequestStatusAsyncWithHttpInfo (string requestId)
        {
            // verify the required parameter 'requestId' is set
            if (requestId == null)
                throw new ApiException(400, "Missing required parameter 'requestId' when calling LoanBatchApi->BatchUpdateRequestStatus");

            var localVarPath = "/encompass/v1/loanBatch/updateRequests/{requestId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (requestId != null) localVarPathParams.Add("requestId", Configuration.ApiClient.ParameterToString(requestId)); // path parameter

            // authentication (bearerAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BatchUpdateRequestStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanBatchUpdateContract"> (optional)</param>
        /// <returns></returns>
        public void BatchUpdateRequests (LoanBatchUpdateRequestContract loanBatchUpdateContract = null)
        {
             BatchUpdateRequestsWithHttpInfo(loanBatchUpdateContract);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanBatchUpdateContract"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> BatchUpdateRequestsWithHttpInfo (LoanBatchUpdateRequestContract loanBatchUpdateContract = null)
        {

            var localVarPath = "/encompass/v1/loanBatch/updateRequests";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (loanBatchUpdateContract != null && loanBatchUpdateContract.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(loanBatchUpdateContract); // http body (model) parameter
            }
            else
            {
                localVarPostBody = loanBatchUpdateContract; // byte array
            }

            // authentication (bearerAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BatchUpdateRequests", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanBatchUpdateContract"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task BatchUpdateRequestsAsync (LoanBatchUpdateRequestContract loanBatchUpdateContract = null)
        {
             await BatchUpdateRequestsAsyncWithHttpInfo(loanBatchUpdateContract);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanBatchUpdateContract"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> BatchUpdateRequestsAsyncWithHttpInfo (LoanBatchUpdateRequestContract loanBatchUpdateContract = null)
        {

            var localVarPath = "/encompass/v1/loanBatch/updateRequests";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (loanBatchUpdateContract != null && loanBatchUpdateContract.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(loanBatchUpdateContract); // http body (model) parameter
            }
            else
            {
                localVarPostBody = loanBatchUpdateContract; // byte array
            }

            // authentication (bearerAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BatchUpdateRequests", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
