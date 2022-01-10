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
    /// Function template.
    /// </summary>
    [DataContract(Name = "TemplateFunction")]
    public partial class TemplateFunction : OpenAPIGenBaseModel, IEquatable<TemplateFunction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateFunction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplateFunction() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "TemplateFunction";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateFunction" /> class.
        /// </summary>
        /// <param name="name">Function name. Must be unique within a plugin. (required).</param>
        /// <param name="command">Full shell command for this function. Each function accepts only one command. The command will be executed as a shell command in plugin. For running several commands after each other use &amp;&amp; between the commands or pipe data from one to another using | (required).</param>
        /// <param name="config">The plugin config to use for this function (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="inputs">Input arguments for this function..</param>
        /// <param name="outputs">List of output arguments..</param>
        /// <param name="description">Function description. A short human readable description for this function..</param>
        public TemplateFunction
        (
           string name, string command, PluginConfig config, // Required parameters
           Dictionary<string, string> annotations= default, List<AnyOf<FunctionStringInput,FunctionIntegerInput,FunctionNumberInput,FunctionBooleanInput,FunctionFolderInput,FunctionFileInput,FunctionPathInput,FunctionArrayInput,FunctionJSONObjectInput>> inputs= default, List<AnyOf<FunctionStringOutput,FunctionIntegerOutput,FunctionNumberOutput,FunctionBooleanOutput,FunctionFolderOutput,FunctionFileOutput,FunctionPathOutput,FunctionArrayOutput,FunctionJSONObjectOutput>> outputs= default, string description= default // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for TemplateFunction and cannot be null");
            // to ensure "command" is required (not null)
            this.Command = command ?? throw new ArgumentNullException("command is a required property for TemplateFunction and cannot be null");
            // to ensure "config" is required (not null)
            this.Config = config ?? throw new ArgumentNullException("config is a required property for TemplateFunction and cannot be null");
            this.Annotations = annotations;
            this.Inputs = inputs;
            this.Outputs = outputs;
            this.Description = description;

            // Set non-required readonly properties with defaultValue
            this.Type = "TemplateFunction";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; protected internal set; }  = "TemplateFunction";

        /// <summary>
        /// Function name. Must be unique within a plugin.
        /// </summary>
        /// <value>Function name. Must be unique within a plugin.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; } 
        /// <summary>
        /// Full shell command for this function. Each function accepts only one command. The command will be executed as a shell command in plugin. For running several commands after each other use &amp;&amp; between the commands or pipe data from one to another using |
        /// </summary>
        /// <value>Full shell command for this function. Each function accepts only one command. The command will be executed as a shell command in plugin. For running several commands after each other use &amp;&amp; between the commands or pipe data from one to another using |</value>
        [DataMember(Name = "command", IsRequired = true, EmitDefaultValue = false)]
        public string Command { get; set; } 
        /// <summary>
        /// The plugin config to use for this function
        /// </summary>
        /// <value>The plugin config to use for this function</value>
        [DataMember(Name = "config", IsRequired = true, EmitDefaultValue = false)]
        public PluginConfig Config { get; set; } 
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name = "annotations", EmitDefaultValue = false)]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// Input arguments for this function.
        /// </summary>
        /// <value>Input arguments for this function.</value>
        [DataMember(Name = "inputs", EmitDefaultValue = false)]
        public List<AnyOf<FunctionStringInput,FunctionIntegerInput,FunctionNumberInput,FunctionBooleanInput,FunctionFolderInput,FunctionFileInput,FunctionPathInput,FunctionArrayInput,FunctionJSONObjectInput>> Inputs { get; set; } 
        /// <summary>
        /// List of output arguments.
        /// </summary>
        /// <value>List of output arguments.</value>
        [DataMember(Name = "outputs", EmitDefaultValue = false)]
        public List<AnyOf<FunctionStringOutput,FunctionIntegerOutput,FunctionNumberOutput,FunctionBooleanOutput,FunctionFolderOutput,FunctionFileOutput,FunctionPathOutput,FunctionArrayOutput,FunctionJSONObjectOutput>> Outputs { get; set; } 
        /// <summary>
        /// Function description. A short human readable description for this function.
        /// </summary>
        /// <value>Function description. A short human readable description for this function.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "TemplateFunction";
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
            sb.Append("TemplateFunction:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>TemplateFunction object</returns>
        public static TemplateFunction FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<TemplateFunction>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>TemplateFunction object</returns>
        public virtual TemplateFunction DuplicateTemplateFunction()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateTemplateFunction();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateTemplateFunction();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as TemplateFunction);
        }

        /// <summary>
        /// Returns true if TemplateFunction instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateFunction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateFunction input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.Command == input.Command ||
                    (this.Command != null &&
                    this.Command.Equals(input.Command))
                ) && base.Equals(input) && 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && base.Equals(input) && 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && base.Equals(input) && 
                (
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    input.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
                ) && base.Equals(input) && 
                (
                    this.Outputs == input.Outputs ||
                    this.Outputs != null &&
                    input.Outputs != null &&
                    this.Outputs.SequenceEqual(input.Outputs)
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Command != null)
                    hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.Outputs != null)
                    hashCode = hashCode * 59 + this.Outputs.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
            Regex regexType = new Regex(@"^TemplateFunction$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
