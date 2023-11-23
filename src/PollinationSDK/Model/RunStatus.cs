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
    /// Job Status.
    /// </summary>
    [DataContract]
    public partial class RunStatus :  IEquatable<RunStatus>, IValidatableObject
    {
        /// <summary>
        /// The status of this run.
        /// </summary>
        /// <value>The status of this run.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public RunStatusEnum? Status { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="RunStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RunStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RunStatus" /> class.
        /// </summary>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="entrypoint">The ID of the first step in the run..</param>
        /// <param name="finishedAt">The time at which the task was completed.</param>
        /// <param name="id">The ID of the individual run. (required).</param>
        /// <param name="inputs">The inputs used for this run. (required).</param>
        /// <param name="jobId">The ID of the job that generated this run. (required).</param>
        /// <param name="message">Any message produced by the task. Usually error/debugging hints..</param>
        /// <param name="outputs">The outputs produced by this run. (required).</param>
        /// <param name="source">Source url for the status object. It can be a recipe or a function..</param>
        /// <param name="startedAt">The time at which the task was started (required).</param>
        /// <param name="status">The status of this run..</param>
        /// <param name="steps">steps.</param>
        public RunStatus
        (
           string id, List<AnyOf<StepStringInput,StepIntegerInput,StepNumberInput,StepBooleanInput,StepFolderInput,StepFileInput,StepPathInput,StepArrayInput,StepJSONObjectInput>> inputs, string jobId, List<AnyOf<StepStringOutput,StepIntegerOutput,StepNumberOutput,StepBooleanOutput,StepFolderOutput,StepFileOutput,StepPathOutput,StepArrayOutput,StepJSONObjectOutput>> outputs, DateTime startedAt, // Required parameters
           Dictionary<string, string> annotations= default, string entrypoint= default, DateTime finishedAt= default, string message= default, string source= default, RunStatusEnum? status= default, Dictionary<string, StepStatus> steps= default // Optional parameters
        )// BaseClass
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for RunStatus and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "inputs" is required (not null)
            if (inputs == null)
            {
                throw new InvalidDataException("inputs is a required property for RunStatus and cannot be null");
            }
            else
            {
                this.Inputs = inputs;
            }
            
            // to ensure "jobId" is required (not null)
            if (jobId == null)
            {
                throw new InvalidDataException("jobId is a required property for RunStatus and cannot be null");
            }
            else
            {
                this.JobId = jobId;
            }
            
            // to ensure "outputs" is required (not null)
            if (outputs == null)
            {
                throw new InvalidDataException("outputs is a required property for RunStatus and cannot be null");
            }
            else
            {
                this.Outputs = outputs;
            }
            
            // to ensure "startedAt" is required (not null)
            if (startedAt == null)
            {
                throw new InvalidDataException("startedAt is a required property for RunStatus and cannot be null");
            }
            else
            {
                this.StartedAt = startedAt;
            }
            
            this.Annotations = annotations;
            this.Entrypoint = entrypoint;
            this.FinishedAt = finishedAt;
            this.Message = message;
            this.Source = source;
            this.Status = status;
            this.Steps = steps;

            // Set non-required readonly properties with defaultValue
            this.ApiVersion = "v1beta1";
            this.Type = "RunStatus";
        }
        
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        [JsonProperty("annotations")]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// The ID of the first step in the run.
        /// </summary>
        /// <value>The ID of the first step in the run.</value>
        [DataMember(Name="entrypoint", EmitDefaultValue=false)]
        [JsonProperty("entrypoint")]
        public string Entrypoint { get; set; } 
        /// <summary>
        /// The time at which the task was completed
        /// </summary>
        /// <value>The time at which the task was completed</value>
        [DataMember(Name="finished_at", EmitDefaultValue=false)]
        [JsonProperty("finished_at")]
        public DateTime FinishedAt { get; set; } 
        /// <summary>
        /// The ID of the individual run.
        /// </summary>
        /// <value>The ID of the individual run.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public string Id { get; set; } 
        /// <summary>
        /// The inputs used for this run.
        /// </summary>
        /// <value>The inputs used for this run.</value>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        [JsonProperty("inputs")]
        public List<AnyOf<StepStringInput,StepIntegerInput,StepNumberInput,StepBooleanInput,StepFolderInput,StepFileInput,StepPathInput,StepArrayInput,StepJSONObjectInput>> Inputs { get; set; } 
        /// <summary>
        /// The ID of the job that generated this run.
        /// </summary>
        /// <value>The ID of the job that generated this run.</value>
        [DataMember(Name="job_id", EmitDefaultValue=false)]
        [JsonProperty("job_id")]
        public string JobId { get; set; } 
        /// <summary>
        /// Any message produced by the task. Usually error/debugging hints.
        /// </summary>
        /// <value>Any message produced by the task. Usually error/debugging hints.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        [JsonProperty("message")]
        public string Message { get; set; } 
        /// <summary>
        /// The outputs produced by this run.
        /// </summary>
        /// <value>The outputs produced by this run.</value>
        [DataMember(Name="outputs", EmitDefaultValue=false)]
        [JsonProperty("outputs")]
        public List<AnyOf<StepStringOutput,StepIntegerOutput,StepNumberOutput,StepBooleanOutput,StepFolderOutput,StepFileOutput,StepPathOutput,StepArrayOutput,StepJSONObjectOutput>> Outputs { get; set; } 
        /// <summary>
        /// Source url for the status object. It can be a recipe or a function.
        /// </summary>
        /// <value>Source url for the status object. It can be a recipe or a function.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        [JsonProperty("source")]
        public string Source { get; set; } 
        /// <summary>
        /// The time at which the task was started
        /// </summary>
        /// <value>The time at which the task was started</value>
        [DataMember(Name="started_at", EmitDefaultValue=false)]
        [JsonProperty("started_at")]
        public DateTime StartedAt { get; set; } 
        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name="steps", EmitDefaultValue=false)]
        [JsonProperty("steps")]
        public Dictionary<string, StepStatus> Steps { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunStatus {\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Entrypoint: ").Append(Entrypoint).Append("\n");
            sb.Append("  FinishedAt: ").Append(FinishedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
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
        /// <returns>RunStatus object</returns>
        public static RunStatus FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RunStatus>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RunStatus object</returns>
        public RunStatus DuplicateRunStatus()
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
            return this.Equals(input as RunStatus);
        }

        /// <summary>
        /// Returns true if RunStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of RunStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunStatus input)
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
                    this.Entrypoint == input.Entrypoint ||
                    (this.Entrypoint != null &&
                    this.Entrypoint.Equals(input.Entrypoint))
                ) && 
                (
                    this.FinishedAt == input.FinishedAt ||
                    (this.FinishedAt != null &&
                    this.FinishedAt.Equals(input.FinishedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    input.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Outputs == input.Outputs ||
                    this.Outputs != null &&
                    input.Outputs != null &&
                    this.Outputs.SequenceEqual(input.Outputs)
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.StartedAt == input.StartedAt ||
                    (this.StartedAt != null &&
                    this.StartedAt.Equals(input.StartedAt))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    input.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
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
                if (this.Entrypoint != null)
                    hashCode = hashCode * 59 + this.Entrypoint.GetHashCode();
                if (this.FinishedAt != null)
                    hashCode = hashCode * 59 + this.FinishedAt.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Outputs != null)
                    hashCode = hashCode * 59 + this.Outputs.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.StartedAt != null)
                    hashCode = hashCode * 59 + this.StartedAt.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Steps != null)
                    hashCode = hashCode * 59 + this.Steps.GetHashCode();
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
            Regex regexType = new Regex(@"^RunStatus$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
