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
    /// An enumeration.
    /// </summary>
    /// <value>An enumeration.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PackageSortKey
    {
        /// <summary>
        /// Enum Createdat for value: created_at
        /// </summary>
        [EnumMember(Value = "created_at")]
        Createdat = 1,

        /// <summary>
        /// Enum Updatedat for value: updated_at
        /// </summary>
        [EnumMember(Value = "updated_at")]
        Updatedat = 2,

        /// <summary>
        /// Enum Tag for value: tag
        /// </summary>
        [EnumMember(Value = "tag")]
        Tag = 3

    }

}
