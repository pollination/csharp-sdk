/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.37.0
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
    /// Project
    /// </summary>
    [DataContract]
    public partial class Project :  IEquatable<Project>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Project() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="description">A description of the project (default to &quot;&quot;).</param>
        /// <param name="id">The project ID (required).</param>
        /// <param name="name">The name of the project. Must be unique to a given owner (required).</param>
        /// <param name="owner">The project owner (required).</param>
        /// <param name="permissions">permissions (required).</param>
        /// <param name="_public">Whether or not a project is publicly viewable (default to true).</param>
        /// <param name="slug">The project name in slug format (required).</param>
        /// <param name="usage">The resource consumption of this project.</param>
        public Project
        (
           string id, string name, AccountPublic owner, UserPermission permissions, string slug, // Required parameters
           string description = "", bool _public = true, Usage usage= default// Optional parameters
        )// BaseClass
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Project and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Project and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "owner" is required (not null)
            if (owner == null)
            {
                throw new InvalidDataException("owner is a required property for Project and cannot be null");
            }
            else
            {
                this.Owner = owner;
            }
            
            // to ensure "permissions" is required (not null)
            if (permissions == null)
            {
                throw new InvalidDataException("permissions is a required property for Project and cannot be null");
            }
            else
            {
                this.Permissions = permissions;
            }
            
            // to ensure "slug" is required (not null)
            if (slug == null)
            {
                throw new InvalidDataException("slug is a required property for Project and cannot be null");
            }
            else
            {
                this.Slug = slug;
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
            this.Usage = usage;

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
        /// The project ID
        /// </summary>
        /// <value>The project ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public string Id { get; set; } 
        /// <summary>
        /// The name of the project. Must be unique to a given owner
        /// </summary>
        /// <value>The name of the project. Must be unique to a given owner</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// The project owner
        /// </summary>
        /// <value>The project owner</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        [JsonProperty("owner")]
        public AccountPublic Owner { get; set; } 
        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        [JsonProperty("permissions")]
        public UserPermission Permissions { get; set; } 
        /// <summary>
        /// Whether or not a project is publicly viewable
        /// </summary>
        /// <value>Whether or not a project is publicly viewable</value>
        [DataMember(Name="public", EmitDefaultValue=false)]
        [JsonProperty("public")]
        public bool Public { get; set; }  = true;
        /// <summary>
        /// The project name in slug format
        /// </summary>
        /// <value>The project name in slug format</value>
        [DataMember(Name="slug", EmitDefaultValue=false)]
        [JsonProperty("slug")]
        public string Slug { get; set; } 
        /// <summary>
        /// The resource consumption of this project
        /// </summary>
        /// <value>The resource consumption of this project</value>
        [DataMember(Name="usage", EmitDefaultValue=false)]
        [JsonProperty("usage")]
        public Usage Usage { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Project {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
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
        /// <returns>Project object</returns>
        public static Project FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Project>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Project object</returns>
        public Project DuplicateProject()
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
            return this.Equals(input as Project);
        }

        /// <summary>
        /// Returns true if Project instances are equal
        /// </summary>
        /// <param name="input">Instance of Project to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Project input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
                ) && 
                (
                    this.Public == input.Public ||
                    (this.Public != null &&
                    this.Public.Equals(input.Public))
                ) && 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.Usage == input.Usage ||
                    (this.Usage != null &&
                    this.Usage.Equals(input.Usage))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.Public != null)
                    hashCode = hashCode * 59 + this.Public.GetHashCode();
                if (this.Slug != null)
                    hashCode = hashCode * 59 + this.Slug.GetHashCode();
                if (this.Usage != null)
                    hashCode = hashCode * 59 + this.Usage.GetHashCode();
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
