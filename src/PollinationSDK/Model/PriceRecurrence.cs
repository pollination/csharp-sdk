/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
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


namespace PollinationSDK
{
    /// <summary>
    /// PriceRecurrence
    /// </summary>
    [DataContract(Name = "PriceRecurrence")]
    public partial class PriceRecurrence : IEquatable<PriceRecurrence>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceRecurrence" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PriceRecurrence() 
        { 
            // Set non-required readonly properties with defaultValue
        }
        
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
            this.Interval = interval ?? throw new ArgumentNullException("interval is a required property for PriceRecurrence and cannot be null");
            this.IntervalCount = intervalCount;
            // to ensure "usageType" is required (not null)
            this.UsageType = usageType ?? throw new ArgumentNullException("usageType is a required property for PriceRecurrence and cannot be null");

            // Set non-required readonly properties with defaultValue
        }


        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name = "interval", IsRequired = true, EmitDefaultValue = false)]
        public string Interval { get; set; } 
        /// <summary>
        /// Gets or Sets IntervalCount
        /// </summary>
        [DataMember(Name = "interval_count", IsRequired = true, EmitDefaultValue = false)]
        public int IntervalCount { get; set; } 
        /// <summary>
        /// Gets or Sets UsageType
        /// </summary>
        [DataMember(Name = "usage_type", IsRequired = true, EmitDefaultValue = false)]
        public string UsageType { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "PriceRecurrence";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("PriceRecurrence:\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  IntervalCount: ").Append(IntervalCount).Append("\n");
            sb.Append("  UsageType: ").Append(UsageType).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>PriceRecurrence object</returns>
        public static PriceRecurrence FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<PriceRecurrence>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>PriceRecurrence object</returns>
        public virtual PriceRecurrence DuplicatePriceRecurrence()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicatePriceRecurrence();
        }

     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
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
