/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.40.0
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
    /// Payment
    /// </summary>
    [DataContract]
    public partial class Payment :  IEquatable<Payment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Payment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="isOneOffCharge">isOneOffCharge (required).</param>
        /// <param name="isPaid">isPaid (required).</param>
        /// <param name="payoutDate">payoutDate (required).</param>
        /// <param name="receiptUrl">receiptUrl.</param>
        /// <param name="subscriptionId">subscriptionId (required).</param>
        public Payment
        (
           int amount, string currency, int id, bool isOneOffCharge, bool isPaid, DateTime payoutDate, int subscriptionId, // Required parameters
           string receiptUrl= default // Optional parameters
        )// BaseClass
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for Payment and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for Payment and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Payment and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "isOneOffCharge" is required (not null)
            if (isOneOffCharge == null)
            {
                throw new InvalidDataException("isOneOffCharge is a required property for Payment and cannot be null");
            }
            else
            {
                this.IsOneOffCharge = isOneOffCharge;
            }
            
            // to ensure "isPaid" is required (not null)
            if (isPaid == null)
            {
                throw new InvalidDataException("isPaid is a required property for Payment and cannot be null");
            }
            else
            {
                this.IsPaid = isPaid;
            }
            
            // to ensure "payoutDate" is required (not null)
            if (payoutDate == null)
            {
                throw new InvalidDataException("payoutDate is a required property for Payment and cannot be null");
            }
            else
            {
                this.PayoutDate = payoutDate;
            }
            
            // to ensure "subscriptionId" is required (not null)
            if (subscriptionId == null)
            {
                throw new InvalidDataException("subscriptionId is a required property for Payment and cannot be null");
            }
            else
            {
                this.SubscriptionId = subscriptionId;
            }
            
            this.ReceiptUrl = receiptUrl;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        [JsonProperty("amount")]
        public int Amount { get; set; } 
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        [JsonProperty("currency")]
        public string Currency { get; set; } 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public int Id { get; set; } 
        /// <summary>
        /// Gets or Sets IsOneOffCharge
        /// </summary>
        [DataMember(Name="is_one_off_charge", EmitDefaultValue=false)]
        [JsonProperty("is_one_off_charge")]
        public bool IsOneOffCharge { get; set; } 
        /// <summary>
        /// Gets or Sets IsPaid
        /// </summary>
        [DataMember(Name="is_paid", EmitDefaultValue=false)]
        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; } 
        /// <summary>
        /// Gets or Sets PayoutDate
        /// </summary>
        [DataMember(Name="payout_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        [JsonProperty("payout_date")]
        public DateTime PayoutDate { get; set; } 
        /// <summary>
        /// Gets or Sets ReceiptUrl
        /// </summary>
        [DataMember(Name="receipt_url", EmitDefaultValue=false)]
        [JsonProperty("receipt_url")]
        public string ReceiptUrl { get; set; } 
        /// <summary>
        /// Gets or Sets SubscriptionId
        /// </summary>
        [DataMember(Name="subscription_id", EmitDefaultValue=false)]
        [JsonProperty("subscription_id")]
        public int SubscriptionId { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Payment {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsOneOffCharge: ").Append(IsOneOffCharge).Append("\n");
            sb.Append("  IsPaid: ").Append(IsPaid).Append("\n");
            sb.Append("  PayoutDate: ").Append(PayoutDate).Append("\n");
            sb.Append("  ReceiptUrl: ").Append(ReceiptUrl).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
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
        /// <returns>Payment object</returns>
        public static Payment FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Payment>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Payment object</returns>
        public Payment DuplicatePayment()
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
            return this.Equals(input as Payment);
        }

        /// <summary>
        /// Returns true if Payment instances are equal
        /// </summary>
        /// <param name="input">Instance of Payment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Payment input)
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
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsOneOffCharge == input.IsOneOffCharge ||
                    (this.IsOneOffCharge != null &&
                    this.IsOneOffCharge.Equals(input.IsOneOffCharge))
                ) && 
                (
                    this.IsPaid == input.IsPaid ||
                    (this.IsPaid != null &&
                    this.IsPaid.Equals(input.IsPaid))
                ) && 
                (
                    this.PayoutDate == input.PayoutDate ||
                    (this.PayoutDate != null &&
                    this.PayoutDate.Equals(input.PayoutDate))
                ) && 
                (
                    this.ReceiptUrl == input.ReceiptUrl ||
                    (this.ReceiptUrl != null &&
                    this.ReceiptUrl.Equals(input.ReceiptUrl))
                ) && 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
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
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsOneOffCharge != null)
                    hashCode = hashCode * 59 + this.IsOneOffCharge.GetHashCode();
                if (this.IsPaid != null)
                    hashCode = hashCode * 59 + this.IsPaid.GetHashCode();
                if (this.PayoutDate != null)
                    hashCode = hashCode * 59 + this.PayoutDate.GetHashCode();
                if (this.ReceiptUrl != null)
                    hashCode = hashCode * 59 + this.ReceiptUrl.GetHashCode();
                if (this.SubscriptionId != null)
                    hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
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
