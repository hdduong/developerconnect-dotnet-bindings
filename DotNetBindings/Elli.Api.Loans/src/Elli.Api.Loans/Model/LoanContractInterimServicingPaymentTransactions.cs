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
    /// LoanContractInterimServicingPaymentTransactions
    /// </summary>
    [DataContract]
    public partial class LoanContractInterimServicingPaymentTransactions :  IEquatable<LoanContractInterimServicingPaymentTransactions>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AccountHolder
        /// </summary>
        [DataMember(Name="accountHolder", EmitDefaultValue=false)]
        public string AccountHolder { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="accountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalEscrow
        /// </summary>
        [DataMember(Name="additionalEscrow", EmitDefaultValue=false)]
        public double? AdditionalEscrow { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalPrincipal
        /// </summary>
        [DataMember(Name="additionalPrincipal", EmitDefaultValue=false)]
        public double? AdditionalPrincipal { get; set; }

        /// <summary>
        /// Gets or Sets BuydownSubsidyAmount
        /// </summary>
        [DataMember(Name="buydownSubsidyAmount", EmitDefaultValue=false)]
        public double? BuydownSubsidyAmount { get; set; }

        /// <summary>
        /// Gets or Sets CheckNumber
        /// </summary>
        [DataMember(Name="checkNumber", EmitDefaultValue=false)]
        public string CheckNumber { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets CommonAmount
        /// </summary>
        [DataMember(Name="commonAmount", EmitDefaultValue=false)]
        public double? CommonAmount { get; set; }

        /// <summary>
        /// Gets or Sets CommonDate
        /// </summary>
        [DataMember(Name="commonDate", EmitDefaultValue=false)]
        public DateTime? CommonDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedById
        /// </summary>
        [DataMember(Name="createdById", EmitDefaultValue=false)]
        public string CreatedById { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByName
        /// </summary>
        [DataMember(Name="createdByName", EmitDefaultValue=false)]
        public string CreatedByName { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTimeUtc
        /// </summary>
        [DataMember(Name="createdDateTimeUtc", EmitDefaultValue=false)]
        public DateTime? CreatedDateTimeUtc { get; set; }

        /// <summary>
        /// Gets or Sets Escrow
        /// </summary>
        [DataMember(Name="escrow", EmitDefaultValue=false)]
        public double? Escrow { get; set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or Sets IndexRate
        /// </summary>
        [DataMember(Name="indexRate", EmitDefaultValue=false)]
        public double? IndexRate { get; set; }

        /// <summary>
        /// Gets or Sets InstitutionName
        /// </summary>
        [DataMember(Name="institutionName", EmitDefaultValue=false)]
        public string InstitutionName { get; set; }

        /// <summary>
        /// Gets or Sets InstitutionRouting
        /// </summary>
        [DataMember(Name="institutionRouting", EmitDefaultValue=false)]
        public string InstitutionRouting { get; set; }

        /// <summary>
        /// Gets or Sets Interest
        /// </summary>
        [DataMember(Name="interest", EmitDefaultValue=false)]
        public double? Interest { get; set; }

        /// <summary>
        /// Gets or Sets InterestRate
        /// </summary>
        [DataMember(Name="interestRate", EmitDefaultValue=false)]
        public double? InterestRate { get; set; }

        /// <summary>
        /// Gets or Sets LateFee
        /// </summary>
        [DataMember(Name="lateFee", EmitDefaultValue=false)]
        public double? LateFee { get; set; }

        /// <summary>
        /// Gets or Sets LateFeeIfLate
        /// </summary>
        [DataMember(Name="lateFeeIfLate", EmitDefaultValue=false)]
        public double? LateFeeIfLate { get; set; }

        /// <summary>
        /// Gets or Sets LatePaymentDate
        /// </summary>
        [DataMember(Name="latePaymentDate", EmitDefaultValue=false)]
        public DateTime? LatePaymentDate { get; set; }

        /// <summary>
        /// Gets or Sets MiscFee
        /// </summary>
        [DataMember(Name="miscFee", EmitDefaultValue=false)]
        public double? MiscFee { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedById
        /// </summary>
        [DataMember(Name="modifiedById", EmitDefaultValue=false)]
        public string ModifiedById { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedByName
        /// </summary>
        [DataMember(Name="modifiedByName", EmitDefaultValue=false)]
        public string ModifiedByName { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDateTimeUtc
        /// </summary>
        [DataMember(Name="modifiedDateTimeUtc", EmitDefaultValue=false)]
        public DateTime? ModifiedDateTimeUtc { get; set; }

        /// <summary>
        /// Gets or Sets PaymentDepositedDate
        /// </summary>
        [DataMember(Name="paymentDepositedDate", EmitDefaultValue=false)]
        public DateTime? PaymentDepositedDate { get; set; }

        /// <summary>
        /// Gets or Sets PaymentDueDate
        /// </summary>
        [DataMember(Name="paymentDueDate", EmitDefaultValue=false)]
        public DateTime? PaymentDueDate { get; set; }

        /// <summary>
        /// Gets or Sets PaymentIndexDate
        /// </summary>
        [DataMember(Name="paymentIndexDate", EmitDefaultValue=false)]
        public DateTime? PaymentIndexDate { get; set; }

        /// <summary>
        /// Gets or Sets PaymentNumber
        /// </summary>
        [DataMember(Name="paymentNumber", EmitDefaultValue=false)]
        public int? PaymentNumber { get; set; }

        /// <summary>
        /// Gets or Sets PaymentReceivedDate
        /// </summary>
        [DataMember(Name="paymentReceivedDate", EmitDefaultValue=false)]
        public DateTime? PaymentReceivedDate { get; set; }

        /// <summary>
        /// Gets or Sets Principal
        /// </summary>
        [DataMember(Name="principal", EmitDefaultValue=false)]
        public double? Principal { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets ServicingPaymentMethod
        /// </summary>
        [DataMember(Name="servicingPaymentMethod", EmitDefaultValue=false)]
        public string ServicingPaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets ServicingTransactionType
        /// </summary>
        [DataMember(Name="servicingTransactionType", EmitDefaultValue=false)]
        public string ServicingTransactionType { get; set; }

        /// <summary>
        /// Gets or Sets StatementDate
        /// </summary>
        [DataMember(Name="statementDate", EmitDefaultValue=false)]
        public DateTime? StatementDate { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountDue
        /// </summary>
        [DataMember(Name="totalAmountDue", EmitDefaultValue=false)]
        public double? TotalAmountDue { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountReceived
        /// </summary>
        [DataMember(Name="totalAmountReceived", EmitDefaultValue=false)]
        public double? TotalAmountReceived { get; set; }

        /// <summary>
        /// Gets or Sets TransactionAmount
        /// </summary>
        [DataMember(Name="transactionAmount", EmitDefaultValue=false)]
        public double? TransactionAmount { get; set; }

        /// <summary>
        /// Gets or Sets TransactionDate
        /// </summary>
        [DataMember(Name="transactionDate", EmitDefaultValue=false)]
        public DateTime? TransactionDate { get; set; }

        /// <summary>
        /// Gets or Sets EscrowUSDAMonthlyPremium
        /// </summary>
        [DataMember(Name="escrowUSDAMonthlyPremium", EmitDefaultValue=false)]
        public double? EscrowUSDAMonthlyPremium { get; set; }

        /// <summary>
        /// Gets or Sets SchedulePayLogMiscFee
        /// </summary>
        [DataMember(Name="schedulePayLogMiscFee", EmitDefaultValue=false)]
        public double? SchedulePayLogMiscFee { get; set; }

        /// <summary>
        /// Gets or Sets EscrowTax
        /// </summary>
        [DataMember(Name="escrowTax", EmitDefaultValue=false)]
        public double? EscrowTax { get; set; }

        /// <summary>
        /// Gets or Sets EscrowMortgageInsurance
        /// </summary>
        [DataMember(Name="escrowMortgageInsurance", EmitDefaultValue=false)]
        public double? EscrowMortgageInsurance { get; set; }

        /// <summary>
        /// Gets or Sets EscrowHazardInsurance
        /// </summary>
        [DataMember(Name="escrowHazardInsurance", EmitDefaultValue=false)]
        public double? EscrowHazardInsurance { get; set; }

        /// <summary>
        /// Gets or Sets EscrowFloodInsurance
        /// </summary>
        [DataMember(Name="escrowFloodInsurance", EmitDefaultValue=false)]
        public double? EscrowFloodInsurance { get; set; }

        /// <summary>
        /// Gets or Sets EscrowCityPropertyTax
        /// </summary>
        [DataMember(Name="escrowCityPropertyTax", EmitDefaultValue=false)]
        public double? EscrowCityPropertyTax { get; set; }

        /// <summary>
        /// Gets or Sets EscrowOther1
        /// </summary>
        [DataMember(Name="escrowOther1", EmitDefaultValue=false)]
        public double? EscrowOther1 { get; set; }

        /// <summary>
        /// Gets or Sets EscrowOther2
        /// </summary>
        [DataMember(Name="escrowOther2", EmitDefaultValue=false)]
        public double? EscrowOther2 { get; set; }

        /// <summary>
        /// Gets or Sets EscrowOther3
        /// </summary>
        [DataMember(Name="escrowOther3", EmitDefaultValue=false)]
        public double? EscrowOther3 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractInterimServicingPaymentTransactions {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccountHolder: ").Append(AccountHolder).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  AdditionalEscrow: ").Append(AdditionalEscrow).Append("\n");
            sb.Append("  AdditionalPrincipal: ").Append(AdditionalPrincipal).Append("\n");
            sb.Append("  BuydownSubsidyAmount: ").Append(BuydownSubsidyAmount).Append("\n");
            sb.Append("  CheckNumber: ").Append(CheckNumber).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  CommonAmount: ").Append(CommonAmount).Append("\n");
            sb.Append("  CommonDate: ").Append(CommonDate).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedByName: ").Append(CreatedByName).Append("\n");
            sb.Append("  CreatedDateTimeUtc: ").Append(CreatedDateTimeUtc).Append("\n");
            sb.Append("  Escrow: ").Append(Escrow).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  IndexRate: ").Append(IndexRate).Append("\n");
            sb.Append("  InstitutionName: ").Append(InstitutionName).Append("\n");
            sb.Append("  InstitutionRouting: ").Append(InstitutionRouting).Append("\n");
            sb.Append("  Interest: ").Append(Interest).Append("\n");
            sb.Append("  InterestRate: ").Append(InterestRate).Append("\n");
            sb.Append("  LateFee: ").Append(LateFee).Append("\n");
            sb.Append("  LateFeeIfLate: ").Append(LateFeeIfLate).Append("\n");
            sb.Append("  LatePaymentDate: ").Append(LatePaymentDate).Append("\n");
            sb.Append("  MiscFee: ").Append(MiscFee).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
            sb.Append("  ModifiedByName: ").Append(ModifiedByName).Append("\n");
            sb.Append("  ModifiedDateTimeUtc: ").Append(ModifiedDateTimeUtc).Append("\n");
            sb.Append("  PaymentDepositedDate: ").Append(PaymentDepositedDate).Append("\n");
            sb.Append("  PaymentDueDate: ").Append(PaymentDueDate).Append("\n");
            sb.Append("  PaymentIndexDate: ").Append(PaymentIndexDate).Append("\n");
            sb.Append("  PaymentNumber: ").Append(PaymentNumber).Append("\n");
            sb.Append("  PaymentReceivedDate: ").Append(PaymentReceivedDate).Append("\n");
            sb.Append("  Principal: ").Append(Principal).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  ServicingPaymentMethod: ").Append(ServicingPaymentMethod).Append("\n");
            sb.Append("  ServicingTransactionType: ").Append(ServicingTransactionType).Append("\n");
            sb.Append("  StatementDate: ").Append(StatementDate).Append("\n");
            sb.Append("  TotalAmountDue: ").Append(TotalAmountDue).Append("\n");
            sb.Append("  TotalAmountReceived: ").Append(TotalAmountReceived).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
            sb.Append("  EscrowUSDAMonthlyPremium: ").Append(EscrowUSDAMonthlyPremium).Append("\n");
            sb.Append("  SchedulePayLogMiscFee: ").Append(SchedulePayLogMiscFee).Append("\n");
            sb.Append("  EscrowTax: ").Append(EscrowTax).Append("\n");
            sb.Append("  EscrowMortgageInsurance: ").Append(EscrowMortgageInsurance).Append("\n");
            sb.Append("  EscrowHazardInsurance: ").Append(EscrowHazardInsurance).Append("\n");
            sb.Append("  EscrowFloodInsurance: ").Append(EscrowFloodInsurance).Append("\n");
            sb.Append("  EscrowCityPropertyTax: ").Append(EscrowCityPropertyTax).Append("\n");
            sb.Append("  EscrowOther1: ").Append(EscrowOther1).Append("\n");
            sb.Append("  EscrowOther2: ").Append(EscrowOther2).Append("\n");
            sb.Append("  EscrowOther3: ").Append(EscrowOther3).Append("\n");
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
            return this.Equals(input as LoanContractInterimServicingPaymentTransactions);
        }

        /// <summary>
        /// Returns true if LoanContractInterimServicingPaymentTransactions instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractInterimServicingPaymentTransactions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractInterimServicingPaymentTransactions input)
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
                    this.AccountHolder == input.AccountHolder ||
                    (this.AccountHolder != null &&
                    this.AccountHolder.Equals(input.AccountHolder))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.AdditionalEscrow == input.AdditionalEscrow ||
                    (this.AdditionalEscrow != null &&
                    this.AdditionalEscrow.Equals(input.AdditionalEscrow))
                ) && 
                (
                    this.AdditionalPrincipal == input.AdditionalPrincipal ||
                    (this.AdditionalPrincipal != null &&
                    this.AdditionalPrincipal.Equals(input.AdditionalPrincipal))
                ) && 
                (
                    this.BuydownSubsidyAmount == input.BuydownSubsidyAmount ||
                    (this.BuydownSubsidyAmount != null &&
                    this.BuydownSubsidyAmount.Equals(input.BuydownSubsidyAmount))
                ) && 
                (
                    this.CheckNumber == input.CheckNumber ||
                    (this.CheckNumber != null &&
                    this.CheckNumber.Equals(input.CheckNumber))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.CommonAmount == input.CommonAmount ||
                    (this.CommonAmount != null &&
                    this.CommonAmount.Equals(input.CommonAmount))
                ) && 
                (
                    this.CommonDate == input.CommonDate ||
                    (this.CommonDate != null &&
                    this.CommonDate.Equals(input.CommonDate))
                ) && 
                (
                    this.CreatedById == input.CreatedById ||
                    (this.CreatedById != null &&
                    this.CreatedById.Equals(input.CreatedById))
                ) && 
                (
                    this.CreatedByName == input.CreatedByName ||
                    (this.CreatedByName != null &&
                    this.CreatedByName.Equals(input.CreatedByName))
                ) && 
                (
                    this.CreatedDateTimeUtc == input.CreatedDateTimeUtc ||
                    (this.CreatedDateTimeUtc != null &&
                    this.CreatedDateTimeUtc.Equals(input.CreatedDateTimeUtc))
                ) && 
                (
                    this.Escrow == input.Escrow ||
                    (this.Escrow != null &&
                    this.Escrow.Equals(input.Escrow))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.IndexRate == input.IndexRate ||
                    (this.IndexRate != null &&
                    this.IndexRate.Equals(input.IndexRate))
                ) && 
                (
                    this.InstitutionName == input.InstitutionName ||
                    (this.InstitutionName != null &&
                    this.InstitutionName.Equals(input.InstitutionName))
                ) && 
                (
                    this.InstitutionRouting == input.InstitutionRouting ||
                    (this.InstitutionRouting != null &&
                    this.InstitutionRouting.Equals(input.InstitutionRouting))
                ) && 
                (
                    this.Interest == input.Interest ||
                    (this.Interest != null &&
                    this.Interest.Equals(input.Interest))
                ) && 
                (
                    this.InterestRate == input.InterestRate ||
                    (this.InterestRate != null &&
                    this.InterestRate.Equals(input.InterestRate))
                ) && 
                (
                    this.LateFee == input.LateFee ||
                    (this.LateFee != null &&
                    this.LateFee.Equals(input.LateFee))
                ) && 
                (
                    this.LateFeeIfLate == input.LateFeeIfLate ||
                    (this.LateFeeIfLate != null &&
                    this.LateFeeIfLate.Equals(input.LateFeeIfLate))
                ) && 
                (
                    this.LatePaymentDate == input.LatePaymentDate ||
                    (this.LatePaymentDate != null &&
                    this.LatePaymentDate.Equals(input.LatePaymentDate))
                ) && 
                (
                    this.MiscFee == input.MiscFee ||
                    (this.MiscFee != null &&
                    this.MiscFee.Equals(input.MiscFee))
                ) && 
                (
                    this.ModifiedById == input.ModifiedById ||
                    (this.ModifiedById != null &&
                    this.ModifiedById.Equals(input.ModifiedById))
                ) && 
                (
                    this.ModifiedByName == input.ModifiedByName ||
                    (this.ModifiedByName != null &&
                    this.ModifiedByName.Equals(input.ModifiedByName))
                ) && 
                (
                    this.ModifiedDateTimeUtc == input.ModifiedDateTimeUtc ||
                    (this.ModifiedDateTimeUtc != null &&
                    this.ModifiedDateTimeUtc.Equals(input.ModifiedDateTimeUtc))
                ) && 
                (
                    this.PaymentDepositedDate == input.PaymentDepositedDate ||
                    (this.PaymentDepositedDate != null &&
                    this.PaymentDepositedDate.Equals(input.PaymentDepositedDate))
                ) && 
                (
                    this.PaymentDueDate == input.PaymentDueDate ||
                    (this.PaymentDueDate != null &&
                    this.PaymentDueDate.Equals(input.PaymentDueDate))
                ) && 
                (
                    this.PaymentIndexDate == input.PaymentIndexDate ||
                    (this.PaymentIndexDate != null &&
                    this.PaymentIndexDate.Equals(input.PaymentIndexDate))
                ) && 
                (
                    this.PaymentNumber == input.PaymentNumber ||
                    (this.PaymentNumber != null &&
                    this.PaymentNumber.Equals(input.PaymentNumber))
                ) && 
                (
                    this.PaymentReceivedDate == input.PaymentReceivedDate ||
                    (this.PaymentReceivedDate != null &&
                    this.PaymentReceivedDate.Equals(input.PaymentReceivedDate))
                ) && 
                (
                    this.Principal == input.Principal ||
                    (this.Principal != null &&
                    this.Principal.Equals(input.Principal))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.ServicingPaymentMethod == input.ServicingPaymentMethod ||
                    (this.ServicingPaymentMethod != null &&
                    this.ServicingPaymentMethod.Equals(input.ServicingPaymentMethod))
                ) && 
                (
                    this.ServicingTransactionType == input.ServicingTransactionType ||
                    (this.ServicingTransactionType != null &&
                    this.ServicingTransactionType.Equals(input.ServicingTransactionType))
                ) && 
                (
                    this.StatementDate == input.StatementDate ||
                    (this.StatementDate != null &&
                    this.StatementDate.Equals(input.StatementDate))
                ) && 
                (
                    this.TotalAmountDue == input.TotalAmountDue ||
                    (this.TotalAmountDue != null &&
                    this.TotalAmountDue.Equals(input.TotalAmountDue))
                ) && 
                (
                    this.TotalAmountReceived == input.TotalAmountReceived ||
                    (this.TotalAmountReceived != null &&
                    this.TotalAmountReceived.Equals(input.TotalAmountReceived))
                ) && 
                (
                    this.TransactionAmount == input.TransactionAmount ||
                    (this.TransactionAmount != null &&
                    this.TransactionAmount.Equals(input.TransactionAmount))
                ) && 
                (
                    this.TransactionDate == input.TransactionDate ||
                    (this.TransactionDate != null &&
                    this.TransactionDate.Equals(input.TransactionDate))
                ) && 
                (
                    this.EscrowUSDAMonthlyPremium == input.EscrowUSDAMonthlyPremium ||
                    (this.EscrowUSDAMonthlyPremium != null &&
                    this.EscrowUSDAMonthlyPremium.Equals(input.EscrowUSDAMonthlyPremium))
                ) && 
                (
                    this.SchedulePayLogMiscFee == input.SchedulePayLogMiscFee ||
                    (this.SchedulePayLogMiscFee != null &&
                    this.SchedulePayLogMiscFee.Equals(input.SchedulePayLogMiscFee))
                ) && 
                (
                    this.EscrowTax == input.EscrowTax ||
                    (this.EscrowTax != null &&
                    this.EscrowTax.Equals(input.EscrowTax))
                ) && 
                (
                    this.EscrowMortgageInsurance == input.EscrowMortgageInsurance ||
                    (this.EscrowMortgageInsurance != null &&
                    this.EscrowMortgageInsurance.Equals(input.EscrowMortgageInsurance))
                ) && 
                (
                    this.EscrowHazardInsurance == input.EscrowHazardInsurance ||
                    (this.EscrowHazardInsurance != null &&
                    this.EscrowHazardInsurance.Equals(input.EscrowHazardInsurance))
                ) && 
                (
                    this.EscrowFloodInsurance == input.EscrowFloodInsurance ||
                    (this.EscrowFloodInsurance != null &&
                    this.EscrowFloodInsurance.Equals(input.EscrowFloodInsurance))
                ) && 
                (
                    this.EscrowCityPropertyTax == input.EscrowCityPropertyTax ||
                    (this.EscrowCityPropertyTax != null &&
                    this.EscrowCityPropertyTax.Equals(input.EscrowCityPropertyTax))
                ) && 
                (
                    this.EscrowOther1 == input.EscrowOther1 ||
                    (this.EscrowOther1 != null &&
                    this.EscrowOther1.Equals(input.EscrowOther1))
                ) && 
                (
                    this.EscrowOther2 == input.EscrowOther2 ||
                    (this.EscrowOther2 != null &&
                    this.EscrowOther2.Equals(input.EscrowOther2))
                ) && 
                (
                    this.EscrowOther3 == input.EscrowOther3 ||
                    (this.EscrowOther3 != null &&
                    this.EscrowOther3.Equals(input.EscrowOther3))
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
                if (this.AccountHolder != null)
                    hashCode = hashCode * 59 + this.AccountHolder.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.AdditionalEscrow != null)
                    hashCode = hashCode * 59 + this.AdditionalEscrow.GetHashCode();
                if (this.AdditionalPrincipal != null)
                    hashCode = hashCode * 59 + this.AdditionalPrincipal.GetHashCode();
                if (this.BuydownSubsidyAmount != null)
                    hashCode = hashCode * 59 + this.BuydownSubsidyAmount.GetHashCode();
                if (this.CheckNumber != null)
                    hashCode = hashCode * 59 + this.CheckNumber.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.CommonAmount != null)
                    hashCode = hashCode * 59 + this.CommonAmount.GetHashCode();
                if (this.CommonDate != null)
                    hashCode = hashCode * 59 + this.CommonDate.GetHashCode();
                if (this.CreatedById != null)
                    hashCode = hashCode * 59 + this.CreatedById.GetHashCode();
                if (this.CreatedByName != null)
                    hashCode = hashCode * 59 + this.CreatedByName.GetHashCode();
                if (this.CreatedDateTimeUtc != null)
                    hashCode = hashCode * 59 + this.CreatedDateTimeUtc.GetHashCode();
                if (this.Escrow != null)
                    hashCode = hashCode * 59 + this.Escrow.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.IndexRate != null)
                    hashCode = hashCode * 59 + this.IndexRate.GetHashCode();
                if (this.InstitutionName != null)
                    hashCode = hashCode * 59 + this.InstitutionName.GetHashCode();
                if (this.InstitutionRouting != null)
                    hashCode = hashCode * 59 + this.InstitutionRouting.GetHashCode();
                if (this.Interest != null)
                    hashCode = hashCode * 59 + this.Interest.GetHashCode();
                if (this.InterestRate != null)
                    hashCode = hashCode * 59 + this.InterestRate.GetHashCode();
                if (this.LateFee != null)
                    hashCode = hashCode * 59 + this.LateFee.GetHashCode();
                if (this.LateFeeIfLate != null)
                    hashCode = hashCode * 59 + this.LateFeeIfLate.GetHashCode();
                if (this.LatePaymentDate != null)
                    hashCode = hashCode * 59 + this.LatePaymentDate.GetHashCode();
                if (this.MiscFee != null)
                    hashCode = hashCode * 59 + this.MiscFee.GetHashCode();
                if (this.ModifiedById != null)
                    hashCode = hashCode * 59 + this.ModifiedById.GetHashCode();
                if (this.ModifiedByName != null)
                    hashCode = hashCode * 59 + this.ModifiedByName.GetHashCode();
                if (this.ModifiedDateTimeUtc != null)
                    hashCode = hashCode * 59 + this.ModifiedDateTimeUtc.GetHashCode();
                if (this.PaymentDepositedDate != null)
                    hashCode = hashCode * 59 + this.PaymentDepositedDate.GetHashCode();
                if (this.PaymentDueDate != null)
                    hashCode = hashCode * 59 + this.PaymentDueDate.GetHashCode();
                if (this.PaymentIndexDate != null)
                    hashCode = hashCode * 59 + this.PaymentIndexDate.GetHashCode();
                if (this.PaymentNumber != null)
                    hashCode = hashCode * 59 + this.PaymentNumber.GetHashCode();
                if (this.PaymentReceivedDate != null)
                    hashCode = hashCode * 59 + this.PaymentReceivedDate.GetHashCode();
                if (this.Principal != null)
                    hashCode = hashCode * 59 + this.Principal.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.ServicingPaymentMethod != null)
                    hashCode = hashCode * 59 + this.ServicingPaymentMethod.GetHashCode();
                if (this.ServicingTransactionType != null)
                    hashCode = hashCode * 59 + this.ServicingTransactionType.GetHashCode();
                if (this.StatementDate != null)
                    hashCode = hashCode * 59 + this.StatementDate.GetHashCode();
                if (this.TotalAmountDue != null)
                    hashCode = hashCode * 59 + this.TotalAmountDue.GetHashCode();
                if (this.TotalAmountReceived != null)
                    hashCode = hashCode * 59 + this.TotalAmountReceived.GetHashCode();
                if (this.TransactionAmount != null)
                    hashCode = hashCode * 59 + this.TransactionAmount.GetHashCode();
                if (this.TransactionDate != null)
                    hashCode = hashCode * 59 + this.TransactionDate.GetHashCode();
                if (this.EscrowUSDAMonthlyPremium != null)
                    hashCode = hashCode * 59 + this.EscrowUSDAMonthlyPremium.GetHashCode();
                if (this.SchedulePayLogMiscFee != null)
                    hashCode = hashCode * 59 + this.SchedulePayLogMiscFee.GetHashCode();
                if (this.EscrowTax != null)
                    hashCode = hashCode * 59 + this.EscrowTax.GetHashCode();
                if (this.EscrowMortgageInsurance != null)
                    hashCode = hashCode * 59 + this.EscrowMortgageInsurance.GetHashCode();
                if (this.EscrowHazardInsurance != null)
                    hashCode = hashCode * 59 + this.EscrowHazardInsurance.GetHashCode();
                if (this.EscrowFloodInsurance != null)
                    hashCode = hashCode * 59 + this.EscrowFloodInsurance.GetHashCode();
                if (this.EscrowCityPropertyTax != null)
                    hashCode = hashCode * 59 + this.EscrowCityPropertyTax.GetHashCode();
                if (this.EscrowOther1 != null)
                    hashCode = hashCode * 59 + this.EscrowOther1.GetHashCode();
                if (this.EscrowOther2 != null)
                    hashCode = hashCode * 59 + this.EscrowOther2.GetHashCode();
                if (this.EscrowOther3 != null)
                    hashCode = hashCode * 59 + this.EscrowOther3.GetHashCode();
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
