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
    /// RefreshTokenDto
    /// </summary>
    [DataContract]
    public partial class RefreshTokenDto :  IEquatable<RefreshTokenDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshTokenDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RefreshTokenDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshTokenDto" /> class.
        /// </summary>
        /// <param name="tokenName">tokenName (required).</param>
        public RefreshTokenDto
        (
           string tokenName// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "tokenName" is required (not null)
            if (tokenName == null)
            {
                throw new InvalidDataException("tokenName is a required property for RefreshTokenDto and cannot be null");
            }
            else
            {
                this.TokenName = tokenName;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
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
            sb.Append("class RefreshTokenDto {\n");
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
        /// <returns>RefreshTokenDto object</returns>
        public static RefreshTokenDto FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RefreshTokenDto>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RefreshTokenDto object</returns>
        public RefreshTokenDto DuplicateRefreshTokenDto()
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
            return this.Equals(input as RefreshTokenDto);
        }

        /// <summary>
        /// Returns true if RefreshTokenDto instances are equal
        /// </summary>
        /// <param name="input">Instance of RefreshTokenDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefreshTokenDto input)
        {
            if (input == null)
                return false;
            return 
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
