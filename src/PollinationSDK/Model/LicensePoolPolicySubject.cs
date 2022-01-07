/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.23.0
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
    /// LicensePoolPolicySubject
    /// </summary>
    [DataContract]
    public partial class LicensePoolPolicySubject :  IEquatable<LicensePoolPolicySubject>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets SubjectType
        /// </summary>
        [DataMember(Name="subject_type", EmitDefaultValue=false)]
        public SubjectType SubjectType { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensePoolPolicySubject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LicensePoolPolicySubject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensePoolPolicySubject" /> class.
        /// </summary>
        /// <param name="name">The name of the policy subject (required).</param>
        /// <param name="subjectType">subjectType (required).</param>
        public LicensePoolPolicySubject
        (
           string name, SubjectType subjectType// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for LicensePoolPolicySubject and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "subjectType" is required (not null)
            if (subjectType == null)
            {
                throw new InvalidDataException("subjectType is a required property for LicensePoolPolicySubject and cannot be null");
            }
            else
            {
                this.SubjectType = subjectType;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The name of the policy subject
        /// </summary>
        /// <value>The name of the policy subject</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicensePoolPolicySubject {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SubjectType: ").Append(SubjectType).Append("\n");
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
        /// <returns>LicensePoolPolicySubject object</returns>
        public static LicensePoolPolicySubject FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<LicensePoolPolicySubject>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>LicensePoolPolicySubject object</returns>
        public LicensePoolPolicySubject DuplicateLicensePoolPolicySubject()
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
            return this.Equals(input as LicensePoolPolicySubject);
        }

        /// <summary>
        /// Returns true if LicensePoolPolicySubject instances are equal
        /// </summary>
        /// <param name="input">Instance of LicensePoolPolicySubject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicensePoolPolicySubject input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SubjectType == input.SubjectType ||
                    (this.SubjectType != null &&
                    this.SubjectType.Equals(input.SubjectType))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SubjectType != null)
                    hashCode = hashCode * 59 + this.SubjectType.GetHashCode();
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
