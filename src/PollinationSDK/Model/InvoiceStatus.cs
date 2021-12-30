/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.22.0
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
    
    public enum InvoiceStatus
    {
        /// <summary>
        /// Enum Draft for value: draft
        /// </summary>
        [EnumMember(Value = "draft")]
        Draft = 1,

        /// <summary>
        /// Enum Open for value: open
        /// </summary>
        [EnumMember(Value = "open")]
        Open = 2,

        /// <summary>
        /// Enum Paid for value: paid
        /// </summary>
        [EnumMember(Value = "paid")]
        Paid = 3,

        /// <summary>
        /// Enum Uncollectable for value: uncollectable
        /// </summary>
        [EnumMember(Value = "uncollectable")]
        Uncollectable = 4,

        /// <summary>
        /// Enum Void for value: void
        /// </summary>
        [EnumMember(Value = "void")]
        Void = 5

    }

}
