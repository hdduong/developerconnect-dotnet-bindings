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
    /// LoanContractTQLTQLComplianceAlerts
    /// </summary>
    [DataContract]
    public partial class LoanContractTQLTQLComplianceAlerts :  IEquatable<LoanContractTQLTQLComplianceAlerts>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets LastComplianceOrderAlertCategories
        /// </summary>
        [DataMember(Name="lastComplianceOrderAlertCategories", EmitDefaultValue=false)]
        public string LastComplianceOrderAlertCategories { get; set; }

        /// <summary>
        /// Gets or Sets LastComplianceOrderAlertMessage
        /// </summary>
        [DataMember(Name="lastComplianceOrderAlertMessage", EmitDefaultValue=false)]
        public string LastComplianceOrderAlertMessage { get; set; }

        /// <summary>
        /// Gets or Sets LastComplianceOrderDescriptionOfAlerts
        /// </summary>
        [DataMember(Name="lastComplianceOrderDescriptionOfAlerts", EmitDefaultValue=false)]
        public string LastComplianceOrderDescriptionOfAlerts { get; set; }

        /// <summary>
        /// Gets or Sets TQLComplianceAlertIndex
        /// </summary>
        [DataMember(Name="tQLComplianceAlertIndex", EmitDefaultValue=false)]
        public int? TQLComplianceAlertIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractTQLTQLComplianceAlerts {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastComplianceOrderAlertCategories: ").Append(LastComplianceOrderAlertCategories).Append("\n");
            sb.Append("  LastComplianceOrderAlertMessage: ").Append(LastComplianceOrderAlertMessage).Append("\n");
            sb.Append("  LastComplianceOrderDescriptionOfAlerts: ").Append(LastComplianceOrderDescriptionOfAlerts).Append("\n");
            sb.Append("  TQLComplianceAlertIndex: ").Append(TQLComplianceAlertIndex).Append("\n");
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
            return this.Equals(input as LoanContractTQLTQLComplianceAlerts);
        }

        /// <summary>
        /// Returns true if LoanContractTQLTQLComplianceAlerts instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractTQLTQLComplianceAlerts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractTQLTQLComplianceAlerts input)
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
                    this.LastComplianceOrderAlertCategories == input.LastComplianceOrderAlertCategories ||
                    (this.LastComplianceOrderAlertCategories != null &&
                    this.LastComplianceOrderAlertCategories.Equals(input.LastComplianceOrderAlertCategories))
                ) && 
                (
                    this.LastComplianceOrderAlertMessage == input.LastComplianceOrderAlertMessage ||
                    (this.LastComplianceOrderAlertMessage != null &&
                    this.LastComplianceOrderAlertMessage.Equals(input.LastComplianceOrderAlertMessage))
                ) && 
                (
                    this.LastComplianceOrderDescriptionOfAlerts == input.LastComplianceOrderDescriptionOfAlerts ||
                    (this.LastComplianceOrderDescriptionOfAlerts != null &&
                    this.LastComplianceOrderDescriptionOfAlerts.Equals(input.LastComplianceOrderDescriptionOfAlerts))
                ) && 
                (
                    this.TQLComplianceAlertIndex == input.TQLComplianceAlertIndex ||
                    (this.TQLComplianceAlertIndex != null &&
                    this.TQLComplianceAlertIndex.Equals(input.TQLComplianceAlertIndex))
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
                if (this.LastComplianceOrderAlertCategories != null)
                    hashCode = hashCode * 59 + this.LastComplianceOrderAlertCategories.GetHashCode();
                if (this.LastComplianceOrderAlertMessage != null)
                    hashCode = hashCode * 59 + this.LastComplianceOrderAlertMessage.GetHashCode();
                if (this.LastComplianceOrderDescriptionOfAlerts != null)
                    hashCode = hashCode * 59 + this.LastComplianceOrderDescriptionOfAlerts.GetHashCode();
                if (this.TQLComplianceAlertIndex != null)
                    hashCode = hashCode * 59 + this.TQLComplianceAlertIndex.GetHashCode();
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
