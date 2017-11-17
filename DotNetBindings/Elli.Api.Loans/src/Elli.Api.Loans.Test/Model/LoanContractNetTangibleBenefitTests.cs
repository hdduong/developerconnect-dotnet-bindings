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
    ///  Class for testing LoanContractNetTangibleBenefit
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LoanContractNetTangibleBenefitTests
    {
        // TODO uncomment below to declare an instance variable for LoanContractNetTangibleBenefit
        //private LoanContractNetTangibleBenefit instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LoanContractNetTangibleBenefit
            //instance = new LoanContractNetTangibleBenefit();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoanContractNetTangibleBenefit
        /// </summary>
        [Test]
        public void LoanContractNetTangibleBenefitInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LoanContractNetTangibleBenefit
            //Assert.IsInstanceOfType<LoanContractNetTangibleBenefit> (instance, "variable 'instance' is a LoanContractNetTangibleBenefit");
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
        /// Test the property 'AprNotExceedIndicator'
        /// </summary>
        [Test]
        public void AprNotExceedIndicatorTest()
        {
            // TODO unit test for the property 'AprNotExceedIndicator'
        }
        /// <summary>
        /// Test the property 'AvoidingForeclosureIndicator'
        /// </summary>
        [Test]
        public void AvoidingForeclosureIndicatorTest()
        {
            // TODO unit test for the property 'AvoidingForeclosureIndicator'
        }
        /// <summary>
        /// Test the property 'BeneficialChangedForBorrowerIndicator'
        /// </summary>
        [Test]
        public void BeneficialChangedForBorrowerIndicatorTest()
        {
            // TODO unit test for the property 'BeneficialChangedForBorrowerIndicator'
        }
        /// <summary>
        /// Test the property 'BonaFideFinancialEmergency'
        /// </summary>
        [Test]
        public void BonaFideFinancialEmergencyTest()
        {
            // TODO unit test for the property 'BonaFideFinancialEmergency'
        }
        /// <summary>
        /// Test the property 'BorrowerCanRecoupCostofRefinancingIndicator'
        /// </summary>
        [Test]
        public void BorrowerCanRecoupCostofRefinancingIndicatorTest()
        {
            // TODO unit test for the property 'BorrowerCanRecoupCostofRefinancingIndicator'
        }
        /// <summary>
        /// Test the property 'BorrowerCanRecoupIndicator'
        /// </summary>
        [Test]
        public void BorrowerCanRecoupIndicatorTest()
        {
            // TODO unit test for the property 'BorrowerCanRecoupIndicator'
        }
        /// <summary>
        /// Test the property 'BorrowerMonthlyPaymentLowerThan20Indicator'
        /// </summary>
        [Test]
        public void BorrowerMonthlyPaymentLowerThan20IndicatorTest()
        {
            // TODO unit test for the property 'BorrowerMonthlyPaymentLowerThan20Indicator'
        }
        /// <summary>
        /// Test the property 'BorrowerReceivedReasonable'
        /// </summary>
        [Test]
        public void BorrowerReceivedReasonableTest()
        {
            // TODO unit test for the property 'BorrowerReceivedReasonable'
        }
        /// <summary>
        /// Test the property 'BorrowerReceivesAmountExcessCostAndFeesIndicator'
        /// </summary>
        [Test]
        public void BorrowerReceivesAmountExcessCostAndFeesIndicatorTest()
        {
            // TODO unit test for the property 'BorrowerReceivesAmountExcessCostAndFeesIndicator'
        }
        /// <summary>
        /// Test the property 'ChangeLoanFromArmtoFixedIndicator'
        /// </summary>
        [Test]
        public void ChangeLoanFromArmtoFixedIndicatorTest()
        {
            // TODO unit test for the property 'ChangeLoanFromArmtoFixedIndicator'
        }
        /// <summary>
        /// Test the property 'ChangingLoanToFixedRateIndicator'
        /// </summary>
        [Test]
        public void ChangingLoanToFixedRateIndicatorTest()
        {
            // TODO unit test for the property 'ChangingLoanToFixedRateIndicator'
        }
        /// <summary>
        /// Test the property 'ConsolidatingOtherExistingLoansIntoNewLoanIndicator'
        /// </summary>
        [Test]
        public void ConsolidatingOtherExistingLoansIntoNewLoanIndicatorTest()
        {
            // TODO unit test for the property 'ConsolidatingOtherExistingLoansIntoNewLoanIndicator'
        }
        /// <summary>
        /// Test the property 'EliminatingBalloonPaymentIndicator'
        /// </summary>
        [Test]
        public void EliminatingBalloonPaymentIndicatorTest()
        {
            // TODO unit test for the property 'EliminatingBalloonPaymentIndicator'
        }
        /// <summary>
        /// Test the property 'EliminatingNegArmIndicator'
        /// </summary>
        [Test]
        public void EliminatingNegArmIndicatorTest()
        {
            // TODO unit test for the property 'EliminatingNegArmIndicator'
        }
        /// <summary>
        /// Test the property 'EliminatingPrivateMortgageInsuranceIndicator'
        /// </summary>
        [Test]
        public void EliminatingPrivateMortgageInsuranceIndicatorTest()
        {
            // TODO unit test for the property 'EliminatingPrivateMortgageInsuranceIndicator'
        }
        /// <summary>
        /// Test the property 'ExistingLoanAprPercent'
        /// </summary>
        [Test]
        public void ExistingLoanAprPercentTest()
        {
            // TODO unit test for the property 'ExistingLoanAprPercent'
        }
        /// <summary>
        /// Test the property 'ExistingLoanBalloonIndicator'
        /// </summary>
        [Test]
        public void ExistingLoanBalloonIndicatorTest()
        {
            // TODO unit test for the property 'ExistingLoanBalloonIndicator'
        }
        /// <summary>
        /// Test the property 'ExistingLoanBorrowerReceivesCashOutAmount'
        /// </summary>
        [Test]
        public void ExistingLoanBorrowerReceivesCashOutAmountTest()
        {
            // TODO unit test for the property 'ExistingLoanBorrowerReceivesCashOutAmount'
        }
        /// <summary>
        /// Test the property 'ExistingLoanBorrowerReceivesCashOutIndicator'
        /// </summary>
        [Test]
        public void ExistingLoanBorrowerReceivesCashOutIndicatorTest()
        {
            // TODO unit test for the property 'ExistingLoanBorrowerReceivesCashOutIndicator'
        }
        /// <summary>
        /// Test the property 'ExistingLoanBottomRatioPercent'
        /// </summary>
        [Test]
        public void ExistingLoanBottomRatioPercentTest()
        {
            // TODO unit test for the property 'ExistingLoanBottomRatioPercent'
        }
        /// <summary>
        /// Test the property 'ExistingLoanDateLoanClosed'
        /// </summary>
        [Test]
        public void ExistingLoanDateLoanClosedTest()
        {
            // TODO unit test for the property 'ExistingLoanDateLoanClosed'
        }
        /// <summary>
        /// Test the property 'ExistingLoanFullyIndexRatePercent'
        /// </summary>
        [Test]
        public void ExistingLoanFullyIndexRatePercentTest()
        {
            // TODO unit test for the property 'ExistingLoanFullyIndexRatePercent'
        }
        /// <summary>
        /// Test the property 'ExistingLoanInterestRatePercent'
        /// </summary>
        [Test]
        public void ExistingLoanInterestRatePercentTest()
        {
            // TODO unit test for the property 'ExistingLoanInterestRatePercent'
        }
        /// <summary>
        /// Test the property 'ExistingLoanIsGuaranteedIndicator'
        /// </summary>
        [Test]
        public void ExistingLoanIsGuaranteedIndicatorTest()
        {
            // TODO unit test for the property 'ExistingLoanIsGuaranteedIndicator'
        }
        /// <summary>
        /// Test the property 'ExistingLoanIsLoanRefinancedAsSpecial'
        /// </summary>
        [Test]
        public void ExistingLoanIsLoanRefinancedAsSpecialTest()
        {
            // TODO unit test for the property 'ExistingLoanIsLoanRefinancedAsSpecial'
        }
        /// <summary>
        /// Test the property 'ExistingLoanIsNegativeAmortizationFeatureIndicator'
        /// </summary>
        [Test]
        public void ExistingLoanIsNegativeAmortizationFeatureIndicatorTest()
        {
            // TODO unit test for the property 'ExistingLoanIsNegativeAmortizationFeatureIndicator'
        }
        /// <summary>
        /// Test the property 'ExistingLoanIsPrepaymentPenalty'
        /// </summary>
        [Test]
        public void ExistingLoanIsPrepaymentPenaltyTest()
        {
            // TODO unit test for the property 'ExistingLoanIsPrepaymentPenalty'
        }
        /// <summary>
        /// Test the property 'ExistingLoanLoanAmortizationType'
        /// </summary>
        [Test]
        public void ExistingLoanLoanAmortizationTypeTest()
        {
            // TODO unit test for the property 'ExistingLoanLoanAmortizationType'
        }
        /// <summary>
        /// Test the property 'ExistingLoanLoanAmount'
        /// </summary>
        [Test]
        public void ExistingLoanLoanAmountTest()
        {
            // TODO unit test for the property 'ExistingLoanLoanAmount'
        }
        /// <summary>
        /// Test the property 'ExistingLoanLoanTerm'
        /// </summary>
        [Test]
        public void ExistingLoanLoanTermTest()
        {
            // TODO unit test for the property 'ExistingLoanLoanTerm'
        }
        /// <summary>
        /// Test the property 'ExistingLoanLtvPercent'
        /// </summary>
        [Test]
        public void ExistingLoanLtvPercentTest()
        {
            // TODO unit test for the property 'ExistingLoanLtvPercent'
        }
        /// <summary>
        /// Test the property 'ExistingLoanMaximumRatePercent'
        /// </summary>
        [Test]
        public void ExistingLoanMaximumRatePercentTest()
        {
            // TODO unit test for the property 'ExistingLoanMaximumRatePercent'
        }
        /// <summary>
        /// Test the property 'ExistingLoanMonthsRemaining'
        /// </summary>
        [Test]
        public void ExistingLoanMonthsRemainingTest()
        {
            // TODO unit test for the property 'ExistingLoanMonthsRemaining'
        }
        /// <summary>
        /// Test the property 'ExistingLoanPaymentAmount'
        /// </summary>
        [Test]
        public void ExistingLoanPaymentAmountTest()
        {
            // TODO unit test for the property 'ExistingLoanPaymentAmount'
        }
        /// <summary>
        /// Test the property 'ExistingLoanPaymentDifference'
        /// </summary>
        [Test]
        public void ExistingLoanPaymentDifferenceTest()
        {
            // TODO unit test for the property 'ExistingLoanPaymentDifference'
        }
        /// <summary>
        /// Test the property 'ExistingLoanPaymentIncludeMiObligation'
        /// </summary>
        [Test]
        public void ExistingLoanPaymentIncludeMiObligationTest()
        {
            // TODO unit test for the property 'ExistingLoanPaymentIncludeMiObligation'
        }
        /// <summary>
        /// Test the property 'ExistingLoanPaymentIncludeMortgageInsurance'
        /// </summary>
        [Test]
        public void ExistingLoanPaymentIncludeMortgageInsuranceTest()
        {
            // TODO unit test for the property 'ExistingLoanPaymentIncludeMortgageInsurance'
        }
        /// <summary>
        /// Test the property 'ExistingLoanPrepaymentPenaltyAmountIncludedInNewLoan'
        /// </summary>
        [Test]
        public void ExistingLoanPrepaymentPenaltyAmountIncludedInNewLoanTest()
        {
            // TODO unit test for the property 'ExistingLoanPrepaymentPenaltyAmountIncludedInNewLoan'
        }
        /// <summary>
        /// Test the property 'ExistingLoanPrepaymentPenaltyBasedOn'
        /// </summary>
        [Test]
        public void ExistingLoanPrepaymentPenaltyBasedOnTest()
        {
            // TODO unit test for the property 'ExistingLoanPrepaymentPenaltyBasedOn'
        }
        /// <summary>
        /// Test the property 'ExistingLoanPrepaymentPenaltyPercentage'
        /// </summary>
        [Test]
        public void ExistingLoanPrepaymentPenaltyPercentageTest()
        {
            // TODO unit test for the property 'ExistingLoanPrepaymentPenaltyPercentage'
        }
        /// <summary>
        /// Test the property 'ExistingLoanPrepaymentPenaltyTerm'
        /// </summary>
        [Test]
        public void ExistingLoanPrepaymentPenaltyTermTest()
        {
            // TODO unit test for the property 'ExistingLoanPrepaymentPenaltyTerm'
        }
        /// <summary>
        /// Test the property 'ExistingLoanProvidedByLicenseeType'
        /// </summary>
        [Test]
        public void ExistingLoanProvidedByLicenseeTypeTest()
        {
            // TODO unit test for the property 'ExistingLoanProvidedByLicenseeType'
        }
        /// <summary>
        /// Test the property 'ExistingLoanPurposeType'
        /// </summary>
        [Test]
        public void ExistingLoanPurposeTypeTest()
        {
            // TODO unit test for the property 'ExistingLoanPurposeType'
        }
        /// <summary>
        /// Test the property 'ExistingLoanRecoupCostsYears'
        /// </summary>
        [Test]
        public void ExistingLoanRecoupCostsYearsTest()
        {
            // TODO unit test for the property 'ExistingLoanRecoupCostsYears'
        }
        /// <summary>
        /// Test the property 'ExistingLoanSavingsAmount'
        /// </summary>
        [Test]
        public void ExistingLoanSavingsAmountTest()
        {
            // TODO unit test for the property 'ExistingLoanSavingsAmount'
        }
        /// <summary>
        /// Test the property 'ExistingLoanTotalDebtPayoff'
        /// </summary>
        [Test]
        public void ExistingLoanTotalDebtPayoffTest()
        {
            // TODO unit test for the property 'ExistingLoanTotalDebtPayoff'
        }
        /// <summary>
        /// Test the property 'ExistingLoanWeightedAverageInterestRatePercent'
        /// </summary>
        [Test]
        public void ExistingLoanWeightedAverageInterestRatePercentTest()
        {
            // TODO unit test for the property 'ExistingLoanWeightedAverageInterestRatePercent'
        }
        /// <summary>
        /// Test the property 'HomeLoanComplianceWith209'
        /// </summary>
        [Test]
        public void HomeLoanComplianceWith209Test()
        {
            // TODO unit test for the property 'HomeLoanComplianceWith209'
        }
        /// <summary>
        /// Test the property 'LenderDeterminedBorrowersInterest'
        /// </summary>
        [Test]
        public void LenderDeterminedBorrowersInterestTest()
        {
            // TODO unit test for the property 'LenderDeterminedBorrowersInterest'
        }
        /// <summary>
        /// Test the property 'NewLoanIsGuaranteedIndicator'
        /// </summary>
        [Test]
        public void NewLoanIsGuaranteedIndicatorTest()
        {
            // TODO unit test for the property 'NewLoanIsGuaranteedIndicator'
        }
        /// <summary>
        /// Test the property 'NewLoanIsNegativeAmortizationFeatureIndicator'
        /// </summary>
        [Test]
        public void NewLoanIsNegativeAmortizationFeatureIndicatorTest()
        {
            // TODO unit test for the property 'NewLoanIsNegativeAmortizationFeatureIndicator'
        }
        /// <summary>
        /// Test the property 'NewLoanIsSpecialMortgageOriginatedIndicator'
        /// </summary>
        [Test]
        public void NewLoanIsSpecialMortgageOriginatedIndicatorTest()
        {
            // TODO unit test for the property 'NewLoanIsSpecialMortgageOriginatedIndicator'
        }
        /// <summary>
        /// Test the property 'NewLoanPaymentWithMiDifference'
        /// </summary>
        [Test]
        public void NewLoanPaymentWithMiDifferenceTest()
        {
            // TODO unit test for the property 'NewLoanPaymentWithMiDifference'
        }
        /// <summary>
        /// Test the property 'NewLoanPaymentWithObligationDifference'
        /// </summary>
        [Test]
        public void NewLoanPaymentWithObligationDifferenceTest()
        {
            // TODO unit test for the property 'NewLoanPaymentWithObligationDifference'
        }
        /// <summary>
        /// Test the property 'NewLoanPayOffConsolidateDebtIndicator'
        /// </summary>
        [Test]
        public void NewLoanPayOffConsolidateDebtIndicatorTest()
        {
            // TODO unit test for the property 'NewLoanPayOffConsolidateDebtIndicator'
        }
        /// <summary>
        /// Test the property 'NewLoanWeightedAverageInterestRatePercent'
        /// </summary>
        [Test]
        public void NewLoanWeightedAverageInterestRatePercentTest()
        {
            // TODO unit test for the property 'NewLoanWeightedAverageInterestRatePercent'
        }
        /// <summary>
        /// Test the property 'ObtainingLowerIntMonthlyPaymentIndicator'
        /// </summary>
        [Test]
        public void ObtainingLowerIntMonthlyPaymentIndicatorTest()
        {
            // TODO unit test for the property 'ObtainingLowerIntMonthlyPaymentIndicator'
        }
        /// <summary>
        /// Test the property 'ObtainingLowerIntRateIndicator'
        /// </summary>
        [Test]
        public void ObtainingLowerIntRateIndicatorTest()
        {
            // TODO unit test for the property 'ObtainingLowerIntRateIndicator'
        }
        /// <summary>
        /// Test the property 'ObtainingShortAmortScheduleIndicator'
        /// </summary>
        [Test]
        public void ObtainingShortAmortScheduleIndicatorTest()
        {
            // TODO unit test for the property 'ObtainingShortAmortScheduleIndicator'
        }
        /// <summary>
        /// Test the property 'OtherReason'
        /// </summary>
        [Test]
        public void OtherReasonTest()
        {
            // TODO unit test for the property 'OtherReason'
        }
        /// <summary>
        /// Test the property 'OtherReasonDescription'
        /// </summary>
        [Test]
        public void OtherReasonDescriptionTest()
        {
            // TODO unit test for the property 'OtherReasonDescription'
        }
        /// <summary>
        /// Test the property 'PrintBorrowerInitialLinesIndicator'
        /// </summary>
        [Test]
        public void PrintBorrowerInitialLinesIndicatorTest()
        {
            // TODO unit test for the property 'PrintBorrowerInitialLinesIndicator'
        }
        /// <summary>
        /// Test the property 'ProceedsOfNewLoanWillBeUsedIndicator'
        /// </summary>
        [Test]
        public void ProceedsOfNewLoanWillBeUsedIndicatorTest()
        {
            // TODO unit test for the property 'ProceedsOfNewLoanWillBeUsedIndicator'
        }
        /// <summary>
        /// Test the property 'ReceivingCashOutFromNewLoanGreaterThanClosingCostIndicator'
        /// </summary>
        [Test]
        public void ReceivingCashOutFromNewLoanGreaterThanClosingCostIndicatorTest()
        {
            // TODO unit test for the property 'ReceivingCashOutFromNewLoanGreaterThanClosingCostIndicator'
        }
        /// <summary>
        /// Test the property 'RefinancingLoanIsHomeEquityIndicator'
        /// </summary>
        [Test]
        public void RefinancingLoanIsHomeEquityIndicatorTest()
        {
            // TODO unit test for the property 'RefinancingLoanIsHomeEquityIndicator'
        }
        /// <summary>
        /// Test the property 'RefinancingRespondBonaFide'
        /// </summary>
        [Test]
        public void RefinancingRespondBonaFideTest()
        {
            // TODO unit test for the property 'RefinancingRespondBonaFide'
        }
        /// <summary>
        /// Test the property 'NewLoanIsSafeHarborQM'
        /// </summary>
        [Test]
        public void NewLoanIsSafeHarborQMTest()
        {
            // TODO unit test for the property 'NewLoanIsSafeHarborQM'
        }

    }

}
