/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.35.0
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
    /// Input and output alias handler object.
    /// </summary>
    [DataContract]
    public partial class IOAliasHandler :  IEquatable<IOAliasHandler>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IOAliasHandler" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IOAliasHandler() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IOAliasHandler" /> class.
        /// </summary>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="function">Name of the function. The input value will be passed to this function as the first argument. (required).</param>
        /// <param name="index">An integer to set the index for the order of execution. This input is only useful when there are more than one handler for the same platform and the output of one handler should be passed to another handler. This is also called chained handlers. By default all the handlers are indexed as 0 assuming they are not chained. (default to 0).</param>
        /// <param name="language">Declare the language (e.g. python, csharp, etc.). This option allows the recipe to be flexible on handling different programming languages. (required).</param>
        /// <param name="module">Target module or namespace to load the alias function. (required).</param>
        public IOAliasHandler
        (
           string function, string language, string module, // Required parameters
           Dictionary<string, string> annotations= default, int index = 0 // Optional parameters
        )// BaseClass
        {
            // to ensure "function" is required (not null)
            if (function == null)
            {
                throw new InvalidDataException("function is a required property for IOAliasHandler and cannot be null");
            }
            else
            {
                this.Function = function;
            }
            
            // to ensure "language" is required (not null)
            if (language == null)
            {
                throw new InvalidDataException("language is a required property for IOAliasHandler and cannot be null");
            }
            else
            {
                this.Language = language;
            }
            
            // to ensure "module" is required (not null)
            if (module == null)
            {
                throw new InvalidDataException("module is a required property for IOAliasHandler and cannot be null");
            }
            else
            {
                this.Module = module;
            }
            
            this.Annotations = annotations;
            // use default value if no "index" provided
            if (index == null)
            {
                this.Index =0;
            }
            else
            {
                this.Index = index;
            }

            // Set non-required readonly properties with defaultValue
            this.Type = "IOAliasHandler";
        }
        
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        [JsonProperty("annotations")]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// Name of the function. The input value will be passed to this function as the first argument.
        /// </summary>
        /// <value>Name of the function. The input value will be passed to this function as the first argument.</value>
        [DataMember(Name="function", EmitDefaultValue=false)]
        [JsonProperty("function")]
        public string Function { get; set; } 
        /// <summary>
        /// An integer to set the index for the order of execution. This input is only useful when there are more than one handler for the same platform and the output of one handler should be passed to another handler. This is also called chained handlers. By default all the handlers are indexed as 0 assuming they are not chained.
        /// </summary>
        /// <value>An integer to set the index for the order of execution. This input is only useful when there are more than one handler for the same platform and the output of one handler should be passed to another handler. This is also called chained handlers. By default all the handlers are indexed as 0 assuming they are not chained.</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        [JsonProperty("index")]
        public int Index { get; set; }  = 0;
        /// <summary>
        /// Declare the language (e.g. python, csharp, etc.). This option allows the recipe to be flexible on handling different programming languages.
        /// </summary>
        /// <value>Declare the language (e.g. python, csharp, etc.). This option allows the recipe to be flexible on handling different programming languages.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        [JsonProperty("language")]
        public string Language { get; set; } 
        /// <summary>
        /// Target module or namespace to load the alias function.
        /// </summary>
        /// <value>Target module or namespace to load the alias function.</value>
        [DataMember(Name="module", EmitDefaultValue=false)]
        [JsonProperty("module")]
        public string Module { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IOAliasHandler {\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Function: ").Append(Function).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Module: ").Append(Module).Append("\n");
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
        /// <returns>IOAliasHandler object</returns>
        public static IOAliasHandler FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<IOAliasHandler>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>IOAliasHandler object</returns>
        public IOAliasHandler DuplicateIOAliasHandler()
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
            return this.Equals(input as IOAliasHandler);
        }

        /// <summary>
        /// Returns true if IOAliasHandler instances are equal
        /// </summary>
        /// <param name="input">Instance of IOAliasHandler to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IOAliasHandler input)
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
                    this.Function == input.Function ||
                    (this.Function != null &&
                    this.Function.Equals(input.Function))
                ) && 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Module == input.Module ||
                    (this.Module != null &&
                    this.Module.Equals(input.Module))
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
                if (this.Function != null)
                    hashCode = hashCode * 59 + this.Function.GetHashCode();
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Module != null)
                    hashCode = hashCode * 59 + this.Module.GetHashCode();
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
            Regex regexType = new Regex(@"^IOAliasHandler$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
