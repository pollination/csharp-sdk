/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
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


namespace PollinationSDK
{
    /// <summary>
    /// RecipePackage
    /// </summary>
    [DataContract(Name = "RecipePackage")]
    public partial class RecipePackage : RepositoryPackage, IEquatable<RecipePackage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipePackage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecipePackage() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "RecipePackage";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipePackage" /> class.
        /// </summary>
        /// <param name="manifest">manifest (required).</param>
        /// <param name="digest">The new package digest (required).</param>
        /// <param name="tag">The new package tag (required).</param>
        /// <param name="keywords">keywords.</param>
        /// <param name="description">description.</param>
        /// <param name="icon">icon.</param>
        /// <param name="createdAt">Creation Timestamp.</param>
        /// <param name="readme">The Repository Readme.</param>
        public RecipePackage
        (
            string digest, string tag, RecipeInterface manifest, // Required parameters
            List<string> keywords= default, string description= default, string icon= default, DateTime createdAt= default, string readme= default // Optional parameters
        ) : base(digest: digest, tag: tag, keywords: keywords, description: description, icon: icon, createdAt: createdAt, readme: readme )// BaseClass
        {
            // to ensure "manifest" is required (not null)
            this.Manifest = manifest ?? throw new ArgumentNullException("manifest is a required property for RecipePackage and cannot be null");

            // Set non-required readonly properties with defaultValue
            this.Type = "RecipePackage";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "RecipePackage";

        /// <summary>
        /// Gets or Sets Manifest
        /// </summary>
        [DataMember(Name = "manifest", IsRequired = true)]
        public RecipeInterface Manifest { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "RecipePackage";
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
            sb.Append("RecipePackage:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Digest: ").Append(this.Digest).Append("\n");
            sb.Append("  Tag: ").Append(this.Tag).Append("\n");
            sb.Append("  Keywords: ").Append(this.Keywords).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  Icon: ").Append(this.Icon).Append("\n");
            sb.Append("  CreatedAt: ").Append(this.CreatedAt).Append("\n");
            sb.Append("  Readme: ").Append(this.Readme).Append("\n");
            sb.Append("  Manifest: ").Append(this.Manifest).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>RecipePackage object</returns>
        public static RecipePackage FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RecipePackage>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RecipePackage object</returns>
        public virtual RecipePackage DuplicateRecipePackage()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateRecipePackage();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override RepositoryPackage DuplicateRepositoryPackage()
        {
            return DuplicateRecipePackage();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
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
            return base.Equals(input) && 
                    Extension.Equals(this.Manifest, input.Manifest) && 
                    Extension.Equals(this.Type, input.Type);
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
                if (this.Manifest != null)
                    hashCode = hashCode * 59 + this.Manifest.GetHashCode();
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
            Regex regexType = new Regex(@"^RecipePackage$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
