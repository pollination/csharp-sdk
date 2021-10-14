/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.18.0-beta.6
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
    /// DAG generic alias output.  In most cases, you should not be using the generic output unless you need a dynamic output that changes its type in different platforms because of returning different objects in handler.
    /// </summary>
    [DataContract]
    public partial class DAGGenericOutputAlias :  IEquatable<DAGGenericOutputAlias>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGGenericOutputAlias" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DAGGenericOutputAlias() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGGenericOutputAlias" /> class.
        /// </summary>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="description">Optional description for output..</param>
        /// <param name="handler">List of process actions to process the input or output value. (required).</param>
        /// <param name="name">Output name. (required).</param>
        /// <param name="platform">Name of the client platform (e.g. Grasshopper, Revit, etc). The value can be any strings as long as it has been agreed between client-side developer and author of the recipe. (required).</param>
        public DAGGenericOutputAlias
        (
           List<IOAliasHandler> handler, string name, List<string> platform, // Required parameters
           Dictionary<string, string> annotations= default, string description= default // Optional parameters
        )// BaseClass
        {
            // to ensure "handler" is required (not null)
            if (handler == null)
            {
                throw new InvalidDataException("handler is a required property for DAGGenericOutputAlias and cannot be null");
            }
            else
            {
                this.Handler = handler;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for DAGGenericOutputAlias and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "platform" is required (not null)
            if (platform == null)
            {
                throw new InvalidDataException("platform is a required property for DAGGenericOutputAlias and cannot be null");
            }
            else
            {
                this.Platform = platform;
            }
            
            this.Annotations = annotations;
            this.Description = description;

            // Set non-required readonly properties with defaultValue
            this.Type = "DAGGenericOutputAlias";
        }
        
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        [JsonProperty("annotations")]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// Optional description for output.
        /// </summary>
        /// <value>Optional description for output.</value>
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
        /// Output name.
        /// </summary>
        /// <value>Output name.</value>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DAGGenericOutputAlias {\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Handler: ").Append(Handler).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
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
        /// <returns>DAGGenericOutputAlias object</returns>
        public static DAGGenericOutputAlias FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAGGenericOutputAlias>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAGGenericOutputAlias object</returns>
        public DAGGenericOutputAlias DuplicateDAGGenericOutputAlias()
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
            return this.Equals(input as DAGGenericOutputAlias);
        }

        /// <summary>
        /// Returns true if DAGGenericOutputAlias instances are equal
        /// </summary>
        /// <param name="input">Instance of DAGGenericOutputAlias to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAGGenericOutputAlias input)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Handler != null)
                    hashCode = hashCode * 59 + this.Handler.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
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
            Regex regexType = new Regex(@"^DAGGenericOutputAlias$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
