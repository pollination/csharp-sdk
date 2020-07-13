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
    /// A Function Artifact object  This indicates the path within the function context at which a certain file or folder (ie: artifact) can be found.
    /// </summary>
    [DataContract]
    public partial class FunctionParameterOut :  IEquatable<FunctionParameterOut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionParameterOut" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FunctionParameterOut() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionParameterOut" /> class.
        /// </summary>
        /// <param name="name">Name of the artifact. Must be unique within a task&#39;s inputs / outputs. (required).</param>
        /// <param name="description">Optional description for input parameter..</param>
        /// <param name="path">Path to the artifact relative to the working directory where the command is executed. (required).</param>
        public FunctionParameterOut
        (
           string name, string path, // Required parameters
           string description= default // Optional parameters
        )// BaseClass
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for FunctionParameterOut and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new InvalidDataException("path is a required property for FunctionParameterOut and cannot be null");
            }
            else
            {
                this.Path = path;
            }
            
            this.Description = description;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Name of the artifact. Must be unique within a task&#39;s inputs / outputs.
        /// </summary>
        /// <value>Name of the artifact. Must be unique within a task&#39;s inputs / outputs.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// Optional description for input parameter.
        /// </summary>
        /// <value>Optional description for input parameter.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; } 
        /// <summary>
        /// Path to the artifact relative to the working directory where the command is executed.
        /// </summary>
        /// <value>Path to the artifact relative to the working directory where the command is executed.</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        [JsonProperty("path")]
        public string Path { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FunctionParameterOut {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
        /// <returns>FunctionParameterOut object</returns>
        public static FunctionParameterOut FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<FunctionParameterOut>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>FunctionParameterOut object</returns>
        public FunctionParameterOut DuplicateFunctionParameterOut()
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
            return this.Equals(input as FunctionParameterOut);
        }

        /// <summary>
        /// Returns true if FunctionParameterOut instances are equal
        /// </summary>
        /// <param name="input">Instance of FunctionParameterOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FunctionParameterOut input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
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
