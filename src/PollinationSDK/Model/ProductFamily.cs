/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.18.0-beta.5
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
    /// ProductFamily
    /// </summary>
    [DataContract]
    public partial class ProductFamily :  IEquatable<ProductFamily>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductFamily" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductFamily() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductFamily" /> class.
        /// </summary>
        /// <param name="active">active (required).</param>
        /// <param name="description">description.</param>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="prices">prices (required).</param>
        public ProductFamily
        (
           bool active, string id, string name, List<Price> prices, // Required parameters
           string description= default // Optional parameters
        )// BaseClass
        {
            // to ensure "active" is required (not null)
            if (active == null)
            {
                throw new InvalidDataException("active is a required property for ProductFamily and cannot be null");
            }
            else
            {
                this.Active = active;
            }
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ProductFamily and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ProductFamily and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "prices" is required (not null)
            if (prices == null)
            {
                throw new InvalidDataException("prices is a required property for ProductFamily and cannot be null");
            }
            else
            {
                this.Prices = prices;
            }
            
            this.Description = description;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        [JsonProperty("active")]
        public bool Active { get; set; } 
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; } 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public string Id { get; set; } 
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// Gets or Sets Prices
        /// </summary>
        [DataMember(Name="prices", EmitDefaultValue=false)]
        [JsonProperty("prices")]
        public List<Price> Prices { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductFamily {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Prices: ").Append(Prices).Append("\n");
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
        /// <returns>ProductFamily object</returns>
        public static ProductFamily FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ProductFamily>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ProductFamily object</returns>
        public ProductFamily DuplicateProductFamily()
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
            return this.Equals(input as ProductFamily);
        }

        /// <summary>
        /// Returns true if ProductFamily instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductFamily to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductFamily input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                    this.Prices == input.Prices ||
                    this.Prices != null &&
                    input.Prices != null &&
                    this.Prices.SequenceEqual(input.Prices)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Prices != null)
                    hashCode = hashCode * 59 + this.Prices.GetHashCode();
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
