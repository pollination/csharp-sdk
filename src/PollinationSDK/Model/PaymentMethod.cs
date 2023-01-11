/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.36.0
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
    /// PaymentMethod
    /// </summary>
    [DataContract]
    public partial class PaymentMethod :  IEquatable<PaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets CardType
        /// </summary>
        [DataMember(Name="card_type", EmitDefaultValue=false)]
        public CardType? CardType { get; set; }   
        /// <summary>
        /// Gets or Sets _PaymentMethod
        /// </summary>
        [DataMember(Name="payment_method", EmitDefaultValue=false)]
        public PaymentMethodEnum _PaymentMethod { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethod" /> class.
        /// </summary>
        /// <param name="cardType">cardType.</param>
        /// <param name="expiryDate">expiryDate.</param>
        /// <param name="lastFourDigits">lastFourDigits.</param>
        /// <param name="paymentMethod">paymentMethod (required).</param>
        public PaymentMethod
        (
           PaymentMethodEnum paymentMethod, // Required parameters
           CardType? cardType= default, string expiryDate= default, string lastFourDigits= default // Optional parameters
        )// BaseClass
        {
            // to ensure "paymentMethod" is required (not null)
            if (paymentMethod == null)
            {
                throw new InvalidDataException("paymentMethod is a required property for PaymentMethod and cannot be null");
            }
            else
            {
                this._PaymentMethod = paymentMethod;
            }
            
            this.CardType = cardType;
            this.ExpiryDate = expiryDate;
            this.LastFourDigits = lastFourDigits;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets ExpiryDate
        /// </summary>
        [DataMember(Name="expiry_date", EmitDefaultValue=false)]
        [JsonProperty("expiry_date")]
        public string ExpiryDate { get; set; } 
        /// <summary>
        /// Gets or Sets LastFourDigits
        /// </summary>
        [DataMember(Name="last_four_digits", EmitDefaultValue=false)]
        [JsonProperty("last_four_digits")]
        public string LastFourDigits { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethod {\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  LastFourDigits: ").Append(LastFourDigits).Append("\n");
            sb.Append("  _PaymentMethod: ").Append(_PaymentMethod).Append("\n");
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
        /// <returns>PaymentMethod object</returns>
        public static PaymentMethod FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<PaymentMethod>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>PaymentMethod object</returns>
        public PaymentMethod DuplicatePaymentMethod()
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
            return this.Equals(input as PaymentMethod);
        }

        /// <summary>
        /// Returns true if PaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethod input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.CardType == input.CardType ||
                    (this.CardType != null &&
                    this.CardType.Equals(input.CardType))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                ) && 
                (
                    this.LastFourDigits == input.LastFourDigits ||
                    (this.LastFourDigits != null &&
                    this.LastFourDigits.Equals(input.LastFourDigits))
                ) && 
                (
                    this._PaymentMethod == input._PaymentMethod ||
                    (this._PaymentMethod != null &&
                    this._PaymentMethod.Equals(input._PaymentMethod))
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
                if (this.CardType != null)
                    hashCode = hashCode * 59 + this.CardType.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.LastFourDigits != null)
                    hashCode = hashCode * 59 + this.LastFourDigits.GetHashCode();
                if (this._PaymentMethod != null)
                    hashCode = hashCode * 59 + this._PaymentMethod.GetHashCode();
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
