﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
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
                var typeKey = jObject["type"];
                if (typeKey != null)
                {
                    var typeName = typeKey.Value<string>();
                    
                    var type = validTypes.FirstOrDefault(_ => _.Name.Equals(typeName, StringComparison.CurrentCultureIgnoreCase));
                    // TODO: this is only for temp fix before Queenbee is updated.
                    if (type == null)
                    {
                        var typename = typeName.Substring(0, typeName.Length - 1);
                        type = validTypes.FirstOrDefault(_ => _.Name.ToLower().StartsWith(typename));
                    }


                    if (type != null)
                    {
                        data = jObject.ToObject(type, serializer);
                    }
                    else
                    {
                        throw new ArgumentException($"{typeName} is not a valid type for {reader.Path}, this might because of mismatch version of honeybee schema!");
                    }
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
            if (value.Obj == null) return;
            JToken t = JToken.FromObject(value.Obj, serializer);
            t.WriteTo(writer);
        }

      
    }
}