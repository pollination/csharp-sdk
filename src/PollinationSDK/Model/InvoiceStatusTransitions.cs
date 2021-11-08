/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.18.1-beta.3
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
    /// InvoiceStatusTransitions
    /// </summary>
    [DataContract]
    public partial class InvoiceStatusTransitions :  IEquatable<InvoiceStatusTransitions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceStatusTransitions" /> class.
        /// </summary>
        /// <param name="finalizedAt">finalizedAt.</param>
        /// <param name="markedUncollectibleAt">markedUncollectibleAt.</param>
        /// <param name="paidAt">paidAt.</param>
        /// <param name="voidedAt">voidedAt.</param>
        public InvoiceStatusTransitions
        (
           // Required parameters
           DateTime finalizedAt= default, DateTime markedUncollectibleAt= default, DateTime paidAt= default, DateTime voidedAt= default// Optional parameters
        )// BaseClass
        {
            this.FinalizedAt = finalizedAt;
            this.MarkedUncollectibleAt = markedUncollectibleAt;
            this.PaidAt = paidAt;
            this.VoidedAt = voidedAt;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets FinalizedAt
        /// </summary>
        [DataMember(Name="finalized_at", EmitDefaultValue=false)]
        [JsonProperty("finalized_at")]
        public DateTime FinalizedAt { get; set; } 
        /// <summary>
        /// Gets or Sets MarkedUncollectibleAt
        /// </summary>
        [DataMember(Name="marked_uncollectible_at", EmitDefaultValue=false)]
        [JsonProperty("marked_uncollectible_at")]
        public DateTime MarkedUncollectibleAt { get; set; } 
        /// <summary>
        /// Gets or Sets PaidAt
        /// </summary>
        [DataMember(Name="paid_at", EmitDefaultValue=false)]
        [JsonProperty("paid_at")]
        public DateTime PaidAt { get; set; } 
        /// <summary>
        /// Gets or Sets VoidedAt
        /// </summary>
        [DataMember(Name="voided_at", EmitDefaultValue=false)]
        [JsonProperty("voided_at")]
        public DateTime VoidedAt { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceStatusTransitions {\n");
            sb.Append("  FinalizedAt: ").Append(FinalizedAt).Append("\n");
            sb.Append("  MarkedUncollectibleAt: ").Append(MarkedUncollectibleAt).Append("\n");
            sb.Append("  PaidAt: ").Append(PaidAt).Append("\n");
            sb.Append("  VoidedAt: ").Append(VoidedAt).Append("\n");
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
        /// <returns>InvoiceStatusTransitions object</returns>
        public static InvoiceStatusTransitions FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<InvoiceStatusTransitions>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>InvoiceStatusTransitions object</returns>
        public InvoiceStatusTransitions DuplicateInvoiceStatusTransitions()
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
            return this.Equals(input as InvoiceStatusTransitions);
        }

        /// <summary>
        /// Returns true if InvoiceStatusTransitions instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceStatusTransitions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceStatusTransitions input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.FinalizedAt == input.FinalizedAt ||
                    (this.FinalizedAt != null &&
                    this.FinalizedAt.Equals(input.FinalizedAt))
                ) && 
                (
                    this.MarkedUncollectibleAt == input.MarkedUncollectibleAt ||
                    (this.MarkedUncollectibleAt != null &&
                    this.MarkedUncollectibleAt.Equals(input.MarkedUncollectibleAt))
                ) && 
                (
                    this.PaidAt == input.PaidAt ||
                    (this.PaidAt != null &&
                    this.PaidAt.Equals(input.PaidAt))
                ) && 
                (
                    this.VoidedAt == input.VoidedAt ||
                    (this.VoidedAt != null &&
                    this.VoidedAt.Equals(input.VoidedAt))
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
                if (this.FinalizedAt != null)
                    hashCode = hashCode * 59 + this.FinalizedAt.GetHashCode();
                if (this.MarkedUncollectibleAt != null)
                    hashCode = hashCode * 59 + this.MarkedUncollectibleAt.GetHashCode();
                if (this.PaidAt != null)
                    hashCode = hashCode * 59 + this.PaidAt.GetHashCode();
                if (this.VoidedAt != null)
                    hashCode = hashCode * 59 + this.VoidedAt.GetHashCode();
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
