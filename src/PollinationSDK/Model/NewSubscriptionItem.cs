/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.17.0-staging
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
    /// NewSubscriptionItem
    /// </summary>
    [DataContract]
    public partial class NewSubscriptionItem :  IEquatable<NewSubscriptionItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewSubscriptionItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewSubscriptionItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewSubscriptionItem" /> class.
        /// </summary>
        /// <param name="price">price (required).</param>
        /// <param name="quantity">quantity (required).</param>
        public NewSubscriptionItem
        (
           Price price, int quantity// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "price" is required (not null)
            if (price == null)
            {
                throw new InvalidDataException("price is a required property for NewSubscriptionItem and cannot be null");
            }
            else
            {
                this.Price = price;
            }
            
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for NewSubscriptionItem and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        [JsonProperty("price")]
        public Price Price { get; set; } 
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        [JsonProperty("quantity")]
        public int Quantity { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewSubscriptionItem {\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
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
        /// <returns>NewSubscriptionItem object</returns>
        public static NewSubscriptionItem FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<NewSubscriptionItem>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>NewSubscriptionItem object</returns>
        public NewSubscriptionItem DuplicateNewSubscriptionItem()
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
            return this.Equals(input as NewSubscriptionItem);
        }

        /// <summary>
        /// Returns true if NewSubscriptionItem instances are equal
        /// </summary>
        /// <param name="input">Instance of NewSubscriptionItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewSubscriptionItem input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
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
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
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
