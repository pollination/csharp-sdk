/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
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


namespace PollinationSDK
{
    /// <summary>
    /// A JSON object input.  JSON objects are similar to Python dictionaries.  You can add additional validation by defining a JSONSchema specification.  See http://json-schema.org/understanding-json-schema/reference/object.html for more information.
    /// </summary>
    [DataContract(Name = "DAGJSONObjectInput")]
    public partial class DAGJSONObjectInput : GenericInput, IEquatable<DAGJSONObjectInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGJSONObjectInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DAGJSONObjectInput() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "DAGJSONObjectInput";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGJSONObjectInput" /> class.
        /// </summary>
        /// <param name="_default">Default value to use for an input if a value was not supplied..</param>
        /// <param name="alias">A list of aliases for this input in different platforms..</param>
        /// <param name="required">A field to indicate if this input is required. This input needs to be set explicitly even when a default value is provided. (default to false).</param>
        /// <param name="spec">An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec..</param>
        /// <param name="name">Input name. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="description">Optional description for input..</param>
        public DAGJSONObjectInput
        (
            string name, // Required parameters
            Dictionary<string, string> annotations= default, string description= default, Object _default= default, List<AnyOf<DAGGenericInputAlias,DAGStringInputAlias,DAGIntegerInputAlias,DAGNumberInputAlias,DAGBooleanInputAlias,DAGFolderInputAlias,DAGFileInputAlias,DAGPathInputAlias,DAGArrayInputAlias,DAGJSONObjectInputAlias,DAGLinkedInputAlias>> alias= default, bool required = false, Object spec= default // Optional parameters
        ) : base(name: name, annotations: annotations, description: description )// BaseClass
        {
            this.Default = _default;
            this.Alias = alias;
            this.Required = required;
            this.Spec = spec;

            // Set non-required readonly properties with defaultValue
            this.Type = "DAGJSONObjectInput";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "DAGJSONObjectInput";

        /// <summary>
        /// Default value to use for an input if a value was not supplied.
        /// </summary>
        /// <value>Default value to use for an input if a value was not supplied.</value>
        [DataMember(Name = "default")]
        public Object Default { get; set; } 
        /// <summary>
        /// A list of aliases for this input in different platforms.
        /// </summary>
        /// <value>A list of aliases for this input in different platforms.</value>
        [DataMember(Name = "alias")]
        public List<AnyOf<DAGGenericInputAlias,DAGStringInputAlias,DAGIntegerInputAlias,DAGNumberInputAlias,DAGBooleanInputAlias,DAGFolderInputAlias,DAGFileInputAlias,DAGPathInputAlias,DAGArrayInputAlias,DAGJSONObjectInputAlias,DAGLinkedInputAlias>> Alias { get; set; } 
        /// <summary>
        /// A field to indicate if this input is required. This input needs to be set explicitly even when a default value is provided.
        /// </summary>
        /// <value>A field to indicate if this input is required. This input needs to be set explicitly even when a default value is provided.</value>
        [DataMember(Name = "required")]
        public bool Required { get; set; }  = false;
        /// <summary>
        /// An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec.
        /// </summary>
        /// <value>An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec.</value>
        [DataMember(Name = "spec")]
        public Object Spec { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DAGJSONObjectInput";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("DAGJSONObjectInput:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Annotations: ").Append(this.Annotations).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  Default: ").Append(this.Default).Append("\n");
            sb.Append("  Alias: ").Append(this.Alias).Append("\n");
            sb.Append("  Required: ").Append(this.Required).Append("\n");
            sb.Append("  Spec: ").Append(this.Spec).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DAGJSONObjectInput object</returns>
        public static DAGJSONObjectInput FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAGJSONObjectInput>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAGJSONObjectInput object</returns>
        public virtual DAGJSONObjectInput DuplicateDAGJSONObjectInput()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDAGJSONObjectInput();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override GenericInput DuplicateGenericInput()
        {
            return DuplicateDAGJSONObjectInput();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as DAGJSONObjectInput);
        }

        /// <summary>
        /// Returns true if DAGJSONObjectInput instances are equal
        /// </summary>
        /// <param name="input">Instance of DAGJSONObjectInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAGJSONObjectInput input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Default, input.Default) && 
                (
                    this.Alias == input.Alias ||
                    Extension.AllEquals(this.Alias, input.Alias)
                ) && 
                    Extension.Equals(this.Required, input.Required) && 
                    Extension.Equals(this.Spec, input.Spec) && 
                    Extension.Equals(this.Type, input.Type);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^DAGJSONObjectInput$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
