/* 
 * Pollination Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.5.32
 * 
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
    /// ProjectPermissions
    /// </summary>
    [DataContract]
    public partial class ProjectPermissions :  IEquatable<ProjectPermissions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectPermissions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectPermissions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectPermissions" /> class.
        /// </summary>
        /// <param name="admin">admin (required).</param>
        /// <param name="contribute">contribute (required).</param>
        /// <param name="read">read (required).</param>
        public ProjectPermissions
        (
           bool admin, bool contribute, bool read// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "admin" is required (not null)
            if (admin == null)
            {
                throw new InvalidDataException("admin is a required property for ProjectPermissions and cannot be null");
            }
            else
            {
                this.Admin = admin;
            }
            
            // to ensure "contribute" is required (not null)
            if (contribute == null)
            {
                throw new InvalidDataException("contribute is a required property for ProjectPermissions and cannot be null");
            }
            else
            {
                this.Contribute = contribute;
            }
            
            // to ensure "read" is required (not null)
            if (read == null)
            {
                throw new InvalidDataException("read is a required property for ProjectPermissions and cannot be null");
            }
            else
            {
                this.Read = read;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Admin
        /// </summary>
        [DataMember(Name="admin", EmitDefaultValue=false)]
        [JsonProperty("admin")]
        public bool Admin { get; set; } 
        /// <summary>
        /// Gets or Sets Contribute
        /// </summary>
        [DataMember(Name="contribute", EmitDefaultValue=false)]
        [JsonProperty("contribute")]
        public bool Contribute { get; set; } 
        /// <summary>
        /// Gets or Sets Read
        /// </summary>
        [DataMember(Name="read", EmitDefaultValue=false)]
        [JsonProperty("read")]
        public bool Read { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectPermissions {\n");
            sb.Append("  Admin: ").Append(Admin).Append("\n");
            sb.Append("  Contribute: ").Append(Contribute).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
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
        /// <returns>ProjectPermissions object</returns>
        public static ProjectPermissions FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ProjectPermissions>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ProjectPermissions object</returns>
        public ProjectPermissions DuplicateProjectPermissions()
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
            return this.Equals(input as ProjectPermissions);
        }

        /// <summary>
        /// Returns true if ProjectPermissions instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectPermissions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectPermissions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Admin == input.Admin ||
                    (this.Admin != null &&
                    this.Admin.Equals(input.Admin))
                ) && 
                (
                    this.Contribute == input.Contribute ||
                    (this.Contribute != null &&
                    this.Contribute.Equals(input.Contribute))
                ) && 
                (
                    this.Read == input.Read ||
                    (this.Read != null &&
                    this.Read.Equals(input.Read))
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
                if (this.Admin != null)
                    hashCode = hashCode * 59 + this.Admin.GetHashCode();
                if (this.Contribute != null)
                    hashCode = hashCode * 59 + this.Contribute.GetHashCode();
                if (this.Read != null)
                    hashCode = hashCode * 59 + this.Read.GetHashCode();
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
