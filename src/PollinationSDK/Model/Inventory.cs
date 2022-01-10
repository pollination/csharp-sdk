/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
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


namespace PollinationSDK
{
    /// <summary>
    /// Inventory
    /// </summary>
    [DataContract(Name = "Inventory")]
    public partial class Inventory : OpenAPIGenBaseModel, IEquatable<Inventory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Inventory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Inventory() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "Inventory";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Inventory" /> class.
        /// </summary>
        /// <param name="families">families (required).</param>
        public Inventory
        (
           List<ProductFamily> families// Required parameters
           // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "families" is required (not null)
            this.Families = families ?? throw new ArgumentNullException("families is a required property for Inventory and cannot be null");

            // Set non-required readonly properties with defaultValue
            this.Type = "Inventory";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; protected internal set; }  = "Inventory";

        /// <summary>
        /// Gets or Sets Families
        /// </summary>
        [DataMember(Name = "families", IsRequired = true, EmitDefaultValue = false)]
        public List<ProductFamily> Families { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Inventory";
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
            sb.Append("Inventory:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Families: ").Append(Families).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Inventory object</returns>
        public static Inventory FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Inventory>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Inventory object</returns>
        public virtual Inventory DuplicateInventory()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateInventory();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateInventory();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
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
            return base.Equals(input) && 
                (
                    this.Families == input.Families ||
                    this.Families != null &&
                    input.Families != null &&
                    this.Families.SequenceEqual(input.Families)
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                int hashCode = base.GetHashCode();
                if (this.Families != null)
                    hashCode = hashCode * 59 + this.Families.GetHashCode();
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
            Regex regexType = new Regex(@"^Inventory$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
