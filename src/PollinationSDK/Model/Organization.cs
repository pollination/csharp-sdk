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
    /// Organization
    /// </summary>
    [DataContract(Name = "Organization")]
    public partial class Organization : IEquatable<Organization>, IValidatableObject
    {
        /// <summary>
        /// The role the user has within the organization
        /// </summary>
        /// <value>The role the user has within the organization</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public OrganizationRoleEnum Role { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Organization() 
        { 
            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        /// <param name="accountName">The unique name of the org in small case without spaces.</param>
        /// <param name="contactEmail">The contact email for the Organization.</param>
        /// <param name="description">A description of the org.</param>
        /// <param name="id">The org ID (required).</param>
        /// <param name="memberCount">The number of members that are part of this org (default to 0).</param>
        /// <param name="name">The display name for this org.</param>
        /// <param name="owner">The account the organization represents (required).</param>
        /// <param name="pictureUrl">URL to the picture associated with this org.</param>
        /// <param name="role">The role the user has within the organization.</param>
        /// <param name="teamCount">The number of teams that are part of this org (default to 0).</param>
        public Organization
        (
           string id, AccountPublic owner, // Required parameters
           string accountName= default, string contactEmail= default, string description= default, int memberCount = 0, string name= default, string pictureUrl= default, OrganizationRoleEnum role= default, int teamCount = 0// Optional parameters
        )// BaseClass
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for Organization and cannot be null");
            // to ensure "owner" is required (not null)
            this.Owner = owner ?? throw new ArgumentNullException("owner is a required property for Organization and cannot be null");
            this.AccountName = accountName;
            this.ContactEmail = contactEmail;
            this.Description = description;
            this.MemberCount = memberCount;
            this.Name = name;
            this.PictureUrl = pictureUrl;
            this.Role = role;
            this.TeamCount = teamCount;

            // Set non-required readonly properties with defaultValue
        }


        /// <summary>
        /// The unique name of the org in small case without spaces
        /// </summary>
        /// <value>The unique name of the org in small case without spaces</value>
        [DataMember(Name = "account_name", EmitDefaultValue = false)]
        public string AccountName { get; set; } 
        /// <summary>
        /// The contact email for the Organization
        /// </summary>
        /// <value>The contact email for the Organization</value>
        [DataMember(Name = "contact_email", EmitDefaultValue = false)]
        public string ContactEmail { get; set; } 
        /// <summary>
        /// A description of the org
        /// </summary>
        /// <value>A description of the org</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; } 
        /// <summary>
        /// The org ID
        /// </summary>
        /// <value>The org ID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; } 
        /// <summary>
        /// The number of members that are part of this org
        /// </summary>
        /// <value>The number of members that are part of this org</value>
        [DataMember(Name = "member_count", EmitDefaultValue = true)]
        public int MemberCount { get; set; }  = 0;
        /// <summary>
        /// The display name for this org
        /// </summary>
        /// <value>The display name for this org</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; } 
        /// <summary>
        /// The account the organization represents
        /// </summary>
        /// <value>The account the organization represents</value>
        [DataMember(Name = "owner", IsRequired = true, EmitDefaultValue = false)]
        public AccountPublic Owner { get; set; } 
        /// <summary>
        /// URL to the picture associated with this org
        /// </summary>
        /// <value>URL to the picture associated with this org</value>
        [DataMember(Name = "picture_url", EmitDefaultValue = false)]
        public string PictureUrl { get; set; } 
        /// <summary>
        /// The number of teams that are part of this org
        /// </summary>
        /// <value>The number of teams that are part of this org</value>
        [DataMember(Name = "team_count", EmitDefaultValue = true)]
        public int TeamCount { get; set; }  = 0;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Organization";
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
            sb.Append("Organization:\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  PictureUrl: ").Append(PictureUrl).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  TeamCount: ").Append(TeamCount).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Organization object</returns>
        public static Organization FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Organization>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Organization object</returns>
        public virtual Organization DuplicateOrganization()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateOrganization();
        }

     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Organization);
        }

        /// <summary>
        /// Returns true if Organization instances are equal
        /// </summary>
        /// <param name="input">Instance of Organization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Organization input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.ContactEmail == input.ContactEmail ||
                    (this.ContactEmail != null &&
                    this.ContactEmail.Equals(input.ContactEmail))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MemberCount == input.MemberCount ||
                    (this.MemberCount != null &&
                    this.MemberCount.Equals(input.MemberCount))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.PictureUrl == input.PictureUrl ||
                    (this.PictureUrl != null &&
                    this.PictureUrl.Equals(input.PictureUrl))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.TeamCount == input.TeamCount ||
                    (this.TeamCount != null &&
                    this.TeamCount.Equals(input.TeamCount))
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
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.ContactEmail != null)
                    hashCode = hashCode * 59 + this.ContactEmail.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MemberCount != null)
                    hashCode = hashCode * 59 + this.MemberCount.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.PictureUrl != null)
                    hashCode = hashCode * 59 + this.PictureUrl.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.TeamCount != null)
                    hashCode = hashCode * 59 + this.TeamCount.GetHashCode();
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
