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
using QueenbeeSDK;

namespace PollinationSDK
{
    /// <summary>
    /// S3UploadRequest
    /// </summary>
    [DataContract(Name = "S3UploadRequest")]
    public partial class S3UploadRequest : OpenAPIGenBaseModel, IEquatable<S3UploadRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3UploadRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected S3UploadRequest() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "S3UploadRequest";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="S3UploadRequest" /> class.
        /// </summary>
        /// <param name="url">url (required).</param>
        /// <param name="fields">fields (required).</param>
        public S3UploadRequest
        (
           string url, Dictionary<string, string> fields// Required parameters
           // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "url" is required (not null)
            this.Url = url ?? throw new ArgumentNullException("url is a required property for S3UploadRequest and cannot be null");
            // to ensure "fields" is required (not null)
            this.Fields = fields ?? throw new ArgumentNullException("fields is a required property for S3UploadRequest and cannot be null");

            // Set non-required readonly properties with defaultValue
            this.Type = "S3UploadRequest";
        }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = false)]
        public string Url { get; set; } 
        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> Fields { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "S3UploadRequest";
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
            sb.Append("S3UploadRequest:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>S3UploadRequest object</returns>
        public static S3UploadRequest FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<S3UploadRequest>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>S3UploadRequest object</returns>
        public virtual S3UploadRequest DuplicateS3UploadRequest()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateS3UploadRequest();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateS3UploadRequest();
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
            return base.Equals(input) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && base.Equals(input) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
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
            Regex regexType = new Regex(@"^S3UploadRequest$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
