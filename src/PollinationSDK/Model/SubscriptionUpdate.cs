/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.36.0
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
    /// SubscriptionUpdate
    /// </summary>
    [DataContract]
    public partial class SubscriptionUpdate :  IEquatable<SubscriptionUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdate" /> class.
        /// </summary>
        /// <param name="planId">The Paddle Plan ID to change the subscription to..</param>
        /// <param name="quantity">The number of times this subscription is purchased (default to 1).</param>
        public SubscriptionUpdate
        (
           // Required parameters
           int planId= default, int quantity = 1// Optional parameters
        )// BaseClass
        {
            this.PlanId = planId;
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
        /// The Paddle Plan ID to change the subscription to.
        /// </summary>
        /// <value>The Paddle Plan ID to change the subscription to.</value>
        [DataMember(Name="plan_id", EmitDefaultValue=false)]
        [JsonProperty("plan_id")]
        public int PlanId { get; set; } 
        /// <summary>
        /// The number of times this subscription is purchased
        /// </summary>
        /// <value>The number of times this subscription is purchased</value>
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
            sb.Append("class SubscriptionUpdate {\n");
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
        /// <returns>SubscriptionUpdate object</returns>
        public static SubscriptionUpdate FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SubscriptionUpdate>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SubscriptionUpdate object</returns>
        public SubscriptionUpdate DuplicateSubscriptionUpdate()
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
            return this.Equals(input as SubscriptionUpdate);
        }

        /// <summary>
        /// Returns true if SubscriptionUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionUpdate input)
        {
            if (input == null)
                return false;
            return 
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
