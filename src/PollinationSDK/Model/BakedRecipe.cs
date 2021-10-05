/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.18.0-beta.2
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
    /// Baked Recipe.  A Baked Recipe contains all the templates referred to in the DAG within a templates list.
    /// </summary>
    [DataContract]
    public partial class BakedRecipe :  IEquatable<BakedRecipe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BakedRecipe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BakedRecipe() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BakedRecipe" /> class.
        /// </summary>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="dependencies">A list of plugins and other recipes this recipe depends on..</param>
        /// <param name="digest">digest (required).</param>
        /// <param name="flow">A list of tasks to create a DAG recipe. (required).</param>
        /// <param name="metadata">Recipe metadata information..</param>
        /// <param name="templates">A list of templates. Templates can be Function or a DAG. (required).</param>
        public BakedRecipe
        (
           string digest, List<DAG> flow, List<AnyOf<TemplateFunction,DAG>> templates, // Required parameters
           Dictionary<string, string> annotations= default, List<Dependency> dependencies= default, MetaData metadata= default // Optional parameters
        )// BaseClass
        {
            // to ensure "digest" is required (not null)
            if (digest == null)
            {
                throw new InvalidDataException("digest is a required property for BakedRecipe and cannot be null");
            }
            else
            {
                this.Digest = digest;
            }
            
            // to ensure "flow" is required (not null)
            if (flow == null)
            {
                throw new InvalidDataException("flow is a required property for BakedRecipe and cannot be null");
            }
            else
            {
                this.Flow = flow;
            }
            
            // to ensure "templates" is required (not null)
            if (templates == null)
            {
                throw new InvalidDataException("templates is a required property for BakedRecipe and cannot be null");
            }
            else
            {
                this.Templates = templates;
            }
            
            this.Annotations = annotations;
            this.Dependencies = dependencies;
            this.Metadata = metadata;

            // Set non-required readonly properties with defaultValue
            this.ApiVersion = "v1beta1";
            this.Type = "BakedRecipe";
        }
        
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        [JsonProperty("annotations")]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// A list of plugins and other recipes this recipe depends on.
        /// </summary>
        /// <value>A list of plugins and other recipes this recipe depends on.</value>
        [DataMember(Name="dependencies", EmitDefaultValue=false)]
        [JsonProperty("dependencies")]
        public List<Dependency> Dependencies { get; set; } 
        /// <summary>
        /// Gets or Sets Digest
        /// </summary>
        [DataMember(Name="digest", EmitDefaultValue=false)]
        [JsonProperty("digest")]
        public string Digest { get; set; } 
        /// <summary>
        /// A list of tasks to create a DAG recipe.
        /// </summary>
        /// <value>A list of tasks to create a DAG recipe.</value>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        [JsonProperty("flow")]
        public List<DAG> Flow { get; set; } 
        /// <summary>
        /// Recipe metadata information.
        /// </summary>
        /// <value>Recipe metadata information.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        [JsonProperty("metadata")]
        public MetaData Metadata { get; set; } 
        /// <summary>
        /// A list of templates. Templates can be Function or a DAG.
        /// </summary>
        /// <value>A list of templates. Templates can be Function or a DAG.</value>
        [DataMember(Name="templates", EmitDefaultValue=false)]
        [JsonProperty("templates")]
        public List<AnyOf<TemplateFunction,DAG>> Templates { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BakedRecipe {\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Dependencies: ").Append(Dependencies).Append("\n");
            sb.Append("  Digest: ").Append(Digest).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Templates: ").Append(Templates).Append("\n");
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
        /// <returns>BakedRecipe object</returns>
        public static BakedRecipe FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<BakedRecipe>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>BakedRecipe object</returns>
        public BakedRecipe DuplicateBakedRecipe()
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
            return this.Equals(input as BakedRecipe);
        }

        /// <summary>
        /// Returns true if BakedRecipe instances are equal
        /// </summary>
        /// <param name="input">Instance of BakedRecipe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BakedRecipe input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.Dependencies == input.Dependencies ||
                    this.Dependencies != null &&
                    input.Dependencies != null &&
                    this.Dependencies.SequenceEqual(input.Dependencies)
                ) && 
                (
                    this.Digest == input.Digest ||
                    (this.Digest != null &&
                    this.Digest.Equals(input.Digest))
                ) && 
                (
                    this.Flow == input.Flow ||
                    this.Flow != null &&
                    input.Flow != null &&
                    this.Flow.SequenceEqual(input.Flow)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Templates == input.Templates ||
                    this.Templates != null &&
                    input.Templates != null &&
                    this.Templates.SequenceEqual(input.Templates)
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
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Dependencies != null)
                    hashCode = hashCode * 59 + this.Dependencies.GetHashCode();
                if (this.Digest != null)
                    hashCode = hashCode * 59 + this.Digest.GetHashCode();
                if (this.Flow != null)
                    hashCode = hashCode * 59 + this.Flow.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Templates != null)
                    hashCode = hashCode * 59 + this.Templates.GetHashCode();
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
            // ApiVersion (string) pattern
            Regex regexApiVersion = new Regex(@"^v1beta1$", RegexOptions.CultureInvariant);
            if (false == regexApiVersion.Match(this.ApiVersion).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApiVersion, must match a pattern of " + regexApiVersion, new [] { "ApiVersion" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^BakedRecipe$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
