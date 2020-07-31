/* 
 * Pollination Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.7.1
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
    /// RepositoryDto
    /// </summary>
    [DataContract]
    public partial class RepositoryDto :  IEquatable<RepositoryDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RepositoryDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryDto" /> class.
        /// </summary>
        /// <param name="_public">Whether or not a repository is publicly viewable (default to true).</param>
        /// <param name="keywords">keywords.</param>
        /// <param name="description">description.</param>
        /// <param name="icon">icon.</param>
        /// <param name="name">The name of the repository (required).</param>
        /// <param name="latestTag">The latest package version to be indexed (required).</param>
        /// <param name="owner">The owner of the repository (required).</param>
        /// <param name="slug">The repository slug.</param>
        /// <param name="permissions">The permissions the user making the API call has on the resource (required).</param>
        public RepositoryDto
        (
           string name, string latestTag, AccountPublic owner, RepositoryPermissions permissions, // Required parameters
           bool _public = true, List<string> keywords= default, string description= default, string icon= default, string slug= default // Optional parameters
        )// BaseClass
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for RepositoryDto and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "latestTag" is required (not null)
            if (latestTag == null)
            {
                throw new InvalidDataException("latestTag is a required property for RepositoryDto and cannot be null");
            }
            else
            {
                this.LatestTag = latestTag;
            }
            
            // to ensure "owner" is required (not null)
            if (owner == null)
            {
                throw new InvalidDataException("owner is a required property for RepositoryDto and cannot be null");
            }
            else
            {
                this.Owner = owner;
            }
            
            // to ensure "permissions" is required (not null)
            if (permissions == null)
            {
                throw new InvalidDataException("permissions is a required property for RepositoryDto and cannot be null");
            }
            else
            {
                this.Permissions = permissions;
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
            this.Keywords = keywords;
            this.Description = description;
            this.Icon = icon;
            this.Slug = slug;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Whether or not a repository is publicly viewable
        /// </summary>
        /// <value>Whether or not a repository is publicly viewable</value>
        [DataMember(Name="public", EmitDefaultValue=false)]
        [JsonProperty("public")]
        public bool Public { get; set; }  = true;
        /// <summary>
        /// keywords
        /// </summary>
        /// <value>keywords</value>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        [JsonProperty("keywords")]
        public List<string> Keywords { get; set; } 
        /// <summary>
        /// description
        /// </summary>
        /// <value>description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; } 
        /// <summary>
        /// icon
        /// </summary>
        /// <value>icon</value>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        [JsonProperty("icon")]
        public string Icon { get; set; } 
        /// <summary>
        /// The name of the repository
        /// </summary>
        /// <value>The name of the repository</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// The latest package version to be indexed
        /// </summary>
        /// <value>The latest package version to be indexed</value>
        [DataMember(Name="latest_tag", EmitDefaultValue=false)]
        [JsonProperty("latest_tag")]
        public string LatestTag { get; set; } 
        /// <summary>
        /// The owner of the repository
        /// </summary>
        /// <value>The owner of the repository</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        [JsonProperty("owner")]
        public AccountPublic Owner { get; set; } 
        /// <summary>
        /// The repository slug
        /// </summary>
        /// <value>The repository slug</value>
        [DataMember(Name="slug", EmitDefaultValue=false)]
        [JsonProperty("slug")]
        public string Slug { get; set; } 
        /// <summary>
        /// The permissions the user making the API call has on the resource
        /// </summary>
        /// <value>The permissions the user making the API call has on the resource</value>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        [JsonProperty("permissions")]
        public RepositoryPermissions Permissions { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryDto {\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LatestTag: ").Append(LatestTag).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
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
        /// <returns>RepositoryDto object</returns>
        public static RepositoryDto FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RepositoryDto>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RepositoryDto object</returns>
        public RepositoryDto DuplicateRepositoryDto()
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
            return this.Equals(input as RepositoryDto);
        }

        /// <summary>
        /// Returns true if RepositoryDto instances are equal
        /// </summary>
        /// <param name="input">Instance of RepositoryDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepositoryDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Public == input.Public ||
                    (this.Public != null &&
                    this.Public.Equals(input.Public))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    input.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LatestTag == input.LatestTag ||
                    (this.LatestTag != null &&
                    this.LatestTag.Equals(input.LatestTag))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
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
                if (this.Public != null)
                    hashCode = hashCode * 59 + this.Public.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.LatestTag != null)
                    hashCode = hashCode * 59 + this.LatestTag.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Slug != null)
                    hashCode = hashCode * 59 + this.Slug.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
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
