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
    /// ModifyUser
    /// </summary>
    [DataContract(Name = "ModifyUser")]
    public partial class ModifyUser : IEquatable<ModifyUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyUser" /> class.
        /// </summary>
        /// <param name="newKudos">The new total Kudos this user has after this request.</param>
        /// <param name="concurrency">The request concurrency this user has after this request.</param>
        /// <param name="usageMultiplier">Multiplies the amount of kudos lost when generating images..</param>
        /// <param name="workerInvited">Whether this user has been invited to join a worker to the horde and how many of them. When 0, this user cannot add (new) workers to the horde..</param>
        /// <param name="moderator">The user&#39;s new moderator status..</param>
        /// <param name="publicWorkers">The user&#39;s new public_workers status..</param>
        /// <param name="username">The user&#39;s new username..</param>
        /// <param name="monthlyKudos">The user&#39;s new monthly kudos total.</param>
        /// <param name="trusted">The user&#39;s new trusted status.</param>
        public ModifyUser(decimal newKudos = default(decimal), int concurrency = default(int), decimal usageMultiplier = default(decimal), int workerInvited = default(int), bool moderator = default(bool), bool publicWorkers = default(bool), string username = default(string), int monthlyKudos = default(int), bool trusted = default(bool))
        {
            this.NewKudos = newKudos;
            this.Concurrency = concurrency;
            this.UsageMultiplier = usageMultiplier;
            this.WorkerInvited = workerInvited;
            this.Moderator = moderator;
            this.PublicWorkers = publicWorkers;
            this.Username = username;
            this.MonthlyKudos = monthlyKudos;
            this.Trusted = trusted;
        }

        /// <summary>
        /// The new total Kudos this user has after this request
        /// </summary>
        /// <value>The new total Kudos this user has after this request</value>
        [DataMember(Name = "new_kudos", EmitDefaultValue = false)]
        public decimal NewKudos { get; set; }

        /// <summary>
        /// The request concurrency this user has after this request
        /// </summary>
        /// <value>The request concurrency this user has after this request</value>
        [DataMember(Name = "concurrency", EmitDefaultValue = false)]
        public int Concurrency { get; set; }

        /// <summary>
        /// Multiplies the amount of kudos lost when generating images.
        /// </summary>
        /// <value>Multiplies the amount of kudos lost when generating images.</value>
        [DataMember(Name = "usage_multiplier", EmitDefaultValue = false)]
        public decimal UsageMultiplier { get; set; }

        /// <summary>
        /// Whether this user has been invited to join a worker to the horde and how many of them. When 0, this user cannot add (new) workers to the horde.
        /// </summary>
        /// <value>Whether this user has been invited to join a worker to the horde and how many of them. When 0, this user cannot add (new) workers to the horde.</value>
        [DataMember(Name = "worker_invited", EmitDefaultValue = false)]
        public int WorkerInvited { get; set; }

        /// <summary>
        /// The user&#39;s new moderator status.
        /// </summary>
        /// <value>The user&#39;s new moderator status.</value>
        [DataMember(Name = "moderator", EmitDefaultValue = true)]
        public bool Moderator { get; set; }

        /// <summary>
        /// The user&#39;s new public_workers status.
        /// </summary>
        /// <value>The user&#39;s new public_workers status.</value>
        [DataMember(Name = "public_workers", EmitDefaultValue = true)]
        public bool PublicWorkers { get; set; }

        /// <summary>
        /// The user&#39;s new username.
        /// </summary>
        /// <value>The user&#39;s new username.</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// The user&#39;s new monthly kudos total
        /// </summary>
        /// <value>The user&#39;s new monthly kudos total</value>
        [DataMember(Name = "monthly_kudos", EmitDefaultValue = false)]
        public int MonthlyKudos { get; set; }

        /// <summary>
        /// The user&#39;s new trusted status
        /// </summary>
        /// <value>The user&#39;s new trusted status</value>
        [DataMember(Name = "trusted", EmitDefaultValue = true)]
        public bool Trusted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModifyUser {\n");
            sb.Append("  NewKudos: ").Append(NewKudos).Append("\n");
            sb.Append("  Concurrency: ").Append(Concurrency).Append("\n");
            sb.Append("  UsageMultiplier: ").Append(UsageMultiplier).Append("\n");
            sb.Append("  WorkerInvited: ").Append(WorkerInvited).Append("\n");
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
            return this.Equals(input as ModifyUser);
        }

        /// <summary>
        /// Returns true if ModifyUser instances are equal
        /// </summary>
        /// <param name="input">Instance of ModifyUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifyUser input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NewKudos == input.NewKudos ||
                    this.NewKudos.Equals(input.NewKudos)
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
                    this.WorkerInvited == input.WorkerInvited ||
                    this.WorkerInvited.Equals(input.WorkerInvited)
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
                hashCode = (hashCode * 59) + this.NewKudos.GetHashCode();
                hashCode = (hashCode * 59) + this.Concurrency.GetHashCode();
                hashCode = (hashCode * 59) + this.UsageMultiplier.GetHashCode();
                hashCode = (hashCode * 59) + this.WorkerInvited.GetHashCode();
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