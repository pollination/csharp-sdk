/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 1.2.0
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
    /// DeploymentConfigUpdate
    /// </summary>
    [DataContract]
    public partial class DeploymentConfigUpdate :  IEquatable<DeploymentConfigUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentConfigUpdate" /> class.
        /// </summary>
        /// <param name="cpuLimit">The maximum number of CPU cores that can be used by the application..</param>
        /// <param name="entrypointFile">The Streamlit python file to use as an entrypoint to the app.</param>
        /// <param name="loginRequired">Whether the application requires login..</param>
        /// <param name="memoryLimit">The maximum amount of memory that can be used by the application..</param>
        /// <param name="scaleToZero">A boolean toggle to scale deployments down to zero replicas when not used..</param>
        public DeploymentConfigUpdate
        (
           // Required parameters
           int cpuLimit= default, string entrypointFile= default, bool loginRequired= default, int memoryLimit= default, bool scaleToZero= default// Optional parameters
        )// BaseClass
        {
            this.CpuLimit = cpuLimit;
            this.EntrypointFile = entrypointFile;
            this.LoginRequired = loginRequired;
            this.MemoryLimit = memoryLimit;
            this.ScaleToZero = scaleToZero;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The maximum number of CPU cores that can be used by the application.
        /// </summary>
        /// <value>The maximum number of CPU cores that can be used by the application.</value>
        [DataMember(Name="cpu_limit", EmitDefaultValue=false)]
        [JsonProperty("cpu_limit")]
        public int CpuLimit { get; set; } 
        /// <summary>
        /// The Streamlit python file to use as an entrypoint to the app
        /// </summary>
        /// <value>The Streamlit python file to use as an entrypoint to the app</value>
        [DataMember(Name="entrypoint_file", EmitDefaultValue=false)]
        [JsonProperty("entrypoint_file")]
        public string EntrypointFile { get; set; } 
        /// <summary>
        /// Whether the application requires login.
        /// </summary>
        /// <value>Whether the application requires login.</value>
        [DataMember(Name="login_required", EmitDefaultValue=false)]
        [JsonProperty("login_required")]
        public bool LoginRequired { get; set; } 
        /// <summary>
        /// The maximum amount of memory that can be used by the application.
        /// </summary>
        /// <value>The maximum amount of memory that can be used by the application.</value>
        [DataMember(Name="memory_limit", EmitDefaultValue=false)]
        [JsonProperty("memory_limit")]
        public int MemoryLimit { get; set; } 
        /// <summary>
        /// A boolean toggle to scale deployments down to zero replicas when not used.
        /// </summary>
        /// <value>A boolean toggle to scale deployments down to zero replicas when not used.</value>
        [DataMember(Name="scale_to_zero", EmitDefaultValue=false)]
        [JsonProperty("scale_to_zero")]
        public bool ScaleToZero { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeploymentConfigUpdate {\n");
            sb.Append("  CpuLimit: ").Append(CpuLimit).Append("\n");
            sb.Append("  EntrypointFile: ").Append(EntrypointFile).Append("\n");
            sb.Append("  LoginRequired: ").Append(LoginRequired).Append("\n");
            sb.Append("  MemoryLimit: ").Append(MemoryLimit).Append("\n");
            sb.Append("  ScaleToZero: ").Append(ScaleToZero).Append("\n");
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
        /// <returns>DeploymentConfigUpdate object</returns>
        public static DeploymentConfigUpdate FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DeploymentConfigUpdate>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DeploymentConfigUpdate object</returns>
        public DeploymentConfigUpdate DuplicateDeploymentConfigUpdate()
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
            return this.Equals(input as DeploymentConfigUpdate);
        }

        /// <summary>
        /// Returns true if DeploymentConfigUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of DeploymentConfigUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeploymentConfigUpdate input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.CpuLimit == input.CpuLimit ||
                    (this.CpuLimit != null &&
                    this.CpuLimit.Equals(input.CpuLimit))
                ) && 
                (
                    this.EntrypointFile == input.EntrypointFile ||
                    (this.EntrypointFile != null &&
                    this.EntrypointFile.Equals(input.EntrypointFile))
                ) && 
                (
                    this.LoginRequired == input.LoginRequired ||
                    (this.LoginRequired != null &&
                    this.LoginRequired.Equals(input.LoginRequired))
                ) && 
                (
                    this.MemoryLimit == input.MemoryLimit ||
                    (this.MemoryLimit != null &&
                    this.MemoryLimit.Equals(input.MemoryLimit))
                ) && 
                (
                    this.ScaleToZero == input.ScaleToZero ||
                    (this.ScaleToZero != null &&
                    this.ScaleToZero.Equals(input.ScaleToZero))
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
                if (this.CpuLimit != null)
                    hashCode = hashCode * 59 + this.CpuLimit.GetHashCode();
                if (this.EntrypointFile != null)
                    hashCode = hashCode * 59 + this.EntrypointFile.GetHashCode();
                if (this.LoginRequired != null)
                    hashCode = hashCode * 59 + this.LoginRequired.GetHashCode();
                if (this.MemoryLimit != null)
                    hashCode = hashCode * 59 + this.MemoryLimit.GetHashCode();
                if (this.ScaleToZero != null)
                    hashCode = hashCode * 59 + this.ScaleToZero.GetHashCode();
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
