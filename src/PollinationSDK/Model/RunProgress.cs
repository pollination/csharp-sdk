/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.37.0
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
    /// RunProgress
    /// </summary>
    [DataContract]
    public partial class RunProgress :  IEquatable<RunProgress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunProgress" /> class.
        /// </summary>
        /// <param name="completed">completed (default to 0).</param>
        /// <param name="running">running (default to 0).</param>
        /// <param name="total">total (default to 0).</param>
        public RunProgress
        (
           // Required parameters
           int completed = 0, int running = 0, int total = 0// Optional parameters
        )// BaseClass
        {
            // use default value if no "completed" provided
            if (completed == null)
            {
                this.Completed =0;
            }
            else
            {
                this.Completed = completed;
            }
            // use default value if no "running" provided
            if (running == null)
            {
                this.Running =0;
            }
            else
            {
                this.Running = running;
            }
            // use default value if no "total" provided
            if (total == null)
            {
                this.Total =0;
            }
            else
            {
                this.Total = total;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name="completed", EmitDefaultValue=false)]
        [JsonProperty("completed")]
        public int Completed { get; set; }  = 0;
        /// <summary>
        /// Gets or Sets Running
        /// </summary>
        [DataMember(Name="running", EmitDefaultValue=false)]
        [JsonProperty("running")]
        public int Running { get; set; }  = 0;
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        [JsonProperty("total")]
        public int Total { get; set; }  = 0;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunProgress {\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  Running: ").Append(Running).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
        /// <returns>RunProgress object</returns>
        public static RunProgress FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RunProgress>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RunProgress object</returns>
        public RunProgress DuplicateRunProgress()
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
            return this.Equals(input as RunProgress);
        }

        /// <summary>
        /// Returns true if RunProgress instances are equal
        /// </summary>
        /// <param name="input">Instance of RunProgress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunProgress input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Completed == input.Completed ||
                    (this.Completed != null &&
                    this.Completed.Equals(input.Completed))
                ) && 
                (
                    this.Running == input.Running ||
                    (this.Running != null &&
                    this.Running.Equals(input.Running))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.Completed != null)
                    hashCode = hashCode * 59 + this.Completed.GetHashCode();
                if (this.Running != null)
                    hashCode = hashCode * 59 + this.Running.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
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
