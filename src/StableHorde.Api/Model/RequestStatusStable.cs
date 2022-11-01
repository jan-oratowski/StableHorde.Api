/*
 * Stable Horde
 *
 * The API documentation for the Stable Horde
 *
 * The version of the OpenAPI document: 2.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = StableHorde.Api.Client.OpenAPIDateConverter;

namespace StableHorde.Api.Model
{
    /// <summary>
    /// RequestStatusStable
    /// </summary>
    [DataContract(Name = "RequestStatusStable")]
    public partial class RequestStatusStable : IEquatable<RequestStatusStable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestStatusStable" /> class.
        /// </summary>
        /// <param name="finished">The amount of finished images in this request.</param>
        /// <param name="processing">The amount of still processing images in this request.</param>
        /// <param name="waiting">The amount of images waiting to be picked up by a worker.</param>
        /// <param name="done">True when all images in this request are done. Else False..</param>
        /// <param name="faulted">True when this request caused an internal server error and cannot be completed. (default to false).</param>
        /// <param name="waitTime">The expected amount to wait (in seconds) to generate all images in this request.</param>
        /// <param name="queuePosition">The position in the requests queue. This position is determined by relative Kudos amounts..</param>
        /// <param name="generations">generations.</param>
        public RequestStatusStable(int finished = default(int), int processing = default(int), int waiting = default(int), bool done = default(bool), bool faulted = false, int waitTime = default(int), int queuePosition = default(int), List<GenerationStable> generations = default(List<GenerationStable>))
        {
            this.Finished = finished;
            this.Processing = processing;
            this.Waiting = waiting;
            this.Done = done;
            this.Faulted = faulted;
            this.WaitTime = waitTime;
            this.QueuePosition = queuePosition;
            this.Generations = generations;
        }

        /// <summary>
        /// The amount of finished images in this request
        /// </summary>
        /// <value>The amount of finished images in this request</value>
        [DataMember(Name = "finished", EmitDefaultValue = false)]
        public int Finished { get; set; }

        /// <summary>
        /// The amount of still processing images in this request
        /// </summary>
        /// <value>The amount of still processing images in this request</value>
        [DataMember(Name = "processing", EmitDefaultValue = false)]
        public int Processing { get; set; }

        /// <summary>
        /// The amount of images waiting to be picked up by a worker
        /// </summary>
        /// <value>The amount of images waiting to be picked up by a worker</value>
        [DataMember(Name = "waiting", EmitDefaultValue = false)]
        public int Waiting { get; set; }

        /// <summary>
        /// True when all images in this request are done. Else False.
        /// </summary>
        /// <value>True when all images in this request are done. Else False.</value>
        [DataMember(Name = "done", EmitDefaultValue = true)]
        public bool Done { get; set; }

        /// <summary>
        /// True when this request caused an internal server error and cannot be completed.
        /// </summary>
        /// <value>True when this request caused an internal server error and cannot be completed.</value>
        [DataMember(Name = "faulted", EmitDefaultValue = true)]
        public bool Faulted { get; set; }

        /// <summary>
        /// The expected amount to wait (in seconds) to generate all images in this request
        /// </summary>
        /// <value>The expected amount to wait (in seconds) to generate all images in this request</value>
        [DataMember(Name = "wait_time", EmitDefaultValue = false)]
        public int WaitTime { get; set; }

        /// <summary>
        /// The position in the requests queue. This position is determined by relative Kudos amounts.
        /// </summary>
        /// <value>The position in the requests queue. This position is determined by relative Kudos amounts.</value>
        [DataMember(Name = "queue_position", EmitDefaultValue = false)]
        public int QueuePosition { get; set; }

        /// <summary>
        /// Gets or Sets Generations
        /// </summary>
        [DataMember(Name = "generations", EmitDefaultValue = false)]
        public List<GenerationStable> Generations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RequestStatusStable {\n");
            sb.Append("  Finished: ").Append(Finished).Append("\n");
            sb.Append("  Processing: ").Append(Processing).Append("\n");
            sb.Append("  Waiting: ").Append(Waiting).Append("\n");
            sb.Append("  Done: ").Append(Done).Append("\n");
            sb.Append("  Faulted: ").Append(Faulted).Append("\n");
            sb.Append("  WaitTime: ").Append(WaitTime).Append("\n");
            sb.Append("  QueuePosition: ").Append(QueuePosition).Append("\n");
            sb.Append("  Generations: ").Append(Generations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RequestStatusStable);
        }

        /// <summary>
        /// Returns true if RequestStatusStable instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestStatusStable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestStatusStable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Finished == input.Finished ||
                    this.Finished.Equals(input.Finished)
                ) && 
                (
                    this.Processing == input.Processing ||
                    this.Processing.Equals(input.Processing)
                ) && 
                (
                    this.Waiting == input.Waiting ||
                    this.Waiting.Equals(input.Waiting)
                ) && 
                (
                    this.Done == input.Done ||
                    this.Done.Equals(input.Done)
                ) && 
                (
                    this.Faulted == input.Faulted ||
                    this.Faulted.Equals(input.Faulted)
                ) && 
                (
                    this.WaitTime == input.WaitTime ||
                    this.WaitTime.Equals(input.WaitTime)
                ) && 
                (
                    this.QueuePosition == input.QueuePosition ||
                    this.QueuePosition.Equals(input.QueuePosition)
                ) && 
                (
                    this.Generations == input.Generations ||
                    this.Generations != null &&
                    input.Generations != null &&
                    this.Generations.SequenceEqual(input.Generations)
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
                hashCode = (hashCode * 59) + this.Finished.GetHashCode();
                hashCode = (hashCode * 59) + this.Processing.GetHashCode();
                hashCode = (hashCode * 59) + this.Waiting.GetHashCode();
                hashCode = (hashCode * 59) + this.Done.GetHashCode();
                hashCode = (hashCode * 59) + this.Faulted.GetHashCode();
                hashCode = (hashCode * 59) + this.WaitTime.GetHashCode();
                hashCode = (hashCode * 59) + this.QueuePosition.GetHashCode();
                if (this.Generations != null)
                {
                    hashCode = (hashCode * 59) + this.Generations.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}