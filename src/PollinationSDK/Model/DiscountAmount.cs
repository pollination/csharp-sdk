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
    /// DiscountAmount
    /// </summary>
    [DataContract]
    public partial class DiscountAmount :  IEquatable<DiscountAmount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountAmount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DiscountAmount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountAmount" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="discount">discount (required).</param>
        public DiscountAmount
        (
           int amount, string discount// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for DiscountAmount and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            
            // to ensure "discount" is required (not null)
            if (discount == null)
            {
                throw new InvalidDataException("discount is a required property for DiscountAmount and cannot be null");
            }
            else
            {
                this.Discount = discount;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        [JsonProperty("amount")]
        public int Amount { get; set; } 
        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name="discount", EmitDefaultValue=false)]
        [JsonProperty("discount")]
        public string Discount { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiscountAmount {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
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
        /// <returns>DiscountAmount object</returns>
        public static DiscountAmount FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DiscountAmount>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DiscountAmount object</returns>
        public DiscountAmount DuplicateDiscountAmount()
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
            return this.Equals(input as DiscountAmount);
        }

        /// <summary>
        /// Returns true if DiscountAmount instances are equal
        /// </summary>
        /// <param name="input">Instance of DiscountAmount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiscountAmount input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Discount == input.Discount ||
                    (this.Discount != null &&
                    this.Discount.Equals(input.Discount))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Discount != null)
                    hashCode = hashCode * 59 + this.Discount.GetHashCode();
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
