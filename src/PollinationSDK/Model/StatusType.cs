/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.37.0
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
    /// Type enum for status type.
    /// </summary>
    /// <value>Type enum for status type.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum StatusType
    {
        /// <summary>
        /// Enum Function for value: Function
        /// </summary>
        [EnumMember(Value = "Function")]
        Function = 1,

        /// <summary>
        /// Enum DAG for value: DAG
        /// </summary>
        [EnumMember(Value = "DAG")]
        DAG = 2,

        /// <summary>
        /// Enum Loop for value: Loop
        /// </summary>
        [EnumMember(Value = "Loop")]
        Loop = 3,

        /// <summary>
        /// Enum Container for value: Container
        /// </summary>
        [EnumMember(Value = "Container")]
        Container = 4,

        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 5

    }

}
