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
    /// UserPermission
    /// </summary>
    [DataContract(Name = "UserPermission")]
    public partial class UserPermission : OpenAPIGenBaseModel, IEquatable<UserPermission>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPermission" /> class.
        /// </summary>
        /// <param name="admin">The user has admin permission to this resource (default to false).</param>
        /// <param name="write">The user has write permission on this resource (default to false).</param>
        /// <param name="read">The user has read permission on this resource (default to false).</param>
        public UserPermission
        (
           // Required parameters
           bool admin = false, bool write = false, bool read = false // Optional parameters
        ) : base()// BaseClass
        {
            this.Admin = admin;
            this.Write = write;
            this.Read = read;

            // Set non-required readonly properties with defaultValue
            this.Type = "UserPermission";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; protected internal set; }  = "UserPermission";

        /// <summary>
        /// The user has admin permission to this resource
        /// </summary>
        /// <value>The user has admin permission to this resource</value>
        [DataMember(Name = "admin", EmitDefaultValue = true)]
        public bool Admin { get; set; }  = false;
        /// <summary>
        /// The user has write permission on this resource
        /// </summary>
        /// <value>The user has write permission on this resource</value>
        [DataMember(Name = "write", EmitDefaultValue = true)]
        public bool Write { get; set; }  = false;
        /// <summary>
        /// The user has read permission on this resource
        /// </summary>
        /// <value>The user has read permission on this resource</value>
        [DataMember(Name = "read", EmitDefaultValue = true)]
        public bool Read { get; set; }  = false;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "UserPermission";
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
            sb.Append("UserPermission:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Admin: ").Append(Admin).Append("\n");
            sb.Append("  Write: ").Append(Write).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>UserPermission object</returns>
        public static UserPermission FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<UserPermission>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>UserPermission object</returns>
        public virtual UserPermission DuplicateUserPermission()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateUserPermission();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateUserPermission();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as UserPermission);
        }

        /// <summary>
        /// Returns true if UserPermission instances are equal
        /// </summary>
        /// <param name="input">Instance of UserPermission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserPermission input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Admin == input.Admin ||
                    (this.Admin != null &&
                    this.Admin.Equals(input.Admin))
                ) && base.Equals(input) && 
                (
                    this.Write == input.Write ||
                    (this.Write != null &&
                    this.Write.Equals(input.Write))
                ) && base.Equals(input) && 
                (
                    this.Read == input.Read ||
                    (this.Read != null &&
                    this.Read.Equals(input.Read))
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
                if (this.Admin != null)
                    hashCode = hashCode * 59 + this.Admin.GetHashCode();
                if (this.Write != null)
                    hashCode = hashCode * 59 + this.Write.GetHashCode();
                if (this.Read != null)
                    hashCode = hashCode * 59 + this.Read.GetHashCode();
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
            Regex regexType = new Regex(@"^UserPermission$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
