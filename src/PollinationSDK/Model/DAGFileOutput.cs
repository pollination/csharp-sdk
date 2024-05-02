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
    /// DAG file output.
    /// </summary>
    [DataContract(Name = "DAGFileOutput")]
    public partial class DAGFileOutput : GenericOutput, IEquatable<DAGFileOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGFileOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DAGFileOutput() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "DAGFileOutput";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGFileOutput" /> class.
        /// </summary>
        /// <param name="from">Reference to a file or a task output. Task output must be file. (required).</param>
        /// <param name="alias">A list of additional processes for loading this output on different platforms..</param>
        /// <param name="required">A boolean to indicate if an artifact output is required. A False value makes the artifact optional. (default to true).</param>
        /// <param name="name">Output name. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="description">Optional description for output..</param>
        public DAGFileOutput
        (
            string name, AnyOf<TaskReference,FileReference> from, // Required parameters
            Dictionary<string, string> annotations= default, string description= default, List<AnyOf<DAGGenericOutputAlias,DAGStringOutputAlias,DAGIntegerOutputAlias,DAGNumberOutputAlias,DAGBooleanOutputAlias,DAGFolderOutputAlias,DAGFileOutputAlias,DAGPathOutputAlias,DAGArrayOutputAlias,DAGJSONObjectOutputAlias,DAGLinkedOutputAlias>> alias= default, bool required = true // Optional parameters
        ) : base(name: name, annotations: annotations, description: description )// BaseClass
        {
            // to ensure "from" is required (not null)
            this.From = from ?? throw new ArgumentNullException("from is a required property for DAGFileOutput and cannot be null");
            this.Alias = alias;
            this.Required = required;

            // Set non-required readonly properties with defaultValue
            this.Type = "DAGFileOutput";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "DAGFileOutput";

        /// <summary>
        /// Reference to a file or a task output. Task output must be file.
        /// </summary>
        /// <value>Reference to a file or a task output. Task output must be file.</value>
        [DataMember(Name = "from", IsRequired = true)]
        public AnyOf<TaskReference,FileReference> From { get; set; } 
        /// <summary>
        /// A list of additional processes for loading this output on different platforms.
        /// </summary>
        /// <value>A list of additional processes for loading this output on different platforms.</value>
        [DataMember(Name = "alias")]
        public List<AnyOf<DAGGenericOutputAlias,DAGStringOutputAlias,DAGIntegerOutputAlias,DAGNumberOutputAlias,DAGBooleanOutputAlias,DAGFolderOutputAlias,DAGFileOutputAlias,DAGPathOutputAlias,DAGArrayOutputAlias,DAGJSONObjectOutputAlias,DAGLinkedOutputAlias>> Alias { get; set; } 
        /// <summary>
        /// A boolean to indicate if an artifact output is required. A False value makes the artifact optional.
        /// </summary>
        /// <value>A boolean to indicate if an artifact output is required. A False value makes the artifact optional.</value>
        [DataMember(Name = "required")]
        public bool Required { get; set; }  = true;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DAGFileOutput";
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
            sb.Append("DAGFileOutput:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Annotations: ").Append(this.Annotations).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  From: ").Append(this.From).Append("\n");
            sb.Append("  Alias: ").Append(this.Alias).Append("\n");
            sb.Append("  Required: ").Append(this.Required).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DAGFileOutput object</returns>
        public static DAGFileOutput FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAGFileOutput>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAGFileOutput object</returns>
        public virtual DAGFileOutput DuplicateDAGFileOutput()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDAGFileOutput();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override GenericOutput DuplicateGenericOutput()
        {
            return DuplicateDAGFileOutput();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as DAGFileOutput);
        }

        /// <summary>
        /// Returns true if DAGFileOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of DAGFileOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAGFileOutput input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.From, input.From) && 
                (
                    this.Alias == input.Alias ||
                    Extension.AllEquals(this.Alias, input.Alias)
                ) && 
                    Extension.Equals(this.Required, input.Required) && 
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
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
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
            Regex regexType = new Regex(@"^DAGFileOutput$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
