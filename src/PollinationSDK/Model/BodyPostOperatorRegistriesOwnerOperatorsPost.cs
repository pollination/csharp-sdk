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
    /// BodyPostOperatorRegistriesOwnerOperatorsPost
    /// </summary>
    [DataContract]
    public partial class BodyPostOperatorRegistriesOwnerOperatorsPost :  IEquatable<BodyPostOperatorRegistriesOwnerOperatorsPost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPostOperatorRegistriesOwnerOperatorsPost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BodyPostOperatorRegistriesOwnerOperatorsPost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPostOperatorRegistriesOwnerOperatorsPost" /> class.
        /// </summary>
        /// <param name="package">package (required).</param>
        public BodyPostOperatorRegistriesOwnerOperatorsPost
        (
           System.IO.Stream package// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "package" is required (not null)
            if (package == null)
            {
                throw new InvalidDataException("package is a required property for BodyPostOperatorRegistriesOwnerOperatorsPost and cannot be null");
            }
            else
            {
                this.Package = package;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Package
        /// </summary>
        [DataMember(Name="package", EmitDefaultValue=false)]
        [JsonProperty("package")]
        public System.IO.Stream Package { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BodyPostOperatorRegistriesOwnerOperatorsPost {\n");
            sb.Append("  Package: ").Append(Package).Append("\n");
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
        /// <returns>BodyPostOperatorRegistriesOwnerOperatorsPost object</returns>
        public static BodyPostOperatorRegistriesOwnerOperatorsPost FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<BodyPostOperatorRegistriesOwnerOperatorsPost>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>BodyPostOperatorRegistriesOwnerOperatorsPost object</returns>
        public BodyPostOperatorRegistriesOwnerOperatorsPost DuplicateBodyPostOperatorRegistriesOwnerOperatorsPost()
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
            return this.Equals(input as BodyPostOperatorRegistriesOwnerOperatorsPost);
        }

        /// <summary>
        /// Returns true if BodyPostOperatorRegistriesOwnerOperatorsPost instances are equal
        /// </summary>
        /// <param name="input">Instance of BodyPostOperatorRegistriesOwnerOperatorsPost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BodyPostOperatorRegistriesOwnerOperatorsPost input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Package == input.Package ||
                    (this.Package != null &&
                    this.Package.Equals(input.Package))
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
                if (this.Package != null)
                    hashCode = hashCode * 59 + this.Package.GetHashCode();
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
