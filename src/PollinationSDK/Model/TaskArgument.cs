/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.18.0-beta.5
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
    /// Task argument for receiving inputs that are not files or folders.
    /// </summary>
    [DataContract]
    public partial class TaskArgument :  IEquatable<TaskArgument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskArgument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskArgument() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskArgument" /> class.
        /// </summary>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="from">A reference to a DAG input, a DAG output or another task output. You can also use the ValueReference type to hard-code an input value. (required).</param>
        /// <param name="name">Argument name. The name must match one of the input names from Task&#39;s template which can be a function or DAG. (required).</param>
        public TaskArgument
        (
           AnyOf<InputReference,TaskReference,ItemReference,ValueReference> from, string name, // Required parameters
           Dictionary<string, string> annotations= default // Optional parameters
        )// BaseClass
        {
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new InvalidDataException("from is a required property for TaskArgument and cannot be null");
            }
            else
            {
                this.From = from;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for TaskArgument and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            this.Annotations = annotations;

            // Set non-required readonly properties with defaultValue
            this.Type = "TaskArgument";
        }
        
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        [JsonProperty("annotations")]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// A reference to a DAG input, a DAG output or another task output. You can also use the ValueReference type to hard-code an input value.
        /// </summary>
        /// <value>A reference to a DAG input, a DAG output or another task output. You can also use the ValueReference type to hard-code an input value.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        [JsonProperty("from")]
        public AnyOf<InputReference,TaskReference,ItemReference,ValueReference> From { get; set; } 
        /// <summary>
        /// Argument name. The name must match one of the input names from Task&#39;s template which can be a function or DAG.
        /// </summary>
        /// <value>Argument name. The name must match one of the input names from Task&#39;s template which can be a function or DAG.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskArgument {\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
        /// <returns>TaskArgument object</returns>
        public static TaskArgument FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<TaskArgument>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>TaskArgument object</returns>
        public TaskArgument DuplicateTaskArgument()
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
            return this.Equals(input as TaskArgument);
        }

        /// <summary>
        /// Returns true if TaskArgument instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskArgument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskArgument input)
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
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
            Regex regexType = new Regex(@"^TaskArgument$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
