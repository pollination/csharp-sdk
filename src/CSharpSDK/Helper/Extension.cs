 extern alias LBTRestSharp; 
using LBT.Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PollinationSDK
{

    public static class Extension 
	{
        public static bool AllEquals(IDictionary x, IDictionary y)
        {
            if (x != null && y != null)
            {
                if (x.Count <= 0 || y.Count <= 0)
                    return x.Count == y.Count;

                var key1 = x.Keys.Cast<object>().ToList();
                var key2 = y.Keys.Cast<object>().ToList();

                if (AllEquals(key1, key2))
                {
                    return AllEquals(x.Values.Cast<object>().ToList(), y.Values.Cast<object>().ToList());
                }
                else
                {
                    return false;
                }

                
            }
            else if (x == null)
            {
                return y == null || y.Count == 0;
            }
            else if (y == null)
            {
                return x == null || x.Count == 0;
            }
            else
            {
                return x == y;
            }
        }

        public static bool AllEquals(IList x, IList y)
        {
            if (x != null && y != null)
            {
                if (x.Count <=0 || y.Count <= 0)
                    return x.Count == y.Count;

                if (x[0] is IList listX && y[0] is IList listY)
                {
                    return AllEquals(listX, listY);
                }
                else
                {
                    var xo = x.Cast<object>();
                    var yo = y.Cast<object>();
                    return xo.SequenceEqual(yo);
                }
            }
            else if (x == null)
            {
                return y == null || y.Count == 0;
            }
            else if (y == null)
            {
                return x == null || x.Count == 0;
            }
            else
            {
                return x == y;
            }
        }

        public static bool Equals(object x, object y)
        {

            if (x == y)
                return true;

            if (x == null)
                return y == null;

            if (x is JObject j)
                return JToken.DeepEquals(j, y as JObject);
            else
                return x.Equals(y);

        }
        

    }

}

