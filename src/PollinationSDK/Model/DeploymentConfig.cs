/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.36.0
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
    /// DeploymentConfig
    /// </summary>
    [DataContract]
    public partial class DeploymentConfig :  IEquatable<DeploymentConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentConfig" /> class.
        /// </summary>
        /// <param name="cpuLimit">The maximum number of CPU cores that can be used by the application. (default to 1).</param>
        /// <param name="loginRequired">Whether the application requires login. (default to true).</param>
        /// <param name="memoryLimit">The maximum amount of memory that can be used by the application. (default to 2000).</param>
        public DeploymentConfig
        (
           // Required parameters
           int cpuLimit = 1, bool loginRequired = true, int memoryLimit = 2000// Optional parameters
        )// BaseClass
        {
            // use default value if no "cpuLimit" provided
            if (cpuLimit == null)
            {
                this.CpuLimit =1;
            }
            else
            {
                this.CpuLimit = cpuLimit;
            }
            // use default value if no "loginRequired" provided
            if (loginRequired == null)
            {
                this.LoginRequired =true;
            }
            else
            {
                this.LoginRequired = loginRequired;
            }
            // use default value if no "memoryLimit" provided
            if (memoryLimit == null)
            {
                this.MemoryLimit =2000;
            }
            else
            {
                this.MemoryLimit = memoryLimit;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The maximum number of CPU cores that can be used by the application.
        /// </summary>
        /// <value>The maximum number of CPU cores that can be used by the application.</value>
        [DataMember(Name="cpu_limit", EmitDefaultValue=false)]
        [JsonProperty("cpu_limit")]
        public int CpuLimit { get; set; }  = 1;
        /// <summary>
        /// Whether the application requires login.
        /// </summary>
        /// <value>Whether the application requires login.</value>
        [DataMember(Name="login_required", EmitDefaultValue=false)]
        [JsonProperty("login_required")]
        public bool LoginRequired { get; set; }  = true;
        /// <summary>
        /// The maximum amount of memory that can be used by the application.
        /// </summary>
        /// <value>The maximum amount of memory that can be used by the application.</value>
        [DataMember(Name="memory_limit", EmitDefaultValue=false)]
        [JsonProperty("memory_limit")]
        public int MemoryLimit { get; set; }  = 2000;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeploymentConfig {\n");
            sb.Append("  CpuLimit: ").Append(CpuLimit).Append("\n");
            sb.Append("  LoginRequired: ").Append(LoginRequired).Append("\n");
            sb.Append("  MemoryLimit: ").Append(MemoryLimit).Append("\n");
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
        /// <returns>DeploymentConfig object</returns>
        public static DeploymentConfig FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DeploymentConfig>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DeploymentConfig object</returns>
        public DeploymentConfig DuplicateDeploymentConfig()
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
            return this.Equals(input as DeploymentConfig);
        }

        /// <summary>
        /// Returns true if DeploymentConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of DeploymentConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeploymentConfig input)
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
                    this.LoginRequired == input.LoginRequired ||
                    (this.LoginRequired != null &&
                    this.LoginRequired.Equals(input.LoginRequired))
                ) && 
                (
                    this.MemoryLimit == input.MemoryLimit ||
                    (this.MemoryLimit != null &&
                    this.MemoryLimit.Equals(input.MemoryLimit))
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
                if (this.LoginRequired != null)
                    hashCode = hashCode * 59 + this.LoginRequired.GetHashCode();
                if (this.MemoryLimit != null)
                    hashCode = hashCode * 59 + this.MemoryLimit.GetHashCode();
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
