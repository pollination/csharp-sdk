/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.30.0
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
    /// NewRecipePackage
    /// </summary>
    [DataContract]
    public partial class NewRecipePackage :  IEquatable<NewRecipePackage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewRecipePackage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewRecipePackage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewRecipePackage" /> class.
        /// </summary>
        /// <param name="manifest">The Recipe manifest to be created (required).</param>
        /// <param name="readme">The README file to attach to this package (default to &quot;&quot;).</param>
        public NewRecipePackage
        (
           Recipe manifest, // Required parameters
           string readme = ""// Optional parameters
        )// BaseClass
        {
            // to ensure "manifest" is required (not null)
            if (manifest == null)
            {
                throw new InvalidDataException("manifest is a required property for NewRecipePackage and cannot be null");
            }
            else
            {
                this.Manifest = manifest;
            }
            
            // use default value if no "readme" provided
            if (readme == null)
            {
                this.Readme ="";
            }
            else
            {
                this.Readme = readme;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The Recipe manifest to be created
        /// </summary>
        /// <value>The Recipe manifest to be created</value>
        [DataMember(Name="manifest", EmitDefaultValue=false)]
        [JsonProperty("manifest")]
        public Recipe Manifest { get; set; } 
        /// <summary>
        /// The README file to attach to this package
        /// </summary>
        /// <value>The README file to attach to this package</value>
        [DataMember(Name="readme", EmitDefaultValue=false)]
        [JsonProperty("readme")]
        public string Readme { get; set; }  = "";
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewRecipePackage {\n");
            sb.Append("  Manifest: ").Append(Manifest).Append("\n");
            sb.Append("  Readme: ").Append(Readme).Append("\n");
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
        /// <returns>NewRecipePackage object</returns>
        public static NewRecipePackage FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<NewRecipePackage>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>NewRecipePackage object</returns>
        public NewRecipePackage DuplicateNewRecipePackage()
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
            return this.Equals(input as NewRecipePackage);
        }

        /// <summary>
        /// Returns true if NewRecipePackage instances are equal
        /// </summary>
        /// <param name="input">Instance of NewRecipePackage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewRecipePackage input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Manifest == input.Manifest ||
                    (this.Manifest != null &&
                    this.Manifest.Equals(input.Manifest))
                ) && 
                (
                    this.Readme == input.Readme ||
                    (this.Readme != null &&
                    this.Readme.Equals(input.Readme))
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
                if (this.Manifest != null)
                    hashCode = hashCode * 59 + this.Manifest.GetHashCode();
                if (this.Readme != null)
                    hashCode = hashCode * 59 + this.Readme.GetHashCode();
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
