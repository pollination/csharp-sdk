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
    /// TeamMember
    /// </summary>
    [DataContract(Name = "TeamMember")]
    public partial class TeamMember : OpenAPIGenBaseModel, IEquatable<TeamMember>, IValidatableObject
    {
        /// <summary>
        /// The role the user has within the team
        /// </summary>
        /// <value>The role the user has within the team</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public TeamRoleEnum Role { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMember" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TeamMember() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "TeamMember";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMember" /> class.
        /// </summary>
        /// <param name="user">The team member (required).</param>
        /// <param name="role">The role the user has within the team (required).</param>
        public TeamMember
        (
           UserPublic user, TeamRoleEnum role// Required parameters
           // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "user" is required (not null)
            this.User = user ?? throw new ArgumentNullException("user is a required property for TeamMember and cannot be null");
            this.Role = role;

            // Set non-required readonly properties with defaultValue
            this.Type = "TeamMember";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; protected internal set; }  = "TeamMember";

        /// <summary>
        /// The team member
        /// </summary>
        /// <value>The team member</value>
        [DataMember(Name = "user", IsRequired = true, EmitDefaultValue = false)]
        public UserPublic User { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "TeamMember";
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
            sb.Append("TeamMember:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>TeamMember object</returns>
        public static TeamMember FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<TeamMember>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>TeamMember object</returns>
        public virtual TeamMember DuplicateTeamMember()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateTeamMember();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateTeamMember();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as TeamMember);
        }

        /// <summary>
        /// Returns true if TeamMember instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamMember input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && base.Equals(input) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
            Regex regexType = new Regex(@"^TeamMember$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
