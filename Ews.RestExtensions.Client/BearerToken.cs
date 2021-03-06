﻿using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Ews.RestExtensions.Client
{
    public class BearerToken
    {
        private readonly DateTimeOffset _createdOn;

        #region Constructor
        public BearerToken()
        {
            _createdOn = DateTimeOffset.UtcNow;
        }
        #endregion

        #region TokenUri
        /// <summary>
        /// The complete URI used to obtain the token
        /// </summary>
        public Uri TokenUri { get; private set; } 
        #endregion

        #region access_token
        public string access_token;
        #endregion

        #region token_type
        public string token_type;
        #endregion

        #region userName
        public string userName;
        #endregion

        #region expires_in
        public long expires_in;
        #endregion

        #region HasExpired
        public bool HasExpired => (DateTimeOffset.UtcNow - _createdOn).TotalMilliseconds > expires_in;
        #endregion

        #region ObtainToken
        /// <summary>
        /// Requests a Bearer Token from baseAddress/tokenActionName and returns it.
        /// </summary>
        /// <param name="baseAddress">The servers base address (do not include the route here).</param>
        /// <param name="username">Username to authenticate with.</param>
        /// <param name="password">Password to authenticate with.</param>
        /// <param name="tokenActionName"></param>
        public static BearerToken ObtainToken(Uri baseAddress, string username, string password, string tokenActionName = "GetToken")
        {
            var cookieContainer = new CookieContainer();

            using (var handler = new HttpClientHandler { CookieContainer = cookieContainer })
            using (var client = new HttpClient(handler))
            {
                try
                {
                    client.BaseAddress = baseAddress;
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var requestContent = new StringContent($"grant_type=password&username={username}&password={password}");
                    var uri = new Uri(client.BaseAddress + tokenActionName);
                    var response = client.PostAsync(uri, requestContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = response.Content.ReadAsAsync<BearerToken>();
                        var token = responseContent.Result;
                        token.TokenUri = uri;
                        return token;
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                return null;
            }
        }
        #endregion
    }
}
