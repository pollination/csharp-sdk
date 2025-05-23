﻿extern alias LBTNewtonsoft; extern alias LBTRestSharp; using System;
using LBTNewtonsoft::Newtonsoft.Json;
using LBTNewtonsoft::Newtonsoft.Json.Linq;

using System.Linq;

namespace PollinationSDK
{
    public class AnyOfJsonConverter : JsonConverter<AnyOf>
    {
        private readonly Type _types;

        public AnyOfJsonConverter()
        {
            _types = typeof(AnyOf);
        }

        public override AnyOf ReadJson(JsonReader reader, Type objectType, AnyOf existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var objType = objectType;
            var validTypes = objType.GenericTypeArguments;

            var data = reader.Value;

            // try to load value
            if (data == null)
            {
                var jObject = JObject.Load(reader);

                if (jObject["type"] != null)
                {
                    var typeName = jObject["type"].Value<string>();
                    var type = validTypes.FirstOrDefault(_ => _.Name.Equals(typeName, StringComparison.CurrentCultureIgnoreCase));
                    if (type != null)
                    {
                        data = jObject.ToObject(type, serializer);
                    }
                    else
                    {
                        throw new ArgumentException($"{typeName} is not a valid type for {reader.Path}, this might because of mismatch version of honeybee schema!");
                    }
                }
                else if (jObject["account_type"] != null) //TODO: temporary solution for AccountPublic 
                {
                    //Accessor's subjuect
                    //"account_type": "user",
                    data = jObject.ToObject(typeof(AccountPublic), serializer);
                }
                else if (jObject["member_count"] != null) //TODO: temporary solution for Team
                {
                    //Accessor's subjuect
                    data = jObject.ToObject(typeof(Team), serializer);
                }
                else
                {
                    throw new ArgumentException($"Unable to load {reader.Path}");
                }
            }
           

            var inputType = data.GetType();
           
            if (validTypes.ToList().Contains(inputType))
            {
                var obj = Activator.CreateInstance(objectType, new object[] {data});
                return obj as AnyOf;
            }
            else
            {
                throw new ArgumentException($"{data} is {inputType} type, which doesn't match any of [{string.Join(", ", validTypes.ToString())}]");
            }

        }

        public override void WriteJson(JsonWriter writer,  AnyOf value, JsonSerializer serializer)
        {
            JToken t = JToken.FromObject(value.Obj, serializer);
            t.WriteTo(writer);
        }

      
    }
}