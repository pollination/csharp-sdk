/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.24.0
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
    /// A Function with a single command
    /// </summary>
    [DataContract]
    public partial class Function :  IEquatable<Function>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Function" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Function() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Function" /> class.
        /// </summary>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="command">Full shell command for this function. Each function accepts only one command. The command will be executed as a shell command in plugin. For running several commands after each other use &amp;&amp; between the commands or pipe data from one to another using | (required).</param>
        /// <param name="description">Function description. A short human readable description for this function..</param>
        /// <param name="inputs">Input arguments for this function..</param>
        /// <param name="name">Function name. Must be unique within a plugin. (required).</param>
        /// <param name="outputs">List of output arguments..</param>
        public Function
        (
           string command, string name, // Required parameters
           Dictionary<string, string> annotations= default, string description= default, List<AnyOf<FunctionStringInput,FunctionIntegerInput,FunctionNumberInput,FunctionBooleanInput,FunctionFolderInput,FunctionFileInput,FunctionPathInput,FunctionArrayInput,FunctionJSONObjectInput>> inputs= default, List<AnyOf<FunctionStringOutput,FunctionIntegerOutput,FunctionNumberOutput,FunctionBooleanOutput,FunctionFolderOutput,FunctionFileOutput,FunctionPathOutput,FunctionArrayOutput,FunctionJSONObjectOutput>> outputs= default // Optional parameters
        )// BaseClass
        {
            // to ensure "command" is required (not null)
            if (command == null)
            {
                throw new InvalidDataException("command is a required property for Function and cannot be null");
            }
            else
            {
                this.Command = command;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Function and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            this.Annotations = annotations;
            this.Description = description;
            this.Inputs = inputs;
            this.Outputs = outputs;

            // Set non-required readonly properties with defaultValue
            this.Type = "Function";
        }
        
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        [JsonProperty("annotations")]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// Full shell command for this function. Each function accepts only one command. The command will be executed as a shell command in plugin. For running several commands after each other use &amp;&amp; between the commands or pipe data from one to another using |
        /// </summary>
        /// <value>Full shell command for this function. Each function accepts only one command. The command will be executed as a shell command in plugin. For running several commands after each other use &amp;&amp; between the commands or pipe data from one to another using |</value>
        [DataMember(Name="command", EmitDefaultValue=false)]
        [JsonProperty("command")]
        public string Command { get; set; } 
        /// <summary>
        /// Function description. A short human readable description for this function.
        /// </summary>
        /// <value>Function description. A short human readable description for this function.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; } 
        /// <summary>
        /// Input arguments for this function.
        /// </summary>
        /// <value>Input arguments for this function.</value>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        [JsonProperty("inputs")]
        public List<AnyOf<FunctionStringInput,FunctionIntegerInput,FunctionNumberInput,FunctionBooleanInput,FunctionFolderInput,FunctionFileInput,FunctionPathInput,FunctionArrayInput,FunctionJSONObjectInput>> Inputs { get; set; } 
        /// <summary>
        /// Function name. Must be unique within a plugin.
        /// </summary>
        /// <value>Function name. Must be unique within a plugin.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// List of output arguments.
        /// </summary>
        /// <value>List of output arguments.</value>
        [DataMember(Name="outputs", EmitDefaultValue=false)]
        [JsonProperty("outputs")]
        public List<AnyOf<FunctionStringOutput,FunctionIntegerOutput,FunctionNumberOutput,FunctionBooleanOutput,FunctionFolderOutput,FunctionFileOutput,FunctionPathOutput,FunctionArrayOutput,FunctionJSONObjectOutput>> Outputs { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Function {\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
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
        /// <returns>Function object</returns>
        public static Function FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Function>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Function object</returns>
        public Function DuplicateFunction()
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
            return this.Equals(input as Function);
        }

        /// <summary>
        /// Returns true if Function instances are equal
        /// </summary>
        /// <param name="input">Instance of Function to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Function input)
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
                    this.Command == input.Command ||
                    (this.Command != null &&
                    this.Command.Equals(input.Command))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    input.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Outputs == input.Outputs ||
                    this.Outputs != null &&
                    input.Outputs != null &&
                    this.Outputs.SequenceEqual(input.Outputs)
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
                if (this.Command != null)
                    hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Outputs != null)
                    hashCode = hashCode * 59 + this.Outputs.GetHashCode();
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
            Regex regexType = new Regex(@"^Function$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
