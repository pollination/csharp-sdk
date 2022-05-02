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
    /// Metadata
    /// </summary>
    [DataContract]
    public partial class Metadata :  IEquatable<Metadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Metadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Metadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Metadata" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="key">key (required).</param>
        /// <param name="value">value (required).</param>
        /// <param name="visible">visible (default to false).</param>
        public Metadata
        (
           string key, string value, // Required parameters
           string id= default, bool visible = false// Optional parameters
        )// BaseClass
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for Metadata and cannot be null");
            }
            else
            {
                this.Key = key;
            }
            
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for Metadata and cannot be null");
            }
            else
            {
                this.Value = value;
            }
            
            this.Id = id;
            // use default value if no "visible" provided
            if (visible == null)
            {
                this.Visible =false;
            }
            else
            {
                this.Visible = visible;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public string Id { get; set; } 
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        [JsonProperty("key")]
        public string Key { get; set; } 
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        [JsonProperty("value")]
        public string Value { get; set; } 
        /// <summary>
        /// Gets or Sets Visible
        /// </summary>
        [DataMember(Name="visible", EmitDefaultValue=false)]
        [JsonProperty("visible")]
        public bool Visible { get; set; }  = false;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Metadata {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
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
        /// <returns>Metadata object</returns>
        public static Metadata FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Metadata>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Metadata object</returns>
        public Metadata DuplicateMetadata()
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
            return this.Equals(input as Metadata);
        }

        /// <summary>
        /// Returns true if Metadata instances are equal
        /// </summary>
        /// <param name="input">Instance of Metadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Metadata input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Visible == input.Visible ||
                    (this.Visible != null &&
                    this.Visible.Equals(input.Visible))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Visible != null)
                    hashCode = hashCode * 59 + this.Visible.GetHashCode();
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
