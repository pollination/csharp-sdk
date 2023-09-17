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
    /// BillingInfo
    /// </summary>
    [DataContract]
    public partial class BillingInfo :  IEquatable<BillingInfo>, IValidatableObject
    {
        /// <summary>
        /// The reason the subscription was paused
        /// </summary>
        /// <value>The reason the subscription was paused</value>
        [DataMember(Name="paused_reason", EmitDefaultValue=false)]
        public PausedReason? PausedReason { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillingInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingInfo" /> class.
        /// </summary>
        /// <param name="cancelUrl">The url to cancel the subscription (required).</param>
        /// <param name="lastPayment">The last payment made (required).</param>
        /// <param name="nextPayment">The last payment made.</param>
        /// <param name="pausedAt">The date the subscription was paused.</param>
        /// <param name="pausedFrom">The date the subscription will be paused from.</param>
        /// <param name="pausedReason">The reason the subscription was paused.</param>
        /// <param name="paymentInformation">The payment method used (required).</param>
        /// <param name="signupDate">The date the subscription was created (required).</param>
        /// <param name="updateUrl">The url to update the billing info (required).</param>
        /// <param name="userEmail">The email used for billing on this subscription (required).</param>
        public BillingInfo
        (
           string cancelUrl, SubscriptionPayment lastPayment, PaymentMethod paymentInformation, DateTime signupDate, string updateUrl, string userEmail, // Required parameters
           SubscriptionPayment nextPayment= default, DateTime pausedAt= default, DateTime pausedFrom= default, PausedReason? pausedReason= default // Optional parameters
        )// BaseClass
        {
            // to ensure "cancelUrl" is required (not null)
            if (cancelUrl == null)
            {
                throw new InvalidDataException("cancelUrl is a required property for BillingInfo and cannot be null");
            }
            else
            {
                this.CancelUrl = cancelUrl;
            }
            
            // to ensure "lastPayment" is required (not null)
            if (lastPayment == null)
            {
                throw new InvalidDataException("lastPayment is a required property for BillingInfo and cannot be null");
            }
            else
            {
                this.LastPayment = lastPayment;
            }
            
            // to ensure "paymentInformation" is required (not null)
            if (paymentInformation == null)
            {
                throw new InvalidDataException("paymentInformation is a required property for BillingInfo and cannot be null");
            }
            else
            {
                this.PaymentInformation = paymentInformation;
            }
            
            // to ensure "signupDate" is required (not null)
            if (signupDate == null)
            {
                throw new InvalidDataException("signupDate is a required property for BillingInfo and cannot be null");
            }
            else
            {
                this.SignupDate = signupDate;
            }
            
            // to ensure "updateUrl" is required (not null)
            if (updateUrl == null)
            {
                throw new InvalidDataException("updateUrl is a required property for BillingInfo and cannot be null");
            }
            else
            {
                this.UpdateUrl = updateUrl;
            }
            
            // to ensure "userEmail" is required (not null)
            if (userEmail == null)
            {
                throw new InvalidDataException("userEmail is a required property for BillingInfo and cannot be null");
            }
            else
            {
                this.UserEmail = userEmail;
            }
            
            this.NextPayment = nextPayment;
            this.PausedAt = pausedAt;
            this.PausedFrom = pausedFrom;
            this.PausedReason = pausedReason;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The url to cancel the subscription
        /// </summary>
        /// <value>The url to cancel the subscription</value>
        [DataMember(Name="cancel_url", EmitDefaultValue=false)]
        [JsonProperty("cancel_url")]
        public string CancelUrl { get; set; } 
        /// <summary>
        /// The last payment made
        /// </summary>
        /// <value>The last payment made</value>
        [DataMember(Name="last_payment", EmitDefaultValue=false)]
        [JsonProperty("last_payment")]
        public SubscriptionPayment LastPayment { get; set; } 
        /// <summary>
        /// The last payment made
        /// </summary>
        /// <value>The last payment made</value>
        [DataMember(Name="next_payment", EmitDefaultValue=false)]
        [JsonProperty("next_payment")]
        public SubscriptionPayment NextPayment { get; set; } 
        /// <summary>
        /// The date the subscription was paused
        /// </summary>
        /// <value>The date the subscription was paused</value>
        [DataMember(Name="paused_at", EmitDefaultValue=false)]
        [JsonProperty("paused_at")]
        public DateTime PausedAt { get; set; } 
        /// <summary>
        /// The date the subscription will be paused from
        /// </summary>
        /// <value>The date the subscription will be paused from</value>
        [DataMember(Name="paused_from", EmitDefaultValue=false)]
        [JsonProperty("paused_from")]
        public DateTime PausedFrom { get; set; } 
        /// <summary>
        /// The payment method used
        /// </summary>
        /// <value>The payment method used</value>
        [DataMember(Name="payment_information", EmitDefaultValue=false)]
        [JsonProperty("payment_information")]
        public PaymentMethod PaymentInformation { get; set; } 
        /// <summary>
        /// The date the subscription was created
        /// </summary>
        /// <value>The date the subscription was created</value>
        [DataMember(Name="signup_date", EmitDefaultValue=false)]
        [JsonProperty("signup_date")]
        public DateTime SignupDate { get; set; } 
        /// <summary>
        /// The url to update the billing info
        /// </summary>
        /// <value>The url to update the billing info</value>
        [DataMember(Name="update_url", EmitDefaultValue=false)]
        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; } 
        /// <summary>
        /// The email used for billing on this subscription
        /// </summary>
        /// <value>The email used for billing on this subscription</value>
        [DataMember(Name="user_email", EmitDefaultValue=false)]
        [JsonProperty("user_email")]
        public string UserEmail { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingInfo {\n");
            sb.Append("  CancelUrl: ").Append(CancelUrl).Append("\n");
            sb.Append("  LastPayment: ").Append(LastPayment).Append("\n");
            sb.Append("  NextPayment: ").Append(NextPayment).Append("\n");
            sb.Append("  PausedAt: ").Append(PausedAt).Append("\n");
            sb.Append("  PausedFrom: ").Append(PausedFrom).Append("\n");
            sb.Append("  PausedReason: ").Append(PausedReason).Append("\n");
            sb.Append("  PaymentInformation: ").Append(PaymentInformation).Append("\n");
            sb.Append("  SignupDate: ").Append(SignupDate).Append("\n");
            sb.Append("  UpdateUrl: ").Append(UpdateUrl).Append("\n");
            sb.Append("  UserEmail: ").Append(UserEmail).Append("\n");
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
        /// <returns>BillingInfo object</returns>
        public static BillingInfo FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<BillingInfo>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>BillingInfo object</returns>
        public BillingInfo DuplicateBillingInfo()
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
            return this.Equals(input as BillingInfo);
        }

        /// <summary>
        /// Returns true if BillingInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingInfo input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.CancelUrl == input.CancelUrl ||
                    (this.CancelUrl != null &&
                    this.CancelUrl.Equals(input.CancelUrl))
                ) && 
                (
                    this.LastPayment == input.LastPayment ||
                    (this.LastPayment != null &&
                    this.LastPayment.Equals(input.LastPayment))
                ) && 
                (
                    this.NextPayment == input.NextPayment ||
                    (this.NextPayment != null &&
                    this.NextPayment.Equals(input.NextPayment))
                ) && 
                (
                    this.PausedAt == input.PausedAt ||
                    (this.PausedAt != null &&
                    this.PausedAt.Equals(input.PausedAt))
                ) && 
                (
                    this.PausedFrom == input.PausedFrom ||
                    (this.PausedFrom != null &&
                    this.PausedFrom.Equals(input.PausedFrom))
                ) && 
                (
                    this.PausedReason == input.PausedReason ||
                    (this.PausedReason != null &&
                    this.PausedReason.Equals(input.PausedReason))
                ) && 
                (
                    this.PaymentInformation == input.PaymentInformation ||
                    (this.PaymentInformation != null &&
                    this.PaymentInformation.Equals(input.PaymentInformation))
                ) && 
                (
                    this.SignupDate == input.SignupDate ||
                    (this.SignupDate != null &&
                    this.SignupDate.Equals(input.SignupDate))
                ) && 
                (
                    this.UpdateUrl == input.UpdateUrl ||
                    (this.UpdateUrl != null &&
                    this.UpdateUrl.Equals(input.UpdateUrl))
                ) && 
                (
                    this.UserEmail == input.UserEmail ||
                    (this.UserEmail != null &&
                    this.UserEmail.Equals(input.UserEmail))
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
                if (this.CancelUrl != null)
                    hashCode = hashCode * 59 + this.CancelUrl.GetHashCode();
                if (this.LastPayment != null)
                    hashCode = hashCode * 59 + this.LastPayment.GetHashCode();
                if (this.NextPayment != null)
                    hashCode = hashCode * 59 + this.NextPayment.GetHashCode();
                if (this.PausedAt != null)
                    hashCode = hashCode * 59 + this.PausedAt.GetHashCode();
                if (this.PausedFrom != null)
                    hashCode = hashCode * 59 + this.PausedFrom.GetHashCode();
                if (this.PausedReason != null)
                    hashCode = hashCode * 59 + this.PausedReason.GetHashCode();
                if (this.PaymentInformation != null)
                    hashCode = hashCode * 59 + this.PaymentInformation.GetHashCode();
                if (this.SignupDate != null)
                    hashCode = hashCode * 59 + this.SignupDate.GetHashCode();
                if (this.UpdateUrl != null)
                    hashCode = hashCode * 59 + this.UpdateUrl.GetHashCode();
                if (this.UserEmail != null)
                    hashCode = hashCode * 59 + this.UserEmail.GetHashCode();
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
