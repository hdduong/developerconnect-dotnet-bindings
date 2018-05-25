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
 * Contacts
 *
 * Represents borrower and business contacts
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
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Elli.Api.Contacts.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBorrowerContactSelectorApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve Borrower Contacts
        /// </summary>
        /// <remarks>
        /// Retrieve and paginate through borrower contacts
        /// </remarks>
        /// <exception cref="Elli.Api.Contacts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Start index or record number to retrieve a set of borrower contacts. (optional)</param>
        /// <param name="limit">This is the maximum number of records user wants to fetch. Response size is limited to 6 MB hence this is recalculated if response size exceeds 6 MB. Default value is 1000 and max value for this parameter is limited to 10000 in any case. (optional)</param>
        /// <param name="cursorType">This should be passed when user wants to create a new cursor. Only RandomAccess cursor type is supported. (optional)</param>
        /// <param name="cursor">Id of the cursor from which data needs to be retrieved. This is responded in location header while creating a new cursor. (optional)</param>
        /// <param name="request">Borrower contact query object (optional)</param>
        /// <returns>List&lt;BorrowerContactSelectorContract&gt;</returns>
        List<BorrowerContactSelectorContract> QueryBorrowerContacts (string start = null, string limit = null, string cursorType = null, string cursor = null, BorrowerContactQueryContract request = null);

        /// <summary>
        /// Retrieve Borrower Contacts
        /// </summary>
        /// <remarks>
        /// Retrieve and paginate through borrower contacts
        /// </remarks>
        /// <exception cref="Elli.Api.Contacts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Start index or record number to retrieve a set of borrower contacts. (optional)</param>
        /// <param name="limit">This is the maximum number of records user wants to fetch. Response size is limited to 6 MB hence this is recalculated if response size exceeds 6 MB. Default value is 1000 and max value for this parameter is limited to 10000 in any case. (optional)</param>
        /// <param name="cursorType">This should be passed when user wants to create a new cursor. Only RandomAccess cursor type is supported. (optional)</param>
        /// <param name="cursor">Id of the cursor from which data needs to be retrieved. This is responded in location header while creating a new cursor. (optional)</param>
        /// <param name="request">Borrower contact query object (optional)</param>
        /// <returns>ApiResponse of List&lt;BorrowerContactSelectorContract&gt;</returns>
        ApiResponse<List<BorrowerContactSelectorContract>> QueryBorrowerContactsWithHttpInfo (string start = null, string limit = null, string cursorType = null, string cursor = null, BorrowerContactQueryContract request = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve Borrower Contacts
        /// </summary>
        /// <remarks>
        /// Retrieve and paginate through borrower contacts
        /// </remarks>
        /// <exception cref="Elli.Api.Contacts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Start index or record number to retrieve a set of borrower contacts. (optional)</param>
        /// <param name="limit">This is the maximum number of records user wants to fetch. Response size is limited to 6 MB hence this is recalculated if response size exceeds 6 MB. Default value is 1000 and max value for this parameter is limited to 10000 in any case. (optional)</param>
        /// <param name="cursorType">This should be passed when user wants to create a new cursor. Only RandomAccess cursor type is supported. (optional)</param>
        /// <param name="cursor">Id of the cursor from which data needs to be retrieved. This is responded in location header while creating a new cursor. (optional)</param>
        /// <param name="request">Borrower contact query object (optional)</param>
        /// <returns>Task of List&lt;BorrowerContactSelectorContract&gt;</returns>
        System.Threading.Tasks.Task<List<BorrowerContactSelectorContract>> QueryBorrowerContactsAsync (string start = null, string limit = null, string cursorType = null, string cursor = null, BorrowerContactQueryContract request = null);

        /// <summary>
        /// Retrieve Borrower Contacts
        /// </summary>
        /// <remarks>
        /// Retrieve and paginate through borrower contacts
        /// </remarks>
        /// <exception cref="Elli.Api.Contacts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Start index or record number to retrieve a set of borrower contacts. (optional)</param>
        /// <param name="limit">This is the maximum number of records user wants to fetch. Response size is limited to 6 MB hence this is recalculated if response size exceeds 6 MB. Default value is 1000 and max value for this parameter is limited to 10000 in any case. (optional)</param>
        /// <param name="cursorType">This should be passed when user wants to create a new cursor. Only RandomAccess cursor type is supported. (optional)</param>
        /// <param name="cursor">Id of the cursor from which data needs to be retrieved. This is responded in location header while creating a new cursor. (optional)</param>
        /// <param name="request">Borrower contact query object (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;BorrowerContactSelectorContract&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<BorrowerContactSelectorContract>>> QueryBorrowerContactsAsyncWithHttpInfo (string start = null, string limit = null, string cursorType = null, string cursor = null, BorrowerContactQueryContract request = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BorrowerContactSelectorApi : IBorrowerContactSelectorApi
    {
        private Elli.Api.Contacts.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BorrowerContactSelectorApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BorrowerContactSelectorApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Elli.Api.Contacts.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BorrowerContactSelectorApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BorrowerContactSelectorApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Elli.Api.Contacts.Client.Configuration.DefaultExceptionFactory;

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
        public Elli.Api.Contacts.Client.ExceptionFactory ExceptionFactory
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
        /// Retrieve Borrower Contacts Retrieve and paginate through borrower contacts
        /// </summary>
        /// <exception cref="Elli.Api.Contacts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Start index or record number to retrieve a set of borrower contacts. (optional)</param>
        /// <param name="limit">This is the maximum number of records user wants to fetch. Response size is limited to 6 MB hence this is recalculated if response size exceeds 6 MB. Default value is 1000 and max value for this parameter is limited to 10000 in any case. (optional)</param>
        /// <param name="cursorType">This should be passed when user wants to create a new cursor. Only RandomAccess cursor type is supported. (optional)</param>
        /// <param name="cursor">Id of the cursor from which data needs to be retrieved. This is responded in location header while creating a new cursor. (optional)</param>
        /// <param name="request">Borrower contact query object (optional)</param>
        /// <returns>List&lt;BorrowerContactSelectorContract&gt;</returns>
        public List<BorrowerContactSelectorContract> QueryBorrowerContacts (string start = null, string limit = null, string cursorType = null, string cursor = null, BorrowerContactQueryContract request = null)
        {
             ApiResponse<List<BorrowerContactSelectorContract>> localVarResponse = QueryBorrowerContactsWithHttpInfo(start, limit, cursorType, cursor, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve Borrower Contacts Retrieve and paginate through borrower contacts
        /// </summary>
        /// <exception cref="Elli.Api.Contacts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Start index or record number to retrieve a set of borrower contacts. (optional)</param>
        /// <param name="limit">This is the maximum number of records user wants to fetch. Response size is limited to 6 MB hence this is recalculated if response size exceeds 6 MB. Default value is 1000 and max value for this parameter is limited to 10000 in any case. (optional)</param>
        /// <param name="cursorType">This should be passed when user wants to create a new cursor. Only RandomAccess cursor type is supported. (optional)</param>
        /// <param name="cursor">Id of the cursor from which data needs to be retrieved. This is responded in location header while creating a new cursor. (optional)</param>
        /// <param name="request">Borrower contact query object (optional)</param>
        /// <returns>ApiResponse of List&lt;BorrowerContactSelectorContract&gt;</returns>
        public ApiResponse< List<BorrowerContactSelectorContract> > QueryBorrowerContactsWithHttpInfo (string start = null, string limit = null, string cursorType = null, string cursor = null, BorrowerContactQueryContract request = null)
        {

            var localVarPath = "/encompass/v1/borrowerContactSelector/";
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

            if (start != null) localVarQueryParams.Add("start", Configuration.ApiClient.ParameterToString(start)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (cursorType != null) localVarQueryParams.Add("cursorType", Configuration.ApiClient.ParameterToString(cursorType)); // query parameter
            if (cursor != null) localVarQueryParams.Add("cursor", Configuration.ApiClient.ParameterToString(cursor)); // query parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
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
                Exception exception = ExceptionFactory("QueryBorrowerContacts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<BorrowerContactSelectorContract>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BorrowerContactSelectorContract>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BorrowerContactSelectorContract>)));
        }

        /// <summary>
        /// Retrieve Borrower Contacts Retrieve and paginate through borrower contacts
        /// </summary>
        /// <exception cref="Elli.Api.Contacts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Start index or record number to retrieve a set of borrower contacts. (optional)</param>
        /// <param name="limit">This is the maximum number of records user wants to fetch. Response size is limited to 6 MB hence this is recalculated if response size exceeds 6 MB. Default value is 1000 and max value for this parameter is limited to 10000 in any case. (optional)</param>
        /// <param name="cursorType">This should be passed when user wants to create a new cursor. Only RandomAccess cursor type is supported. (optional)</param>
        /// <param name="cursor">Id of the cursor from which data needs to be retrieved. This is responded in location header while creating a new cursor. (optional)</param>
        /// <param name="request">Borrower contact query object (optional)</param>
        /// <returns>Task of List&lt;BorrowerContactSelectorContract&gt;</returns>
        public async System.Threading.Tasks.Task<List<BorrowerContactSelectorContract>> QueryBorrowerContactsAsync (string start = null, string limit = null, string cursorType = null, string cursor = null, BorrowerContactQueryContract request = null)
        {
             ApiResponse<List<BorrowerContactSelectorContract>> localVarResponse = await QueryBorrowerContactsAsyncWithHttpInfo(start, limit, cursorType, cursor, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve Borrower Contacts Retrieve and paginate through borrower contacts
        /// </summary>
        /// <exception cref="Elli.Api.Contacts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Start index or record number to retrieve a set of borrower contacts. (optional)</param>
        /// <param name="limit">This is the maximum number of records user wants to fetch. Response size is limited to 6 MB hence this is recalculated if response size exceeds 6 MB. Default value is 1000 and max value for this parameter is limited to 10000 in any case. (optional)</param>
        /// <param name="cursorType">This should be passed when user wants to create a new cursor. Only RandomAccess cursor type is supported. (optional)</param>
        /// <param name="cursor">Id of the cursor from which data needs to be retrieved. This is responded in location header while creating a new cursor. (optional)</param>
        /// <param name="request">Borrower contact query object (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;BorrowerContactSelectorContract&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<BorrowerContactSelectorContract>>> QueryBorrowerContactsAsyncWithHttpInfo (string start = null, string limit = null, string cursorType = null, string cursor = null, BorrowerContactQueryContract request = null)
        {

            var localVarPath = "/encompass/v1/borrowerContactSelector/";
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

            if (start != null) localVarQueryParams.Add("start", Configuration.ApiClient.ParameterToString(start)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (cursorType != null) localVarQueryParams.Add("cursorType", Configuration.ApiClient.ParameterToString(cursorType)); // query parameter
            if (cursor != null) localVarQueryParams.Add("cursor", Configuration.ApiClient.ParameterToString(cursor)); // query parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
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
                Exception exception = ExceptionFactory("QueryBorrowerContacts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<BorrowerContactSelectorContract>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BorrowerContactSelectorContract>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BorrowerContactSelectorContract>)));
        }

    }
}
