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
    /// PutUserSingleRequest
    /// </summary>
    [DataContract(Name = "put_user_single_request")]
    public partial class PutUserSingleRequest : IEquatable<PutUserSingleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutUserSingleRequest" /> class.
        /// </summary>
        /// <param name="kudos">kudos.</param>
        /// <param name="concurrency">concurrency.</param>
        /// <param name="usageMultiplier">usageMultiplier.</param>
        /// <param name="workerInvite">workerInvite.</param>
        /// <param name="moderator">moderator.</param>
        /// <param name="publicWorkers">publicWorkers.</param>
        /// <param name="username">username.</param>
        /// <param name="monthlyKudos">monthlyKudos.</param>
        /// <param name="trusted">trusted.</param>
        public PutUserSingleRequest(int kudos = default(int), int concurrency = default(int), decimal usageMultiplier = default(decimal), int workerInvite = default(int), bool moderator = default(bool), bool publicWorkers = default(bool), string username = default(string), int monthlyKudos = default(int), bool trusted = default(bool))
        {
            this.Kudos = kudos;
            this.Concurrency = concurrency;
            this.UsageMultiplier = usageMultiplier;
            this.WorkerInvite = workerInvite;
            this.Moderator = moderator;
            this.PublicWorkers = publicWorkers;
            this.Username = username;
            this.MonthlyKudos = monthlyKudos;
            this.Trusted = trusted;
        }

        /// <summary>
        /// Gets or Sets Kudos
        /// </summary>
        [DataMember(Name = "kudos", EmitDefaultValue = false)]
        public int Kudos { get; set; }

        /// <summary>
        /// Gets or Sets Concurrency
        /// </summary>
        [DataMember(Name = "concurrency", EmitDefaultValue = false)]
        public int Concurrency { get; set; }

        /// <summary>
        /// Gets or Sets UsageMultiplier
        /// </summary>
        [DataMember(Name = "usage_multiplier", EmitDefaultValue = false)]
        public decimal UsageMultiplier { get; set; }

        /// <summary>
        /// Gets or Sets WorkerInvite
        /// </summary>
        [DataMember(Name = "worker_invite", EmitDefaultValue = false)]
        public int WorkerInvite { get; set; }

        /// <summary>
        /// Gets or Sets Moderator
        /// </summary>
        [DataMember(Name = "moderator", EmitDefaultValue = true)]
        public bool Moderator { get; set; }

        /// <summary>
        /// Gets or Sets PublicWorkers
        /// </summary>
        [DataMember(Name = "public_workers", EmitDefaultValue = true)]
        public bool PublicWorkers { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyKudos
        /// </summary>
        [DataMember(Name = "monthly_kudos", EmitDefaultValue = false)]
        public int MonthlyKudos { get; set; }

        /// <summary>
        /// Gets or Sets Trusted
        /// </summary>
        [DataMember(Name = "trusted", EmitDefaultValue = true)]
        public bool Trusted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PutUserSingleRequest {\n");
            sb.Append("  Kudos: ").Append(Kudos).Append("\n");
            sb.Append("  Concurrency: ").Append(Concurrency).Append("\n");
            sb.Append("  UsageMultiplier: ").Append(UsageMultiplier).Append("\n");
            sb.Append("  WorkerInvite: ").Append(WorkerInvite).Append("\n");
            sb.Append("  Moderator: ").Append(Moderator).Append("\n");
            sb.Append("  PublicWorkers: ").Append(PublicWorkers).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  MonthlyKudos: ").Append(MonthlyKudos).Append("\n");
            sb.Append("  Trusted: ").Append(Trusted).Append("\n");
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
            return this.Equals(input as PutUserSingleRequest);
        }

        /// <summary>
        /// Returns true if PutUserSingleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PutUserSingleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PutUserSingleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Kudos == input.Kudos ||
                    this.Kudos.Equals(input.Kudos)
                ) && 
                (
                    this.Concurrency == input.Concurrency ||
                    this.Concurrency.Equals(input.Concurrency)
                ) && 
                (
                    this.UsageMultiplier == input.UsageMultiplier ||
                    this.UsageMultiplier.Equals(input.UsageMultiplier)
                ) && 
                (
                    this.WorkerInvite == input.WorkerInvite ||
                    this.WorkerInvite.Equals(input.WorkerInvite)
                ) && 
                (
                    this.Moderator == input.Moderator ||
                    this.Moderator.Equals(input.Moderator)
                ) && 
                (
                    this.PublicWorkers == input.PublicWorkers ||
                    this.PublicWorkers.Equals(input.PublicWorkers)
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.MonthlyKudos == input.MonthlyKudos ||
                    this.MonthlyKudos.Equals(input.MonthlyKudos)
                ) && 
                (
                    this.Trusted == input.Trusted ||
                    this.Trusted.Equals(input.Trusted)
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
                hashCode = (hashCode * 59) + this.Kudos.GetHashCode();
                hashCode = (hashCode * 59) + this.Concurrency.GetHashCode();
                hashCode = (hashCode * 59) + this.UsageMultiplier.GetHashCode();
                hashCode = (hashCode * 59) + this.WorkerInvite.GetHashCode();
                hashCode = (hashCode * 59) + this.Moderator.GetHashCode();
                hashCode = (hashCode * 59) + this.PublicWorkers.GetHashCode();
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MonthlyKudos.GetHashCode();
                hashCode = (hashCode * 59) + this.Trusted.GetHashCode();
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
