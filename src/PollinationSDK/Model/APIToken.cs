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
    /// APIToken
    /// </summary>
    [DataContract(Name = "APIToken")]
    public partial class APIToken : OpenAPIGenBaseModel, IEquatable<APIToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIToken" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected APIToken() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "APIToken";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="APIToken" /> class.
        /// </summary>
        /// <param name="tokenId">The unique ID of this API token (required).</param>
        /// <param name="name">The user friendly name of the API token (required).</param>
        /// <param name="claims">Key value pairs of auth claims the API token is entitled to.</param>
        public APIToken
        (
           string tokenId, string name, // Required parameters
           Dictionary<string, string> claims= default // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "tokenId" is required (not null)
            this.TokenId = tokenId ?? throw new ArgumentNullException("tokenId is a required property for APIToken and cannot be null");
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for APIToken and cannot be null");
            this.Claims = claims;

            // Set non-required readonly properties with defaultValue
            this.Type = "APIToken";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "APIToken";

        /// <summary>
        /// The unique ID of this API token
        /// </summary>
        /// <value>The unique ID of this API token</value>
        [DataMember(Name = "token_id", IsRequired = true)]
        public string TokenId { get; set; } 
        /// <summary>
        /// The user friendly name of the API token
        /// </summary>
        /// <value>The user friendly name of the API token</value>
        [DataMember(Name = "name", IsRequired = true)]
        public string Name { get; set; } 
        /// <summary>
        /// Key value pairs of auth claims the API token is entitled to
        /// </summary>
        /// <value>Key value pairs of auth claims the API token is entitled to</value>
        [DataMember(Name = "claims")]
        public Dictionary<string, string> Claims { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "APIToken";
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
            sb.Append("APIToken:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  TokenId: ").Append(this.TokenId).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Claims: ").Append(this.Claims).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>APIToken object</returns>
        public static APIToken FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<APIToken>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>APIToken object</returns>
        public virtual APIToken DuplicateAPIToken()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateAPIToken();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateAPIToken();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as APIToken);
        }

        /// <summary>
        /// Returns true if APIToken instances are equal
        /// </summary>
        /// <param name="input">Instance of APIToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIToken input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.TokenId, input.TokenId) && 
                    Extension.Equals(this.Name, input.Name) && 
                (
                    this.Claims == input.Claims ||
                    Extension.AllEquals(this.Claims, input.Claims)
                ) && 
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
                if (this.TokenId != null)
                    hashCode = hashCode * 59 + this.TokenId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Claims != null)
                    hashCode = hashCode * 59 + this.Claims.GetHashCode();
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
            Regex regexType = new Regex(@"^APIToken$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
