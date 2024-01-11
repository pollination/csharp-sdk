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
    /// Content for created response.
    /// </summary>
    [DataContract(Name = "CreatedContent")]
    public partial class CreatedContent : OpenAPIGenBaseModel, IEquatable<CreatedContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatedContent() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "CreatedContent";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedContent" /> class.
        /// </summary>
        /// <param name="id">Id for the newly created resource. (required).</param>
        /// <param name="message"> A human readable message.</param>
        public CreatedContent
        (
           Guid id, // Required parameters
           string message= default // Optional parameters
        ) : base()// BaseClass
        {
            this.Id = id;
            this.Message = message;

            // Set non-required readonly properties with defaultValue
            this.Type = "CreatedContent";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "CreatedContent";

        /// <summary>
        /// Id for the newly created resource.
        /// </summary>
        /// <value>Id for the newly created resource.</value>
        [DataMember(Name = "id", IsRequired = true)]
        public Guid Id { get; set; } 
        /// <summary>
        ///  A human readable message
        /// </summary>
        /// <value> A human readable message</value>
        [DataMember(Name = "message")]
        public string Message { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "CreatedContent";
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
            sb.Append("CreatedContent:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Message: ").Append(this.Message).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>CreatedContent object</returns>
        public static CreatedContent FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<CreatedContent>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>CreatedContent object</returns>
        public virtual CreatedContent DuplicateCreatedContent()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateCreatedContent();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateCreatedContent();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as CreatedContent);
        }

        /// <summary>
        /// Returns true if CreatedContent instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatedContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatedContent input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Id, input.Id) && 
                    Extension.Equals(this.Message, input.Message) && 
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
            Regex regexType = new Regex(@"^CreatedContent$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
