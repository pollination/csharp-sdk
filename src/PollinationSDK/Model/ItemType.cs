/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.18.0-beta.7
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
    /// Type enum for items in a list.  Items can not be files or folder. For a list of files you should copy them to a folder and use FolderInput input instead of using ArrayInput.
    /// </summary>
    /// <value>Type enum for items in a list.  Items can not be files or folder. For a list of files you should copy them to a folder and use FolderInput input instead of using ArrayInput.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ItemType
    {
        /// <summary>
        /// Enum Generic for value: Generic
        /// </summary>
        [EnumMember(Value = "Generic")]
        Generic = 1,

        /// <summary>
        /// Enum String for value: String
        /// </summary>
        [EnumMember(Value = "String")]
        String = 2,

        /// <summary>
        /// Enum Integer for value: Integer
        /// </summary>
        [EnumMember(Value = "Integer")]
        Integer = 3,

        /// <summary>
        /// Enum Number for value: Number
        /// </summary>
        [EnumMember(Value = "Number")]
        Number = 4,

        /// <summary>
        /// Enum Boolean for value: Boolean
        /// </summary>
        [EnumMember(Value = "Boolean")]
        Boolean = 5,

        /// <summary>
        /// Enum Array for value: Array
        /// </summary>
        [EnumMember(Value = "Array")]
        Array = 6,

        /// <summary>
        /// Enum JSONObject for value: JSONObject
        /// </summary>
        [EnumMember(Value = "JSONObject")]
        JSONObject = 7

    }

}
