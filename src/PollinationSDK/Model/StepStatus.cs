/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * The version of the OpenAPI document: 0.18.0-beta.4
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
    /// The Status of a Job Step
    /// </summary>
    [DataContract]
    public partial class StepStatus :  IEquatable<StepStatus>, IValidatableObject
    {
        /// <summary>
        /// The status of this step.
        /// </summary>
        /// <value>The status of this step.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StepStatusEnum? Status { get; set; }   
        /// <summary>
        /// The type of step this status is for. Can be \&quot;Function\&quot;, \&quot;DAG\&quot; or \&quot;Loop\&quot;
        /// </summary>
        /// <value>The type of step this status is for. Can be \&quot;Function\&quot;, \&quot;DAG\&quot; or \&quot;Loop\&quot;</value>
        [DataMember(Name="status_type", EmitDefaultValue=false)]
        public StatusType StatusType { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="StepStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StepStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StepStatus" /> class.
        /// </summary>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="boundaryId">This indicates the step ID of the associated template root             step in which this step belongs to. A DAG step will have the id of the             parent DAG for example..</param>
        /// <param name="childrenIds">A list of child step IDs (required).</param>
        /// <param name="command">The command used to run this step. Only applies to Function steps..</param>
        /// <param name="finishedAt">The time at which the task was completed.</param>
        /// <param name="id">The step unique ID (required).</param>
        /// <param name="inputs">The inputs used by this step. (required).</param>
        /// <param name="message">Any message produced by the task. Usually error/debugging hints..</param>
        /// <param name="name">A human readable name for the step. Usually defined by the DAG task name but can be extended if the step is part of a loop for example. This name is unique within the boundary of the DAG/Job that generated it. (required).</param>
        /// <param name="outboundSteps">A list of the last step to ran in the context of this step. In the case of a DAG or a job this will be the last step that has been executed. It will remain empty for functions. (required).</param>
        /// <param name="outputs">The outputs produced by this step. (required).</param>
        /// <param name="source">Source url for the status object. It can be a recipe or a function..</param>
        /// <param name="startedAt">The time at which the task was started (required).</param>
        /// <param name="status">The status of this step..</param>
        /// <param name="statusType">The type of step this status is for. Can be \&quot;Function\&quot;, \&quot;DAG\&quot; or \&quot;Loop\&quot; (required).</param>
        /// <param name="templateRef">The name of the template that spawned this step (required).</param>
        public StepStatus
        (
           List<string> childrenIds, string id, List<AnyOf<StepStringInput,StepIntegerInput,StepNumberInput,StepBooleanInput,StepFolderInput,StepFileInput,StepPathInput,StepArrayInput,StepJSONObjectInput>> inputs, string name, List<string> outboundSteps, List<AnyOf<StepStringOutput,StepIntegerOutput,StepNumberOutput,StepBooleanOutput,StepFolderOutput,StepFileOutput,StepPathOutput,StepArrayOutput,StepJSONObjectOutput>> outputs, DateTime startedAt, StatusType statusType, string templateRef, // Required parameters
           Dictionary<string, string> annotations= default, string boundaryId= default, string command= default, DateTime finishedAt= default, string message= default, string source= default, StepStatusEnum? status= default // Optional parameters
        )// BaseClass
        {
            // to ensure "childrenIds" is required (not null)
            if (childrenIds == null)
            {
                throw new InvalidDataException("childrenIds is a required property for StepStatus and cannot be null");
            }
            else
            {
                this.ChildrenIds = childrenIds;
            }
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for StepStatus and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "inputs" is required (not null)
            if (inputs == null)
            {
                throw new InvalidDataException("inputs is a required property for StepStatus and cannot be null");
            }
            else
            {
                this.Inputs = inputs;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for StepStatus and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "outboundSteps" is required (not null)
            if (outboundSteps == null)
            {
                throw new InvalidDataException("outboundSteps is a required property for StepStatus and cannot be null");
            }
            else
            {
                this.OutboundSteps = outboundSteps;
            }
            
            // to ensure "outputs" is required (not null)
            if (outputs == null)
            {
                throw new InvalidDataException("outputs is a required property for StepStatus and cannot be null");
            }
            else
            {
                this.Outputs = outputs;
            }
            
            // to ensure "startedAt" is required (not null)
            if (startedAt == null)
            {
                throw new InvalidDataException("startedAt is a required property for StepStatus and cannot be null");
            }
            else
            {
                this.StartedAt = startedAt;
            }
            
            // to ensure "statusType" is required (not null)
            if (statusType == null)
            {
                throw new InvalidDataException("statusType is a required property for StepStatus and cannot be null");
            }
            else
            {
                this.StatusType = statusType;
            }
            
            // to ensure "templateRef" is required (not null)
            if (templateRef == null)
            {
                throw new InvalidDataException("templateRef is a required property for StepStatus and cannot be null");
            }
            else
            {
                this.TemplateRef = templateRef;
            }
            
            this.Annotations = annotations;
            this.BoundaryId = boundaryId;
            this.Command = command;
            this.FinishedAt = finishedAt;
            this.Message = message;
            this.Source = source;
            this.Status = status;

            // Set non-required readonly properties with defaultValue
            this.Type = "StepStatus";
        }
        
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        [JsonProperty("annotations")]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// This indicates the step ID of the associated template root             step in which this step belongs to. A DAG step will have the id of the             parent DAG for example.
        /// </summary>
        /// <value>This indicates the step ID of the associated template root             step in which this step belongs to. A DAG step will have the id of the             parent DAG for example.</value>
        [DataMember(Name="boundary_id", EmitDefaultValue=false)]
        [JsonProperty("boundary_id")]
        public string BoundaryId { get; set; } 
        /// <summary>
        /// A list of child step IDs
        /// </summary>
        /// <value>A list of child step IDs</value>
        [DataMember(Name="children_ids", EmitDefaultValue=false)]
        [JsonProperty("children_ids")]
        public List<string> ChildrenIds { get; set; } 
        /// <summary>
        /// The command used to run this step. Only applies to Function steps.
        /// </summary>
        /// <value>The command used to run this step. Only applies to Function steps.</value>
        [DataMember(Name="command", EmitDefaultValue=false)]
        [JsonProperty("command")]
        public string Command { get; set; } 
        /// <summary>
        /// The time at which the task was completed
        /// </summary>
        /// <value>The time at which the task was completed</value>
        [DataMember(Name="finished_at", EmitDefaultValue=false)]
        [JsonProperty("finished_at")]
        public DateTime FinishedAt { get; set; } 
        /// <summary>
        /// The step unique ID
        /// </summary>
        /// <value>The step unique ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public string Id { get; set; } 
        /// <summary>
        /// The inputs used by this step.
        /// </summary>
        /// <value>The inputs used by this step.</value>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        [JsonProperty("inputs")]
        public List<AnyOf<StepStringInput,StepIntegerInput,StepNumberInput,StepBooleanInput,StepFolderInput,StepFileInput,StepPathInput,StepArrayInput,StepJSONObjectInput>> Inputs { get; set; } 
        /// <summary>
        /// Any message produced by the task. Usually error/debugging hints.
        /// </summary>
        /// <value>Any message produced by the task. Usually error/debugging hints.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        [JsonProperty("message")]
        public string Message { get; set; } 
        /// <summary>
        /// A human readable name for the step. Usually defined by the DAG task name but can be extended if the step is part of a loop for example. This name is unique within the boundary of the DAG/Job that generated it.
        /// </summary>
        /// <value>A human readable name for the step. Usually defined by the DAG task name but can be extended if the step is part of a loop for example. This name is unique within the boundary of the DAG/Job that generated it.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// A list of the last step to ran in the context of this step. In the case of a DAG or a job this will be the last step that has been executed. It will remain empty for functions.
        /// </summary>
        /// <value>A list of the last step to ran in the context of this step. In the case of a DAG or a job this will be the last step that has been executed. It will remain empty for functions.</value>
        [DataMember(Name="outbound_steps", EmitDefaultValue=false)]
        [JsonProperty("outbound_steps")]
        public List<string> OutboundSteps { get; set; } 
        /// <summary>
        /// The outputs produced by this step.
        /// </summary>
        /// <value>The outputs produced by this step.</value>
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
        /// The name of the template that spawned this step
        /// </summary>
        /// <value>The name of the template that spawned this step</value>
        [DataMember(Name="template_ref", EmitDefaultValue=false)]
        [JsonProperty("template_ref")]
        public string TemplateRef { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StepStatus {\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  BoundaryId: ").Append(BoundaryId).Append("\n");
            sb.Append("  ChildrenIds: ").Append(ChildrenIds).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  FinishedAt: ").Append(FinishedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OutboundSteps: ").Append(OutboundSteps).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusType: ").Append(StatusType).Append("\n");
            sb.Append("  TemplateRef: ").Append(TemplateRef).Append("\n");
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
        /// <returns>StepStatus object</returns>
        public static StepStatus FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<StepStatus>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>StepStatus object</returns>
        public StepStatus DuplicateStepStatus()
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
            return this.Equals(input as StepStatus);
        }

        /// <summary>
        /// Returns true if StepStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of StepStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StepStatus input)
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
                    this.BoundaryId == input.BoundaryId ||
                    (this.BoundaryId != null &&
                    this.BoundaryId.Equals(input.BoundaryId))
                ) && 
                (
                    this.ChildrenIds == input.ChildrenIds ||
                    this.ChildrenIds != null &&
                    input.ChildrenIds != null &&
                    this.ChildrenIds.SequenceEqual(input.ChildrenIds)
                ) && 
                (
                    this.Command == input.Command ||
                    (this.Command != null &&
                    this.Command.Equals(input.Command))
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
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OutboundSteps == input.OutboundSteps ||
                    this.OutboundSteps != null &&
                    input.OutboundSteps != null &&
                    this.OutboundSteps.SequenceEqual(input.OutboundSteps)
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
                    this.StatusType == input.StatusType ||
                    (this.StatusType != null &&
                    this.StatusType.Equals(input.StatusType))
                ) && 
                (
                    this.TemplateRef == input.TemplateRef ||
                    (this.TemplateRef != null &&
                    this.TemplateRef.Equals(input.TemplateRef))
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
                if (this.BoundaryId != null)
                    hashCode = hashCode * 59 + this.BoundaryId.GetHashCode();
                if (this.ChildrenIds != null)
                    hashCode = hashCode * 59 + this.ChildrenIds.GetHashCode();
                if (this.Command != null)
                    hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.FinishedAt != null)
                    hashCode = hashCode * 59 + this.FinishedAt.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OutboundSteps != null)
                    hashCode = hashCode * 59 + this.OutboundSteps.GetHashCode();
                if (this.Outputs != null)
                    hashCode = hashCode * 59 + this.Outputs.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.StartedAt != null)
                    hashCode = hashCode * 59 + this.StartedAt.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusType != null)
                    hashCode = hashCode * 59 + this.StatusType.GetHashCode();
                if (this.TemplateRef != null)
                    hashCode = hashCode * 59 + this.TemplateRef.GetHashCode();
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
            // Type (string) pattern
            Regex regexType = new Regex(@"^StepStatus$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
