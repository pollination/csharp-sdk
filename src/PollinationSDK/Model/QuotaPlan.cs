/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.42.0
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
    /// QuotaPlan
    /// </summary>
    [DataContract]
    public partial class QuotaPlan :  IEquatable<QuotaPlan>, IValidatableObject
    {
        /// <summary>
        /// The name of the quota
        /// </summary>
        /// <value>The name of the quota</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public QuotaType Type { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaPlan" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuotaPlan() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaPlan" /> class.
        /// </summary>
        /// <param name="description">The description.</param>
        /// <param name="displayName">The human-readable name.</param>
        /// <param name="enforced">Whether the limit is triggers a blocking response from the server (default to false).</param>
        /// <param name="limit">The maximum amount of a resource that a subscription allows.</param>
        /// <param name="maxLimit">The maximum amount of a resource that a subscription allows.</param>
        /// <param name="resets">Whether consumption is reset to 0 every month (default to false).</param>
        /// <param name="unit">The unit in which the usage and limit are measured.</param>
        public QuotaPlan
        (
           , // Required parameters
           string description= default, string displayName= default, bool enforced = false, double limit= default, double maxLimit= default, bool resets = false, string unit= default// Optional parameters
        )// BaseClass
        {
            this.Description = description;
            this.DisplayName = displayName;
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
            this.MaxLimit = maxLimit;
            // use default value if no "resets" provided
            if (resets == null)
            {
                this.Resets =false;
            }
            else
            {
                this.Resets = resets;
            }
            this.Unit = unit;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The description
        /// </summary>
        /// <value>The description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; } 
        /// <summary>
        /// The human-readable name
        /// </summary>
        /// <value>The human-readable name</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        [JsonProperty("display_name")]
        public string DisplayName { get; set; } 
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
        /// The maximum amount of a resource that a subscription allows
        /// </summary>
        /// <value>The maximum amount of a resource that a subscription allows</value>
        [DataMember(Name="max_limit", EmitDefaultValue=false)]
        [JsonProperty("max_limit")]
        public double MaxLimit { get; set; } 
        /// <summary>
        /// Whether consumption is reset to 0 every month
        /// </summary>
        /// <value>Whether consumption is reset to 0 every month</value>
        [DataMember(Name="resets", EmitDefaultValue=false)]
        [JsonProperty("resets")]
        public bool Resets { get; set; }  = false;
        /// <summary>
        /// The unit in which the usage and limit are measured
        /// </summary>
        /// <value>The unit in which the usage and limit are measured</value>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        [JsonProperty("unit")]
        public string Unit { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuotaPlan {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Enforced: ").Append(Enforced).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  MaxLimit: ").Append(MaxLimit).Append("\n");
            sb.Append("  Resets: ").Append(Resets).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
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
                    this.MaxLimit == input.MaxLimit ||
                    (this.MaxLimit != null &&
                    this.MaxLimit.Equals(input.MaxLimit))
                ) && 
                (
                    this.Resets == input.Resets ||
                    (this.Resets != null &&
                    this.Resets.Equals(input.Resets))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Enforced != null)
                    hashCode = hashCode * 59 + this.Enforced.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.MaxLimit != null)
                    hashCode = hashCode * 59 + this.MaxLimit.GetHashCode();
                if (this.Resets != null)
                    hashCode = hashCode * 59 + this.Resets.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
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
