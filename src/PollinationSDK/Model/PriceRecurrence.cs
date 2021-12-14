/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.21.0
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
    /// PriceRecurrence
    /// </summary>
    [DataContract]
    public partial class PriceRecurrence :  IEquatable<PriceRecurrence>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceRecurrence" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PriceRecurrence() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceRecurrence" /> class.
        /// </summary>
        /// <param name="interval">interval (required).</param>
        /// <param name="intervalCount">intervalCount (required).</param>
        /// <param name="usageType">usageType (required).</param>
        public PriceRecurrence
        (
           string interval, int intervalCount, string usageType// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "interval" is required (not null)
            if (interval == null)
            {
                throw new InvalidDataException("interval is a required property for PriceRecurrence and cannot be null");
            }
            else
            {
                this.Interval = interval;
            }
            
            // to ensure "intervalCount" is required (not null)
            if (intervalCount == null)
            {
                throw new InvalidDataException("intervalCount is a required property for PriceRecurrence and cannot be null");
            }
            else
            {
                this.IntervalCount = intervalCount;
            }
            
            // to ensure "usageType" is required (not null)
            if (usageType == null)
            {
                throw new InvalidDataException("usageType is a required property for PriceRecurrence and cannot be null");
            }
            else
            {
                this.UsageType = usageType;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        [JsonProperty("interval")]
        public string Interval { get; set; } 
        /// <summary>
        /// Gets or Sets IntervalCount
        /// </summary>
        [DataMember(Name="interval_count", EmitDefaultValue=false)]
        [JsonProperty("interval_count")]
        public int IntervalCount { get; set; } 
        /// <summary>
        /// Gets or Sets UsageType
        /// </summary>
        [DataMember(Name="usage_type", EmitDefaultValue=false)]
        [JsonProperty("usage_type")]
        public string UsageType { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PriceRecurrence {\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  IntervalCount: ").Append(IntervalCount).Append("\n");
            sb.Append("  UsageType: ").Append(UsageType).Append("\n");
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
        /// <returns>PriceRecurrence object</returns>
        public static PriceRecurrence FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<PriceRecurrence>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>PriceRecurrence object</returns>
        public PriceRecurrence DuplicatePriceRecurrence()
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
            return this.Equals(input as PriceRecurrence);
        }

        /// <summary>
        /// Returns true if PriceRecurrence instances are equal
        /// </summary>
        /// <param name="input">Instance of PriceRecurrence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PriceRecurrence input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) && 
                (
                    this.IntervalCount == input.IntervalCount ||
                    (this.IntervalCount != null &&
                    this.IntervalCount.Equals(input.IntervalCount))
                ) && 
                (
                    this.UsageType == input.UsageType ||
                    (this.UsageType != null &&
                    this.UsageType.Equals(input.UsageType))
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
                if (this.Interval != null)
                    hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.IntervalCount != null)
                    hashCode = hashCode * 59 + this.IntervalCount.GetHashCode();
                if (this.UsageType != null)
                    hashCode = hashCode * 59 + this.UsageType.GetHashCode();
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
