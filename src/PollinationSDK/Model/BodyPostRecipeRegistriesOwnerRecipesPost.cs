/* 
 * Pollination Server
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
using QueenbeeSDK;

namespace PollinationSDK
{
    /// <summary>
    /// BodyPostRecipeRegistriesOwnerRecipesPost
    /// </summary>
    [DataContract(Name = "Body_post_recipe_registries__owner__recipes_post")]
    public partial class BodyPostRecipeRegistriesOwnerRecipesPost : OpenAPIGenBaseModel, IEquatable<BodyPostRecipeRegistriesOwnerRecipesPost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPostRecipeRegistriesOwnerRecipesPost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BodyPostRecipeRegistriesOwnerRecipesPost() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "Body_post_recipe_registries__owner__recipes_post";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPostRecipeRegistriesOwnerRecipesPost" /> class.
        /// </summary>
        /// <param name="package">package (required).</param>
        public BodyPostRecipeRegistriesOwnerRecipesPost
        (
           System.IO.Stream package// Required parameters
           // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "package" is required (not null)
            this.Package = package ?? throw new ArgumentNullException("package is a required property for BodyPostRecipeRegistriesOwnerRecipesPost and cannot be null");

            // Set non-required readonly properties with defaultValue
            this.Type = "Body_post_recipe_registries__owner__recipes_post";
        }

        /// <summary>
        /// Gets or Sets Package
        /// </summary>
        [DataMember(Name = "package", IsRequired = true, EmitDefaultValue = false)]
        public System.IO.Stream Package { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "BodyPostRecipeRegistriesOwnerRecipesPost";
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
            sb.Append("BodyPostRecipeRegistriesOwnerRecipesPost:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Package: ").Append(Package).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>BodyPostRecipeRegistriesOwnerRecipesPost object</returns>
        public static BodyPostRecipeRegistriesOwnerRecipesPost FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<BodyPostRecipeRegistriesOwnerRecipesPost>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>BodyPostRecipeRegistriesOwnerRecipesPost object</returns>
        public virtual BodyPostRecipeRegistriesOwnerRecipesPost DuplicateBodyPostRecipeRegistriesOwnerRecipesPost()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateBodyPostRecipeRegistriesOwnerRecipesPost();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateBodyPostRecipeRegistriesOwnerRecipesPost();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BodyPostRecipeRegistriesOwnerRecipesPost);
        }

        /// <summary>
        /// Returns true if BodyPostRecipeRegistriesOwnerRecipesPost instances are equal
        /// </summary>
        /// <param name="input">Instance of BodyPostRecipeRegistriesOwnerRecipesPost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BodyPostRecipeRegistriesOwnerRecipesPost input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Package == input.Package ||
                    (this.Package != null &&
                    this.Package.Equals(input.Package))
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
                if (this.Package != null)
                    hashCode = hashCode * 59 + this.Package.GetHashCode();
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
            Regex regexType = new Regex(@"^Body_post_recipe_registries__owner__recipes_post$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
