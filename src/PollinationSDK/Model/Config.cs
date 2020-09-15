/* 
 * Pollination Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.8.8
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
    /// Operator configuration.  The config is used to schedule functions on a desktop or in other contexts (ie: Docker).
    /// </summary>
    [DataContract]
    public partial class Config :  IEquatable<Config>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Config" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Config() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Config" /> class.
        /// </summary>
        /// <param name="docker">The configuration to use this operator in a docker container (required).</param>
        /// <param name="local">The configuration to use this operator locally.</param>
        public Config
        (
           DockerConfig docker, // Required parameters
           Object local= default// Optional parameters
        )// BaseClass
        {
            // to ensure "docker" is required (not null)
            if (docker == null)
            {
                throw new InvalidDataException("docker is a required property for Config and cannot be null");
            }
            else
            {
                this.Docker = docker;
            }
            
            this.Local = local;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The configuration to use this operator in a docker container
        /// </summary>
        /// <value>The configuration to use this operator in a docker container</value>
        [DataMember(Name="docker", EmitDefaultValue=false)]
        [JsonProperty("docker")]
        public DockerConfig Docker { get; set; } 
        /// <summary>
        /// The configuration to use this operator locally
        /// </summary>
        /// <value>The configuration to use this operator locally</value>
        [DataMember(Name="local", EmitDefaultValue=false)]
        [JsonProperty("local")]
        public Object Local { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Config {\n");
            sb.Append("  Docker: ").Append(Docker).Append("\n");
            sb.Append("  Local: ").Append(Local).Append("\n");
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
        /// <returns>Config object</returns>
        public static Config FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Config>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Config object</returns>
        public Config DuplicateConfig()
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
            return this.Equals(input as Config);
        }

        /// <summary>
        /// Returns true if Config instances are equal
        /// </summary>
        /// <param name="input">Instance of Config to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Config input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Docker == input.Docker ||
                    (this.Docker != null &&
                    this.Docker.Equals(input.Docker))
                ) && 
                (
                    this.Local == input.Local ||
                    (this.Local != null &&
                    this.Local.Equals(input.Local))
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
                if (this.Docker != null)
                    hashCode = hashCode * 59 + this.Docker.GetHashCode();
                if (this.Local != null)
                    hashCode = hashCode * 59 + this.Local.GetHashCode();
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
