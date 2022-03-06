/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.27.0
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
    /// Accessor
    /// </summary>
    [DataContract]
    public partial class Accessor :  IEquatable<Accessor>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [DataMember(Name="permission", EmitDefaultValue=false)]
        public Permission Permission { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="Accessor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Accessor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Accessor" /> class.
        /// </summary>
        /// <param name="permission">permission (required).</param>
        /// <param name="subject">subject (required).</param>
        public Accessor
        (
           Permission permission, AnyOf<AccountPublic,Team> subject// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "permission" is required (not null)
            if (permission == null)
            {
                throw new InvalidDataException("permission is a required property for Accessor and cannot be null");
            }
            else
            {
                this.Permission = permission;
            }
            
            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new InvalidDataException("subject is a required property for Accessor and cannot be null");
            }
            else
            {
                this.Subject = subject;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        [JsonProperty("subject")]
        public AnyOf<AccountPublic,Team> Subject { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Accessor {\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
        /// <returns>Accessor object</returns>
        public static Accessor FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Accessor>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Accessor object</returns>
        public Accessor DuplicateAccessor()
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
            return 
                (
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
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
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
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
