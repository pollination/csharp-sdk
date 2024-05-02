/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * Contact: info@pollination.cloud
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

extern alias LBTNewtonsoft;  extern alias LBTRestSharp; using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using LBTNewtonsoft::Newtonsoft.Json;
using LBTNewtonsoft::Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace PollinationSDK
{
    /// <summary>
    /// Function boolean output.  This output loads the content from a file as a boolean.
    /// </summary>
    [DataContract(Name = "FunctionBooleanOutput")]
    public partial class FunctionBooleanOutput : FunctionStringOutput, IEquatable<FunctionBooleanOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionBooleanOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FunctionBooleanOutput() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "FunctionBooleanOutput";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionBooleanOutput" /> class.
        /// </summary>
        /// <param name="name">Output name. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="description">Optional description for output..</param>
        /// <param name="path">Path to the output artifact relative to where the function command is executed. (required).</param>
        /// <param name="required">A boolean to indicate if an artifact output is required. A False value makes the artifact optional. (default to true).</param>
        public FunctionBooleanOutput
        (
            string name, string path, // Required parameters
            Dictionary<string, string> annotations= default, string description= default, bool required = true // Optional parameters
        ) : base(name: name, annotations: annotations, description: description, path: path, required: required )// BaseClass
        {

            // Set non-required readonly properties with defaultValue
            this.Type = "FunctionBooleanOutput";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "FunctionBooleanOutput";


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "FunctionBooleanOutput";
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
            sb.Append("FunctionBooleanOutput:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Annotations: ").Append(this.Annotations).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  Path: ").Append(this.Path).Append("\n");
            sb.Append("  Required: ").Append(this.Required).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>FunctionBooleanOutput object</returns>
        public static FunctionBooleanOutput FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<FunctionBooleanOutput>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>FunctionBooleanOutput object</returns>
        public virtual FunctionBooleanOutput DuplicateFunctionBooleanOutput()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateFunctionBooleanOutput();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override FunctionStringOutput DuplicateFunctionStringOutput()
        {
            return DuplicateFunctionBooleanOutput();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as FunctionBooleanOutput);
        }

        /// <summary>
        /// Returns true if FunctionBooleanOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of FunctionBooleanOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FunctionBooleanOutput input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^FunctionBooleanOutput$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
