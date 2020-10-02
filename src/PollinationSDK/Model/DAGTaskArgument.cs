/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: v0.9.0
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
    /// DAG task argument.  These arguments should match the inputs from the template referenced in the task.
    /// </summary>
    [DataContract]
    public partial class DAGTaskArgument :  IEquatable<DAGTaskArgument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGTaskArgument" /> class.
        /// </summary>
        /// <param name="artifacts">A list of input artifacts to pass to the task.</param>
        /// <param name="parameters">A list of input parameters to pass to the task.</param>
        public DAGTaskArgument
        (
           // Required parameters
           List<DAGTaskArtifactArgument> artifacts= default, List<DAGTaskParameterArgument> parameters= default// Optional parameters
        )// BaseClass
        {
            this.Artifacts = artifacts;
            this.Parameters = parameters;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// A list of input artifacts to pass to the task
        /// </summary>
        /// <value>A list of input artifacts to pass to the task</value>
        [DataMember(Name="artifacts", EmitDefaultValue=false)]
        [JsonProperty("artifacts")]
        public List<DAGTaskArtifactArgument> Artifacts { get; set; } 
        /// <summary>
        /// A list of input parameters to pass to the task
        /// </summary>
        /// <value>A list of input parameters to pass to the task</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        [JsonProperty("parameters")]
        public List<DAGTaskParameterArgument> Parameters { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DAGTaskArgument {\n");
            sb.Append("  Artifacts: ").Append(Artifacts).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
        /// <returns>DAGTaskArgument object</returns>
        public static DAGTaskArgument FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAGTaskArgument>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAGTaskArgument object</returns>
        public DAGTaskArgument DuplicateDAGTaskArgument()
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
            return this.Equals(input as DAGTaskArgument);
        }

        /// <summary>
        /// Returns true if DAGTaskArgument instances are equal
        /// </summary>
        /// <param name="input">Instance of DAGTaskArgument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAGTaskArgument input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Artifacts == input.Artifacts ||
                    this.Artifacts != null &&
                    input.Artifacts != null &&
                    this.Artifacts.SequenceEqual(input.Artifacts)
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
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
                if (this.Artifacts != null)
                    hashCode = hashCode * 59 + this.Artifacts.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
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
