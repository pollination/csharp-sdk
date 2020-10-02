/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: v0.9.0
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
    /// A Base reference model
    /// </summary>
    [DataContract]
    public partial class FolderArtifactReference :  IEquatable<FolderArtifactReference>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Folder for value: folder
            /// </summary>
            [EnumMember(Value = "folder")]
            Folder = 1

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }   = TypeEnum.Folder; 
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderArtifactReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FolderArtifactReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderArtifactReference" /> class.
        /// </summary>
        /// <param name="path">The path to the file or folder relative to the workflow output folder (required).</param>
        /// <param name="type">type (default to TypeEnum.Folder).</param>
        public FolderArtifactReference
        (
           string path, // Required parameters
           TypeEnum? type = TypeEnum.Folder// Optional parameters
        )// BaseClass
        {
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new InvalidDataException("path is a required property for FolderArtifactReference and cannot be null");
            }
            else
            {
                this.Path = path;
            }
            
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type =TypeEnum.Folder;
            }
            else
            {
                this.Type = type;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The path to the file or folder relative to the workflow output folder
        /// </summary>
        /// <value>The path to the file or folder relative to the workflow output folder</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        [JsonProperty("path")]
        public string Path { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderArtifactReference {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
        /// <returns>FolderArtifactReference object</returns>
        public static FolderArtifactReference FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<FolderArtifactReference>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>FolderArtifactReference object</returns>
        public FolderArtifactReference DuplicateFolderArtifactReference()
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
            return this.Equals(input as FolderArtifactReference);
        }

        /// <summary>
        /// Returns true if FolderArtifactReference instances are equal
        /// </summary>
        /// <param name="input">Instance of FolderArtifactReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FolderArtifactReference input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
            yield break;
        }
    }

}
