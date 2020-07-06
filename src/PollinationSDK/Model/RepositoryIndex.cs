/* 
 * Pollination Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.5.31
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
    /// A searchable index for a Queenbee Operator and Recipe repository
    /// </summary>
    [DataContract]
    public partial class RepositoryIndex :  IEquatable<RepositoryIndex>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryIndex" /> class.
        /// </summary>
        /// <param name="generated">The timestamp at which the index was generated.</param>
        /// <param name="_operator">A dict of operators accessible by name. Each name key points to a list of operator versions.</param>
        /// <param name="recipe">A dict of recipes accessible by name. Each name key points to a list of recipesversions.</param>
        public RepositoryIndex
        (
           // Required parameters
           DateTime generated= default, Dictionary<string, List<OperatorVersion>> _operator= default, Dictionary<string, List<RecipeVersion>> recipe= default// Optional parameters
        )// BaseClass
        {
            this.Generated = generated;
            this.Operator = _operator;
            this.Recipe = recipe;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The timestamp at which the index was generated
        /// </summary>
        /// <value>The timestamp at which the index was generated</value>
        [DataMember(Name="generated", EmitDefaultValue=false)]
        [JsonProperty("generated")]
        public DateTime Generated { get; set; } 
        /// <summary>
        /// A dict of operators accessible by name. Each name key points to a list of operator versions
        /// </summary>
        /// <value>A dict of operators accessible by name. Each name key points to a list of operator versions</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        [JsonProperty("operator")]
        public Dictionary<string, List<OperatorVersion>> Operator { get; set; } 
        /// <summary>
        /// A dict of recipes accessible by name. Each name key points to a list of recipesversions
        /// </summary>
        /// <value>A dict of recipes accessible by name. Each name key points to a list of recipesversions</value>
        [DataMember(Name="recipe", EmitDefaultValue=false)]
        [JsonProperty("recipe")]
        public Dictionary<string, List<RecipeVersion>> Recipe { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryIndex {\n");
            sb.Append("  Generated: ").Append(Generated).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryIndex);
        }

        /// <summary>
        /// Returns true if RepositoryIndex instances are equal
        /// </summary>
        /// <param name="input">Instance of RepositoryIndex to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepositoryIndex input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Generated == input.Generated ||
                    (this.Generated != null &&
                    this.Generated.Equals(input.Generated))
                ) && 
                (
                    this.Operator == input.Operator ||
                    this.Operator != null &&
                    input.Operator != null &&
                    this.Operator.SequenceEqual(input.Operator)
                ) && 
                (
                    this.Recipe == input.Recipe ||
                    this.Recipe != null &&
                    input.Recipe != null &&
                    this.Recipe.SequenceEqual(input.Recipe)
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
                if (this.Generated != null)
                    hashCode = hashCode * 59 + this.Generated.GetHashCode();
                if (this.Operator != null)
                    hashCode = hashCode * 59 + this.Operator.GetHashCode();
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
