/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.30.0
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
    /// BillingOption
    /// </summary>
    [DataContract]
    public partial class BillingOption :  IEquatable<BillingOption>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillingOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingOption" /> class.
        /// </summary>
        /// <param name="billingPeriod">The number of period for the billing cycle (required).</param>
        /// <param name="billingType">The type of billing option, can be daily, monthly or yearly (required).</param>
        /// <param name="id">The id of the billing option (required).</param>
        /// <param name="name">The name of the billing option (required).</param>
        /// <param name="recurringPrice">The price of the billing option (required).</param>
        public BillingOption
        (
           int billingPeriod, string billingType, int id, string name, Dictionary<string, decimal> recurringPrice// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "billingPeriod" is required (not null)
            if (billingPeriod == null)
            {
                throw new InvalidDataException("billingPeriod is a required property for BillingOption and cannot be null");
            }
            else
            {
                this.BillingPeriod = billingPeriod;
            }
            
            // to ensure "billingType" is required (not null)
            if (billingType == null)
            {
                throw new InvalidDataException("billingType is a required property for BillingOption and cannot be null");
            }
            else
            {
                this.BillingType = billingType;
            }
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for BillingOption and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for BillingOption and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "recurringPrice" is required (not null)
            if (recurringPrice == null)
            {
                throw new InvalidDataException("recurringPrice is a required property for BillingOption and cannot be null");
            }
            else
            {
                this.RecurringPrice = recurringPrice;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The number of period for the billing cycle
        /// </summary>
        /// <value>The number of period for the billing cycle</value>
        [DataMember(Name="billing_period", EmitDefaultValue=false)]
        [JsonProperty("billing_period")]
        public int BillingPeriod { get; set; } 
        /// <summary>
        /// The type of billing option, can be daily, monthly or yearly
        /// </summary>
        /// <value>The type of billing option, can be daily, monthly or yearly</value>
        [DataMember(Name="billing_type", EmitDefaultValue=false)]
        [JsonProperty("billing_type")]
        public string BillingType { get; set; } 
        /// <summary>
        /// The id of the billing option
        /// </summary>
        /// <value>The id of the billing option</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public int Id { get; set; } 
        /// <summary>
        /// The name of the billing option
        /// </summary>
        /// <value>The name of the billing option</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// The price of the billing option
        /// </summary>
        /// <value>The price of the billing option</value>
        [DataMember(Name="recurring_price", EmitDefaultValue=false)]
        [JsonProperty("recurring_price")]
        public Dictionary<string, decimal> RecurringPrice { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingOption {\n");
            sb.Append("  BillingPeriod: ").Append(BillingPeriod).Append("\n");
            sb.Append("  BillingType: ").Append(BillingType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RecurringPrice: ").Append(RecurringPrice).Append("\n");
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
        /// <returns>BillingOption object</returns>
        public static BillingOption FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<BillingOption>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>BillingOption object</returns>
        public BillingOption DuplicateBillingOption()
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
            return this.Equals(input as BillingOption);
        }

        /// <summary>
        /// Returns true if BillingOption instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingOption input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.BillingPeriod == input.BillingPeriod ||
                    (this.BillingPeriod != null &&
                    this.BillingPeriod.Equals(input.BillingPeriod))
                ) && 
                (
                    this.BillingType == input.BillingType ||
                    (this.BillingType != null &&
                    this.BillingType.Equals(input.BillingType))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RecurringPrice == input.RecurringPrice ||
                    this.RecurringPrice != null &&
                    input.RecurringPrice != null &&
                    this.RecurringPrice.SequenceEqual(input.RecurringPrice)
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
                if (this.BillingPeriod != null)
                    hashCode = hashCode * 59 + this.BillingPeriod.GetHashCode();
                if (this.BillingType != null)
                    hashCode = hashCode * 59 + this.BillingType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RecurringPrice != null)
                    hashCode = hashCode * 59 + this.RecurringPrice.GetHashCode();
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
