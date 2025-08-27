extern alias LBTNewtonsoft;  extern alias LBTRestSharp; using System;

namespace PollinationSDK
{
    public static class Env
    {
        private static class Variable
        {
            public const string HTTPTimeout = "PO_HTTP_TIMEOUT";
        }

        public static int HTTPTimeout
        {
            get
            {
                int retVal = 300_000;
                var envTimeout = Environment.GetEnvironmentVariable(Variable.HTTPTimeout);
                if (envTimeout != null)
                {
                    int parseRes;
                    int.TryParse(envTimeout, out parseRes);

                    if (parseRes != null)
                    {
                        retVal = parseRes;
                    }
                }
                return retVal;
            }
        }


        private static System.Net.Cache.RequestCachePolicy _cache;

        public static System.Net.Cache.RequestCachePolicy CachePolicy
        {
            get
            {
                return (_cache = _cache ?? new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.Revalidate));
            }
        }


    }
}
