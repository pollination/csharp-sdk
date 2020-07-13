/* 
 * Pollination Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.5.32
 * 
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


namespace PollinationSDK.Model
{
    /// <summary>
    /// Workflow Arguments
    /// </summary>
    [DataContract]
    public partial class Arguments :  IEquatable<Arguments>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Arguments" /> class.
        /// </summary>
        /// <param name="parameters">A list of input parameters.</param>
        /// <param name="artifacts">A list of input artifacts.</param>
        public Arguments
        (
           // Required parameters
           List<ArgumentParameter> parameters= default, List<ArgumentArtifact> artifacts= default// Optional parameters
        )// BaseClass
        {
            this.Parameters = parameters;
            this.Artifacts = artifacts;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// A list of input parameters
        /// </summary>
        /// <value>A list of input parameters</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        [JsonProperty("parameters")]
        public List<ArgumentParameter> Parameters { get; set; } 
        /// <summary>
        /// A list of input artifacts
        /// </summary>
        /// <value>A list of input artifacts</value>
        [DataMember(Name="artifacts", EmitDefaultValue=false)]
        [JsonProperty("artifacts")]
        public List<ArgumentArtifact> Artifacts { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Arguments {\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Artifacts: ").Append(Artifacts).Append("\n");
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
        /// <returns>Arguments object</returns>
        public static Arguments FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Arguments>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Arguments object</returns>
        public Arguments DuplicateArguments()
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
            return this.Equals(input as Arguments);
        }

        /// <summary>
        /// Returns true if Arguments instances are equal
        /// </summary>
        /// <param name="input">Instance of Arguments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Arguments input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.Artifacts == input.Artifacts ||
                    this.Artifacts != null &&
                    input.Artifacts != null &&
                    this.Artifacts.SequenceEqual(input.Artifacts)
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
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Artifacts != null)
                    hashCode = hashCode * 59 + this.Artifacts.GetHashCode();
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
