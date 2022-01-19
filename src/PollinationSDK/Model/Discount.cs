/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.25.0
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
    /// Discount
    /// </summary>
    [DataContract]
    public partial class Discount :  IEquatable<Discount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Discount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Discount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Discount" /> class.
        /// </summary>
        /// <param name="coupon">coupon (required).</param>
        /// <param name="end">end.</param>
        /// <param name="id">id (required).</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="promotionCode">promotionCode.</param>
        /// <param name="start">start (required).</param>
        public Discount
        (
           Coupon coupon, string id, DateTime start, // Required parameters
           DateTime end= default, Object metadata= default, string promotionCode= default // Optional parameters
        )// BaseClass
        {
            // to ensure "coupon" is required (not null)
            if (coupon == null)
            {
                throw new InvalidDataException("coupon is a required property for Discount and cannot be null");
            }
            else
            {
                this.Coupon = coupon;
            }
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Discount and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "start" is required (not null)
            if (start == null)
            {
                throw new InvalidDataException("start is a required property for Discount and cannot be null");
            }
            else
            {
                this.Start = start;
            }
            
            this.End = end;
            this.Metadata = metadata;
            this.PromotionCode = promotionCode;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Coupon
        /// </summary>
        [DataMember(Name="coupon", EmitDefaultValue=false)]
        [JsonProperty("coupon")]
        public Coupon Coupon { get; set; } 
        /// <summary>
        /// Gets or Sets End
        /// </summary>
        [DataMember(Name="end", EmitDefaultValue=false)]
        [JsonProperty("end")]
        public DateTime End { get; set; } 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public string Id { get; set; } 
        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        [JsonProperty("metadata")]
        public Object Metadata { get; set; } 
        /// <summary>
        /// Gets or Sets PromotionCode
        /// </summary>
        [DataMember(Name="promotion_code", EmitDefaultValue=false)]
        [JsonProperty("promotion_code")]
        public string PromotionCode { get; set; } 
        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name="start", EmitDefaultValue=false)]
        [JsonProperty("start")]
        public DateTime Start { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Discount {\n");
            sb.Append("  Coupon: ").Append(Coupon).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  PromotionCode: ").Append(PromotionCode).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
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
        /// <returns>Discount object</returns>
        public static Discount FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Discount>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Discount object</returns>
        public Discount DuplicateDiscount()
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
            return this.Equals(input as Discount);
        }

        /// <summary>
        /// Returns true if Discount instances are equal
        /// </summary>
        /// <param name="input">Instance of Discount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Discount input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Coupon == input.Coupon ||
                    (this.Coupon != null &&
                    this.Coupon.Equals(input.Coupon))
                ) && 
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.PromotionCode == input.PromotionCode ||
                    (this.PromotionCode != null &&
                    this.PromotionCode.Equals(input.PromotionCode))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
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
                if (this.Coupon != null)
                    hashCode = hashCode * 59 + this.Coupon.GetHashCode();
                if (this.End != null)
                    hashCode = hashCode * 59 + this.End.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.PromotionCode != null)
                    hashCode = hashCode * 59 + this.PromotionCode.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
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
