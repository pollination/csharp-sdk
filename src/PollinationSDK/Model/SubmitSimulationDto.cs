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
    /// SubmitSimulationDto
    /// </summary>
    [DataContract]
    public partial class SubmitSimulationDto :  IEquatable<SubmitSimulationDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitSimulationDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubmitSimulationDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitSimulationDto" /> class.
        /// </summary>
        /// <param name="recipe">The recipe to use (required).</param>
        /// <param name="inputs">Simulation inputs.</param>
        public SubmitSimulationDto
        (
           RecipeSelection recipe, // Required parameters
           Arguments inputs= default// Optional parameters
        )// BaseClass
        {
            // to ensure "recipe" is required (not null)
            if (recipe == null)
            {
                throw new InvalidDataException("recipe is a required property for SubmitSimulationDto and cannot be null");
            }
            else
            {
                this.Recipe = recipe;
            }
            
            this.Inputs = inputs;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The recipe to use
        /// </summary>
        /// <value>The recipe to use</value>
        [DataMember(Name="recipe", EmitDefaultValue=false)]
        [JsonProperty("recipe")]
        public RecipeSelection Recipe { get; set; } 
        /// <summary>
        /// Simulation inputs
        /// </summary>
        /// <value>Simulation inputs</value>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        [JsonProperty("inputs")]
        public Arguments Inputs { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubmitSimulationDto {\n");
            sb.Append("  Recipe: ").Append(Recipe).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
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
        /// <returns>SubmitSimulationDto object</returns>
        public static SubmitSimulationDto FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SubmitSimulationDto>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SubmitSimulationDto object</returns>
        public SubmitSimulationDto DuplicateSubmitSimulationDto()
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
            return this.Equals(input as SubmitSimulationDto);
        }

        /// <summary>
        /// Returns true if SubmitSimulationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of SubmitSimulationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubmitSimulationDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Recipe == input.Recipe ||
                    (this.Recipe != null &&
                    this.Recipe.Equals(input.Recipe))
                ) && 
                (
                    this.Inputs == input.Inputs ||
                    (this.Inputs != null &&
                    this.Inputs.Equals(input.Inputs))
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
                if (this.Recipe != null)
                    hashCode = hashCode * 59 + this.Recipe.GetHashCode();
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
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
