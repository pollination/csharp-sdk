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
    [DataContract(Name = "QuotaList")]
    public partial class QuotaList : OpenAPIGenBaseModel, IEquatable<QuotaList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuotaList() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "QuotaList";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaList" /> class.
        /// </summary>
        /// <param name="page">The current page the pagination request is on (required).</param>
        /// <param name="perPage">The number of pages per pagination request (required).</param>
        /// <param name="pageCount">The total number of pages (required).</param>
        /// <param name="totalCount">The total number of resources matching the list request (required).</param>
        /// <param name="resources">resources (required).</param>
        /// <param name="nextPage">The next page, if this on is not the last.</param>
        public QuotaList
        (
           int page, int perPage, int pageCount, int totalCount, List<Quota> resources, // Required parameters
           int nextPage= default // Optional parameters
        ) : base()// BaseClass
        {
            this.Page = page;
            this.PerPage = perPage;
            this.PageCount = pageCount;
            this.TotalCount = totalCount;
            // to ensure "resources" is required (not null)
            this.Resources = resources ?? throw new ArgumentNullException("resources is a required property for QuotaList and cannot be null");
            this.NextPage = nextPage;

            // Set non-required readonly properties with defaultValue
            this.Type = "QuotaList";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "QuotaList";

        /// <summary>
        /// The current page the pagination request is on
        /// </summary>
        /// <value>The current page the pagination request is on</value>
        [DataMember(Name = "page", IsRequired = true)]
        public int Page { get; set; } 
        /// <summary>
        /// The number of pages per pagination request
        /// </summary>
        /// <value>The number of pages per pagination request</value>
        [DataMember(Name = "per_page", IsRequired = true)]
        public int PerPage { get; set; } 
        /// <summary>
        /// The total number of pages
        /// </summary>
        /// <value>The total number of pages</value>
        [DataMember(Name = "page_count", IsRequired = true)]
        public int PageCount { get; set; } 
        /// <summary>
        /// The total number of resources matching the list request
        /// </summary>
        /// <value>The total number of resources matching the list request</value>
        [DataMember(Name = "total_count", IsRequired = true)]
        public int TotalCount { get; set; } 
        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [DataMember(Name = "resources", IsRequired = true)]
        public List<Quota> Resources { get; set; } 
        /// <summary>
        /// The next page, if this on is not the last
        /// </summary>
        /// <value>The next page, if this on is not the last</value>
        [DataMember(Name = "next_page")]
        public int NextPage { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "QuotaList";
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
            sb.Append("QuotaList:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Page: ").Append(this.Page).Append("\n");
            sb.Append("  PerPage: ").Append(this.PerPage).Append("\n");
            sb.Append("  PageCount: ").Append(this.PageCount).Append("\n");
            sb.Append("  TotalCount: ").Append(this.TotalCount).Append("\n");
            sb.Append("  Resources: ").Append(this.Resources).Append("\n");
            sb.Append("  NextPage: ").Append(this.NextPage).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>QuotaList object</returns>
        public static QuotaList FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<QuotaList>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>QuotaList object</returns>
        public virtual QuotaList DuplicateQuotaList()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateQuotaList();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateQuotaList();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as QuotaList);
        }

        /// <summary>
        /// Returns true if QuotaList instances are equal
        /// </summary>
        /// <param name="input">Instance of QuotaList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuotaList input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Page, input.Page) && 
                    Extension.Equals(this.PerPage, input.PerPage) && 
                    Extension.Equals(this.PageCount, input.PageCount) && 
                    Extension.Equals(this.TotalCount, input.TotalCount) && 
                (
                    this.Resources == input.Resources ||
                    Extension.AllEquals(this.Resources, input.Resources)
                ) && 
                    Extension.Equals(this.NextPage, input.NextPage) && 
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
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.PerPage != null)
                    hashCode = hashCode * 59 + this.PerPage.GetHashCode();
                if (this.PageCount != null)
                    hashCode = hashCode * 59 + this.PageCount.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
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
            Regex regexType = new Regex(@"^QuotaList$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
