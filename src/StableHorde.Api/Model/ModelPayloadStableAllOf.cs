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
    /// ModelPayloadStableAllOf
    /// </summary>
    [DataContract(Name = "ModelPayloadStable_allOf")]
    public partial class ModelPayloadStableAllOf : IEquatable<ModelPayloadStableAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPayloadStableAllOf" /> class.
        /// </summary>
        /// <param name="prompt">The prompt which will be sent to Stable Diffusion to generate an image.</param>
        /// <param name="ddimSteps">ddimSteps.</param>
        /// <param name="nIter">The amount of images to generate.</param>
        /// <param name="useNsfwCensor">When true will apply NSFW censoring model on the generation.</param>
        public ModelPayloadStableAllOf(string prompt = default(string), int ddimSteps = default(int), int nIter = default(int), bool useNsfwCensor = default(bool))
        {
            this.Prompt = prompt;
            this.DdimSteps = ddimSteps;
            this.NIter = nIter;
            this.UseNsfwCensor = useNsfwCensor;
        }

        /// <summary>
        /// The prompt which will be sent to Stable Diffusion to generate an image
        /// </summary>
        /// <value>The prompt which will be sent to Stable Diffusion to generate an image</value>
        [DataMember(Name = "prompt", EmitDefaultValue = false)]
        public string Prompt { get; set; }

        /// <summary>
        /// Gets or Sets DdimSteps
        /// </summary>
        [DataMember(Name = "ddim_steps", EmitDefaultValue = false)]
        public int DdimSteps { get; set; }

        /// <summary>
        /// The amount of images to generate
        /// </summary>
        /// <value>The amount of images to generate</value>
        [DataMember(Name = "n_iter", EmitDefaultValue = false)]
        public int NIter { get; set; }

        /// <summary>
        /// When true will apply NSFW censoring model on the generation
        /// </summary>
        /// <value>When true will apply NSFW censoring model on the generation</value>
        [DataMember(Name = "use_nsfw_censor", EmitDefaultValue = true)]
        public bool UseNsfwCensor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModelPayloadStableAllOf {\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
            sb.Append("  DdimSteps: ").Append(DdimSteps).Append("\n");
            sb.Append("  NIter: ").Append(NIter).Append("\n");
            sb.Append("  UseNsfwCensor: ").Append(UseNsfwCensor).Append("\n");
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
            return this.Equals(input as ModelPayloadStableAllOf);
        }

        /// <summary>
        /// Returns true if ModelPayloadStableAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelPayloadStableAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelPayloadStableAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Prompt == input.Prompt ||
                    (this.Prompt != null &&
                    this.Prompt.Equals(input.Prompt))
                ) && 
                (
                    this.DdimSteps == input.DdimSteps ||
                    this.DdimSteps.Equals(input.DdimSteps)
                ) && 
                (
                    this.NIter == input.NIter ||
                    this.NIter.Equals(input.NIter)
                ) && 
                (
                    this.UseNsfwCensor == input.UseNsfwCensor ||
                    this.UseNsfwCensor.Equals(input.UseNsfwCensor)
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
                if (this.Prompt != null)
                {
                    hashCode = (hashCode * 59) + this.Prompt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DdimSteps.GetHashCode();
                hashCode = (hashCode * 59) + this.NIter.GetHashCode();
                hashCode = (hashCode * 59) + this.UseNsfwCensor.GetHashCode();
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