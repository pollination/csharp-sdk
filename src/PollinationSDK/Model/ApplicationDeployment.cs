/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.36.0
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
    /// ApplicationDeployment
    /// </summary>
    [DataContract]
    public partial class ApplicationDeployment :  IEquatable<ApplicationDeployment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationDeployment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationDeployment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationDeployment" /> class.
        /// </summary>
        /// <param name="author">The user who deployed this app (required).</param>
        /// <param name="ready">Indicates whether the application deployment is ready. (required).</param>
        /// <param name="url">The URL of the application deployment. (required).</param>
        /// <param name="version">The version deployed (required).</param>
        public ApplicationDeployment
        (
           AccountPublic author, bool ready, string url, ApplicationVersion version// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "author" is required (not null)
            if (author == null)
            {
                throw new InvalidDataException("author is a required property for ApplicationDeployment and cannot be null");
            }
            else
            {
                this.Author = author;
            }
            
            // to ensure "ready" is required (not null)
            if (ready == null)
            {
                throw new InvalidDataException("ready is a required property for ApplicationDeployment and cannot be null");
            }
            else
            {
                this.Ready = ready;
            }
            
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for ApplicationDeployment and cannot be null");
            }
            else
            {
                this.Url = url;
            }
            
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for ApplicationDeployment and cannot be null");
            }
            else
            {
                this.Version = version;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The user who deployed this app
        /// </summary>
        /// <value>The user who deployed this app</value>
        [DataMember(Name="author", EmitDefaultValue=false)]
        [JsonProperty("author")]
        public AccountPublic Author { get; set; } 
        /// <summary>
        /// Indicates whether the application deployment is ready.
        /// </summary>
        /// <value>Indicates whether the application deployment is ready.</value>
        [DataMember(Name="ready", EmitDefaultValue=false)]
        [JsonProperty("ready")]
        public bool Ready { get; set; } 
        /// <summary>
        /// The URL of the application deployment.
        /// </summary>
        /// <value>The URL of the application deployment.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        [JsonProperty("url")]
        public string Url { get; set; } 
        /// <summary>
        /// The version deployed
        /// </summary>
        /// <value>The version deployed</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        [JsonProperty("version")]
        public ApplicationVersion Version { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationDeployment {\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Ready: ").Append(Ready).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
        /// <returns>ApplicationDeployment object</returns>
        public static ApplicationDeployment FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ApplicationDeployment>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ApplicationDeployment object</returns>
        public ApplicationDeployment DuplicateApplicationDeployment()
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
            return this.Equals(input as ApplicationDeployment);
        }

        /// <summary>
        /// Returns true if ApplicationDeployment instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationDeployment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationDeployment input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.Ready == input.Ready ||
                    (this.Ready != null &&
                    this.Ready.Equals(input.Ready))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Ready != null)
                    hashCode = hashCode * 59 + this.Ready.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
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
