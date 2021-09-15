/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.16.0
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = PollinationSDK.Client.OpenAPIDateConverter;

namespace PollinationSDK.Model
{
    /// <summary>
    /// Usage
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "type")]
    public partial class Usage : OpenAPIGenBaseModel,  IEquatable<Usage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Usage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        /// <param name="start">The start date for this usage aggregation (required).</param>
        /// <param name="end">The end date for this usage aggregation (required).</param>
        /// <param name="cpu">cpu usage (default to 0D).</param>
        /// <param name="memory">memory usage (default to 0D).</param>
        /// <param name="succeeded">succeeded usage (default to 0).</param>
        /// <param name="failed">failed usage (default to 0).</param>
        /// <param name="dailyUsage">daily breakdown of usage.</param>
        public Usage(DateTime start = default(DateTime), DateTime end = default(DateTime), double cpu = 0D, double memory = 0D, int succeeded = 0, int failed = 0, List<DailyUsage> dailyUsage = default(List<DailyUsage>)) : base()
        {
            // to ensure "start" is required (not null)
            if (start == null)
            {
                throw new InvalidDataException("start is a required property for Usage and cannot be null");
            }
            else
            {
                this.Start = start;
            }
            
            // to ensure "end" is required (not null)
            if (end == null)
            {
                throw new InvalidDataException("end is a required property for Usage and cannot be null");
            }
            else
            {
                this.End = end;
            }
            
            // use default value if no "cpu" provided
            if (cpu == null)
            {
                this.Cpu = 0D;
            }
            else
            {
                this.Cpu = cpu;
            }
            // use default value if no "memory" provided
            if (memory == null)
            {
                this.Memory = 0D;
            }
            else
            {
                this.Memory = memory;
            }
            // use default value if no "succeeded" provided
            if (succeeded == null)
            {
                this.Succeeded = 0;
            }
            else
            {
                this.Succeeded = succeeded;
            }
            // use default value if no "failed" provided
            if (failed == null)
            {
                this.Failed = 0;
            }
            else
            {
                this.Failed = failed;
            }
            this.DailyUsage = dailyUsage;
        }
        
        /// <summary>
        /// The start date for this usage aggregation
        /// </summary>
        /// <value>The start date for this usage aggregation</value>
        [DataMember(Name="start", EmitDefaultValue=true)]
        public DateTime Start { get; set; }

        /// <summary>
        /// The end date for this usage aggregation
        /// </summary>
        /// <value>The end date for this usage aggregation</value>
        [DataMember(Name="end", EmitDefaultValue=true)]
        public DateTime End { get; set; }

        /// <summary>
        /// cpu usage
        /// </summary>
        /// <value>cpu usage</value>
        [DataMember(Name="cpu", EmitDefaultValue=false)]
        public double Cpu { get; set; }

        /// <summary>
        /// memory usage
        /// </summary>
        /// <value>memory usage</value>
        [DataMember(Name="memory", EmitDefaultValue=false)]
        public double Memory { get; set; }

        /// <summary>
        /// succeeded usage
        /// </summary>
        /// <value>succeeded usage</value>
        [DataMember(Name="succeeded", EmitDefaultValue=false)]
        public int Succeeded { get; set; }

        /// <summary>
        /// failed usage
        /// </summary>
        /// <value>failed usage</value>
        [DataMember(Name="failed", EmitDefaultValue=false)]
        public int Failed { get; set; }

        /// <summary>
        /// daily breakdown of usage
        /// </summary>
        /// <value>daily breakdown of usage</value>
        [DataMember(Name="daily_usage", EmitDefaultValue=false)]
        public List<DailyUsage> DailyUsage { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Usage {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Cpu: ").Append(Cpu).Append("\n");
            sb.Append("  Memory: ").Append(Memory).Append("\n");
            sb.Append("  Succeeded: ").Append(Succeeded).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  DailyUsage: ").Append(DailyUsage).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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

            return base.Equals(input) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && base.Equals(input) && 
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
                ) && base.Equals(input) && 
                (
                    this.Cpu == input.Cpu ||
                    (this.Cpu != null &&
                    this.Cpu.Equals(input.Cpu))
                ) && base.Equals(input) && 
                (
                    this.Memory == input.Memory ||
                    (this.Memory != null &&
                    this.Memory.Equals(input.Memory))
                ) && base.Equals(input) && 
                (
                    this.Succeeded == input.Succeeded ||
                    (this.Succeeded != null &&
                    this.Succeeded.Equals(input.Succeeded))
                ) && base.Equals(input) && 
                (
                    this.Failed == input.Failed ||
                    (this.Failed != null &&
                    this.Failed.Equals(input.Failed))
                ) && base.Equals(input) && 
                (
                    this.DailyUsage == input.DailyUsage ||
                    this.DailyUsage != null &&
                    input.DailyUsage != null &&
                    this.DailyUsage.SequenceEqual(input.DailyUsage)
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                int hashCode = base.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.End != null)
                    hashCode = hashCode * 59 + this.End.GetHashCode();
                if (this.Cpu != null)
                    hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Memory != null)
                    hashCode = hashCode * 59 + this.Memory.GetHashCode();
                if (this.Succeeded != null)
                    hashCode = hashCode * 59 + this.Succeeded.GetHashCode();
                if (this.Failed != null)
                    hashCode = hashCode * 59 + this.Failed.GetHashCode();
                if (this.DailyUsage != null)
                    hashCode = hashCode * 59 + this.DailyUsage.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^Usage$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
