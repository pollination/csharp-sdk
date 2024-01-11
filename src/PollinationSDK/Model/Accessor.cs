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
    /// Accessor
    /// </summary>
    [DataContract(Name = "Accessor")]
    public partial class Accessor : OpenAPIGenBaseModel, IEquatable<Accessor>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [DataMember(Name="permission")]
        public Permission Permission { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="Accessor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Accessor() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "Accessor";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Accessor" /> class.
        /// </summary>
        /// <param name="subject">subject (required).</param>
        /// <param name="permission">permission (required).</param>
        public Accessor
        (
           AnyOf<AccountPublic,Team> subject, Permission permission// Required parameters
            // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "subject" is required (not null)
            this.Subject = subject ?? throw new ArgumentNullException("subject is a required property for Accessor and cannot be null");
            this.Permission = permission;

            // Set non-required readonly properties with defaultValue
            this.Type = "Accessor";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "Accessor";

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", IsRequired = true)]
        public AnyOf<AccountPublic,Team> Subject { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Accessor";
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
            sb.Append("Accessor:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Subject: ").Append(this.Subject).Append("\n");
            sb.Append("  Permission: ").Append(this.Permission).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Accessor object</returns>
        public static Accessor FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Accessor>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Accessor object</returns>
        public virtual Accessor DuplicateAccessor()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateAccessor();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateAccessor();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Accessor);
        }

        /// <summary>
        /// Returns true if Accessor instances are equal
        /// </summary>
        /// <param name="input">Instance of Accessor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Accessor input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Subject, input.Subject) && 
                    Extension.Equals(this.Permission, input.Permission) && 
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
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
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
            Regex regexType = new Regex(@"^Accessor$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
