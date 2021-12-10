/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
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
    /// A quota plan
    /// </summary>
    [DataContract]
    public partial class QuotaPlan :  IEquatable<QuotaPlan>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaPlan" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuotaPlan() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaPlan" /> class.
        /// </summary>
        /// <param name="enforced">Whether the limit is triggers a blocking response from the server (default to false).</param>
        /// <param name="limit">The maximum amount of a resource that a subscription allows.</param>
        /// <param name="name">The name of the quota (required).</param>
        /// <param name="resets">Whether consumption is reset to 0 every month (default to false).</param>
        public QuotaPlan
        (
           string name, // Required parameters
           bool enforced = false, double limit= default, bool resets = false// Optional parameters
        )// BaseClass
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for QuotaPlan and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // use default value if no "enforced" provided
            if (enforced == null)
            {
                this.Enforced =false;
            }
            else
            {
                this.Enforced = enforced;
            }
            this.Limit = limit;
            // use default value if no "resets" provided
            if (resets == null)
            {
                this.Resets =false;
            }
            else
            {
                this.Resets = resets;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Whether the limit is triggers a blocking response from the server
        /// </summary>
        /// <value>Whether the limit is triggers a blocking response from the server</value>
        [DataMember(Name="enforced", EmitDefaultValue=false)]
        [JsonProperty("enforced")]
        public bool Enforced { get; set; }  = false;
        /// <summary>
        /// The maximum amount of a resource that a subscription allows
        /// </summary>
        /// <value>The maximum amount of a resource that a subscription allows</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        [JsonProperty("limit")]
        public double Limit { get; set; } 
        /// <summary>
        /// The name of the quota
        /// </summary>
        /// <value>The name of the quota</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// Whether consumption is reset to 0 every month
        /// </summary>
        /// <value>Whether consumption is reset to 0 every month</value>
        [DataMember(Name="resets", EmitDefaultValue=false)]
        [JsonProperty("resets")]
        public bool Resets { get; set; }  = false;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuotaPlan {\n");
            sb.Append("  Enforced: ").Append(Enforced).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Resets: ").Append(Resets).Append("\n");
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
        /// <returns>QuotaPlan object</returns>
        public static QuotaPlan FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<QuotaPlan>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>QuotaPlan object</returns>
        public QuotaPlan DuplicateQuotaPlan()
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
            return this.Equals(input as QuotaPlan);
        }

        /// <summary>
        /// Returns true if QuotaPlan instances are equal
        /// </summary>
        /// <param name="input">Instance of QuotaPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuotaPlan input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Enforced == input.Enforced ||
                    (this.Enforced != null &&
                    this.Enforced.Equals(input.Enforced))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Resets == input.Resets ||
                    (this.Resets != null &&
                    this.Resets.Equals(input.Resets))
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
                if (this.Enforced != null)
                    hashCode = hashCode * 59 + this.Enforced.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Resets != null)
                    hashCode = hashCode * 59 + this.Resets.GetHashCode();
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
