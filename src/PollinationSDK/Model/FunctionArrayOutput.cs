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
    /// Function array output.  This output loads the content from a JSON file which must be a JSON Array.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "type")]
    public partial class FunctionArrayOutput : FunctionStringOutput,  IEquatable<FunctionArrayOutput>, IValidatableObject
    {
        /// <summary>
        /// Type of items in this array. All the items in an array must be from the same type.
        /// </summary>
        /// <value>Type of items in this array. All the items in an array must be from the same type.</value>
        [DataMember(Name="items_type", EmitDefaultValue=false)]
        public ItemType? ItemsType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionArrayOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FunctionArrayOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionArrayOutput" /> class.
        /// </summary>
        /// <param name="itemsType">Type of items in this array. All the items in an array must be from the same type..</param>
        public FunctionArrayOutput(ItemType? itemsType = default(ItemType?), string name = default(string), Dictionary<string, string> annotations = default(Dictionary<string, string>), string description = default(string), string path = default(string), bool required = true) : base()
        {
            this.ItemsType = itemsType;
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
            sb.Append("class FunctionArrayOutput {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ItemsType: ").Append(ItemsType).Append("\n");
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
            return this.Equals(input as FunctionArrayOutput);
        }

        /// <summary>
        /// Returns true if FunctionArrayOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of FunctionArrayOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FunctionArrayOutput input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.ItemsType == input.ItemsType ||
                    (this.ItemsType != null &&
                    this.ItemsType.Equals(input.ItemsType))
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
                if (this.ItemsType != null)
                    hashCode = hashCode * 59 + this.ItemsType.GetHashCode();
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
            Regex regexType = new Regex(@"^FunctionArrayOutput$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
