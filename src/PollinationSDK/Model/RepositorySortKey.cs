/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.18.1-beta.1
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
    
    public enum RepositorySortKey
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
        /// Enum Name for value: name
        /// </summary>
        [EnumMember(Value = "name")]
        Name = 3,

        /// <summary>
        /// Enum Latesttag for value: latest_tag
        /// </summary>
        [EnumMember(Value = "latest_tag")]
        Latesttag = 4

    }

}
