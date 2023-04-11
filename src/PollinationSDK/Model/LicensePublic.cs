/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.37.0
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
    /// LicensePublic
    /// </summary>
    [DataContract]
    public partial class LicensePublic :  IEquatable<LicensePublic>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public LicenseType Type { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensePublic" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LicensePublic() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensePublic" /> class.
        /// </summary>
        /// <param name="allowedActivations">allowedActivations (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="key">The key used to activate this license. Treat this like a password. (required).</param>
        /// <param name="leaseDuration">leaseDuration (required).</param>
        /// <param name="metadata">metadata (required).</param>
        /// <param name="notes">notes.</param>
        /// <param name="productId">productId (required).</param>
        /// <param name="revoked">revoked (required).</param>
        /// <param name="serverSyncGracePeriod">serverSyncGracePeriod (required).</param>
        /// <param name="serverSyncInterval">serverSyncInterval (required).</param>
        /// <param name="suspended">suspended (required).</param>
        /// <param name="totalActivations">totalActivations (required).</param>
        /// <param name="totalDeactivations">totalDeactivations (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="validity">validity (required).</param>
        public LicensePublic
        (
           int allowedActivations, DateTime createdAt, string id, string key, int leaseDuration, List<Metadata> metadata, string productId, bool revoked, int serverSyncGracePeriod, int serverSyncInterval, bool suspended, int totalActivations, int totalDeactivations, LicenseType type, DateTime updatedAt, int validity, // Required parameters
           string notes= default // Optional parameters
        )// BaseClass
        {
            // to ensure "allowedActivations" is required (not null)
            if (allowedActivations == null)
            {
                throw new InvalidDataException("allowedActivations is a required property for LicensePublic and cannot be null");
            }
            else
            {
                this.AllowedActivations = allowedActivations;
            }
            
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for LicensePublic and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for LicensePublic and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for LicensePublic and cannot be null");
            }
            else
            {
                this.Key = key;
            }
            
            // to ensure "leaseDuration" is required (not null)
            if (leaseDuration == null)
            {
                throw new InvalidDataException("leaseDuration is a required property for LicensePublic and cannot be null");
            }
            else
            {
                this.LeaseDuration = leaseDuration;
            }
            
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new InvalidDataException("metadata is a required property for LicensePublic and cannot be null");
            }
            else
            {
                this.Metadata = metadata;
            }
            
            // to ensure "productId" is required (not null)
            if (productId == null)
            {
                throw new InvalidDataException("productId is a required property for LicensePublic and cannot be null");
            }
            else
            {
                this.ProductId = productId;
            }
            
            // to ensure "revoked" is required (not null)
            if (revoked == null)
            {
                throw new InvalidDataException("revoked is a required property for LicensePublic and cannot be null");
            }
            else
            {
                this.Revoked = revoked;
            }
            
            // to ensure "serverSyncGracePeriod" is required (not null)
            if (serverSyncGracePeriod == null)
            {
                throw new InvalidDataException("serverSyncGracePeriod is a required property for LicensePublic and cannot be null");
            }
            else
            {
                this.ServerSyncGracePeriod = serverSyncGracePeriod;
            }
            
            // to ensure "serverSyncInterval" is required (not null)
            if (serverSyncInterval == null)
            {
                throw new InvalidDataException("serverSyncInterval is a required property for LicensePublic and cannot be null");
            }
            else
            {
                this.ServerSyncInterval = serverSyncInterval;
            }
            
            // to ensure "suspended" is required (not null)
            if (suspended == null)
            {
                throw new InvalidDataException("suspended is a required property for LicensePublic and cannot be null");
            }
            else
            {
                this.Suspended = suspended;
            }
            
            // to ensure "totalActivations" is required (not null)
            if (totalActivations == null)
            {
                throw new InvalidDataException("totalActivations is a required property for LicensePublic and cannot be null");
            }
            else
            {
                this.TotalActivations = totalActivations;
            }
            
            // to ensure "totalDeactivations" is required (not null)
            if (totalDeactivations == null)
            {
                throw new InvalidDataException("totalDeactivations is a required property for LicensePublic and cannot be null");
            }
            else
            {
                this.TotalDeactivations = totalDeactivations;
            }
            
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for LicensePublic and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            
            // to ensure "updatedAt" is required (not null)
            if (updatedAt == null)
            {
                throw new InvalidDataException("updatedAt is a required property for LicensePublic and cannot be null");
            }
            else
            {
                this.UpdatedAt = updatedAt;
            }
            
            // to ensure "validity" is required (not null)
            if (validity == null)
            {
                throw new InvalidDataException("validity is a required property for LicensePublic and cannot be null");
            }
            else
            {
                this.Validity = validity;
            }
            
            this.Notes = notes;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets AllowedActivations
        /// </summary>
        [DataMember(Name="allowed_activations", EmitDefaultValue=false)]
        [JsonProperty("allowed_activations")]
        public int AllowedActivations { get; set; } 
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; } 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public string Id { get; set; } 
        /// <summary>
        /// The key used to activate this license. Treat this like a password.
        /// </summary>
        /// <value>The key used to activate this license. Treat this like a password.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        [JsonProperty("key")]
        public string Key { get; set; } 
        /// <summary>
        /// Gets or Sets LeaseDuration
        /// </summary>
        [DataMember(Name="lease_duration", EmitDefaultValue=false)]
        [JsonProperty("lease_duration")]
        public int LeaseDuration { get; set; } 
        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        [JsonProperty("metadata")]
        public List<Metadata> Metadata { get; set; } 
        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        [JsonProperty("notes")]
        public string Notes { get; set; } 
        /// <summary>
        /// Gets or Sets ProductId
        /// </summary>
        [DataMember(Name="product_id", EmitDefaultValue=false)]
        [JsonProperty("product_id")]
        public string ProductId { get; set; } 
        /// <summary>
        /// Gets or Sets Revoked
        /// </summary>
        [DataMember(Name="revoked", EmitDefaultValue=false)]
        [JsonProperty("revoked")]
        public bool Revoked { get; set; } 
        /// <summary>
        /// Gets or Sets ServerSyncGracePeriod
        /// </summary>
        [DataMember(Name="server_sync_grace_period", EmitDefaultValue=false)]
        [JsonProperty("server_sync_grace_period")]
        public int ServerSyncGracePeriod { get; set; } 
        /// <summary>
        /// Gets or Sets ServerSyncInterval
        /// </summary>
        [DataMember(Name="server_sync_interval", EmitDefaultValue=false)]
        [JsonProperty("server_sync_interval")]
        public int ServerSyncInterval { get; set; } 
        /// <summary>
        /// Gets or Sets Suspended
        /// </summary>
        [DataMember(Name="suspended", EmitDefaultValue=false)]
        [JsonProperty("suspended")]
        public bool Suspended { get; set; } 
        /// <summary>
        /// Gets or Sets TotalActivations
        /// </summary>
        [DataMember(Name="total_activations", EmitDefaultValue=false)]
        [JsonProperty("total_activations")]
        public int TotalActivations { get; set; } 
        /// <summary>
        /// Gets or Sets TotalDeactivations
        /// </summary>
        [DataMember(Name="total_deactivations", EmitDefaultValue=false)]
        [JsonProperty("total_deactivations")]
        public int TotalDeactivations { get; set; } 
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; } 
        /// <summary>
        /// Gets or Sets Validity
        /// </summary>
        [DataMember(Name="validity", EmitDefaultValue=false)]
        [JsonProperty("validity")]
        public int Validity { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicensePublic {\n");
            sb.Append("  AllowedActivations: ").Append(AllowedActivations).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  LeaseDuration: ").Append(LeaseDuration).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Revoked: ").Append(Revoked).Append("\n");
            sb.Append("  ServerSyncGracePeriod: ").Append(ServerSyncGracePeriod).Append("\n");
            sb.Append("  ServerSyncInterval: ").Append(ServerSyncInterval).Append("\n");
            sb.Append("  Suspended: ").Append(Suspended).Append("\n");
            sb.Append("  TotalActivations: ").Append(TotalActivations).Append("\n");
            sb.Append("  TotalDeactivations: ").Append(TotalDeactivations).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Validity: ").Append(Validity).Append("\n");
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
        /// <returns>LicensePublic object</returns>
        public static LicensePublic FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<LicensePublic>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>LicensePublic object</returns>
        public LicensePublic DuplicateLicensePublic()
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
            return this.Equals(input as LicensePublic);
        }

        /// <summary>
        /// Returns true if LicensePublic instances are equal
        /// </summary>
        /// <param name="input">Instance of LicensePublic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicensePublic input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.AllowedActivations == input.AllowedActivations ||
                    (this.AllowedActivations != null &&
                    this.AllowedActivations.Equals(input.AllowedActivations))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.LeaseDuration == input.LeaseDuration ||
                    (this.LeaseDuration != null &&
                    this.LeaseDuration.Equals(input.LeaseDuration))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.Revoked == input.Revoked ||
                    (this.Revoked != null &&
                    this.Revoked.Equals(input.Revoked))
                ) && 
                (
                    this.ServerSyncGracePeriod == input.ServerSyncGracePeriod ||
                    (this.ServerSyncGracePeriod != null &&
                    this.ServerSyncGracePeriod.Equals(input.ServerSyncGracePeriod))
                ) && 
                (
                    this.ServerSyncInterval == input.ServerSyncInterval ||
                    (this.ServerSyncInterval != null &&
                    this.ServerSyncInterval.Equals(input.ServerSyncInterval))
                ) && 
                (
                    this.Suspended == input.Suspended ||
                    (this.Suspended != null &&
                    this.Suspended.Equals(input.Suspended))
                ) && 
                (
                    this.TotalActivations == input.TotalActivations ||
                    (this.TotalActivations != null &&
                    this.TotalActivations.Equals(input.TotalActivations))
                ) && 
                (
                    this.TotalDeactivations == input.TotalDeactivations ||
                    (this.TotalDeactivations != null &&
                    this.TotalDeactivations.Equals(input.TotalDeactivations))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Validity == input.Validity ||
                    (this.Validity != null &&
                    this.Validity.Equals(input.Validity))
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
                if (this.AllowedActivations != null)
                    hashCode = hashCode * 59 + this.AllowedActivations.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.LeaseDuration != null)
                    hashCode = hashCode * 59 + this.LeaseDuration.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.Revoked != null)
                    hashCode = hashCode * 59 + this.Revoked.GetHashCode();
                if (this.ServerSyncGracePeriod != null)
                    hashCode = hashCode * 59 + this.ServerSyncGracePeriod.GetHashCode();
                if (this.ServerSyncInterval != null)
                    hashCode = hashCode * 59 + this.ServerSyncInterval.GetHashCode();
                if (this.Suspended != null)
                    hashCode = hashCode * 59 + this.Suspended.GetHashCode();
                if (this.TotalActivations != null)
                    hashCode = hashCode * 59 + this.TotalActivations.GetHashCode();
                if (this.TotalDeactivations != null)
                    hashCode = hashCode * 59 + this.TotalDeactivations.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Validity != null)
                    hashCode = hashCode * 59 + this.Validity.GetHashCode();
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
