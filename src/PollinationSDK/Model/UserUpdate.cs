/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.18.0-beta.4
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
    /// UserUpdate
    /// </summary>
    [DataContract]
    public partial class UserUpdate :  IEquatable<UserUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUpdate" /> class.
        /// </summary>
        /// <param name="description">A description of the user (default to &quot;&quot;).</param>
        /// <param name="name">The display name for this user (required).</param>
        /// <param name="pictureUrl">URL to the picture associated with this user (required).</param>
        public UserUpdate
        (
           string name, string pictureUrl, // Required parameters
           string description = "" // Optional parameters
        )// BaseClass
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for UserUpdate and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "pictureUrl" is required (not null)
            if (pictureUrl == null)
            {
                throw new InvalidDataException("pictureUrl is a required property for UserUpdate and cannot be null");
            }
            else
            {
                this.PictureUrl = pictureUrl;
            }
            
            // use default value if no "description" provided
            if (description == null)
            {
                this.Description ="";
            }
            else
            {
                this.Description = description;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// A description of the user
        /// </summary>
        /// <value>A description of the user</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; }  = "";
        /// <summary>
        /// The display name for this user
        /// </summary>
        /// <value>The display name for this user</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// URL to the picture associated with this user
        /// </summary>
        /// <value>URL to the picture associated with this user</value>
        [DataMember(Name="picture_url", EmitDefaultValue=false)]
        [JsonProperty("picture_url")]
        public string PictureUrl { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserUpdate {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PictureUrl: ").Append(PictureUrl).Append("\n");
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
        /// <returns>UserUpdate object</returns>
        public static UserUpdate FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<UserUpdate>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>UserUpdate object</returns>
        public UserUpdate DuplicateUserUpdate()
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
            return this.Equals(input as UserUpdate);
        }

        /// <summary>
        /// Returns true if UserUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of UserUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserUpdate input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PictureUrl == input.PictureUrl ||
                    (this.PictureUrl != null &&
                    this.PictureUrl.Equals(input.PictureUrl))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PictureUrl != null)
                    hashCode = hashCode * 59 + this.PictureUrl.GetHashCode();
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
