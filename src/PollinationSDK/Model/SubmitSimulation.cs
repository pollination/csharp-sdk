/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: 0.9.6
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
    /// SubmitSimulation
    /// </summary>
    [DataContract]
    public partial class SubmitSimulation :  IEquatable<SubmitSimulation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitSimulation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubmitSimulation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitSimulation" /> class.
        /// </summary>
        /// <param name="inputs">Simulation inputs.</param>
        /// <param name="recipe">The recipe to use (required).</param>
        public SubmitSimulation
        (
           RecipeSelection recipe, // Required parameters
           SimulationInputs inputs= default // Optional parameters
        )// BaseClass
        {
            // to ensure "recipe" is required (not null)
            if (recipe == null)
            {
                throw new InvalidDataException("recipe is a required property for SubmitSimulation and cannot be null");
            }
            else
            {
                this.Recipe = recipe;
            }
            
            this.Inputs = inputs;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Simulation inputs
        /// </summary>
        /// <value>Simulation inputs</value>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        [JsonProperty("inputs")]
        public SimulationInputs Inputs { get; set; } 
        /// <summary>
        /// The recipe to use
        /// </summary>
        /// <value>The recipe to use</value>
        [DataMember(Name="recipe", EmitDefaultValue=false)]
        [JsonProperty("recipe")]
        public RecipeSelection Recipe { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubmitSimulation {\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  Recipe: ").Append(Recipe).Append("\n");
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
        /// <returns>SubmitSimulation object</returns>
        public static SubmitSimulation FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SubmitSimulation>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SubmitSimulation object</returns>
        public SubmitSimulation DuplicateSubmitSimulation()
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
            return this.Equals(input as SubmitSimulation);
        }

        /// <summary>
        /// Returns true if SubmitSimulation instances are equal
        /// </summary>
        /// <param name="input">Instance of SubmitSimulation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubmitSimulation input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Inputs == input.Inputs ||
                    (this.Inputs != null &&
                    this.Inputs.Equals(input.Inputs))
                ) && 
                (
                    this.Recipe == input.Recipe ||
                    (this.Recipe != null &&
                    this.Recipe.Equals(input.Recipe))
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
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.Recipe != null)
                    hashCode = hashCode * 59 + this.Recipe.GetHashCode();
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
