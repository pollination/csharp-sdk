/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.18.0
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
    /// ResourcesDuration
    /// </summary>
    [DataContract]
    public partial class ResourcesDuration :  IEquatable<ResourcesDuration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesDuration" /> class.
        /// </summary>
        /// <param name="cpu">cpu (default to 0).</param>
        /// <param name="memory">memory (default to 0).</param>
        public ResourcesDuration
        (
           // Required parameters
           int cpu = 0, int memory = 0// Optional parameters
        )// BaseClass
        {
            // use default value if no "cpu" provided
            if (cpu == null)
            {
                this.Cpu =0;
            }
            else
            {
                this.Cpu = cpu;
            }
            // use default value if no "memory" provided
            if (memory == null)
            {
                this.Memory =0;
            }
            else
            {
                this.Memory = memory;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Cpu
        /// </summary>
        [DataMember(Name="cpu", EmitDefaultValue=false)]
        [JsonProperty("cpu")]
        public int Cpu { get; set; }  = 0;
        /// <summary>
        /// Gets or Sets Memory
        /// </summary>
        [DataMember(Name="memory", EmitDefaultValue=false)]
        [JsonProperty("memory")]
        public int Memory { get; set; }  = 0;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourcesDuration {\n");
            sb.Append("  Cpu: ").Append(Cpu).Append("\n");
            sb.Append("  Memory: ").Append(Memory).Append("\n");
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
        /// <returns>ResourcesDuration object</returns>
        public static ResourcesDuration FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ResourcesDuration>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ResourcesDuration object</returns>
        public ResourcesDuration DuplicateResourcesDuration()
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
            return this.Equals(input as ResourcesDuration);
        }

        /// <summary>
        /// Returns true if ResourcesDuration instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourcesDuration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourcesDuration input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Cpu == input.Cpu ||
                    (this.Cpu != null &&
                    this.Cpu.Equals(input.Cpu))
                ) && 
                (
                    this.Memory == input.Memory ||
                    (this.Memory != null &&
                    this.Memory.Equals(input.Memory))
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
                if (this.Cpu != null)
                    hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Memory != null)
                    hashCode = hashCode * 59 + this.Memory.GetHashCode();
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