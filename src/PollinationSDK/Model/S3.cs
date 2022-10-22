/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.31.0
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
    /// S3 Source  An S3 bucket artifact Source.
    /// </summary>
    [DataContract]
    public partial class S3 :  IEquatable<S3>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected S3() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="S3" /> class.
        /// </summary>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="bucket">The name of the S3 bucket on the host server. (required).</param>
        /// <param name="credentialsPath">Path to the file holding the AccessKey and SecretAccessKey to authenticate to the bucket. Assumes public bucket access if none are specified..</param>
        /// <param name="endpoint">The HTTP endpoint to reach the S3 bucket. (required).</param>
        /// <param name="key">The path inside the bucket to source artifacts from. (required).</param>
        public S3
        (
           string bucket, string endpoint, string key, // Required parameters
           Dictionary<string, string> annotations= default, string credentialsPath= default // Optional parameters
        )// BaseClass
        {
            // to ensure "bucket" is required (not null)
            if (bucket == null)
            {
                throw new InvalidDataException("bucket is a required property for S3 and cannot be null");
            }
            else
            {
                this.Bucket = bucket;
            }
            
            // to ensure "endpoint" is required (not null)
            if (endpoint == null)
            {
                throw new InvalidDataException("endpoint is a required property for S3 and cannot be null");
            }
            else
            {
                this.Endpoint = endpoint;
            }
            
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for S3 and cannot be null");
            }
            else
            {
                this.Key = key;
            }
            
            this.Annotations = annotations;
            this.CredentialsPath = credentialsPath;

            // Set non-required readonly properties with defaultValue
            this.Type = "S3";
        }
        
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        [JsonProperty("annotations")]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// The name of the S3 bucket on the host server.
        /// </summary>
        /// <value>The name of the S3 bucket on the host server.</value>
        [DataMember(Name="bucket", EmitDefaultValue=false)]
        [JsonProperty("bucket")]
        public string Bucket { get; set; } 
        /// <summary>
        /// Path to the file holding the AccessKey and SecretAccessKey to authenticate to the bucket. Assumes public bucket access if none are specified.
        /// </summary>
        /// <value>Path to the file holding the AccessKey and SecretAccessKey to authenticate to the bucket. Assumes public bucket access if none are specified.</value>
        [DataMember(Name="credentials_path", EmitDefaultValue=false)]
        [JsonProperty("credentials_path")]
        public string CredentialsPath { get; set; } 
        /// <summary>
        /// The HTTP endpoint to reach the S3 bucket.
        /// </summary>
        /// <value>The HTTP endpoint to reach the S3 bucket.</value>
        [DataMember(Name="endpoint", EmitDefaultValue=false)]
        [JsonProperty("endpoint")]
        public string Endpoint { get; set; } 
        /// <summary>
        /// The path inside the bucket to source artifacts from.
        /// </summary>
        /// <value>The path inside the bucket to source artifacts from.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        [JsonProperty("key")]
        public string Key { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class S3 {\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Bucket: ").Append(Bucket).Append("\n");
            sb.Append("  CredentialsPath: ").Append(CredentialsPath).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
        /// <returns>S3 object</returns>
        public static S3 FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<S3>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>S3 object</returns>
        public S3 DuplicateS3()
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
            return this.Equals(input as S3);
        }

        /// <summary>
        /// Returns true if S3 instances are equal
        /// </summary>
        /// <param name="input">Instance of S3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3 input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && 
                (
                    this.Bucket == input.Bucket ||
                    (this.Bucket != null &&
                    this.Bucket.Equals(input.Bucket))
                ) && 
                (
                    this.CredentialsPath == input.CredentialsPath ||
                    (this.CredentialsPath != null &&
                    this.CredentialsPath.Equals(input.CredentialsPath))
                ) && 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.Bucket != null)
                    hashCode = hashCode * 59 + this.Bucket.GetHashCode();
                if (this.CredentialsPath != null)
                    hashCode = hashCode * 59 + this.CredentialsPath.GetHashCode();
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
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
            // Type (string) pattern
            Regex regexType = new Regex(@"^S3$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
