/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: v0.9.0
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
    /// SimulationOutputSource  An artifact pulled from the outputs of another simulation
    /// </summary>
    [DataContract]
    public partial class SimulationOutputSource :  IEquatable<SimulationOutputSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOutputSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SimulationOutputSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOutputSource" /> class.
        /// </summary>
        /// <param name="output">Simulation output artifact name.</param>
        /// <param name="path">The path within the simulation outputs folder to a specified artifact.</param>
        /// <param name="simulation">Simulation ID (required).</param>
        /// <param name="type">type (default to &quot;simulation&quot;).</param>
        public SimulationOutputSource
        (
           string simulation, // Required parameters
           string output= default, string path= default, string type = "simulation"// Optional parameters
        )// BaseClass
        {
            // to ensure "simulation" is required (not null)
            if (simulation == null)
            {
                throw new InvalidDataException("simulation is a required property for SimulationOutputSource and cannot be null");
            }
            else
            {
                this.Simulation = simulation;
            }
            
            this.Output = output;
            this.Path = path;
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type ="simulation";
            }
            else
            {
                this.Type = type;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Simulation output artifact name
        /// </summary>
        /// <value>Simulation output artifact name</value>
        [DataMember(Name="output", EmitDefaultValue=false)]
        [JsonProperty("output")]
        public string Output { get; set; } 
        /// <summary>
        /// The path within the simulation outputs folder to a specified artifact
        /// </summary>
        /// <value>The path within the simulation outputs folder to a specified artifact</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        [JsonProperty("path")]
        public string Path { get; set; } 
        /// <summary>
        /// Simulation ID
        /// </summary>
        /// <value>Simulation ID</value>
        [DataMember(Name="simulation", EmitDefaultValue=false)]
        [JsonProperty("simulation")]
        public string Simulation { get; set; } 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }  = "simulation";
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimulationOutputSource {\n");
            sb.Append("  Output: ").Append(Output).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Simulation: ").Append(Simulation).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
        /// <returns>SimulationOutputSource object</returns>
        public static SimulationOutputSource FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SimulationOutputSource>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SimulationOutputSource object</returns>
        public SimulationOutputSource DuplicateSimulationOutputSource()
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
            return this.Equals(input as SimulationOutputSource);
        }

        /// <summary>
        /// Returns true if SimulationOutputSource instances are equal
        /// </summary>
        /// <param name="input">Instance of SimulationOutputSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimulationOutputSource input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Output == input.Output ||
                    (this.Output != null &&
                    this.Output.Equals(input.Output))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Simulation == input.Simulation ||
                    (this.Simulation != null &&
                    this.Simulation.Equals(input.Simulation))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Output != null)
                    hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Simulation != null)
                    hashCode = hashCode * 59 + this.Simulation.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            // Type (string) pattern
            Regex regexType = new Regex(@"^simulation$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
