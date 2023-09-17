/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.44.0
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
    /// Activation
    /// </summary>
    [DataContract]
    public partial class Activation :  IEquatable<Activation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Activation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Activation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Activation" /> class.
        /// </summary>
        /// <param name="appVersion">appVersion.</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="hostname">hostname.</param>
        /// <param name="id">id (required).</param>
        /// <param name="lastSyncedAt">lastSyncedAt (required).</param>
        /// <param name="leaseExpiresAt">leaseExpiresAt.</param>
        /// <param name="licenseId">licenseId.</param>
        /// <param name="location">location (required).</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="offline">offline (required).</param>
        /// <param name="os">os.</param>
        /// <param name="osVersion">osVersion.</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="user">The user associated with the activation.</param>
        public Activation
        (
           DateTime createdAt, string id, DateTime lastSyncedAt, Location location, bool offline, DateTime updatedAt, // Required parameters
           string appVersion= default, string hostname= default, DateTime leaseExpiresAt= default, string licenseId= default, List<Metadata> metadata= default, string os= default, string osVersion= default, AccountPublic user= default// Optional parameters
        )// BaseClass
        {
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for Activation and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Activation and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "lastSyncedAt" is required (not null)
            if (lastSyncedAt == null)
            {
                throw new InvalidDataException("lastSyncedAt is a required property for Activation and cannot be null");
            }
            else
            {
                this.LastSyncedAt = lastSyncedAt;
            }
            
            // to ensure "location" is required (not null)
            if (location == null)
            {
                throw new InvalidDataException("location is a required property for Activation and cannot be null");
            }
            else
            {
                this.Location = location;
            }
            
            // to ensure "offline" is required (not null)
            if (offline == null)
            {
                throw new InvalidDataException("offline is a required property for Activation and cannot be null");
            }
            else
            {
                this.Offline = offline;
            }
            
            // to ensure "updatedAt" is required (not null)
            if (updatedAt == null)
            {
                throw new InvalidDataException("updatedAt is a required property for Activation and cannot be null");
            }
            else
            {
                this.UpdatedAt = updatedAt;
            }
            
            this.AppVersion = appVersion;
            this.Hostname = hostname;
            this.LeaseExpiresAt = leaseExpiresAt;
            this.LicenseId = licenseId;
            this.Metadata = metadata;
            this.Os = os;
            this.OsVersion = osVersion;
            this.User = user;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets AppVersion
        /// </summary>
        [DataMember(Name="app_version", EmitDefaultValue=false)]
        [JsonProperty("app_version")]
        public string AppVersion { get; set; } 
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; } 
        /// <summary>
        /// Gets or Sets Hostname
        /// </summary>
        [DataMember(Name="hostname", EmitDefaultValue=false)]
        [JsonProperty("hostname")]
        public string Hostname { get; set; } 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public string Id { get; set; } 
        /// <summary>
        /// Gets or Sets LastSyncedAt
        /// </summary>
        [DataMember(Name="last_synced_at", EmitDefaultValue=false)]
        [JsonProperty("last_synced_at")]
        public DateTime LastSyncedAt { get; set; } 
        /// <summary>
        /// Gets or Sets LeaseExpiresAt
        /// </summary>
        [DataMember(Name="lease_expires_at", EmitDefaultValue=false)]
        [JsonProperty("lease_expires_at")]
        public DateTime LeaseExpiresAt { get; set; } 
        /// <summary>
        /// Gets or Sets LicenseId
        /// </summary>
        [DataMember(Name="license_id", EmitDefaultValue=false)]
        [JsonProperty("license_id")]
        public string LicenseId { get; set; } 
        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        [JsonProperty("location")]
        public Location Location { get; set; } 
        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        [JsonProperty("metadata")]
        public List<Metadata> Metadata { get; set; } 
        /// <summary>
        /// Gets or Sets Offline
        /// </summary>
        [DataMember(Name="offline", EmitDefaultValue=false)]
        [JsonProperty("offline")]
        public bool Offline { get; set; } 
        /// <summary>
        /// Gets or Sets Os
        /// </summary>
        [DataMember(Name="os", EmitDefaultValue=false)]
        [JsonProperty("os")]
        public string Os { get; set; } 
        /// <summary>
        /// Gets or Sets OsVersion
        /// </summary>
        [DataMember(Name="os_version", EmitDefaultValue=false)]
        [JsonProperty("os_version")]
        public string OsVersion { get; set; } 
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; } 
        /// <summary>
        /// The user associated with the activation
        /// </summary>
        /// <value>The user associated with the activation</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        [JsonProperty("user")]
        public AccountPublic User { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Activation {\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastSyncedAt: ").Append(LastSyncedAt).Append("\n");
            sb.Append("  LeaseExpiresAt: ").Append(LeaseExpiresAt).Append("\n");
            sb.Append("  LicenseId: ").Append(LicenseId).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Offline: ").Append(Offline).Append("\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
        /// <returns>Activation object</returns>
        public static Activation FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Activation>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Activation object</returns>
        public Activation DuplicateActivation()
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
            return this.Equals(input as Activation);
        }

        /// <summary>
        /// Returns true if Activation instances are equal
        /// </summary>
        /// <param name="input">Instance of Activation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Activation input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Hostname == input.Hostname ||
                    (this.Hostname != null &&
                    this.Hostname.Equals(input.Hostname))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LastSyncedAt == input.LastSyncedAt ||
                    (this.LastSyncedAt != null &&
                    this.LastSyncedAt.Equals(input.LastSyncedAt))
                ) && 
                (
                    this.LeaseExpiresAt == input.LeaseExpiresAt ||
                    (this.LeaseExpiresAt != null &&
                    this.LeaseExpiresAt.Equals(input.LeaseExpiresAt))
                ) && 
                (
                    this.LicenseId == input.LicenseId ||
                    (this.LicenseId != null &&
                    this.LicenseId.Equals(input.LicenseId))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.Offline == input.Offline ||
                    (this.Offline != null &&
                    this.Offline.Equals(input.Offline))
                ) && 
                (
                    this.Os == input.Os ||
                    (this.Os != null &&
                    this.Os.Equals(input.Os))
                ) && 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.AppVersion != null)
                    hashCode = hashCode * 59 + this.AppVersion.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Hostname != null)
                    hashCode = hashCode * 59 + this.Hostname.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LastSyncedAt != null)
                    hashCode = hashCode * 59 + this.LastSyncedAt.GetHashCode();
                if (this.LeaseExpiresAt != null)
                    hashCode = hashCode * 59 + this.LeaseExpiresAt.GetHashCode();
                if (this.LicenseId != null)
                    hashCode = hashCode * 59 + this.LicenseId.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Offline != null)
                    hashCode = hashCode * 59 + this.Offline.GetHashCode();
                if (this.Os != null)
                    hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.OsVersion != null)
                    hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
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
