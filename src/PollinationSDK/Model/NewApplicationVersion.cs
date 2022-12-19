/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.34.0
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
    /// NewApplicationVersion
    /// </summary>
    [DataContract]
    public partial class NewApplicationVersion :  IEquatable<NewApplicationVersion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewApplicationVersion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewApplicationVersion() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewApplicationVersion" /> class.
        /// </summary>
        /// <param name="releaseNotes">Some useful release notes so users know what has changed in this version (default to &quot;&quot;).</param>
        /// <param name="tag">The tag for this new version of the application (required).</param>
        public NewApplicationVersion
        (
           string tag, // Required parameters
           string releaseNotes = "" // Optional parameters
        )// BaseClass
        {
            // to ensure "tag" is required (not null)
            if (tag == null)
            {
                throw new InvalidDataException("tag is a required property for NewApplicationVersion and cannot be null");
            }
            else
            {
                this.Tag = tag;
            }
            
            // use default value if no "releaseNotes" provided
            if (releaseNotes == null)
            {
                this.ReleaseNotes ="";
            }
            else
            {
                this.ReleaseNotes = releaseNotes;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Some useful release notes so users know what has changed in this version
        /// </summary>
        /// <value>Some useful release notes so users know what has changed in this version</value>
        [DataMember(Name="release_notes", EmitDefaultValue=false)]
        [JsonProperty("release_notes")]
        public string ReleaseNotes { get; set; }  = "";
        /// <summary>
        /// The tag for this new version of the application
        /// </summary>
        /// <value>The tag for this new version of the application</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        [JsonProperty("tag")]
        public string Tag { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewApplicationVersion {\n");
            sb.Append("  ReleaseNotes: ").Append(ReleaseNotes).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
        /// <returns>NewApplicationVersion object</returns>
        public static NewApplicationVersion FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<NewApplicationVersion>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>NewApplicationVersion object</returns>
        public NewApplicationVersion DuplicateNewApplicationVersion()
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
            return this.Equals(input as NewApplicationVersion);
        }

        /// <summary>
        /// Returns true if NewApplicationVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of NewApplicationVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewApplicationVersion input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.ReleaseNotes == input.ReleaseNotes ||
                    (this.ReleaseNotes != null &&
                    this.ReleaseNotes.Equals(input.ReleaseNotes))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
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
                if (this.ReleaseNotes != null)
                    hashCode = hashCode * 59 + this.ReleaseNotes.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
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
