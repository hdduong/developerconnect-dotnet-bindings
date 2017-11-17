/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/


/* 
 * Loan
 *
 * APIs to manage eFolder related entities - document and attachment.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = Elli.Api.Loans.EFolder.Client.SwaggerDateConverter;

namespace Elli.Api.Loans.EFolder.Model
{
    /// <summary>
    /// EFolderAttachmentContractPages
    /// </summary>
    [DataContract]
    public partial class EFolderAttachmentContractPages :  IEquatable<EFolderAttachmentContractPages>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets ImageKey
        /// </summary>
        [DataMember(Name="imageKey", EmitDefaultValue=false)]
        public string ImageKey { get; set; }

        /// <summary>
        /// Gets or Sets ZipKey
        /// </summary>
        [DataMember(Name="zipKey", EmitDefaultValue=false)]
        public string ZipKey { get; set; }

        /// <summary>
        /// Gets or Sets NativeKey
        /// </summary>
        [DataMember(Name="nativeKey", EmitDefaultValue=false)]
        public string NativeKey { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or Sets HorizontalResolution
        /// </summary>
        [DataMember(Name="horizontalResolution", EmitDefaultValue=false)]
        public float? HorizontalResolution { get; set; }

        /// <summary>
        /// Gets or Sets VerticalResolution
        /// </summary>
        [DataMember(Name="verticalResolution", EmitDefaultValue=false)]
        public float? VerticalResolution { get; set; }

        /// <summary>
        /// Gets or Sets Rotation
        /// </summary>
        [DataMember(Name="rotation", EmitDefaultValue=false)]
        public int? Rotation { get; set; }

        /// <summary>
        /// Gets or Sets FileSize
        /// </summary>
        [DataMember(Name="fileSize", EmitDefaultValue=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// Gets or Sets Thumbnail
        /// </summary>
        [DataMember(Name="thumbnail", EmitDefaultValue=false)]
        public EFolderAttachmentContractThumbnail Thumbnail { get; set; }

        /// <summary>
        /// Gets or Sets Annotations
        /// </summary>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        public List<EFolderAttachmentContractAnnotations> Annotations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EFolderAttachmentContractPages {\n");
            sb.Append("  ImageKey: ").Append(ImageKey).Append("\n");
            sb.Append("  ZipKey: ").Append(ZipKey).Append("\n");
            sb.Append("  NativeKey: ").Append(NativeKey).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  HorizontalResolution: ").Append(HorizontalResolution).Append("\n");
            sb.Append("  VerticalResolution: ").Append(VerticalResolution).Append("\n");
            sb.Append("  Rotation: ").Append(Rotation).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EFolderAttachmentContractPages);
        }

        /// <summary>
        /// Returns true if EFolderAttachmentContractPages instances are equal
        /// </summary>
        /// <param name="input">Instance of EFolderAttachmentContractPages to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EFolderAttachmentContractPages input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImageKey == input.ImageKey ||
                    (this.ImageKey != null &&
                    this.ImageKey.Equals(input.ImageKey))
                ) && 
                (
                    this.ZipKey == input.ZipKey ||
                    (this.ZipKey != null &&
                    this.ZipKey.Equals(input.ZipKey))
                ) && 
                (
                    this.NativeKey == input.NativeKey ||
                    (this.NativeKey != null &&
                    this.NativeKey.Equals(input.NativeKey))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.HorizontalResolution == input.HorizontalResolution ||
                    (this.HorizontalResolution != null &&
                    this.HorizontalResolution.Equals(input.HorizontalResolution))
                ) && 
                (
                    this.VerticalResolution == input.VerticalResolution ||
                    (this.VerticalResolution != null &&
                    this.VerticalResolution.Equals(input.VerticalResolution))
                ) && 
                (
                    this.Rotation == input.Rotation ||
                    (this.Rotation != null &&
                    this.Rotation.Equals(input.Rotation))
                ) && 
                (
                    this.FileSize == input.FileSize ||
                    (this.FileSize != null &&
                    this.FileSize.Equals(input.FileSize))
                ) && 
                (
                    this.Thumbnail == input.Thumbnail ||
                    (this.Thumbnail != null &&
                    this.Thumbnail.Equals(input.Thumbnail))
                ) && 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
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
                if (this.ImageKey != null)
                    hashCode = hashCode * 59 + this.ImageKey.GetHashCode();
                if (this.ZipKey != null)
                    hashCode = hashCode * 59 + this.ZipKey.GetHashCode();
                if (this.NativeKey != null)
                    hashCode = hashCode * 59 + this.NativeKey.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.HorizontalResolution != null)
                    hashCode = hashCode * 59 + this.HorizontalResolution.GetHashCode();
                if (this.VerticalResolution != null)
                    hashCode = hashCode * 59 + this.VerticalResolution.GetHashCode();
                if (this.Rotation != null)
                    hashCode = hashCode * 59 + this.Rotation.GetHashCode();
                if (this.FileSize != null)
                    hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.Thumbnail != null)
                    hashCode = hashCode * 59 + this.Thumbnail.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
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
            yield break;
        }
    }

}
