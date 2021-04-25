/* 
 * Dronelogbook API
 *
 * This is the swagger file that describes Dronelogbook API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@dronelogbook.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Dronelogbook.Client;
using Dronelogbook.Model;

namespace Dronelogbook.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFlightApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns the list of flights
        /// </summary>
        /// <remarks>
        /// Returns the list of flights according to your access rights
        /// </remarks>
        /// <exception cref="Dronelogbook.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numPage">Page Number (optional)</param>
        /// <returns>Flight</returns>
        Flight EndpointFlightReadAll (int? numPage = null);

        /// <summary>
        /// Returns the list of flights
        /// </summary>
        /// <remarks>
        /// Returns the list of flights according to your access rights
        /// </remarks>
        /// <exception cref="Dronelogbook.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numPage">Page Number (optional)</param>
        /// <returns>ApiResponse of Flight</returns>
        ApiResponse<Flight> EndpointFlightReadAllWithHttpInfo (int? numPage = null);
        /// <summary>
        /// Finds flight by guid
        /// </summary>
        /// <remarks>
        /// Returns single flight according to your access rights
        /// </remarks>
        /// <exception cref="Dronelogbook.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">guid of flight to return</param>
        /// <returns>Flight</returns>
        Flight EndpointFlightReadOne (string guid);

        /// <summary>
        /// Finds flight by guid
        /// </summary>
        /// <remarks>
        /// Returns single flight according to your access rights
        /// </remarks>
        /// <exception cref="Dronelogbook.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">guid of flight to return</param>
        /// <returns>ApiResponse of Flight</returns>
        ApiResponse<Flight> EndpointFlightReadOneWithHttpInfo (string guid);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns the list of flights
        /// </summary>
        /// <remarks>
        /// Returns the list of flights according to your access rights
        /// </remarks>
        /// <exception cref="Dronelogbook.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numPage">Page Number (optional)</param>
        /// <returns>Task of Flight</returns>
        System.Threading.Tasks.Task<Flight> EndpointFlightReadAllAsync (int? numPage = null);

        /// <summary>
        /// Returns the list of flights
        /// </summary>
        /// <remarks>
        /// Returns the list of flights according to your access rights
        /// </remarks>
        /// <exception cref="Dronelogbook.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numPage">Page Number (optional)</param>
        /// <returns>Task of ApiResponse (Flight)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flight>> EndpointFlightReadAllAsyncWithHttpInfo (int? numPage = null);
        /// <summary>
        /// Finds flight by guid
        /// </summary>
        /// <remarks>
        /// Returns single flight according to your access rights
        /// </remarks>
        /// <exception cref="Dronelogbook.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">guid of flight to return</param>
        /// <returns>Task of Flight</returns>
        System.Threading.Tasks.Task<Flight> EndpointFlightReadOneAsync (string guid);

        /// <summary>
        /// Finds flight by guid
        /// </summary>
        /// <remarks>
        /// Returns single flight according to your access rights
        /// </remarks>
        /// <exception cref="Dronelogbook.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">guid of flight to return</param>
        /// <returns>Task of ApiResponse (Flight)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flight>> EndpointFlightReadOneAsyncWithHttpInfo (string guid);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FlightApi : IFlightApi
    {
        private Dronelogbook.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FlightApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FlightApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Dronelogbook.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlightApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FlightApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Dronelogbook.Client.Configuration.DefaultExceptionFactory;

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
        public Dronelogbook.Client.ExceptionFactory ExceptionFactory
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
        /// Returns the list of flights Returns the list of flights according to your access rights
        /// </summary>
        /// <exception cref="Dronelogbook.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numPage">Page Number (optional)</param>
        /// <returns>Flight</returns>
        public Flight EndpointFlightReadAll (int? numPage = null)
        {
             ApiResponse<Flight> localVarResponse = EndpointFlightReadAllWithHttpInfo(numPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the list of flights Returns the list of flights according to your access rights
        /// </summary>
        /// <exception cref="Dronelogbook.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numPage">Page Number (optional)</param>
        /// <returns>ApiResponse of Flight</returns>
        public ApiResponse< Flight > EndpointFlightReadAllWithHttpInfo (int? numPage = null)
        {

            var localVarPath = "/flight";
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

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (numPage != null) localVarQueryParams.Add("num_page", Configuration.ApiClient.ParameterToString(numPage)); // query parameter

            // authentication (APIKeyHeader) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKey")))
            {
                localVarHeaderParams["ApiKey"] = Configuration.GetApiKeyWithPrefix("ApiKey");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EndpointFlightReadAll", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Flight>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flight) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flight)));
            
        }

        /// <summary>
        /// Returns the list of flights Returns the list of flights according to your access rights
        /// </summary>
        /// <exception cref="Dronelogbook.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numPage">Page Number (optional)</param>
        /// <returns>Task of Flight</returns>
        public async System.Threading.Tasks.Task<Flight> EndpointFlightReadAllAsync (int? numPage = null)
        {
             ApiResponse<Flight> localVarResponse = await EndpointFlightReadAllAsyncWithHttpInfo(numPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns the list of flights Returns the list of flights according to your access rights
        /// </summary>
        /// <exception cref="Dronelogbook.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numPage">Page Number (optional)</param>
        /// <returns>Task of ApiResponse (Flight)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flight>> EndpointFlightReadAllAsyncWithHttpInfo (int? numPage = null)
        {

            var localVarPath = "/flight";
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

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (numPage != null) localVarQueryParams.Add("num_page", Configuration.ApiClient.ParameterToString(numPage)); // query parameter

            // authentication (APIKeyHeader) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKey")))
            {
                localVarHeaderParams["ApiKey"] = Configuration.GetApiKeyWithPrefix("ApiKey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EndpointFlightReadAll", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Flight>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flight) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flight)));
            
        }

        /// <summary>
        /// Finds flight by guid Returns single flight according to your access rights
        /// </summary>
        /// <exception cref="Dronelogbook.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">guid of flight to return</param>
        /// <returns>Flight</returns>
        public Flight EndpointFlightReadOne (string guid)
        {
             ApiResponse<Flight> localVarResponse = EndpointFlightReadOneWithHttpInfo(guid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Finds flight by guid Returns single flight according to your access rights
        /// </summary>
        /// <exception cref="Dronelogbook.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">guid of flight to return</param>
        /// <returns>ApiResponse of Flight</returns>
        public ApiResponse< Flight > EndpointFlightReadOneWithHttpInfo (string guid)
        {
            // verify the required parameter 'guid' is set
            if (guid == null)
                throw new ApiException(400, "Missing required parameter 'guid' when calling FlightApi->EndpointFlightReadOne");

            var localVarPath = "/flight/{guid}";
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

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (guid != null) localVarPathParams.Add("guid", Configuration.ApiClient.ParameterToString(guid)); // path parameter

            // authentication (APIKeyHeader) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKey")))
            {
                localVarHeaderParams["ApiKey"] = Configuration.GetApiKeyWithPrefix("ApiKey");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EndpointFlightReadOne", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Flight>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flight) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flight)));
            
        }

        /// <summary>
        /// Finds flight by guid Returns single flight according to your access rights
        /// </summary>
        /// <exception cref="Dronelogbook.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">guid of flight to return</param>
        /// <returns>Task of Flight</returns>
        public async System.Threading.Tasks.Task<Flight> EndpointFlightReadOneAsync (string guid)
        {
             ApiResponse<Flight> localVarResponse = await EndpointFlightReadOneAsyncWithHttpInfo(guid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Finds flight by guid Returns single flight according to your access rights
        /// </summary>
        /// <exception cref="Dronelogbook.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid">guid of flight to return</param>
        /// <returns>Task of ApiResponse (Flight)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flight>> EndpointFlightReadOneAsyncWithHttpInfo (string guid)
        {
            // verify the required parameter 'guid' is set
            if (guid == null)
                throw new ApiException(400, "Missing required parameter 'guid' when calling FlightApi->EndpointFlightReadOne");

            var localVarPath = "/flight/{guid}";
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

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (guid != null) localVarPathParams.Add("guid", Configuration.ApiClient.ParameterToString(guid)); // path parameter

            // authentication (APIKeyHeader) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKey")))
            {
                localVarHeaderParams["ApiKey"] = Configuration.GetApiKeyWithPrefix("ApiKey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EndpointFlightReadOne", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Flight>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flight) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flight)));
            
        }

    }
}