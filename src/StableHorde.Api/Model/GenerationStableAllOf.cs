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
    /// GenerationStableAllOf
    /// </summary>
    [DataContract(Name = "GenerationStable_allOf")]
    public partial class GenerationStableAllOf : IEquatable<GenerationStableAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationStableAllOf" /> class.
        /// </summary>
        /// <param name="img">The generated image as a Base64-encoded .webp file.</param>
        /// <param name="seed">The seed which generated this image.</param>
        public GenerationStableAllOf(string img = default(string), string seed = default(string))
        {
            this.Img = img;
            this.Seed = seed;
        }

        /// <summary>
        /// The generated image as a Base64-encoded .webp file
        /// </summary>
        /// <value>The generated image as a Base64-encoded .webp file</value>
        [DataMember(Name = "img", EmitDefaultValue = false)]
        public string Img { get; set; }

        /// <summary>
        /// The seed which generated this image
        /// </summary>
        /// <value>The seed which generated this image</value>
        [DataMember(Name = "seed", EmitDefaultValue = false)]
        public string Seed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GenerationStableAllOf {\n");
            sb.Append("  Img: ").Append(Img).Append("\n");
            sb.Append("  Seed: ").Append(Seed).Append("\n");
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
            return this.Equals(input as GenerationStableAllOf);
        }

        /// <summary>
        /// Returns true if GenerationStableAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of GenerationStableAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerationStableAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Img == input.Img ||
                    (this.Img != null &&
                    this.Img.Equals(input.Img))
                ) && 
                (
                    this.Seed == input.Seed ||
                    (this.Seed != null &&
                    this.Seed.Equals(input.Seed))
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
                if (this.Img != null)
                {
                    hashCode = (hashCode * 59) + this.Img.GetHashCode();
                }
                if (this.Seed != null)
                {
                    hashCode = (hashCode * 59) + this.Seed.GetHashCode();
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
