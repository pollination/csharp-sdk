/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
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
    /// Run
    /// </summary>
    [DataContract(Name = "Run")]
    public partial class Run : OpenAPIGenBaseModel, IEquatable<Run>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Run" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Run() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "Run";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Run" /> class.
        /// </summary>
        /// <param name="owner">owner (required).</param>
        /// <param name="job">job (required).</param>
        /// <param name="status">The status of the job.</param>
        public Run
        (
           AccountPublic owner, Job job, // Required parameters
           JobStatus status= default // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "owner" is required (not null)
            this.Owner = owner ?? throw new ArgumentNullException("owner is a required property for Run and cannot be null");
            // to ensure "job" is required (not null)
            this.Job = job ?? throw new ArgumentNullException("job is a required property for Run and cannot be null");
            this.Status = status;

            // Set non-required readonly properties with defaultValue
            this.Type = "Run";
        }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name = "owner", IsRequired = true, EmitDefaultValue = false)]
        public AccountPublic Owner { get; set; } 
        /// <summary>
        /// Gets or Sets Job
        /// </summary>
        [DataMember(Name = "job", IsRequired = true, EmitDefaultValue = false)]
        public Job Job { get; set; } 
        /// <summary>
        /// The status of the job
        /// </summary>
        /// <value>The status of the job</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public JobStatus Status { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Run";
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
            sb.Append("Run:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Job: ").Append(Job).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Run object</returns>
        public static Run FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Run>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Run object</returns>
        public virtual Run DuplicateRun()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateRun();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateRun();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Run);
        }

        /// <summary>
        /// Returns true if Run instances are equal
        /// </summary>
        /// <param name="input">Instance of Run to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Run input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && base.Equals(input) && 
                (
                    this.Job == input.Job ||
                    (this.Job != null &&
                    this.Job.Equals(input.Job))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Job != null)
                    hashCode = hashCode * 59 + this.Job.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
            Regex regexType = new Regex(@"^Run$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
