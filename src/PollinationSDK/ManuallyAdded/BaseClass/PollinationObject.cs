using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace PollinationSDK
{
    public abstract class PollinationObject : IPollinationObject
    {
         /// <summary>
        /// Gets or Sets Type
        /// The default value is set to "InvalidSchemaObject", which should be overridden in subclass' constructor.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public virtual string Type { get; protected internal set; } = "InvalidSchemaObject";


        /// <summary>
        /// This is the base class for all queenbee schema objects.
        /// </summary>
        protected internal PollinationObject()
        {
        }


        public abstract string ToString(bool detailed);

        public abstract OpenAPIGenBaseModel Duplicate();
        
        public string ToJson(bool indented = false)
        {
            var format = indented ? Formatting.Indented : Formatting.None;
            return JsonConvert.SerializeObject(this, format, JsonSetting.AnyOfConvertSetting);
        }

        public static bool operator == (PollinationObject left, PollinationObject right)
        {
            if (left is null)
            {
                if (right is null)
                {
                    return true;
                }

                // Only the left side is null.
                return false;
            }
            // Equals handles case of null on right side.
            return left.Equals(right);
        }

        public static bool operator !=(PollinationObject left, PollinationObject right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj is PollinationObject input)
                return ModelExtensions.Equals(this.Type, input.Type);
            return false;
        }

       
    }
}

