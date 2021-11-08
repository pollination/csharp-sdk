/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.18.1-beta.3
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
    /// A JSON array output.
    /// </summary>
    [DataContract]
    public partial class StepArrayOutput :  IEquatable<StepArrayOutput>, IValidatableObject
    {
        /// <summary>
        /// Type of items in this array. All the items in an array must be from the same type.
        /// </summary>
        /// <value>Type of items in this array. All the items in an array must be from the same type.</value>
        [DataMember(Name="items_type", EmitDefaultValue=false)]
        public ItemType? ItemsType { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="StepArrayOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StepArrayOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StepArrayOutput" /> class.
        /// </summary>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="description">Optional description for output..</param>
        /// <param name="itemsType">Type of items in this array. All the items in an array must be from the same type..</param>
        /// <param name="name">Output name. (required).</param>
        /// <param name="path">Path to the output file relative to where the function command is executed. (required).</param>
        /// <param name="required">A boolean to indicate if an artifact output is required. A False value makes the artifact optional. (default to true).</param>
        /// <param name="value">value (required).</param>
        public StepArrayOutput
        (
           string name, string path, List<object> value, // Required parameters
           Dictionary<string, string> annotations= default, string description= default, ItemType? itemsType= default, bool required = true // Optional parameters
        )// BaseClass
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for StepArrayOutput and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new InvalidDataException("path is a required property for StepArrayOutput and cannot be null");
            }
            else
            {
                this.Path = path;
            }
            
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for StepArrayOutput and cannot be null");
            }
            else
            {
                this.Value = value;
            }
            
            this.Annotations = annotations;
            this.Description = description;
            this.ItemsType = itemsType;
            // use default value if no "required" provided
            if (required == null)
            {
                this.Required =true;
            }
            else
            {
                this.Required = required;
            }

            // Set non-required readonly properties with defaultValue
            this.Type = "StepArrayOutput";
        }
        
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        [JsonProperty("annotations")]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// Optional description for output.
        /// </summary>
        /// <value>Optional description for output.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; } 
        /// <summary>
        /// Output name.
        /// </summary>
        /// <value>Output name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// Path to the output file relative to where the function command is executed.
        /// </summary>
        /// <value>Path to the output file relative to where the function command is executed.</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        [JsonProperty("path")]
        public string Path { get; set; } 
        /// <summary>
        /// A boolean to indicate if an artifact output is required. A False value makes the artifact optional.
        /// </summary>
        /// <value>A boolean to indicate if an artifact output is required. A False value makes the artifact optional.</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        [JsonProperty("required")]
        public bool Required { get; set; }  = true;
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        [JsonProperty("value")]
        public List<object> Value { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StepArrayOutput {\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ItemsType: ").Append(ItemsType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
        /// <returns>StepArrayOutput object</returns>
        public static StepArrayOutput FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<StepArrayOutput>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>StepArrayOutput object</returns>
        public StepArrayOutput DuplicateStepArrayOutput()
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
            return this.Equals(input as StepArrayOutput);
        }

        /// <summary>
        /// Returns true if StepArrayOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of StepArrayOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StepArrayOutput input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ItemsType == input.ItemsType ||
                    (this.ItemsType != null &&
                    this.ItemsType.Equals(input.ItemsType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
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
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ItemsType != null)
                    hashCode = hashCode * 59 + this.ItemsType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
            Regex regexType = new Regex(@"^StepArrayOutput$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
