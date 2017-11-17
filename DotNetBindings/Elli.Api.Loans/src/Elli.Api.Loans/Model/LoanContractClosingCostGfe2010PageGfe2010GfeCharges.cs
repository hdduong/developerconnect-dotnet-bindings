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
 * Returns the entire loan or specific entities of a loan.
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
using SwaggerDateConverter = Elli.Api.Loans.Client.SwaggerDateConverter;

namespace Elli.Api.Loans.Model
{
    /// <summary>
    /// LoanContractClosingCostGfe2010PageGfe2010GfeCharges
    /// </summary>
    [DataContract]
    public partial class LoanContractClosingCostGfe2010PageGfe2010GfeCharges :  IEquatable<LoanContractClosingCostGfe2010PageGfe2010GfeCharges>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ChargeBelow10Indicator
        /// </summary>
        [DataMember(Name="chargeBelow10Indicator", EmitDefaultValue=false)]
        public bool? ChargeBelow10Indicator { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Gfe2010GfeChargeIndex
        /// </summary>
        [DataMember(Name="gfe2010GfeChargeIndex", EmitDefaultValue=false)]
        public int? Gfe2010GfeChargeIndex { get; set; }

        /// <summary>
        /// Gets or Sets GfeCharge
        /// </summary>
        [DataMember(Name="gfeCharge", EmitDefaultValue=false)]
        public double? GfeCharge { get; set; }

        /// <summary>
        /// Gets or Sets HudCharge
        /// </summary>
        [DataMember(Name="hudCharge", EmitDefaultValue=false)]
        public double? HudCharge { get; set; }

        /// <summary>
        /// Gets or Sets Line
        /// </summary>
        [DataMember(Name="line", EmitDefaultValue=false)]
        public string Line { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractClosingCostGfe2010PageGfe2010GfeCharges {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ChargeBelow10Indicator: ").Append(ChargeBelow10Indicator).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Gfe2010GfeChargeIndex: ").Append(Gfe2010GfeChargeIndex).Append("\n");
            sb.Append("  GfeCharge: ").Append(GfeCharge).Append("\n");
            sb.Append("  HudCharge: ").Append(HudCharge).Append("\n");
            sb.Append("  Line: ").Append(Line).Append("\n");
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
            return this.Equals(input as LoanContractClosingCostGfe2010PageGfe2010GfeCharges);
        }

        /// <summary>
        /// Returns true if LoanContractClosingCostGfe2010PageGfe2010GfeCharges instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractClosingCostGfe2010PageGfe2010GfeCharges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractClosingCostGfe2010PageGfe2010GfeCharges input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ChargeBelow10Indicator == input.ChargeBelow10Indicator ||
                    (this.ChargeBelow10Indicator != null &&
                    this.ChargeBelow10Indicator.Equals(input.ChargeBelow10Indicator))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Gfe2010GfeChargeIndex == input.Gfe2010GfeChargeIndex ||
                    (this.Gfe2010GfeChargeIndex != null &&
                    this.Gfe2010GfeChargeIndex.Equals(input.Gfe2010GfeChargeIndex))
                ) && 
                (
                    this.GfeCharge == input.GfeCharge ||
                    (this.GfeCharge != null &&
                    this.GfeCharge.Equals(input.GfeCharge))
                ) && 
                (
                    this.HudCharge == input.HudCharge ||
                    (this.HudCharge != null &&
                    this.HudCharge.Equals(input.HudCharge))
                ) && 
                (
                    this.Line == input.Line ||
                    (this.Line != null &&
                    this.Line.Equals(input.Line))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ChargeBelow10Indicator != null)
                    hashCode = hashCode * 59 + this.ChargeBelow10Indicator.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Gfe2010GfeChargeIndex != null)
                    hashCode = hashCode * 59 + this.Gfe2010GfeChargeIndex.GetHashCode();
                if (this.GfeCharge != null)
                    hashCode = hashCode * 59 + this.GfeCharge.GetHashCode();
                if (this.HudCharge != null)
                    hashCode = hashCode * 59 + this.HudCharge.GetHashCode();
                if (this.Line != null)
                    hashCode = hashCode * 59 + this.Line.GetHashCode();
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
