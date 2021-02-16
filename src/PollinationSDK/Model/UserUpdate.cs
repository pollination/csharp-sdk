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
using QueenbeeSDK;

namespace PollinationSDK
{
    /// <summary>
    /// UserUpdate
    /// </summary>
    [DataContract(Name = "UserUpdate")]
    public partial class UserUpdate : OpenAPIGenBaseModel, IEquatable<UserUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserUpdate() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "UserUpdate";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUpdate" /> class.
        /// </summary>
        /// <param name="name">The display name for this user (required).</param>
        /// <param name="pictureUrl">URL to the picture associated with this user (required).</param>
        /// <param name="description">A description of the user (default to &quot;&quot;).</param>
        public UserUpdate
        (
           string name, string pictureUrl, // Required parameters
           string description = "" // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for UserUpdate and cannot be null");
            // to ensure "pictureUrl" is required (not null)
            this.PictureUrl = pictureUrl ?? throw new ArgumentNullException("pictureUrl is a required property for UserUpdate and cannot be null");
            // use default value if no "description" provided
            this.Description = description ?? "";

            // Set non-required readonly properties with defaultValue
            this.Type = "UserUpdate";
        }

        /// <summary>
        /// The display name for this user
        /// </summary>
        /// <value>The display name for this user</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; } 
        /// <summary>
        /// URL to the picture associated with this user
        /// </summary>
        /// <value>URL to the picture associated with this user</value>
        [DataMember(Name = "picture_url", IsRequired = true, EmitDefaultValue = false)]
        public string PictureUrl { get; set; } 
        /// <summary>
        /// A description of the user
        /// </summary>
        /// <value>A description of the user</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }  = "";

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "UserUpdate";
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
            sb.Append("UserUpdate:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PictureUrl: ").Append(PictureUrl).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>UserUpdate object</returns>
        public static UserUpdate FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<UserUpdate>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>UserUpdate object</returns>
        public virtual UserUpdate DuplicateUserUpdate()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateUserUpdate();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateUserUpdate();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserUpdate);
        }

        /// <summary>
        /// Returns true if UserUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of UserUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserUpdate input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.PictureUrl == input.PictureUrl ||
                    (this.PictureUrl != null &&
                    this.PictureUrl.Equals(input.PictureUrl))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PictureUrl != null)
                    hashCode = hashCode * 59 + this.PictureUrl.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^UserUpdate$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
