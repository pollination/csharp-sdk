/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: 0.9.2
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
    /// SignUp
    /// </summary>
    [DataContract]
    public partial class SignUp :  IEquatable<SignUp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignUp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignUp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignUp" /> class.
        /// </summary>
        /// <param name="email">An email address (required).</param>
        /// <param name="metadata">Some information about the user (required).</param>
        /// <param name="password">A password for the user (required).</param>
        /// <param name="username">A lower case username without spaces (required).</param>
        public SignUp
        (
           string email, UserMetadata metadata, string password, string username// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for SignUp and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new InvalidDataException("metadata is a required property for SignUp and cannot be null");
            }
            else
            {
                this.Metadata = metadata;
            }
            
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new InvalidDataException("password is a required property for SignUp and cannot be null");
            }
            else
            {
                this.Password = password;
            }
            
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new InvalidDataException("username is a required property for SignUp and cannot be null");
            }
            else
            {
                this.Username = username;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// An email address
        /// </summary>
        /// <value>An email address</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        [JsonProperty("email")]
        public string Email { get; set; } 
        /// <summary>
        /// Some information about the user
        /// </summary>
        /// <value>Some information about the user</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        [JsonProperty("metadata")]
        public UserMetadata Metadata { get; set; } 
        /// <summary>
        /// A password for the user
        /// </summary>
        /// <value>A password for the user</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        [JsonProperty("password")]
        public string Password { get; set; } 
        /// <summary>
        /// A lower case username without spaces
        /// </summary>
        /// <value>A lower case username without spaces</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        [JsonProperty("username")]
        public string Username { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignUp {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
        /// <returns>SignUp object</returns>
        public static SignUp FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SignUp>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SignUp object</returns>
        public SignUp DuplicateSignUp()
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
            return this.Equals(input as SignUp);
        }

        /// <summary>
        /// Returns true if SignUp instances are equal
        /// </summary>
        /// <param name="input">Instance of SignUp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignUp input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
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
