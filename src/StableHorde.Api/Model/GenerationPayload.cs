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
    /// GenerationPayload
    /// </summary>
    [DataContract(Name = "GenerationPayload")]
    public partial class GenerationPayload : IEquatable<GenerationPayload>, IValidatableObject
    {
        /// <summary>
        /// If source_image is provided, specifies how to process it.
        /// </summary>
        /// <value>If source_image is provided, specifies how to process it.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceProcessingEnum
        {
            /// <summary>
            /// Enum Img2img for value: img2img
            /// </summary>
            [EnumMember(Value = "img2img")]
            Img2img = 1,

            /// <summary>
            /// Enum Inpainting for value: inpainting
            /// </summary>
            [EnumMember(Value = "inpainting")]
            Inpainting = 2,

            /// <summary>
            /// Enum Outpainting for value: outpainting
            /// </summary>
            [EnumMember(Value = "outpainting")]
            Outpainting = 3

        }


        /// <summary>
        /// If source_image is provided, specifies how to process it.
        /// </summary>
        /// <value>If source_image is provided, specifies how to process it.</value>
        [DataMember(Name = "source_processing", EmitDefaultValue = false)]
        public SourceProcessingEnum? SourceProcessing { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationPayload" /> class.
        /// </summary>
        /// <param name="payload">payload.</param>
        /// <param name="id">The UUID for this image generation.</param>
        /// <param name="skipped">skipped.</param>
        /// <param name="model">Which of the available models to use for this request.</param>
        /// <param name="sourceImage">The Base64-encoded webp to use for img2img.</param>
        /// <param name="sourceProcessing">If source_image is provided, specifies how to process it. (default to SourceProcessingEnum.Img2img).</param>
        /// <param name="sourceMask">If img_processing is set to &#39;inpainting&#39; or &#39;outpainting&#39;, this parameter can be optionally provided as the mask of the areas to inpaint. If this arg is not passed, the inpainting/outpainting mask has to be embedded as alpha channel.</param>
        public GenerationPayload(ModelPayloadStable payload = default(ModelPayloadStable), string id = default(string), NoValidRequestFoundStable skipped = default(NoValidRequestFoundStable), string model = default(string), string sourceImage = default(string), SourceProcessingEnum? sourceProcessing = SourceProcessingEnum.Img2img, string sourceMask = default(string))
        {
            this.Payload = payload;
            this.Id = id;
            this.Skipped = skipped;
            this.Model = model;
            this.SourceImage = sourceImage;
            this.SourceProcessing = sourceProcessing;
            this.SourceMask = sourceMask;
        }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public ModelPayloadStable Payload { get; set; }

        /// <summary>
        /// The UUID for this image generation
        /// </summary>
        /// <value>The UUID for this image generation</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Skipped
        /// </summary>
        [DataMember(Name = "skipped", EmitDefaultValue = false)]
        public NoValidRequestFoundStable Skipped { get; set; }

        /// <summary>
        /// Which of the available models to use for this request
        /// </summary>
        /// <value>Which of the available models to use for this request</value>
        [DataMember(Name = "model", EmitDefaultValue = false)]
        public string Model { get; set; }

        /// <summary>
        /// The Base64-encoded webp to use for img2img
        /// </summary>
        /// <value>The Base64-encoded webp to use for img2img</value>
        [DataMember(Name = "source_image", EmitDefaultValue = false)]
        public string SourceImage { get; set; }

        /// <summary>
        /// If img_processing is set to &#39;inpainting&#39; or &#39;outpainting&#39;, this parameter can be optionally provided as the mask of the areas to inpaint. If this arg is not passed, the inpainting/outpainting mask has to be embedded as alpha channel
        /// </summary>
        /// <value>If img_processing is set to &#39;inpainting&#39; or &#39;outpainting&#39;, this parameter can be optionally provided as the mask of the areas to inpaint. If this arg is not passed, the inpainting/outpainting mask has to be embedded as alpha channel</value>
        [DataMember(Name = "source_mask", EmitDefaultValue = false)]
        public string SourceMask { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GenerationPayload {\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Skipped: ").Append(Skipped).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  SourceImage: ").Append(SourceImage).Append("\n");
            sb.Append("  SourceProcessing: ").Append(SourceProcessing).Append("\n");
            sb.Append("  SourceMask: ").Append(SourceMask).Append("\n");
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
            return this.Equals(input as GenerationPayload);
        }

        /// <summary>
        /// Returns true if GenerationPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of GenerationPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerationPayload input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Skipped == input.Skipped ||
                    (this.Skipped != null &&
                    this.Skipped.Equals(input.Skipped))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.SourceImage == input.SourceImage ||
                    (this.SourceImage != null &&
                    this.SourceImage.Equals(input.SourceImage))
                ) && 
                (
                    this.SourceProcessing == input.SourceProcessing ||
                    this.SourceProcessing.Equals(input.SourceProcessing)
                ) && 
                (
                    this.SourceMask == input.SourceMask ||
                    (this.SourceMask != null &&
                    this.SourceMask.Equals(input.SourceMask))
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
                if (this.Payload != null)
                {
                    hashCode = (hashCode * 59) + this.Payload.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Skipped != null)
                {
                    hashCode = (hashCode * 59) + this.Skipped.GetHashCode();
                }
                if (this.Model != null)
                {
                    hashCode = (hashCode * 59) + this.Model.GetHashCode();
                }
                if (this.SourceImage != null)
                {
                    hashCode = (hashCode * 59) + this.SourceImage.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SourceProcessing.GetHashCode();
                if (this.SourceMask != null)
                {
                    hashCode = (hashCode * 59) + this.SourceMask.GetHashCode();
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
