/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.16.0
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
    /// The type of comsumption-limited resource to which the quota refers.
    /// </summary>
    /// <value>The type of comsumption-limited resource to which the quota refers.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum QuotaType
    {
        /// <summary>
        /// Enum Storage for value: storage
        /// </summary>
        [EnumMember(Value = "storage")]
        Storage = 1,

        /// <summary>
        /// Enum Computehours for value: compute_hours
        /// </summary>
        [EnumMember(Value = "compute_hours")]
        Computehours = 2,

        /// <summary>
        /// Enum Parallelworkflowcontainers for value: parallel_workflow_containers
        /// </summary>
        [EnumMember(Value = "parallel_workflow_containers")]
        Parallelworkflowcontainers = 3,

        /// <summary>
        /// Enum Privaterepositories for value: private_repositories
        /// </summary>
        [EnumMember(Value = "private_repositories")]
        Privaterepositories = 4,

        /// <summary>
        /// Enum Privateprojects for value: private_projects
        /// </summary>
        [EnumMember(Value = "private_projects")]
        Privateprojects = 5,

        /// <summary>
        /// Enum Teams for value: teams
        /// </summary>
        [EnumMember(Value = "teams")]
        Teams = 6,

        /// <summary>
        /// Enum Members for value: members
        /// </summary>
        [EnumMember(Value = "members")]
        Members = 7,

        /// <summary>
        /// Enum Cpulimit for value: cpu_limit
        /// </summary>
        [EnumMember(Value = "cpu_limit")]
        Cpulimit = 8,

        /// <summary>
        /// Enum Memorylimit for value: memory_limit
        /// </summary>
        [EnumMember(Value = "memory_limit")]
        Memorylimit = 9

    }

}
