/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: 0.0.0
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
    /// Operator Configuration to run in a Docker container
    /// </summary>
    [DataContract]
    public partial class DockerConfig :  IEquatable<DockerConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DockerConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DockerConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DockerConfig" /> class.
        /// </summary>
        /// <param name="image">Docker image name. Must include tag. (required).</param>
        /// <param name="registry">The container registry URLs that this container should be pulled from. Will default to Dockerhub if none is specified..</param>
        /// <param name="workdir">The working directory the entrypoint command of the container runsin. This is used to determine where to load artifacts when running in the container. (required).</param>
        public DockerConfig
        (
           string image, string workdir, // Required parameters
           string registry= default // Optional parameters
        )// BaseClass
        {
            // to ensure "image" is required (not null)
            if (image == null)
            {
                throw new InvalidDataException("image is a required property for DockerConfig and cannot be null");
            }
            else
            {
                this.Image = image;
            }
            
            // to ensure "workdir" is required (not null)
            if (workdir == null)
            {
                throw new InvalidDataException("workdir is a required property for DockerConfig and cannot be null");
            }
            else
            {
                this.Workdir = workdir;
            }
            
            this.Registry = registry;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Docker image name. Must include tag.
        /// </summary>
        /// <value>Docker image name. Must include tag.</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        [JsonProperty("image")]
        public string Image { get; set; } 
        /// <summary>
        /// The container registry URLs that this container should be pulled from. Will default to Dockerhub if none is specified.
        /// </summary>
        /// <value>The container registry URLs that this container should be pulled from. Will default to Dockerhub if none is specified.</value>
        [DataMember(Name="registry", EmitDefaultValue=false)]
        [JsonProperty("registry")]
        public string Registry { get; set; } 
        /// <summary>
        /// The working directory the entrypoint command of the container runsin. This is used to determine where to load artifacts when running in the container.
        /// </summary>
        /// <value>The working directory the entrypoint command of the container runsin. This is used to determine where to load artifacts when running in the container.</value>
        [DataMember(Name="workdir", EmitDefaultValue=false)]
        [JsonProperty("workdir")]
        public string Workdir { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DockerConfig {\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Registry: ").Append(Registry).Append("\n");
            sb.Append("  Workdir: ").Append(Workdir).Append("\n");
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
        /// <returns>DockerConfig object</returns>
        public static DockerConfig FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DockerConfig>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DockerConfig object</returns>
        public DockerConfig DuplicateDockerConfig()
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
            return 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Registry == input.Registry ||
                    (this.Registry != null &&
                    this.Registry.Equals(input.Registry))
                ) && 
                (
                    this.Workdir == input.Workdir ||
                    (this.Workdir != null &&
                    this.Workdir.Equals(input.Workdir))
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
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Registry != null)
                    hashCode = hashCode * 59 + this.Registry.GetHashCode();
                if (this.Workdir != null)
                    hashCode = hashCode * 59 + this.Workdir.GetHashCode();
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
