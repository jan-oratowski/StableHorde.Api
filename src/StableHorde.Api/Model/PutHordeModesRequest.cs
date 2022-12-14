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
    /// PutHordeModesRequest
    /// </summary>
    [DataContract(Name = "put_horde_modes_request")]
    public partial class PutHordeModesRequest : IEquatable<PutHordeModesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutHordeModesRequest" /> class.
        /// </summary>
        /// <param name="maintenance">maintenance.</param>
        /// <param name="inviteOnly">inviteOnly.</param>
        /// <param name="raid">raid.</param>
        public PutHordeModesRequest(bool maintenance = default(bool), bool inviteOnly = default(bool), bool raid = default(bool))
        {
            this.Maintenance = maintenance;
            this.InviteOnly = inviteOnly;
            this.Raid = raid;
        }

        /// <summary>
        /// Gets or Sets Maintenance
        /// </summary>
        [DataMember(Name = "maintenance", EmitDefaultValue = true)]
        public bool Maintenance { get; set; }

        /// <summary>
        /// Gets or Sets InviteOnly
        /// </summary>
        [DataMember(Name = "invite_only", EmitDefaultValue = true)]
        public bool InviteOnly { get; set; }

        /// <summary>
        /// Gets or Sets Raid
        /// </summary>
        [DataMember(Name = "raid", EmitDefaultValue = true)]
        public bool Raid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PutHordeModesRequest {\n");
            sb.Append("  Maintenance: ").Append(Maintenance).Append("\n");
            sb.Append("  InviteOnly: ").Append(InviteOnly).Append("\n");
            sb.Append("  Raid: ").Append(Raid).Append("\n");
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
            return this.Equals(input as PutHordeModesRequest);
        }

        /// <summary>
        /// Returns true if PutHordeModesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PutHordeModesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PutHordeModesRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Maintenance == input.Maintenance ||
                    this.Maintenance.Equals(input.Maintenance)
                ) && 
                (
                    this.InviteOnly == input.InviteOnly ||
                    this.InviteOnly.Equals(input.InviteOnly)
                ) && 
                (
                    this.Raid == input.Raid ||
                    this.Raid.Equals(input.Raid)
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
                hashCode = (hashCode * 59) + this.Maintenance.GetHashCode();
                hashCode = (hashCode * 59) + this.InviteOnly.GetHashCode();
                hashCode = (hashCode * 59) + this.Raid.GetHashCode();
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
