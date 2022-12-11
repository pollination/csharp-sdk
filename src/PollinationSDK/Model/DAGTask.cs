/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.33.0
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
    /// A single task in a DAG flow.
    /// </summary>
    [DataContract]
    public partial class DAGTask :  IEquatable<DAGTask>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGTask" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DAGTask() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGTask" /> class.
        /// </summary>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="arguments">The input arguments for this task..</param>
        /// <param name="loop">Loop configuration for this task..</param>
        /// <param name="name">Name for this task. It must be unique in a DAG. (required).</param>
        /// <param name="needs">List of DAG tasks that this task depends on and needs to be executed before this task..</param>
        /// <param name="returns">List of task returns..</param>
        /// <param name="subFolder">A path relative to the current folder context where artifacts should be saved. This is useful when performing a loop or invoking another workflow and wanting to save results in a specific sub_folder..</param>
        /// <param name="template">Template name. A template is a Function or a DAG. This template must be available in the dependencies. (required).</param>
        public DAGTask
        (
           string name, string template, // Required parameters
           Dictionary<string, string> annotations= default, List<AnyOf<TaskArgument,TaskPathArgument>> arguments= default, DAGTaskLoop loop= default, List<string> needs= default, List<AnyOf<TaskReturn,TaskPathReturn>> returns= default, string subFolder= default // Optional parameters
        )// BaseClass
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for DAGTask and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "template" is required (not null)
            if (template == null)
            {
                throw new InvalidDataException("template is a required property for DAGTask and cannot be null");
            }
            else
            {
                this.Template = template;
            }
            
            this.Annotations = annotations;
            this.Arguments = arguments;
            this.Loop = loop;
            this.Needs = needs;
            this.Returns = returns;
            this.SubFolder = subFolder;

            // Set non-required readonly properties with defaultValue
            this.Type = "DAGTask";
        }
        
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        [JsonProperty("annotations")]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// The input arguments for this task.
        /// </summary>
        /// <value>The input arguments for this task.</value>
        [DataMember(Name="arguments", EmitDefaultValue=false)]
        [JsonProperty("arguments")]
        public List<AnyOf<TaskArgument,TaskPathArgument>> Arguments { get; set; } 
        /// <summary>
        /// Loop configuration for this task.
        /// </summary>
        /// <value>Loop configuration for this task.</value>
        [DataMember(Name="loop", EmitDefaultValue=false)]
        [JsonProperty("loop")]
        public DAGTaskLoop Loop { get; set; } 
        /// <summary>
        /// Name for this task. It must be unique in a DAG.
        /// </summary>
        /// <value>Name for this task. It must be unique in a DAG.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// List of DAG tasks that this task depends on and needs to be executed before this task.
        /// </summary>
        /// <value>List of DAG tasks that this task depends on and needs to be executed before this task.</value>
        [DataMember(Name="needs", EmitDefaultValue=false)]
        [JsonProperty("needs")]
        public List<string> Needs { get; set; } 
        /// <summary>
        /// List of task returns.
        /// </summary>
        /// <value>List of task returns.</value>
        [DataMember(Name="returns", EmitDefaultValue=false)]
        [JsonProperty("returns")]
        public List<AnyOf<TaskReturn,TaskPathReturn>> Returns { get; set; } 
        /// <summary>
        /// A path relative to the current folder context where artifacts should be saved. This is useful when performing a loop or invoking another workflow and wanting to save results in a specific sub_folder.
        /// </summary>
        /// <value>A path relative to the current folder context where artifacts should be saved. This is useful when performing a loop or invoking another workflow and wanting to save results in a specific sub_folder.</value>
        [DataMember(Name="sub_folder", EmitDefaultValue=false)]
        [JsonProperty("sub_folder")]
        public string SubFolder { get; set; } 
        /// <summary>
        /// Template name. A template is a Function or a DAG. This template must be available in the dependencies.
        /// </summary>
        /// <value>Template name. A template is a Function or a DAG. This template must be available in the dependencies.</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        [JsonProperty("template")]
        public string Template { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DAGTask {\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
            sb.Append("  Loop: ").Append(Loop).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Needs: ").Append(Needs).Append("\n");
            sb.Append("  Returns: ").Append(Returns).Append("\n");
            sb.Append("  SubFolder: ").Append(SubFolder).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
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
        /// <returns>DAGTask object</returns>
        public static DAGTask FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAGTask>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAGTask object</returns>
        public DAGTask DuplicateDAGTask()
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
            return this.Equals(input as DAGTask);
        }

        /// <summary>
        /// Returns true if DAGTask instances are equal
        /// </summary>
        /// <param name="input">Instance of DAGTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAGTask input)
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
                    this.Arguments == input.Arguments ||
                    this.Arguments != null &&
                    input.Arguments != null &&
                    this.Arguments.SequenceEqual(input.Arguments)
                ) && 
                (
                    this.Loop == input.Loop ||
                    (this.Loop != null &&
                    this.Loop.Equals(input.Loop))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Needs == input.Needs ||
                    this.Needs != null &&
                    input.Needs != null &&
                    this.Needs.SequenceEqual(input.Needs)
                ) && 
                (
                    this.Returns == input.Returns ||
                    this.Returns != null &&
                    input.Returns != null &&
                    this.Returns.SequenceEqual(input.Returns)
                ) && 
                (
                    this.SubFolder == input.SubFolder ||
                    (this.SubFolder != null &&
                    this.SubFolder.Equals(input.SubFolder))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
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
                if (this.Arguments != null)
                    hashCode = hashCode * 59 + this.Arguments.GetHashCode();
                if (this.Loop != null)
                    hashCode = hashCode * 59 + this.Loop.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Needs != null)
                    hashCode = hashCode * 59 + this.Needs.GetHashCode();
                if (this.Returns != null)
                    hashCode = hashCode * 59 + this.Returns.GetHashCode();
                if (this.SubFolder != null)
                    hashCode = hashCode * 59 + this.SubFolder.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
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
            Regex regexType = new Regex(@"^DAGTask$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
