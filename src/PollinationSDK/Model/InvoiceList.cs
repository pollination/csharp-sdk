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
    /// InvoiceList
    /// </summary>
    [DataContract]
    public partial class InvoiceList :  IEquatable<InvoiceList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvoiceList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceList" /> class.
        /// </summary>
        /// <param name="hasMore">hasMore (required).</param>
        /// <param name="resources">resources (required).</param>
        public InvoiceList
        (
           bool hasMore, List<Invoice> resources// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "hasMore" is required (not null)
            if (hasMore == null)
            {
                throw new InvalidDataException("hasMore is a required property for InvoiceList and cannot be null");
            }
            else
            {
                this.HasMore = hasMore;
            }
            
            // to ensure "resources" is required (not null)
            if (resources == null)
            {
                throw new InvalidDataException("resources is a required property for InvoiceList and cannot be null");
            }
            else
            {
                this.Resources = resources;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets HasMore
        /// </summary>
        [DataMember(Name="has_more", EmitDefaultValue=false)]
        [JsonProperty("has_more")]
        public bool HasMore { get; set; } 
        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [DataMember(Name="resources", EmitDefaultValue=false)]
        [JsonProperty("resources")]
        public List<Invoice> Resources { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceList {\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
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
        /// <returns>InvoiceList object</returns>
        public static InvoiceList FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<InvoiceList>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>InvoiceList object</returns>
        public InvoiceList DuplicateInvoiceList()
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
            return this.Equals(input as InvoiceList);
        }

        /// <summary>
        /// Returns true if InvoiceList instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceList input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.HasMore == input.HasMore ||
                    (this.HasMore != null &&
                    this.HasMore.Equals(input.HasMore))
                ) && 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    input.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
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
                if (this.HasMore != null)
                    hashCode = hashCode * 59 + this.HasMore.GetHashCode();
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
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
