/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: 0.9.6
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
    /// A workflow Artifact Argument
    /// </summary>
    [DataContract]
    public partial class SimulationInputArtifact :  IEquatable<SimulationInputArtifact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationInputArtifact" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SimulationInputArtifact() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationInputArtifact" /> class.
        /// </summary>
        /// <param name="name">The name of the artifact (required).</param>
        /// <param name="source">The source to pull the artifact from (required).</param>
        public SimulationInputArtifact
        (
           string name, AnyOf<HTTPSource,S3Source,ProjectFolderSource,SimulationOutputSource> source// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for SimulationInputArtifact and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new InvalidDataException("source is a required property for SimulationInputArtifact and cannot be null");
            }
            else
            {
                this.Source = source;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The name of the artifact
        /// </summary>
        /// <value>The name of the artifact</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// The source to pull the artifact from
        /// </summary>
        /// <value>The source to pull the artifact from</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        [JsonProperty("source")]
        public AnyOf<HTTPSource,S3Source,ProjectFolderSource,SimulationOutputSource> Source { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimulationInputArtifact {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
        /// <returns>SimulationInputArtifact object</returns>
        public static SimulationInputArtifact FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SimulationInputArtifact>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SimulationInputArtifact object</returns>
        public SimulationInputArtifact DuplicateSimulationInputArtifact()
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
            return this.Equals(input as SimulationInputArtifact);
        }

        /// <summary>
        /// Returns true if SimulationInputArtifact instances are equal
        /// </summary>
        /// <param name="input">Instance of SimulationInputArtifact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimulationInputArtifact input)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
