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
    /// DeploymentConfig
    /// </summary>
    [DataContract(Name = "DeploymentConfig")]
    public partial class DeploymentConfig : OpenAPIGenBaseModel, IEquatable<DeploymentConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentConfig" /> class.
        /// </summary>
        /// <param name="loginRequired">Whether the application requires login. (default to true).</param>
        /// <param name="cpuLimit">The maximum number of CPU cores that can be used by the application. (default to 1).</param>
        /// <param name="memoryLimit">The maximum amount of memory that can be used by the application. (default to 2000).</param>
        /// <param name="scaleToZero">A boolean toggle to scale deployments down to zero replicas when not used. (default to true).</param>
        /// <param name="entrypointFile">The Streamlit python file to use as an entrypoint to the app (default to &quot;app.py&quot;).</param>
        public DeploymentConfig
        (
            // Required parameters
           bool loginRequired = true, int cpuLimit = 1, int memoryLimit = 2000, bool scaleToZero = true, string entrypointFile = "app.py" // Optional parameters
        ) : base()// BaseClass
        {
            this.LoginRequired = loginRequired;
            this.CpuLimit = cpuLimit;
            this.MemoryLimit = memoryLimit;
            this.ScaleToZero = scaleToZero;
            // use default value if no "entrypointFile" provided
            this.EntrypointFile = entrypointFile ?? "app.py";

            // Set non-required readonly properties with defaultValue
            this.Type = "DeploymentConfig";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "DeploymentConfig";

        /// <summary>
        /// Whether the application requires login.
        /// </summary>
        /// <value>Whether the application requires login.</value>
        [DataMember(Name = "login_required")]
        public bool LoginRequired { get; set; }  = true;
        /// <summary>
        /// The maximum number of CPU cores that can be used by the application.
        /// </summary>
        /// <value>The maximum number of CPU cores that can be used by the application.</value>
        [DataMember(Name = "cpu_limit")]
        public int CpuLimit { get; set; }  = 1;
        /// <summary>
        /// The maximum amount of memory that can be used by the application.
        /// </summary>
        /// <value>The maximum amount of memory that can be used by the application.</value>
        [DataMember(Name = "memory_limit")]
        public int MemoryLimit { get; set; }  = 2000;
        /// <summary>
        /// A boolean toggle to scale deployments down to zero replicas when not used.
        /// </summary>
        /// <value>A boolean toggle to scale deployments down to zero replicas when not used.</value>
        [DataMember(Name = "scale_to_zero")]
        public bool ScaleToZero { get; set; }  = true;
        /// <summary>
        /// The Streamlit python file to use as an entrypoint to the app
        /// </summary>
        /// <value>The Streamlit python file to use as an entrypoint to the app</value>
        [DataMember(Name = "entrypoint_file")]
        public string EntrypointFile { get; set; }  = "app.py";

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DeploymentConfig";
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
            sb.Append("DeploymentConfig:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  LoginRequired: ").Append(this.LoginRequired).Append("\n");
            sb.Append("  CpuLimit: ").Append(this.CpuLimit).Append("\n");
            sb.Append("  MemoryLimit: ").Append(this.MemoryLimit).Append("\n");
            sb.Append("  ScaleToZero: ").Append(this.ScaleToZero).Append("\n");
            sb.Append("  EntrypointFile: ").Append(this.EntrypointFile).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DeploymentConfig object</returns>
        public static DeploymentConfig FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DeploymentConfig>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DeploymentConfig object</returns>
        public virtual DeploymentConfig DuplicateDeploymentConfig()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDeploymentConfig();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateDeploymentConfig();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
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
            return base.Equals(input) && 
                    Extension.Equals(this.LoginRequired, input.LoginRequired) && 
                    Extension.Equals(this.CpuLimit, input.CpuLimit) && 
                    Extension.Equals(this.MemoryLimit, input.MemoryLimit) && 
                    Extension.Equals(this.ScaleToZero, input.ScaleToZero) && 
                    Extension.Equals(this.EntrypointFile, input.EntrypointFile) && 
                    Extension.Equals(this.Type, input.Type);
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
                if (this.LoginRequired != null)
                    hashCode = hashCode * 59 + this.LoginRequired.GetHashCode();
                if (this.CpuLimit != null)
                    hashCode = hashCode * 59 + this.CpuLimit.GetHashCode();
                if (this.MemoryLimit != null)
                    hashCode = hashCode * 59 + this.MemoryLimit.GetHashCode();
                if (this.ScaleToZero != null)
                    hashCode = hashCode * 59 + this.ScaleToZero.GetHashCode();
                if (this.EntrypointFile != null)
                    hashCode = hashCode * 59 + this.EntrypointFile.GetHashCode();
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
            Regex regexType = new Regex(@"^DeploymentConfig$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
