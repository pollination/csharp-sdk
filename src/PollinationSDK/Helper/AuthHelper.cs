using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using PollinationSDK.Client;

namespace PollinationSDK
{
    public static class AuthHelper
    {
        public struct AuthResult
        {
            public string IDToken;

            public int ExpiresInSeconds;

            public string RefreshToken;

            public static AuthResult From(NameValueCollection queryMap)
            {
                var idToken = queryMap.Get("token");

                var expiresIn = queryMap.Get("expiresIn");

                var expirationSeconds = 3600;

                int.TryParse(expiresIn, out expirationSeconds);

                var refreshToken = queryMap.Get("refreshToken");

                return new AuthResult
                {
                    IDToken = idToken,
                    ExpiresInSeconds = expirationSeconds,
                    RefreshToken = refreshToken
                };
            }
        }

        private static readonly string DevDomain = "staging.";
        private static readonly string AuthURL_Base = "https://auth.{0}pollination.cloud{1}";

        private static readonly string AuthSignInPath = "/sdk-login";

        private static readonly string AuthRefreshPath = "/authAPI/refreshToken";
        private static string LoginURL => string.Format(AuthURL_Base, "", AuthSignInPath);
        private static string LoginURL_Dev => string.Format(AuthURL_Base, DevDomain, AuthSignInPath);
        public static string RefreshURL => string.Format(AuthURL_Base, "", AuthRefreshPath);

        public static string RefreshURL_Dev => string.Format(AuthURL_Base, DevDomain, AuthRefreshPath);

        public static string ApiURL => "https://api.pollination.cloud/";
        public static string ApiURL_Dev => "https://api.staging.pollination.cloud/";

        public static async Task SignInAsync(Action ActionWhenDone = default, bool devEnv = false)
        {
            //OutputMessage = string.Empty;
            try
            {
                Helper.CurrentUser = null;
                var task = PollinationSignInAsync(devEnv);
                var authResult = await task;
                if (string.IsNullOrEmpty(authResult.IDToken))
                    throw new ArgumentException($"SignInAsync: Failed to get the Auth token");

                if (Helper.CurrentUser == null)
                    throw new ArgumentException($"SignInAsync: Failed to sign in to the Pollination");

                ActionWhenDone?.Invoke();
            }
            catch (Exception e)
            {
                Helper.Logger?.Error(e, "Failed to sign in");
                //Console.WriteLine(e.Message);
                throw e;
            }

        }

        public static async Task SignInWithApiAuthAsync(string apiAuth, Action ActionWhenDone = default, bool devEnv = false)
        {
            //OutputMessage = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(apiAuth))
                {
                    Configuration.Default.BasePath = devEnv ? ApiURL_Dev : ApiURL;
                    Configuration.Default.AddApiKey("x-pollination-token", apiAuth);
                    Helper.CurrentUser = Helper.GetUser();
                    Helper.Logger.Information($"SignInWithApiAuthAsync: logged in as {Helper.CurrentUser.Username}");
                }
                else
                {
                    Helper.Logger.Warning($"SignInWithApiAuthAsync: Invalid apiAuth");
                }

                ActionWhenDone?.Invoke();
            }
            catch (Exception e)
            {
                Helper.Logger?.Error(e, "Failed to sign in");
                //Console.WriteLine(e.Message);
                throw e;
            }

        }


        private static async Task<AuthResult> PollinationSignInAsync(bool devEnv = false)
        {
            if (!HttpListener.IsSupported)
            {
                Helper.Logger.Error($"PollinationSignInAsync: HttpListener is not supported on this system");
                throw new ArgumentException("PollinationSignIn is not supported on this system");
            }

            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                Helper.Logger.Error($"PollinationSignInAsync: Network is not available, please double check with your connection or firewall!");
                throw new ArgumentException("Network is not available, please double check with your connection or firewall!");
            }

            var redirectUrl = "http://localhost:8645/";
            var loginUrl = devEnv ? LoginURL_Dev : LoginURL;

            var listener = new System.Net.HttpListener();
            try
            {
                try
                {

                    listener.Prefixes.Add(redirectUrl);
                    listener.Start();
                    //listener.TimeoutManager.IdleConnection = TimeSpan.FromSeconds(30);
                    //listener.TimeoutManager.HeaderWait = TimeSpan.FromSeconds(30);

                }
                catch (HttpListenerException e)
                {
                    //it is already listening the port, but users didn't login
                    if (e.ErrorCode == 183)
                    {
                        Console.WriteLine(e.Message);
                        Helper.Logger.Warning($"PollinationSignInAsync: it is still waiting for users to login from last time.\n{e.Message}");
                    }
                    else
                    {
                        Helper.Logger.Error($"PollinationSignInAsync: Failed to start the listener.\n{e.Message}");
                        throw e;
                    }

                }

                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = loginUrl,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
                Helper.Logger.Information($"PollinationSignInAsync: login from {loginUrl}");

                // wait for the authorization response.
                var context = await listener.GetContextAsync();

                var request = context.Request;
                var response = context.Response;

                var returnUrl = request.RawUrl.Contains("?token=") ? request.RawUrl : request.UrlReferrer?.PathAndQuery;
                if (string.IsNullOrEmpty(returnUrl))
                {
                    Helper.Logger.Error($"PollinationSignInAsync: Failed to authorize the login: \n{request.RawUrl}");
                    throw new ArgumentException($"Failed to authorize the login: \n{request.RawUrl}");
                }

                var auth = AuthResult.From(request.QueryString);
                var loggedIn = CheckGetUser(auth, out var error, devEnv);

                var message = string.Empty;
                if (loggedIn)
                    message = $"<h1>Authorization was successful!</h1><h4>{Helper.CurrentUser.Name} ({Helper.CurrentUser.Username})</h4><p>You can close this browser window.</p>";
                else
                    message = $"<h1>Invalid authorization!</h1><p>{error}</p><p>Please report the issue with your account to https://discourse.pollination.cloud.</p>";

                //sends an HTTP response to the browser.
                var responseString = $"<html><head></head><body style=\"text-align: center; font-family: Lato, Helvetica, Arial, sans-serif\"><img src=\"https://app.pollination.cloud/logo.svg\" width=\"128px\">{message}</body></html>";

                var buffer = Encoding.UTF8.GetBytes(responseString);
                response.ContentLength64 = buffer.Length;
                var responseOutput = response.OutputStream;
                await responseOutput.WriteAsync(buffer, 0, buffer.Length);
                await Task.Delay(1000);
                responseOutput.Flush();
                responseOutput.Close();

                Helper.Logger.Information($"PollinationSignInAsync: closing the listener");

                return auth;
            }
            finally
            {
                listener.Stop();
            }
            
          
        }

        private static bool CheckGetUser(AuthResult auth, out string errorMessage, bool devEnv = false)
        {
            errorMessage = string.Empty;
            try
            {
                Configuration.Default.BasePath = devEnv ? ApiURL_Dev : ApiURL;

                Configuration.Default.TokenRepo = new TokenRepo(
                    refreshURL: devEnv ? RefreshURL_Dev : RefreshURL,
                    idToken: auth.IDToken,
                    expiresInSeconds: auth.ExpiresInSeconds,
                    refreshToken: auth.RefreshToken
                );
                Helper.CurrentUser = Helper.GetUser();
                Helper.Logger?.Information($"CheckGetUser: logged in as {Helper.CurrentUser.Username}");

                return true;

            }
            catch (Exception e)
            {
                Configuration.Default.TokenRepo = null;
                Helper.CurrentUser = null;
                Helper.Logger?.Error(e, $"CheckGetUser()");
                errorMessage = e.Message;
                return false;
                //throw;
            }
        
        }
    }
}
