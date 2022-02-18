/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.26.1
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
    /// OrganizationMember
    /// </summary>
    [DataContract]
    public partial class OrganizationMember :  IEquatable<OrganizationMember>, IValidatableObject
    {
        /// <summary>
        /// The role the user has within the organization
        /// </summary>
        /// <value>The role the user has within the organization</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public OrganizationRoleEnum Role { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMember" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrganizationMember() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMember" /> class.
        /// </summary>
        /// <param name="role">The role the user has within the organization (required).</param>
        /// <param name="user">The organization member (required).</param>
        public OrganizationMember
        (
           OrganizationRoleEnum role, UserPublic user// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "role" is required (not null)
            if (role == null)
            {
                throw new InvalidDataException("role is a required property for OrganizationMember and cannot be null");
            }
            else
            {
                this.Role = role;
            }
            
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new InvalidDataException("user is a required property for OrganizationMember and cannot be null");
            }
            else
            {
                this.User = user;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The organization member
        /// </summary>
        /// <value>The organization member</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        [JsonProperty("user")]
        public UserPublic User { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationMember {\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
        /// <returns>OrganizationMember object</returns>
        public static OrganizationMember FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<OrganizationMember>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OrganizationMember object</returns>
        public OrganizationMember DuplicateOrganizationMember()
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
            return 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
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
