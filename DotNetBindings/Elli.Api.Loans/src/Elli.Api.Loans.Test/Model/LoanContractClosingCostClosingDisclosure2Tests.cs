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
    ///  Class for testing LoanContractClosingCostClosingDisclosure2
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LoanContractClosingCostClosingDisclosure2Tests
    {
        // TODO uncomment below to declare an instance variable for LoanContractClosingCostClosingDisclosure2
        //private LoanContractClosingCostClosingDisclosure2 instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LoanContractClosingCostClosingDisclosure2
            //instance = new LoanContractClosingCostClosingDisclosure2();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoanContractClosingCostClosingDisclosure2
        /// </summary>
        [Test]
        public void LoanContractClosingCostClosingDisclosure2InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LoanContractClosingCostClosingDisclosure2
            //Assert.IsInstanceOfType<LoanContractClosingCostClosingDisclosure2> (instance, "variable 'instance' is a LoanContractClosingCostClosingDisclosure2");
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
        /// Test the property 'LCAtClosing'
        /// </summary>
        [Test]
        public void LCAtClosingTest()
        {
            // TODO unit test for the property 'LCAtClosing'
        }
        /// <summary>
        /// Test the property 'OriginationChargesSubTotal'
        /// </summary>
        [Test]
        public void OriginationChargesSubTotalTest()
        {
            // TODO unit test for the property 'OriginationChargesSubTotal'
        }
        /// <summary>
        /// Test the property 'ServicesDidNotShopSubTotal'
        /// </summary>
        [Test]
        public void ServicesDidNotShopSubTotalTest()
        {
            // TODO unit test for the property 'ServicesDidNotShopSubTotal'
        }
        /// <summary>
        /// Test the property 'ServicesDidShopSubTotal'
        /// </summary>
        [Test]
        public void ServicesDidShopSubTotalTest()
        {
            // TODO unit test for the property 'ServicesDidShopSubTotal'
        }
        /// <summary>
        /// Test the property 'TotalLoanCost'
        /// </summary>
        [Test]
        public void TotalLoanCostTest()
        {
            // TODO unit test for the property 'TotalLoanCost'
        }
        /// <summary>
        /// Test the property 'LastDisclosedLoanCosts'
        /// </summary>
        [Test]
        public void LastDisclosedLoanCostsTest()
        {
            // TODO unit test for the property 'LastDisclosedLoanCosts'
        }
        /// <summary>
        /// Test the property 'TotalBorrowerPaidAtClosing'
        /// </summary>
        [Test]
        public void TotalBorrowerPaidAtClosingTest()
        {
            // TODO unit test for the property 'TotalBorrowerPaidAtClosing'
        }
        /// <summary>
        /// Test the property 'TotalBorrowerPaidBeforeClosing'
        /// </summary>
        [Test]
        public void TotalBorrowerPaidBeforeClosingTest()
        {
            // TODO unit test for the property 'TotalBorrowerPaidBeforeClosing'
        }
        /// <summary>
        /// Test the property 'TaxesGovermentFeesSubTotal'
        /// </summary>
        [Test]
        public void TaxesGovermentFeesSubTotalTest()
        {
            // TODO unit test for the property 'TaxesGovermentFeesSubTotal'
        }
        /// <summary>
        /// Test the property 'PrepaidsSubTotal'
        /// </summary>
        [Test]
        public void PrepaidsSubTotalTest()
        {
            // TODO unit test for the property 'PrepaidsSubTotal'
        }
        /// <summary>
        /// Test the property 'InitialEscrowSubTotal'
        /// </summary>
        [Test]
        public void InitialEscrowSubTotalTest()
        {
            // TODO unit test for the property 'InitialEscrowSubTotal'
        }
        /// <summary>
        /// Test the property 'OtherSubTotal'
        /// </summary>
        [Test]
        public void OtherSubTotalTest()
        {
            // TODO unit test for the property 'OtherSubTotal'
        }
        /// <summary>
        /// Test the property 'TotalOtherCost'
        /// </summary>
        [Test]
        public void TotalOtherCostTest()
        {
            // TODO unit test for the property 'TotalOtherCost'
        }
        /// <summary>
        /// Test the property 'LastDisclosedOtherCosts'
        /// </summary>
        [Test]
        public void LastDisclosedOtherCostsTest()
        {
            // TODO unit test for the property 'LastDisclosedOtherCosts'
        }
        /// <summary>
        /// Test the property 'TotalOtherCostAtClosing'
        /// </summary>
        [Test]
        public void TotalOtherCostAtClosingTest()
        {
            // TODO unit test for the property 'TotalOtherCostAtClosing'
        }
        /// <summary>
        /// Test the property 'TotalOtherCostBeforeClosing'
        /// </summary>
        [Test]
        public void TotalOtherCostBeforeClosingTest()
        {
            // TODO unit test for the property 'TotalOtherCostBeforeClosing'
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
        /// Test the property 'BorrowerClosingCostAtClosing'
        /// </summary>
        [Test]
        public void BorrowerClosingCostAtClosingTest()
        {
            // TODO unit test for the property 'BorrowerClosingCostAtClosing'
        }
        /// <summary>
        /// Test the property 'BorrowerClosingCostBeforeClosing'
        /// </summary>
        [Test]
        public void BorrowerClosingCostBeforeClosingTest()
        {
            // TODO unit test for the property 'BorrowerClosingCostBeforeClosing'
        }
        /// <summary>
        /// Test the property 'SellerClosingCostAtClosing'
        /// </summary>
        [Test]
        public void SellerClosingCostAtClosingTest()
        {
            // TODO unit test for the property 'SellerClosingCostAtClosing'
        }
        /// <summary>
        /// Test the property 'SellerClosingCostBeforeClosing'
        /// </summary>
        [Test]
        public void SellerClosingCostBeforeClosingTest()
        {
            // TODO unit test for the property 'SellerClosingCostBeforeClosing'
        }
        /// <summary>
        /// Test the property 'ClosingCostPaidByOthers'
        /// </summary>
        [Test]
        public void ClosingCostPaidByOthersTest()
        {
            // TODO unit test for the property 'ClosingCostPaidByOthers'
        }
        /// <summary>
        /// Test the property 'ClosingCostLenderCredits'
        /// </summary>
        [Test]
        public void ClosingCostLenderCreditsTest()
        {
            // TODO unit test for the property 'ClosingCostLenderCredits'
        }
        /// <summary>
        /// Test the property 'LastDisclosedLenderCredits'
        /// </summary>
        [Test]
        public void LastDisclosedLenderCreditsTest()
        {
            // TODO unit test for the property 'LastDisclosedLenderCredits'
        }

    }

}
