/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.42.0
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
    /// The status of a build.
    /// </summary>
    /// <value>The status of a build.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum BuildStatusEnum
    {
        /// <summary>
        /// Enum Pending for value: pending
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending = 1,

        /// <summary>
        /// Enum Running for value: running
        /// </summary>
        [EnumMember(Value = "running")]
        Running = 2,

        /// <summary>
        /// Enum Success for value: success
        /// </summary>
        [EnumMember(Value = "success")]
        Success = 3,

        /// <summary>
        /// Enum Failure for value: failure
        /// </summary>
        [EnumMember(Value = "failure")]
        Failure = 4,

        /// <summary>
        /// Enum Cancelled for value: cancelled
        /// </summary>
        [EnumMember(Value = "cancelled")]
        Cancelled = 5,

        /// <summary>
        /// Enum Awaitingpackageupload for value: awaiting_package_upload
        /// </summary>
        [EnumMember(Value = "awaiting_package_upload")]
        Awaitingpackageupload = 6,

        /// <summary>
        /// Enum Unknown for value: unknown
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown = 7

    }

}
