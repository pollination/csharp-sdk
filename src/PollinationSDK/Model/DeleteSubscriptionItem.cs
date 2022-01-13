/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.24.0
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
    /// DeleteSubscriptionItem
    /// </summary>
    [DataContract]
    public partial class DeleteSubscriptionItem :  IEquatable<DeleteSubscriptionItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSubscriptionItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteSubscriptionItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSubscriptionItem" /> class.
        /// </summary>
        /// <param name="deleted">deleted (default to true).</param>
        /// <param name="id">id (required).</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="price">price (required).</param>
        /// <param name="quantity">quantity (required).</param>
        public DeleteSubscriptionItem
        (
           string id, Price price, int quantity, // Required parameters
           bool deleted = true, Object metadata= default // Optional parameters
        )// BaseClass
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for DeleteSubscriptionItem and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "price" is required (not null)
            if (price == null)
            {
                throw new InvalidDataException("price is a required property for DeleteSubscriptionItem and cannot be null");
            }
            else
            {
                this.Price = price;
            }
            
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for DeleteSubscriptionItem and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
            
            // use default value if no "deleted" provided
            if (deleted == null)
            {
                this.Deleted =true;
            }
            else
            {
                this.Deleted = deleted;
            }
            this.Metadata = metadata;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }  = true;
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public string Id { get; set; } 
        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        [JsonProperty("metadata")]
        public Object Metadata { get; set; } 
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
            sb.Append("class DeleteSubscriptionItem {\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        /// <returns>DeleteSubscriptionItem object</returns>
        public static DeleteSubscriptionItem FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DeleteSubscriptionItem>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DeleteSubscriptionItem object</returns>
        public DeleteSubscriptionItem DuplicateDeleteSubscriptionItem()
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
            return this.Equals(input as DeleteSubscriptionItem);
        }

        /// <summary>
        /// Returns true if DeleteSubscriptionItem instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteSubscriptionItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteSubscriptionItem input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Deleted == input.Deleted ||
                    (this.Deleted != null &&
                    this.Deleted.Equals(input.Deleted))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
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
                if (this.Deleted != null)
                    hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
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
