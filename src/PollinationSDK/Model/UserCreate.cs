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
    /// UserCreate
    /// </summary>
    [DataContract(Name = "UserCreate")]
    public partial class UserCreate : UserUpdate, IEquatable<UserCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserCreate() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "UserCreate";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCreate" /> class.
        /// </summary>
        /// <param name="username">The unique name of the user in small case without spaces (required).</param>
        /// <param name="email">The contact email for the Organization (required).</param>
        /// <param name="password">A password for this new user to authenticate with (required).</param>
        /// <param name="name">The display name for this user (required).</param>
        /// <param name="pictureUrl">URL to the picture associated with this user (required).</param>
        /// <param name="description">A description of the user (default to &quot;&quot;).</param>
        public UserCreate
        (
            string name, string pictureUrl, string username, string email, string password, // Required parameters
            string description = "" // Optional parameters
        ) : base(name: name, pictureUrl: pictureUrl, description: description)// BaseClass
        {
            // to ensure "username" is required (not null)
            this.Username = username ?? throw new ArgumentNullException("username is a required property for UserCreate and cannot be null");
            // to ensure "email" is required (not null)
            this.Email = email ?? throw new ArgumentNullException("email is a required property for UserCreate and cannot be null");
            // to ensure "password" is required (not null)
            this.Password = password ?? throw new ArgumentNullException("password is a required property for UserCreate and cannot be null");

            // Set non-required readonly properties with defaultValue
            this.Type = "UserCreate";
        }

        /// <summary>
        /// The unique name of the user in small case without spaces
        /// </summary>
        /// <value>The unique name of the user in small case without spaces</value>
        [DataMember(Name = "username", IsRequired = true, EmitDefaultValue = false)]
        public string Username { get; set; } 
        /// <summary>
        /// The contact email for the Organization
        /// </summary>
        /// <value>The contact email for the Organization</value>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = false)]
        public string Email { get; set; } 
        /// <summary>
        /// A password for this new user to authenticate with
        /// </summary>
        /// <value>A password for this new user to authenticate with</value>
        [DataMember(Name = "password", IsRequired = true, EmitDefaultValue = false)]
        public string Password { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "UserCreate";
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
            sb.Append("UserCreate:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PictureUrl: ").Append(PictureUrl).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>UserCreate object</returns>
        public static UserCreate FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<UserCreate>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>UserCreate object</returns>
        public virtual UserCreate DuplicateUserCreate()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateUserCreate();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override UserUpdate DuplicateUserUpdate()
        {
            return DuplicateUserCreate();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserCreate);
        }

        /// <summary>
        /// Returns true if UserCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of UserCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserCreate input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && base.Equals(input) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && base.Equals(input) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
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
            Regex regexType = new Regex(@"^UserCreate$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
