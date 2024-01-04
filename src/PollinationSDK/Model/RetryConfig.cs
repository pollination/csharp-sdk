/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 1.1.0
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
    /// RetryConfig
    /// </summary>
    [DataContract]
    public partial class RetryConfig :  IEquatable<RetryConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetryConfig" /> class.
        /// </summary>
        /// <param name="hard">Hard retry, will delete run data and restart from scratch (default to false).</param>
        public RetryConfig
        (
           // Required parameters
           bool hard = false// Optional parameters
        )// BaseClass
        {
            // use default value if no "hard" provided
            if (hard == null)
            {
                this.Hard =false;
            }
            else
            {
                this.Hard = hard;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Hard retry, will delete run data and restart from scratch
        /// </summary>
        /// <value>Hard retry, will delete run data and restart from scratch</value>
        [DataMember(Name="hard", EmitDefaultValue=false)]
        [JsonProperty("hard")]
        public bool Hard { get; set; }  = false;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetryConfig {\n");
            sb.Append("  Hard: ").Append(Hard).Append("\n");
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
        /// <returns>RetryConfig object</returns>
        public static RetryConfig FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RetryConfig>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RetryConfig object</returns>
        public RetryConfig DuplicateRetryConfig()
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
            return this.Equals(input as RetryConfig);
        }

        /// <summary>
        /// Returns true if RetryConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of RetryConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetryConfig input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Hard == input.Hard ||
                    (this.Hard != null &&
                    this.Hard.Equals(input.Hard))
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
                if (this.Hard != null)
                    hashCode = hashCode * 59 + this.Hard.GetHashCode();
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
