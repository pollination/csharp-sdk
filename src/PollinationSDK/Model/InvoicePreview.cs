/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.18.1-beta.0
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
    /// InvoicePreview
    /// </summary>
    [DataContract]
    public partial class InvoicePreview :  IEquatable<InvoicePreview>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public InvoiceStatus Status { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePreview" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvoicePreview() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePreview" /> class.
        /// </summary>
        /// <param name="autoAdvance">autoAdvance.</param>
        /// <param name="collectionMethod">collectionMethod (required).</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="customer">customer (required).</param>
        /// <param name="description">description.</param>
        /// <param name="hostedInvoiceUrl">hostedInvoiceUrl.</param>
        /// <param name="lines">lines (required).</param>
        /// <param name="paymentMethod">The payment method that will be billed when this invoice is due. (required).</param>
        /// <param name="periodEnd">periodEnd (required).</param>
        /// <param name="periodStart">periodStart (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="statusTransitions">statusTransitions (required).</param>
        /// <param name="subscription">subscription (required).</param>
        /// <param name="total">total (required).</param>
        public InvoicePreview
        (
           string collectionMethod, string currency, string customer, LineItemList lines, CardPublic paymentMethod, DateTime periodEnd, DateTime periodStart, InvoiceStatus status, InvoiceStatusTransitions statusTransitions, string subscription, int total, // Required parameters
           bool autoAdvance= default, string description= default, string hostedInvoiceUrl= default // Optional parameters
        )// BaseClass
        {
            // to ensure "collectionMethod" is required (not null)
            if (collectionMethod == null)
            {
                throw new InvalidDataException("collectionMethod is a required property for InvoicePreview and cannot be null");
            }
            else
            {
                this.CollectionMethod = collectionMethod;
            }
            
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for InvoicePreview and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }
            
            // to ensure "customer" is required (not null)
            if (customer == null)
            {
                throw new InvalidDataException("customer is a required property for InvoicePreview and cannot be null");
            }
            else
            {
                this.Customer = customer;
            }
            
            // to ensure "lines" is required (not null)
            if (lines == null)
            {
                throw new InvalidDataException("lines is a required property for InvoicePreview and cannot be null");
            }
            else
            {
                this.Lines = lines;
            }
            
            // to ensure "paymentMethod" is required (not null)
            if (paymentMethod == null)
            {
                throw new InvalidDataException("paymentMethod is a required property for InvoicePreview and cannot be null");
            }
            else
            {
                this.PaymentMethod = paymentMethod;
            }
            
            // to ensure "periodEnd" is required (not null)
            if (periodEnd == null)
            {
                throw new InvalidDataException("periodEnd is a required property for InvoicePreview and cannot be null");
            }
            else
            {
                this.PeriodEnd = periodEnd;
            }
            
            // to ensure "periodStart" is required (not null)
            if (periodStart == null)
            {
                throw new InvalidDataException("periodStart is a required property for InvoicePreview and cannot be null");
            }
            else
            {
                this.PeriodStart = periodStart;
            }
            
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for InvoicePreview and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            
            // to ensure "statusTransitions" is required (not null)
            if (statusTransitions == null)
            {
                throw new InvalidDataException("statusTransitions is a required property for InvoicePreview and cannot be null");
            }
            else
            {
                this.StatusTransitions = statusTransitions;
            }
            
            // to ensure "subscription" is required (not null)
            if (subscription == null)
            {
                throw new InvalidDataException("subscription is a required property for InvoicePreview and cannot be null");
            }
            else
            {
                this.Subscription = subscription;
            }
            
            // to ensure "total" is required (not null)
            if (total == null)
            {
                throw new InvalidDataException("total is a required property for InvoicePreview and cannot be null");
            }
            else
            {
                this.Total = total;
            }
            
            this.AutoAdvance = autoAdvance;
            this.Description = description;
            this.HostedInvoiceUrl = hostedInvoiceUrl;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets AutoAdvance
        /// </summary>
        [DataMember(Name="auto_advance", EmitDefaultValue=false)]
        [JsonProperty("auto_advance")]
        public bool AutoAdvance { get; set; } 
        /// <summary>
        /// Gets or Sets CollectionMethod
        /// </summary>
        [DataMember(Name="collection_method", EmitDefaultValue=false)]
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; } 
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        [JsonProperty("currency")]
        public string Currency { get; set; } 
        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        [JsonProperty("customer")]
        public string Customer { get; set; } 
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; } 
        /// <summary>
        /// Gets or Sets HostedInvoiceUrl
        /// </summary>
        [DataMember(Name="hosted_invoice_url", EmitDefaultValue=false)]
        [JsonProperty("hosted_invoice_url")]
        public string HostedInvoiceUrl { get; set; } 
        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name="lines", EmitDefaultValue=false)]
        [JsonProperty("lines")]
        public LineItemList Lines { get; set; } 
        /// <summary>
        /// The payment method that will be billed when this invoice is due.
        /// </summary>
        /// <value>The payment method that will be billed when this invoice is due.</value>
        [DataMember(Name="payment_method", EmitDefaultValue=false)]
        [JsonProperty("payment_method")]
        public CardPublic PaymentMethod { get; set; } 
        /// <summary>
        /// Gets or Sets PeriodEnd
        /// </summary>
        [DataMember(Name="period_end", EmitDefaultValue=false)]
        [JsonProperty("period_end")]
        public DateTime PeriodEnd { get; set; } 
        /// <summary>
        /// Gets or Sets PeriodStart
        /// </summary>
        [DataMember(Name="period_start", EmitDefaultValue=false)]
        [JsonProperty("period_start")]
        public DateTime PeriodStart { get; set; } 
        /// <summary>
        /// Gets or Sets StatusTransitions
        /// </summary>
        [DataMember(Name="status_transitions", EmitDefaultValue=false)]
        [JsonProperty("status_transitions")]
        public InvoiceStatusTransitions StatusTransitions { get; set; } 
        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        [JsonProperty("subscription")]
        public string Subscription { get; set; } 
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        [JsonProperty("total")]
        public int Total { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoicePreview {\n");
            sb.Append("  AutoAdvance: ").Append(AutoAdvance).Append("\n");
            sb.Append("  CollectionMethod: ").Append(CollectionMethod).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  HostedInvoiceUrl: ").Append(HostedInvoiceUrl).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  PeriodEnd: ").Append(PeriodEnd).Append("\n");
            sb.Append("  PeriodStart: ").Append(PeriodStart).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusTransitions: ").Append(StatusTransitions).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
        /// <returns>InvoicePreview object</returns>
        public static InvoicePreview FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<InvoicePreview>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>InvoicePreview object</returns>
        public InvoicePreview DuplicateInvoicePreview()
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
            return this.Equals(input as InvoicePreview);
        }

        /// <summary>
        /// Returns true if InvoicePreview instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoicePreview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoicePreview input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.AutoAdvance == input.AutoAdvance ||
                    (this.AutoAdvance != null &&
                    this.AutoAdvance.Equals(input.AutoAdvance))
                ) && 
                (
                    this.CollectionMethod == input.CollectionMethod ||
                    (this.CollectionMethod != null &&
                    this.CollectionMethod.Equals(input.CollectionMethod))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.HostedInvoiceUrl == input.HostedInvoiceUrl ||
                    (this.HostedInvoiceUrl != null &&
                    this.HostedInvoiceUrl.Equals(input.HostedInvoiceUrl))
                ) && 
                (
                    this.Lines == input.Lines ||
                    (this.Lines != null &&
                    this.Lines.Equals(input.Lines))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.PeriodEnd == input.PeriodEnd ||
                    (this.PeriodEnd != null &&
                    this.PeriodEnd.Equals(input.PeriodEnd))
                ) && 
                (
                    this.PeriodStart == input.PeriodStart ||
                    (this.PeriodStart != null &&
                    this.PeriodStart.Equals(input.PeriodStart))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusTransitions == input.StatusTransitions ||
                    (this.StatusTransitions != null &&
                    this.StatusTransitions.Equals(input.StatusTransitions))
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.AutoAdvance != null)
                    hashCode = hashCode * 59 + this.AutoAdvance.GetHashCode();
                if (this.CollectionMethod != null)
                    hashCode = hashCode * 59 + this.CollectionMethod.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.HostedInvoiceUrl != null)
                    hashCode = hashCode * 59 + this.HostedInvoiceUrl.GetHashCode();
                if (this.Lines != null)
                    hashCode = hashCode * 59 + this.Lines.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.PeriodEnd != null)
                    hashCode = hashCode * 59 + this.PeriodEnd.GetHashCode();
                if (this.PeriodStart != null)
                    hashCode = hashCode * 59 + this.PeriodStart.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusTransitions != null)
                    hashCode = hashCode * 59 + this.StatusTransitions.GetHashCode();
                if (this.Subscription != null)
                    hashCode = hashCode * 59 + this.Subscription.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
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
