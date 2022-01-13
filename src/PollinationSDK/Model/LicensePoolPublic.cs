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
    /// LicensePoolPublic
    /// </summary>
    [DataContract]
    public partial class LicensePoolPublic :  IEquatable<LicensePoolPublic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensePoolPublic" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LicensePoolPublic() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensePoolPublic" /> class.
        /// </summary>
        /// <param name="accessors">The entities that can access the license though the pool.</param>
        /// <param name="allowedActivations">The number of allowable activations for this license (required).</param>
        /// <param name="description">The description of the pool.</param>
        /// <param name="id">The ID of the pool (required).</param>
        /// <param name="licenseId">The ID of the license to which the pool provides access (required).</param>
        /// <param name="owner">The account that owns the license (required).</param>
        /// <param name="permissions">permissions (required).</param>
        /// <param name="product">The pollination product to which this pool provides access (required).</param>
        /// <param name="totalActivations">The number of current activations for this license (required).</param>
        public LicensePoolPublic
        (
           int allowedActivations, Guid id, string licenseId, AccountPublic owner, UserPermission permissions, string product, int totalActivations, // Required parameters
           List<Accessor> accessors= default, string description= default // Optional parameters
        )// BaseClass
        {
            // to ensure "allowedActivations" is required (not null)
            if (allowedActivations == null)
            {
                throw new InvalidDataException("allowedActivations is a required property for LicensePoolPublic and cannot be null");
            }
            else
            {
                this.AllowedActivations = allowedActivations;
            }
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for LicensePoolPublic and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "licenseId" is required (not null)
            if (licenseId == null)
            {
                throw new InvalidDataException("licenseId is a required property for LicensePoolPublic and cannot be null");
            }
            else
            {
                this.LicenseId = licenseId;
            }
            
            // to ensure "owner" is required (not null)
            if (owner == null)
            {
                throw new InvalidDataException("owner is a required property for LicensePoolPublic and cannot be null");
            }
            else
            {
                this.Owner = owner;
            }
            
            // to ensure "permissions" is required (not null)
            if (permissions == null)
            {
                throw new InvalidDataException("permissions is a required property for LicensePoolPublic and cannot be null");
            }
            else
            {
                this.Permissions = permissions;
            }
            
            // to ensure "product" is required (not null)
            if (product == null)
            {
                throw new InvalidDataException("product is a required property for LicensePoolPublic and cannot be null");
            }
            else
            {
                this.Product = product;
            }
            
            // to ensure "totalActivations" is required (not null)
            if (totalActivations == null)
            {
                throw new InvalidDataException("totalActivations is a required property for LicensePoolPublic and cannot be null");
            }
            else
            {
                this.TotalActivations = totalActivations;
            }
            
            this.Accessors = accessors;
            this.Description = description;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The entities that can access the license though the pool
        /// </summary>
        /// <value>The entities that can access the license though the pool</value>
        [DataMember(Name="accessors", EmitDefaultValue=false)]
        [JsonProperty("accessors")]
        public List<Accessor> Accessors { get; set; } 
        /// <summary>
        /// The number of allowable activations for this license
        /// </summary>
        /// <value>The number of allowable activations for this license</value>
        [DataMember(Name="allowed_activations", EmitDefaultValue=false)]
        [JsonProperty("allowed_activations")]
        public int AllowedActivations { get; set; } 
        /// <summary>
        /// The description of the pool
        /// </summary>
        /// <value>The description of the pool</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; } 
        /// <summary>
        /// The ID of the pool
        /// </summary>
        /// <value>The ID of the pool</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public Guid Id { get; set; } 
        /// <summary>
        /// The ID of the license to which the pool provides access
        /// </summary>
        /// <value>The ID of the license to which the pool provides access</value>
        [DataMember(Name="license_id", EmitDefaultValue=false)]
        [JsonProperty("license_id")]
        public string LicenseId { get; set; } 
        /// <summary>
        /// The account that owns the license
        /// </summary>
        /// <value>The account that owns the license</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        [JsonProperty("owner")]
        public AccountPublic Owner { get; set; } 
        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        [JsonProperty("permissions")]
        public UserPermission Permissions { get; set; } 
        /// <summary>
        /// The pollination product to which this pool provides access
        /// </summary>
        /// <value>The pollination product to which this pool provides access</value>
        [DataMember(Name="product", EmitDefaultValue=false)]
        [JsonProperty("product")]
        public string Product { get; set; } 
        /// <summary>
        /// The number of current activations for this license
        /// </summary>
        /// <value>The number of current activations for this license</value>
        [DataMember(Name="total_activations", EmitDefaultValue=false)]
        [JsonProperty("total_activations")]
        public int TotalActivations { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicensePoolPublic {\n");
            sb.Append("  Accessors: ").Append(Accessors).Append("\n");
            sb.Append("  AllowedActivations: ").Append(AllowedActivations).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LicenseId: ").Append(LicenseId).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  TotalActivations: ").Append(TotalActivations).Append("\n");
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
        /// <returns>LicensePoolPublic object</returns>
        public static LicensePoolPublic FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<LicensePoolPublic>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>LicensePoolPublic object</returns>
        public LicensePoolPublic DuplicateLicensePoolPublic()
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
            return this.Equals(input as LicensePoolPublic);
        }

        /// <summary>
        /// Returns true if LicensePoolPublic instances are equal
        /// </summary>
        /// <param name="input">Instance of LicensePoolPublic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicensePoolPublic input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Accessors == input.Accessors ||
                    this.Accessors != null &&
                    input.Accessors != null &&
                    this.Accessors.SequenceEqual(input.Accessors)
                ) && 
                (
                    this.AllowedActivations == input.AllowedActivations ||
                    (this.AllowedActivations != null &&
                    this.AllowedActivations.Equals(input.AllowedActivations))
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
                    this.LicenseId == input.LicenseId ||
                    (this.LicenseId != null &&
                    this.LicenseId.Equals(input.LicenseId))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
                ) && 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
                ) && 
                (
                    this.TotalActivations == input.TotalActivations ||
                    (this.TotalActivations != null &&
                    this.TotalActivations.Equals(input.TotalActivations))
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
                if (this.Accessors != null)
                    hashCode = hashCode * 59 + this.Accessors.GetHashCode();
                if (this.AllowedActivations != null)
                    hashCode = hashCode * 59 + this.AllowedActivations.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LicenseId != null)
                    hashCode = hashCode * 59 + this.LicenseId.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.TotalActivations != null)
                    hashCode = hashCode * 59 + this.TotalActivations.GetHashCode();
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
