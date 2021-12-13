/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.20.0
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
    /// Quota
    /// </summary>
    [DataContract]
    public partial class Quota :  IEquatable<Quota>, IValidatableObject
    {
        /// <summary>
        /// The type of resource
        /// </summary>
        /// <value>The type of resource</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public QuotaType Type { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="Quota" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Quota() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Quota" /> class.
        /// </summary>
        /// <param name="description">The description.</param>
        /// <param name="displayName">The human-readable name.</param>
        /// <param name="enforced">Whether the limit triggers a blocking response from the server (default to false).</param>
        /// <param name="exceeded">Whether the resource usage is greater than or equal to the limit (default to false).</param>
        /// <param name="id">The unique ID for this Quota.</param>
        /// <param name="limit">The maximum amount of a resource the account can consume.</param>
        /// <param name="owner">The quota owner (required).</param>
        /// <param name="periodStart">The start of the quota usage tracking period.</param>
        /// <param name="resets">Whether consumption is reset to 0 every billing period (default to false).</param>
        /// <param name="unit">The unit in which the usage and limit are measured.</param>
        /// <param name="usage">The current amount of a resource allocated to the account linked to the subscription.</param>
        public Quota
        (
           AccountPublic owner, // Required parameters
           string description= default, string displayName= default, bool enforced = false, bool exceeded = false, Guid id= default, double limit= default, DateTime periodStart= default, bool resets = false, string unit= default, double usage= default// Optional parameters
        )// BaseClass
        {
            // to ensure "owner" is required (not null)
            if (owner == null)
            {
                throw new InvalidDataException("owner is a required property for Quota and cannot be null");
            }
            else
            {
                this.Owner = owner;
            }
            
            this.Description = description;
            this.DisplayName = displayName;
            // use default value if no "enforced" provided
            if (enforced == null)
            {
                this.Enforced =false;
            }
            else
            {
                this.Enforced = enforced;
            }
            // use default value if no "exceeded" provided
            if (exceeded == null)
            {
                this.Exceeded =false;
            }
            else
            {
                this.Exceeded = exceeded;
            }
            this.Id = id;
            this.Limit = limit;
            this.PeriodStart = periodStart;
            // use default value if no "resets" provided
            if (resets == null)
            {
                this.Resets =false;
            }
            else
            {
                this.Resets = resets;
            }
            this.Unit = unit;
            this.Usage = usage;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The description
        /// </summary>
        /// <value>The description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; } 
        /// <summary>
        /// The human-readable name
        /// </summary>
        /// <value>The human-readable name</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        [JsonProperty("display_name")]
        public string DisplayName { get; set; } 
        /// <summary>
        /// Whether the limit triggers a blocking response from the server
        /// </summary>
        /// <value>Whether the limit triggers a blocking response from the server</value>
        [DataMember(Name="enforced", EmitDefaultValue=false)]
        [JsonProperty("enforced")]
        public bool Enforced { get; set; }  = false;
        /// <summary>
        /// Whether the resource usage is greater than or equal to the limit
        /// </summary>
        /// <value>Whether the resource usage is greater than or equal to the limit</value>
        [DataMember(Name="exceeded", EmitDefaultValue=false)]
        [JsonProperty("exceeded")]
        public bool Exceeded { get; set; }  = false;
        /// <summary>
        /// The unique ID for this Quota
        /// </summary>
        /// <value>The unique ID for this Quota</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public Guid Id { get; set; } 
        /// <summary>
        /// The maximum amount of a resource the account can consume
        /// </summary>
        /// <value>The maximum amount of a resource the account can consume</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        [JsonProperty("limit")]
        public double Limit { get; set; } 
        /// <summary>
        /// The quota owner
        /// </summary>
        /// <value>The quota owner</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        [JsonProperty("owner")]
        public AccountPublic Owner { get; set; } 
        /// <summary>
        /// The start of the quota usage tracking period
        /// </summary>
        /// <value>The start of the quota usage tracking period</value>
        [DataMember(Name="period_start", EmitDefaultValue=false)]
        [JsonProperty("period_start")]
        public DateTime PeriodStart { get; set; } 
        /// <summary>
        /// Whether consumption is reset to 0 every billing period
        /// </summary>
        /// <value>Whether consumption is reset to 0 every billing period</value>
        [DataMember(Name="resets", EmitDefaultValue=false)]
        [JsonProperty("resets")]
        public bool Resets { get; set; }  = false;
        /// <summary>
        /// The unit in which the usage and limit are measured
        /// </summary>
        /// <value>The unit in which the usage and limit are measured</value>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        [JsonProperty("unit")]
        public string Unit { get; set; } 
        /// <summary>
        /// The current amount of a resource allocated to the account linked to the subscription
        /// </summary>
        /// <value>The current amount of a resource allocated to the account linked to the subscription</value>
        [DataMember(Name="usage", EmitDefaultValue=false)]
        [JsonProperty("usage")]
        public double Usage { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Quota {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Enforced: ").Append(Enforced).Append("\n");
            sb.Append("  Exceeded: ").Append(Exceeded).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  PeriodStart: ").Append(PeriodStart).Append("\n");
            sb.Append("  Resets: ").Append(Resets).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
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
        /// <returns>Quota object</returns>
        public static Quota FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Quota>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Quota object</returns>
        public Quota DuplicateQuota()
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
            return this.Equals(input as Quota);
        }

        /// <summary>
        /// Returns true if Quota instances are equal
        /// </summary>
        /// <param name="input">Instance of Quota to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Quota input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Enforced == input.Enforced ||
                    (this.Enforced != null &&
                    this.Enforced.Equals(input.Enforced))
                ) && 
                (
                    this.Exceeded == input.Exceeded ||
                    (this.Exceeded != null &&
                    this.Exceeded.Equals(input.Exceeded))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.PeriodStart == input.PeriodStart ||
                    (this.PeriodStart != null &&
                    this.PeriodStart.Equals(input.PeriodStart))
                ) && 
                (
                    this.Resets == input.Resets ||
                    (this.Resets != null &&
                    this.Resets.Equals(input.Resets))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Usage == input.Usage ||
                    (this.Usage != null &&
                    this.Usage.Equals(input.Usage))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Enforced != null)
                    hashCode = hashCode * 59 + this.Enforced.GetHashCode();
                if (this.Exceeded != null)
                    hashCode = hashCode * 59 + this.Exceeded.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.PeriodStart != null)
                    hashCode = hashCode * 59 + this.PeriodStart.GetHashCode();
                if (this.Resets != null)
                    hashCode = hashCode * 59 + this.Resets.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Usage != null)
                    hashCode = hashCode * 59 + this.Usage.GetHashCode();
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
            // Usage (double) minimum
            if(this.Usage < (double)0.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Usage, must be a value greater than or equal to 0.0.", new [] { "Usage" });
            }

            yield break;
        }
    }

}
