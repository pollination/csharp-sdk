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
    /// A list response from a pagination request
    /// </summary>
    [DataContract(Name = "UserPublicList")]
    public partial class UserPublicList : IEquatable<UserPublicList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPublicList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserPublicList() 
        { 
            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPublicList" /> class.
        /// </summary>
        /// <param name="nextPage">The next page, if this on is not the last.</param>
        /// <param name="page">The current page the pagination request is on (required).</param>
        /// <param name="pageCount">The total number of pages (required).</param>
        /// <param name="perPage">The number of pages per pagination request (required).</param>
        /// <param name="resources">resources (required).</param>
        /// <param name="totalCount">The total number of resources matching the list request (required).</param>
        public UserPublicList
        (
           int page, int pageCount, int perPage, List<UserPublic> resources, int totalCount, // Required parameters
           int nextPage= default // Optional parameters
        )// BaseClass
        {
            this.Page = page;
            this.PageCount = pageCount;
            this.PerPage = perPage;
            // to ensure "resources" is required (not null)
            this.Resources = resources ?? throw new ArgumentNullException("resources is a required property for UserPublicList and cannot be null");
            this.TotalCount = totalCount;
            this.NextPage = nextPage;

            // Set non-required readonly properties with defaultValue
        }


        /// <summary>
        /// The next page, if this on is not the last
        /// </summary>
        /// <value>The next page, if this on is not the last</value>
        [DataMember(Name = "next_page", EmitDefaultValue = false)]
        public int NextPage { get; set; } 
        /// <summary>
        /// The current page the pagination request is on
        /// </summary>
        /// <value>The current page the pagination request is on</value>
        [DataMember(Name = "page", IsRequired = true, EmitDefaultValue = false)]
        public int Page { get; set; } 
        /// <summary>
        /// The total number of pages
        /// </summary>
        /// <value>The total number of pages</value>
        [DataMember(Name = "page_count", IsRequired = true, EmitDefaultValue = false)]
        public int PageCount { get; set; } 
        /// <summary>
        /// The number of pages per pagination request
        /// </summary>
        /// <value>The number of pages per pagination request</value>
        [DataMember(Name = "per_page", IsRequired = true, EmitDefaultValue = false)]
        public int PerPage { get; set; } 
        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [DataMember(Name = "resources", IsRequired = true, EmitDefaultValue = false)]
        public List<UserPublic> Resources { get; set; } 
        /// <summary>
        /// The total number of resources matching the list request
        /// </summary>
        /// <value>The total number of resources matching the list request</value>
        [DataMember(Name = "total_count", IsRequired = true, EmitDefaultValue = false)]
        public int TotalCount { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "UserPublicList";
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
            sb.Append("UserPublicList:\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>UserPublicList object</returns>
        public static UserPublicList FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<UserPublicList>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>UserPublicList object</returns>
        public virtual UserPublicList DuplicateUserPublicList()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateUserPublicList();
        }

     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as UserPublicList);
        }

        /// <summary>
        /// Returns true if UserPublicList instances are equal
        /// </summary>
        /// <param name="input">Instance of UserPublicList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserPublicList input)
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
