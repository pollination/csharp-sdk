/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: 0.0.0
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
    /// HTTPValidationError
    /// </summary>
    [DataContract]
    public partial class HTTPValidationError :  IEquatable<HTTPValidationError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPValidationError" /> class.
        /// </summary>
        /// <param name="detail">detail.</param>
        public HTTPValidationError
        (
           // Required parameters
           List<ValidationError> detail= default// Optional parameters
        )// BaseClass
        {
            this.Detail = detail;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Detail
        /// </summary>
        [DataMember(Name="detail", EmitDefaultValue=false)]
        [JsonProperty("detail")]
        public List<ValidationError> Detail { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HTTPValidationError {\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
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
        /// <returns>HTTPValidationError object</returns>
        public static HTTPValidationError FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<HTTPValidationError>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>HTTPValidationError object</returns>
        public HTTPValidationError DuplicateHTTPValidationError()
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
            return this.Equals(input as HTTPValidationError);
        }

        /// <summary>
        /// Returns true if HTTPValidationError instances are equal
        /// </summary>
        /// <param name="input">Instance of HTTPValidationError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HTTPValidationError input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Detail == input.Detail ||
                    this.Detail != null &&
                    input.Detail != null &&
                    this.Detail.SequenceEqual(input.Detail)
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
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
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
            yield break;
        }
    }

}
