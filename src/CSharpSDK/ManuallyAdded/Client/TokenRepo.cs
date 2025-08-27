extern alias LBTNewtonsoft;  extern alias LBTRestSharp; using System;
using System.Collections.Generic;
using LBTRestSharp::RestSharp;
using Pollination;

namespace PollinationSDK.Client
{
    /// <summary>
    /// TokenRepo is responsible for holding and acquiring auth tokens
    /// </summary>
    public class TokenRepo
    {
        private static Microsoft.Extensions.Logging.ILogger Logger => LogUtils.GetLogger<TokenRepo>();
        public string RefreshURL;
        private string IDToken;
        public DateTime ExpiresAt;
        public string RefreshToken;

        public TokenRepo(string refreshURL, string idToken, int expiresInSeconds, string refreshToken)
        {
            RefreshURL = refreshURL;
            IDToken = idToken;

            // make it expire 1 mins early so that it refresh token before expiration.
            ExpiresAt = DateTime.Now.AddSeconds(expiresInSeconds - 60);
            RefreshToken = refreshToken;
            this.LogTokenExpiration();
        }

        private void LogTokenExpiration()
        {
            Logger.Info($"Token expires at: {ExpiresAt}");
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
            var seconds = int.Parse(res.Data["expires_in"]);
            this.ExpiresAt = DateTime.Now.AddSeconds(seconds);
            this.RefreshToken = res.Data["refresh_token"];
        }

        private void DoTokenRefreshLogged()
        {
            Logger.Info("Refreshing token");
            this.DoTokenRefresh();
            Logger.Info("Token refresh finished");
            this.LogTokenExpiration();
        }

        public void CheckToken()
        {
            if (DateTime.Now < this.ExpiresAt)
                return;

            this.DoTokenRefreshLogged();
        }

        public string GetToken()
        {
            CheckToken();
            return this.IDToken;
        }
    }
}
