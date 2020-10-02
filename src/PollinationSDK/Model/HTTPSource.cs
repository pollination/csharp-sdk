/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: v0.9.0
 * Contact: info@pollination.cloud
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = PollinationSDK.Client.OpenAPIDateConverter;

namespace PollinationSDK.Model
{
    /// <summary>
    /// HTTPSource  A web HTTP to an FTP server or an API for example.
    /// </summary>
    [DataContract]
    public partial class HTTPSource :  IEquatable<HTTPSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HTTPSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPSource" /> class.
        /// </summary>
        /// <param name="type">type (default to &quot;http&quot;).</param>
        /// <param name="url">For a HTTP endpoint this can be http://climate.onebuilding.org. (required).</param>
        public HTTPSource
        (
           string url, // Required parameters
           string type = "http" // Optional parameters
        )// BaseClass
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for HTTPSource and cannot be null");
            }
            else
            {
                this.Url = url;
            }
            
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type ="http";
            }
            else
            {
                this.Type = type;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }  = "http";
        /// <summary>
        /// For a HTTP endpoint this can be http://climate.onebuilding.org.
        /// </summary>
        /// <value>For a HTTP endpoint this can be http://climate.onebuilding.org.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        [JsonProperty("url")]
        public string Url { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HTTPSource {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, JsonSetting.ConvertSetting);
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>HTTPSource object</returns>
        public static HTTPSource FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<HTTPSource>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>HTTPSource object</returns>
        public HTTPSource DuplicateHTTPSource()
        {
            return FromJson(this.ToJson());
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as HTTPSource);
        }

        /// <summary>
        /// Returns true if HTTPSource instances are equal
        /// </summary>
        /// <param name="input">Instance of HTTPSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HTTPSource input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Type (string) pattern
            Regex regexType = new Regex(@"^http$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
