/* 
 * Pollination Server
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
using QueenbeeSDK;

namespace PollinationSDK
{
    /// <summary>
    /// RepositoryPolicySubject
    /// </summary>
    [DataContract(Name = "RepositoryPolicySubject")]
    public partial class RepositoryPolicySubject : PolicySubject, IEquatable<RepositoryPolicySubject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryPolicySubject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RepositoryPolicySubject() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "RepositoryPolicySubject";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryPolicySubject" /> class.
        /// </summary>
        /// <param name="subjectType">subjectType (required).</param>
        /// <param name="name">The name of the policy subject (required).</param>
        public RepositoryPolicySubject
        (
            SubjectTypeEnum subjectType, string name// Required parameters
           // Optional parameters
        ) : base(subjectType: subjectType, name: name)// BaseClass
        {

            // Set non-required readonly properties with defaultValue
            this.Type = "RepositoryPolicySubject";
        }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "RepositoryPolicySubject";
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
            sb.Append("RepositoryPolicySubject:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SubjectType: ").Append(SubjectType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>RepositoryPolicySubject object</returns>
        public static RepositoryPolicySubject FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RepositoryPolicySubject>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RepositoryPolicySubject object</returns>
        public virtual RepositoryPolicySubject DuplicateRepositoryPolicySubject()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateRepositoryPolicySubject();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override PolicySubject DuplicatePolicySubject()
        {
            return DuplicateRepositoryPolicySubject();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryPolicySubject);
        }

        /// <summary>
        /// Returns true if RepositoryPolicySubject instances are equal
        /// </summary>
        /// <param name="input">Instance of RepositoryPolicySubject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepositoryPolicySubject input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
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
            Regex regexType = new Regex(@"^RepositoryPolicySubject$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
