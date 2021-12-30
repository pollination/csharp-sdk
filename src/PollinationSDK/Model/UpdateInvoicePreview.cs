/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.22.0
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
    /// UpdateInvoicePreview
    /// </summary>
    [DataContract]
    public partial class UpdateInvoicePreview :  IEquatable<UpdateInvoicePreview>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInvoicePreview" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateInvoicePreview() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInvoicePreview" /> class.
        /// </summary>
        /// <param name="exceededQuotas">A list of quotas that would be exceeded by the update.</param>
        /// <param name="immediate">The invoice that will be finalized right after changes are applied (required).</param>
        /// <param name="paymentMethod">The payment method that will be billed when this invoice is due..</param>
        /// <param name="upcoming">The invoice that will be finalized at the end of the current billing cycle (required).</param>
        public UpdateInvoicePreview
        (
           InvoicePreview immediate, InvoicePreview upcoming, // Required parameters
           List<Quota> exceededQuotas= default, CardPublic paymentMethod= default // Optional parameters
        )// BaseClass
        {
            // to ensure "immediate" is required (not null)
            if (immediate == null)
            {
                throw new InvalidDataException("immediate is a required property for UpdateInvoicePreview and cannot be null");
            }
            else
            {
                this.Immediate = immediate;
            }
            
            // to ensure "upcoming" is required (not null)
            if (upcoming == null)
            {
                throw new InvalidDataException("upcoming is a required property for UpdateInvoicePreview and cannot be null");
            }
            else
            {
                this.Upcoming = upcoming;
            }
            
            this.ExceededQuotas = exceededQuotas;
            this.PaymentMethod = paymentMethod;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// A list of quotas that would be exceeded by the update
        /// </summary>
        /// <value>A list of quotas that would be exceeded by the update</value>
        [DataMember(Name="exceeded_quotas", EmitDefaultValue=false)]
        [JsonProperty("exceeded_quotas")]
        public List<Quota> ExceededQuotas { get; set; } 
        /// <summary>
        /// The invoice that will be finalized right after changes are applied
        /// </summary>
        /// <value>The invoice that will be finalized right after changes are applied</value>
        [DataMember(Name="immediate", EmitDefaultValue=false)]
        [JsonProperty("immediate")]
        public InvoicePreview Immediate { get; set; } 
        /// <summary>
        /// The payment method that will be billed when this invoice is due.
        /// </summary>
        /// <value>The payment method that will be billed when this invoice is due.</value>
        [DataMember(Name="payment_method", EmitDefaultValue=false)]
        [JsonProperty("payment_method")]
        public CardPublic PaymentMethod { get; set; } 
        /// <summary>
        /// The invoice that will be finalized at the end of the current billing cycle
        /// </summary>
        /// <value>The invoice that will be finalized at the end of the current billing cycle</value>
        [DataMember(Name="upcoming", EmitDefaultValue=false)]
        [JsonProperty("upcoming")]
        public InvoicePreview Upcoming { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInvoicePreview {\n");
            sb.Append("  ExceededQuotas: ").Append(ExceededQuotas).Append("\n");
            sb.Append("  Immediate: ").Append(Immediate).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  Upcoming: ").Append(Upcoming).Append("\n");
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
        /// <returns>UpdateInvoicePreview object</returns>
        public static UpdateInvoicePreview FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<UpdateInvoicePreview>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>UpdateInvoicePreview object</returns>
        public UpdateInvoicePreview DuplicateUpdateInvoicePreview()
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
            return this.Equals(input as UpdateInvoicePreview);
        }

        /// <summary>
        /// Returns true if UpdateInvoicePreview instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateInvoicePreview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateInvoicePreview input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.ExceededQuotas == input.ExceededQuotas ||
                    this.ExceededQuotas != null &&
                    input.ExceededQuotas != null &&
                    this.ExceededQuotas.SequenceEqual(input.ExceededQuotas)
                ) && 
                (
                    this.Immediate == input.Immediate ||
                    (this.Immediate != null &&
                    this.Immediate.Equals(input.Immediate))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.Upcoming == input.Upcoming ||
                    (this.Upcoming != null &&
                    this.Upcoming.Equals(input.Upcoming))
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
                if (this.ExceededQuotas != null)
                    hashCode = hashCode * 59 + this.ExceededQuotas.GetHashCode();
                if (this.Immediate != null)
                    hashCode = hashCode * 59 + this.Immediate.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.Upcoming != null)
                    hashCode = hashCode * 59 + this.Upcoming.GetHashCode();
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
