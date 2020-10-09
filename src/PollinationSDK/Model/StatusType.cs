/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: 0.9.6
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
    
    public enum StatusType
    {
        /// <summary>
        /// Enum Function for value: function
        /// </summary>
        [EnumMember(Value = "function")]
        Function = 1,

        /// <summary>
        /// Enum Dag for value: dag
        /// </summary>
        [EnumMember(Value = "dag")]
        Dag = 2,

        /// <summary>
        /// Enum Loop for value: loop
        /// </summary>
        [EnumMember(Value = "loop")]
        Loop = 3

    }

}
