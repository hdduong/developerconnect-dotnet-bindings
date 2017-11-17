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
    /// LoanContractLoanSubmission
    /// </summary>
    [DataContract]
    public partial class LoanContractLoanSubmission :  IEquatable<LoanContractLoanSubmission>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AmountAvailable
        /// </summary>
        [DataMember(Name="amountAvailable", EmitDefaultValue=false)]
        public double? AmountAvailable { get; set; }

        /// <summary>
        /// Gets or Sets AmountRequiredToClose
        /// </summary>
        [DataMember(Name="amountRequiredToClose", EmitDefaultValue=false)]
        public double? AmountRequiredToClose { get; set; }

        /// <summary>
        /// Gets or Sets BuydownDescription
        /// </summary>
        [DataMember(Name="buydownDescription", EmitDefaultValue=false)]
        public string BuydownDescription { get; set; }

        /// <summary>
        /// Gets or Sets BuydownMonthsPerAdjustment
        /// </summary>
        [DataMember(Name="buydownMonthsPerAdjustment", EmitDefaultValue=false)]
        public string BuydownMonthsPerAdjustment { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets CurrentRateSetDate
        /// </summary>
        [DataMember(Name="currentRateSetDate", EmitDefaultValue=false)]
        public DateTime? CurrentRateSetDate { get; set; }

        /// <summary>
        /// Gets or Sets RateLockDisclosureDate
        /// </summary>
        [DataMember(Name="rateLockDisclosureDate", EmitDefaultValue=false)]
        public DateTime? RateLockDisclosureDate { get; set; }

        /// <summary>
        /// Gets or Sets DateLastPaymentReceived
        /// </summary>
        [DataMember(Name="dateLastPaymentReceived", EmitDefaultValue=false)]
        public DateTime? DateLastPaymentReceived { get; set; }

        /// <summary>
        /// Gets or Sets FloodIndicator
        /// </summary>
        [DataMember(Name="floodIndicator", EmitDefaultValue=false)]
        public bool? FloodIndicator { get; set; }

        /// <summary>
        /// Gets or Sets HazardIndicator
        /// </summary>
        [DataMember(Name="hazardIndicator", EmitDefaultValue=false)]
        public bool? HazardIndicator { get; set; }

        /// <summary>
        /// Gets or Sets LoanSubmissionFees
        /// </summary>
        [DataMember(Name="loanSubmissionFees", EmitDefaultValue=false)]
        public List<LoanContractLoanSubmissionLoanSubmissionFees> LoanSubmissionFees { get; set; }

        /// <summary>
        /// Gets or Sets LockDate
        /// </summary>
        [DataMember(Name="lockDate", EmitDefaultValue=false)]
        public DateTime? LockDate { get; set; }

        /// <summary>
        /// Gets or Sets LockDateTimestampUtc
        /// </summary>
        [DataMember(Name="lockDateTimestampUtc", EmitDefaultValue=false)]
        public DateTime? LockDateTimestampUtc { get; set; }

        /// <summary>
        /// Gets or Sets LockExpiresDate
        /// </summary>
        [DataMember(Name="lockExpiresDate", EmitDefaultValue=false)]
        public DateTime? LockExpiresDate { get; set; }

        /// <summary>
        /// Gets or Sets MmmPmiIndicator
        /// </summary>
        [DataMember(Name="mmmPmiIndicator", EmitDefaultValue=false)]
        public bool? MmmPmiIndicator { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfDays
        /// </summary>
        [DataMember(Name="numberOfDays", EmitDefaultValue=false)]
        public int? NumberOfDays { get; set; }

        /// <summary>
        /// Gets or Sets OtherDescription
        /// </summary>
        [DataMember(Name="otherDescription", EmitDefaultValue=false)]
        public string OtherDescription { get; set; }

        /// <summary>
        /// Gets or Sets OtherIndicator
        /// </summary>
        [DataMember(Name="otherIndicator", EmitDefaultValue=false)]
        public bool? OtherIndicator { get; set; }

        /// <summary>
        /// Gets or Sets ProgramCode
        /// </summary>
        [DataMember(Name="programCode", EmitDefaultValue=false)]
        public string ProgramCode { get; set; }

        /// <summary>
        /// Gets or Sets RateLock
        /// </summary>
        [DataMember(Name="rateLock", EmitDefaultValue=false)]
        public string RateLock { get; set; }

        /// <summary>
        /// Gets or Sets ReducedDocsIndicator
        /// </summary>
        [DataMember(Name="reducedDocsIndicator", EmitDefaultValue=false)]
        public bool? ReducedDocsIndicator { get; set; }

        /// <summary>
        /// Gets or Sets TaxesIndicator
        /// </summary>
        [DataMember(Name="taxesIndicator", EmitDefaultValue=false)]
        public bool? TaxesIndicator { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public double? Total { get; set; }

        /// <summary>
        /// Gets or Sets TotalDiscountPointCharged
        /// </summary>
        [DataMember(Name="totalDiscountPointCharged", EmitDefaultValue=false)]
        public double? TotalDiscountPointCharged { get; set; }

        /// <summary>
        /// Gets or Sets TotalForDueBroker
        /// </summary>
        [DataMember(Name="totalForDueBroker", EmitDefaultValue=false)]
        public double? TotalForDueBroker { get; set; }

        /// <summary>
        /// Gets or Sets TotalForDueLender
        /// </summary>
        [DataMember(Name="totalForDueLender", EmitDefaultValue=false)]
        public double? TotalForDueLender { get; set; }

        /// <summary>
        /// Gets or Sets TotalForPrimaryResidence
        /// </summary>
        [DataMember(Name="totalForPrimaryResidence", EmitDefaultValue=false)]
        public double? TotalForPrimaryResidence { get; set; }

        /// <summary>
        /// Gets or Sets IsSecondaryRegistration
        /// </summary>
        [DataMember(Name="isSecondaryRegistration", EmitDefaultValue=false)]
        public bool? IsSecondaryRegistration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractLoanSubmission {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AmountAvailable: ").Append(AmountAvailable).Append("\n");
            sb.Append("  AmountRequiredToClose: ").Append(AmountRequiredToClose).Append("\n");
            sb.Append("  BuydownDescription: ").Append(BuydownDescription).Append("\n");
            sb.Append("  BuydownMonthsPerAdjustment: ").Append(BuydownMonthsPerAdjustment).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  CurrentRateSetDate: ").Append(CurrentRateSetDate).Append("\n");
            sb.Append("  RateLockDisclosureDate: ").Append(RateLockDisclosureDate).Append("\n");
            sb.Append("  DateLastPaymentReceived: ").Append(DateLastPaymentReceived).Append("\n");
            sb.Append("  FloodIndicator: ").Append(FloodIndicator).Append("\n");
            sb.Append("  HazardIndicator: ").Append(HazardIndicator).Append("\n");
            sb.Append("  LoanSubmissionFees: ").Append(LoanSubmissionFees).Append("\n");
            sb.Append("  LockDate: ").Append(LockDate).Append("\n");
            sb.Append("  LockDateTimestampUtc: ").Append(LockDateTimestampUtc).Append("\n");
            sb.Append("  LockExpiresDate: ").Append(LockExpiresDate).Append("\n");
            sb.Append("  MmmPmiIndicator: ").Append(MmmPmiIndicator).Append("\n");
            sb.Append("  NumberOfDays: ").Append(NumberOfDays).Append("\n");
            sb.Append("  OtherDescription: ").Append(OtherDescription).Append("\n");
            sb.Append("  OtherIndicator: ").Append(OtherIndicator).Append("\n");
            sb.Append("  ProgramCode: ").Append(ProgramCode).Append("\n");
            sb.Append("  RateLock: ").Append(RateLock).Append("\n");
            sb.Append("  ReducedDocsIndicator: ").Append(ReducedDocsIndicator).Append("\n");
            sb.Append("  TaxesIndicator: ").Append(TaxesIndicator).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  TotalDiscountPointCharged: ").Append(TotalDiscountPointCharged).Append("\n");
            sb.Append("  TotalForDueBroker: ").Append(TotalForDueBroker).Append("\n");
            sb.Append("  TotalForDueLender: ").Append(TotalForDueLender).Append("\n");
            sb.Append("  TotalForPrimaryResidence: ").Append(TotalForPrimaryResidence).Append("\n");
            sb.Append("  IsSecondaryRegistration: ").Append(IsSecondaryRegistration).Append("\n");
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
            return this.Equals(input as LoanContractLoanSubmission);
        }

        /// <summary>
        /// Returns true if LoanContractLoanSubmission instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractLoanSubmission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractLoanSubmission input)
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
                    this.AmountAvailable == input.AmountAvailable ||
                    (this.AmountAvailable != null &&
                    this.AmountAvailable.Equals(input.AmountAvailable))
                ) && 
                (
                    this.AmountRequiredToClose == input.AmountRequiredToClose ||
                    (this.AmountRequiredToClose != null &&
                    this.AmountRequiredToClose.Equals(input.AmountRequiredToClose))
                ) && 
                (
                    this.BuydownDescription == input.BuydownDescription ||
                    (this.BuydownDescription != null &&
                    this.BuydownDescription.Equals(input.BuydownDescription))
                ) && 
                (
                    this.BuydownMonthsPerAdjustment == input.BuydownMonthsPerAdjustment ||
                    (this.BuydownMonthsPerAdjustment != null &&
                    this.BuydownMonthsPerAdjustment.Equals(input.BuydownMonthsPerAdjustment))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.CurrentRateSetDate == input.CurrentRateSetDate ||
                    (this.CurrentRateSetDate != null &&
                    this.CurrentRateSetDate.Equals(input.CurrentRateSetDate))
                ) && 
                (
                    this.RateLockDisclosureDate == input.RateLockDisclosureDate ||
                    (this.RateLockDisclosureDate != null &&
                    this.RateLockDisclosureDate.Equals(input.RateLockDisclosureDate))
                ) && 
                (
                    this.DateLastPaymentReceived == input.DateLastPaymentReceived ||
                    (this.DateLastPaymentReceived != null &&
                    this.DateLastPaymentReceived.Equals(input.DateLastPaymentReceived))
                ) && 
                (
                    this.FloodIndicator == input.FloodIndicator ||
                    (this.FloodIndicator != null &&
                    this.FloodIndicator.Equals(input.FloodIndicator))
                ) && 
                (
                    this.HazardIndicator == input.HazardIndicator ||
                    (this.HazardIndicator != null &&
                    this.HazardIndicator.Equals(input.HazardIndicator))
                ) && 
                (
                    this.LoanSubmissionFees == input.LoanSubmissionFees ||
                    this.LoanSubmissionFees != null &&
                    this.LoanSubmissionFees.SequenceEqual(input.LoanSubmissionFees)
                ) && 
                (
                    this.LockDate == input.LockDate ||
                    (this.LockDate != null &&
                    this.LockDate.Equals(input.LockDate))
                ) && 
                (
                    this.LockDateTimestampUtc == input.LockDateTimestampUtc ||
                    (this.LockDateTimestampUtc != null &&
                    this.LockDateTimestampUtc.Equals(input.LockDateTimestampUtc))
                ) && 
                (
                    this.LockExpiresDate == input.LockExpiresDate ||
                    (this.LockExpiresDate != null &&
                    this.LockExpiresDate.Equals(input.LockExpiresDate))
                ) && 
                (
                    this.MmmPmiIndicator == input.MmmPmiIndicator ||
                    (this.MmmPmiIndicator != null &&
                    this.MmmPmiIndicator.Equals(input.MmmPmiIndicator))
                ) && 
                (
                    this.NumberOfDays == input.NumberOfDays ||
                    (this.NumberOfDays != null &&
                    this.NumberOfDays.Equals(input.NumberOfDays))
                ) && 
                (
                    this.OtherDescription == input.OtherDescription ||
                    (this.OtherDescription != null &&
                    this.OtherDescription.Equals(input.OtherDescription))
                ) && 
                (
                    this.OtherIndicator == input.OtherIndicator ||
                    (this.OtherIndicator != null &&
                    this.OtherIndicator.Equals(input.OtherIndicator))
                ) && 
                (
                    this.ProgramCode == input.ProgramCode ||
                    (this.ProgramCode != null &&
                    this.ProgramCode.Equals(input.ProgramCode))
                ) && 
                (
                    this.RateLock == input.RateLock ||
                    (this.RateLock != null &&
                    this.RateLock.Equals(input.RateLock))
                ) && 
                (
                    this.ReducedDocsIndicator == input.ReducedDocsIndicator ||
                    (this.ReducedDocsIndicator != null &&
                    this.ReducedDocsIndicator.Equals(input.ReducedDocsIndicator))
                ) && 
                (
                    this.TaxesIndicator == input.TaxesIndicator ||
                    (this.TaxesIndicator != null &&
                    this.TaxesIndicator.Equals(input.TaxesIndicator))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.TotalDiscountPointCharged == input.TotalDiscountPointCharged ||
                    (this.TotalDiscountPointCharged != null &&
                    this.TotalDiscountPointCharged.Equals(input.TotalDiscountPointCharged))
                ) && 
                (
                    this.TotalForDueBroker == input.TotalForDueBroker ||
                    (this.TotalForDueBroker != null &&
                    this.TotalForDueBroker.Equals(input.TotalForDueBroker))
                ) && 
                (
                    this.TotalForDueLender == input.TotalForDueLender ||
                    (this.TotalForDueLender != null &&
                    this.TotalForDueLender.Equals(input.TotalForDueLender))
                ) && 
                (
                    this.TotalForPrimaryResidence == input.TotalForPrimaryResidence ||
                    (this.TotalForPrimaryResidence != null &&
                    this.TotalForPrimaryResidence.Equals(input.TotalForPrimaryResidence))
                ) && 
                (
                    this.IsSecondaryRegistration == input.IsSecondaryRegistration ||
                    (this.IsSecondaryRegistration != null &&
                    this.IsSecondaryRegistration.Equals(input.IsSecondaryRegistration))
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
                if (this.AmountAvailable != null)
                    hashCode = hashCode * 59 + this.AmountAvailable.GetHashCode();
                if (this.AmountRequiredToClose != null)
                    hashCode = hashCode * 59 + this.AmountRequiredToClose.GetHashCode();
                if (this.BuydownDescription != null)
                    hashCode = hashCode * 59 + this.BuydownDescription.GetHashCode();
                if (this.BuydownMonthsPerAdjustment != null)
                    hashCode = hashCode * 59 + this.BuydownMonthsPerAdjustment.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.CurrentRateSetDate != null)
                    hashCode = hashCode * 59 + this.CurrentRateSetDate.GetHashCode();
                if (this.RateLockDisclosureDate != null)
                    hashCode = hashCode * 59 + this.RateLockDisclosureDate.GetHashCode();
                if (this.DateLastPaymentReceived != null)
                    hashCode = hashCode * 59 + this.DateLastPaymentReceived.GetHashCode();
                if (this.FloodIndicator != null)
                    hashCode = hashCode * 59 + this.FloodIndicator.GetHashCode();
                if (this.HazardIndicator != null)
                    hashCode = hashCode * 59 + this.HazardIndicator.GetHashCode();
                if (this.LoanSubmissionFees != null)
                    hashCode = hashCode * 59 + this.LoanSubmissionFees.GetHashCode();
                if (this.LockDate != null)
                    hashCode = hashCode * 59 + this.LockDate.GetHashCode();
                if (this.LockDateTimestampUtc != null)
                    hashCode = hashCode * 59 + this.LockDateTimestampUtc.GetHashCode();
                if (this.LockExpiresDate != null)
                    hashCode = hashCode * 59 + this.LockExpiresDate.GetHashCode();
                if (this.MmmPmiIndicator != null)
                    hashCode = hashCode * 59 + this.MmmPmiIndicator.GetHashCode();
                if (this.NumberOfDays != null)
                    hashCode = hashCode * 59 + this.NumberOfDays.GetHashCode();
                if (this.OtherDescription != null)
                    hashCode = hashCode * 59 + this.OtherDescription.GetHashCode();
                if (this.OtherIndicator != null)
                    hashCode = hashCode * 59 + this.OtherIndicator.GetHashCode();
                if (this.ProgramCode != null)
                    hashCode = hashCode * 59 + this.ProgramCode.GetHashCode();
                if (this.RateLock != null)
                    hashCode = hashCode * 59 + this.RateLock.GetHashCode();
                if (this.ReducedDocsIndicator != null)
                    hashCode = hashCode * 59 + this.ReducedDocsIndicator.GetHashCode();
                if (this.TaxesIndicator != null)
                    hashCode = hashCode * 59 + this.TaxesIndicator.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.TotalDiscountPointCharged != null)
                    hashCode = hashCode * 59 + this.TotalDiscountPointCharged.GetHashCode();
                if (this.TotalForDueBroker != null)
                    hashCode = hashCode * 59 + this.TotalForDueBroker.GetHashCode();
                if (this.TotalForDueLender != null)
                    hashCode = hashCode * 59 + this.TotalForDueLender.GetHashCode();
                if (this.TotalForPrimaryResidence != null)
                    hashCode = hashCode * 59 + this.TotalForPrimaryResidence.GetHashCode();
                if (this.IsSecondaryRegistration != null)
                    hashCode = hashCode * 59 + this.IsSecondaryRegistration.GetHashCode();
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
