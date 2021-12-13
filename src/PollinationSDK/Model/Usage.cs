/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: v0.20.0
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
    /// Usage
    /// </summary>
    [DataContract]
    public partial class Usage :  IEquatable<Usage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Usage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        /// <param name="cpu">cpu usage (default to 0D).</param>
        /// <param name="dailyUsage">daily breakdown of usage.</param>
        /// <param name="end">The end date for this usage aggregation (required).</param>
        /// <param name="failed">failed usage (default to 0).</param>
        /// <param name="memory">memory usage (default to 0D).</param>
        /// <param name="start">The start date for this usage aggregation (required).</param>
        /// <param name="succeeded">succeeded usage (default to 0).</param>
        public Usage
        (
           DateTime end, DateTime start, // Required parameters
           double cpu = 0D, List<DailyUsage> dailyUsage= default, int failed = 0, double memory = 0D, int succeeded = 0// Optional parameters
        )// BaseClass
        {
            // to ensure "end" is required (not null)
            if (end == null)
            {
                throw new InvalidDataException("end is a required property for Usage and cannot be null");
            }
            else
            {
                this.End = end;
            }
            
            // to ensure "start" is required (not null)
            if (start == null)
            {
                throw new InvalidDataException("start is a required property for Usage and cannot be null");
            }
            else
            {
                this.Start = start;
            }
            
            // use default value if no "cpu" provided
            if (cpu == null)
            {
                this.Cpu =0D;
            }
            else
            {
                this.Cpu = cpu;
            }
            this.DailyUsage = dailyUsage;
            // use default value if no "failed" provided
            if (failed == null)
            {
                this.Failed =0;
            }
            else
            {
                this.Failed = failed;
            }
            // use default value if no "memory" provided
            if (memory == null)
            {
                this.Memory =0D;
            }
            else
            {
                this.Memory = memory;
            }
            // use default value if no "succeeded" provided
            if (succeeded == null)
            {
                this.Succeeded =0;
            }
            else
            {
                this.Succeeded = succeeded;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// cpu usage
        /// </summary>
        /// <value>cpu usage</value>
        [DataMember(Name="cpu", EmitDefaultValue=false)]
        [JsonProperty("cpu")]
        public double Cpu { get; set; }  = 0D;
        /// <summary>
        /// daily breakdown of usage
        /// </summary>
        /// <value>daily breakdown of usage</value>
        [DataMember(Name="daily_usage", EmitDefaultValue=false)]
        [JsonProperty("daily_usage")]
        public List<DailyUsage> DailyUsage { get; set; } 
        /// <summary>
        /// The end date for this usage aggregation
        /// </summary>
        /// <value>The end date for this usage aggregation</value>
        [DataMember(Name="end", EmitDefaultValue=false)]
        [JsonProperty("end")]
        public DateTime End { get; set; } 
        /// <summary>
        /// failed usage
        /// </summary>
        /// <value>failed usage</value>
        [DataMember(Name="failed", EmitDefaultValue=false)]
        [JsonProperty("failed")]
        public int Failed { get; set; }  = 0;
        /// <summary>
        /// memory usage
        /// </summary>
        /// <value>memory usage</value>
        [DataMember(Name="memory", EmitDefaultValue=false)]
        [JsonProperty("memory")]
        public double Memory { get; set; }  = 0D;
        /// <summary>
        /// The start date for this usage aggregation
        /// </summary>
        /// <value>The start date for this usage aggregation</value>
        [DataMember(Name="start", EmitDefaultValue=false)]
        [JsonProperty("start")]
        public DateTime Start { get; set; } 
        /// <summary>
        /// succeeded usage
        /// </summary>
        /// <value>succeeded usage</value>
        [DataMember(Name="succeeded", EmitDefaultValue=false)]
        [JsonProperty("succeeded")]
        public int Succeeded { get; set; }  = 0;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Usage {\n");
            sb.Append("  Cpu: ").Append(Cpu).Append("\n");
            sb.Append("  DailyUsage: ").Append(DailyUsage).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  Memory: ").Append(Memory).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Succeeded: ").Append(Succeeded).Append("\n");
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
        /// <returns>Usage object</returns>
        public static Usage FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Usage>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Usage object</returns>
        public Usage DuplicateUsage()
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
            return this.Equals(input as Usage);
        }

        /// <summary>
        /// Returns true if Usage instances are equal
        /// </summary>
        /// <param name="input">Instance of Usage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Usage input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Cpu == input.Cpu ||
                    (this.Cpu != null &&
                    this.Cpu.Equals(input.Cpu))
                ) && 
                (
                    this.DailyUsage == input.DailyUsage ||
                    this.DailyUsage != null &&
                    input.DailyUsage != null &&
                    this.DailyUsage.SequenceEqual(input.DailyUsage)
                ) && 
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
                ) && 
                (
                    this.Failed == input.Failed ||
                    (this.Failed != null &&
                    this.Failed.Equals(input.Failed))
                ) && 
                (
                    this.Memory == input.Memory ||
                    (this.Memory != null &&
                    this.Memory.Equals(input.Memory))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.Succeeded == input.Succeeded ||
                    (this.Succeeded != null &&
                    this.Succeeded.Equals(input.Succeeded))
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
                if (this.Cpu != null)
                    hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.DailyUsage != null)
                    hashCode = hashCode * 59 + this.DailyUsage.GetHashCode();
                if (this.End != null)
                    hashCode = hashCode * 59 + this.End.GetHashCode();
                if (this.Failed != null)
                    hashCode = hashCode * 59 + this.Failed.GetHashCode();
                if (this.Memory != null)
                    hashCode = hashCode * 59 + this.Memory.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Succeeded != null)
                    hashCode = hashCode * 59 + this.Succeeded.GetHashCode();
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
