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
 * OpenAPI spec version: 1.2.1
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
    /// LoanContractHud1EsHud1EsPayTos
    /// </summary>
    [DataContract]
    public partial class LoanContractHud1EsHud1EsPayTos :  IEquatable<LoanContractHud1EsHud1EsPayTos>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets AmountLastPay
        /// </summary>
        [DataMember(Name="amountLastPay", EmitDefaultValue=false)]
        public double? AmountLastPay { get; set; }

        /// <summary>
        /// Gets or Sets AmountNextDue
        /// </summary>
        [DataMember(Name="amountNextDue", EmitDefaultValue=false)]
        public double? AmountNextDue { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets ContactName
        /// </summary>
        [DataMember(Name="contactName", EmitDefaultValue=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or Sets CoverageAmount
        /// </summary>
        [DataMember(Name="coverageAmount", EmitDefaultValue=false)]
        public double? CoverageAmount { get; set; }

        /// <summary>
        /// Gets or Sets DatePaid
        /// </summary>
        [DataMember(Name="datePaid", EmitDefaultValue=false)]
        public DateTime? DatePaid { get; set; }

        /// <summary>
        /// Gets or Sets DelinquentDate
        /// </summary>
        [DataMember(Name="delinquentDate", EmitDefaultValue=false)]
        public DateTime? DelinquentDate { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Fax
        /// </summary>
        [DataMember(Name="fax", EmitDefaultValue=false)]
        public string Fax { get; set; }

        /// <summary>
        /// Gets or Sets FeeType
        /// </summary>
        [DataMember(Name="feeType", EmitDefaultValue=false)]
        public string FeeType { get; set; }

        /// <summary>
        /// Gets or Sets Hud1EsPayToIndex
        /// </summary>
        [DataMember(Name="hud1EsPayToIndex", EmitDefaultValue=false)]
        public int? Hud1EsPayToIndex { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NextDueDate
        /// </summary>
        [DataMember(Name="nextDueDate", EmitDefaultValue=false)]
        public DateTime? NextDueDate { get; set; }

        /// <summary>
        /// Gets or Sets PaymentSchedule
        /// </summary>
        [DataMember(Name="paymentSchedule", EmitDefaultValue=false)]
        public string PaymentSchedule { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets PolicyNumber
        /// </summary>
        [DataMember(Name="policyNumber", EmitDefaultValue=false)]
        public string PolicyNumber { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets Premium
        /// </summary>
        [DataMember(Name="premium", EmitDefaultValue=false)]
        public double? Premium { get; set; }

        /// <summary>
        /// Gets or Sets RenewalDate
        /// </summary>
        [DataMember(Name="renewalDate", EmitDefaultValue=false)]
        public DateTime? RenewalDate { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets MaxDeductiblePercentage
        /// </summary>
        [DataMember(Name="maxDeductiblePercentage", EmitDefaultValue=false)]
        public double? MaxDeductiblePercentage { get; set; }

        /// <summary>
        /// Gets or Sets MaxDeductibleAmount
        /// </summary>
        [DataMember(Name="maxDeductibleAmount", EmitDefaultValue=false)]
        public double? MaxDeductibleAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractHud1EsHud1EsPayTos {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AmountLastPay: ").Append(AmountLastPay).Append("\n");
            sb.Append("  AmountNextDue: ").Append(AmountNextDue).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  CoverageAmount: ").Append(CoverageAmount).Append("\n");
            sb.Append("  DatePaid: ").Append(DatePaid).Append("\n");
            sb.Append("  DelinquentDate: ").Append(DelinquentDate).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  FeeType: ").Append(FeeType).Append("\n");
            sb.Append("  Hud1EsPayToIndex: ").Append(Hud1EsPayToIndex).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NextDueDate: ").Append(NextDueDate).Append("\n");
            sb.Append("  PaymentSchedule: ").Append(PaymentSchedule).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PolicyNumber: ").Append(PolicyNumber).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Premium: ").Append(Premium).Append("\n");
            sb.Append("  RenewalDate: ").Append(RenewalDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  MaxDeductiblePercentage: ").Append(MaxDeductiblePercentage).Append("\n");
            sb.Append("  MaxDeductibleAmount: ").Append(MaxDeductibleAmount).Append("\n");
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
            return this.Equals(input as LoanContractHud1EsHud1EsPayTos);
        }

        /// <summary>
        /// Returns true if LoanContractHud1EsHud1EsPayTos instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractHud1EsHud1EsPayTos to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractHud1EsHud1EsPayTos input)
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
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.AmountLastPay == input.AmountLastPay ||
                    (this.AmountLastPay != null &&
                    this.AmountLastPay.Equals(input.AmountLastPay))
                ) && 
                (
                    this.AmountNextDue == input.AmountNextDue ||
                    (this.AmountNextDue != null &&
                    this.AmountNextDue.Equals(input.AmountNextDue))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.ContactName == input.ContactName ||
                    (this.ContactName != null &&
                    this.ContactName.Equals(input.ContactName))
                ) && 
                (
                    this.CoverageAmount == input.CoverageAmount ||
                    (this.CoverageAmount != null &&
                    this.CoverageAmount.Equals(input.CoverageAmount))
                ) && 
                (
                    this.DatePaid == input.DatePaid ||
                    (this.DatePaid != null &&
                    this.DatePaid.Equals(input.DatePaid))
                ) && 
                (
                    this.DelinquentDate == input.DelinquentDate ||
                    (this.DelinquentDate != null &&
                    this.DelinquentDate.Equals(input.DelinquentDate))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) && 
                (
                    this.FeeType == input.FeeType ||
                    (this.FeeType != null &&
                    this.FeeType.Equals(input.FeeType))
                ) && 
                (
                    this.Hud1EsPayToIndex == input.Hud1EsPayToIndex ||
                    (this.Hud1EsPayToIndex != null &&
                    this.Hud1EsPayToIndex.Equals(input.Hud1EsPayToIndex))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NextDueDate == input.NextDueDate ||
                    (this.NextDueDate != null &&
                    this.NextDueDate.Equals(input.NextDueDate))
                ) && 
                (
                    this.PaymentSchedule == input.PaymentSchedule ||
                    (this.PaymentSchedule != null &&
                    this.PaymentSchedule.Equals(input.PaymentSchedule))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.PolicyNumber == input.PolicyNumber ||
                    (this.PolicyNumber != null &&
                    this.PolicyNumber.Equals(input.PolicyNumber))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Premium == input.Premium ||
                    (this.Premium != null &&
                    this.Premium.Equals(input.Premium))
                ) && 
                (
                    this.RenewalDate == input.RenewalDate ||
                    (this.RenewalDate != null &&
                    this.RenewalDate.Equals(input.RenewalDate))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.MaxDeductiblePercentage == input.MaxDeductiblePercentage ||
                    (this.MaxDeductiblePercentage != null &&
                    this.MaxDeductiblePercentage.Equals(input.MaxDeductiblePercentage))
                ) && 
                (
                    this.MaxDeductibleAmount == input.MaxDeductibleAmount ||
                    (this.MaxDeductibleAmount != null &&
                    this.MaxDeductibleAmount.Equals(input.MaxDeductibleAmount))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.AmountLastPay != null)
                    hashCode = hashCode * 59 + this.AmountLastPay.GetHashCode();
                if (this.AmountNextDue != null)
                    hashCode = hashCode * 59 + this.AmountNextDue.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.ContactName != null)
                    hashCode = hashCode * 59 + this.ContactName.GetHashCode();
                if (this.CoverageAmount != null)
                    hashCode = hashCode * 59 + this.CoverageAmount.GetHashCode();
                if (this.DatePaid != null)
                    hashCode = hashCode * 59 + this.DatePaid.GetHashCode();
                if (this.DelinquentDate != null)
                    hashCode = hashCode * 59 + this.DelinquentDate.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Fax != null)
                    hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.FeeType != null)
                    hashCode = hashCode * 59 + this.FeeType.GetHashCode();
                if (this.Hud1EsPayToIndex != null)
                    hashCode = hashCode * 59 + this.Hud1EsPayToIndex.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NextDueDate != null)
                    hashCode = hashCode * 59 + this.NextDueDate.GetHashCode();
                if (this.PaymentSchedule != null)
                    hashCode = hashCode * 59 + this.PaymentSchedule.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.PolicyNumber != null)
                    hashCode = hashCode * 59 + this.PolicyNumber.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.Premium != null)
                    hashCode = hashCode * 59 + this.Premium.GetHashCode();
                if (this.RenewalDate != null)
                    hashCode = hashCode * 59 + this.RenewalDate.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.MaxDeductiblePercentage != null)
                    hashCode = hashCode * 59 + this.MaxDeductiblePercentage.GetHashCode();
                if (this.MaxDeductibleAmount != null)
                    hashCode = hashCode * 59 + this.MaxDeductibleAmount.GetHashCode();
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
