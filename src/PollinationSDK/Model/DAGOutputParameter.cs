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
    /// A parameter sourced from within the DAG that is exposed as an output.
    /// </summary>
    [DataContract]
    public partial class DAGOutputParameter :  IEquatable<DAGOutputParameter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGOutputParameter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DAGOutputParameter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGOutputParameter" /> class.
        /// </summary>
        /// <param name="from">The task reference to pull this output variable from. Note, this must be an output variable. (required).</param>
        /// <param name="name">The name of the output variable (required).</param>
        public DAGOutputParameter
        (
           TaskParameterReference from, string name// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new InvalidDataException("from is a required property for DAGOutputParameter and cannot be null");
            }
            else
            {
                this.From = from;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for DAGOutputParameter and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The task reference to pull this output variable from. Note, this must be an output variable.
        /// </summary>
        /// <value>The task reference to pull this output variable from. Note, this must be an output variable.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        [JsonProperty("from")]
        public TaskParameterReference From { get; set; } 
        /// <summary>
        /// The name of the output variable
        /// </summary>
        /// <value>The name of the output variable</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DAGOutputParameter {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
        /// <returns>DAGOutputParameter object</returns>
        public static DAGOutputParameter FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAGOutputParameter>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAGOutputParameter object</returns>
        public DAGOutputParameter DuplicateDAGOutputParameter()
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
            return this.Equals(input as DAGOutputParameter);
        }

        /// <summary>
        /// Returns true if DAGOutputParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of DAGOutputParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAGOutputParameter input)
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
