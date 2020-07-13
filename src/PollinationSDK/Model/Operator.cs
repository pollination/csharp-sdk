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
    /// A Queenbee Operator.  An Operator contains runtime configuration for a Command Line Interface (CLI) and a list of functions that can be executed using this CLI tool.
    /// </summary>
    [DataContract]
    public partial class Operator :  IEquatable<Operator>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Operator" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Operator() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Operator" /> class.
        /// </summary>
        /// <param name="metadata">The Operator metadata information (required).</param>
        /// <param name="config">The configuration information to run this operator (required).</param>
        /// <param name="functions">List of Operator functions (required).</param>
        public Operator
        (
           QueenbeeOperatorMetadataMetaData metadata, Config config, List<Function> functions// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new InvalidDataException("metadata is a required property for Operator and cannot be null");
            }
            else
            {
                this.Metadata = metadata;
            }
            
            // to ensure "config" is required (not null)
            if (config == null)
            {
                throw new InvalidDataException("config is a required property for Operator and cannot be null");
            }
            else
            {
                this.Config = config;
            }
            
            // to ensure "functions" is required (not null)
            if (functions == null)
            {
                throw new InvalidDataException("functions is a required property for Operator and cannot be null");
            }
            else
            {
                this.Functions = functions;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The Operator metadata information
        /// </summary>
        /// <value>The Operator metadata information</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        [JsonProperty("metadata")]
        public QueenbeeOperatorMetadataMetaData Metadata { get; set; } 
        /// <summary>
        /// The configuration information to run this operator
        /// </summary>
        /// <value>The configuration information to run this operator</value>
        [DataMember(Name="config", EmitDefaultValue=false)]
        [JsonProperty("config")]
        public Config Config { get; set; } 
        /// <summary>
        /// List of Operator functions
        /// </summary>
        /// <value>List of Operator functions</value>
        [DataMember(Name="functions", EmitDefaultValue=false)]
        [JsonProperty("functions")]
        public List<Function> Functions { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Operator {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Functions: ").Append(Functions).Append("\n");
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
        /// <returns>Operator object</returns>
        public static Operator FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Operator>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Operator object</returns>
        public Operator DuplicateOperator()
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
            return this.Equals(input as Operator);
        }

        /// <summary>
        /// Returns true if Operator instances are equal
        /// </summary>
        /// <param name="input">Instance of Operator to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Operator input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.Functions == input.Functions ||
                    this.Functions != null &&
                    input.Functions != null &&
                    this.Functions.SequenceEqual(input.Functions)
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
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.Functions != null)
                    hashCode = hashCode * 59 + this.Functions.GetHashCode();
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
