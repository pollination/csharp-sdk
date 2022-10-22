/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.31.0
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
        /// The type of subscription
        /// </summary>
        /// <value>The type of subscription</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public PlanType Type { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Subscription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        /// <param name="billingInfo">The billing info for the subscription.</param>
        /// <param name="externalId">The ID of this subscription.</param>
        /// <param name="id">The unique ID of this subscription (required).</param>
        /// <param name="owner">The owner of the repository (required).</param>
        /// <param name="periodEnd">The end of the current subscription period (required).</param>
        /// <param name="periodStart">The start of the current subscription period (required).</param>
        /// <param name="planMultiplier">The number of times to multiply the plan limit by (default to 1).</param>
        /// <param name="planSlug">The slug of the plan used to create this subscription (required).</param>
        public Subscription
        (
           Guid id, AccountPublic owner, DateTime periodEnd, DateTime periodStart, string planSlug, // Required parameters
           BillingInfo billingInfo= default, string externalId= default, int planMultiplier = 1 // Optional parameters
        )// BaseClass
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Subscription and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "owner" is required (not null)
            if (owner == null)
            {
                throw new InvalidDataException("owner is a required property for Subscription and cannot be null");
            }
            else
            {
                this.Owner = owner;
            }
            
            // to ensure "periodEnd" is required (not null)
            if (periodEnd == null)
            {
                throw new InvalidDataException("periodEnd is a required property for Subscription and cannot be null");
            }
            else
            {
                this.PeriodEnd = periodEnd;
            }
            
            // to ensure "periodStart" is required (not null)
            if (periodStart == null)
            {
                throw new InvalidDataException("periodStart is a required property for Subscription and cannot be null");
            }
            else
            {
                this.PeriodStart = periodStart;
            }
            
            // to ensure "planSlug" is required (not null)
            if (planSlug == null)
            {
                throw new InvalidDataException("planSlug is a required property for Subscription and cannot be null");
            }
            else
            {
                this.PlanSlug = planSlug;
            }
            
            this.BillingInfo = billingInfo;
            this.ExternalId = externalId;
            // use default value if no "planMultiplier" provided
            if (planMultiplier == null)
            {
                this.PlanMultiplier =1;
            }
            else
            {
                this.PlanMultiplier = planMultiplier;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The billing info for the subscription
        /// </summary>
        /// <value>The billing info for the subscription</value>
        [DataMember(Name="billing_info", EmitDefaultValue=false)]
        [JsonProperty("billing_info")]
        public BillingInfo BillingInfo { get; set; } 
        /// <summary>
        /// The ID of this subscription
        /// </summary>
        /// <value>The ID of this subscription</value>
        [DataMember(Name="external_id", EmitDefaultValue=false)]
        [JsonProperty("external_id")]
        public string ExternalId { get; set; } 
        /// <summary>
        /// The unique ID of this subscription
        /// </summary>
        /// <value>The unique ID of this subscription</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public Guid Id { get; set; } 
        /// <summary>
        /// The owner of the repository
        /// </summary>
        /// <value>The owner of the repository</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        [JsonProperty("owner")]
        public AccountPublic Owner { get; set; } 
        /// <summary>
        /// The end of the current subscription period
        /// </summary>
        /// <value>The end of the current subscription period</value>
        [DataMember(Name="period_end", EmitDefaultValue=false)]
        [JsonProperty("period_end")]
        public DateTime PeriodEnd { get; set; } 
        /// <summary>
        /// The start of the current subscription period
        /// </summary>
        /// <value>The start of the current subscription period</value>
        [DataMember(Name="period_start", EmitDefaultValue=false)]
        [JsonProperty("period_start")]
        public DateTime PeriodStart { get; set; } 
        /// <summary>
        /// The number of times to multiply the plan limit by
        /// </summary>
        /// <value>The number of times to multiply the plan limit by</value>
        [DataMember(Name="plan_multiplier", EmitDefaultValue=false)]
        [JsonProperty("plan_multiplier")]
        public int PlanMultiplier { get; set; }  = 1;
        /// <summary>
        /// The slug of the plan used to create this subscription
        /// </summary>
        /// <value>The slug of the plan used to create this subscription</value>
        [DataMember(Name="plan_slug", EmitDefaultValue=false)]
        [JsonProperty("plan_slug")]
        public string PlanSlug { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subscription {\n");
            sb.Append("  BillingInfo: ").Append(BillingInfo).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  PeriodEnd: ").Append(PeriodEnd).Append("\n");
            sb.Append("  PeriodStart: ").Append(PeriodStart).Append("\n");
            sb.Append("  PlanMultiplier: ").Append(PlanMultiplier).Append("\n");
            sb.Append("  PlanSlug: ").Append(PlanSlug).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
                    this.BillingInfo == input.BillingInfo ||
                    (this.BillingInfo != null &&
                    this.BillingInfo.Equals(input.BillingInfo))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
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
                    this.PlanMultiplier == input.PlanMultiplier ||
                    (this.PlanMultiplier != null &&
                    this.PlanMultiplier.Equals(input.PlanMultiplier))
                ) && 
                (
                    this.PlanSlug == input.PlanSlug ||
                    (this.PlanSlug != null &&
                    this.PlanSlug.Equals(input.PlanSlug))
                ) && 
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
                int hashCode = 41;
                if (this.BillingInfo != null)
                    hashCode = hashCode * 59 + this.BillingInfo.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.PeriodEnd != null)
                    hashCode = hashCode * 59 + this.PeriodEnd.GetHashCode();
                if (this.PeriodStart != null)
                    hashCode = hashCode * 59 + this.PeriodStart.GetHashCode();
                if (this.PlanMultiplier != null)
                    hashCode = hashCode * 59 + this.PlanMultiplier.GetHashCode();
                if (this.PlanSlug != null)
                    hashCode = hashCode * 59 + this.PlanSlug.GetHashCode();
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
            yield break;
        }
    }

}
