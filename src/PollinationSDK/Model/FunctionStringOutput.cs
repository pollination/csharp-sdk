/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.16.0
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = PollinationSDK.Client.OpenAPIDateConverter;

namespace PollinationSDK.Model
{
    /// <summary>
    /// Function string output.  This output loads the content from a file as a string.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(FunctionJSONObjectOutput), "FunctionJSONObjectOutput")]
    [JsonSubtypes.KnownSubType(typeof(FunctionArrayOutput), "FunctionArrayOutput")]
    [JsonSubtypes.KnownSubType(typeof(StepStringOutput), "StepStringOutput")]
    [JsonSubtypes.KnownSubType(typeof(FunctionNumberOutput), "FunctionNumberOutput")]
    [JsonSubtypes.KnownSubType(typeof(FunctionBooleanOutput), "FunctionBooleanOutput")]
    [JsonSubtypes.KnownSubType(typeof(FunctionIntegerOutput), "FunctionIntegerOutput")]
    [JsonSubtypes.KnownSubType(typeof(StepArrayOutput), "StepArrayOutput")]
    public partial class FunctionStringOutput : FunctionFileOutput,  IEquatable<FunctionStringOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionStringOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FunctionStringOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionStringOutput" /> class.
        /// </summary>
        public FunctionStringOutput(string name = default(string), Dictionary<string, string> annotations = default(Dictionary<string, string>), string description = default(string), string path = default(string), bool required = true) : base()
        {
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FunctionStringOutput {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FunctionStringOutput);
        }

        /// <summary>
        /// Returns true if FunctionStringOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of FunctionStringOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FunctionStringOutput input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^FunctionStringOutput$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
