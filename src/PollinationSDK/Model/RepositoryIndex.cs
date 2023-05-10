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
    /// A searchable index for a Queenbee Plugin and Recipe repository
    /// </summary>
    [DataContract(Name = "RepositoryIndex")]
    public partial class RepositoryIndex : OpenAPIGenBaseModel, IEquatable<RepositoryIndex>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryIndex" /> class.
        /// </summary>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="generated">The timestamp at which the index was generated.</param>
        /// <param name="metadata">Extra information about the repository.</param>
        /// <param name="plugin">A dict of plugins accessible by name. Each name key points to a list of plugin versions.</param>
        /// <param name="recipe">A dict of recipes accessible by name. Each name key points to a list of recipesversions.</param>
        public RepositoryIndex
        (
           // Required parameters
           Dictionary<string, string> annotations= default, DateTime generated= default, RepositoryMetadata metadata= default, Dictionary<string, List<PackageVersion>> plugin= default, Dictionary<string, List<PackageVersion>> recipe= default// Optional parameters
        ) : base()// BaseClass
        {
            this.Annotations = annotations;
            this.Generated = generated;
            this.Metadata = metadata;
            this.Plugin = plugin;
            this.Recipe = recipe;

            // Set non-required readonly properties with defaultValue
            this.Type = "RepositoryIndex";
            this.ApiVersion = "v1beta1";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public override string Type { get; protected internal set; }  = "RepositoryIndex";
        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name = "api_version", EmitDefaultValue = true)]
        public string ApiVersion { get; protected internal set; }  = "v1beta1";

        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name = "annotations", EmitDefaultValue = false)]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// The timestamp at which the index was generated
        /// </summary>
        /// <value>The timestamp at which the index was generated</value>
        [DataMember(Name = "generated", EmitDefaultValue = false)]
        public DateTime Generated { get; set; } 
        /// <summary>
        /// Extra information about the repository
        /// </summary>
        /// <value>Extra information about the repository</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public RepositoryMetadata Metadata { get; set; } 
        /// <summary>
        /// A dict of plugins accessible by name. Each name key points to a list of plugin versions
        /// </summary>
        /// <value>A dict of plugins accessible by name. Each name key points to a list of plugin versions</value>
        [DataMember(Name = "plugin", EmitDefaultValue = false)]
        public Dictionary<string, List<PackageVersion>> Plugin { get; set; } 
        /// <summary>
        /// A dict of recipes accessible by name. Each name key points to a list of recipesversions
        /// </summary>
        /// <value>A dict of recipes accessible by name. Each name key points to a list of recipesversions</value>
        [DataMember(Name = "recipe", EmitDefaultValue = false)]
        public Dictionary<string, List<PackageVersion>> Recipe { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "RepositoryIndex";
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
            sb.Append("RepositoryIndex:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Generated: ").Append(Generated).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Plugin: ").Append(Plugin).Append("\n");
            sb.Append("  Recipe: ").Append(Recipe).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>RepositoryIndex object</returns>
        public static RepositoryIndex FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RepositoryIndex>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RepositoryIndex object</returns>
        public virtual RepositoryIndex DuplicateRepositoryIndex()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateRepositoryIndex();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateRepositoryIndex();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as RepositoryIndex);
        }

        /// <summary>
        /// Returns true if RepositoryIndex instances are equal
        /// </summary>
        /// <param name="input">Instance of RepositoryIndex to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepositoryIndex input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && base.Equals(input) && 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && base.Equals(input) && 
                (
                    this.Generated == input.Generated ||
                    (this.Generated != null &&
                    this.Generated.Equals(input.Generated))
                ) && base.Equals(input) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && base.Equals(input) && 
                (
                    this.Plugin == input.Plugin ||
                    this.Plugin != null &&
                    input.Plugin != null &&
                    this.Plugin.SequenceEqual(input.Plugin)
                ) && base.Equals(input) && 
                (
                    this.Recipe == input.Recipe ||
                    this.Recipe != null &&
                    input.Recipe != null &&
                    this.Recipe.SequenceEqual(input.Recipe)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Generated != null)
                    hashCode = hashCode * 59 + this.Generated.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Plugin != null)
                    hashCode = hashCode * 59 + this.Plugin.GetHashCode();
                if (this.Recipe != null)
                    hashCode = hashCode * 59 + this.Recipe.GetHashCode();
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
            Regex regexType = new Regex(@"^RepositoryIndex$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }


            
            // ApiVersion (string) pattern
            Regex regexApiVersion = new Regex(@"^v1beta1$", RegexOptions.CultureInvariant);
            if (false == regexApiVersion.Match(this.ApiVersion).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApiVersion, must match a pattern of " + regexApiVersion, new [] { "ApiVersion" });
            }

            yield break;
        }
    }
}
