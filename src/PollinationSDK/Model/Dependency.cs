/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.17.0
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
    /// Configuration to fetch a Recipe or Plugin that another Recipe depends on.
    /// </summary>
    [DataContract]
    public partial class Dependency :  IEquatable<Dependency>, IValidatableObject
    {
        /// <summary>
        /// The kind of dependency. It can be a recipe or an plugin.
        /// </summary>
        /// <value>The kind of dependency. It can be a recipe or an plugin.</value>
        [DataMember(Name="kind", EmitDefaultValue=false)]
        public DependencyKind Kind { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="Dependency" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Dependency() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Dependency" /> class.
        /// </summary>
        /// <param name="alias">An optional alias to refer to this dependency. Useful if the name is already used somewhere else..</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="hash">The digest hash of the dependency when retrieved from its source. This is locked when the resource dependencies are downloaded..</param>
        /// <param name="kind">The kind of dependency. It can be a recipe or an plugin. (required).</param>
        /// <param name="name">Workflow name. This name should be unique among all the resources in your resource. Use an alias if this is not the case. (required).</param>
        /// <param name="source">URL to a repository where this resource can be found. (required).</param>
        /// <param name="tag">Tag of the resource. (required).</param>
        public Dependency
        (
           DependencyKind kind, string name, string source, string tag, // Required parameters
           string alias= default, Dictionary<string, string> annotations= default, string hash= default // Optional parameters
        )// BaseClass
        {
            // to ensure "kind" is required (not null)
            if (kind == null)
            {
                throw new InvalidDataException("kind is a required property for Dependency and cannot be null");
            }
            else
            {
                this.Kind = kind;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Dependency and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new InvalidDataException("source is a required property for Dependency and cannot be null");
            }
            else
            {
                this.Source = source;
            }
            
            // to ensure "tag" is required (not null)
            if (tag == null)
            {
                throw new InvalidDataException("tag is a required property for Dependency and cannot be null");
            }
            else
            {
                this.Tag = tag;
            }
            
            this.Alias = alias;
            this.Annotations = annotations;
            this.Hash = hash;

            // Set non-required readonly properties with defaultValue
            this.Type = "Dependency";
        }
        
        /// <summary>
        /// An optional alias to refer to this dependency. Useful if the name is already used somewhere else.
        /// </summary>
        /// <value>An optional alias to refer to this dependency. Useful if the name is already used somewhere else.</value>
        [DataMember(Name="alias", EmitDefaultValue=false)]
        [JsonProperty("alias")]
        public string Alias { get; set; } 
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        [JsonProperty("annotations")]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// The digest hash of the dependency when retrieved from its source. This is locked when the resource dependencies are downloaded.
        /// </summary>
        /// <value>The digest hash of the dependency when retrieved from its source. This is locked when the resource dependencies are downloaded.</value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        [JsonProperty("hash")]
        public string Hash { get; set; } 
        /// <summary>
        /// Workflow name. This name should be unique among all the resources in your resource. Use an alias if this is not the case.
        /// </summary>
        /// <value>Workflow name. This name should be unique among all the resources in your resource. Use an alias if this is not the case.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// URL to a repository where this resource can be found.
        /// </summary>
        /// <value>URL to a repository where this resource can be found.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        [JsonProperty("source")]
        public string Source { get; set; } 
        /// <summary>
        /// Tag of the resource.
        /// </summary>
        /// <value>Tag of the resource.</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        [JsonProperty("tag")]
        public string Tag { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Dependency {\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
        /// <returns>Dependency object</returns>
        public static Dependency FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Dependency>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Dependency object</returns>
        public Dependency DuplicateDependency()
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
            return this.Equals(input as Dependency);
        }

        /// <summary>
        /// Returns true if Dependency instances are equal
        /// </summary>
        /// <param name="input">Instance of Dependency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Dependency input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.Kind == input.Kind ||
                    (this.Kind != null &&
                    this.Kind.Equals(input.Kind))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.Hash != null)
                    hashCode = hashCode * 59 + this.Hash.GetHashCode();
                if (this.Kind != null)
                    hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
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
            // Type (string) pattern
            Regex regexType = new Regex(@"^Dependency$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
