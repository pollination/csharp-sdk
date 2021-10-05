/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.17.0-beta.1
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
    /// BodyPostPluginOwnerPluginsPost
    /// </summary>
    [DataContract]
    public partial class BodyPostPluginOwnerPluginsPost :  IEquatable<BodyPostPluginOwnerPluginsPost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPostPluginOwnerPluginsPost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BodyPostPluginOwnerPluginsPost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPostPluginOwnerPluginsPost" /> class.
        /// </summary>
        /// <param name="package">package (required).</param>
        public BodyPostPluginOwnerPluginsPost
        (
           System.IO.Stream package// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "package" is required (not null)
            if (package == null)
            {
                throw new InvalidDataException("package is a required property for BodyPostPluginOwnerPluginsPost and cannot be null");
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
            sb.Append("class BodyPostPluginOwnerPluginsPost {\n");
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
        /// <returns>BodyPostPluginOwnerPluginsPost object</returns>
        public static BodyPostPluginOwnerPluginsPost FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<BodyPostPluginOwnerPluginsPost>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>BodyPostPluginOwnerPluginsPost object</returns>
        public BodyPostPluginOwnerPluginsPost DuplicateBodyPostPluginOwnerPluginsPost()
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
            return this.Equals(input as BodyPostPluginOwnerPluginsPost);
        }

        /// <summary>
        /// Returns true if BodyPostPluginOwnerPluginsPost instances are equal
        /// </summary>
        /// <param name="input">Instance of BodyPostPluginOwnerPluginsPost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BodyPostPluginOwnerPluginsPost input)
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
