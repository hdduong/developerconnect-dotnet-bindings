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
    ///  Class for testing LoanContractClosingCost
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LoanContractClosingCostTests
    {
        // TODO uncomment below to declare an instance variable for LoanContractClosingCost
        //private LoanContractClosingCost instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LoanContractClosingCost
            //instance = new LoanContractClosingCost();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoanContractClosingCost
        /// </summary>
        [Test]
        public void LoanContractClosingCostInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LoanContractClosingCost
            //Assert.IsInstanceOfType<LoanContractClosingCost> (instance, "variable 'instance' is a LoanContractClosingCost");
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
        /// Test the property 'AdjustmentFactor'
        /// </summary>
        [Test]
        public void AdjustmentFactorTest()
        {
            // TODO unit test for the property 'AdjustmentFactor'
        }
        /// <summary>
        /// Test the property 'AggregateAdjustmentFwbc'
        /// </summary>
        [Test]
        public void AggregateAdjustmentFwbcTest()
        {
            // TODO unit test for the property 'AggregateAdjustmentFwbc'
        }
        /// <summary>
        /// Test the property 'BorrowerPaidDiscountPointsTotalAmount'
        /// </summary>
        [Test]
        public void BorrowerPaidDiscountPointsTotalAmountTest()
        {
            // TODO unit test for the property 'BorrowerPaidDiscountPointsTotalAmount'
        }
        /// <summary>
        /// Test the property 'BrokerCommissionBasedPrice'
        /// </summary>
        [Test]
        public void BrokerCommissionBasedPriceTest()
        {
            // TODO unit test for the property 'BrokerCommissionBasedPrice'
        }
        /// <summary>
        /// Test the property 'BrokerCommissionBasedUnitPercentage'
        /// </summary>
        [Test]
        public void BrokerCommissionBasedUnitPercentageTest()
        {
            // TODO unit test for the property 'BrokerCommissionBasedUnitPercentage'
        }
        /// <summary>
        /// Test the property 'BrokerCommissionBasedUnitPrice'
        /// </summary>
        [Test]
        public void BrokerCommissionBasedUnitPriceTest()
        {
            // TODO unit test for the property 'BrokerCommissionBasedUnitPrice'
        }
        /// <summary>
        /// Test the property 'ClosingCostProgram'
        /// </summary>
        [Test]
        public void ClosingCostProgramTest()
        {
            // TODO unit test for the property 'ClosingCostProgram'
        }
        /// <summary>
        /// Test the property 'ClosingCostScenarioXml'
        /// </summary>
        [Test]
        public void ClosingCostScenarioXmlTest()
        {
            // TODO unit test for the property 'ClosingCostScenarioXml'
        }
        /// <summary>
        /// Test the property 'EscrowCompanyName'
        /// </summary>
        [Test]
        public void EscrowCompanyNameTest()
        {
            // TODO unit test for the property 'EscrowCompanyName'
        }
        /// <summary>
        /// Test the property 'EscrowTableDesc1'
        /// </summary>
        [Test]
        public void EscrowTableDesc1Test()
        {
            // TODO unit test for the property 'EscrowTableDesc1'
        }
        /// <summary>
        /// Test the property 'EscrowTableDesc2'
        /// </summary>
        [Test]
        public void EscrowTableDesc2Test()
        {
            // TODO unit test for the property 'EscrowTableDesc2'
        }
        /// <summary>
        /// Test the property 'EscrowTableDesc3'
        /// </summary>
        [Test]
        public void EscrowTableDesc3Test()
        {
            // TODO unit test for the property 'EscrowTableDesc3'
        }
        /// <summary>
        /// Test the property 'EscrowTableDesc4'
        /// </summary>
        [Test]
        public void EscrowTableDesc4Test()
        {
            // TODO unit test for the property 'EscrowTableDesc4'
        }
        /// <summary>
        /// Test the property 'EscrowTableDesc5'
        /// </summary>
        [Test]
        public void EscrowTableDesc5Test()
        {
            // TODO unit test for the property 'EscrowTableDesc5'
        }
        /// <summary>
        /// Test the property 'EscrowTableFee'
        /// </summary>
        [Test]
        public void EscrowTableFeeTest()
        {
            // TODO unit test for the property 'EscrowTableFee'
        }
        /// <summary>
        /// Test the property 'EscrowTableFee1'
        /// </summary>
        [Test]
        public void EscrowTableFee1Test()
        {
            // TODO unit test for the property 'EscrowTableFee1'
        }
        /// <summary>
        /// Test the property 'EscrowTableFee2'
        /// </summary>
        [Test]
        public void EscrowTableFee2Test()
        {
            // TODO unit test for the property 'EscrowTableFee2'
        }
        /// <summary>
        /// Test the property 'EscrowTableFee3'
        /// </summary>
        [Test]
        public void EscrowTableFee3Test()
        {
            // TODO unit test for the property 'EscrowTableFee3'
        }
        /// <summary>
        /// Test the property 'EscrowTableFee4'
        /// </summary>
        [Test]
        public void EscrowTableFee4Test()
        {
            // TODO unit test for the property 'EscrowTableFee4'
        }
        /// <summary>
        /// Test the property 'EscrowTableFee5'
        /// </summary>
        [Test]
        public void EscrowTableFee5Test()
        {
            // TODO unit test for the property 'EscrowTableFee5'
        }
        /// <summary>
        /// Test the property 'EscrowTableName'
        /// </summary>
        [Test]
        public void EscrowTableNameTest()
        {
            // TODO unit test for the property 'EscrowTableName'
        }
        /// <summary>
        /// Test the property 'ClosingDisclosure5'
        /// </summary>
        [Test]
        public void ClosingDisclosure5Test()
        {
            // TODO unit test for the property 'ClosingDisclosure5'
        }
        /// <summary>
        /// Test the property 'Gfe2010'
        /// </summary>
        [Test]
        public void Gfe2010Test()
        {
            // TODO unit test for the property 'Gfe2010'
        }
        /// <summary>
        /// Test the property 'Gfe2010Page'
        /// </summary>
        [Test]
        public void Gfe2010PageTest()
        {
            // TODO unit test for the property 'Gfe2010Page'
        }
        /// <summary>
        /// Test the property 'Gfe2010Section'
        /// </summary>
        [Test]
        public void Gfe2010SectionTest()
        {
            // TODO unit test for the property 'Gfe2010Section'
        }
        /// <summary>
        /// Test the property 'ImpoundHazInsRate'
        /// </summary>
        [Test]
        public void ImpoundHazInsRateTest()
        {
            // TODO unit test for the property 'ImpoundHazInsRate'
        }
        /// <summary>
        /// Test the property 'ImpoundMortgInsPremRate'
        /// </summary>
        [Test]
        public void ImpoundMortgInsPremRateTest()
        {
            // TODO unit test for the property 'ImpoundMortgInsPremRate'
        }
        /// <summary>
        /// Test the property 'ImpoundMortgInsPremYearlyBasis'
        /// </summary>
        [Test]
        public void ImpoundMortgInsPremYearlyBasisTest()
        {
            // TODO unit test for the property 'ImpoundMortgInsPremYearlyBasis'
        }
        /// <summary>
        /// Test the property 'ImpoundTaxesRate'
        /// </summary>
        [Test]
        public void ImpoundTaxesRateTest()
        {
            // TODO unit test for the property 'ImpoundTaxesRate'
        }
        /// <summary>
        /// Test the property 'ImpoundType1'
        /// </summary>
        [Test]
        public void ImpoundType1Test()
        {
            // TODO unit test for the property 'ImpoundType1'
        }
        /// <summary>
        /// Test the property 'ImpoundType2'
        /// </summary>
        [Test]
        public void ImpoundType2Test()
        {
            // TODO unit test for the property 'ImpoundType2'
        }
        /// <summary>
        /// Test the property 'ImpoundType3'
        /// </summary>
        [Test]
        public void ImpoundType3Test()
        {
            // TODO unit test for the property 'ImpoundType3'
        }
        /// <summary>
        /// Test the property 'ImpoundType4'
        /// </summary>
        [Test]
        public void ImpoundType4Test()
        {
            // TODO unit test for the property 'ImpoundType4'
        }
        /// <summary>
        /// Test the property 'ProposedMonthlyHazardInsurance'
        /// </summary>
        [Test]
        public void ProposedMonthlyHazardInsuranceTest()
        {
            // TODO unit test for the property 'ProposedMonthlyHazardInsurance'
        }
        /// <summary>
        /// Test the property 'ProposedMonthlyMortgageInsurance'
        /// </summary>
        [Test]
        public void ProposedMonthlyMortgageInsuranceTest()
        {
            // TODO unit test for the property 'ProposedMonthlyMortgageInsurance'
        }
        /// <summary>
        /// Test the property 'Section1000BorrowerPaidTotalAmount'
        /// </summary>
        [Test]
        public void Section1000BorrowerPaidTotalAmountTest()
        {
            // TODO unit test for the property 'Section1000BorrowerPaidTotalAmount'
        }
        /// <summary>
        /// Test the property 'Section1000SellerPaidTotalAmount'
        /// </summary>
        [Test]
        public void Section1000SellerPaidTotalAmountTest()
        {
            // TODO unit test for the property 'Section1000SellerPaidTotalAmount'
        }
        /// <summary>
        /// Test the property 'SettlementClosingFeeNewHudBorPaidAmount'
        /// </summary>
        [Test]
        public void SettlementClosingFeeNewHudBorPaidAmountTest()
        {
            // TODO unit test for the property 'SettlementClosingFeeNewHudBorPaidAmount'
        }
        /// <summary>
        /// Test the property 'SettlementClosingFeeNewHudSelPaidAmount'
        /// </summary>
        [Test]
        public void SettlementClosingFeeNewHudSelPaidAmountTest()
        {
            // TODO unit test for the property 'SettlementClosingFeeNewHudSelPaidAmount'
        }
        /// <summary>
        /// Test the property 'TitleCompanyName'
        /// </summary>
        [Test]
        public void TitleCompanyNameTest()
        {
            // TODO unit test for the property 'TitleCompanyName'
        }
        /// <summary>
        /// Test the property 'TitleExaminationNewHudSelPaidAmount'
        /// </summary>
        [Test]
        public void TitleExaminationNewHudSelPaidAmountTest()
        {
            // TODO unit test for the property 'TitleExaminationNewHudSelPaidAmount'
        }
        /// <summary>
        /// Test the property 'TitleTable2010Name'
        /// </summary>
        [Test]
        public void TitleTable2010NameTest()
        {
            // TODO unit test for the property 'TitleTable2010Name'
        }
        /// <summary>
        /// Test the property 'TitleTableName'
        /// </summary>
        [Test]
        public void TitleTableNameTest()
        {
            // TODO unit test for the property 'TitleTableName'
        }
        /// <summary>
        /// Test the property 'TotalForBorPaid1'
        /// </summary>
        [Test]
        public void TotalForBorPaid1Test()
        {
            // TODO unit test for the property 'TotalForBorPaid1'
        }
        /// <summary>
        /// Test the property 'TotalForBorPaid2'
        /// </summary>
        [Test]
        public void TotalForBorPaid2Test()
        {
            // TODO unit test for the property 'TotalForBorPaid2'
        }
        /// <summary>
        /// Test the property 'TotalForBorPaid3'
        /// </summary>
        [Test]
        public void TotalForBorPaid3Test()
        {
            // TODO unit test for the property 'TotalForBorPaid3'
        }
        /// <summary>
        /// Test the property 'TotalForBorPaid4'
        /// </summary>
        [Test]
        public void TotalForBorPaid4Test()
        {
            // TODO unit test for the property 'TotalForBorPaid4'
        }
        /// <summary>
        /// Test the property 'TotalForBorPaid5'
        /// </summary>
        [Test]
        public void TotalForBorPaid5Test()
        {
            // TODO unit test for the property 'TotalForBorPaid5'
        }
        /// <summary>
        /// Test the property 'TotalForBorPaid6'
        /// </summary>
        [Test]
        public void TotalForBorPaid6Test()
        {
            // TODO unit test for the property 'TotalForBorPaid6'
        }
        /// <summary>
        /// Test the property 'TotalForSellerPaid1'
        /// </summary>
        [Test]
        public void TotalForSellerPaid1Test()
        {
            // TODO unit test for the property 'TotalForSellerPaid1'
        }
        /// <summary>
        /// Test the property 'TotalForSellerPaid2'
        /// </summary>
        [Test]
        public void TotalForSellerPaid2Test()
        {
            // TODO unit test for the property 'TotalForSellerPaid2'
        }
        /// <summary>
        /// Test the property 'TotalForSellerPaid3'
        /// </summary>
        [Test]
        public void TotalForSellerPaid3Test()
        {
            // TODO unit test for the property 'TotalForSellerPaid3'
        }
        /// <summary>
        /// Test the property 'TotalForSellerPaid4'
        /// </summary>
        [Test]
        public void TotalForSellerPaid4Test()
        {
            // TODO unit test for the property 'TotalForSellerPaid4'
        }
        /// <summary>
        /// Test the property 'TotalForSellerPaid5'
        /// </summary>
        [Test]
        public void TotalForSellerPaid5Test()
        {
            // TODO unit test for the property 'TotalForSellerPaid5'
        }
        /// <summary>
        /// Test the property 'TotalForSellerPaid6'
        /// </summary>
        [Test]
        public void TotalForSellerPaid6Test()
        {
            // TODO unit test for the property 'TotalForSellerPaid6'
        }
        /// <summary>
        /// Test the property 'LoanEstimate1'
        /// </summary>
        [Test]
        public void LoanEstimate1Test()
        {
            // TODO unit test for the property 'LoanEstimate1'
        }
        /// <summary>
        /// Test the property 'LoanEstimate2'
        /// </summary>
        [Test]
        public void LoanEstimate2Test()
        {
            // TODO unit test for the property 'LoanEstimate2'
        }
        /// <summary>
        /// Test the property 'LoanEstimate3'
        /// </summary>
        [Test]
        public void LoanEstimate3Test()
        {
            // TODO unit test for the property 'LoanEstimate3'
        }
        /// <summary>
        /// Test the property 'ClosingDisclosure1'
        /// </summary>
        [Test]
        public void ClosingDisclosure1Test()
        {
            // TODO unit test for the property 'ClosingDisclosure1'
        }
        /// <summary>
        /// Test the property 'ClosingDisclosure2'
        /// </summary>
        [Test]
        public void ClosingDisclosure2Test()
        {
            // TODO unit test for the property 'ClosingDisclosure2'
        }
        /// <summary>
        /// Test the property 'ClosingDisclosure3'
        /// </summary>
        [Test]
        public void ClosingDisclosure3Test()
        {
            // TODO unit test for the property 'ClosingDisclosure3'
        }
        /// <summary>
        /// Test the property 'ClosingDisclosure4'
        /// </summary>
        [Test]
        public void ClosingDisclosure4Test()
        {
            // TODO unit test for the property 'ClosingDisclosure4'
        }
        /// <summary>
        /// Test the property 'FeeVarianceOther'
        /// </summary>
        [Test]
        public void FeeVarianceOtherTest()
        {
            // TODO unit test for the property 'FeeVarianceOther'
        }
        /// <summary>
        /// Test the property 'FeeVariances'
        /// </summary>
        [Test]
        public void FeeVariancesTest()
        {
            // TODO unit test for the property 'FeeVariances'
        }

    }

}
