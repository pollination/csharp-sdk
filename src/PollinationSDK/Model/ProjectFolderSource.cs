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
    /// Project Folder Source  This is the path to a folder where files and folders can be sourced. In the context of a desktop run Workflow this folder will correspond to a local folder. In the context of a workflow run on Pollination this folder will correspond to a Project scoped folder.
    /// </summary>
    [DataContract]
    public partial class ProjectFolderSource :  IEquatable<ProjectFolderSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectFolderSource" /> class.
        /// </summary>
        /// <param name="path">For a local filesystem this can be \&quot;C:\\Users\\me\\simulations\\test\&quot;. This will correspond to the run specific folder ..</param>
        /// <param name="type">type (default to &quot;project-folder&quot;).</param>
        public ProjectFolderSource
        (
           // Required parameters
           string path= default, string type = "project-folder"// Optional parameters
        )// BaseClass
        {
            this.Path = path;
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type ="project-folder";
            }
            else
            {
                this.Type = type;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// For a local filesystem this can be \&quot;C:\\Users\\me\\simulations\\test\&quot;. This will correspond to the run specific folder .
        /// </summary>
        /// <value>For a local filesystem this can be \&quot;C:\\Users\\me\\simulations\\test\&quot;. This will correspond to the run specific folder .</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        [JsonProperty("path")]
        public string Path { get; set; } 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }  = "project-folder";
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectFolderSource {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
        /// <returns>ProjectFolderSource object</returns>
        public static ProjectFolderSource FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ProjectFolderSource>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ProjectFolderSource object</returns>
        public ProjectFolderSource DuplicateProjectFolderSource()
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
            return this.Equals(input as ProjectFolderSource);
        }

        /// <summary>
        /// Returns true if ProjectFolderSource instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectFolderSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectFolderSource input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
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
            Regex regexType = new Regex(@"^project-folder$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
