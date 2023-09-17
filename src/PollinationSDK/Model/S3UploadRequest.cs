/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.44.0
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
    /// S3UploadRequest
    /// </summary>
    [DataContract]
    public partial class S3UploadRequest :  IEquatable<S3UploadRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3UploadRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected S3UploadRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="S3UploadRequest" /> class.
        /// </summary>
        /// <param name="fields">fields (required).</param>
        /// <param name="url">url (required).</param>
        public S3UploadRequest
        (
           Dictionary<string, string> fields, string url// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "fields" is required (not null)
            if (fields == null)
            {
                throw new InvalidDataException("fields is a required property for S3UploadRequest and cannot be null");
            }
            else
            {
                this.Fields = fields;
            }
            
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for S3UploadRequest and cannot be null");
            }
            else
            {
                this.Url = url;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        [JsonProperty("fields")]
        public Dictionary<string, string> Fields { get; set; } 
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        [JsonProperty("url")]
        public string Url { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class S3UploadRequest {\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
        /// <returns>S3UploadRequest object</returns>
        public static S3UploadRequest FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<S3UploadRequest>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>S3UploadRequest object</returns>
        public S3UploadRequest DuplicateS3UploadRequest()
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
            return this.Equals(input as S3UploadRequest);
        }

        /// <summary>
        /// Returns true if S3UploadRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of S3UploadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3UploadRequest input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
