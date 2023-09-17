/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.44.0
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
    /// UserPermission
    /// </summary>
    [DataContract]
    public partial class UserPermission :  IEquatable<UserPermission>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPermission" /> class.
        /// </summary>
        /// <param name="admin">The user has admin permission to this resource (default to false).</param>
        /// <param name="read">The user has read permission on this resource (default to false).</param>
        /// <param name="write">The user has write permission on this resource (default to false).</param>
        public UserPermission
        (
           // Required parameters
           bool admin = false, bool read = false, bool write = false// Optional parameters
        )// BaseClass
        {
            // use default value if no "admin" provided
            if (admin == null)
            {
                this.Admin =false;
            }
            else
            {
                this.Admin = admin;
            }
            // use default value if no "read" provided
            if (read == null)
            {
                this.Read =false;
            }
            else
            {
                this.Read = read;
            }
            // use default value if no "write" provided
            if (write == null)
            {
                this.Write =false;
            }
            else
            {
                this.Write = write;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The user has admin permission to this resource
        /// </summary>
        /// <value>The user has admin permission to this resource</value>
        [DataMember(Name="admin", EmitDefaultValue=false)]
        [JsonProperty("admin")]
        public bool Admin { get; set; }  = false;
        /// <summary>
        /// The user has read permission on this resource
        /// </summary>
        /// <value>The user has read permission on this resource</value>
        [DataMember(Name="read", EmitDefaultValue=false)]
        [JsonProperty("read")]
        public bool Read { get; set; }  = false;
        /// <summary>
        /// The user has write permission on this resource
        /// </summary>
        /// <value>The user has write permission on this resource</value>
        [DataMember(Name="write", EmitDefaultValue=false)]
        [JsonProperty("write")]
        public bool Write { get; set; }  = false;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserPermission {\n");
            sb.Append("  Admin: ").Append(Admin).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  Write: ").Append(Write).Append("\n");
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
        /// <returns>UserPermission object</returns>
        public static UserPermission FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<UserPermission>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>UserPermission object</returns>
        public UserPermission DuplicateUserPermission()
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
            return 
                (
                    this.Admin == input.Admin ||
                    (this.Admin != null &&
                    this.Admin.Equals(input.Admin))
                ) && 
                (
                    this.Read == input.Read ||
                    (this.Read != null &&
                    this.Read.Equals(input.Read))
                ) && 
                (
                    this.Write == input.Write ||
                    (this.Write != null &&
                    this.Write.Equals(input.Write))
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
                if (this.Read != null)
                    hashCode = hashCode * 59 + this.Read.GetHashCode();
                if (this.Write != null)
                    hashCode = hashCode * 59 + this.Write.GetHashCode();
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
