/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.18.0-beta.2
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
    /// PaymentSetup
    /// </summary>
    [DataContract]
    public partial class PaymentSetup :  IEquatable<PaymentSetup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSetup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentSetup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSetup" /> class.
        /// </summary>
        /// <param name="clientSecret">Secret string to be used to complete a payment setup exchange with a payment provider (required).</param>
        public PaymentSetup
        (
           string clientSecret// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "clientSecret" is required (not null)
            if (clientSecret == null)
            {
                throw new InvalidDataException("clientSecret is a required property for PaymentSetup and cannot be null");
            }
            else
            {
                this.ClientSecret = clientSecret;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Secret string to be used to complete a payment setup exchange with a payment provider
        /// </summary>
        /// <value>Secret string to be used to complete a payment setup exchange with a payment provider</value>
        [DataMember(Name="client_secret", EmitDefaultValue=false)]
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentSetup {\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
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
        /// <returns>PaymentSetup object</returns>
        public static PaymentSetup FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<PaymentSetup>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>PaymentSetup object</returns>
        public PaymentSetup DuplicatePaymentSetup()
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
            return this.Equals(input as PaymentSetup);
        }

        /// <summary>
        /// Returns true if PaymentSetup instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentSetup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentSetup input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
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
                if (this.ClientSecret != null)
                    hashCode = hashCode * 59 + this.ClientSecret.GetHashCode();
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
