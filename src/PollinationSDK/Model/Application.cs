/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.47.0
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
    /// Application
    /// </summary>
    [DataContract]
    public partial class Application :  IEquatable<Application>, IValidatableObject
    {
        /// <summary>
        /// The SDK used to build the application
        /// </summary>
        /// <value>The SDK used to build the application</value>
        [DataMember(Name="sdk", EmitDefaultValue=false)]
        public SDKEnum? Sdk { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="Application" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Application() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Application" /> class.
        /// </summary>
        /// <param name="deploymentConfig">The deployment configuration for the application.</param>
        /// <param name="description">A description of the application (default to &quot;&quot;).</param>
        /// <param name="hasBeenDeployed">Whether or not the application has been deployed (required).</param>
        /// <param name="id">The application ID (required).</param>
        /// <param name="image">An image associated with the application (default to &quot;https://picsum.photos/400&quot;).</param>
        /// <param name="isPaid">Whether or not the application is paid (default to false).</param>
        /// <param name="keywords">A list of keywords associated with the application.</param>
        /// <param name="license">The license of the application.</param>
        /// <param name="name">The name of the application. Must be unique to a given owner (required).</param>
        /// <param name="owner">The application owner (required).</param>
        /// <param name="permissions">permissions (required).</param>
        /// <param name="_public">Whether or not a application is publicly viewable (default to true).</param>
        /// <param name="sdk">The SDK used to build the application.</param>
        /// <param name="slug">The application name in slug format (required).</param>
        /// <param name="source">A link to the source code of the application.</param>
        /// <param name="url">The URL of the application deployment.</param>
        public Application
        (
           bool hasBeenDeployed, string id, string name, AccountPublic owner, UserPermission permissions, string slug, // Required parameters
           DeploymentConfig deploymentConfig= default, string description = "", string image = "https://picsum.photos/400", bool isPaid = false, List<string> keywords= default, string license= default, bool _public = true, SDKEnum? sdk= default, string source= default, string url= default// Optional parameters
        )// BaseClass
        {
            // to ensure "hasBeenDeployed" is required (not null)
            if (hasBeenDeployed == null)
            {
                throw new InvalidDataException("hasBeenDeployed is a required property for Application and cannot be null");
            }
            else
            {
                this.HasBeenDeployed = hasBeenDeployed;
            }
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Application and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Application and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "owner" is required (not null)
            if (owner == null)
            {
                throw new InvalidDataException("owner is a required property for Application and cannot be null");
            }
            else
            {
                this.Owner = owner;
            }
            
            // to ensure "permissions" is required (not null)
            if (permissions == null)
            {
                throw new InvalidDataException("permissions is a required property for Application and cannot be null");
            }
            else
            {
                this.Permissions = permissions;
            }
            
            // to ensure "slug" is required (not null)
            if (slug == null)
            {
                throw new InvalidDataException("slug is a required property for Application and cannot be null");
            }
            else
            {
                this.Slug = slug;
            }
            
            this.DeploymentConfig = deploymentConfig;
            // use default value if no "description" provided
            if (description == null)
            {
                this.Description ="";
            }
            else
            {
                this.Description = description;
            }
            // use default value if no "image" provided
            if (image == null)
            {
                this.Image ="https://picsum.photos/400";
            }
            else
            {
                this.Image = image;
            }
            // use default value if no "isPaid" provided
            if (isPaid == null)
            {
                this.IsPaid =false;
            }
            else
            {
                this.IsPaid = isPaid;
            }
            this.Keywords = keywords;
            this.License = license;
            // use default value if no "_public" provided
            if (_public == null)
            {
                this.Public =true;
            }
            else
            {
                this.Public = _public;
            }
            this.Sdk = sdk;
            this.Source = source;
            this.Url = url;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The deployment configuration for the application
        /// </summary>
        /// <value>The deployment configuration for the application</value>
        [DataMember(Name="deployment_config", EmitDefaultValue=false)]
        [JsonProperty("deployment_config")]
        public DeploymentConfig DeploymentConfig { get; set; } 
        /// <summary>
        /// A description of the application
        /// </summary>
        /// <value>A description of the application</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; }  = "";
        /// <summary>
        /// Whether or not the application has been deployed
        /// </summary>
        /// <value>Whether or not the application has been deployed</value>
        [DataMember(Name="has_been_deployed", EmitDefaultValue=false)]
        [JsonProperty("has_been_deployed")]
        public bool HasBeenDeployed { get; set; } 
        /// <summary>
        /// The application ID
        /// </summary>
        /// <value>The application ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public string Id { get; set; } 
        /// <summary>
        /// An image associated with the application
        /// </summary>
        /// <value>An image associated with the application</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        [JsonProperty("image")]
        public string Image { get; set; }  = "https://picsum.photos/400";
        /// <summary>
        /// Whether or not the application is paid
        /// </summary>
        /// <value>Whether or not the application is paid</value>
        [DataMember(Name="is_paid", EmitDefaultValue=false)]
        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }  = false;
        /// <summary>
        /// A list of keywords associated with the application
        /// </summary>
        /// <value>A list of keywords associated with the application</value>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        [JsonProperty("keywords")]
        public List<string> Keywords { get; set; } 
        /// <summary>
        /// The license of the application
        /// </summary>
        /// <value>The license of the application</value>
        [DataMember(Name="license", EmitDefaultValue=false)]
        [JsonProperty("license")]
        public string License { get; set; } 
        /// <summary>
        /// The name of the application. Must be unique to a given owner
        /// </summary>
        /// <value>The name of the application. Must be unique to a given owner</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// The application owner
        /// </summary>
        /// <value>The application owner</value>
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
        /// Whether or not a application is publicly viewable
        /// </summary>
        /// <value>Whether or not a application is publicly viewable</value>
        [DataMember(Name="public", EmitDefaultValue=false)]
        [JsonProperty("public")]
        public bool Public { get; set; }  = true;
        /// <summary>
        /// The application name in slug format
        /// </summary>
        /// <value>The application name in slug format</value>
        [DataMember(Name="slug", EmitDefaultValue=false)]
        [JsonProperty("slug")]
        public string Slug { get; set; } 
        /// <summary>
        /// A link to the source code of the application
        /// </summary>
        /// <value>A link to the source code of the application</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        [JsonProperty("source")]
        public string Source { get; set; } 
        /// <summary>
        /// The URL of the application deployment
        /// </summary>
        /// <value>The URL of the application deployment</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        [JsonProperty("url")]
        public string Url { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Application {\n");
            sb.Append("  DeploymentConfig: ").Append(DeploymentConfig).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  HasBeenDeployed: ").Append(HasBeenDeployed).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  IsPaid: ").Append(IsPaid).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  License: ").Append(License).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  Sdk: ").Append(Sdk).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
        /// <returns>Application object</returns>
        public static Application FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Application>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Application object</returns>
        public Application DuplicateApplication()
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
            return this.Equals(input as Application);
        }

        /// <summary>
        /// Returns true if Application instances are equal
        /// </summary>
        /// <param name="input">Instance of Application to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Application input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.DeploymentConfig == input.DeploymentConfig ||
                    (this.DeploymentConfig != null &&
                    this.DeploymentConfig.Equals(input.DeploymentConfig))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.HasBeenDeployed == input.HasBeenDeployed ||
                    (this.HasBeenDeployed != null &&
                    this.HasBeenDeployed.Equals(input.HasBeenDeployed))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.IsPaid == input.IsPaid ||
                    (this.IsPaid != null &&
                    this.IsPaid.Equals(input.IsPaid))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    input.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
                ) && 
                (
                    this.License == input.License ||
                    (this.License != null &&
                    this.License.Equals(input.License))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.Public == input.Public ||
                    (this.Public != null &&
                    this.Public.Equals(input.Public))
                ) && 
                (
                    this.Sdk == input.Sdk ||
                    (this.Sdk != null &&
                    this.Sdk.Equals(input.Sdk))
                ) && 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.DeploymentConfig != null)
                    hashCode = hashCode * 59 + this.DeploymentConfig.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.HasBeenDeployed != null)
                    hashCode = hashCode * 59 + this.HasBeenDeployed.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.IsPaid != null)
                    hashCode = hashCode * 59 + this.IsPaid.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.License != null)
                    hashCode = hashCode * 59 + this.License.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.Public != null)
                    hashCode = hashCode * 59 + this.Public.GetHashCode();
                if (this.Sdk != null)
                    hashCode = hashCode * 59 + this.Sdk.GetHashCode();
                if (this.Slug != null)
                    hashCode = hashCode * 59 + this.Slug.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
