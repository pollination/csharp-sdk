/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.18.0-beta.3
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
    /// Price
    /// </summary>
    [DataContract]
    public partial class Price :  IEquatable<Price>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public PriceType Type { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="Price" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Price() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Price" /> class.
        /// </summary>
        /// <param name="active">active (required).</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="nickname">nickname.</param>
        /// <param name="product">product (required).</param>
        /// <param name="recurring">recurring.</param>
        /// <param name="tiers">tiers.</param>
        /// <param name="type">type (required).</param>
        /// <param name="unitAmount">unitAmount.</param>
        public Price
        (
           bool active, string currency, string id, string product, PriceType type, // Required parameters
           string nickname= default, PriceRecurrence recurring= default, List<PriceTier> tiers= default, int unitAmount= default// Optional parameters
        )// BaseClass
        {
            // to ensure "active" is required (not null)
            if (active == null)
            {
                throw new InvalidDataException("active is a required property for Price and cannot be null");
            }
            else
            {
                this.Active = active;
            }
            
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for Price and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Price and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "product" is required (not null)
            if (product == null)
            {
                throw new InvalidDataException("product is a required property for Price and cannot be null");
            }
            else
            {
                this.Product = product;
            }
            
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Price and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            
            this.Nickname = nickname;
            this.Recurring = recurring;
            this.Tiers = tiers;
            this.UnitAmount = unitAmount;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        [JsonProperty("active")]
        public bool Active { get; set; } 
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        [JsonProperty("currency")]
        public string Currency { get; set; } 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public string Id { get; set; } 
        /// <summary>
        /// Gets or Sets Nickname
        /// </summary>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        [JsonProperty("nickname")]
        public string Nickname { get; set; } 
        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name="product", EmitDefaultValue=false)]
        [JsonProperty("product")]
        public string Product { get; set; } 
        /// <summary>
        /// Gets or Sets Recurring
        /// </summary>
        [DataMember(Name="recurring", EmitDefaultValue=false)]
        [JsonProperty("recurring")]
        public PriceRecurrence Recurring { get; set; } 
        /// <summary>
        /// Gets or Sets Tiers
        /// </summary>
        [DataMember(Name="tiers", EmitDefaultValue=false)]
        [JsonProperty("tiers")]
        public List<PriceTier> Tiers { get; set; } 
        /// <summary>
        /// Gets or Sets UnitAmount
        /// </summary>
        [DataMember(Name="unit_amount", EmitDefaultValue=false)]
        [JsonProperty("unit_amount")]
        public int UnitAmount { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Price {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Recurring: ").Append(Recurring).Append("\n");
            sb.Append("  Tiers: ").Append(Tiers).Append("\n");
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
        /// <returns>Price object</returns>
        public static Price FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Price>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Price object</returns>
        public Price DuplicatePrice()
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
            return this.Equals(input as Price);
        }

        /// <summary>
        /// Returns true if Price instances are equal
        /// </summary>
        /// <param name="input">Instance of Price to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Price input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Nickname == input.Nickname ||
                    (this.Nickname != null &&
                    this.Nickname.Equals(input.Nickname))
                ) && 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
                ) && 
                (
                    this.Recurring == input.Recurring ||
                    (this.Recurring != null &&
                    this.Recurring.Equals(input.Recurring))
                ) && 
                (
                    this.Tiers == input.Tiers ||
                    this.Tiers != null &&
                    input.Tiers != null &&
                    this.Tiers.SequenceEqual(input.Tiers)
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Nickname != null)
                    hashCode = hashCode * 59 + this.Nickname.GetHashCode();
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.Recurring != null)
                    hashCode = hashCode * 59 + this.Recurring.GetHashCode();
                if (this.Tiers != null)
                    hashCode = hashCode * 59 + this.Tiers.GetHashCode();
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
            yield break;
        }
    }

}
