/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: 0.9.2
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
    /// RepositoryPolicySubject
    /// </summary>
    [DataContract]
    public partial class RepositoryPolicySubject :  IEquatable<RepositoryPolicySubject>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public SubjectType Type { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryPolicySubject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RepositoryPolicySubject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryPolicySubject" /> class.
        /// </summary>
        /// <param name="name">The name of the policy subject (required).</param>
        /// <param name="type">type (required).</param>
        public RepositoryPolicySubject
        (
           string name, SubjectType type// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for RepositoryPolicySubject and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for RepositoryPolicySubject and cannot be null");
            }
            else
            {
                this.Type = type;
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
            sb.Append("class RepositoryPolicySubject {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
        /// <returns>RepositoryPolicySubject object</returns>
        public static RepositoryPolicySubject FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RepositoryPolicySubject>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RepositoryPolicySubject object</returns>
        public RepositoryPolicySubject DuplicateRepositoryPolicySubject()
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
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
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
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
            yield break;
        }
    }

}
