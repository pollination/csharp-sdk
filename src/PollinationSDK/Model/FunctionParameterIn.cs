/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: v0.9.1
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
    /// A Function Parameter  Parameter indicate a passed string parameter to a service template with an optional default value.
    /// </summary>
    [DataContract]
    public partial class FunctionParameterIn :  IEquatable<FunctionParameterIn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionParameterIn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FunctionParameterIn() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionParameterIn" /> class.
        /// </summary>
        /// <param name="_default">Default value to use for an input parameter if a value was not supplied..</param>
        /// <param name="description">Optional description for input parameter..</param>
        /// <param name="name">Name is the parameter name. must be unique within a task&#39;s inputs. (required).</param>
        /// <param name="required">Whether this value must be specified in a task argument..</param>
        public FunctionParameterIn
        (
           string name, // Required parameters
           string _default= default, string description= default, bool required= default// Optional parameters
        )// BaseClass
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for FunctionParameterIn and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            this.Default = _default;
            this.Description = description;
            this.Required = required;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Default value to use for an input parameter if a value was not supplied.
        /// </summary>
        /// <value>Default value to use for an input parameter if a value was not supplied.</value>
        [DataMember(Name="default", EmitDefaultValue=false)]
        [JsonProperty("default")]
        public string Default { get; set; } 
        /// <summary>
        /// Optional description for input parameter.
        /// </summary>
        /// <value>Optional description for input parameter.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; } 
        /// <summary>
        /// Name is the parameter name. must be unique within a task&#39;s inputs.
        /// </summary>
        /// <value>Name is the parameter name. must be unique within a task&#39;s inputs.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// Whether this value must be specified in a task argument.
        /// </summary>
        /// <value>Whether this value must be specified in a task argument.</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        [JsonProperty("required")]
        public bool Required { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FunctionParameterIn {\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
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
        /// <returns>FunctionParameterIn object</returns>
        public static FunctionParameterIn FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<FunctionParameterIn>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>FunctionParameterIn object</returns>
        public FunctionParameterIn DuplicateFunctionParameterIn()
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
            return this.Equals(input as FunctionParameterIn);
        }

        /// <summary>
        /// Returns true if FunctionParameterIn instances are equal
        /// </summary>
        /// <param name="input">Instance of FunctionParameterIn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FunctionParameterIn input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && 
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
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
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
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
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
