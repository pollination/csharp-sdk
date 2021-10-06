/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.18.0-beta.4
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
    /// An input file reference
    /// </summary>
    [DataContract]
    public partial class InputFileReference :  IEquatable<InputFileReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputFileReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InputFileReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InputFileReference" /> class.
        /// </summary>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="variable">The name of the DAG input variable (required).</param>
        public InputFileReference
        (
           string variable, // Required parameters
           Dictionary<string, string> annotations= default // Optional parameters
        )// BaseClass
        {
            // to ensure "variable" is required (not null)
            if (variable == null)
            {
                throw new InvalidDataException("variable is a required property for InputFileReference and cannot be null");
            }
            else
            {
                this.Variable = variable;
            }
            
            this.Annotations = annotations;

            // Set non-required readonly properties with defaultValue
            this.Type = "InputFileReference";
        }
        
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        [JsonProperty("annotations")]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// The name of the DAG input variable
        /// </summary>
        /// <value>The name of the DAG input variable</value>
        [DataMember(Name="variable", EmitDefaultValue=false)]
        [JsonProperty("variable")]
        public string Variable { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InputFileReference {\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Variable: ").Append(Variable).Append("\n");
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
        /// <returns>InputFileReference object</returns>
        public static InputFileReference FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<InputFileReference>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>InputFileReference object</returns>
        public InputFileReference DuplicateInputFileReference()
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
            return this.Equals(input as InputFileReference);
        }

        /// <summary>
        /// Returns true if InputFileReference instances are equal
        /// </summary>
        /// <param name="input">Instance of InputFileReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputFileReference input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Variable == input.Variable ||
                    (this.Variable != null &&
                    this.Variable.Equals(input.Variable))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Variable != null)
                    hashCode = hashCode * 59 + this.Variable.GetHashCode();
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
            Regex regexType = new Regex(@"^InputFileReference$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
