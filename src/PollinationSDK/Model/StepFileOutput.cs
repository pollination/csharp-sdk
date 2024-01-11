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
    /// A file output.
    /// </summary>
    [DataContract(Name = "StepFileOutput")]
    public partial class StepFileOutput : FunctionFileOutput, IEquatable<StepFileOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StepFileOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StepFileOutput() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "StepFileOutput";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="StepFileOutput" /> class.
        /// </summary>
        /// <param name="source">The path to source the file from. (required).</param>
        /// <param name="name">Output name. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="description">Optional description for output..</param>
        /// <param name="path">Path to the output artifact relative to where the function command is executed. (required).</param>
        /// <param name="required">A boolean to indicate if an artifact output is required. A False value makes the artifact optional. (default to true).</param>
        public StepFileOutput
        (
            string name, string path, AnyOf<HTTP,S3,ProjectFolder> source, // Required parameters
            Dictionary<string, string> annotations= default, string description= default, bool required = true // Optional parameters
        ) : base(name: name, annotations: annotations, description: description, path: path, required: required )// BaseClass
        {
            // to ensure "source" is required (not null)
            this.Source = source ?? throw new ArgumentNullException("source is a required property for StepFileOutput and cannot be null");

            // Set non-required readonly properties with defaultValue
            this.Type = "StepFileOutput";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "StepFileOutput";

        /// <summary>
        /// The path to source the file from.
        /// </summary>
        /// <value>The path to source the file from.</value>
        [DataMember(Name = "source", IsRequired = true)]
        public AnyOf<HTTP,S3,ProjectFolder> Source { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "StepFileOutput";
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
            sb.Append("StepFileOutput:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Annotations: ").Append(this.Annotations).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  Path: ").Append(this.Path).Append("\n");
            sb.Append("  Required: ").Append(this.Required).Append("\n");
            sb.Append("  Source: ").Append(this.Source).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>StepFileOutput object</returns>
        public static StepFileOutput FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<StepFileOutput>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>StepFileOutput object</returns>
        public virtual StepFileOutput DuplicateStepFileOutput()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateStepFileOutput();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override FunctionFileOutput DuplicateFunctionFileOutput()
        {
            return DuplicateStepFileOutput();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as StepFileOutput);
        }

        /// <summary>
        /// Returns true if StepFileOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of StepFileOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StepFileOutput input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Source, input.Source) && 
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
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
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
            Regex regexType = new Regex(@"^StepFileOutput$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
