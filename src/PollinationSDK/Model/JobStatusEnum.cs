/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.18.0-beta.8
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
    
    public enum JobStatusEnum
    {
        /// <summary>
        /// Enum Created for value: Created
        /// </summary>
        [EnumMember(Value = "Created")]
        Created = 1,

        /// <summary>
        /// Enum PreProcessing for value: Pre-Processing
        /// </summary>
        [EnumMember(Value = "Pre-Processing")]
        PreProcessing = 2,

        /// <summary>
        /// Enum Running for value: Running
        /// </summary>
        [EnumMember(Value = "Running")]
        Running = 3,

        /// <summary>
        /// Enum Failed for value: Failed
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed = 4,

        /// <summary>
        /// Enum Cancelled for value: Cancelled
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled = 5,

        /// <summary>
        /// Enum Completed for value: Completed
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed = 6,

        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 7

    }

}
