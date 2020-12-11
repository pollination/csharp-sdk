/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
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
using QueenbeeSDK;

namespace PollinationSDK
{
    /// <summary>
    /// Repository
    /// </summary>
    [DataContract(Name = "Repository")]
    public partial class Repository : RepositoryCreate, IEquatable<Repository>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Repository" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Repository() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "Repository";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Repository" /> class.
        /// </summary>
        /// <param name="id">The recipe unique ID (required).</param>
        /// <param name="latestTag">The latest package version to be indexed (required).</param>
        /// <param name="owner">The owner of the repository (required).</param>
        /// <param name="permissions">The permissions the user making the API call has on the resource.</param>
        /// <param name="slug">The repository slug.</param>
        /// <param name="_public">Whether or not a repository is publicly viewable (default to true).</param>
        /// <param name="keywords">A list of keywords to index the repository by.</param>
        /// <param name="description">A description of the repository.</param>
        /// <param name="icon">An icon to represent this repository.</param>
        /// <param name="name">The name of the repository (required).</param>
        public Repository
        (
            string name, string id, string latestTag, AccountPublic owner, // Required parameters
            bool _public = true, List<string> keywords= default, string description= default, string icon= default, RepositoryUserPermissions permissions= default, string slug= default // Optional parameters
        ) : base(_public: _public, keywords: keywords, description: description, icon: icon, name: name)// BaseClass
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for Repository and cannot be null");
            // to ensure "latestTag" is required (not null)
            this.LatestTag = latestTag ?? throw new ArgumentNullException("latestTag is a required property for Repository and cannot be null");
            // to ensure "owner" is required (not null)
            this.Owner = owner ?? throw new ArgumentNullException("owner is a required property for Repository and cannot be null");
            this.Permissions = permissions;
            this.Slug = slug;

            // Set non-required readonly properties with defaultValue
            this.Type = "Repository";
        }

        /// <summary>
        /// The recipe unique ID
        /// </summary>
        /// <value>The recipe unique ID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; } 
        /// <summary>
        /// The latest package version to be indexed
        /// </summary>
        /// <value>The latest package version to be indexed</value>
        [DataMember(Name = "latest_tag", IsRequired = true, EmitDefaultValue = false)]
        public string LatestTag { get; set; } 
        /// <summary>
        /// The owner of the repository
        /// </summary>
        /// <value>The owner of the repository</value>
        [DataMember(Name = "owner", IsRequired = true, EmitDefaultValue = false)]
        public AccountPublic Owner { get; set; } 
        /// <summary>
        /// The permissions the user making the API call has on the resource
        /// </summary>
        /// <value>The permissions the user making the API call has on the resource</value>
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public RepositoryUserPermissions Permissions { get; set; } 
        /// <summary>
        /// The repository slug
        /// </summary>
        /// <value>The repository slug</value>
        [DataMember(Name = "slug", EmitDefaultValue = false)]
        public string Slug { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Repository";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("Repository:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LatestTag: ").Append(LatestTag).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Repository object</returns>
        public static Repository FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Repository>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Repository object</returns>
        public virtual Repository DuplicateRepository()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateRepository();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override RepositoryCreate DuplicateRepositoryCreate()
        {
            return DuplicateRepository();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Repository);
        }

        /// <summary>
        /// Returns true if Repository instances are equal
        /// </summary>
        /// <param name="input">Instance of Repository to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Repository input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.LatestTag == input.LatestTag ||
                    (this.LatestTag != null &&
                    this.LatestTag.Equals(input.LatestTag))
                ) && base.Equals(input) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && base.Equals(input) && 
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
                ) && base.Equals(input) && 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                int hashCode = base.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LatestTag != null)
                    hashCode = hashCode * 59 + this.LatestTag.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.Slug != null)
                    hashCode = hashCode * 59 + this.Slug.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^Repository$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
