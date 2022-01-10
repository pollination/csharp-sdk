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
    /// PaymentIntent
    /// </summary>
    [DataContract(Name = "PaymentIntent")]
    public partial class PaymentIntent : SecureResourcePublic, IEquatable<PaymentIntent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentIntent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentIntent() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "PaymentIntent";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentIntent" /> class.
        /// </summary>
        /// <param name="clientSecret">Secret string to be used to retrieve the resource from the client (required).</param>
        public PaymentIntent
        (
            string clientSecret// Required parameters
           // Optional parameters
        ) : base(clientSecret: clientSecret)// BaseClass
        {

            // Set non-required readonly properties with defaultValue
            this.Type = "PaymentIntent";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; protected internal set; }  = "PaymentIntent";


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "PaymentIntent";
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
            sb.Append("PaymentIntent:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>PaymentIntent object</returns>
        public static PaymentIntent FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<PaymentIntent>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>PaymentIntent object</returns>
        public virtual PaymentIntent DuplicatePaymentIntent()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicatePaymentIntent();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override SecureResourcePublic DuplicateSecureResourcePublic()
        {
            return DuplicatePaymentIntent();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as PaymentIntent);
        }

        /// <summary>
        /// Returns true if PaymentIntent instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentIntent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentIntent input)
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
            Regex regexType = new Regex(@"^PaymentIntent$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
