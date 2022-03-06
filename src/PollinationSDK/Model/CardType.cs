/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.27.0
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
    
    public enum CardType
    {
        /// <summary>
        /// Enum Master for value: master
        /// </summary>
        [EnumMember(Value = "master")]
        Master = 1,

        /// <summary>
        /// Enum Visa for value: visa
        /// </summary>
        [EnumMember(Value = "visa")]
        Visa = 2,

        /// <summary>
        /// Enum Americanexpress for value: american_express
        /// </summary>
        [EnumMember(Value = "american_express")]
        Americanexpress = 3,

        /// <summary>
        /// Enum Discover for value: discover
        /// </summary>
        [EnumMember(Value = "discover")]
        Discover = 4,

        /// <summary>
        /// Enum Jcb for value: jcb
        /// </summary>
        [EnumMember(Value = "jcb")]
        Jcb = 5,

        /// <summary>
        /// Enum Maestro for value: maestro
        /// </summary>
        [EnumMember(Value = "maestro")]
        Maestro = 6,

        /// <summary>
        /// Enum Dinersclub for value: diners_club
        /// </summary>
        [EnumMember(Value = "diners_club")]
        Dinersclub = 7,

        /// <summary>
        /// Enum Unionpay for value: unionpay
        /// </summary>
        [EnumMember(Value = "unionpay")]
        Unionpay = 8

    }

}
