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
    ///  Class for testing LoanContractClosingCostGfe2010Gfe2010Fees
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LoanContractClosingCostGfe2010Gfe2010FeesTests
    {
        // TODO uncomment below to declare an instance variable for LoanContractClosingCostGfe2010Gfe2010Fees
        //private LoanContractClosingCostGfe2010Gfe2010Fees instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LoanContractClosingCostGfe2010Gfe2010Fees
            //instance = new LoanContractClosingCostGfe2010Gfe2010Fees();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoanContractClosingCostGfe2010Gfe2010Fees
        /// </summary>
        [Test]
        public void LoanContractClosingCostGfe2010Gfe2010FeesInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LoanContractClosingCostGfe2010Gfe2010Fees
            //Assert.IsInstanceOfType<LoanContractClosingCostGfe2010Gfe2010Fees> (instance, "variable 'instance' is a LoanContractClosingCostGfe2010Gfe2010Fees");
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
        /// Test the property 'AdditionalAmount'
        /// </summary>
        [Test]
        public void AdditionalAmountTest()
        {
            // TODO unit test for the property 'AdditionalAmount'
        }
        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Test]
        public void AmountTest()
        {
            // TODO unit test for the property 'Amount'
        }
        /// <summary>
        /// Test the property 'AprIndicator'
        /// </summary>
        [Test]
        public void AprIndicatorTest()
        {
            // TODO unit test for the property 'AprIndicator'
        }
        /// <summary>
        /// Test the property 'BorPaidAmount'
        /// </summary>
        [Test]
        public void BorPaidAmountTest()
        {
            // TODO unit test for the property 'BorPaidAmount'
        }
        /// <summary>
        /// Test the property 'BorrowerSelectIndicator'
        /// </summary>
        [Test]
        public void BorrowerSelectIndicatorTest()
        {
            // TODO unit test for the property 'BorrowerSelectIndicator'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'FinancedIndicator'
        /// </summary>
        [Test]
        public void FinancedIndicatorTest()
        {
            // TODO unit test for the property 'FinancedIndicator'
        }
        /// <summary>
        /// Test the property 'Gfe2010FeeIndex'
        /// </summary>
        [Test]
        public void Gfe2010FeeIndexTest()
        {
            // TODO unit test for the property 'Gfe2010FeeIndex'
        }
        /// <summary>
        /// Test the property 'Gfe2010FeeParentType'
        /// </summary>
        [Test]
        public void Gfe2010FeeParentTypeTest()
        {
            // TODO unit test for the property 'Gfe2010FeeParentType'
        }
        /// <summary>
        /// Test the property 'Gfe2010FeeType'
        /// </summary>
        [Test]
        public void Gfe2010FeeTypeTest()
        {
            // TODO unit test for the property 'Gfe2010FeeType'
        }
        /// <summary>
        /// Test the property 'GfeAmount'
        /// </summary>
        [Test]
        public void GfeAmountTest()
        {
            // TODO unit test for the property 'GfeAmount'
        }
        /// <summary>
        /// Test the property 'PaidByType'
        /// </summary>
        [Test]
        public void PaidByTypeTest()
        {
            // TODO unit test for the property 'PaidByType'
        }
        /// <summary>
        /// Test the property 'PaidToName'
        /// </summary>
        [Test]
        public void PaidToNameTest()
        {
            // TODO unit test for the property 'PaidToName'
        }
        /// <summary>
        /// Test the property 'PocPtcIndicator'
        /// </summary>
        [Test]
        public void PocPtcIndicatorTest()
        {
            // TODO unit test for the property 'PocPtcIndicator'
        }
        /// <summary>
        /// Test the property 'PtbType'
        /// </summary>
        [Test]
        public void PtbTypeTest()
        {
            // TODO unit test for the property 'PtbType'
        }
        /// <summary>
        /// Test the property 'Rate'
        /// </summary>
        [Test]
        public void RateTest()
        {
            // TODO unit test for the property 'Rate'
        }
        /// <summary>
        /// Test the property 'SelPaidAmount'
        /// </summary>
        [Test]
        public void SelPaidAmountTest()
        {
            // TODO unit test for the property 'SelPaidAmount'
        }
        /// <summary>
        /// Test the property 'TitleServiceSelectIndicator'
        /// </summary>
        [Test]
        public void TitleServiceSelectIndicatorTest()
        {
            // TODO unit test for the property 'TitleServiceSelectIndicator'
        }
        /// <summary>
        /// Test the property 'WholePoc'
        /// </summary>
        [Test]
        public void WholePocTest()
        {
            // TODO unit test for the property 'WholePoc'
        }
        /// <summary>
        /// Test the property 'WholePocPaidByType'
        /// </summary>
        [Test]
        public void WholePocPaidByTypeTest()
        {
            // TODO unit test for the property 'WholePocPaidByType'
        }
        /// <summary>
        /// Test the property 'TotalFeeAmount2015'
        /// </summary>
        [Test]
        public void TotalFeeAmount2015Test()
        {
            // TODO unit test for the property 'TotalFeeAmount2015'
        }
        /// <summary>
        /// Test the property 'TotalFeePercentage2015'
        /// </summary>
        [Test]
        public void TotalFeePercentage2015Test()
        {
            // TODO unit test for the property 'TotalFeePercentage2015'
        }
        /// <summary>
        /// Test the property 'LastDisclosedLoanEstimate2015'
        /// </summary>
        [Test]
        public void LastDisclosedLoanEstimate2015Test()
        {
            // TODO unit test for the property 'LastDisclosedLoanEstimate2015'
        }
        /// <summary>
        /// Test the property 'LastDisclosedClosingDisclosure2015'
        /// </summary>
        [Test]
        public void LastDisclosedClosingDisclosure2015Test()
        {
            // TODO unit test for the property 'LastDisclosedClosingDisclosure2015'
        }
        /// <summary>
        /// Test the property 'BorrowerFinanced2015'
        /// </summary>
        [Test]
        public void BorrowerFinanced2015Test()
        {
            // TODO unit test for the property 'BorrowerFinanced2015'
        }
        /// <summary>
        /// Test the property 'BorrowerPTC2015'
        /// </summary>
        [Test]
        public void BorrowerPTC2015Test()
        {
            // TODO unit test for the property 'BorrowerPTC2015'
        }
        /// <summary>
        /// Test the property 'BorrowerPAC2015'
        /// </summary>
        [Test]
        public void BorrowerPAC2015Test()
        {
            // TODO unit test for the property 'BorrowerPAC2015'
        }
        /// <summary>
        /// Test the property 'BorrowerPOC2015'
        /// </summary>
        [Test]
        public void BorrowerPOC2015Test()
        {
            // TODO unit test for the property 'BorrowerPOC2015'
        }
        /// <summary>
        /// Test the property 'BorrowerAmountPaid2015'
        /// </summary>
        [Test]
        public void BorrowerAmountPaid2015Test()
        {
            // TODO unit test for the property 'BorrowerAmountPaid2015'
        }
        /// <summary>
        /// Test the property 'SellerPAC2015'
        /// </summary>
        [Test]
        public void SellerPAC2015Test()
        {
            // TODO unit test for the property 'SellerPAC2015'
        }
        /// <summary>
        /// Test the property 'SellerPOC2015'
        /// </summary>
        [Test]
        public void SellerPOC2015Test()
        {
            // TODO unit test for the property 'SellerPOC2015'
        }
        /// <summary>
        /// Test the property 'SellerAmountPaid2015'
        /// </summary>
        [Test]
        public void SellerAmountPaid2015Test()
        {
            // TODO unit test for the property 'SellerAmountPaid2015'
        }
        /// <summary>
        /// Test the property 'BrokerPAC2015'
        /// </summary>
        [Test]
        public void BrokerPAC2015Test()
        {
            // TODO unit test for the property 'BrokerPAC2015'
        }
        /// <summary>
        /// Test the property 'BrokerPOC2015'
        /// </summary>
        [Test]
        public void BrokerPOC2015Test()
        {
            // TODO unit test for the property 'BrokerPOC2015'
        }
        /// <summary>
        /// Test the property 'BrokerAmountPaid2015'
        /// </summary>
        [Test]
        public void BrokerAmountPaid2015Test()
        {
            // TODO unit test for the property 'BrokerAmountPaid2015'
        }
        /// <summary>
        /// Test the property 'LenderPAC2015'
        /// </summary>
        [Test]
        public void LenderPAC2015Test()
        {
            // TODO unit test for the property 'LenderPAC2015'
        }
        /// <summary>
        /// Test the property 'LenderPOC2015'
        /// </summary>
        [Test]
        public void LenderPOC2015Test()
        {
            // TODO unit test for the property 'LenderPOC2015'
        }
        /// <summary>
        /// Test the property 'LenderAmountPaid2015'
        /// </summary>
        [Test]
        public void LenderAmountPaid2015Test()
        {
            // TODO unit test for the property 'LenderAmountPaid2015'
        }
        /// <summary>
        /// Test the property 'OtherPAC2015'
        /// </summary>
        [Test]
        public void OtherPAC2015Test()
        {
            // TODO unit test for the property 'OtherPAC2015'
        }
        /// <summary>
        /// Test the property 'OtherPOC2015'
        /// </summary>
        [Test]
        public void OtherPOC2015Test()
        {
            // TODO unit test for the property 'OtherPOC2015'
        }
        /// <summary>
        /// Test the property 'OtherAmountPaid2015'
        /// </summary>
        [Test]
        public void OtherAmountPaid2015Test()
        {
            // TODO unit test for the property 'OtherAmountPaid2015'
        }
        /// <summary>
        /// Test the property 'TotalPaidByBLO2015'
        /// </summary>
        [Test]
        public void TotalPaidByBLO2015Test()
        {
            // TODO unit test for the property 'TotalPaidByBLO2015'
        }
        /// <summary>
        /// Test the property 'BorrowerCanShopForIndicator2015'
        /// </summary>
        [Test]
        public void BorrowerCanShopForIndicator2015Test()
        {
            // TODO unit test for the property 'BorrowerCanShopForIndicator2015'
        }
        /// <summary>
        /// Test the property 'BorrowerDidShopForIndicator2015'
        /// </summary>
        [Test]
        public void BorrowerDidShopForIndicator2015Test()
        {
            // TODO unit test for the property 'BorrowerDidShopForIndicator2015'
        }
        /// <summary>
        /// Test the property 'SellerCreditIndicator2015'
        /// </summary>
        [Test]
        public void SellerCreditIndicator2015Test()
        {
            // TODO unit test for the property 'SellerCreditIndicator2015'
        }
        /// <summary>
        /// Test the property 'SellerObligatedIndicator2015'
        /// </summary>
        [Test]
        public void SellerObligatedIndicator2015Test()
        {
            // TODO unit test for the property 'SellerObligatedIndicator2015'
        }
        /// <summary>
        /// Test the property 'SellerObligatedAmount2015'
        /// </summary>
        [Test]
        public void SellerObligatedAmount2015Test()
        {
            // TODO unit test for the property 'SellerObligatedAmount2015'
        }
        /// <summary>
        /// Test the property 'Sec32PointsAndFees2015'
        /// </summary>
        [Test]
        public void Sec32PointsAndFees2015Test()
        {
            // TODO unit test for the property 'Sec32PointsAndFees2015'
        }
        /// <summary>
        /// Test the property 'RetainedAmount2015'
        /// </summary>
        [Test]
        public void RetainedAmount2015Test()
        {
            // TODO unit test for the property 'RetainedAmount2015'
        }
        /// <summary>
        /// Test the property 'OptionalIndicator2015'
        /// </summary>
        [Test]
        public void OptionalIndicator2015Test()
        {
            // TODO unit test for the property 'OptionalIndicator2015'
        }
        /// <summary>
        /// Test the property 'NumberOfMonths'
        /// </summary>
        [Test]
        public void NumberOfMonthsTest()
        {
            // TODO unit test for the property 'NumberOfMonths'
        }
        /// <summary>
        /// Test the property 'MonthlyPayment'
        /// </summary>
        [Test]
        public void MonthlyPaymentTest()
        {
            // TODO unit test for the property 'MonthlyPayment'
        }
        /// <summary>
        /// Test the property 'InsuranceIndicator2015'
        /// </summary>
        [Test]
        public void InsuranceIndicator2015Test()
        {
            // TODO unit test for the property 'InsuranceIndicator2015'
        }
        /// <summary>
        /// Test the property 'TaxesIndicator2015'
        /// </summary>
        [Test]
        public void TaxesIndicator2015Test()
        {
            // TODO unit test for the property 'TaxesIndicator2015'
        }
        /// <summary>
        /// Test the property 'EscrowedIndicator2015'
        /// </summary>
        [Test]
        public void EscrowedIndicator2015Test()
        {
            // TODO unit test for the property 'EscrowedIndicator2015'
        }
        /// <summary>
        /// Test the property 'PropertyIndicator2015'
        /// </summary>
        [Test]
        public void PropertyIndicator2015Test()
        {
            // TODO unit test for the property 'PropertyIndicator2015'
        }
        /// <summary>
        /// Test the property 'SimultaneousIssuanceIndicator2015'
        /// </summary>
        [Test]
        public void SimultaneousIssuanceIndicator2015Test()
        {
            // TODO unit test for the property 'SimultaneousIssuanceIndicator2015'
        }
        /// <summary>
        /// Test the property 'UndiscountedInsurance2015'
        /// </summary>
        [Test]
        public void UndiscountedInsurance2015Test()
        {
            // TODO unit test for the property 'UndiscountedInsurance2015'
        }

    }

}
