/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 1.2.0
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
    /// An enumeration.
    /// </summary>
    /// <value>An enumeration.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PaymentMethodEnum
    {
        /// <summary>
        /// Enum Card for value: card
        /// </summary>
        [EnumMember(Value = "card")]
        Card = 1,

        /// <summary>
        /// Enum Paypal for value: paypal
        /// </summary>
        [EnumMember(Value = "paypal")]
        Paypal = 2,

        /// <summary>
        /// Enum PayPal for value: PayPal
        /// </summary>
        [EnumMember(Value = "PayPal")]
        PayPal = 3

    }

}
