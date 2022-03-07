/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.27.1
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
    /// ApplicationCreate
    /// </summary>
    [DataContract]
    public partial class ApplicationCreate :  IEquatable<ApplicationCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationCreate" /> class.
        /// </summary>
        /// <param name="description">A description of the application (default to &quot;&quot;).</param>
        /// <param name="image">An image associated with the application (default to &quot;https://picsum.photos/400&quot;).</param>
        /// <param name="keywords">A list of keywords associated with the application.</param>
        /// <param name="license">The license of the application.</param>
        /// <param name="name">The name of the application. Must be unique to a given owner (required).</param>
        /// <param name="_public">Whether or not a application is publicly viewable (default to true).</param>
        /// <param name="source">A link to the source code of the application.</param>
        public ApplicationCreate
        (
           string name, // Required parameters
           string description = "", string image = "https://picsum.photos/400", List<string> keywords= default, string license= default, bool _public = true, string source= default// Optional parameters
        )// BaseClass
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ApplicationCreate and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // use default value if no "description" provided
            if (description == null)
            {
                this.Description ="";
            }
            else
            {
                this.Description = description;
            }
            // use default value if no "image" provided
            if (image == null)
            {
                this.Image ="https://picsum.photos/400";
            }
            else
            {
                this.Image = image;
            }
            this.Keywords = keywords;
            this.License = license;
            // use default value if no "_public" provided
            if (_public == null)
            {
                this.Public =true;
            }
            else
            {
                this.Public = _public;
            }
            this.Source = source;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// A description of the application
        /// </summary>
        /// <value>A description of the application</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; }  = "";
        /// <summary>
        /// An image associated with the application
        /// </summary>
        /// <value>An image associated with the application</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        [JsonProperty("image")]
        public string Image { get; set; }  = "https://picsum.photos/400";
        /// <summary>
        /// A list of keywords associated with the application
        /// </summary>
        /// <value>A list of keywords associated with the application</value>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        [JsonProperty("keywords")]
        public List<string> Keywords { get; set; } 
        /// <summary>
        /// The license of the application
        /// </summary>
        /// <value>The license of the application</value>
        [DataMember(Name="license", EmitDefaultValue=false)]
        [JsonProperty("license")]
        public string License { get; set; } 
        /// <summary>
        /// The name of the application. Must be unique to a given owner
        /// </summary>
        /// <value>The name of the application. Must be unique to a given owner</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// Whether or not a application is publicly viewable
        /// </summary>
        /// <value>Whether or not a application is publicly viewable</value>
        [DataMember(Name="public", EmitDefaultValue=false)]
        [JsonProperty("public")]
        public bool Public { get; set; }  = true;
        /// <summary>
        /// A link to the source code of the application
        /// </summary>
        /// <value>A link to the source code of the application</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        [JsonProperty("source")]
        public string Source { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationCreate {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  License: ").Append(License).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
        /// <returns>ApplicationCreate object</returns>
        public static ApplicationCreate FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ApplicationCreate>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ApplicationCreate object</returns>
        public ApplicationCreate DuplicateApplicationCreate()
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
            return this.Equals(input as ApplicationCreate);
        }

        /// <summary>
        /// Returns true if ApplicationCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationCreate input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    input.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
                ) && 
                (
                    this.License == input.License ||
                    (this.License != null &&
                    this.License.Equals(input.License))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Public == input.Public ||
                    (this.Public != null &&
                    this.Public.Equals(input.Public))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.License != null)
                    hashCode = hashCode * 59 + this.License.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Public != null)
                    hashCode = hashCode * 59 + this.Public.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
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
