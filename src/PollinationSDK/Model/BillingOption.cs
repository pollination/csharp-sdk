/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * Contact: info@pollination.cloud
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

extern alias LBTNewtonsoft;  extern alias LBTRestSharp; using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using LBTNewtonsoft::Newtonsoft.Json;
using LBTNewtonsoft::Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace PollinationSDK
{
    /// <summary>
    /// BillingOption
    /// </summary>
    [DataContract(Name = "BillingOption")]
    public partial class BillingOption : OpenAPIGenBaseModel, IEquatable<BillingOption>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillingOption() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "BillingOption";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingOption" /> class.
        /// </summary>
        /// <param name="id">The id of the billing option (required).</param>
        /// <param name="name">The name of the billing option (required).</param>
        /// <param name="billingType">The type of billing option, can be daily, monthly or yearly (required).</param>
        /// <param name="billingPeriod">The number of period for the billing cycle (required).</param>
        /// <param name="recurringPrice">The price of the billing option (required).</param>
        public BillingOption
        (
           int id, string name, string billingType, int billingPeriod, Dictionary<string, decimal> recurringPrice// Required parameters
            // Optional parameters
        ) : base()// BaseClass
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for BillingOption and cannot be null");
            // to ensure "billingType" is required (not null)
            this.BillingType = billingType ?? throw new ArgumentNullException("billingType is a required property for BillingOption and cannot be null");
            this.BillingPeriod = billingPeriod;
            // to ensure "recurringPrice" is required (not null)
            this.RecurringPrice = recurringPrice ?? throw new ArgumentNullException("recurringPrice is a required property for BillingOption and cannot be null");

            // Set non-required readonly properties with defaultValue
            this.Type = "BillingOption";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "BillingOption";

        /// <summary>
        /// The id of the billing option
        /// </summary>
        /// <value>The id of the billing option</value>
        [DataMember(Name = "id", IsRequired = true)]
        public int Id { get; set; } 
        /// <summary>
        /// The name of the billing option
        /// </summary>
        /// <value>The name of the billing option</value>
        [DataMember(Name = "name", IsRequired = true)]
        public string Name { get; set; } 
        /// <summary>
        /// The type of billing option, can be daily, monthly or yearly
        /// </summary>
        /// <value>The type of billing option, can be daily, monthly or yearly</value>
        [DataMember(Name = "billing_type", IsRequired = true)]
        public string BillingType { get; set; } 
        /// <summary>
        /// The number of period for the billing cycle
        /// </summary>
        /// <value>The number of period for the billing cycle</value>
        [DataMember(Name = "billing_period", IsRequired = true)]
        public int BillingPeriod { get; set; } 
        /// <summary>
        /// The price of the billing option
        /// </summary>
        /// <value>The price of the billing option</value>
        [DataMember(Name = "recurring_price", IsRequired = true)]
        public Dictionary<string, decimal> RecurringPrice { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "BillingOption";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("BillingOption:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  BillingType: ").Append(this.BillingType).Append("\n");
            sb.Append("  BillingPeriod: ").Append(this.BillingPeriod).Append("\n");
            sb.Append("  RecurringPrice: ").Append(this.RecurringPrice).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>BillingOption object</returns>
        public static BillingOption FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<BillingOption>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>BillingOption object</returns>
        public virtual BillingOption DuplicateBillingOption()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateBillingOption();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateBillingOption();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
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
            return base.Equals(input) && 
                    Extension.Equals(this.Id, input.Id) && 
                    Extension.Equals(this.Name, input.Name) && 
                    Extension.Equals(this.BillingType, input.BillingType) && 
                    Extension.Equals(this.BillingPeriod, input.BillingPeriod) && 
                (
                    this.RecurringPrice == input.RecurringPrice ||
                    Extension.AllEquals(this.RecurringPrice, input.RecurringPrice)
                ) && 
                    Extension.Equals(this.Type, input.Type);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.BillingType != null)
                    hashCode = hashCode * 59 + this.BillingType.GetHashCode();
                if (this.BillingPeriod != null)
                    hashCode = hashCode * 59 + this.BillingPeriod.GetHashCode();
                if (this.RecurringPrice != null)
                    hashCode = hashCode * 59 + this.RecurringPrice.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^BillingOption$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
