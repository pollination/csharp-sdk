/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.25.0
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
    /// Queenbee Job.  A Job is an object to submit a list of arguments to execute a Queenbee recipe.
    /// </summary>
    [DataContract]
    public partial class Job :  IEquatable<Job>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Job() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="arguments">Input arguments for this job..</param>
        /// <param name="description">Run description..</param>
        /// <param name="labels">Optional user data as a dictionary. User data is for user reference only and will not be used in the execution of the job..</param>
        /// <param name="name">An optional name for this job. This name will be used a the display name for the run..</param>
        /// <param name="source">The source url for downloading the recipe. (required).</param>
        public Job
        (
           string source, // Required parameters
           Dictionary<string, string> annotations= default, List<List<AnyOf<JobArgument,JobPathArgument>>> arguments= default, string description= default, Dictionary<string, string> labels= default, string name= default // Optional parameters
        )// BaseClass
        {
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new InvalidDataException("source is a required property for Job and cannot be null");
            }
            else
            {
                this.Source = source;
            }
            
            this.Annotations = annotations;
            this.Arguments = arguments;
            this.Description = description;
            this.Labels = labels;
            this.Name = name;

            // Set non-required readonly properties with defaultValue
            this.ApiVersion = "v1beta1";
            this.Type = "Job";
        }
        
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        [JsonProperty("annotations")]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// Input arguments for this job.
        /// </summary>
        /// <value>Input arguments for this job.</value>
        [DataMember(Name="arguments", EmitDefaultValue=false)]
        [JsonProperty("arguments")]
        public List<List<AnyOf<JobArgument,JobPathArgument>>> Arguments { get; set; } 
        /// <summary>
        /// Run description.
        /// </summary>
        /// <value>Run description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; } 
        /// <summary>
        /// Optional user data as a dictionary. User data is for user reference only and will not be used in the execution of the job.
        /// </summary>
        /// <value>Optional user data as a dictionary. User data is for user reference only and will not be used in the execution of the job.</value>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; } 
        /// <summary>
        /// An optional name for this job. This name will be used a the display name for the run.
        /// </summary>
        /// <value>An optional name for this job. This name will be used a the display name for the run.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// The source url for downloading the recipe.
        /// </summary>
        /// <value>The source url for downloading the recipe.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        [JsonProperty("source")]
        public string Source { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Job {\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, JsonSetting.ConvertSetting);
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Job object</returns>
        public static Job FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Job>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Job object</returns>
        public Job DuplicateJob()
        {
            return FromJson(this.ToJson());
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Job);
        }

        /// <summary>
        /// Returns true if Job instances are equal
        /// </summary>
        /// <param name="input">Instance of Job to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Job input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.Arguments == input.Arguments ||
                    this.Arguments != null &&
                    input.Arguments != null &&
                    this.Arguments.SequenceEqual(input.Arguments)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Arguments != null)
                    hashCode = hashCode * 59 + this.Arguments.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // ApiVersion (string) pattern
            Regex regexApiVersion = new Regex(@"^v1beta1$", RegexOptions.CultureInvariant);
            if (false == regexApiVersion.Match(this.ApiVersion).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApiVersion, must match a pattern of " + regexApiVersion, new [] { "ApiVersion" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^Job$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
