/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.17.0
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
    /// CardPublic
    /// </summary>
    [DataContract]
    public partial class CardPublic :  IEquatable<CardPublic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardPublic" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CardPublic() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardPublic" /> class.
        /// </summary>
        /// <param name="expMonth">The month the card expires (required).</param>
        /// <param name="expYear">The year the card expires (required).</param>
        /// <param name="last4">The last four digits of the card (required).</param>
        public CardPublic
        (
           int expMonth, int expYear, string last4// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "expMonth" is required (not null)
            if (expMonth == null)
            {
                throw new InvalidDataException("expMonth is a required property for CardPublic and cannot be null");
            }
            else
            {
                this.ExpMonth = expMonth;
            }
            
            // to ensure "expYear" is required (not null)
            if (expYear == null)
            {
                throw new InvalidDataException("expYear is a required property for CardPublic and cannot be null");
            }
            else
            {
                this.ExpYear = expYear;
            }
            
            // to ensure "last4" is required (not null)
            if (last4 == null)
            {
                throw new InvalidDataException("last4 is a required property for CardPublic and cannot be null");
            }
            else
            {
                this.Last4 = last4;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The month the card expires
        /// </summary>
        /// <value>The month the card expires</value>
        [DataMember(Name="exp_month", EmitDefaultValue=false)]
        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; } 
        /// <summary>
        /// The year the card expires
        /// </summary>
        /// <value>The year the card expires</value>
        [DataMember(Name="exp_year", EmitDefaultValue=false)]
        [JsonProperty("exp_year")]
        public int ExpYear { get; set; } 
        /// <summary>
        /// The last four digits of the card
        /// </summary>
        /// <value>The last four digits of the card</value>
        [DataMember(Name="last4", EmitDefaultValue=false)]
        [JsonProperty("last4")]
        public string Last4 { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardPublic {\n");
            sb.Append("  ExpMonth: ").Append(ExpMonth).Append("\n");
            sb.Append("  ExpYear: ").Append(ExpYear).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
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
        /// <returns>CardPublic object</returns>
        public static CardPublic FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<CardPublic>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>CardPublic object</returns>
        public CardPublic DuplicateCardPublic()
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
            return this.Equals(input as CardPublic);
        }

        /// <summary>
        /// Returns true if CardPublic instances are equal
        /// </summary>
        /// <param name="input">Instance of CardPublic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardPublic input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.ExpMonth == input.ExpMonth ||
                    (this.ExpMonth != null &&
                    this.ExpMonth.Equals(input.ExpMonth))
                ) && 
                (
                    this.ExpYear == input.ExpYear ||
                    (this.ExpYear != null &&
                    this.ExpYear.Equals(input.ExpYear))
                ) && 
                (
                    this.Last4 == input.Last4 ||
                    (this.Last4 != null &&
                    this.Last4.Equals(input.Last4))
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
                if (this.ExpMonth != null)
                    hashCode = hashCode * 59 + this.ExpMonth.GetHashCode();
                if (this.ExpYear != null)
                    hashCode = hashCode * 59 + this.ExpYear.GetHashCode();
                if (this.Last4 != null)
                    hashCode = hashCode * 59 + this.Last4.GetHashCode();
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
