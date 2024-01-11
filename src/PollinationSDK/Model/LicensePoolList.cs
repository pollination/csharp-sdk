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
    /// LicensePoolList
    /// </summary>
    [DataContract(Name = "LicensePoolList")]
    public partial class LicensePoolList : OpenAPIGenBaseModel, IEquatable<LicensePoolList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensePoolList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LicensePoolList() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "LicensePoolList";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensePoolList" /> class.
        /// </summary>
        /// <param name="resources">resources (required).</param>
        public LicensePoolList
        (
           List<LicensePoolPublic> resources// Required parameters
            // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "resources" is required (not null)
            this.Resources = resources ?? throw new ArgumentNullException("resources is a required property for LicensePoolList and cannot be null");

            // Set non-required readonly properties with defaultValue
            this.Type = "LicensePoolList";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "LicensePoolList";

        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [DataMember(Name = "resources", IsRequired = true)]
        public List<LicensePoolPublic> Resources { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "LicensePoolList";
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
            sb.Append("LicensePoolList:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Resources: ").Append(this.Resources).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>LicensePoolList object</returns>
        public static LicensePoolList FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<LicensePoolList>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>LicensePoolList object</returns>
        public virtual LicensePoolList DuplicateLicensePoolList()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateLicensePoolList();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateLicensePoolList();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as LicensePoolList);
        }

        /// <summary>
        /// Returns true if LicensePoolList instances are equal
        /// </summary>
        /// <param name="input">Instance of LicensePoolList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicensePoolList input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Resources == input.Resources ||
                    Extension.AllEquals(this.Resources, input.Resources)
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
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
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
            Regex regexType = new Regex(@"^LicensePoolList$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
