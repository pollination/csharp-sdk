/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: 0.9.2
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
    /// Package Version  A MetaData object to distinguish a specific package version within a repository index.
    /// </summary>
    [DataContract]
    public partial class PackageVersion :  IEquatable<PackageVersion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageVersion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PackageVersion() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageVersion" /> class.
        /// </summary>
        /// <param name="appVersion">The version of the application code underlying the manifest.</param>
        /// <param name="created">created (required).</param>
        /// <param name="deprecated">Whether this package is deprecated.</param>
        /// <param name="description">A description of what this package does.</param>
        /// <param name="digest">digest (required).</param>
        /// <param name="home">The URL of this package&#39;s home page.</param>
        /// <param name="icon">A URL to an SVG or PNG image to be used as an icon.</param>
        /// <param name="keywords">A list of keywords to search the package by.</param>
        /// <param name="license">The License file string for this package.</param>
        /// <param name="maintainers">A list of maintainers for the package.</param>
        /// <param name="manifest">The package Recipe or Operator manifest.</param>
        /// <param name="name">Package name. Make it descriptive and helpful ;) (required).</param>
        /// <param name="readme">The README file string for this package.</param>
        /// <param name="slug">A slug of the repository name and the package name..</param>
        /// <param name="sources">A list of URLs to source code for this project.</param>
        /// <param name="tag">The tag of the package (required).</param>
        /// <param name="type">The type of Queenbee package (ie: recipe or operator) (default to &quot;&quot;).</param>
        /// <param name="url">url (required).</param>
        public PackageVersion
        (
           DateTime created, string digest, string name, string tag, string url, // Required parameters
           string appVersion= default, bool deprecated= default, string description= default, string home= default, string icon= default, List<string> keywords= default, string license= default, List<Maintainer> maintainers= default, AnyOf<Recipe,Operator> manifest= default, string readme= default, string slug= default, List<string> sources= default, string type = "" // Optional parameters
        )// BaseClass
        {
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for PackageVersion and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            
            // to ensure "digest" is required (not null)
            if (digest == null)
            {
                throw new InvalidDataException("digest is a required property for PackageVersion and cannot be null");
            }
            else
            {
                this.Digest = digest;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for PackageVersion and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "tag" is required (not null)
            if (tag == null)
            {
                throw new InvalidDataException("tag is a required property for PackageVersion and cannot be null");
            }
            else
            {
                this.Tag = tag;
            }
            
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for PackageVersion and cannot be null");
            }
            else
            {
                this.Url = url;
            }
            
            this.AppVersion = appVersion;
            this.Deprecated = deprecated;
            this.Description = description;
            this.Home = home;
            this.Icon = icon;
            this.Keywords = keywords;
            this.License = license;
            this.Maintainers = maintainers;
            this.Manifest = manifest;
            this.Readme = readme;
            this.Slug = slug;
            this.Sources = sources;
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type ="";
            }
            else
            {
                this.Type = type;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The version of the application code underlying the manifest
        /// </summary>
        /// <value>The version of the application code underlying the manifest</value>
        [DataMember(Name="app_version", EmitDefaultValue=false)]
        [JsonProperty("app_version")]
        public string AppVersion { get; set; } 
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        [JsonProperty("created")]
        public DateTime Created { get; set; } 
        /// <summary>
        /// Whether this package is deprecated
        /// </summary>
        /// <value>Whether this package is deprecated</value>
        [DataMember(Name="deprecated", EmitDefaultValue=false)]
        [JsonProperty("deprecated")]
        public bool Deprecated { get; set; } 
        /// <summary>
        /// A description of what this package does
        /// </summary>
        /// <value>A description of what this package does</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; } 
        /// <summary>
        /// Gets or Sets Digest
        /// </summary>
        [DataMember(Name="digest", EmitDefaultValue=false)]
        [JsonProperty("digest")]
        public string Digest { get; set; } 
        /// <summary>
        /// The URL of this package&#39;s home page
        /// </summary>
        /// <value>The URL of this package&#39;s home page</value>
        [DataMember(Name="home", EmitDefaultValue=false)]
        [JsonProperty("home")]
        public string Home { get; set; } 
        /// <summary>
        /// A URL to an SVG or PNG image to be used as an icon
        /// </summary>
        /// <value>A URL to an SVG or PNG image to be used as an icon</value>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        [JsonProperty("icon")]
        public string Icon { get; set; } 
        /// <summary>
        /// A list of keywords to search the package by
        /// </summary>
        /// <value>A list of keywords to search the package by</value>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        [JsonProperty("keywords")]
        public List<string> Keywords { get; set; } 
        /// <summary>
        /// The License file string for this package
        /// </summary>
        /// <value>The License file string for this package</value>
        [DataMember(Name="license", EmitDefaultValue=false)]
        [JsonProperty("license")]
        public string License { get; set; } 
        /// <summary>
        /// A list of maintainers for the package
        /// </summary>
        /// <value>A list of maintainers for the package</value>
        [DataMember(Name="maintainers", EmitDefaultValue=false)]
        [JsonProperty("maintainers")]
        public List<Maintainer> Maintainers { get; set; } 
        /// <summary>
        /// The package Recipe or Operator manifest
        /// </summary>
        /// <value>The package Recipe or Operator manifest</value>
        [DataMember(Name="manifest", EmitDefaultValue=false)]
        [JsonProperty("manifest")]
        public AnyOf<Recipe,Operator> Manifest { get; set; } 
        /// <summary>
        /// Package name. Make it descriptive and helpful ;)
        /// </summary>
        /// <value>Package name. Make it descriptive and helpful ;)</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// The README file string for this package
        /// </summary>
        /// <value>The README file string for this package</value>
        [DataMember(Name="readme", EmitDefaultValue=false)]
        [JsonProperty("readme")]
        public string Readme { get; set; } 
        /// <summary>
        /// A slug of the repository name and the package name.
        /// </summary>
        /// <value>A slug of the repository name and the package name.</value>
        [DataMember(Name="slug", EmitDefaultValue=false)]
        [JsonProperty("slug")]
        public string Slug { get; set; } 
        /// <summary>
        /// A list of URLs to source code for this project
        /// </summary>
        /// <value>A list of URLs to source code for this project</value>
        [DataMember(Name="sources", EmitDefaultValue=false)]
        [JsonProperty("sources")]
        public List<string> Sources { get; set; } 
        /// <summary>
        /// The tag of the package
        /// </summary>
        /// <value>The tag of the package</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        [JsonProperty("tag")]
        public string Tag { get; set; } 
        /// <summary>
        /// The type of Queenbee package (ie: recipe or operator)
        /// </summary>
        /// <value>The type of Queenbee package (ie: recipe or operator)</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }  = "";
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
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
            sb.Append("class PackageVersion {\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Deprecated: ").Append(Deprecated).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Digest: ").Append(Digest).Append("\n");
            sb.Append("  Home: ").Append(Home).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  License: ").Append(License).Append("\n");
            sb.Append("  Maintainers: ").Append(Maintainers).Append("\n");
            sb.Append("  Manifest: ").Append(Manifest).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Readme: ").Append(Readme).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Sources: ").Append(Sources).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
        /// <returns>PackageVersion object</returns>
        public static PackageVersion FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<PackageVersion>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>PackageVersion object</returns>
        public PackageVersion DuplicatePackageVersion()
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
            return this.Equals(input as PackageVersion);
        }

        /// <summary>
        /// Returns true if PackageVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of PackageVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PackageVersion input)
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
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Deprecated == input.Deprecated ||
                    (this.Deprecated != null &&
                    this.Deprecated.Equals(input.Deprecated))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Digest == input.Digest ||
                    (this.Digest != null &&
                    this.Digest.Equals(input.Digest))
                ) && 
                (
                    this.Home == input.Home ||
                    (this.Home != null &&
                    this.Home.Equals(input.Home))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
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
                    this.Maintainers == input.Maintainers ||
                    this.Maintainers != null &&
                    input.Maintainers != null &&
                    this.Maintainers.SequenceEqual(input.Maintainers)
                ) && 
                (
                    this.Manifest == input.Manifest ||
                    (this.Manifest != null &&
                    this.Manifest.Equals(input.Manifest))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Readme == input.Readme ||
                    (this.Readme != null &&
                    this.Readme.Equals(input.Readme))
                ) && 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.Sources == input.Sources ||
                    this.Sources != null &&
                    input.Sources != null &&
                    this.Sources.SequenceEqual(input.Sources)
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.AppVersion != null)
                    hashCode = hashCode * 59 + this.AppVersion.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Deprecated != null)
                    hashCode = hashCode * 59 + this.Deprecated.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Digest != null)
                    hashCode = hashCode * 59 + this.Digest.GetHashCode();
                if (this.Home != null)
                    hashCode = hashCode * 59 + this.Home.GetHashCode();
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.License != null)
                    hashCode = hashCode * 59 + this.License.GetHashCode();
                if (this.Maintainers != null)
                    hashCode = hashCode * 59 + this.Maintainers.GetHashCode();
                if (this.Manifest != null)
                    hashCode = hashCode * 59 + this.Manifest.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Readme != null)
                    hashCode = hashCode * 59 + this.Readme.GetHashCode();
                if (this.Slug != null)
                    hashCode = hashCode * 59 + this.Slug.GetHashCode();
                if (this.Sources != null)
                    hashCode = hashCode * 59 + this.Sources.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
