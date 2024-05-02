/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * Contact: info@pollination.cloud
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

extern alias LBTNewtonsoft;  extern alias LBTRestSharp; using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using LBTNewtonsoft::Newtonsoft.Json;
using LBTNewtonsoft::Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace PollinationSDK
{
    /// <summary>
    /// PaymentMethod
    /// </summary>
    [DataContract(Name = "PaymentMethod")]
    public partial class PaymentMethod : OpenAPIGenBaseModel, IEquatable<PaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets _PaymentMethod
        /// </summary>
        [DataMember(Name="payment_method")]
        public PaymentMethodEnum _PaymentMethod { get; set; }   
        /// <summary>
        /// Gets or Sets CardType
        /// </summary>
        [DataMember(Name="card_type")]
        public CardType CardType { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentMethod() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "PaymentMethod";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethod" /> class.
        /// </summary>
        /// <param name="paymentMethod">paymentMethod (required).</param>
        /// <param name="cardType">cardType.</param>
        /// <param name="lastFourDigits">lastFourDigits.</param>
        /// <param name="expiryDate">expiryDate.</param>
        public PaymentMethod
        (
           PaymentMethodEnum paymentMethod, // Required parameters
           CardType cardType= default, string lastFourDigits= default, string expiryDate= default // Optional parameters
        ) : base()// BaseClass
        {
            this._PaymentMethod = paymentMethod;
            this.CardType = cardType;
            this.LastFourDigits = lastFourDigits;
            this.ExpiryDate = expiryDate;

            // Set non-required readonly properties with defaultValue
            this.Type = "PaymentMethod";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "PaymentMethod";

        /// <summary>
        /// Gets or Sets LastFourDigits
        /// </summary>
        [DataMember(Name = "last_four_digits")]
        public string LastFourDigits { get; set; } 
        /// <summary>
        /// Gets or Sets ExpiryDate
        /// </summary>
        [DataMember(Name = "expiry_date")]
        public string ExpiryDate { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "PaymentMethod";
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
            sb.Append("PaymentMethod:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  PaymentMethod: ").Append(this._PaymentMethod).Append("\n");
            sb.Append("  CardType: ").Append(this.CardType).Append("\n");
            sb.Append("  LastFourDigits: ").Append(this.LastFourDigits).Append("\n");
            sb.Append("  ExpiryDate: ").Append(this.ExpiryDate).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>PaymentMethod object</returns>
        public static PaymentMethod FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<PaymentMethod>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>PaymentMethod object</returns>
        public virtual PaymentMethod DuplicatePaymentMethod()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicatePaymentMethod();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicatePaymentMethod();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
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
            return base.Equals(input) && 
                    Extension.Equals(this._PaymentMethod, input._PaymentMethod) && 
                    Extension.Equals(this.CardType, input.CardType) && 
                    Extension.Equals(this.LastFourDigits, input.LastFourDigits) && 
                    Extension.Equals(this.ExpiryDate, input.ExpiryDate) && 
                    Extension.Equals(this.Type, input.Type);
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
                if (this._PaymentMethod != null)
                    hashCode = hashCode * 59 + this._PaymentMethod.GetHashCode();
                if (this.CardType != null)
                    hashCode = hashCode * 59 + this.CardType.GetHashCode();
                if (this.LastFourDigits != null)
                    hashCode = hashCode * 59 + this.LastFourDigits.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
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
            Regex regexType = new Regex(@"^PaymentMethod$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
