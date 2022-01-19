/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.25.0
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
    /// PaymentIntent
    /// </summary>
    [DataContract]
    public partial class PaymentIntent :  IEquatable<PaymentIntent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentIntent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentIntent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentIntent" /> class.
        /// </summary>
        /// <param name="clientSecret">Secret string to be used to retrieve the resource from the client (required).</param>
        public PaymentIntent
        (
           string clientSecret// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "clientSecret" is required (not null)
            if (clientSecret == null)
            {
                throw new InvalidDataException("clientSecret is a required property for PaymentIntent and cannot be null");
            }
            else
            {
                this.ClientSecret = clientSecret;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Secret string to be used to retrieve the resource from the client
        /// </summary>
        /// <value>Secret string to be used to retrieve the resource from the client</value>
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
            sb.Append("class PaymentIntent {\n");
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
        /// <returns>PaymentIntent object</returns>
        public static PaymentIntent FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<PaymentIntent>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>PaymentIntent object</returns>
        public PaymentIntent DuplicatePaymentIntent()
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
