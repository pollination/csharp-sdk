/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.25.0
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
    /// Period
    /// </summary>
    [DataContract]
    public partial class Period :  IEquatable<Period>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Period" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Period() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Period" /> class.
        /// </summary>
        /// <param name="end">end (required).</param>
        /// <param name="start">start (required).</param>
        public Period
        (
           DateTime end, DateTime start// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "end" is required (not null)
            if (end == null)
            {
                throw new InvalidDataException("end is a required property for Period and cannot be null");
            }
            else
            {
                this.End = end;
            }
            
            // to ensure "start" is required (not null)
            if (start == null)
            {
                throw new InvalidDataException("start is a required property for Period and cannot be null");
            }
            else
            {
                this.Start = start;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets End
        /// </summary>
        [DataMember(Name="end", EmitDefaultValue=false)]
        [JsonProperty("end")]
        public DateTime End { get; set; } 
        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name="start", EmitDefaultValue=false)]
        [JsonProperty("start")]
        public DateTime Start { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Period {\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
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
        /// <returns>Period object</returns>
        public static Period FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Period>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Period object</returns>
        public Period DuplicatePeriod()
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
            return this.Equals(input as Period);
        }

        /// <summary>
        /// Returns true if Period instances are equal
        /// </summary>
        /// <param name="input">Instance of Period to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Period input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
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
                if (this.End != null)
                    hashCode = hashCode * 59 + this.End.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
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
