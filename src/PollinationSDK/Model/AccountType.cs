/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.21.0
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
    /// The type of account.
    /// </summary>
    /// <value>The type of account.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AccountType
    {
        /// <summary>
        /// Enum Org for value: org
        /// </summary>
        [EnumMember(Value = "org")]
        Org = 1,

        /// <summary>
        /// Enum User for value: user
        /// </summary>
        [EnumMember(Value = "user")]
        User = 2

    }

}
