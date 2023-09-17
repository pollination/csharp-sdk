/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.44.0
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
    
    public enum Permission
    {
        /// <summary>
        /// Enum Admin for value: admin
        /// </summary>
        [EnumMember(Value = "admin")]
        Admin = 1,

        /// <summary>
        /// Enum Write for value: write
        /// </summary>
        [EnumMember(Value = "write")]
        Write = 2,

        /// <summary>
        /// Enum Read for value: read
        /// </summary>
        [EnumMember(Value = "read")]
        Read = 3

    }

}
