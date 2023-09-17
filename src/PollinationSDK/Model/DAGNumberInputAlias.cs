/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.44.0
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
    /// An alias number input.  You can add additional validation by defining a JSONSchema specification.  See http://json-schema.org/understanding-json-schema/reference/numeric.html#numeric for more information.
    /// </summary>
    [DataContract]
    public partial class DAGNumberInputAlias :  IEquatable<DAGNumberInputAlias>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGNumberInputAlias" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DAGNumberInputAlias() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGNumberInputAlias" /> class.
        /// </summary>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="_default">Default value to use for an input if a value was not supplied..</param>
        /// <param name="description">Optional description for input..</param>
        /// <param name="handler">List of process actions to process the input or output value. (required).</param>
        /// <param name="name">Input name. (required).</param>
        /// <param name="platform">Name of the client platform (e.g. Grasshopper, Revit, etc). The value can be any strings as long as it has been agreed between client-side developer and author of the recipe. (required).</param>
        /// <param name="required">A field to indicate if this input is required. This input needs to be set explicitly even when a default value is provided. (default to false).</param>
        /// <param name="spec">An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec..</param>
        public DAGNumberInputAlias
        (
           List<IOAliasHandler> handler, string name, List<string> platform, // Required parameters
           Dictionary<string, string> annotations= default, double _default= default, string description= default, bool required = false, Object spec= default // Optional parameters
        )// BaseClass
        {
            // to ensure "handler" is required (not null)
            if (handler == null)
            {
                throw new InvalidDataException("handler is a required property for DAGNumberInputAlias and cannot be null");
            }
            else
            {
                this.Handler = handler;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for DAGNumberInputAlias and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "platform" is required (not null)
            if (platform == null)
            {
                throw new InvalidDataException("platform is a required property for DAGNumberInputAlias and cannot be null");
            }
            else
            {
                this.Platform = platform;
            }
            
            this.Annotations = annotations;
            this.Default = _default;
            this.Description = description;
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
            this.Type = "DAGNumberInputAlias";
        }
        
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        [JsonProperty("annotations")]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// Default value to use for an input if a value was not supplied.
        /// </summary>
        /// <value>Default value to use for an input if a value was not supplied.</value>
        [DataMember(Name="default", EmitDefaultValue=false)]
        [JsonProperty("default")]
        public double Default { get; set; } 
        /// <summary>
        /// Optional description for input.
        /// </summary>
        /// <value>Optional description for input.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; } 
        /// <summary>
        /// List of process actions to process the input or output value.
        /// </summary>
        /// <value>List of process actions to process the input or output value.</value>
        [DataMember(Name="handler", EmitDefaultValue=false)]
        [JsonProperty("handler")]
        public List<IOAliasHandler> Handler { get; set; } 
        /// <summary>
        /// Input name.
        /// </summary>
        /// <value>Input name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// Name of the client platform (e.g. Grasshopper, Revit, etc). The value can be any strings as long as it has been agreed between client-side developer and author of the recipe.
        /// </summary>
        /// <value>Name of the client platform (e.g. Grasshopper, Revit, etc). The value can be any strings as long as it has been agreed between client-side developer and author of the recipe.</value>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        [JsonProperty("platform")]
        public List<string> Platform { get; set; } 
        /// <summary>
        /// A field to indicate if this input is required. This input needs to be set explicitly even when a default value is provided.
        /// </summary>
        /// <value>A field to indicate if this input is required. This input needs to be set explicitly even when a default value is provided.</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        [JsonProperty("required")]
        public bool Required { get; set; }  = false;
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
            sb.Append("class DAGNumberInputAlias {\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Handler: ").Append(Handler).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
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
        /// <returns>DAGNumberInputAlias object</returns>
        public static DAGNumberInputAlias FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAGNumberInputAlias>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAGNumberInputAlias object</returns>
        public DAGNumberInputAlias DuplicateDAGNumberInputAlias()
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
            return this.Equals(input as DAGNumberInputAlias);
        }

        /// <summary>
        /// Returns true if DAGNumberInputAlias instances are equal
        /// </summary>
        /// <param name="input">Instance of DAGNumberInputAlias to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAGNumberInputAlias input)
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
                    this.Handler == input.Handler ||
                    this.Handler != null &&
                    input.Handler != null &&
                    this.Handler.SequenceEqual(input.Handler)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Platform == input.Platform ||
                    this.Platform != null &&
                    input.Platform != null &&
                    this.Platform.SequenceEqual(input.Platform)
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
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
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Handler != null)
                    hashCode = hashCode * 59 + this.Handler.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
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
            Regex regexType = new Regex(@"^DAGNumberInputAlias$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
