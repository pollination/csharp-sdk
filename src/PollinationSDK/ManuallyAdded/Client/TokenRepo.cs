using System;
using System.Collections.Generic;
using RestSharp;

namespace PollinationSDK.Client
{
    /// <summary>
    /// TokenRepo is responsible for holding and acquiring auth tokens
    /// </summary>
    public class TokenRepo
    {
        public string RefreshURL;
        private string IDToken;
        public DateTime ExpiresAt;
        public string RefreshToken;

        public TokenRepo(string refreshURL, string idToken, int expiresInSeconds, string refreshToken)
        {
            RefreshURL = refreshURL;
            IDToken = idToken;
            ExpiresAt = DateTime.Now.AddSeconds(expiresInSeconds);
            RefreshToken = refreshToken;
            this.LogTokenExpiration();
        }

        private void LogTokenExpiration()
        {
            Helper.Logger.Information($"Token expires at: {ExpiresAt}");
        }

        private void DoTokenRefresh()
        {
            var client = new RestClient(this.RefreshURL);

            var req = new RestRequest().AddJsonBody(
                new Dictionary<string, string>
                {
                    {"token", this.RefreshToken}
                }
                );

            var res = client.Post<Dictionary<string, string>>(req);

            string detail = null;

            res.Data.TryGetValue("detail", out detail);
            res.Data.TryGetValue("message", out detail);

            if (detail != null)
            {
                throw new Exception(detail);
            }

            this.IDToken = res.Data["id_token"];
            this.ExpiresAt = DateTime.Now.AddSeconds(int.Parse(res.Data["expires_in"]));
            this.RefreshToken = res.Data["refresh_token"];
        }

        private void DoTokenRefreshLogged()
        {
            Helper.Logger.Information("Refreshing token");
            this.DoTokenRefresh();
            Helper.Logger.Information("Token refresh finished");
            this.LogTokenExpiration();
        }
        public string GetToken()
        {
            if (DateTime.Now >= this.ExpiresAt)
            {
                this.DoTokenRefreshLogged();
            }

            return this.IDToken;
        }
    }
}
