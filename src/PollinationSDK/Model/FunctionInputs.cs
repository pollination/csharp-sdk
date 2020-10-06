/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: v0.9.1
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
    /// The Inputs of a Function
    /// </summary>
    [DataContract]
    public partial class FunctionInputs :  IEquatable<FunctionInputs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionInputs" /> class.
        /// </summary>
        /// <param name="artifacts">artifacts.</param>
        /// <param name="parameters">parameters.</param>
        public FunctionInputs
        (
           // Required parameters
           List<FunctionArtifact> artifacts= default, List<FunctionParameterIn> parameters= default// Optional parameters
        )// BaseClass
        {
            this.Artifacts = artifacts;
            this.Parameters = parameters;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Artifacts
        /// </summary>
        [DataMember(Name="artifacts", EmitDefaultValue=false)]
        [JsonProperty("artifacts")]
        public List<FunctionArtifact> Artifacts { get; set; } 
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        [JsonProperty("parameters")]
        public List<FunctionParameterIn> Parameters { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FunctionInputs {\n");
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
        /// <returns>FunctionInputs object</returns>
        public static FunctionInputs FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<FunctionInputs>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>FunctionInputs object</returns>
        public FunctionInputs DuplicateFunctionInputs()
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
            return this.Equals(input as FunctionInputs);
        }

        /// <summary>
        /// Returns true if FunctionInputs instances are equal
        /// </summary>
        /// <param name="input">Instance of FunctionInputs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FunctionInputs input)
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
