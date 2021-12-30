/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.22.0
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
    /// A quota extension
    /// </summary>
    [DataContract]
    public partial class QuotaExtension :  IEquatable<QuotaExtension>, IValidatableObject
    {
        /// <summary>
        /// The type of quota this applies to
        /// </summary>
        /// <value>The type of quota this applies to</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public QuotaType Type { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaExtension" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuotaExtension() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaExtension" /> class.
        /// </summary>
        /// <param name="id">The ID of the quota extension (required).</param>
        /// <param name="name">Name of the quota extension plan (required).</param>
        /// <param name="quantity">The number of times to count this extension (required).</param>
        /// <param name="unitAmount">The amount by which this object extends a given quota (required).</param>
        public QuotaExtension
        (
           string id, string name, int quantity, double unitAmount// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for QuotaExtension and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for QuotaExtension and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for QuotaExtension and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
            
            // to ensure "unitAmount" is required (not null)
            if (unitAmount == null)
            {
                throw new InvalidDataException("unitAmount is a required property for QuotaExtension and cannot be null");
            }
            else
            {
                this.UnitAmount = unitAmount;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The ID of the quota extension
        /// </summary>
        /// <value>The ID of the quota extension</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public string Id { get; set; } 
        /// <summary>
        /// Name of the quota extension plan
        /// </summary>
        /// <value>Name of the quota extension plan</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// The number of times to count this extension
        /// </summary>
        /// <value>The number of times to count this extension</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        [JsonProperty("quantity")]
        public int Quantity { get; set; } 
        /// <summary>
        /// The amount by which this object extends a given quota
        /// </summary>
        /// <value>The amount by which this object extends a given quota</value>
        [DataMember(Name="unit_amount", EmitDefaultValue=false)]
        [JsonProperty("unit_amount")]
        public double UnitAmount { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuotaExtension {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UnitAmount: ").Append(UnitAmount).Append("\n");
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
        /// <returns>QuotaExtension object</returns>
        public static QuotaExtension FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<QuotaExtension>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>QuotaExtension object</returns>
        public QuotaExtension DuplicateQuotaExtension()
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
            return this.Equals(input as QuotaExtension);
        }

        /// <summary>
        /// Returns true if QuotaExtension instances are equal
        /// </summary>
        /// <param name="input">Instance of QuotaExtension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuotaExtension input)
        {
            if (input == null)
                return false;
            return 
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
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UnitAmount == input.UnitAmount ||
                    (this.UnitAmount != null &&
                    this.UnitAmount.Equals(input.UnitAmount))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UnitAmount != null)
                    hashCode = hashCode * 59 + this.UnitAmount.GetHashCode();
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
            // UnitAmount (double) minimum
            if(this.UnitAmount < (double)0.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnitAmount, must be a value greater than or equal to 0.0.", new [] { "UnitAmount" });
            }

            yield break;
        }
    }

}
