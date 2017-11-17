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
    ///  Class for testing LoanContractFhaVaLoan
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LoanContractFhaVaLoanTests
    {
        // TODO uncomment below to declare an instance variable for LoanContractFhaVaLoan
        //private LoanContractFhaVaLoan instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LoanContractFhaVaLoan
            //instance = new LoanContractFhaVaLoan();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoanContractFhaVaLoan
        /// </summary>
        [Test]
        public void LoanContractFhaVaLoanInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LoanContractFhaVaLoan
            //Assert.IsInstanceOfType<LoanContractFhaVaLoan> (instance, "variable 'instance' is a LoanContractFhaVaLoan");
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
        /// Test the property 'AddendumType'
        /// </summary>
        [Test]
        public void AddendumTypeTest()
        {
            // TODO unit test for the property 'AddendumType'
        }
        /// <summary>
        /// Test the property 'AdditionalCondition1'
        /// </summary>
        [Test]
        public void AdditionalCondition1Test()
        {
            // TODO unit test for the property 'AdditionalCondition1'
        }
        /// <summary>
        /// Test the property 'AdditionalCondition2'
        /// </summary>
        [Test]
        public void AdditionalCondition2Test()
        {
            // TODO unit test for the property 'AdditionalCondition2'
        }
        /// <summary>
        /// Test the property 'AdditionalCondition3'
        /// </summary>
        [Test]
        public void AdditionalCondition3Test()
        {
            // TODO unit test for the property 'AdditionalCondition3'
        }
        /// <summary>
        /// Test the property 'AdditionalCondition4'
        /// </summary>
        [Test]
        public void AdditionalCondition4Test()
        {
            // TODO unit test for the property 'AdditionalCondition4'
        }
        /// <summary>
        /// Test the property 'AdditionalCondition5'
        /// </summary>
        [Test]
        public void AdditionalCondition5Test()
        {
            // TODO unit test for the property 'AdditionalCondition5'
        }
        /// <summary>
        /// Test the property 'AdditionalCondition6'
        /// </summary>
        [Test]
        public void AdditionalCondition6Test()
        {
            // TODO unit test for the property 'AdditionalCondition6'
        }
        /// <summary>
        /// Test the property 'AdditionalCondition7'
        /// </summary>
        [Test]
        public void AdditionalCondition7Test()
        {
            // TODO unit test for the property 'AdditionalCondition7'
        }
        /// <summary>
        /// Test the property 'AdditionalCondition8'
        /// </summary>
        [Test]
        public void AdditionalCondition8Test()
        {
            // TODO unit test for the property 'AdditionalCondition8'
        }
        /// <summary>
        /// Test the property 'AdditionalCondition9'
        /// </summary>
        [Test]
        public void AdditionalCondition9Test()
        {
            // TODO unit test for the property 'AdditionalCondition9'
        }
        /// <summary>
        /// Test the property 'AddressValidatedBy'
        /// </summary>
        [Test]
        public void AddressValidatedByTest()
        {
            // TODO unit test for the property 'AddressValidatedBy'
        }
        /// <summary>
        /// Test the property 'AddressValidationMessage'
        /// </summary>
        [Test]
        public void AddressValidationMessageTest()
        {
            // TODO unit test for the property 'AddressValidationMessage'
        }
        /// <summary>
        /// Test the property 'AppraisalLoggedDate'
        /// </summary>
        [Test]
        public void AppraisalLoggedDateTest()
        {
            // TODO unit test for the property 'AppraisalLoggedDate'
        }
        /// <summary>
        /// Test the property 'AppraisalLookupBy'
        /// </summary>
        [Test]
        public void AppraisalLookupByTest()
        {
            // TODO unit test for the property 'AppraisalLookupBy'
        }
        /// <summary>
        /// Test the property 'BeenInformed'
        /// </summary>
        [Test]
        public void BeenInformedTest()
        {
            // TODO unit test for the property 'BeenInformed'
        }
        /// <summary>
        /// Test the property 'BorrowerCertificationAddress'
        /// </summary>
        [Test]
        public void BorrowerCertificationAddressTest()
        {
            // TODO unit test for the property 'BorrowerCertificationAddress'
        }
        /// <summary>
        /// Test the property 'BorrowerCertificationCity'
        /// </summary>
        [Test]
        public void BorrowerCertificationCityTest()
        {
            // TODO unit test for the property 'BorrowerCertificationCity'
        }
        /// <summary>
        /// Test the property 'BorrowerCertificationPostalCode'
        /// </summary>
        [Test]
        public void BorrowerCertificationPostalCodeTest()
        {
            // TODO unit test for the property 'BorrowerCertificationPostalCode'
        }
        /// <summary>
        /// Test the property 'BorrowerCertificationState'
        /// </summary>
        [Test]
        public void BorrowerCertificationStateTest()
        {
            // TODO unit test for the property 'BorrowerCertificationState'
        }
        /// <summary>
        /// Test the property 'CAIVRSObtainedBy'
        /// </summary>
        [Test]
        public void CAIVRSObtainedByTest()
        {
            // TODO unit test for the property 'CAIVRSObtainedBy'
        }
        /// <summary>
        /// Test the property 'CaseBinderShippedBy'
        /// </summary>
        [Test]
        public void CaseBinderShippedByTest()
        {
            // TODO unit test for the property 'CaseBinderShippedBy'
        }
        /// <summary>
        /// Test the property 'CaseBinderShippedDate'
        /// </summary>
        [Test]
        public void CaseBinderShippedDateTest()
        {
            // TODO unit test for the property 'CaseBinderShippedDate'
        }
        /// <summary>
        /// Test the property 'ClosingDate'
        /// </summary>
        [Test]
        public void ClosingDateTest()
        {
            // TODO unit test for the property 'ClosingDate'
        }
        /// <summary>
        /// Test the property 'CondoPudID'
        /// </summary>
        [Test]
        public void CondoPudIDTest()
        {
            // TODO unit test for the property 'CondoPudID'
        }
        /// <summary>
        /// Test the property 'CondoPudLookupBy'
        /// </summary>
        [Test]
        public void CondoPudLookupByTest()
        {
            // TODO unit test for the property 'CondoPudLookupBy'
        }
        /// <summary>
        /// Test the property 'CondoPudLookupDate'
        /// </summary>
        [Test]
        public void CondoPudLookupDateTest()
        {
            // TODO unit test for the property 'CondoPudLookupDate'
        }
        /// <summary>
        /// Test the property 'DateApprovalExpires'
        /// </summary>
        [Test]
        public void DateApprovalExpiresTest()
        {
            // TODO unit test for the property 'DateApprovalExpires'
        }
        /// <summary>
        /// Test the property 'DateMortgageApproved'
        /// </summary>
        [Test]
        public void DateMortgageApprovedTest()
        {
            // TODO unit test for the property 'DateMortgageApproved'
        }
        /// <summary>
        /// Test the property 'DetailForOther'
        /// </summary>
        [Test]
        public void DetailForOtherTest()
        {
            // TODO unit test for the property 'DetailForOther'
        }
        /// <summary>
        /// Test the property 'DiscountPoints'
        /// </summary>
        [Test]
        public void DiscountPointsTest()
        {
            // TODO unit test for the property 'DiscountPoints'
        }
        /// <summary>
        /// Test the property 'DulyAgentAddress'
        /// </summary>
        [Test]
        public void DulyAgentAddressTest()
        {
            // TODO unit test for the property 'DulyAgentAddress'
        }
        /// <summary>
        /// Test the property 'DulyAgentCity'
        /// </summary>
        [Test]
        public void DulyAgentCityTest()
        {
            // TODO unit test for the property 'DulyAgentCity'
        }
        /// <summary>
        /// Test the property 'DulyAgentFunction1'
        /// </summary>
        [Test]
        public void DulyAgentFunction1Test()
        {
            // TODO unit test for the property 'DulyAgentFunction1'
        }
        /// <summary>
        /// Test the property 'DulyAgentFunction2'
        /// </summary>
        [Test]
        public void DulyAgentFunction2Test()
        {
            // TODO unit test for the property 'DulyAgentFunction2'
        }
        /// <summary>
        /// Test the property 'DulyAgentName'
        /// </summary>
        [Test]
        public void DulyAgentNameTest()
        {
            // TODO unit test for the property 'DulyAgentName'
        }
        /// <summary>
        /// Test the property 'DulyAgentState'
        /// </summary>
        [Test]
        public void DulyAgentStateTest()
        {
            // TODO unit test for the property 'DulyAgentState'
        }
        /// <summary>
        /// Test the property 'DwellingCoveredBy'
        /// </summary>
        [Test]
        public void DwellingCoveredByTest()
        {
            // TODO unit test for the property 'DwellingCoveredBy'
        }
        /// <summary>
        /// Test the property 'Eem'
        /// </summary>
        [Test]
        public void EemTest()
        {
            // TODO unit test for the property 'Eem'
        }
        /// <summary>
        /// Test the property 'EligibilityAssessment'
        /// </summary>
        [Test]
        public void EligibilityAssessmentTest()
        {
            // TODO unit test for the property 'EligibilityAssessment'
        }
        /// <summary>
        /// Test the property 'EnergyEfficientMortgageAmount'
        /// </summary>
        [Test]
        public void EnergyEfficientMortgageAmountTest()
        {
            // TODO unit test for the property 'EnergyEfficientMortgageAmount'
        }
        /// <summary>
        /// Test the property 'EnergyEfficientMortgageItems'
        /// </summary>
        [Test]
        public void EnergyEfficientMortgageItemsTest()
        {
            // TODO unit test for the property 'EnergyEfficientMortgageItems'
        }
        /// <summary>
        /// Test the property 'EverHadVAHomeLoan'
        /// </summary>
        [Test]
        public void EverHadVAHomeLoanTest()
        {
            // TODO unit test for the property 'EverHadVAHomeLoan'
        }
        /// <summary>
        /// Test the property 'ExcessContributionAmount'
        /// </summary>
        [Test]
        public void ExcessContributionAmountTest()
        {
            // TODO unit test for the property 'ExcessContributionAmount'
        }
        /// <summary>
        /// Test the property 'ExistingDebtAmount'
        /// </summary>
        [Test]
        public void ExistingDebtAmountTest()
        {
            // TODO unit test for the property 'ExistingDebtAmount'
        }
        /// <summary>
        /// Test the property 'FHACaseOrderedBy'
        /// </summary>
        [Test]
        public void FHACaseOrderedByTest()
        {
            // TODO unit test for the property 'FHACaseOrderedBy'
        }
        /// <summary>
        /// Test the property 'FHAManagementCounselType'
        /// </summary>
        [Test]
        public void FHAManagementCounselTypeTest()
        {
            // TODO unit test for the property 'FHAManagementCounselType'
        }
        /// <summary>
        /// Test the property 'FHAMaxLoanAmount'
        /// </summary>
        [Test]
        public void FHAMaxLoanAmountTest()
        {
            // TODO unit test for the property 'FHAMaxLoanAmount'
        }
        /// <summary>
        /// Test the property 'ForeclosedProperty'
        /// </summary>
        [Test]
        public void ForeclosedPropertyTest()
        {
            // TODO unit test for the property 'ForeclosedProperty'
        }
        /// <summary>
        /// Test the property 'FreddieMacCounselType'
        /// </summary>
        [Test]
        public void FreddieMacCounselTypeTest()
        {
            // TODO unit test for the property 'FreddieMacCounselType'
        }
        /// <summary>
        /// Test the property 'FundingFeePaidInCash'
        /// </summary>
        [Test]
        public void FundingFeePaidInCashTest()
        {
            // TODO unit test for the property 'FundingFeePaidInCash'
        }
        /// <summary>
        /// Test the property 'GiftFundsAmount'
        /// </summary>
        [Test]
        public void GiftFundsAmountTest()
        {
            // TODO unit test for the property 'GiftFundsAmount'
        }
        /// <summary>
        /// Test the property 'HaveReceivedLeadPaintPoisoningInfo'
        /// </summary>
        [Test]
        public void HaveReceivedLeadPaintPoisoningInfoTest()
        {
            // TODO unit test for the property 'HaveReceivedLeadPaintPoisoningInfo'
        }
        /// <summary>
        /// Test the property 'HUD1003AddendumApproved'
        /// </summary>
        [Test]
        public void HUD1003AddendumApprovedTest()
        {
            // TODO unit test for the property 'HUD1003AddendumApproved'
        }
        /// <summary>
        /// Test the property 'LastRefiDate'
        /// </summary>
        [Test]
        public void LastRefiDateTest()
        {
            // TODO unit test for the property 'LastRefiDate'
        }
        /// <summary>
        /// Test the property 'LDPGSASearchDate'
        /// </summary>
        [Test]
        public void LDPGSASearchDateTest()
        {
            // TODO unit test for the property 'LDPGSASearchDate'
        }
        /// <summary>
        /// Test the property 'LDPGSASearchedBy'
        /// </summary>
        [Test]
        public void LDPGSASearchedByTest()
        {
            // TODO unit test for the property 'LDPGSASearchedBy'
        }
        /// <summary>
        /// Test the property 'LenderAddress'
        /// </summary>
        [Test]
        public void LenderAddressTest()
        {
            // TODO unit test for the property 'LenderAddress'
        }
        /// <summary>
        /// Test the property 'LenderCity'
        /// </summary>
        [Test]
        public void LenderCityTest()
        {
            // TODO unit test for the property 'LenderCity'
        }
        /// <summary>
        /// Test the property 'LenderName'
        /// </summary>
        [Test]
        public void LenderNameTest()
        {
            // TODO unit test for the property 'LenderName'
        }
        /// <summary>
        /// Test the property 'LenderNMLS'
        /// </summary>
        [Test]
        public void LenderNMLSTest()
        {
            // TODO unit test for the property 'LenderNMLS'
        }
        /// <summary>
        /// Test the property 'LenderPostalCode'
        /// </summary>
        [Test]
        public void LenderPostalCodeTest()
        {
            // TODO unit test for the property 'LenderPostalCode'
        }
        /// <summary>
        /// Test the property 'LenderRepresentativeName'
        /// </summary>
        [Test]
        public void LenderRepresentativeNameTest()
        {
            // TODO unit test for the property 'LenderRepresentativeName'
        }
        /// <summary>
        /// Test the property 'LenderRepresentativePhone'
        /// </summary>
        [Test]
        public void LenderRepresentativePhoneTest()
        {
            // TODO unit test for the property 'LenderRepresentativePhone'
        }
        /// <summary>
        /// Test the property 'LenderRepresentativeTitle'
        /// </summary>
        [Test]
        public void LenderRepresentativeTitleTest()
        {
            // TODO unit test for the property 'LenderRepresentativeTitle'
        }
        /// <summary>
        /// Test the property 'LenderState'
        /// </summary>
        [Test]
        public void LenderStateTest()
        {
            // TODO unit test for the property 'LenderState'
        }
        /// <summary>
        /// Test the property 'LenderTaxID'
        /// </summary>
        [Test]
        public void LenderTaxIDTest()
        {
            // TODO unit test for the property 'LenderTaxID'
        }
        /// <summary>
        /// Test the property 'LoanScoreID'
        /// </summary>
        [Test]
        public void LoanScoreIDTest()
        {
            // TODO unit test for the property 'LoanScoreID'
        }
        /// <summary>
        /// Test the property 'MIAppliedBy'
        /// </summary>
        [Test]
        public void MIAppliedByTest()
        {
            // TODO unit test for the property 'MIAppliedBy'
        }
        /// <summary>
        /// Test the property 'MIAppliedDate'
        /// </summary>
        [Test]
        public void MIAppliedDateTest()
        {
            // TODO unit test for the property 'MIAppliedDate'
        }
        /// <summary>
        /// Test the property 'MICRetrivedDate'
        /// </summary>
        [Test]
        public void MICRetrivedDateTest()
        {
            // TODO unit test for the property 'MICRetrivedDate'
        }
        /// <summary>
        /// Test the property 'MinimumDownPayment'
        /// </summary>
        [Test]
        public void MinimumDownPaymentTest()
        {
            // TODO unit test for the property 'MinimumDownPayment'
        }
        /// <summary>
        /// Test the property 'MIP1stDueDate'
        /// </summary>
        [Test]
        public void MIP1stDueDateTest()
        {
            // TODO unit test for the property 'MIP1stDueDate'
        }
        /// <summary>
        /// Test the property 'MIP1stToInvestor'
        /// </summary>
        [Test]
        public void MIP1stToInvestorTest()
        {
            // TODO unit test for the property 'MIP1stToInvestor'
        }
        /// <summary>
        /// Test the property 'MIPRemittedDate'
        /// </summary>
        [Test]
        public void MIPRemittedDateTest()
        {
            // TODO unit test for the property 'MIPRemittedDate'
        }
        /// <summary>
        /// Test the property 'MIRejectedDate'
        /// </summary>
        [Test]
        public void MIRejectedDateTest()
        {
            // TODO unit test for the property 'MIRejectedDate'
        }
        /// <summary>
        /// Test the property 'ModifiedInterestRate'
        /// </summary>
        [Test]
        public void ModifiedInterestRateTest()
        {
            // TODO unit test for the property 'ModifiedInterestRate'
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
        /// Test the property 'ModifiedMonthlyPayment'
        /// </summary>
        [Test]
        public void ModifiedMonthlyPaymentTest()
        {
            // TODO unit test for the property 'ModifiedMonthlyPayment'
        }
        /// <summary>
        /// Test the property 'ModifiedMonthlyPremium'
        /// </summary>
        [Test]
        public void ModifiedMonthlyPremiumTest()
        {
            // TODO unit test for the property 'ModifiedMonthlyPremium'
        }
        /// <summary>
        /// Test the property 'ModifiedProposedMaturityMonth'
        /// </summary>
        [Test]
        public void ModifiedProposedMaturityMonthTest()
        {
            // TODO unit test for the property 'ModifiedProposedMaturityMonth'
        }
        /// <summary>
        /// Test the property 'ModifiedProposedMaturityYear'
        /// </summary>
        [Test]
        public void ModifiedProposedMaturityYearTest()
        {
            // TODO unit test for the property 'ModifiedProposedMaturityYear'
        }
        /// <summary>
        /// Test the property 'ModifiedTermAnnualPremium'
        /// </summary>
        [Test]
        public void ModifiedTermAnnualPremiumTest()
        {
            // TODO unit test for the property 'ModifiedTermAnnualPremium'
        }
        /// <summary>
        /// Test the property 'ModifiedUpfrontPremium'
        /// </summary>
        [Test]
        public void ModifiedUpfrontPremiumTest()
        {
            // TODO unit test for the property 'ModifiedUpfrontPremium'
        }
        /// <summary>
        /// Test the property 'MortgageeRepresentative'
        /// </summary>
        [Test]
        public void MortgageeRepresentativeTest()
        {
            // TODO unit test for the property 'MortgageeRepresentative'
        }
        /// <summary>
        /// Test the property 'MortgageFinancialInterest'
        /// </summary>
        [Test]
        public void MortgageFinancialInterestTest()
        {
            // TODO unit test for the property 'MortgageFinancialInterest'
        }
        /// <summary>
        /// Test the property 'NonRealtyAndOtherItems'
        /// </summary>
        [Test]
        public void NonRealtyAndOtherItemsTest()
        {
            // TODO unit test for the property 'NonRealtyAndOtherItems'
        }
        /// <summary>
        /// Test the property 'ObtainCAIVRSDate'
        /// </summary>
        [Test]
        public void ObtainCAIVRSDateTest()
        {
            // TODO unit test for the property 'ObtainCAIVRSDate'
        }
        /// <summary>
        /// Test the property 'Occupancy'
        /// </summary>
        [Test]
        public void OccupancyTest()
        {
            // TODO unit test for the property 'Occupancy'
        }
        /// <summary>
        /// Test the property 'OldAgencyCaseIdentifier'
        /// </summary>
        [Test]
        public void OldAgencyCaseIdentifierTest()
        {
            // TODO unit test for the property 'OldAgencyCaseIdentifier'
        }
        /// <summary>
        /// Test the property 'OriginalMortgageAmount'
        /// </summary>
        [Test]
        public void OriginalMortgageAmountTest()
        {
            // TODO unit test for the property 'OriginalMortgageAmount'
        }
        /// <summary>
        /// Test the property 'OtherLiabilitiesMonthlyPayment'
        /// </summary>
        [Test]
        public void OtherLiabilitiesMonthlyPaymentTest()
        {
            // TODO unit test for the property 'OtherLiabilitiesMonthlyPayment'
        }
        /// <summary>
        /// Test the property 'OtherLiabilitiesUnpaidBalance'
        /// </summary>
        [Test]
        public void OtherLiabilitiesUnpaidBalanceTest()
        {
            // TODO unit test for the property 'OtherLiabilitiesUnpaidBalance'
        }
        /// <summary>
        /// Test the property 'OtherMonthlyShelterExpense'
        /// </summary>
        [Test]
        public void OtherMonthlyShelterExpenseTest()
        {
            // TODO unit test for the property 'OtherMonthlyShelterExpense'
        }
        /// <summary>
        /// Test the property 'OtherTitleDescription'
        /// </summary>
        [Test]
        public void OtherTitleDescriptionTest()
        {
            // TODO unit test for the property 'OtherTitleDescription'
        }
        /// <summary>
        /// Test the property 'OwnMoreThanFourDwellings'
        /// </summary>
        [Test]
        public void OwnMoreThanFourDwellingsTest()
        {
            // TODO unit test for the property 'OwnMoreThanFourDwellings'
        }
        /// <summary>
        /// Test the property 'OwnOrSoldOtherRealEstate'
        /// </summary>
        [Test]
        public void OwnOrSoldOtherRealEstateTest()
        {
            // TODO unit test for the property 'OwnOrSoldOtherRealEstate'
        }
        /// <summary>
        /// Test the property 'PaidAmount'
        /// </summary>
        [Test]
        public void PaidAmountTest()
        {
            // TODO unit test for the property 'PaidAmount'
        }
        /// <summary>
        /// Test the property 'PremiumMonths'
        /// </summary>
        [Test]
        public void PremiumMonthsTest()
        {
            // TODO unit test for the property 'PremiumMonths'
        }
        /// <summary>
        /// Test the property 'PrepaidExpenses'
        /// </summary>
        [Test]
        public void PrepaidExpensesTest()
        {
            // TODO unit test for the property 'PrepaidExpenses'
        }
        /// <summary>
        /// Test the property 'PreviousPurchaseDate'
        /// </summary>
        [Test]
        public void PreviousPurchaseDateTest()
        {
            // TODO unit test for the property 'PreviousPurchaseDate'
        }
        /// <summary>
        /// Test the property 'PriorEndorsementDate'
        /// </summary>
        [Test]
        public void PriorEndorsementDateTest()
        {
            // TODO unit test for the property 'PriorEndorsementDate'
        }
        /// <summary>
        /// Test the property 'ProposedMaturityMonths'
        /// </summary>
        [Test]
        public void ProposedMaturityMonthsTest()
        {
            // TODO unit test for the property 'ProposedMaturityMonths'
        }
        /// <summary>
        /// Test the property 'ProposedMaturityYears'
        /// </summary>
        [Test]
        public void ProposedMaturityYearsTest()
        {
            // TODO unit test for the property 'ProposedMaturityYears'
        }
        /// <summary>
        /// Test the property 'PurposeOfLoan'
        /// </summary>
        [Test]
        public void PurposeOfLoanTest()
        {
            // TODO unit test for the property 'PurposeOfLoan'
        }
        /// <summary>
        /// Test the property 'RefiAuthorizationBy'
        /// </summary>
        [Test]
        public void RefiAuthorizationByTest()
        {
            // TODO unit test for the property 'RefiAuthorizationBy'
        }
        /// <summary>
        /// Test the property 'RefiAuthorizationDate'
        /// </summary>
        [Test]
        public void RefiAuthorizationDateTest()
        {
            // TODO unit test for the property 'RefiAuthorizationDate'
        }
        /// <summary>
        /// Test the property 'SalesPrice'
        /// </summary>
        [Test]
        public void SalesPriceTest()
        {
            // TODO unit test for the property 'SalesPrice'
        }
        /// <summary>
        /// Test the property 'SecondMortgageAmount'
        /// </summary>
        [Test]
        public void SecondMortgageAmountTest()
        {
            // TODO unit test for the property 'SecondMortgageAmount'
        }
        /// <summary>
        /// Test the property 'SellerPaidClosingCost'
        /// </summary>
        [Test]
        public void SellerPaidClosingCostTest()
        {
            // TODO unit test for the property 'SellerPaidClosingCost'
        }
        /// <summary>
        /// Test the property 'ServingTransferedDate'
        /// </summary>
        [Test]
        public void ServingTransferedDateTest()
        {
            // TODO unit test for the property 'ServingTransferedDate'
        }
        /// <summary>
        /// Test the property 'SpecialAssessments'
        /// </summary>
        [Test]
        public void SpecialAssessmentsTest()
        {
            // TODO unit test for the property 'SpecialAssessments'
        }
        /// <summary>
        /// Test the property 'SponsorAgentAddress'
        /// </summary>
        [Test]
        public void SponsorAgentAddressTest()
        {
            // TODO unit test for the property 'SponsorAgentAddress'
        }
        /// <summary>
        /// Test the property 'SponsorAgentCity'
        /// </summary>
        [Test]
        public void SponsorAgentCityTest()
        {
            // TODO unit test for the property 'SponsorAgentCity'
        }
        /// <summary>
        /// Test the property 'SponsorAgentName'
        /// </summary>
        [Test]
        public void SponsorAgentNameTest()
        {
            // TODO unit test for the property 'SponsorAgentName'
        }
        /// <summary>
        /// Test the property 'SponsorAgentNMLS'
        /// </summary>
        [Test]
        public void SponsorAgentNMLSTest()
        {
            // TODO unit test for the property 'SponsorAgentNMLS'
        }
        /// <summary>
        /// Test the property 'SponsorAgentPostalCode'
        /// </summary>
        [Test]
        public void SponsorAgentPostalCodeTest()
        {
            // TODO unit test for the property 'SponsorAgentPostalCode'
        }
        /// <summary>
        /// Test the property 'SponsorAgentState'
        /// </summary>
        [Test]
        public void SponsorAgentStateTest()
        {
            // TODO unit test for the property 'SponsorAgentState'
        }
        /// <summary>
        /// Test the property 'SponsorAgentTaxID'
        /// </summary>
        [Test]
        public void SponsorAgentTaxIDTest()
        {
            // TODO unit test for the property 'SponsorAgentTaxID'
        }
        /// <summary>
        /// Test the property 'SponsoredOriginationsName'
        /// </summary>
        [Test]
        public void SponsoredOriginationsNameTest()
        {
            // TODO unit test for the property 'SponsoredOriginationsName'
        }
        /// <summary>
        /// Test the property 'SponsoredOriginationsNMLS'
        /// </summary>
        [Test]
        public void SponsoredOriginationsNMLSTest()
        {
            // TODO unit test for the property 'SponsoredOriginationsNMLS'
        }
        /// <summary>
        /// Test the property 'SponsoredOriginationsTaxID'
        /// </summary>
        [Test]
        public void SponsoredOriginationsTaxIDTest()
        {
            // TODO unit test for the property 'SponsoredOriginationsTaxID'
        }
        /// <summary>
        /// Test the property 'SponsorID'
        /// </summary>
        [Test]
        public void SponsorIDTest()
        {
            // TODO unit test for the property 'SponsorID'
        }
        /// <summary>
        /// Test the property 'TitleVestedIn'
        /// </summary>
        [Test]
        public void TitleVestedInTest()
        {
            // TODO unit test for the property 'TitleVestedIn'
        }
        /// <summary>
        /// Test the property 'ToBeSold'
        /// </summary>
        [Test]
        public void ToBeSoldTest()
        {
            // TODO unit test for the property 'ToBeSold'
        }
        /// <summary>
        /// Test the property 'TotalClosingCost'
        /// </summary>
        [Test]
        public void TotalClosingCostTest()
        {
            // TODO unit test for the property 'TotalClosingCost'
        }
        /// <summary>
        /// Test the property 'TotalScorecardBy'
        /// </summary>
        [Test]
        public void TotalScorecardByTest()
        {
            // TODO unit test for the property 'TotalScorecardBy'
        }
        /// <summary>
        /// Test the property 'TotalScorecardDate'
        /// </summary>
        [Test]
        public void TotalScorecardDateTest()
        {
            // TODO unit test for the property 'TotalScorecardDate'
        }
        /// <summary>
        /// Test the property 'UFMIPRemittanceDueDate'
        /// </summary>
        [Test]
        public void UFMIPRemittanceDueDateTest()
        {
            // TODO unit test for the property 'UFMIPRemittanceDueDate'
        }
        /// <summary>
        /// Test the property 'UFMIPRemittedAmount'
        /// </summary>
        [Test]
        public void UFMIPRemittedAmountTest()
        {
            // TODO unit test for the property 'UFMIPRemittedAmount'
        }
        /// <summary>
        /// Test the property 'UFMIPRemittedBy'
        /// </summary>
        [Test]
        public void UFMIPRemittedByTest()
        {
            // TODO unit test for the property 'UFMIPRemittedBy'
        }
        /// <summary>
        /// Test the property 'UFMIPRemittedDate'
        /// </summary>
        [Test]
        public void UFMIPRemittedDateTest()
        {
            // TODO unit test for the property 'UFMIPRemittedDate'
        }
        /// <summary>
        /// Test the property 'UFMIPVerificationCode'
        /// </summary>
        [Test]
        public void UFMIPVerificationCodeTest()
        {
            // TODO unit test for the property 'UFMIPVerificationCode'
        }
        /// <summary>
        /// Test the property 'UseDefaultLenderInfo'
        /// </summary>
        [Test]
        public void UseDefaultLenderInfoTest()
        {
            // TODO unit test for the property 'UseDefaultLenderInfo'
        }
        /// <summary>
        /// Test the property 'UtilityIncluded'
        /// </summary>
        [Test]
        public void UtilityIncludedTest()
        {
            // TODO unit test for the property 'UtilityIncluded'
        }
        /// <summary>
        /// Test the property 'ValidateAddressDate'
        /// </summary>
        [Test]
        public void ValidateAddressDateTest()
        {
            // TODO unit test for the property 'ValidateAddressDate'
        }
        /// <summary>
        /// Test the property 'Valuation'
        /// </summary>
        [Test]
        public void ValuationTest()
        {
            // TODO unit test for the property 'Valuation'
        }
        /// <summary>
        /// Test the property 'AllConditionsSatisfied'
        /// </summary>
        [Test]
        public void AllConditionsSatisfiedTest()
        {
            // TODO unit test for the property 'AllConditionsSatisfied'
        }

    }

}
