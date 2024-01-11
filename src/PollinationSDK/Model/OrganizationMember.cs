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
    /// OrganizationMember
    /// </summary>
    [DataContract(Name = "OrganizationMember")]
    public partial class OrganizationMember : OpenAPIGenBaseModel, IEquatable<OrganizationMember>, IValidatableObject
    {
        /// <summary>
        /// The role the user has within the organization
        /// </summary>
        /// <value>The role the user has within the organization</value>
        [DataMember(Name="role")]
        public OrganizationRoleEnum Role { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMember" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrganizationMember() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "OrganizationMember";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMember" /> class.
        /// </summary>
        /// <param name="user">The organization member (required).</param>
        /// <param name="role">The role the user has within the organization (required).</param>
        public OrganizationMember
        (
           UserPublic user, OrganizationRoleEnum role// Required parameters
            // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "user" is required (not null)
            this.User = user ?? throw new ArgumentNullException("user is a required property for OrganizationMember and cannot be null");
            this.Role = role;

            // Set non-required readonly properties with defaultValue
            this.Type = "OrganizationMember";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "OrganizationMember";

        /// <summary>
        /// The organization member
        /// </summary>
        /// <value>The organization member</value>
        [DataMember(Name = "user", IsRequired = true)]
        public UserPublic User { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "OrganizationMember";
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
            sb.Append("OrganizationMember:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  User: ").Append(this.User).Append("\n");
            sb.Append("  Role: ").Append(this.Role).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>OrganizationMember object</returns>
        public static OrganizationMember FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<OrganizationMember>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OrganizationMember object</returns>
        public virtual OrganizationMember DuplicateOrganizationMember()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateOrganizationMember();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateOrganizationMember();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as OrganizationMember);
        }

        /// <summary>
        /// Returns true if OrganizationMember instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationMember input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.User, input.User) && 
                    Extension.Equals(this.Role, input.Role) && 
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
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
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
            Regex regexType = new Regex(@"^OrganizationMember$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
