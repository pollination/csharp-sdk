/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: v0.9.1
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
    /// An Input Parameter Reference
    /// </summary>
    [DataContract]
    public partial class InputParameterReference :  IEquatable<InputParameterReference>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public InputReference? Type { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="InputParameterReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InputParameterReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InputParameterReference" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="variable">The name of the DAG input variable (required).</param>
        public InputParameterReference
        (
           string variable, // Required parameters
           InputReference? type= default // Optional parameters
        )// BaseClass
        {
            // to ensure "variable" is required (not null)
            if (variable == null)
            {
                throw new InvalidDataException("variable is a required property for InputParameterReference and cannot be null");
            }
            else
            {
                this.Variable = variable;
            }
            
            this.Type = type;

            // Set non-required readonly properties with defaultValue
        }
        
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
            sb.Append("class InputParameterReference {\n");
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
        /// <returns>InputParameterReference object</returns>
        public static InputParameterReference FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<InputParameterReference>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>InputParameterReference object</returns>
        public InputParameterReference DuplicateInputParameterReference()
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
            return this.Equals(input as InputParameterReference);
        }

        /// <summary>
        /// Returns true if InputParameterReference instances are equal
        /// </summary>
        /// <param name="input">Instance of InputParameterReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputParameterReference input)
        {
            if (input == null)
                return false;
            return 
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
            yield break;
        }
    }

}
