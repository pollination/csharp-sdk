/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.24.0
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
    
    public enum CouponDuration
    {
        /// <summary>
        /// Enum Forever for value: forever
        /// </summary>
        [EnumMember(Value = "forever")]
        Forever = 1,

        /// <summary>
        /// Enum Once for value: once
        /// </summary>
        [EnumMember(Value = "once")]
        Once = 2,

        /// <summary>
        /// Enum Repeating for value: repeating
        /// </summary>
        [EnumMember(Value = "repeating")]
        Repeating = 3

    }

}
