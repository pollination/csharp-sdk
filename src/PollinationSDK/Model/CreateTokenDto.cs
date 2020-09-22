/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: 0.0.0
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
    /// CreateTokenDto
    /// </summary>
    [DataContract]
    public partial class CreateTokenDto :  IEquatable<CreateTokenDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTokenDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTokenDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTokenDto" /> class.
        /// </summary>
        /// <param name="email">email (required).</param>
        /// <param name="password">password (required).</param>
        /// <param name="tokenName">tokenName (required).</param>
        public CreateTokenDto
        (
           string email, string password, string tokenName// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for CreateTokenDto and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new InvalidDataException("password is a required property for CreateTokenDto and cannot be null");
            }
            else
            {
                this.Password = password;
            }
            
            // to ensure "tokenName" is required (not null)
            if (tokenName == null)
            {
                throw new InvalidDataException("tokenName is a required property for CreateTokenDto and cannot be null");
            }
            else
            {
                this.TokenName = tokenName;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        [JsonProperty("email")]
        public string Email { get; set; } 
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        [JsonProperty("password")]
        public string Password { get; set; } 
        /// <summary>
        /// Gets or Sets TokenName
        /// </summary>
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
            sb.Append("class CreateTokenDto {\n");
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
        /// <returns>CreateTokenDto object</returns>
        public static CreateTokenDto FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<CreateTokenDto>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>CreateTokenDto object</returns>
        public CreateTokenDto DuplicateCreateTokenDto()
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
            return this.Equals(input as CreateTokenDto);
        }

        /// <summary>
        /// Returns true if CreateTokenDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTokenDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTokenDto input)
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
