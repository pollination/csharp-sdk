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
    /// OrganizationCreate
    /// </summary>
    [DataContract(Name = "OrganizationCreate")]
    public partial class OrganizationCreate : OrganizationUpdate, IEquatable<OrganizationCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCreate" /> class.
        /// </summary>
        /// <param name="accountName">The unique name of the org in small case without spaces.</param>
        /// <param name="name">The display name for this org.</param>
        /// <param name="pictureUrl">URL to the picture associated with this org.</param>
        /// <param name="contactEmail">The contact email for the Organization.</param>
        /// <param name="description">A description of the org.</param>
        public OrganizationCreate
        (
           // Required parameters
            string accountName= default, string name= default, string pictureUrl= default, string contactEmail= default, string description= default // Optional parameters
        ) : base(accountName: accountName, name: name, pictureUrl: pictureUrl, contactEmail: contactEmail, description: description)// BaseClass
        {

            // Set non-required readonly properties with defaultValue
            this.Type = "OrganizationCreate";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; protected internal set; }  = "OrganizationCreate";


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "OrganizationCreate";
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
            sb.Append("OrganizationCreate:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PictureUrl: ").Append(PictureUrl).Append("\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>OrganizationCreate object</returns>
        public static OrganizationCreate FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<OrganizationCreate>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OrganizationCreate object</returns>
        public virtual OrganizationCreate DuplicateOrganizationCreate()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateOrganizationCreate();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OrganizationUpdate DuplicateOrganizationUpdate()
        {
            return DuplicateOrganizationCreate();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as OrganizationCreate);
        }

        /// <summary>
        /// Returns true if OrganizationCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationCreate input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                int hashCode = base.GetHashCode();
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
            Regex regexType = new Regex(@"^OrganizationCreate$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
