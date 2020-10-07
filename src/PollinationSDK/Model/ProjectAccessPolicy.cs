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


namespace PollinationSDK.Model
{
    /// <summary>
    /// ProjectAccessPolicy
    /// </summary>
    [DataContract]
    public partial class ProjectAccessPolicy :  IEquatable<ProjectAccessPolicy>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [DataMember(Name="permission", EmitDefaultValue=false)]
        public Permission Permission { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAccessPolicy" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectAccessPolicy() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAccessPolicy" /> class.
        /// </summary>
        /// <param name="subject">The subject of the access policy (required).</param>
        /// <param name="permission">permission (required).</param>
        public ProjectAccessPolicy
        (
           PolicySubject subject, Permission permission// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new InvalidDataException("subject is a required property for ProjectAccessPolicy and cannot be null");
            }
            else
            {
                this.Subject = subject;
            }
            
            // to ensure "permission" is required (not null)
            if (permission == null)
            {
                throw new InvalidDataException("permission is a required property for ProjectAccessPolicy and cannot be null");
            }
            else
            {
                this.Permission = permission;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The subject of the access policy
        /// </summary>
        /// <value>The subject of the access policy</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        [JsonProperty("subject")]
        public PolicySubject Subject { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectAccessPolicy {\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
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
        /// <returns>ProjectAccessPolicy object</returns>
        public static ProjectAccessPolicy FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ProjectAccessPolicy>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ProjectAccessPolicy object</returns>
        public ProjectAccessPolicy DuplicateProjectAccessPolicy()
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
            return this.Equals(input as ProjectAccessPolicy);
        }

        /// <summary>
        /// Returns true if ProjectAccessPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectAccessPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectAccessPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
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
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
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