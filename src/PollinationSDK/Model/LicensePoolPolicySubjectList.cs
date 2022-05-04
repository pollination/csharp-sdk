/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.30.1
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
    /// LicensePoolPolicySubjectList
    /// </summary>
    [DataContract]
    public partial class LicensePoolPolicySubjectList :  IEquatable<LicensePoolPolicySubjectList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensePoolPolicySubjectList" /> class.
        /// </summary>
        /// <param name="resources">The list of subjects which currently have access to the pool.</param>
        public LicensePoolPolicySubjectList
        (
           // Required parameters
           List<LicensePoolPolicySubject> resources= default// Optional parameters
        )// BaseClass
        {
            this.Resources = resources;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The list of subjects which currently have access to the pool
        /// </summary>
        /// <value>The list of subjects which currently have access to the pool</value>
        [DataMember(Name="resources", EmitDefaultValue=false)]
        [JsonProperty("resources")]
        public List<LicensePoolPolicySubject> Resources { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicensePoolPolicySubjectList {\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
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
        /// <returns>LicensePoolPolicySubjectList object</returns>
        public static LicensePoolPolicySubjectList FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<LicensePoolPolicySubjectList>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>LicensePoolPolicySubjectList object</returns>
        public LicensePoolPolicySubjectList DuplicateLicensePoolPolicySubjectList()
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
            return this.Equals(input as LicensePoolPolicySubjectList);
        }

        /// <summary>
        /// Returns true if LicensePoolPolicySubjectList instances are equal
        /// </summary>
        /// <param name="input">Instance of LicensePoolPolicySubjectList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicensePoolPolicySubjectList input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    input.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
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
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
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
