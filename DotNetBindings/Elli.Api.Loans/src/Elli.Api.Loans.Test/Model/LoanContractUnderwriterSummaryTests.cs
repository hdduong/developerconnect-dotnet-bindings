/* 
 * Loan
 *
 * Returns the entire loan or specific entities of a loan.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Model;
using Elli.Api.Loans.Client;
using System.Reflection;

namespace Elli.Api.Loans.Test
{
    /// <summary>
    ///  Class for testing LoanContractUnderwriterSummary
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LoanContractUnderwriterSummaryTests
    {
        // TODO uncomment below to declare an instance variable for LoanContractUnderwriterSummary
        //private LoanContractUnderwriterSummary instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LoanContractUnderwriterSummary
            //instance = new LoanContractUnderwriterSummary();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoanContractUnderwriterSummary
        /// </summary>
        [Test]
        public void LoanContractUnderwriterSummaryInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LoanContractUnderwriterSummary
            //Assert.IsInstanceOfType<LoanContractUnderwriterSummary> (instance, "variable 'instance' is a LoanContractUnderwriterSummary");
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Appraisal'
        /// </summary>
        [Test]
        public void AppraisalTest()
        {
            // TODO unit test for the property 'Appraisal'
        }
        /// <summary>
        /// Test the property 'AppraisalCompletedDate'
        /// </summary>
        [Test]
        public void AppraisalCompletedDateTest()
        {
            // TODO unit test for the property 'AppraisalCompletedDate'
        }
        /// <summary>
        /// Test the property 'AppraisalExpiredDate'
        /// </summary>
        [Test]
        public void AppraisalExpiredDateTest()
        {
            // TODO unit test for the property 'AppraisalExpiredDate'
        }
        /// <summary>
        /// Test the property 'AppraisalOrderedDate'
        /// </summary>
        [Test]
        public void AppraisalOrderedDateTest()
        {
            // TODO unit test for the property 'AppraisalOrderedDate'
        }
        /// <summary>
        /// Test the property 'AppraisalType'
        /// </summary>
        [Test]
        public void AppraisalTypeTest()
        {
            // TODO unit test for the property 'AppraisalType'
        }
        /// <summary>
        /// Test the property 'ApprovalExpiredDate'
        /// </summary>
        [Test]
        public void ApprovalExpiredDateTest()
        {
            // TODO unit test for the property 'ApprovalExpiredDate'
        }
        /// <summary>
        /// Test the property 'ApprovedBy'
        /// </summary>
        [Test]
        public void ApprovedByTest()
        {
            // TODO unit test for the property 'ApprovedBy'
        }
        /// <summary>
        /// Test the property 'ApprovedDate'
        /// </summary>
        [Test]
        public void ApprovedDateTest()
        {
            // TODO unit test for the property 'ApprovedDate'
        }
        /// <summary>
        /// Test the property 'AusNumber'
        /// </summary>
        [Test]
        public void AusNumberTest()
        {
            // TODO unit test for the property 'AusNumber'
        }
        /// <summary>
        /// Test the property 'AusRunDate'
        /// </summary>
        [Test]
        public void AusRunDateTest()
        {
            // TODO unit test for the property 'AusRunDate'
        }
        /// <summary>
        /// Test the property 'AusSource'
        /// </summary>
        [Test]
        public void AusSourceTest()
        {
            // TODO unit test for the property 'AusSource'
        }
        /// <summary>
        /// Test the property 'BenefitRequiredIndicator'
        /// </summary>
        [Test]
        public void BenefitRequiredIndicatorTest()
        {
            // TODO unit test for the property 'BenefitRequiredIndicator'
        }
        /// <summary>
        /// Test the property 'ClearToCloseDate'
        /// </summary>
        [Test]
        public void ClearToCloseDateTest()
        {
            // TODO unit test for the property 'ClearToCloseDate'
        }
        /// <summary>
        /// Test the property 'Concerns'
        /// </summary>
        [Test]
        public void ConcernsTest()
        {
            // TODO unit test for the property 'Concerns'
        }
        /// <summary>
        /// Test the property 'Conditions'
        /// </summary>
        [Test]
        public void ConditionsTest()
        {
            // TODO unit test for the property 'Conditions'
        }
        /// <summary>
        /// Test the property 'Credit'
        /// </summary>
        [Test]
        public void CreditTest()
        {
            // TODO unit test for the property 'Credit'
        }
        /// <summary>
        /// Test the property 'CreditApprovalDate'
        /// </summary>
        [Test]
        public void CreditApprovalDateTest()
        {
            // TODO unit test for the property 'CreditApprovalDate'
        }
        /// <summary>
        /// Test the property 'DeniedBy'
        /// </summary>
        [Test]
        public void DeniedByTest()
        {
            // TODO unit test for the property 'DeniedBy'
        }
        /// <summary>
        /// Test the property 'DeniedDate'
        /// </summary>
        [Test]
        public void DeniedDateTest()
        {
            // TODO unit test for the property 'DeniedDate'
        }
        /// <summary>
        /// Test the property 'DifferentApprovalExpiredDate'
        /// </summary>
        [Test]
        public void DifferentApprovalExpiredDateTest()
        {
            // TODO unit test for the property 'DifferentApprovalExpiredDate'
        }
        /// <summary>
        /// Test the property 'DifferentApprovedBy'
        /// </summary>
        [Test]
        public void DifferentApprovedByTest()
        {
            // TODO unit test for the property 'DifferentApprovedBy'
        }
        /// <summary>
        /// Test the property 'DifferentApprovedDate'
        /// </summary>
        [Test]
        public void DifferentApprovedDateTest()
        {
            // TODO unit test for the property 'DifferentApprovedDate'
        }
        /// <summary>
        /// Test the property 'Exceptions'
        /// </summary>
        [Test]
        public void ExceptionsTest()
        {
            // TODO unit test for the property 'Exceptions'
        }
        /// <summary>
        /// Test the property 'ExceptionSignOffBy'
        /// </summary>
        [Test]
        public void ExceptionSignOffByTest()
        {
            // TODO unit test for the property 'ExceptionSignOffBy'
        }
        /// <summary>
        /// Test the property 'ExceptionSignOffDate'
        /// </summary>
        [Test]
        public void ExceptionSignOffDateTest()
        {
            // TODO unit test for the property 'ExceptionSignOffDate'
        }
        /// <summary>
        /// Test the property 'MaxRate'
        /// </summary>
        [Test]
        public void MaxRateTest()
        {
            // TODO unit test for the property 'MaxRate'
        }
        /// <summary>
        /// Test the property 'MiOrderedDate'
        /// </summary>
        [Test]
        public void MiOrderedDateTest()
        {
            // TODO unit test for the property 'MiOrderedDate'
        }
        /// <summary>
        /// Test the property 'MiReceivedDate'
        /// </summary>
        [Test]
        public void MiReceivedDateTest()
        {
            // TODO unit test for the property 'MiReceivedDate'
        }
        /// <summary>
        /// Test the property 'ModifiedLoanAmount'
        /// </summary>
        [Test]
        public void ModifiedLoanAmountTest()
        {
            // TODO unit test for the property 'ModifiedLoanAmount'
        }
        /// <summary>
        /// Test the property 'ModifiedLoanRate'
        /// </summary>
        [Test]
        public void ModifiedLoanRateTest()
        {
            // TODO unit test for the property 'ModifiedLoanRate'
        }
        /// <summary>
        /// Test the property 'ModifiedLoanTerm'
        /// </summary>
        [Test]
        public void ModifiedLoanTermTest()
        {
            // TODO unit test for the property 'ModifiedLoanTerm'
        }
        /// <summary>
        /// Test the property 'ModifiedLtv'
        /// </summary>
        [Test]
        public void ModifiedLtvTest()
        {
            // TODO unit test for the property 'ModifiedLtv'
        }
        /// <summary>
        /// Test the property 'ModifiedMonthlyPayment'
        /// </summary>
        [Test]
        public void ModifiedMonthlyPaymentTest()
        {
            // TODO unit test for the property 'ModifiedMonthlyPayment'
        }
        /// <summary>
        /// Test the property 'OriginalAppraiser'
        /// </summary>
        [Test]
        public void OriginalAppraiserTest()
        {
            // TODO unit test for the property 'OriginalAppraiser'
        }
        /// <summary>
        /// Test the property 'OriginalAppraisersValue'
        /// </summary>
        [Test]
        public void OriginalAppraisersValueTest()
        {
            // TODO unit test for the property 'OriginalAppraisersValue'
        }
        /// <summary>
        /// Test the property 'ResubmittedDate'
        /// </summary>
        [Test]
        public void ResubmittedDateTest()
        {
            // TODO unit test for the property 'ResubmittedDate'
        }
        /// <summary>
        /// Test the property 'ReviewAppraiser'
        /// </summary>
        [Test]
        public void ReviewAppraiserTest()
        {
            // TODO unit test for the property 'ReviewAppraiser'
        }
        /// <summary>
        /// Test the property 'ReviewCompletedDate'
        /// </summary>
        [Test]
        public void ReviewCompletedDateTest()
        {
            // TODO unit test for the property 'ReviewCompletedDate'
        }
        /// <summary>
        /// Test the property 'ReviewRequestedDate'
        /// </summary>
        [Test]
        public void ReviewRequestedDateTest()
        {
            // TODO unit test for the property 'ReviewRequestedDate'
        }
        /// <summary>
        /// Test the property 'ReviewType'
        /// </summary>
        [Test]
        public void ReviewTypeTest()
        {
            // TODO unit test for the property 'ReviewType'
        }
        /// <summary>
        /// Test the property 'ReviewValue'
        /// </summary>
        [Test]
        public void ReviewValueTest()
        {
            // TODO unit test for the property 'ReviewValue'
        }
        /// <summary>
        /// Test the property 'SentToDate'
        /// </summary>
        [Test]
        public void SentToDateTest()
        {
            // TODO unit test for the property 'SentToDate'
        }
        /// <summary>
        /// Test the property 'SignOffBy'
        /// </summary>
        [Test]
        public void SignOffByTest()
        {
            // TODO unit test for the property 'SignOffBy'
        }
        /// <summary>
        /// Test the property 'SignOffDate'
        /// </summary>
        [Test]
        public void SignOffDateTest()
        {
            // TODO unit test for the property 'SignOffDate'
        }
        /// <summary>
        /// Test the property 'Strengths'
        /// </summary>
        [Test]
        public void StrengthsTest()
        {
            // TODO unit test for the property 'Strengths'
        }
        /// <summary>
        /// Test the property 'SubmittedDate'
        /// </summary>
        [Test]
        public void SubmittedDateTest()
        {
            // TODO unit test for the property 'SubmittedDate'
        }
        /// <summary>
        /// Test the property 'SupervisoryAppraiserLicenseNumber'
        /// </summary>
        [Test]
        public void SupervisoryAppraiserLicenseNumberTest()
        {
            // TODO unit test for the property 'SupervisoryAppraiserLicenseNumber'
        }
        /// <summary>
        /// Test the property 'SuspendedBy'
        /// </summary>
        [Test]
        public void SuspendedByTest()
        {
            // TODO unit test for the property 'SuspendedBy'
        }
        /// <summary>
        /// Test the property 'SuspendedDate'
        /// </summary>
        [Test]
        public void SuspendedDateTest()
        {
            // TODO unit test for the property 'SuspendedDate'
        }
        /// <summary>
        /// Test the property 'SuspendedReasons'
        /// </summary>
        [Test]
        public void SuspendedReasonsTest()
        {
            // TODO unit test for the property 'SuspendedReasons'
        }
        /// <summary>
        /// Test the property 'IsAgencyWithAgreement'
        /// </summary>
        [Test]
        public void IsAgencyWithAgreementTest()
        {
            // TODO unit test for the property 'IsAgencyWithAgreement'
        }
        /// <summary>
        /// Test the property 'IsAgencyWaiver'
        /// </summary>
        [Test]
        public void IsAgencyWaiverTest()
        {
            // TODO unit test for the property 'IsAgencyWaiver'
        }
        /// <summary>
        /// Test the property 'IsAgencyManually'
        /// </summary>
        [Test]
        public void IsAgencyManuallyTest()
        {
            // TODO unit test for the property 'IsAgencyManually'
        }

    }

}
