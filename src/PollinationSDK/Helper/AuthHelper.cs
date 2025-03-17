extern alias LBTNewtonsoft;  extern alias LBTRestSharp; using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using PollinationSDK.Client;
using Pollination;

namespace PollinationSDK
{
    public static class AuthHelper
    {
        private static Microsoft.Extensions.Logging.ILogger Logger => LogUtils.GetLogger(nameof(AuthHelper));
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
        private static readonly string AuthURL_Base = "https://auth.{0}pollination.solutions{1}";

        private static readonly string AuthSignInPath = "/sdk-login";

        private static readonly string AuthRefreshPath = "/authAPI/refreshToken";
        private static string LoginURL => string.Format(AuthURL_Base, "", AuthSignInPath);
        private static string LoginURL_Dev => string.Format(AuthURL_Base, DevDomain, AuthSignInPath);
        public static string RefreshURL => string.Format(AuthURL_Base, "", AuthRefreshPath);

        public static string RefreshURL_Dev => string.Format(AuthURL_Base, DevDomain, AuthRefreshPath);

        public static string ApiURL => "https://api.pollination.solutions/";
        public static string ApiURL_Dev => "https://api.staging.pollination.solutions/";

        public static async Task SignInAsync(Action ActionWhenDone = default, bool devEnv = false)
        {
            //OutputMessage = string.Empty;
            try
            {
                Helper.CurrentUser = null;
                var task = PollinationSignInAsync(devEnv);
                var authResult = await task;
                if (string.IsNullOrEmpty(authResult.IDToken))
                    throw new ArgumentException($"Failed to get the Auth token");

                if (Helper.CurrentUser == null)
                    throw new ArgumentException($"Failed to sign in to the Pollination");

                ActionWhenDone?.Invoke();
            }
            catch (Exception e)
            {
                Logger.ThrowError(e);
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
                    Logger.Info($"Logged in as {Helper.CurrentUser.Username}");
                }
                else
                {
                    Logger.Warning($"Invalid apiAuth");
                }

                ActionWhenDone?.Invoke();
            }
            catch (Exception e)
            {
                Logger.ThrowError(e);
            }

        }


        private static async Task<AuthResult> PollinationSignInAsync(bool devEnv = false)
        {
            if (!HttpListener.IsSupported) 
                Logger.ThrowError($"HttpListener is not supported on this system");

            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                Logger.ThrowError($"Network is not available, please double check with your connection or firewall!");

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
                        Logger.Warning($"It is still waiting for users to login from last time.\n{e.Message}");
                    else 
                        Logger.ThrowError($"Failed to start the listener.\n{e.Message}");

                }

                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = loginUrl,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
                Logger.Info($"Login from {loginUrl}");

                // wait for the authorization response.
                var context = await listener.GetContextAsync();

                var request = context.Request;
                var response = context.Response;

                var returnUrl = request.RawUrl.Contains("?token=") ? request.RawUrl : request.UrlReferrer?.PathAndQuery;
                if (string.IsNullOrEmpty(returnUrl)) 
                    Logger.ThrowError($"Failed to authorize the login: \n{request.RawUrl}");

                var auth = AuthResult.From(request.QueryString);
                var loggedIn = CheckGetUser(auth, out var error, devEnv);

                var message = string.Empty;
                if (loggedIn)
                    message = $"<h1>Authorization was successful!</h1><h4>{Helper.CurrentUser.Name} ({Helper.CurrentUser.Username})</h4><p>You can close this browser window.</p>";
                else
                    message = $"<h1>Invalid authorization!</h1><p>{error}</p><p>Please report the issue with your account to https://discourse.pollination.solutions.</p>";

                //sends an HTTP response to the browser.
                var svgLogoBase64 = "data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9Im5vIj8+CjwhRE9DVFlQRSBzdmcgUFVCTElDICItLy9XM0MvL0RURCBTVkcgMS4xLy9FTiIgImh0dHA6Ly93d3cudzMub3JnL0dyYXBoaWNzL1NWRy8xLjEvRFREL3N2ZzExLmR0ZCI+Cjxzdmcgd2lkdGg9IjEwMCUiIGhlaWdodD0iMTAwJSIgdmlld0JveD0iMCAwIDE4MCAxODAiIHZlcnNpb249IjEuMSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeG1sOnNwYWNlPSJwcmVzZXJ2ZSIgeG1sbnM6c2VyaWY9Imh0dHA6Ly93d3cuc2VyaWYuY29tLyIgc3R5bGU9ImZpbGwtcnVsZTpldmVub2RkO2NsaXAtcnVsZTpldmVub2RkO3N0cm9rZS1saW5lam9pbjpyb3VuZDtzdHJva2UtbWl0ZXJsaW1pdDoyOyI+CiAgICA8ZyB0cmFuc2Zvcm09Im1hdHJpeCgwLjU5Nzk0MSwwLDAsMC41OTc5NDEsLTkyLjk2OTksLTE0Ni43ODUpIj4KICAgICAgICA8cGF0aCBkPSJNMjg1LjA5MSw0NTAuMzM5QzI3Mi44OTgsNDY0LjA4OCAyNTQuNzM0LDQ3My43NzEgMjM2LjUyMyw0NzYuMjNDMjM2LjIzOCw0ODkuMTA5IDI0MC4xNjcsNTAzLjM2OCAyNDcuODgzLDUxNS4xNDRDMjU1LjYsNTI2LjkyIDI2Ny4xMDUsNTM2LjIxNSAyNzkuMDI2LDU0MS4wOTVDMjkwLjg0Nyw1NDYuMjE2IDMwNS41MzQsNTQ3Ljk1NSAzMTkuMzUxLDU0NS4yNUMzMzMuMTY4LDU0Mi41NDQgMzQ2LjExNSw1MzUuMzk1IDM1NS4xMzEsNTI2LjE5NEMzNjQuMzMyLDUxNy4xNzggMzcxLjQ4Miw1MDQuMjMxIDM3NC4xODcsNDkwLjQxNEMzNzYuODkzLDQ3Ni41OTcgMzc1LjE1NCw0NjEuOTA5IDM3MC4wMzMsNDUwLjA4OUMzNjUuMTUyLDQzOC4xNjcgMzU1Ljg1OCw0MjYuNjYyIDM0NC4wODIsNDE4Ljk0NkMzMzIuMzA1LDQxMS4yMjkgMzE4LjA0Nyw0MDcuMyAzMDUuMTY4LDQwNy41ODVDMzA0LjA0NSw0MTUuMzk4IDMwMS43NCw0MjMuMTI0IDI5OC4zOTgsNDMwLjI3NEMzMDUuNDg0LDQyNy41ODUgMzE1LjQ0MSw0MzAuNzIyIDMxOS43MDYsNDM2Ljk4N0MzMjQuNTg1LDQ0Mi43ODcgMzI0LjkxMyw0NTMuMjIxIDMyMC40MDksNDU5LjMxN0MzMTYuNTQ2LDQ2NS44MzggMzA2LjgwNyw0NjkuNTk1IDI5OS41NjUsNDY3LjM1N0MyOTIuMTM0LDQ2NS44NjUgMjg1LjM3MSw0NTcuOTEzIDI4NS4wOTEsNDUwLjMzOVoiIHN0eWxlPSJmaWxsOnJnYigyNDIsMTc4LDc3KTtmaWxsLXJ1bGU6bm9uemVybzsiLz4KICAgIDwvZz4KICAgIDxnIHRyYW5zZm9ybT0ibWF0cml4KDAuNTk3OTQxLDAsMCwwLjU5Nzk0MSwtOTIuOTY5OSwtMTQ2Ljc4NSkiPgogICAgICAgIDxwYXRoIGQ9Ik0yNTEuNjYxLDM3NS4wOTFDMjM3LjkxMiwzNjIuODk4IDIyOC4yMjksMzQ0LjczNCAyMjUuNzcsMzI2LjUyM0MyMTIuODkxLDMyNi4yMzggMTk4LjYzMiwzMzAuMTY3IDE4Ni44NTYsMzM3Ljg4M0MxNzUuMDgsMzQ1LjYgMTY1Ljc4NSwzNTcuMTA1IDE2MC45MDUsMzY5LjAyNkMxNTUuNzg0LDM4MC44NDcgMTU0LjA0NSwzOTUuNTM0IDE1Ni43NSw0MDkuMzUxQzE1OS40NTYsNDIzLjE2OCAxNjYuNjA2LDQzNi4xMTUgMTc1LjgwNiw0NDUuMTMxQzE4NC44MjIsNDU0LjMzMiAxOTcuNzY5LDQ2MS40ODIgMjExLjU4Niw0NjQuMTg3QzIyNS40MDQsNDY2Ljg5MyAyNDAuMDkxLDQ2NS4xNTQgMjUxLjkxMSw0NjAuMDMzQzI2My44MzMsNDU1LjE1MiAyNzUuMzM4LDQ0NS44NTggMjgzLjA1NCw0MzQuMDgyQzI5MC43NzEsNDIyLjMwNSAyOTQuNyw0MDguMDQ3IDI5NC40MTUsMzk1LjE2OEMyODYuNjAyLDM5NC4wNDUgMjc4Ljg3NiwzOTEuNzQgMjcxLjcyNiwzODguMzk4QzI3NC40MTUsMzk1LjQ4NCAyNzEuMjc4LDQwNS40NDEgMjY1LjAxMyw0MDkuNzA2QzI1OS4yMTMsNDE0LjU4NSAyNDguNzc5LDQxNC45MTMgMjQyLjY4Myw0MTAuNDA5QzIzNi4xNjIsNDA2LjU0NiAyMzIuNDA2LDM5Ni44MDcgMjM0LjY0MywzODkuNTY1QzIzNi4xMzUsMzgyLjEzNCAyNDQuMDg3LDM3NS4zNzEgMjUxLjY2MSwzNzUuMDkxWiIgc3R5bGU9ImZpbGw6cmdiKDQ1LDE2OSwyMjUpO2ZpbGwtcnVsZTpub256ZXJvOyIvPgogICAgPC9nPgogICAgPGcgdHJhbnNmb3JtPSJtYXRyaXgoMC41OTc5NDEsMCwwLDAuNTk3OTQxLC05Mi45Njk5LC0xNDYuNzg1KSI+CiAgICAgICAgPHBhdGggZD0iTTMyNi45MDksMzQxLjY2MUMzMzkuMTAyLDMyNy45MTIgMzU3LjI2NiwzMTguMjI5IDM3NS40NzcsMzE1Ljc3QzM3NS43NjIsMzAyLjg5MSAzNzEuODMzLDI4OC42MzIgMzY0LjExNywyNzYuODU2QzM1Ni40LDI2NS4wOCAzNDQuODk1LDI1NS43ODUgMzMyLjk3NCwyNTAuOTA1QzMyMS4xNTMsMjQ1Ljc4NCAzMDYuNDY2LDI0NC4wNDUgMjkyLjY0OSwyNDYuNzVDMjc4LjgzMiwyNDkuNDU2IDI2NS44ODUsMjU2LjYwNSAyNTYuODY5LDI2NS44MDZDMjQ3LjY2OCwyNzQuODIyIDI0MC41MTgsMjg3Ljc2OSAyMzcuODEzLDMwMS41ODZDMjM1LjEwNywzMTUuNDA0IDIzNi44NDYsMzMwLjA5MSAyNDEuOTY3LDM0MS45MTFDMjQ2Ljg0OCwzNTMuODMzIDI1Ni4xNDIsMzY1LjMzOCAyNjcuOTE4LDM3My4wNTRDMjc5LjY5NSwzODAuNzcxIDI5My45NTMsMzg0LjcgMzA2LjgzMiwzODQuNDE1QzMwNy45NTUsMzc2LjYwMiAzMTAuMjYsMzY4Ljg3NiAzMTMuNjAyLDM2MS43MjZDMzA2LjUxNiwzNjQuNDE1IDI5Ni41NTksMzYxLjI3OCAyOTIuMjk0LDM1NS4wMTNDMjg3LjQxNSwzNDkuMjEzIDI4Ny4wODcsMzM4Ljc3OSAyOTEuNTkxLDMzMi42ODNDMjk1LjQ1NCwzMjYuMTYyIDMwNS4xOTMsMzIyLjQwNiAzMTIuNDM1LDMyNC42NDNDMzE5Ljg2NiwzMjYuMTM1IDMyNi42MjksMzM0LjA4NyAzMjYuOTA5LDM0MS42NjFaIiBzdHlsZT0iZmlsbDpyZ2IoNCwxNjUsNzkpO2ZpbGwtcnVsZTpub256ZXJvOyIvPgogICAgPC9nPgogICAgPGcgaWQ9IlJlZCIgdHJhbnNmb3JtPSJtYXRyaXgoMC41OTc5NDEsMCwwLDAuNTk3OTQxLC05Mi45Njk5LC0xNDYuNzg1KSI+CiAgICAgICAgPHBhdGggZD0iTTM2MC4zMzksNDE2LjkwOUMzNzQuMDg4LDQyOS4xMDIgMzgzLjc3MSw0NDcuMjY2IDM4Ni4yMyw0NjUuNDc3QzM5OS4xMDksNDY1Ljc2MiA0MTMuMzY4LDQ2MS44MzMgNDI1LjE0NCw0NTQuMTE3QzQzNi45MjEsNDQ2LjQgNDQ2LjIxNSw0MzQuODk1IDQ1MS4wOTUsNDIyLjk3NEM0NTYuMjE2LDQxMS4xNTMgNDU3Ljk1NSwzOTYuNDY2IDQ1NS4yNSwzODIuNjQ5QzQ1Mi41NDQsMzY4LjgzMiA0NDUuMzk1LDM1NS44ODUgNDM2LjE5NCwzNDYuODY5QzQyNy4xNzgsMzM3LjY2OCA0MTQuMjMxLDMzMC41MTggNDAwLjQxNCwzMjcuODEzQzM4Ni41OTcsMzI1LjEwNyAzNzEuOTA5LDMyNi44NDYgMzYwLjA4OSwzMzEuOTY3QzM0OC4xNjcsMzM2Ljg0OCAzMzYuNjYyLDM0Ni4xNDIgMzI4Ljk0NiwzNTcuOTE4QzMyMS4yMjksMzY5LjY5NSAzMTcuMywzODMuOTUzIDMxNy41ODUsMzk2LjgzMkMzMjUuMzk4LDM5Ny45NTUgMzMzLjEyNCw0MDAuMjYgMzQwLjI3NCw0MDMuNjAyQzMzNy41ODUsMzk2LjUxNiAzNDAuNzIyLDM4Ni41NTkgMzQ2Ljk4NywzODIuMjk0QzM1Mi43ODcsMzc3LjQxNSAzNjMuMjIxLDM3Ny4wODcgMzY5LjMxNywzODEuNTkxQzM3NS44MzgsMzg1LjQ1NCAzNzkuNTk1LDM5NS4xOTMgMzc3LjM1Nyw0MDIuNDM1QzM3NS44NjUsNDA5Ljg2NiAzNjcuOTEzLDQxNi42MjkgMzYwLjMzOSw0MTYuOTA5WiIgc3R5bGU9ImZpbGw6cmdiKDIzNSwzNCwzOSk7ZmlsbC1ydWxlOm5vbnplcm87Ii8+CiAgICA8L2c+Cjwvc3ZnPgo=";
                var responseString = $"<html><head></head><body style=\"text-align: center; font-family: Lato, Helvetica, Arial, sans-serif\"><img src=\"{svgLogoBase64}\" width=\"128px\">{message}</body></html>";

                var buffer = Encoding.UTF8.GetBytes(responseString);
                response.ContentLength64 = buffer.Length;
                var responseOutput = response.OutputStream;
                await responseOutput.WriteAsync(buffer, 0, buffer.Length);
                await Task.Delay(1000);
                responseOutput.Flush();
                responseOutput.Close();

                Logger.Info($"Closed listener");

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
                    //expiresInSeconds: 62, // for testing. expires in 1 minute, but it should be refreshed in 2 seconds.
                    refreshToken: auth.RefreshToken
                );
                Helper.CurrentUser = Helper.GetUser();
                Logger.Info($"Logged in as {Helper.CurrentUser.Username}");

                return true;

            }
            catch (Exception e)
            {
                Configuration.Default.TokenRepo = null;
                Helper.CurrentUser = null;
                Logger.Error(e);
                errorMessage = e.Message;
                return false;
                //throw;
            }
        
        }
    }
}
