/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 1.1.0
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
    /// SubscriptionCreate
    /// </summary>
    [DataContract]
    public partial class SubscriptionCreate :  IEquatable<SubscriptionCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionCreate" /> class.
        /// </summary>
        /// <param name="account">The name of the account to create subscription for (required).</param>
        /// <param name="planId">The ID of the plan to subscribe to (required).</param>
        /// <param name="quantity">The number of subscriptions to create (default to 1).</param>
        public SubscriptionCreate
        (
           string account, int planId, // Required parameters
           int quantity = 1// Optional parameters
        )// BaseClass
        {
            // to ensure "account" is required (not null)
            if (account == null)
            {
                throw new InvalidDataException("account is a required property for SubscriptionCreate and cannot be null");
            }
            else
            {
                this.Account = account;
            }
            
            // to ensure "planId" is required (not null)
            if (planId == null)
            {
                throw new InvalidDataException("planId is a required property for SubscriptionCreate and cannot be null");
            }
            else
            {
                this.PlanId = planId;
            }
            
            // use default value if no "quantity" provided
            if (quantity == null)
            {
                this.Quantity =1;
            }
            else
            {
                this.Quantity = quantity;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The name of the account to create subscription for
        /// </summary>
        /// <value>The name of the account to create subscription for</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        [JsonProperty("account")]
        public string Account { get; set; } 
        /// <summary>
        /// The ID of the plan to subscribe to
        /// </summary>
        /// <value>The ID of the plan to subscribe to</value>
        [DataMember(Name="plan_id", EmitDefaultValue=false)]
        [JsonProperty("plan_id")]
        public int PlanId { get; set; } 
        /// <summary>
        /// The number of subscriptions to create
        /// </summary>
        /// <value>The number of subscriptions to create</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        [JsonProperty("quantity")]
        public int Quantity { get; set; }  = 1;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionCreate {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
        /// <returns>SubscriptionCreate object</returns>
        public static SubscriptionCreate FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SubscriptionCreate>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SubscriptionCreate object</returns>
        public SubscriptionCreate DuplicateSubscriptionCreate()
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
            return this.Equals(input as SubscriptionCreate);
        }

        /// <summary>
        /// Returns true if SubscriptionCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionCreate input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.PlanId == input.PlanId ||
                    (this.PlanId != null &&
                    this.PlanId.Equals(input.PlanId))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.PlanId != null)
                    hashCode = hashCode * 59 + this.PlanId.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
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
