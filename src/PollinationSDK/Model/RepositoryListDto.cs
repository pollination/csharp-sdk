/* 
 * Pollination Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.8.8
 * 
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


namespace PollinationSDK.Model
{
    /// <summary>
    /// A list response from a pagination request
    /// </summary>
    [DataContract]
    public partial class RepositoryListDto :  IEquatable<RepositoryListDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryListDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RepositoryListDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryListDto" /> class.
        /// </summary>
        /// <param name="page">The current page the pagination request is on (required).</param>
        /// <param name="perPage">The number of pages per pagination request (required).</param>
        /// <param name="nextPage">The next page, if this on is not the last.</param>
        /// <param name="pageCount">The total number of pages (required).</param>
        /// <param name="totalCount">The total number of resources matching the list request (required).</param>
        /// <param name="resources">resources (required).</param>
        public RepositoryListDto
        (
           int page, int perPage, int pageCount, int totalCount, List<RepositoryAbridgedDto> resources, // Required parameters
           int nextPage= default // Optional parameters
        )// BaseClass
        {
            // to ensure "page" is required (not null)
            if (page == null)
            {
                throw new InvalidDataException("page is a required property for RepositoryListDto and cannot be null");
            }
            else
            {
                this.Page = page;
            }
            
            // to ensure "perPage" is required (not null)
            if (perPage == null)
            {
                throw new InvalidDataException("perPage is a required property for RepositoryListDto and cannot be null");
            }
            else
            {
                this.PerPage = perPage;
            }
            
            // to ensure "pageCount" is required (not null)
            if (pageCount == null)
            {
                throw new InvalidDataException("pageCount is a required property for RepositoryListDto and cannot be null");
            }
            else
            {
                this.PageCount = pageCount;
            }
            
            // to ensure "totalCount" is required (not null)
            if (totalCount == null)
            {
                throw new InvalidDataException("totalCount is a required property for RepositoryListDto and cannot be null");
            }
            else
            {
                this.TotalCount = totalCount;
            }
            
            // to ensure "resources" is required (not null)
            if (resources == null)
            {
                throw new InvalidDataException("resources is a required property for RepositoryListDto and cannot be null");
            }
            else
            {
                this.Resources = resources;
            }
            
            this.NextPage = nextPage;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The current page the pagination request is on
        /// </summary>
        /// <value>The current page the pagination request is on</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        [JsonProperty("page")]
        public int Page { get; set; } 
        /// <summary>
        /// The number of pages per pagination request
        /// </summary>
        /// <value>The number of pages per pagination request</value>
        [DataMember(Name="per_page", EmitDefaultValue=false)]
        [JsonProperty("per_page")]
        public int PerPage { get; set; } 
        /// <summary>
        /// The next page, if this on is not the last
        /// </summary>
        /// <value>The next page, if this on is not the last</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        [JsonProperty("next_page")]
        public int NextPage { get; set; } 
        /// <summary>
        /// The total number of pages
        /// </summary>
        /// <value>The total number of pages</value>
        [DataMember(Name="page_count", EmitDefaultValue=false)]
        [JsonProperty("page_count")]
        public int PageCount { get; set; } 
        /// <summary>
        /// The total number of resources matching the list request
        /// </summary>
        /// <value>The total number of resources matching the list request</value>
        [DataMember(Name="total_count", EmitDefaultValue=false)]
        [JsonProperty("total_count")]
        public int TotalCount { get; set; } 
        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [DataMember(Name="resources", EmitDefaultValue=false)]
        [JsonProperty("resources")]
        public List<RepositoryAbridgedDto> Resources { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryListDto {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
        /// <returns>RepositoryListDto object</returns>
        public static RepositoryListDto FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RepositoryListDto>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RepositoryListDto object</returns>
        public RepositoryListDto DuplicateRepositoryListDto()
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
            return this.Equals(input as RepositoryListDto);
        }

        /// <summary>
        /// Returns true if RepositoryListDto instances are equal
        /// </summary>
        /// <param name="input">Instance of RepositoryListDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepositoryListDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.PerPage == input.PerPage ||
                    (this.PerPage != null &&
                    this.PerPage.Equals(input.PerPage))
                ) && 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
                ) && 
                (
                    this.PageCount == input.PageCount ||
                    (this.PageCount != null &&
                    this.PageCount.Equals(input.PageCount))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
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
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.PerPage != null)
                    hashCode = hashCode * 59 + this.PerPage.GetHashCode();
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
                if (this.PageCount != null)
                    hashCode = hashCode * 59 + this.PageCount.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
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
