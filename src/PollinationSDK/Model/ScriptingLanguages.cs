/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.45.0
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
    /// Supported Scripting Languages
    /// </summary>
    /// <value>Supported Scripting Languages</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ScriptingLanguages
    {
        /// <summary>
        /// Enum Python for value: python
        /// </summary>
        [EnumMember(Value = "python")]
        Python = 1

    }

}
