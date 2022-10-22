/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.31.0
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
    /// RepositoryUpdate
    /// </summary>
    [DataContract]
    public partial class RepositoryUpdate :  IEquatable<RepositoryUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryUpdate" /> class.
        /// </summary>
        /// <param name="description">A description of the repository.</param>
        /// <param name="icon">An icon to represent this repository.</param>
        /// <param name="keywords">A list of keywords to index the repository by.</param>
        /// <param name="_public">Whether or not a repository is publicly viewable.</param>
        public RepositoryUpdate
        (
           // Required parameters
           string description= default, string icon= default, List<string> keywords= default, bool _public= default// Optional parameters
        )// BaseClass
        {
            this.Description = description;
            this.Icon = icon;
            this.Keywords = keywords;
            this.Public = _public;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// A description of the repository
        /// </summary>
        /// <value>A description of the repository</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; } 
        /// <summary>
        /// An icon to represent this repository
        /// </summary>
        /// <value>An icon to represent this repository</value>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        [JsonProperty("icon")]
        public string Icon { get; set; } 
        /// <summary>
        /// A list of keywords to index the repository by
        /// </summary>
        /// <value>A list of keywords to index the repository by</value>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        [JsonProperty("keywords")]
        public List<string> Keywords { get; set; } 
        /// <summary>
        /// Whether or not a repository is publicly viewable
        /// </summary>
        /// <value>Whether or not a repository is publicly viewable</value>
        [DataMember(Name="public", EmitDefaultValue=false)]
        [JsonProperty("public")]
        public bool Public { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryUpdate {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
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
        /// <returns>RepositoryUpdate object</returns>
        public static RepositoryUpdate FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RepositoryUpdate>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RepositoryUpdate object</returns>
        public RepositoryUpdate DuplicateRepositoryUpdate()
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
            return this.Equals(input as RepositoryUpdate);
        }

        /// <summary>
        /// Returns true if RepositoryUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of RepositoryUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepositoryUpdate input)
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
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    input.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
                ) && 
                (
                    this.Public == input.Public ||
                    (this.Public != null &&
                    this.Public.Equals(input.Public))
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
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.Public != null)
                    hashCode = hashCode * 59 + this.Public.GetHashCode();
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
