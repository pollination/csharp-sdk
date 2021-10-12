/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.18.0-beta.5
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
    /// SubscriptionItemList
    /// </summary>
    [DataContract]
    public partial class SubscriptionItemList :  IEquatable<SubscriptionItemList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionItemList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionItemList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionItemList" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        /// <param name="hasMore">hasMore (required).</param>
        public SubscriptionItemList
        (
           List<SubscriptionItem> data, bool hasMore// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for SubscriptionItemList and cannot be null");
            }
            else
            {
                this.Data = data;
            }
            
            // to ensure "hasMore" is required (not null)
            if (hasMore == null)
            {
                throw new InvalidDataException("hasMore is a required property for SubscriptionItemList and cannot be null");
            }
            else
            {
                this.HasMore = hasMore;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        [JsonProperty("data")]
        public List<SubscriptionItem> Data { get; set; } 
        /// <summary>
        /// Gets or Sets HasMore
        /// </summary>
        [DataMember(Name="has_more", EmitDefaultValue=false)]
        [JsonProperty("has_more")]
        public bool HasMore { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionItemList {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
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
        /// <returns>SubscriptionItemList object</returns>
        public static SubscriptionItemList FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SubscriptionItemList>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SubscriptionItemList object</returns>
        public SubscriptionItemList DuplicateSubscriptionItemList()
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
            return this.Equals(input as SubscriptionItemList);
        }

        /// <summary>
        /// Returns true if SubscriptionItemList instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionItemList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionItemList input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.HasMore == input.HasMore ||
                    (this.HasMore != null &&
                    this.HasMore.Equals(input.HasMore))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.HasMore != null)
                    hashCode = hashCode * 59 + this.HasMore.GetHashCode();
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
