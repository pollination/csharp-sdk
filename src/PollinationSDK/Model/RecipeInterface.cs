/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.21.2
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
    /// An interface object for creating a Recipe.  Recipe information only includes metadata, source, inputs and outputs of a Recipe. This object is useful for creating user interface for Recipes.
    /// </summary>
    [DataContract]
    public partial class RecipeInterface :  IEquatable<RecipeInterface>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipeInterface" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecipeInterface() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipeInterface" /> class.
        /// </summary>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="inputs">A list of recipe inputs..</param>
        /// <param name="metadata">Recipe metadata information. (required).</param>
        /// <param name="outputs">A list of recipe outputs..</param>
        /// <param name="source">A URL to the source this recipe from a registry..</param>
        public RecipeInterface
        (
           MetaData metadata, // Required parameters
           Dictionary<string, string> annotations= default, List<AnyOf<DAGGenericInput,DAGStringInput,DAGIntegerInput,DAGNumberInput,DAGBooleanInput,DAGFolderInput,DAGFileInput,DAGPathInput,DAGArrayInput,DAGJSONObjectInput>> inputs= default, List<AnyOf<DAGGenericOutput,DAGStringOutput,DAGIntegerOutput,DAGNumberOutput,DAGBooleanOutput,DAGFolderOutput,DAGFileOutput,DAGPathOutput,DAGArrayOutput,DAGJSONObjectOutput>> outputs= default, string source= default // Optional parameters
        )// BaseClass
        {
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new InvalidDataException("metadata is a required property for RecipeInterface and cannot be null");
            }
            else
            {
                this.Metadata = metadata;
            }
            
            this.Annotations = annotations;
            this.Inputs = inputs;
            this.Outputs = outputs;
            this.Source = source;

            // Set non-required readonly properties with defaultValue
            this.ApiVersion = "v1beta1";
            this.Type = "RecipeInterface";
        }
        
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        [JsonProperty("annotations")]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// A list of recipe inputs.
        /// </summary>
        /// <value>A list of recipe inputs.</value>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        [JsonProperty("inputs")]
        public List<AnyOf<DAGGenericInput,DAGStringInput,DAGIntegerInput,DAGNumberInput,DAGBooleanInput,DAGFolderInput,DAGFileInput,DAGPathInput,DAGArrayInput,DAGJSONObjectInput>> Inputs { get; set; } 
        /// <summary>
        /// Recipe metadata information.
        /// </summary>
        /// <value>Recipe metadata information.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        [JsonProperty("metadata")]
        public MetaData Metadata { get; set; } 
        /// <summary>
        /// A list of recipe outputs.
        /// </summary>
        /// <value>A list of recipe outputs.</value>
        [DataMember(Name="outputs", EmitDefaultValue=false)]
        [JsonProperty("outputs")]
        public List<AnyOf<DAGGenericOutput,DAGStringOutput,DAGIntegerOutput,DAGNumberOutput,DAGBooleanOutput,DAGFolderOutput,DAGFileOutput,DAGPathOutput,DAGArrayOutput,DAGJSONObjectOutput>> Outputs { get; set; } 
        /// <summary>
        /// A URL to the source this recipe from a registry.
        /// </summary>
        /// <value>A URL to the source this recipe from a registry.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        [JsonProperty("source")]
        public string Source { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipeInterface {\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
        /// <returns>RecipeInterface object</returns>
        public static RecipeInterface FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RecipeInterface>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RecipeInterface object</returns>
        public RecipeInterface DuplicateRecipeInterface()
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
            return this.Equals(input as RecipeInterface);
        }

        /// <summary>
        /// Returns true if RecipeInterface instances are equal
        /// </summary>
        /// <param name="input">Instance of RecipeInterface to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipeInterface input)
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
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    input.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Outputs == input.Outputs ||
                    this.Outputs != null &&
                    input.Outputs != null &&
                    this.Outputs.SequenceEqual(input.Outputs)
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Outputs != null)
                    hashCode = hashCode * 59 + this.Outputs.GetHashCode();
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
            // ApiVersion (string) pattern
            Regex regexApiVersion = new Regex(@"^v1beta1$", RegexOptions.CultureInvariant);
            if (false == regexApiVersion.Match(this.ApiVersion).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApiVersion, must match a pattern of " + regexApiVersion, new [] { "ApiVersion" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^RecipeInterface$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
