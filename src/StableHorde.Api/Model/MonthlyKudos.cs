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
    /// MonthlyKudos
    /// </summary>
    [DataContract(Name = "MonthlyKudos")]
    public partial class MonthlyKudos : IEquatable<MonthlyKudos>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyKudos" /> class.
        /// </summary>
        /// <param name="amount">How much recurring Kudos this user receives monthly..</param>
        /// <param name="lastReceived">Last date this user received monthly Kudos..</param>
        public MonthlyKudos(int amount = default(int), DateTime lastReceived = default(DateTime))
        {
            this.Amount = amount;
            this.LastReceived = lastReceived;
        }

        /// <summary>
        /// How much recurring Kudos this user receives monthly.
        /// </summary>
        /// <value>How much recurring Kudos this user receives monthly.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public int Amount { get; set; }

        /// <summary>
        /// Last date this user received monthly Kudos.
        /// </summary>
        /// <value>Last date this user received monthly Kudos.</value>
        [DataMember(Name = "last_received", EmitDefaultValue = false)]
        public DateTime LastReceived { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MonthlyKudos {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  LastReceived: ").Append(LastReceived).Append("\n");
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
            return this.Equals(input as MonthlyKudos);
        }

        /// <summary>
        /// Returns true if MonthlyKudos instances are equal
        /// </summary>
        /// <param name="input">Instance of MonthlyKudos to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MonthlyKudos input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.LastReceived == input.LastReceived ||
                    (this.LastReceived != null &&
                    this.LastReceived.Equals(input.LastReceived))
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
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.LastReceived != null)
                {
                    hashCode = (hashCode * 59) + this.LastReceived.GetHashCode();
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
