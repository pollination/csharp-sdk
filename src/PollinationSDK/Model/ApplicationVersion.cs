/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.28.1
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
    /// ApplicationVersion
    /// </summary>
    [DataContract]
    public partial class ApplicationVersion :  IEquatable<ApplicationVersion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationVersion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationVersion() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationVersion" /> class.
        /// </summary>
        /// <param name="author">The author that created the application version (required).</param>
        /// <param name="buildStatus">The status of the application version build (required).</param>
        /// <param name="createdAt">The time the application version was created.</param>
        /// <param name="id">The application version ID (required).</param>
        /// <param name="releaseNotes">The release notes for the application version (default to &quot;&quot;).</param>
        /// <param name="tag">The tag for this version of the application (required).</param>
        public ApplicationVersion
        (
           AccountPublic author, BuildStatus buildStatus, Guid id, string tag, // Required parameters
           DateTime createdAt= default, string releaseNotes = "" // Optional parameters
        )// BaseClass
        {
            // to ensure "author" is required (not null)
            if (author == null)
            {
                throw new InvalidDataException("author is a required property for ApplicationVersion and cannot be null");
            }
            else
            {
                this.Author = author;
            }
            
            // to ensure "buildStatus" is required (not null)
            if (buildStatus == null)
            {
                throw new InvalidDataException("buildStatus is a required property for ApplicationVersion and cannot be null");
            }
            else
            {
                this.BuildStatus = buildStatus;
            }
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ApplicationVersion and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "tag" is required (not null)
            if (tag == null)
            {
                throw new InvalidDataException("tag is a required property for ApplicationVersion and cannot be null");
            }
            else
            {
                this.Tag = tag;
            }
            
            this.CreatedAt = createdAt;
            // use default value if no "releaseNotes" provided
            if (releaseNotes == null)
            {
                this.ReleaseNotes ="";
            }
            else
            {
                this.ReleaseNotes = releaseNotes;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The author that created the application version
        /// </summary>
        /// <value>The author that created the application version</value>
        [DataMember(Name="author", EmitDefaultValue=false)]
        [JsonProperty("author")]
        public AccountPublic Author { get; set; } 
        /// <summary>
        /// The status of the application version build
        /// </summary>
        /// <value>The status of the application version build</value>
        [DataMember(Name="build_status", EmitDefaultValue=false)]
        [JsonProperty("build_status")]
        public BuildStatus BuildStatus { get; set; } 
        /// <summary>
        /// The time the application version was created
        /// </summary>
        /// <value>The time the application version was created</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; } 
        /// <summary>
        /// The application version ID
        /// </summary>
        /// <value>The application version ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public Guid Id { get; set; } 
        /// <summary>
        /// The release notes for the application version
        /// </summary>
        /// <value>The release notes for the application version</value>
        [DataMember(Name="release_notes", EmitDefaultValue=false)]
        [JsonProperty("release_notes")]
        public string ReleaseNotes { get; set; }  = "";
        /// <summary>
        /// The tag for this version of the application
        /// </summary>
        /// <value>The tag for this version of the application</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        [JsonProperty("tag")]
        public string Tag { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationVersion {\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  BuildStatus: ").Append(BuildStatus).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ReleaseNotes: ").Append(ReleaseNotes).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
        /// <returns>ApplicationVersion object</returns>
        public static ApplicationVersion FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ApplicationVersion>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ApplicationVersion object</returns>
        public ApplicationVersion DuplicateApplicationVersion()
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
            return this.Equals(input as ApplicationVersion);
        }

        /// <summary>
        /// Returns true if ApplicationVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationVersion input)
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
                    this.BuildStatus == input.BuildStatus ||
                    (this.BuildStatus != null &&
                    this.BuildStatus.Equals(input.BuildStatus))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ReleaseNotes == input.ReleaseNotes ||
                    (this.ReleaseNotes != null &&
                    this.ReleaseNotes.Equals(input.ReleaseNotes))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
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
                if (this.BuildStatus != null)
                    hashCode = hashCode * 59 + this.BuildStatus.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ReleaseNotes != null)
                    hashCode = hashCode * 59 + this.ReleaseNotes.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
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
