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
    /// RefreshTokenCreate
    /// </summary>
    [DataContract]
    public partial class RefreshTokenCreate :  IEquatable<RefreshTokenCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshTokenCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RefreshTokenCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshTokenCreate" /> class.
        /// </summary>
        /// <param name="email">An email address (required).</param>
        /// <param name="password">The password for the account associated with the email address (required).</param>
        /// <param name="tokenName">A refresh token that can be used to authenticate to the API (required).</param>
        public RefreshTokenCreate
        (
           string email, string password, string tokenName// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for RefreshTokenCreate and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new InvalidDataException("password is a required property for RefreshTokenCreate and cannot be null");
            }
            else
            {
                this.Password = password;
            }
            
            // to ensure "tokenName" is required (not null)
            if (tokenName == null)
            {
                throw new InvalidDataException("tokenName is a required property for RefreshTokenCreate and cannot be null");
            }
            else
            {
                this.TokenName = tokenName;
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
        /// The password for the account associated with the email address
        /// </summary>
        /// <value>The password for the account associated with the email address</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        [JsonProperty("password")]
        public string Password { get; set; } 
        /// <summary>
        /// A refresh token that can be used to authenticate to the API
        /// </summary>
        /// <value>A refresh token that can be used to authenticate to the API</value>
        [DataMember(Name="token_name", EmitDefaultValue=false)]
        [JsonProperty("token_name")]
        public string TokenName { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefreshTokenCreate {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  TokenName: ").Append(TokenName).Append("\n");
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
        /// <returns>RefreshTokenCreate object</returns>
        public static RefreshTokenCreate FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RefreshTokenCreate>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RefreshTokenCreate object</returns>
        public RefreshTokenCreate DuplicateRefreshTokenCreate()
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
            return this.Equals(input as RefreshTokenCreate);
        }

        /// <summary>
        /// Returns true if RefreshTokenCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of RefreshTokenCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefreshTokenCreate input)
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
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.TokenName == input.TokenName ||
                    (this.TokenName != null &&
                    this.TokenName.Equals(input.TokenName))
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
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.TokenName != null)
                    hashCode = hashCode * 59 + this.TokenName.GetHashCode();
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