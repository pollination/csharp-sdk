/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.21.2
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
    /// RunMeta
    /// </summary>
    [DataContract]
    public partial class RunMeta :  IEquatable<RunMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunMeta" /> class.
        /// </summary>
        /// <param name="progress">progress of the run.</param>
        /// <param name="resourcesDuration">resource usage.</param>
        public RunMeta
        (
           // Required parameters
           RunProgress progress= default, ResourcesDuration resourcesDuration= default// Optional parameters
        )// BaseClass
        {
            this.Progress = progress;
            this.ResourcesDuration = resourcesDuration;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// progress of the run
        /// </summary>
        /// <value>progress of the run</value>
        [DataMember(Name="progress", EmitDefaultValue=false)]
        [JsonProperty("progress")]
        public RunProgress Progress { get; set; } 
        /// <summary>
        /// resource usage
        /// </summary>
        /// <value>resource usage</value>
        [DataMember(Name="resources_duration", EmitDefaultValue=false)]
        [JsonProperty("resources_duration")]
        public ResourcesDuration ResourcesDuration { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunMeta {\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  ResourcesDuration: ").Append(ResourcesDuration).Append("\n");
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
        /// <returns>RunMeta object</returns>
        public static RunMeta FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RunMeta>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RunMeta object</returns>
        public RunMeta DuplicateRunMeta()
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
            return this.Equals(input as RunMeta);
        }

        /// <summary>
        /// Returns true if RunMeta instances are equal
        /// </summary>
        /// <param name="input">Instance of RunMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunMeta input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
                ) && 
                (
                    this.ResourcesDuration == input.ResourcesDuration ||
                    (this.ResourcesDuration != null &&
                    this.ResourcesDuration.Equals(input.ResourcesDuration))
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
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.ResourcesDuration != null)
                    hashCode = hashCode * 59 + this.ResourcesDuration.GetHashCode();
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
