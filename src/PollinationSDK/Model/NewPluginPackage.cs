/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
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


namespace PollinationSDK
{
    /// <summary>
    /// NewPluginPackage
    /// </summary>
    [DataContract(Name = "NewPluginPackage")]
    public partial class NewPluginPackage : IEquatable<NewPluginPackage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewPluginPackage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewPluginPackage() 
        { 
            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="NewPluginPackage" /> class.
        /// </summary>
        /// <param name="manifest">The Plugin manifest to be created (required).</param>
        /// <param name="readme">The README file to attach to this package (default to &quot;&quot;).</param>
        public NewPluginPackage
        (
           Plugin manifest, // Required parameters
           string readme = ""// Optional parameters
        )// BaseClass
        {
            // to ensure "manifest" is required (not null)
            this.Manifest = manifest ?? throw new ArgumentNullException("manifest is a required property for NewPluginPackage and cannot be null");
            // use default value if no "readme" provided
            this.Readme = readme ?? "";

            // Set non-required readonly properties with defaultValue
        }


        /// <summary>
        /// The Plugin manifest to be created
        /// </summary>
        /// <value>The Plugin manifest to be created</value>
        [DataMember(Name = "manifest", IsRequired = true, EmitDefaultValue = false)]
        public Plugin Manifest { get; set; } 
        /// <summary>
        /// The README file to attach to this package
        /// </summary>
        /// <value>The README file to attach to this package</value>
        [DataMember(Name = "readme", EmitDefaultValue = true)]
        public string Readme { get; set; }  = "";

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "NewPluginPackage";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("NewPluginPackage:\n");
            sb.Append("  Manifest: ").Append(Manifest).Append("\n");
            sb.Append("  Readme: ").Append(Readme).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>NewPluginPackage object</returns>
        public static NewPluginPackage FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<NewPluginPackage>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>NewPluginPackage object</returns>
        public virtual NewPluginPackage DuplicateNewPluginPackage()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateNewPluginPackage();
        }

     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as NewPluginPackage);
        }

        /// <summary>
        /// Returns true if NewPluginPackage instances are equal
        /// </summary>
        /// <param name="input">Instance of NewPluginPackage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewPluginPackage input)
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
