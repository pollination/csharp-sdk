/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 1.3.0
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
    /// Team
    /// </summary>
    [DataContract]
    public partial class Team :  IEquatable<Team>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Team" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Team() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Team" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="id">The team ID (required).</param>
        /// <param name="memberCount">The number of members that are part of this team (default to 0).</param>
        /// <param name="name">name (required).</param>
        /// <param name="slug">The public slug of the team (required).</param>
        public Team
        (
           string id, string name, string slug, // Required parameters
           string description= default, int memberCount = 0 // Optional parameters
        )// BaseClass
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Team and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Team and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "slug" is required (not null)
            if (slug == null)
            {
                throw new InvalidDataException("slug is a required property for Team and cannot be null");
            }
            else
            {
                this.Slug = slug;
            }
            
            this.Description = description;
            // use default value if no "memberCount" provided
            if (memberCount == null)
            {
                this.MemberCount =0;
            }
            else
            {
                this.MemberCount = memberCount;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; } 
        /// <summary>
        /// The team ID
        /// </summary>
        /// <value>The team ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public string Id { get; set; } 
        /// <summary>
        /// The number of members that are part of this team
        /// </summary>
        /// <value>The number of members that are part of this team</value>
        [DataMember(Name="member_count", EmitDefaultValue=false)]
        [JsonProperty("member_count")]
        public int MemberCount { get; set; }  = 0;
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// The public slug of the team
        /// </summary>
        /// <value>The public slug of the team</value>
        [DataMember(Name="slug", EmitDefaultValue=false)]
        [JsonProperty("slug")]
        public string Slug { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Team {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
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
        /// <returns>Team object</returns>
        public static Team FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Team>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Team object</returns>
        public Team DuplicateTeam()
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
            return this.Equals(input as Team);
        }

        /// <summary>
        /// Returns true if Team instances are equal
        /// </summary>
        /// <param name="input">Instance of Team to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Team input)
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
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MemberCount != null)
                    hashCode = hashCode * 59 + this.MemberCount.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Slug != null)
                    hashCode = hashCode * 59 + this.Slug.GetHashCode();
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
