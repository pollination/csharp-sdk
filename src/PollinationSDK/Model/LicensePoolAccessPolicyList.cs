/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.27.2
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
    /// LicensePoolAccessPolicyList
    /// </summary>
    [DataContract]
    public partial class LicensePoolAccessPolicyList :  IEquatable<LicensePoolAccessPolicyList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensePoolAccessPolicyList" /> class.
        /// </summary>
        /// <param name="resources">The list of policies granting access to the pool.</param>
        public LicensePoolAccessPolicyList
        (
           // Required parameters
           List<LicensePoolAccessPolicy> resources= default// Optional parameters
        )// BaseClass
        {
            this.Resources = resources;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The list of policies granting access to the pool
        /// </summary>
        /// <value>The list of policies granting access to the pool</value>
        [DataMember(Name="resources", EmitDefaultValue=false)]
        [JsonProperty("resources")]
        public List<LicensePoolAccessPolicy> Resources { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicensePoolAccessPolicyList {\n");
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
        /// <returns>LicensePoolAccessPolicyList object</returns>
        public static LicensePoolAccessPolicyList FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<LicensePoolAccessPolicyList>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>LicensePoolAccessPolicyList object</returns>
        public LicensePoolAccessPolicyList DuplicateLicensePoolAccessPolicyList()
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
            return this.Equals(input as LicensePoolAccessPolicyList);
        }

        /// <summary>
        /// Returns true if LicensePoolAccessPolicyList instances are equal
        /// </summary>
        /// <param name="input">Instance of LicensePoolAccessPolicyList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicensePoolAccessPolicyList input)
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
