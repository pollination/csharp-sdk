/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.29.0
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
    /// SubscriptionUpdateDryRun
    /// </summary>
    [DataContract]
    public partial class SubscriptionUpdateDryRun :  IEquatable<SubscriptionUpdateDryRun>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdateDryRun" /> class.
        /// </summary>
        /// <param name="exceededQuotas">A list of quotas exceeded by a proposed subscription update.</param>
        public SubscriptionUpdateDryRun
        (
           // Required parameters
           List<Quota> exceededQuotas= default// Optional parameters
        )// BaseClass
        {
            this.ExceededQuotas = exceededQuotas;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// A list of quotas exceeded by a proposed subscription update
        /// </summary>
        /// <value>A list of quotas exceeded by a proposed subscription update</value>
        [DataMember(Name="exceeded_quotas", EmitDefaultValue=false)]
        [JsonProperty("exceeded_quotas")]
        public List<Quota> ExceededQuotas { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionUpdateDryRun {\n");
            sb.Append("  ExceededQuotas: ").Append(ExceededQuotas).Append("\n");
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
        /// <returns>SubscriptionUpdateDryRun object</returns>
        public static SubscriptionUpdateDryRun FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SubscriptionUpdateDryRun>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SubscriptionUpdateDryRun object</returns>
        public SubscriptionUpdateDryRun DuplicateSubscriptionUpdateDryRun()
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
            return this.Equals(input as SubscriptionUpdateDryRun);
        }

        /// <summary>
        /// Returns true if SubscriptionUpdateDryRun instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionUpdateDryRun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionUpdateDryRun input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.ExceededQuotas == input.ExceededQuotas ||
                    this.ExceededQuotas != null &&
                    input.ExceededQuotas != null &&
                    this.ExceededQuotas.SequenceEqual(input.ExceededQuotas)
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
