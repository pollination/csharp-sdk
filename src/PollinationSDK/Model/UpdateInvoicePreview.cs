/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
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


namespace PollinationSDK
{
    /// <summary>
    /// UpdateInvoicePreview
    /// </summary>
    [DataContract(Name = "UpdateInvoicePreview")]
    public partial class UpdateInvoicePreview : OpenAPIGenBaseModel, IEquatable<UpdateInvoicePreview>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInvoicePreview" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateInvoicePreview() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "UpdateInvoicePreview";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInvoicePreview" /> class.
        /// </summary>
        /// <param name="immediate">The invoice that will be finalized right after changes are applied (required).</param>
        /// <param name="upcoming">The invoice that will be finalized at the end of the current billing cycle (required).</param>
        /// <param name="paymentMethod">The payment method that will be billed when this invoice is due..</param>
        /// <param name="exceededQuotas">A list of quotas that would be exceeded by the update.</param>
        public UpdateInvoicePreview
        (
           InvoicePreview immediate, InvoicePreview upcoming, // Required parameters
           CardPublic paymentMethod= default, List<Quota> exceededQuotas= default // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "immediate" is required (not null)
            this.Immediate = immediate ?? throw new ArgumentNullException("immediate is a required property for UpdateInvoicePreview and cannot be null");
            // to ensure "upcoming" is required (not null)
            this.Upcoming = upcoming ?? throw new ArgumentNullException("upcoming is a required property for UpdateInvoicePreview and cannot be null");
            this.PaymentMethod = paymentMethod;
            this.ExceededQuotas = exceededQuotas;

            // Set non-required readonly properties with defaultValue
            this.Type = "UpdateInvoicePreview";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; protected internal set; }  = "UpdateInvoicePreview";

        /// <summary>
        /// The invoice that will be finalized right after changes are applied
        /// </summary>
        /// <value>The invoice that will be finalized right after changes are applied</value>
        [DataMember(Name = "immediate", IsRequired = true, EmitDefaultValue = false)]
        public InvoicePreview Immediate { get; set; } 
        /// <summary>
        /// The invoice that will be finalized at the end of the current billing cycle
        /// </summary>
        /// <value>The invoice that will be finalized at the end of the current billing cycle</value>
        [DataMember(Name = "upcoming", IsRequired = true, EmitDefaultValue = false)]
        public InvoicePreview Upcoming { get; set; } 
        /// <summary>
        /// The payment method that will be billed when this invoice is due.
        /// </summary>
        /// <value>The payment method that will be billed when this invoice is due.</value>
        [DataMember(Name = "payment_method", EmitDefaultValue = false)]
        public CardPublic PaymentMethod { get; set; } 
        /// <summary>
        /// A list of quotas that would be exceeded by the update
        /// </summary>
        /// <value>A list of quotas that would be exceeded by the update</value>
        [DataMember(Name = "exceeded_quotas", EmitDefaultValue = false)]
        public List<Quota> ExceededQuotas { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "UpdateInvoicePreview";
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
            sb.Append("UpdateInvoicePreview:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Immediate: ").Append(Immediate).Append("\n");
            sb.Append("  Upcoming: ").Append(Upcoming).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  ExceededQuotas: ").Append(ExceededQuotas).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>UpdateInvoicePreview object</returns>
        public static UpdateInvoicePreview FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<UpdateInvoicePreview>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>UpdateInvoicePreview object</returns>
        public virtual UpdateInvoicePreview DuplicateUpdateInvoicePreview()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateUpdateInvoicePreview();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateUpdateInvoicePreview();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
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
            return base.Equals(input) && 
                (
                    this.Immediate == input.Immediate ||
                    (this.Immediate != null &&
                    this.Immediate.Equals(input.Immediate))
                ) && base.Equals(input) && 
                (
                    this.Upcoming == input.Upcoming ||
                    (this.Upcoming != null &&
                    this.Upcoming.Equals(input.Upcoming))
                ) && base.Equals(input) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && base.Equals(input) && 
                (
                    this.ExceededQuotas == input.ExceededQuotas ||
                    this.ExceededQuotas != null &&
                    input.ExceededQuotas != null &&
                    this.ExceededQuotas.SequenceEqual(input.ExceededQuotas)
                ) && base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
                if (this.Immediate != null)
                    hashCode = hashCode * 59 + this.Immediate.GetHashCode();
                if (this.Upcoming != null)
                    hashCode = hashCode * 59 + this.Upcoming.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.ExceededQuotas != null)
                    hashCode = hashCode * 59 + this.ExceededQuotas.GetHashCode();
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
            Regex regexType = new Regex(@"^UpdateInvoicePreview$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
