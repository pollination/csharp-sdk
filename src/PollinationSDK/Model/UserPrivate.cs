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
    /// UserPrivate
    /// </summary>
    [DataContract(Name = "UserPrivate")]
    public partial class UserPrivate : UserPublic, IEquatable<UserPrivate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPrivate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserPrivate() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "UserPrivate";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPrivate" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="email">email (required).</param>
        /// <param name="username">The lowercase account name for this user (required).</param>
        /// <param name="name">The display name for this user.</param>
        /// <param name="description">A short description of the user.</param>
        /// <param name="picture">URL to the picture associated with this user.</param>
        public UserPrivate
        (
            string username, string id, string email, // Required parameters
            string name= default, string description= default, string picture= default // Optional parameters
        ) : base(username: username, name: name, description: description, picture: picture)// BaseClass
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for UserPrivate and cannot be null");
            // to ensure "email" is required (not null)
            this.Email = email ?? throw new ArgumentNullException("email is a required property for UserPrivate and cannot be null");

            // Set non-required readonly properties with defaultValue
            this.Type = "UserPrivate";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; protected internal set; }  = "UserPrivate";

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; } 
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = false)]
        public string Email { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "UserPrivate";
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
            sb.Append("UserPrivate:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Picture: ").Append(Picture).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>UserPrivate object</returns>
        public static UserPrivate FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<UserPrivate>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>UserPrivate object</returns>
        public virtual UserPrivate DuplicateUserPrivate()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateUserPrivate();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override UserPublic DuplicateUserPublic()
        {
            return DuplicateUserPrivate();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as UserPrivate);
        }

        /// <summary>
        /// Returns true if UserPrivate instances are equal
        /// </summary>
        /// <param name="input">Instance of UserPrivate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserPrivate input)
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
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
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
            Regex regexType = new Regex(@"^UserPrivate$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
