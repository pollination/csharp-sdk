/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.42.0
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
    /// FileMeta
    /// </summary>
    [DataContract]
    public partial class FileMeta :  IEquatable<FileMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileMeta" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileMeta() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileMeta" /> class.
        /// </summary>
        /// <param name="fileName">fileName (required).</param>
        /// <param name="fileType">fileType (required).</param>
        /// <param name="key">key (required).</param>
        /// <param name="lastModified">lastModified.</param>
        /// <param name="size">size.</param>
        public FileMeta
        (
           string fileName, string fileType, string key, // Required parameters
           DateTime lastModified= default, int size= default// Optional parameters
        )// BaseClass
        {
            // to ensure "fileName" is required (not null)
            if (fileName == null)
            {
                throw new InvalidDataException("fileName is a required property for FileMeta and cannot be null");
            }
            else
            {
                this.FileName = fileName;
            }
            
            // to ensure "fileType" is required (not null)
            if (fileType == null)
            {
                throw new InvalidDataException("fileType is a required property for FileMeta and cannot be null");
            }
            else
            {
                this.FileType = fileType;
            }
            
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for FileMeta and cannot be null");
            }
            else
            {
                this.Key = key;
            }
            
            this.LastModified = lastModified;
            this.Size = size;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name="file_name", EmitDefaultValue=false)]
        [JsonProperty("file_name")]
        public string FileName { get; set; } 
        /// <summary>
        /// Gets or Sets FileType
        /// </summary>
        [DataMember(Name="file_type", EmitDefaultValue=false)]
        [JsonProperty("file_type")]
        public string FileType { get; set; } 
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        [JsonProperty("key")]
        public string Key { get; set; } 
        /// <summary>
        /// Gets or Sets LastModified
        /// </summary>
        [DataMember(Name="last_modified", EmitDefaultValue=false)]
        [JsonProperty("last_modified")]
        public DateTime LastModified { get; set; } 
        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        [JsonProperty("size")]
        public int Size { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileMeta {\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
        /// <returns>FileMeta object</returns>
        public static FileMeta FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<FileMeta>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>FileMeta object</returns>
        public FileMeta DuplicateFileMeta()
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
            return this.Equals(input as FileMeta);
        }

        /// <summary>
        /// Returns true if FileMeta instances are equal
        /// </summary>
        /// <param name="input">Instance of FileMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileMeta input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.FileType == input.FileType ||
                    (this.FileType != null &&
                    this.FileType.Equals(input.FileType))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.FileType != null)
                    hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
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
