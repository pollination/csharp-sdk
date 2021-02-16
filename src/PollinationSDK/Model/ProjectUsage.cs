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
using QueenbeeSDK;

namespace PollinationSDK
{
    /// <summary>
    /// ProjectUsage
    /// </summary>
    [DataContract(Name = "ProjectUsage")]
    public partial class ProjectUsage : OpenAPIGenBaseModel, IEquatable<ProjectUsage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUsage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectUsage() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "ProjectUsage";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUsage" /> class.
        /// </summary>
        /// <param name="start">start (required).</param>
        /// <param name="end">end (required).</param>
        /// <param name="cpu">cpu (default to 0D).</param>
        /// <param name="memory">memory (default to 0D).</param>
        /// <param name="succeeded">succeeded (default to 0D).</param>
        /// <param name="failed">failed (default to 0D).</param>
        /// <param name="dailyUsage">dailyUsage.</param>
        public ProjectUsage
        (
           DateTime start, DateTime end, // Required parameters
           double cpu = 0D, double memory = 0D, double succeeded = 0D, double failed = 0D, List<ProjectDailyUsage> dailyUsage= default // Optional parameters
        ) : base()// BaseClass
        {
            this.Start = start;
            this.End = end;
            this.Cpu = cpu;
            this.Memory = memory;
            this.Succeeded = succeeded;
            this.Failed = failed;
            this.DailyUsage = dailyUsage;

            // Set non-required readonly properties with defaultValue
            this.Type = "ProjectUsage";
        }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name = "start", IsRequired = true, EmitDefaultValue = false)]
        public DateTime Start { get; set; } 
        /// <summary>
        /// Gets or Sets End
        /// </summary>
        [DataMember(Name = "end", IsRequired = true, EmitDefaultValue = false)]
        public DateTime End { get; set; } 
        /// <summary>
        /// Gets or Sets Cpu
        /// </summary>
        [DataMember(Name = "cpu", EmitDefaultValue = true)]
        public double Cpu { get; set; }  = 0D;
        /// <summary>
        /// Gets or Sets Memory
        /// </summary>
        [DataMember(Name = "memory", EmitDefaultValue = true)]
        public double Memory { get; set; }  = 0D;
        /// <summary>
        /// Gets or Sets Succeeded
        /// </summary>
        [DataMember(Name = "succeeded", EmitDefaultValue = true)]
        public double Succeeded { get; set; }  = 0D;
        /// <summary>
        /// Gets or Sets Failed
        /// </summary>
        [DataMember(Name = "failed", EmitDefaultValue = true)]
        public double Failed { get; set; }  = 0D;
        /// <summary>
        /// Gets or Sets DailyUsage
        /// </summary>
        [DataMember(Name = "daily_usage", EmitDefaultValue = false)]
        public List<ProjectDailyUsage> DailyUsage { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ProjectUsage";
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
            sb.Append("ProjectUsage:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Cpu: ").Append(Cpu).Append("\n");
            sb.Append("  Memory: ").Append(Memory).Append("\n");
            sb.Append("  Succeeded: ").Append(Succeeded).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  DailyUsage: ").Append(DailyUsage).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ProjectUsage object</returns>
        public static ProjectUsage FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ProjectUsage>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ProjectUsage object</returns>
        public virtual ProjectUsage DuplicateProjectUsage()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateProjectUsage();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateProjectUsage();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProjectUsage);
        }

        /// <summary>
        /// Returns true if ProjectUsage instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectUsage input)
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
            Regex regexType = new Regex(@"^ProjectUsage$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
