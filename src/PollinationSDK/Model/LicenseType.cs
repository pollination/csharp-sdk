/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.27.1
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
    
    public enum LicenseType
    {
        /// <summary>
        /// Enum NodeLocked for value: node-locked
        /// </summary>
        [EnumMember(Value = "node-locked")]
        NodeLocked = 1,

        /// <summary>
        /// Enum HostedFloating for value: hosted-floating
        /// </summary>
        [EnumMember(Value = "hosted-floating")]
        HostedFloating = 2,

        /// <summary>
        /// Enum OnPremiseFloating for value: on-premise-floating
        /// </summary>
        [EnumMember(Value = "on-premise-floating")]
        OnPremiseFloating = 3

    }

}
