/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.21.1
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
    /// Subscription
    /// </summary>
    [DataContract]
    public partial class Subscription :  IEquatable<Subscription>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Subscription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        /// <param name="cancelAtPeriodEnd">cancelAtPeriodEnd (required).</param>
        /// <param name="currentPeriodEnd">currentPeriodEnd (required).</param>
        /// <param name="currentPeriodStart">currentPeriodStart (required).</param>
        /// <param name="customer">customer (required).</param>
        /// <param name="defaultPaymentMethod">defaultPaymentMethod.</param>
        /// <param name="discount">discount.</param>
        /// <param name="id">id (required).</param>
        /// <param name="items">items (required).</param>
        /// <param name="latestInvoice">latestInvoice (required).</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="schedule">schedule.</param>
        public Subscription
        (
           bool cancelAtPeriodEnd, DateTime currentPeriodEnd, DateTime currentPeriodStart, string customer, string id, SubscriptionItemPublicList items, string latestInvoice, // Required parameters
           string defaultPaymentMethod= default, Discount discount= default, Object metadata= default, string schedule= default// Optional parameters
        )// BaseClass
        {
            // to ensure "cancelAtPeriodEnd" is required (not null)
            if (cancelAtPeriodEnd == null)
            {
                throw new InvalidDataException("cancelAtPeriodEnd is a required property for Subscription and cannot be null");
            }
            else
            {
                this.CancelAtPeriodEnd = cancelAtPeriodEnd;
            }
            
            // to ensure "currentPeriodEnd" is required (not null)
            if (currentPeriodEnd == null)
            {
                throw new InvalidDataException("currentPeriodEnd is a required property for Subscription and cannot be null");
            }
            else
            {
                this.CurrentPeriodEnd = currentPeriodEnd;
            }
            
            // to ensure "currentPeriodStart" is required (not null)
            if (currentPeriodStart == null)
            {
                throw new InvalidDataException("currentPeriodStart is a required property for Subscription and cannot be null");
            }
            else
            {
                this.CurrentPeriodStart = currentPeriodStart;
            }
            
            // to ensure "customer" is required (not null)
            if (customer == null)
            {
                throw new InvalidDataException("customer is a required property for Subscription and cannot be null");
            }
            else
            {
                this.Customer = customer;
            }
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Subscription and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new InvalidDataException("items is a required property for Subscription and cannot be null");
            }
            else
            {
                this.Items = items;
            }
            
            // to ensure "latestInvoice" is required (not null)
            if (latestInvoice == null)
            {
                throw new InvalidDataException("latestInvoice is a required property for Subscription and cannot be null");
            }
            else
            {
                this.LatestInvoice = latestInvoice;
            }
            
            this.DefaultPaymentMethod = defaultPaymentMethod;
            this.Discount = discount;
            this.Metadata = metadata;
            this.Schedule = schedule;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets CancelAtPeriodEnd
        /// </summary>
        [DataMember(Name="cancel_at_period_end", EmitDefaultValue=false)]
        [JsonProperty("cancel_at_period_end")]
        public bool CancelAtPeriodEnd { get; set; } 
        /// <summary>
        /// Gets or Sets CurrentPeriodEnd
        /// </summary>
        [DataMember(Name="current_period_end", EmitDefaultValue=false)]
        [JsonProperty("current_period_end")]
        public DateTime CurrentPeriodEnd { get; set; } 
        /// <summary>
        /// Gets or Sets CurrentPeriodStart
        /// </summary>
        [DataMember(Name="current_period_start", EmitDefaultValue=false)]
        [JsonProperty("current_period_start")]
        public DateTime CurrentPeriodStart { get; set; } 
        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        [JsonProperty("customer")]
        public string Customer { get; set; } 
        /// <summary>
        /// Gets or Sets DefaultPaymentMethod
        /// </summary>
        [DataMember(Name="default_payment_method", EmitDefaultValue=false)]
        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod { get; set; } 
        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name="discount", EmitDefaultValue=false)]
        [JsonProperty("discount")]
        public Discount Discount { get; set; } 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public string Id { get; set; } 
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        [JsonProperty("items")]
        public SubscriptionItemPublicList Items { get; set; } 
        /// <summary>
        /// Gets or Sets LatestInvoice
        /// </summary>
        [DataMember(Name="latest_invoice", EmitDefaultValue=false)]
        [JsonProperty("latest_invoice")]
        public string LatestInvoice { get; set; } 
        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        [JsonProperty("metadata")]
        public Object Metadata { get; set; } 
        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        [JsonProperty("schedule")]
        public string Schedule { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subscription {\n");
            sb.Append("  CancelAtPeriodEnd: ").Append(CancelAtPeriodEnd).Append("\n");
            sb.Append("  CurrentPeriodEnd: ").Append(CurrentPeriodEnd).Append("\n");
            sb.Append("  CurrentPeriodStart: ").Append(CurrentPeriodStart).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  DefaultPaymentMethod: ").Append(DefaultPaymentMethod).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  LatestInvoice: ").Append(LatestInvoice).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
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
        /// <returns>Subscription object</returns>
        public static Subscription FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Subscription>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Subscription object</returns>
        public Subscription DuplicateSubscription()
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
            return this.Equals(input as Subscription);
        }

        /// <summary>
        /// Returns true if Subscription instances are equal
        /// </summary>
        /// <param name="input">Instance of Subscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Subscription input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.CancelAtPeriodEnd == input.CancelAtPeriodEnd ||
                    (this.CancelAtPeriodEnd != null &&
                    this.CancelAtPeriodEnd.Equals(input.CancelAtPeriodEnd))
                ) && 
                (
                    this.CurrentPeriodEnd == input.CurrentPeriodEnd ||
                    (this.CurrentPeriodEnd != null &&
                    this.CurrentPeriodEnd.Equals(input.CurrentPeriodEnd))
                ) && 
                (
                    this.CurrentPeriodStart == input.CurrentPeriodStart ||
                    (this.CurrentPeriodStart != null &&
                    this.CurrentPeriodStart.Equals(input.CurrentPeriodStart))
                ) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && 
                (
                    this.DefaultPaymentMethod == input.DefaultPaymentMethod ||
                    (this.DefaultPaymentMethod != null &&
                    this.DefaultPaymentMethod.Equals(input.DefaultPaymentMethod))
                ) && 
                (
                    this.Discount == input.Discount ||
                    (this.Discount != null &&
                    this.Discount.Equals(input.Discount))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Items == input.Items ||
                    (this.Items != null &&
                    this.Items.Equals(input.Items))
                ) && 
                (
                    this.LatestInvoice == input.LatestInvoice ||
                    (this.LatestInvoice != null &&
                    this.LatestInvoice.Equals(input.LatestInvoice))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
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
                if (this.CancelAtPeriodEnd != null)
                    hashCode = hashCode * 59 + this.CancelAtPeriodEnd.GetHashCode();
                if (this.CurrentPeriodEnd != null)
                    hashCode = hashCode * 59 + this.CurrentPeriodEnd.GetHashCode();
                if (this.CurrentPeriodStart != null)
                    hashCode = hashCode * 59 + this.CurrentPeriodStart.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.DefaultPaymentMethod != null)
                    hashCode = hashCode * 59 + this.DefaultPaymentMethod.GetHashCode();
                if (this.Discount != null)
                    hashCode = hashCode * 59 + this.Discount.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.LatestInvoice != null)
                    hashCode = hashCode * 59 + this.LatestInvoice.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
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
