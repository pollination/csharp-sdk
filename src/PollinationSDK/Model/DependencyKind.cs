/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.36.0
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
    /// Dependency kind.
    /// </summary>
    /// <value>Dependency kind.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DependencyKind
    {
        /// <summary>
        /// Enum Recipe for value: recipe
        /// </summary>
        [EnumMember(Value = "recipe")]
        Recipe = 1,

        /// <summary>
        /// Enum Plugin for value: plugin
        /// </summary>
        [EnumMember(Value = "plugin")]
        Plugin = 2

    }

}
