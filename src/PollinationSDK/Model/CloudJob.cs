/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.18.1-beta.1
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
    /// CloudJob
    /// </summary>
    [DataContract]
    public partial class CloudJob :  IEquatable<CloudJob>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudJob" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CloudJob() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudJob" /> class.
        /// </summary>
        /// <param name="author">author.</param>
        /// <param name="id">The unique ID for this run (required).</param>
        /// <param name="owner">owner.</param>
        /// <param name="recipe">The recipe used to generate this .</param>
        /// <param name="spec">The job specification (required).</param>
        /// <param name="status">The status of the job.</param>
        public CloudJob
        (
           string id, Job spec, // Required parameters
           AccountPublic author= default, AccountPublic owner= default, RecipeInterface recipe= default, JobStatus status= default// Optional parameters
        )// BaseClass
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for CloudJob and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "spec" is required (not null)
            if (spec == null)
            {
                throw new InvalidDataException("spec is a required property for CloudJob and cannot be null");
            }
            else
            {
                this.Spec = spec;
            }
            
            this.Author = author;
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
        /// The unique ID for this run
        /// </summary>
        /// <value>The unique ID for this run</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public string Id { get; set; } 
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
        /// The job specification
        /// </summary>
        /// <value>The job specification</value>
        [DataMember(Name="spec", EmitDefaultValue=false)]
        [JsonProperty("spec")]
        public Job Spec { get; set; } 
        /// <summary>
        /// The status of the job
        /// </summary>
        /// <value>The status of the job</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        [JsonProperty("status")]
        public JobStatus Status { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudJob {\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Recipe: ").Append(Recipe).Append("\n");
            sb.Append("  Spec: ").Append(Spec).Append("\n");
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
        /// <returns>CloudJob object</returns>
        public static CloudJob FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<CloudJob>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>CloudJob object</returns>
        public CloudJob DuplicateCloudJob()
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
            return this.Equals(input as CloudJob);
        }

        /// <summary>
        /// Returns true if CloudJob instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudJob input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.Spec == input.Spec ||
                    (this.Spec != null &&
                    this.Spec.Equals(input.Spec))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Recipe != null)
                    hashCode = hashCode * 59 + this.Recipe.GetHashCode();
                if (this.Spec != null)
                    hashCode = hashCode * 59 + this.Spec.GetHashCode();
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
