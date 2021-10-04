/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.17.0
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
    /// Run
    /// </summary>
    [DataContract]
    public partial class Run :  IEquatable<Run>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Run" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Run() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Run" /> class.
        /// </summary>
        /// <param name="author">author.</param>
        /// <param name="generation">The generation of this run.</param>
        /// <param name="id">The unique ID for this run (required).</param>
        /// <param name="meta">Extra metadata about the run.</param>
        /// <param name="owner">owner.</param>
        /// <param name="recipe">The recipe used to generate this .</param>
        /// <param name="status">The status of the run.</param>
        public Run
        (
           string id, // Required parameters
           AccountPublic author= default, double generation= default, RunMeta meta= default, AccountPublic owner= default, RecipeInterface recipe= default, RunStatus status= default// Optional parameters
        )// BaseClass
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Run and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            this.Author = author;
            this.Generation = generation;
            this.Meta = meta;
            this.Owner = owner;
            this.Recipe = recipe;
            this.Status = status;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// author
        /// </summary>
        /// <value>author</value>
        [DataMember(Name="author", EmitDefaultValue=false)]
        [JsonProperty("author")]
        public AccountPublic Author { get; set; } 
        /// <summary>
        /// The generation of this run
        /// </summary>
        /// <value>The generation of this run</value>
        [DataMember(Name="generation", EmitDefaultValue=false)]
        [JsonProperty("generation")]
        public double Generation { get; set; } 
        /// <summary>
        /// The unique ID for this run
        /// </summary>
        /// <value>The unique ID for this run</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public string Id { get; set; } 
        /// <summary>
        /// Extra metadata about the run
        /// </summary>
        /// <value>Extra metadata about the run</value>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        [JsonProperty("meta")]
        public RunMeta Meta { get; set; } 
        /// <summary>
        /// owner
        /// </summary>
        /// <value>owner</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        [JsonProperty("owner")]
        public AccountPublic Owner { get; set; } 
        /// <summary>
        /// The recipe used to generate this 
        /// </summary>
        /// <value>The recipe used to generate this </value>
        [DataMember(Name="recipe", EmitDefaultValue=false)]
        [JsonProperty("recipe")]
        public RecipeInterface Recipe { get; set; } 
        /// <summary>
        /// The status of the run
        /// </summary>
        /// <value>The status of the run</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        [JsonProperty("status")]
        public RunStatus Status { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Run {\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Generation: ").Append(Generation).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Recipe: ").Append(Recipe).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
        /// <returns>Run object</returns>
        public static Run FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Run>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Run object</returns>
        public Run DuplicateRun()
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
            return 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.Generation == input.Generation ||
                    (this.Generation != null &&
                    this.Generation.Equals(input.Generation))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Recipe == input.Recipe ||
                    (this.Recipe != null &&
                    this.Recipe.Equals(input.Recipe))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Generation != null)
                    hashCode = hashCode * 59 + this.Generation.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Recipe != null)
                    hashCode = hashCode * 59 + this.Recipe.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
