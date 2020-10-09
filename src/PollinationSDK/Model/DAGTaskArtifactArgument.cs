/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: 0.9.6
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
    /// Input argument for a DAG task.  The name must correspond to an input artifact from the template function the task refers to.
    /// </summary>
    [DataContract]
    public partial class DAGTaskArtifactArgument :  IEquatable<DAGTaskArtifactArgument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGTaskArtifactArgument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DAGTaskArtifactArgument() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGTaskArtifactArgument" /> class.
        /// </summary>
        /// <param name="from">The previous task or global workflow variable to pull this argument from (required).</param>
        /// <param name="name">Name of the argument variable (required).</param>
        /// <param name="subpath">Specify this value if your source artifact is a repository and you want to source an artifact from within that directory..</param>
        public DAGTaskArtifactArgument
        (
           AnyOf<InputArtifactReference,TaskArtifactReference,FolderArtifactReference> from, string name, // Required parameters
           string subpath= default// Optional parameters
        )// BaseClass
        {
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new InvalidDataException("from is a required property for DAGTaskArtifactArgument and cannot be null");
            }
            else
            {
                this.From = from;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for DAGTaskArtifactArgument and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            this.Subpath = subpath;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The previous task or global workflow variable to pull this argument from
        /// </summary>
        /// <value>The previous task or global workflow variable to pull this argument from</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        [JsonProperty("from")]
        public AnyOf<InputArtifactReference,TaskArtifactReference,FolderArtifactReference> From { get; set; } 
        /// <summary>
        /// Name of the argument variable
        /// </summary>
        /// <value>Name of the argument variable</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// Specify this value if your source artifact is a repository and you want to source an artifact from within that directory.
        /// </summary>
        /// <value>Specify this value if your source artifact is a repository and you want to source an artifact from within that directory.</value>
        [DataMember(Name="subpath", EmitDefaultValue=false)]
        [JsonProperty("subpath")]
        public string Subpath { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DAGTaskArtifactArgument {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Subpath: ").Append(Subpath).Append("\n");
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
        /// <returns>DAGTaskArtifactArgument object</returns>
        public static DAGTaskArtifactArgument FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAGTaskArtifactArgument>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAGTaskArtifactArgument object</returns>
        public DAGTaskArtifactArgument DuplicateDAGTaskArtifactArgument()
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
            return this.Equals(input as DAGTaskArtifactArgument);
        }

        /// <summary>
        /// Returns true if DAGTaskArtifactArgument instances are equal
        /// </summary>
        /// <param name="input">Instance of DAGTaskArtifactArgument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAGTaskArtifactArgument input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Subpath == input.Subpath ||
                    (this.Subpath != null &&
                    this.Subpath.Equals(input.Subpath))
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
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Subpath != null)
                    hashCode = hashCode * 59 + this.Subpath.GetHashCode();
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
