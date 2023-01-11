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
    /// A file or a folder input.
    /// </summary>
    [DataContract]
    public partial class StepPathInput :  IEquatable<StepPathInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StepPathInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StepPathInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StepPathInput" /> class.
        /// </summary>
        /// <param name="alias">A list of aliases for this input in different platforms..</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="_default">The default source for file if the value is not provided..</param>
        /// <param name="description">Optional description for input..</param>
        /// <param name="extensions">Optional list of extensions for file. The check for extension is case-insensitive..</param>
        /// <param name="name">Input name. (required).</param>
        /// <param name="path">Path to the target location that the input will be copied to.  This path is relative to the working directory where the command is executed..</param>
        /// <param name="required">A field to indicate if this input is required. This input needs to be set explicitly even when a default value is provided. (default to false).</param>
        /// <param name="source">The path to source the file from. (required).</param>
        /// <param name="spec">An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec..</param>
        public StepPathInput
        (
           string name, AnyOf<HTTP,S3,ProjectFolder> source, // Required parameters
           List<AnyOf<DAGGenericInputAlias,DAGStringInputAlias,DAGIntegerInputAlias,DAGNumberInputAlias,DAGBooleanInputAlias,DAGFolderInputAlias,DAGFileInputAlias,DAGPathInputAlias,DAGArrayInputAlias,DAGJSONObjectInputAlias,DAGLinkedInputAlias>> alias= default, Dictionary<string, string> annotations= default, AnyOf<HTTP,S3,ProjectFolder> _default= default, string description= default, List<string> extensions= default, string path= default, bool required = false, Object spec= default // Optional parameters
        )// BaseClass
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for StepPathInput and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new InvalidDataException("source is a required property for StepPathInput and cannot be null");
            }
            else
            {
                this.Source = source;
            }
            
            this.Alias = alias;
            this.Annotations = annotations;
            this.Default = _default;
            this.Description = description;
            this.Extensions = extensions;
            this.Path = path;
            // use default value if no "required" provided
            if (required == null)
            {
                this.Required =false;
            }
            else
            {
                this.Required = required;
            }
            this.Spec = spec;

            // Set non-required readonly properties with defaultValue
            this.Type = "StepPathInput";
        }
        
        /// <summary>
        /// A list of aliases for this input in different platforms.
        /// </summary>
        /// <value>A list of aliases for this input in different platforms.</value>
        [DataMember(Name="alias", EmitDefaultValue=false)]
        [JsonProperty("alias")]
        public List<AnyOf<DAGGenericInputAlias,DAGStringInputAlias,DAGIntegerInputAlias,DAGNumberInputAlias,DAGBooleanInputAlias,DAGFolderInputAlias,DAGFileInputAlias,DAGPathInputAlias,DAGArrayInputAlias,DAGJSONObjectInputAlias,DAGLinkedInputAlias>> Alias { get; set; } 
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        [JsonProperty("annotations")]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// The default source for file if the value is not provided.
        /// </summary>
        /// <value>The default source for file if the value is not provided.</value>
        [DataMember(Name="default", EmitDefaultValue=false)]
        [JsonProperty("default")]
        public AnyOf<HTTP,S3,ProjectFolder> Default { get; set; } 
        /// <summary>
        /// Optional description for input.
        /// </summary>
        /// <value>Optional description for input.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; } 
        /// <summary>
        /// Optional list of extensions for file. The check for extension is case-insensitive.
        /// </summary>
        /// <value>Optional list of extensions for file. The check for extension is case-insensitive.</value>
        [DataMember(Name="extensions", EmitDefaultValue=false)]
        [JsonProperty("extensions")]
        public List<string> Extensions { get; set; } 
        /// <summary>
        /// Input name.
        /// </summary>
        /// <value>Input name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// Path to the target location that the input will be copied to.  This path is relative to the working directory where the command is executed.
        /// </summary>
        /// <value>Path to the target location that the input will be copied to.  This path is relative to the working directory where the command is executed.</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        [JsonProperty("path")]
        public string Path { get; set; } 
        /// <summary>
        /// A field to indicate if this input is required. This input needs to be set explicitly even when a default value is provided.
        /// </summary>
        /// <value>A field to indicate if this input is required. This input needs to be set explicitly even when a default value is provided.</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        [JsonProperty("required")]
        public bool Required { get; set; }  = false;
        /// <summary>
        /// The path to source the file from.
        /// </summary>
        /// <value>The path to source the file from.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        [JsonProperty("source")]
        public AnyOf<HTTP,S3,ProjectFolder> Source { get; set; } 
        /// <summary>
        /// An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec.
        /// </summary>
        /// <value>An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec.</value>
        [DataMember(Name="spec", EmitDefaultValue=false)]
        [JsonProperty("spec")]
        public Object Spec { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StepPathInput {\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Extensions: ").Append(Extensions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Spec: ").Append(Spec).Append("\n");
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
        /// <returns>StepPathInput object</returns>
        public static StepPathInput FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<StepPathInput>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>StepPathInput object</returns>
        public StepPathInput DuplicateStepPathInput()
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
            return this.Equals(input as StepPathInput);
        }

        /// <summary>
        /// Returns true if StepPathInput instances are equal
        /// </summary>
        /// <param name="input">Instance of StepPathInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StepPathInput input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Alias == input.Alias ||
                    this.Alias != null &&
                    input.Alias != null &&
                    this.Alias.SequenceEqual(input.Alias)
                ) && 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && 
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
                    this.Extensions == input.Extensions ||
                    this.Extensions != null &&
                    input.Extensions != null &&
                    this.Extensions.SequenceEqual(input.Extensions)
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
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Spec == input.Spec ||
                    (this.Spec != null &&
                    this.Spec.Equals(input.Spec))
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
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Extensions != null)
                    hashCode = hashCode * 59 + this.Extensions.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Spec != null)
                    hashCode = hashCode * 59 + this.Spec.GetHashCode();
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
            Regex regexType = new Regex(@"^StepPathInput$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
