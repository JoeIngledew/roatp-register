﻿using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using SFA.Roatp.Api.Types;

namespace SFA.Roatp.Api.Client
{
    public class RoatpApiClient : ApiClientBase, IRoatpClient
    {
        public RoatpApiClient(string baseUri = null) : base(baseUri)
        {
        }

        /// <summary>
        /// Get a provider details
        /// GET /providers/{provider-ukprn}
        /// </summary>
        /// <param name="providerUkprn">an integer for the provider ukprn</param>
        /// <returns>a provider details based on ukprn</returns>
        public Provider Get(string providerUkprn)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, $"/api/providers/{providerUkprn}"))
            {
                request.Headers.Add("Accept", "application/json");

                using (var response = _httpClient.SendAsync(request))
                {
                    var result = response.Result;
                    if (result.StatusCode == HttpStatusCode.OK)
                    {
                        return JsonConvert.DeserializeObject<Provider>(result.Content.ReadAsStringAsync().Result,
                            _jsonSettings);
                    }
                    if (result.StatusCode == HttpStatusCode.NotFound)
                    {
                        RaiseResponseError($"The provider {providerUkprn} could not be found", request, result);
                    }

                    RaiseResponseError(request, result);
                }

                return null;
            }
        }

        public Provider Get(long providerUkprn)
        {
            return Get(providerUkprn.ToString());
        }

        public Provider Get(int providerUkprn)
        {
            return Get(providerUkprn.ToString());
        }

        /// <summary>
        /// Check if a provider exists
        /// HEAD /providers/{provider-ukprn}
        /// </summary>
        /// <param name="providerUkprn">an integer for the provider ukprn</param>
        /// <returns>bool</returns>
        public bool Exists(string providerUkprn)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Head, $"/api/providers/{providerUkprn}"))
            {
                request.Headers.Add("Accept", "application/json");

                using (var response = _httpClient.SendAsync(request))
                {
                    var result = response.Result;
                    if (result.StatusCode == HttpStatusCode.NoContent)
                    {
                        return true;
                    }
                    if (result.StatusCode == HttpStatusCode.NotFound)
                    {
                        return false;
                    }

                    RaiseResponseError("Unexpected exception", request, result);
                }

                return false;
            }
        }

        public IEnumerable<Provider> FindAll()
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, "/api/providers"))
            {
                request.Headers.Add("Accept", "application/json");

                using (var response = _httpClient.SendAsync(request))
                {
                    var result = response.Result;
                    if (result.StatusCode == HttpStatusCode.OK)
                    {
                        return JsonConvert.DeserializeObject<IEnumerable<Provider>>(result.Content.ReadAsStringAsync().Result, _jsonSettings);
                    }

                    RaiseResponseError(request, result);
                }

                return null;
            }
        }
    }
}
