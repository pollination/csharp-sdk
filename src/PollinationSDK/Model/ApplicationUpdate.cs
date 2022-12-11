/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.33.0
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
    /// ApplicationUpdate
    /// </summary>
    [DataContract]
    public partial class ApplicationUpdate :  IEquatable<ApplicationUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUpdate" /> class.
        /// </summary>
        /// <param name="deploymentConfig">The deployment configuration for the application.</param>
        /// <param name="description">A description of the application.</param>
        /// <param name="isPaid">Whether or not the application is paid.</param>
        /// <param name="keywords">A list of keywords associated with the application.</param>
        /// <param name="license">The license of the application.</param>
        /// <param name="_public">Whether or not a application is publicly viewable.</param>
        /// <param name="source">A link to the source code of the application.</param>
        public ApplicationUpdate
        (
           // Required parameters
           DeploymentConfig deploymentConfig= default, string description= default, bool isPaid= default, List<string> keywords= default, string license= default, bool _public= default, string source= default// Optional parameters
        )// BaseClass
        {
            this.DeploymentConfig = deploymentConfig;
            this.Description = description;
            this.IsPaid = isPaid;
            this.Keywords = keywords;
            this.License = license;
            this.Public = _public;
            this.Source = source;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The deployment configuration for the application
        /// </summary>
        /// <value>The deployment configuration for the application</value>
        [DataMember(Name="deployment_config", EmitDefaultValue=false)]
        [JsonProperty("deployment_config")]
        public DeploymentConfig DeploymentConfig { get; set; } 
        /// <summary>
        /// A description of the application
        /// </summary>
        /// <value>A description of the application</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; } 
        /// <summary>
        /// Whether or not the application is paid
        /// </summary>
        /// <value>Whether or not the application is paid</value>
        [DataMember(Name="is_paid", EmitDefaultValue=false)]
        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; } 
        /// <summary>
        /// A list of keywords associated with the application
        /// </summary>
        /// <value>A list of keywords associated with the application</value>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        [JsonProperty("keywords")]
        public List<string> Keywords { get; set; } 
        /// <summary>
        /// The license of the application
        /// </summary>
        /// <value>The license of the application</value>
        [DataMember(Name="license", EmitDefaultValue=false)]
        [JsonProperty("license")]
        public string License { get; set; } 
        /// <summary>
        /// Whether or not a application is publicly viewable
        /// </summary>
        /// <value>Whether or not a application is publicly viewable</value>
        [DataMember(Name="public", EmitDefaultValue=false)]
        [JsonProperty("public")]
        public bool Public { get; set; } 
        /// <summary>
        /// A link to the source code of the application
        /// </summary>
        /// <value>A link to the source code of the application</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        [JsonProperty("source")]
        public string Source { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationUpdate {\n");
            sb.Append("  DeploymentConfig: ").Append(DeploymentConfig).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsPaid: ").Append(IsPaid).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  License: ").Append(License).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
        /// <returns>ApplicationUpdate object</returns>
        public static ApplicationUpdate FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ApplicationUpdate>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ApplicationUpdate object</returns>
        public ApplicationUpdate DuplicateApplicationUpdate()
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
            return this.Equals(input as ApplicationUpdate);
        }

        /// <summary>
        /// Returns true if ApplicationUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationUpdate input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.DeploymentConfig == input.DeploymentConfig ||
                    (this.DeploymentConfig != null &&
                    this.DeploymentConfig.Equals(input.DeploymentConfig))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsPaid == input.IsPaid ||
                    (this.IsPaid != null &&
                    this.IsPaid.Equals(input.IsPaid))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    input.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
                ) && 
                (
                    this.License == input.License ||
                    (this.License != null &&
                    this.License.Equals(input.License))
                ) && 
                (
                    this.Public == input.Public ||
                    (this.Public != null &&
                    this.Public.Equals(input.Public))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.DeploymentConfig != null)
                    hashCode = hashCode * 59 + this.DeploymentConfig.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsPaid != null)
                    hashCode = hashCode * 59 + this.IsPaid.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.License != null)
                    hashCode = hashCode * 59 + this.License.GetHashCode();
                if (this.Public != null)
                    hashCode = hashCode * 59 + this.Public.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
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
