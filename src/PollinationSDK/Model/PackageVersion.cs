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
    /// Package Version  A MetaData object to distinguish a specific package version within a repository index.
    /// </summary>
    [DataContract(Name = "PackageVersion")]
    public partial class PackageVersion : OpenAPIGenBaseModel, IEquatable<PackageVersion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageVersion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PackageVersion() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "PackageVersion";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageVersion" /> class.
        /// </summary>
        /// <param name="name">Package name. Make it descriptive and helpful ;) (required).</param>
        /// <param name="tag">The tag of the package (required).</param>
        /// <param name="url">url (required).</param>
        /// <param name="created">created (required).</param>
        /// <param name="digest">digest (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="appVersion">The version of the application code underlying the manifest.</param>
        /// <param name="keywords">A list of keywords to search the package by.</param>
        /// <param name="maintainers">A list of maintainers for the package.</param>
        /// <param name="home">The URL of this package&#39;s home page.</param>
        /// <param name="sources">A list of URLs to source code for this project.</param>
        /// <param name="icon">A URL to an SVG or PNG image to be used as an icon.</param>
        /// <param name="deprecated">Whether this package is deprecated.</param>
        /// <param name="description">A description of what this package does.</param>
        /// <param name="license">The license information..</param>
        /// <param name="slug">A slug of the repository name and the package name..</param>
        /// <param name="kind">The type of Queenbee package (ie: recipe or plugin) (default to &quot;&quot;).</param>
        /// <param name="readme">The README file string for this package.</param>
        /// <param name="manifest">The package Recipe or Plugin manifest.</param>
        public PackageVersion
        (
           string name, string tag, string url, DateTime created, string digest, // Required parameters
           Dictionary<string, string> annotations= default, string appVersion= default, List<string> keywords= default, List<Maintainer> maintainers= default, string home= default, List<string> sources= default, string icon= default, bool deprecated= default, string description= default, License license= default, string slug= default, string kind = "", string readme= default, AnyOf<Recipe,Plugin> manifest= default // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for PackageVersion and cannot be null");
            // to ensure "tag" is required (not null)
            this.Tag = tag ?? throw new ArgumentNullException("tag is a required property for PackageVersion and cannot be null");
            // to ensure "url" is required (not null)
            this.Url = url ?? throw new ArgumentNullException("url is a required property for PackageVersion and cannot be null");
            this.Created = created;
            // to ensure "digest" is required (not null)
            this.Digest = digest ?? throw new ArgumentNullException("digest is a required property for PackageVersion and cannot be null");
            this.Annotations = annotations;
            this.AppVersion = appVersion;
            this.Keywords = keywords;
            this.Maintainers = maintainers;
            this.Home = home;
            this.Sources = sources;
            this.Icon = icon;
            this.Deprecated = deprecated;
            this.Description = description;
            this.License = license;
            this.Slug = slug;
            // use default value if no "kind" provided
            this.Kind = kind ?? "";
            this.Readme = readme;
            this.Manifest = manifest;

            // Set non-required readonly properties with defaultValue
            this.Type = "PackageVersion";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; protected internal set; }  = "PackageVersion";

        /// <summary>
        /// Package name. Make it descriptive and helpful ;)
        /// </summary>
        /// <value>Package name. Make it descriptive and helpful ;)</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; } 
        /// <summary>
        /// The tag of the package
        /// </summary>
        /// <value>The tag of the package</value>
        [DataMember(Name = "tag", IsRequired = true, EmitDefaultValue = false)]
        public string Tag { get; set; } 
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = false)]
        public string Url { get; set; } 
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", IsRequired = true, EmitDefaultValue = false)]
        public DateTime Created { get; set; } 
        /// <summary>
        /// Gets or Sets Digest
        /// </summary>
        [DataMember(Name = "digest", IsRequired = true, EmitDefaultValue = false)]
        public string Digest { get; set; } 
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name = "annotations", EmitDefaultValue = false)]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// The version of the application code underlying the manifest
        /// </summary>
        /// <value>The version of the application code underlying the manifest</value>
        [DataMember(Name = "app_version", EmitDefaultValue = false)]
        public string AppVersion { get; set; } 
        /// <summary>
        /// A list of keywords to search the package by
        /// </summary>
        /// <value>A list of keywords to search the package by</value>
        [DataMember(Name = "keywords", EmitDefaultValue = false)]
        public List<string> Keywords { get; set; } 
        /// <summary>
        /// A list of maintainers for the package
        /// </summary>
        /// <value>A list of maintainers for the package</value>
        [DataMember(Name = "maintainers", EmitDefaultValue = false)]
        public List<Maintainer> Maintainers { get; set; } 
        /// <summary>
        /// The URL of this package&#39;s home page
        /// </summary>
        /// <value>The URL of this package&#39;s home page</value>
        [DataMember(Name = "home", EmitDefaultValue = false)]
        public string Home { get; set; } 
        /// <summary>
        /// A list of URLs to source code for this project
        /// </summary>
        /// <value>A list of URLs to source code for this project</value>
        [DataMember(Name = "sources", EmitDefaultValue = false)]
        public List<string> Sources { get; set; } 
        /// <summary>
        /// A URL to an SVG or PNG image to be used as an icon
        /// </summary>
        /// <value>A URL to an SVG or PNG image to be used as an icon</value>
        [DataMember(Name = "icon", EmitDefaultValue = false)]
        public string Icon { get; set; } 
        /// <summary>
        /// Whether this package is deprecated
        /// </summary>
        /// <value>Whether this package is deprecated</value>
        [DataMember(Name = "deprecated", EmitDefaultValue = false)]
        public bool Deprecated { get; set; } 
        /// <summary>
        /// A description of what this package does
        /// </summary>
        /// <value>A description of what this package does</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; } 
        /// <summary>
        /// The license information.
        /// </summary>
        /// <value>The license information.</value>
        [DataMember(Name = "license", EmitDefaultValue = false)]
        public License License { get; set; } 
        /// <summary>
        /// A slug of the repository name and the package name.
        /// </summary>
        /// <value>A slug of the repository name and the package name.</value>
        [DataMember(Name = "slug", EmitDefaultValue = false)]
        public string Slug { get; set; } 
        /// <summary>
        /// The type of Queenbee package (ie: recipe or plugin)
        /// </summary>
        /// <value>The type of Queenbee package (ie: recipe or plugin)</value>
        [DataMember(Name = "kind", EmitDefaultValue = true)]
        public string Kind { get; set; }  = "";
        /// <summary>
        /// The README file string for this package
        /// </summary>
        /// <value>The README file string for this package</value>
        [DataMember(Name = "readme", EmitDefaultValue = false)]
        public string Readme { get; set; } 
        /// <summary>
        /// The package Recipe or Plugin manifest
        /// </summary>
        /// <value>The package Recipe or Plugin manifest</value>
        [DataMember(Name = "manifest", EmitDefaultValue = false)]
        public AnyOf<Recipe,Plugin> Manifest { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "PackageVersion";
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
            sb.Append("PackageVersion:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Digest: ").Append(Digest).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  Maintainers: ").Append(Maintainers).Append("\n");
            sb.Append("  Home: ").Append(Home).Append("\n");
            sb.Append("  Sources: ").Append(Sources).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Deprecated: ").Append(Deprecated).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  License: ").Append(License).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Readme: ").Append(Readme).Append("\n");
            sb.Append("  Manifest: ").Append(Manifest).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>PackageVersion object</returns>
        public static PackageVersion FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<PackageVersion>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>PackageVersion object</returns>
        public virtual PackageVersion DuplicatePackageVersion()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicatePackageVersion();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicatePackageVersion();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
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
            return base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && base.Equals(input) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && base.Equals(input) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && base.Equals(input) && 
                (
                    this.Digest == input.Digest ||
                    (this.Digest != null &&
                    this.Digest.Equals(input.Digest))
                ) && base.Equals(input) && 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && base.Equals(input) && 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && base.Equals(input) && 
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    input.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
                ) && base.Equals(input) && 
                (
                    this.Maintainers == input.Maintainers ||
                    this.Maintainers != null &&
                    input.Maintainers != null &&
                    this.Maintainers.SequenceEqual(input.Maintainers)
                ) && base.Equals(input) && 
                (
                    this.Home == input.Home ||
                    (this.Home != null &&
                    this.Home.Equals(input.Home))
                ) && base.Equals(input) && 
                (
                    this.Sources == input.Sources ||
                    this.Sources != null &&
                    input.Sources != null &&
                    this.Sources.SequenceEqual(input.Sources)
                ) && base.Equals(input) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && base.Equals(input) && 
                (
                    this.Deprecated == input.Deprecated ||
                    (this.Deprecated != null &&
                    this.Deprecated.Equals(input.Deprecated))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.License == input.License ||
                    (this.License != null &&
                    this.License.Equals(input.License))
                ) && base.Equals(input) && 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && base.Equals(input) && 
                (
                    this.Kind == input.Kind ||
                    (this.Kind != null &&
                    this.Kind.Equals(input.Kind))
                ) && base.Equals(input) && 
                (
                    this.Readme == input.Readme ||
                    (this.Readme != null &&
                    this.Readme.Equals(input.Readme))
                ) && base.Equals(input) && 
                (
                    this.Manifest == input.Manifest ||
                    (this.Manifest != null &&
                    this.Manifest.Equals(input.Manifest))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Digest != null)
                    hashCode = hashCode * 59 + this.Digest.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.AppVersion != null)
                    hashCode = hashCode * 59 + this.AppVersion.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.Maintainers != null)
                    hashCode = hashCode * 59 + this.Maintainers.GetHashCode();
                if (this.Home != null)
                    hashCode = hashCode * 59 + this.Home.GetHashCode();
                if (this.Sources != null)
                    hashCode = hashCode * 59 + this.Sources.GetHashCode();
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.Deprecated != null)
                    hashCode = hashCode * 59 + this.Deprecated.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.License != null)
                    hashCode = hashCode * 59 + this.License.GetHashCode();
                if (this.Slug != null)
                    hashCode = hashCode * 59 + this.Slug.GetHashCode();
                if (this.Kind != null)
                    hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.Readme != null)
                    hashCode = hashCode * 59 + this.Readme.GetHashCode();
                if (this.Manifest != null)
                    hashCode = hashCode * 59 + this.Manifest.GetHashCode();
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
            Regex regexType = new Regex(@"^PackageVersion$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
