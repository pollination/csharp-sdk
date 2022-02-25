/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.26.3
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
    /// RecipePackage
    /// </summary>
    [DataContract]
    public partial class RecipePackage :  IEquatable<RecipePackage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipePackage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecipePackage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipePackage" /> class.
        /// </summary>
        /// <param name="createdAt">Creation Timestamp.</param>
        /// <param name="description">description.</param>
        /// <param name="digest">The new package digest (required).</param>
        /// <param name="icon">icon.</param>
        /// <param name="keywords">keywords.</param>
        /// <param name="manifest">manifest (required).</param>
        /// <param name="readme">The Repository Readme.</param>
        /// <param name="tag">The new package tag (required).</param>
        public RecipePackage
        (
           string digest, RecipeInterface manifest, string tag, // Required parameters
           DateTime createdAt= default, string description= default, string icon= default, List<string> keywords= default, string readme= default // Optional parameters
        )// BaseClass
        {
            // to ensure "digest" is required (not null)
            if (digest == null)
            {
                throw new InvalidDataException("digest is a required property for RecipePackage and cannot be null");
            }
            else
            {
                this.Digest = digest;
            }
            
            // to ensure "manifest" is required (not null)
            if (manifest == null)
            {
                throw new InvalidDataException("manifest is a required property for RecipePackage and cannot be null");
            }
            else
            {
                this.Manifest = manifest;
            }
            
            // to ensure "tag" is required (not null)
            if (tag == null)
            {
                throw new InvalidDataException("tag is a required property for RecipePackage and cannot be null");
            }
            else
            {
                this.Tag = tag;
            }
            
            this.CreatedAt = createdAt;
            this.Description = description;
            this.Icon = icon;
            this.Keywords = keywords;
            this.Readme = readme;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Creation Timestamp
        /// </summary>
        /// <value>Creation Timestamp</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; } 
        /// <summary>
        /// description
        /// </summary>
        /// <value>description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; } 
        /// <summary>
        /// The new package digest
        /// </summary>
        /// <value>The new package digest</value>
        [DataMember(Name="digest", EmitDefaultValue=false)]
        [JsonProperty("digest")]
        public string Digest { get; set; } 
        /// <summary>
        /// icon
        /// </summary>
        /// <value>icon</value>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        [JsonProperty("icon")]
        public string Icon { get; set; } 
        /// <summary>
        /// keywords
        /// </summary>
        /// <value>keywords</value>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        [JsonProperty("keywords")]
        public List<string> Keywords { get; set; } 
        /// <summary>
        /// Gets or Sets Manifest
        /// </summary>
        [DataMember(Name="manifest", EmitDefaultValue=false)]
        [JsonProperty("manifest")]
        public RecipeInterface Manifest { get; set; } 
        /// <summary>
        /// The Repository Readme
        /// </summary>
        /// <value>The Repository Readme</value>
        [DataMember(Name="readme", EmitDefaultValue=false)]
        [JsonProperty("readme")]
        public string Readme { get; set; } 
        /// <summary>
        /// The new package tag
        /// </summary>
        /// <value>The new package tag</value>
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
            sb.Append("class RecipePackage {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Digest: ").Append(Digest).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  Manifest: ").Append(Manifest).Append("\n");
            sb.Append("  Readme: ").Append(Readme).Append("\n");
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
        /// <returns>RecipePackage object</returns>
        public static RecipePackage FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RecipePackage>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RecipePackage object</returns>
        public RecipePackage DuplicateRecipePackage()
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
            return this.Equals(input as RecipePackage);
        }

        /// <summary>
        /// Returns true if RecipePackage instances are equal
        /// </summary>
        /// <param name="input">Instance of RecipePackage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipePackage input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Digest == input.Digest ||
                    (this.Digest != null &&
                    this.Digest.Equals(input.Digest))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    input.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
                ) && 
                (
                    this.Manifest == input.Manifest ||
                    (this.Manifest != null &&
                    this.Manifest.Equals(input.Manifest))
                ) && 
                (
                    this.Readme == input.Readme ||
                    (this.Readme != null &&
                    this.Readme.Equals(input.Readme))
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Digest != null)
                    hashCode = hashCode * 59 + this.Digest.GetHashCode();
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.Manifest != null)
                    hashCode = hashCode * 59 + this.Manifest.GetHashCode();
                if (this.Readme != null)
                    hashCode = hashCode * 59 + this.Readme.GetHashCode();
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
