/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.17.0-beta.1
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
    /// A list response from a pagination request
    /// </summary>
    [DataContract]
    public partial class RunResultList :  IEquatable<RunResultList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunResultList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RunResultList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RunResultList" /> class.
        /// </summary>
        /// <param name="nextPage">The next page, if this on is not the last.</param>
        /// <param name="page">The current page the pagination request is on (required).</param>
        /// <param name="pageCount">The total number of pages (required).</param>
        /// <param name="perPage">The number of pages per pagination request (required).</param>
        /// <param name="resources">resources (required).</param>
        /// <param name="totalCount">The total number of resources matching the list request (required).</param>
        public RunResultList
        (
           int page, int pageCount, int perPage, List<List<AnyOf<StepStringInput,StepIntegerInput,StepNumberInput,StepBooleanInput,StepFolderInput,StepFileInput,StepPathInput,StepArrayInput,StepJSONObjectInput,StepStringOutput,StepIntegerOutput,StepNumberOutput,StepBooleanOutput,StepFolderOutput,StepFileOutput,StepPathOutput,StepArrayOutput,StepJSONObjectOutput>>> resources, int totalCount, // Required parameters
           int nextPage= default // Optional parameters
        )// BaseClass
        {
            // to ensure "page" is required (not null)
            if (page == null)
            {
                throw new InvalidDataException("page is a required property for RunResultList and cannot be null");
            }
            else
            {
                this.Page = page;
            }
            
            // to ensure "pageCount" is required (not null)
            if (pageCount == null)
            {
                throw new InvalidDataException("pageCount is a required property for RunResultList and cannot be null");
            }
            else
            {
                this.PageCount = pageCount;
            }
            
            // to ensure "perPage" is required (not null)
            if (perPage == null)
            {
                throw new InvalidDataException("perPage is a required property for RunResultList and cannot be null");
            }
            else
            {
                this.PerPage = perPage;
            }
            
            // to ensure "resources" is required (not null)
            if (resources == null)
            {
                throw new InvalidDataException("resources is a required property for RunResultList and cannot be null");
            }
            else
            {
                this.Resources = resources;
            }
            
            // to ensure "totalCount" is required (not null)
            if (totalCount == null)
            {
                throw new InvalidDataException("totalCount is a required property for RunResultList and cannot be null");
            }
            else
            {
                this.TotalCount = totalCount;
            }
            
            this.NextPage = nextPage;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The next page, if this on is not the last
        /// </summary>
        /// <value>The next page, if this on is not the last</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        [JsonProperty("next_page")]
        public int NextPage { get; set; } 
        /// <summary>
        /// The current page the pagination request is on
        /// </summary>
        /// <value>The current page the pagination request is on</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        [JsonProperty("page")]
        public int Page { get; set; } 
        /// <summary>
        /// The total number of pages
        /// </summary>
        /// <value>The total number of pages</value>
        [DataMember(Name="page_count", EmitDefaultValue=false)]
        [JsonProperty("page_count")]
        public int PageCount { get; set; } 
        /// <summary>
        /// The number of pages per pagination request
        /// </summary>
        /// <value>The number of pages per pagination request</value>
        [DataMember(Name="per_page", EmitDefaultValue=false)]
        [JsonProperty("per_page")]
        public int PerPage { get; set; } 
        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [DataMember(Name="resources", EmitDefaultValue=false)]
        [JsonProperty("resources")]
        public List<List<AnyOf<StepStringInput,StepIntegerInput,StepNumberInput,StepBooleanInput,StepFolderInput,StepFileInput,StepPathInput,StepArrayInput,StepJSONObjectInput,StepStringOutput,StepIntegerOutput,StepNumberOutput,StepBooleanOutput,StepFolderOutput,StepFileOutput,StepPathOutput,StepArrayOutput,StepJSONObjectOutput>>> Resources { get; set; } 
        /// <summary>
        /// The total number of resources matching the list request
        /// </summary>
        /// <value>The total number of resources matching the list request</value>
        [DataMember(Name="total_count", EmitDefaultValue=false)]
        [JsonProperty("total_count")]
        public int TotalCount { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunResultList {\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
        /// <returns>RunResultList object</returns>
        public static RunResultList FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RunResultList>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RunResultList object</returns>
        public RunResultList DuplicateRunResultList()
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
            return this.Equals(input as RunResultList);
        }

        /// <summary>
        /// Returns true if RunResultList instances are equal
        /// </summary>
        /// <param name="input">Instance of RunResultList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunResultList input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.PageCount == input.PageCount ||
                    (this.PageCount != null &&
                    this.PageCount.Equals(input.PageCount))
                ) && 
                (
                    this.PerPage == input.PerPage ||
                    (this.PerPage != null &&
                    this.PerPage.Equals(input.PerPage))
                ) && 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    input.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
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
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.PageCount != null)
                    hashCode = hashCode * 59 + this.PageCount.GetHashCode();
                if (this.PerPage != null)
                    hashCode = hashCode * 59 + this.PerPage.GetHashCode();
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
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
