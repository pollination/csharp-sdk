/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 1.1.0
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
    /// Enumaration of allowable status strings
    /// </summary>
    /// <value>Enumaration of allowable status strings</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RunStatusEnum
    {
        /// <summary>
        /// Enum Created for value: Created
        /// </summary>
        [EnumMember(Value = "Created")]
        Created = 1,

        /// <summary>
        /// Enum Scheduled for value: Scheduled
        /// </summary>
        [EnumMember(Value = "Scheduled")]
        Scheduled = 2,

        /// <summary>
        /// Enum Running for value: Running
        /// </summary>
        [EnumMember(Value = "Running")]
        Running = 3,

        /// <summary>
        /// Enum PostProcessing for value: Post-Processing
        /// </summary>
        [EnumMember(Value = "Post-Processing")]
        PostProcessing = 4,

        /// <summary>
        /// Enum Failed for value: Failed
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed = 5,

        /// <summary>
        /// Enum Cancelled for value: Cancelled
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled = 6,

        /// <summary>
        /// Enum Succeeded for value: Succeeded
        /// </summary>
        [EnumMember(Value = "Succeeded")]
        Succeeded = 7,

        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 8

    }

}
