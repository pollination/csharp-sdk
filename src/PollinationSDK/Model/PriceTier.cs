/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: v0.20.0
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
    /// PriceTier
    /// </summary>
    [DataContract]
    public partial class PriceTier :  IEquatable<PriceTier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceTier" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PriceTier() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceTier" /> class.
        /// </summary>
        /// <param name="flatAmount">flatAmount.</param>
        /// <param name="flatAmountDecimal">flatAmountDecimal.</param>
        /// <param name="unitAmount">unitAmount (required).</param>
        /// <param name="unitAmountDecimal">unitAmountDecimal (required).</param>
        /// <param name="upTo">upTo.</param>
        public PriceTier
        (
           int unitAmount, string unitAmountDecimal, // Required parameters
           int flatAmount= default, string flatAmountDecimal= default, int upTo= default// Optional parameters
        )// BaseClass
        {
            // to ensure "unitAmount" is required (not null)
            if (unitAmount == null)
            {
                throw new InvalidDataException("unitAmount is a required property for PriceTier and cannot be null");
            }
            else
            {
                this.UnitAmount = unitAmount;
            }
            
            // to ensure "unitAmountDecimal" is required (not null)
            if (unitAmountDecimal == null)
            {
                throw new InvalidDataException("unitAmountDecimal is a required property for PriceTier and cannot be null");
            }
            else
            {
                this.UnitAmountDecimal = unitAmountDecimal;
            }
            
            this.FlatAmount = flatAmount;
            this.FlatAmountDecimal = flatAmountDecimal;
            this.UpTo = upTo;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets FlatAmount
        /// </summary>
        [DataMember(Name="flat_amount", EmitDefaultValue=false)]
        [JsonProperty("flat_amount")]
        public int FlatAmount { get; set; } 
        /// <summary>
        /// Gets or Sets FlatAmountDecimal
        /// </summary>
        [DataMember(Name="flat_amount_decimal", EmitDefaultValue=false)]
        [JsonProperty("flat_amount_decimal")]
        public string FlatAmountDecimal { get; set; } 
        /// <summary>
        /// Gets or Sets UnitAmount
        /// </summary>
        [DataMember(Name="unit_amount", EmitDefaultValue=false)]
        [JsonProperty("unit_amount")]
        public int UnitAmount { get; set; } 
        /// <summary>
        /// Gets or Sets UnitAmountDecimal
        /// </summary>
        [DataMember(Name="unit_amount_decimal", EmitDefaultValue=false)]
        [JsonProperty("unit_amount_decimal")]
        public string UnitAmountDecimal { get; set; } 
        /// <summary>
        /// Gets or Sets UpTo
        /// </summary>
        [DataMember(Name="up_to", EmitDefaultValue=false)]
        [JsonProperty("up_to")]
        public int UpTo { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PriceTier {\n");
            sb.Append("  FlatAmount: ").Append(FlatAmount).Append("\n");
            sb.Append("  FlatAmountDecimal: ").Append(FlatAmountDecimal).Append("\n");
            sb.Append("  UnitAmount: ").Append(UnitAmount).Append("\n");
            sb.Append("  UnitAmountDecimal: ").Append(UnitAmountDecimal).Append("\n");
            sb.Append("  UpTo: ").Append(UpTo).Append("\n");
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
        /// <returns>PriceTier object</returns>
        public static PriceTier FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<PriceTier>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>PriceTier object</returns>
        public PriceTier DuplicatePriceTier()
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
            return this.Equals(input as PriceTier);
        }

        /// <summary>
        /// Returns true if PriceTier instances are equal
        /// </summary>
        /// <param name="input">Instance of PriceTier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PriceTier input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.FlatAmount == input.FlatAmount ||
                    (this.FlatAmount != null &&
                    this.FlatAmount.Equals(input.FlatAmount))
                ) && 
                (
                    this.FlatAmountDecimal == input.FlatAmountDecimal ||
                    (this.FlatAmountDecimal != null &&
                    this.FlatAmountDecimal.Equals(input.FlatAmountDecimal))
                ) && 
                (
                    this.UnitAmount == input.UnitAmount ||
                    (this.UnitAmount != null &&
                    this.UnitAmount.Equals(input.UnitAmount))
                ) && 
                (
                    this.UnitAmountDecimal == input.UnitAmountDecimal ||
                    (this.UnitAmountDecimal != null &&
                    this.UnitAmountDecimal.Equals(input.UnitAmountDecimal))
                ) && 
                (
                    this.UpTo == input.UpTo ||
                    (this.UpTo != null &&
                    this.UpTo.Equals(input.UpTo))
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
                if (this.FlatAmount != null)
                    hashCode = hashCode * 59 + this.FlatAmount.GetHashCode();
                if (this.FlatAmountDecimal != null)
                    hashCode = hashCode * 59 + this.FlatAmountDecimal.GetHashCode();
                if (this.UnitAmount != null)
                    hashCode = hashCode * 59 + this.UnitAmount.GetHashCode();
                if (this.UnitAmountDecimal != null)
                    hashCode = hashCode * 59 + this.UnitAmountDecimal.GetHashCode();
                if (this.UpTo != null)
                    hashCode = hashCode * 59 + this.UpTo.GetHashCode();
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
