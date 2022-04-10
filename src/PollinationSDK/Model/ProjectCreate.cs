/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.29.0
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
    /// ProjectCreate
    /// </summary>
    [DataContract]
    public partial class ProjectCreate :  IEquatable<ProjectCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreate" /> class.
        /// </summary>
        /// <param name="description">A description of the project (default to &quot;&quot;).</param>
        /// <param name="name">The name of the project. Must be unique to a given owner (required).</param>
        /// <param name="_public">Whether or not a project is publicly viewable (default to true).</param>
        public ProjectCreate
        (
           string name, // Required parameters
           string description = "", bool _public = true// Optional parameters
        )// BaseClass
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ProjectCreate and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // use default value if no "description" provided
            if (description == null)
            {
                this.Description ="";
            }
            else
            {
                this.Description = description;
            }
            // use default value if no "_public" provided
            if (_public == null)
            {
                this.Public =true;
            }
            else
            {
                this.Public = _public;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// A description of the project
        /// </summary>
        /// <value>A description of the project</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; }  = "";
        /// <summary>
        /// The name of the project. Must be unique to a given owner
        /// </summary>
        /// <value>The name of the project. Must be unique to a given owner</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// Whether or not a project is publicly viewable
        /// </summary>
        /// <value>Whether or not a project is publicly viewable</value>
        [DataMember(Name="public", EmitDefaultValue=false)]
        [JsonProperty("public")]
        public bool Public { get; set; }  = true;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectCreate {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
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
        /// <returns>ProjectCreate object</returns>
        public static ProjectCreate FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ProjectCreate>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ProjectCreate object</returns>
        public ProjectCreate DuplicateProjectCreate()
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
            return this.Equals(input as ProjectCreate);
        }

        /// <summary>
        /// Returns true if ProjectCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectCreate input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Public == input.Public ||
                    (this.Public != null &&
                    this.Public.Equals(input.Public))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Public != null)
                    hashCode = hashCode * 59 + this.Public.GetHashCode();
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
