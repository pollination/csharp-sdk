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
    /// Reference to a folder.
    /// </summary>
    [DataContract(Name = "FolderReference")]
    public partial class FolderReference : BaseReference, IEquatable<FolderReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FolderReference() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "FolderReference";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderReference" /> class.
        /// </summary>
        /// <param name="path">Relative path to a folder. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        public FolderReference
        (
           string path, // Required parameters
            Dictionary<string, string> annotations= default // Optional parameters
        ) : base(annotations: annotations)// BaseClass
        {
            // to ensure "path" is required (not null)
            this.Path = path ?? throw new ArgumentNullException("path is a required property for FolderReference and cannot be null");

            // Set non-required readonly properties with defaultValue
            this.Type = "FolderReference";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; protected internal set; }  = "FolderReference";

        /// <summary>
        /// Relative path to a folder.
        /// </summary>
        /// <value>Relative path to a folder.</value>
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = false)]
        public string Path { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "FolderReference";
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
            sb.Append("FolderReference:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>FolderReference object</returns>
        public static FolderReference FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<FolderReference>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>FolderReference object</returns>
        public virtual FolderReference DuplicateFolderReference()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateFolderReference();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override BaseReference DuplicateBaseReference()
        {
            return DuplicateFolderReference();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as FolderReference);
        }

        /// <summary>
        /// Returns true if FolderReference instances are equal
        /// </summary>
        /// <param name="input">Instance of FolderReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FolderReference input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
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
            Regex regexType = new Regex(@"^FolderReference$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
