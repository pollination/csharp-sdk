/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.27.2
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
    /// SubscriptionPlan
    /// </summary>
    [DataContract]
    public partial class SubscriptionPlan :  IEquatable<SubscriptionPlan>, IValidatableObject
    {
        /// <summary>
        /// The type of plan
        /// </summary>
        /// <value>The type of plan</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public PlanType Type { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPlan" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionPlan() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPlan" /> class.
        /// </summary>
        /// <param name="accountTypes">The types of account to which the plan can be applied (required).</param>
        /// <param name="billingOptions">The billing options for this plan.</param>
        /// <param name="name">A name of the config plan used to create this subscription (required).</param>
        /// <param name="quotas">A list of quota plans for a given subscription.</param>
        /// <param name="slug">A slug of the config plan used to create this subscription (required).</param>
        public SubscriptionPlan
        (
           List<AccountType> accountTypes, string name, string slug, // Required parameters
           List<BillingOption> billingOptions= default, List<QuotaPlan> quotas= default // Optional parameters
        )// BaseClass
        {
            // to ensure "accountTypes" is required (not null)
            if (accountTypes == null)
            {
                throw new InvalidDataException("accountTypes is a required property for SubscriptionPlan and cannot be null");
            }
            else
            {
                this.AccountTypes = accountTypes;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for SubscriptionPlan and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "slug" is required (not null)
            if (slug == null)
            {
                throw new InvalidDataException("slug is a required property for SubscriptionPlan and cannot be null");
            }
            else
            {
                this.Slug = slug;
            }
            
            this.BillingOptions = billingOptions;
            this.Quotas = quotas;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The types of account to which the plan can be applied
        /// </summary>
        /// <value>The types of account to which the plan can be applied</value>
        [DataMember(Name="account_types", EmitDefaultValue=false)]
        [JsonProperty("account_types")]
        public List<AccountType> AccountTypes { get; set; } 
        /// <summary>
        /// The billing options for this plan
        /// </summary>
        /// <value>The billing options for this plan</value>
        [DataMember(Name="billing_options", EmitDefaultValue=false)]
        [JsonProperty("billing_options")]
        public List<BillingOption> BillingOptions { get; set; } 
        /// <summary>
        /// A name of the config plan used to create this subscription
        /// </summary>
        /// <value>A name of the config plan used to create this subscription</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// A list of quota plans for a given subscription
        /// </summary>
        /// <value>A list of quota plans for a given subscription</value>
        [DataMember(Name="quotas", EmitDefaultValue=false)]
        [JsonProperty("quotas")]
        public List<QuotaPlan> Quotas { get; set; } 
        /// <summary>
        /// A slug of the config plan used to create this subscription
        /// </summary>
        /// <value>A slug of the config plan used to create this subscription</value>
        [DataMember(Name="slug", EmitDefaultValue=false)]
        [JsonProperty("slug")]
        public string Slug { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionPlan {\n");
            sb.Append("  AccountTypes: ").Append(AccountTypes).Append("\n");
            sb.Append("  BillingOptions: ").Append(BillingOptions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Quotas: ").Append(Quotas).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
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
        /// <returns>SubscriptionPlan object</returns>
        public static SubscriptionPlan FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SubscriptionPlan>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SubscriptionPlan object</returns>
        public SubscriptionPlan DuplicateSubscriptionPlan()
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
            return this.Equals(input as SubscriptionPlan);
        }

        /// <summary>
        /// Returns true if SubscriptionPlan instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionPlan input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.AccountTypes == input.AccountTypes ||
                    this.AccountTypes != null &&
                    input.AccountTypes != null &&
                    this.AccountTypes.SequenceEqual(input.AccountTypes)
                ) && 
                (
                    this.BillingOptions == input.BillingOptions ||
                    this.BillingOptions != null &&
                    input.BillingOptions != null &&
                    this.BillingOptions.SequenceEqual(input.BillingOptions)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Quotas == input.Quotas ||
                    this.Quotas != null &&
                    input.Quotas != null &&
                    this.Quotas.SequenceEqual(input.Quotas)
                ) && 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
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
                if (this.AccountTypes != null)
                    hashCode = hashCode * 59 + this.AccountTypes.GetHashCode();
                if (this.BillingOptions != null)
                    hashCode = hashCode * 59 + this.BillingOptions.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Quotas != null)
                    hashCode = hashCode * 59 + this.Quotas.GetHashCode();
                if (this.Slug != null)
                    hashCode = hashCode * 59 + this.Slug.GetHashCode();
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
