/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.21.0
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
    /// Inventory
    /// </summary>
    [DataContract]
    public partial class Inventory :  IEquatable<Inventory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Inventory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Inventory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Inventory" /> class.
        /// </summary>
        /// <param name="families">families (required).</param>
        public Inventory
        (
           List<ProductFamily> families// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "families" is required (not null)
            if (families == null)
            {
                throw new InvalidDataException("families is a required property for Inventory and cannot be null");
            }
            else
            {
                this.Families = families;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Families
        /// </summary>
        [DataMember(Name="families", EmitDefaultValue=false)]
        [JsonProperty("families")]
        public List<ProductFamily> Families { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Inventory {\n");
            sb.Append("  Families: ").Append(Families).Append("\n");
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
        /// <returns>Inventory object</returns>
        public static Inventory FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Inventory>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Inventory object</returns>
        public Inventory DuplicateInventory()
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
            return this.Equals(input as Inventory);
        }

        /// <summary>
        /// Returns true if Inventory instances are equal
        /// </summary>
        /// <param name="input">Instance of Inventory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Inventory input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Families == input.Families ||
                    this.Families != null &&
                    input.Families != null &&
                    this.Families.SequenceEqual(input.Families)
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
                if (this.Families != null)
                    hashCode = hashCode * 59 + this.Families.GetHashCode();
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
