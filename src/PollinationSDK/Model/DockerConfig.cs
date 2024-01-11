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
    /// Plugin Configuration to run in a Docker container
    /// </summary>
    [DataContract(Name = "DockerConfig")]
    public partial class DockerConfig : OpenAPIGenBaseModel, IEquatable<DockerConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DockerConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DockerConfig() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "DockerConfig";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DockerConfig" /> class.
        /// </summary>
        /// <param name="image">Docker image name. Must include tag. (required).</param>
        /// <param name="workdir">The working directory the entrypoint command of the container runsin. This is used to determine where to load artifacts when running in the container. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="registry">The container registry URLs that this container should be pulled from. Will default to Dockerhub if none is specified..</param>
        public DockerConfig
        (
           string image, string workdir, // Required parameters
           Dictionary<string, string> annotations= default, string registry= default// Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "image" is required (not null)
            this.Image = image ?? throw new ArgumentNullException("image is a required property for DockerConfig and cannot be null");
            // to ensure "workdir" is required (not null)
            this.Workdir = workdir ?? throw new ArgumentNullException("workdir is a required property for DockerConfig and cannot be null");
            this.Annotations = annotations;
            this.Registry = registry;

            // Set non-required readonly properties with defaultValue
            this.Type = "DockerConfig";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "DockerConfig";

        /// <summary>
        /// Docker image name. Must include tag.
        /// </summary>
        /// <value>Docker image name. Must include tag.</value>
        [DataMember(Name = "image", IsRequired = true)]
        public string Image { get; set; } 
        /// <summary>
        /// The working directory the entrypoint command of the container runsin. This is used to determine where to load artifacts when running in the container.
        /// </summary>
        /// <value>The working directory the entrypoint command of the container runsin. This is used to determine where to load artifacts when running in the container.</value>
        [DataMember(Name = "workdir", IsRequired = true)]
        public string Workdir { get; set; } 
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name = "annotations")]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// The container registry URLs that this container should be pulled from. Will default to Dockerhub if none is specified.
        /// </summary>
        /// <value>The container registry URLs that this container should be pulled from. Will default to Dockerhub if none is specified.</value>
        [DataMember(Name = "registry")]
        public string Registry { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DockerConfig";
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
            sb.Append("DockerConfig:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Image: ").Append(this.Image).Append("\n");
            sb.Append("  Workdir: ").Append(this.Workdir).Append("\n");
            sb.Append("  Annotations: ").Append(this.Annotations).Append("\n");
            sb.Append("  Registry: ").Append(this.Registry).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DockerConfig object</returns>
        public static DockerConfig FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DockerConfig>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DockerConfig object</returns>
        public virtual DockerConfig DuplicateDockerConfig()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDockerConfig();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateDockerConfig();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as DockerConfig);
        }

        /// <summary>
        /// Returns true if DockerConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of DockerConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DockerConfig input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Image, input.Image) && 
                    Extension.Equals(this.Workdir, input.Workdir) && 
                    Extension.Equals(this.Type, input.Type) && 
                (
                    this.Annotations == input.Annotations ||
                    Extension.AllEquals(this.Annotations, input.Annotations)
                ) && 
                    Extension.Equals(this.Registry, input.Registry);
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
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Workdir != null)
                    hashCode = hashCode * 59 + this.Workdir.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.Registry != null)
                    hashCode = hashCode * 59 + this.Registry.GetHashCode();
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
            Regex regexType = new Regex(@"^DockerConfig", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
