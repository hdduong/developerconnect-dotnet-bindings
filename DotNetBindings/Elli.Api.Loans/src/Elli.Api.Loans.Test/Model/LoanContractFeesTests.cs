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
    ///  Class for testing LoanContractFees
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LoanContractFeesTests
    {
        // TODO uncomment below to declare an instance variable for LoanContractFees
        //private LoanContractFees instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LoanContractFees
            //instance = new LoanContractFees();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoanContractFees
        /// </summary>
        [Test]
        public void LoanContractFeesInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LoanContractFees
            //Assert.IsInstanceOfType<LoanContractFees> (instance, "variable 'instance' is a LoanContractFees");
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
        /// Test the property 'Amount'
        /// </summary>
        [Test]
        public void AmountTest()
        {
            // TODO unit test for the property 'Amount'
        }
        /// <summary>
        /// Test the property 'AmountPerDay'
        /// </summary>
        [Test]
        public void AmountPerDayTest()
        {
            // TODO unit test for the property 'AmountPerDay'
        }
        /// <summary>
        /// Test the property 'TruncatedAmountPerDay'
        /// </summary>
        [Test]
        public void TruncatedAmountPerDayTest()
        {
            // TODO unit test for the property 'TruncatedAmountPerDay'
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
        /// Test the property 'DateFrom'
        /// </summary>
        [Test]
        public void DateFromTest()
        {
            // TODO unit test for the property 'DateFrom'
        }
        /// <summary>
        /// Test the property 'DateTo'
        /// </summary>
        [Test]
        public void DateToTest()
        {
            // TODO unit test for the property 'DateTo'
        }
        /// <summary>
        /// Test the property 'Days'
        /// </summary>
        [Test]
        public void DaysTest()
        {
            // TODO unit test for the property 'Days'
        }
        /// <summary>
        /// Test the property 'DeedAmount'
        /// </summary>
        [Test]
        public void DeedAmountTest()
        {
            // TODO unit test for the property 'DeedAmount'
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
        /// Test the property 'FeeType'
        /// </summary>
        [Test]
        public void FeeTypeTest()
        {
            // TODO unit test for the property 'FeeType'
        }
        /// <summary>
        /// Test the property 'FHA'
        /// </summary>
        [Test]
        public void FHATest()
        {
            // TODO unit test for the property 'FHA'
        }
        /// <summary>
        /// Test the property 'FWBC'
        /// </summary>
        [Test]
        public void FWBCTest()
        {
            // TODO unit test for the property 'FWBC'
        }
        /// <summary>
        /// Test the property 'FWSC'
        /// </summary>
        [Test]
        public void FWSCTest()
        {
            // TODO unit test for the property 'FWSC'
        }
        /// <summary>
        /// Test the property 'IncludeAboveNumber'
        /// </summary>
        [Test]
        public void IncludeAboveNumberTest()
        {
            // TODO unit test for the property 'IncludeAboveNumber'
        }
        /// <summary>
        /// Test the property 'LenderCoverage'
        /// </summary>
        [Test]
        public void LenderCoverageTest()
        {
            // TODO unit test for the property 'LenderCoverage'
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
        /// Test the property 'MortgageAmount'
        /// </summary>
        [Test]
        public void MortgageAmountTest()
        {
            // TODO unit test for the property 'MortgageAmount'
        }
        /// <summary>
        /// Test the property 'NewHUDBorPaidAmount'
        /// </summary>
        [Test]
        public void NewHUDBorPaidAmountTest()
        {
            // TODO unit test for the property 'NewHUDBorPaidAmount'
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
        /// Test the property 'OwnerCoverage'
        /// </summary>
        [Test]
        public void OwnerCoverageTest()
        {
            // TODO unit test for the property 'OwnerCoverage'
        }
        /// <summary>
        /// Test the property 'PaidBy'
        /// </summary>
        [Test]
        public void PaidByTest()
        {
            // TODO unit test for the property 'PaidBy'
        }
        /// <summary>
        /// Test the property 'PaidInAdvance'
        /// </summary>
        [Test]
        public void PaidInAdvanceTest()
        {
            // TODO unit test for the property 'PaidInAdvance'
        }
        /// <summary>
        /// Test the property 'PaidToBroker'
        /// </summary>
        [Test]
        public void PaidToBrokerTest()
        {
            // TODO unit test for the property 'PaidToBroker'
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
        /// Test the property 'PaidToOthers'
        /// </summary>
        [Test]
        public void PaidToOthersTest()
        {
            // TODO unit test for the property 'PaidToOthers'
        }
        /// <summary>
        /// Test the property 'Percentage'
        /// </summary>
        [Test]
        public void PercentageTest()
        {
            // TODO unit test for the property 'Percentage'
        }
        /// <summary>
        /// Test the property 'PFC'
        /// </summary>
        [Test]
        public void PFCTest()
        {
            // TODO unit test for the property 'PFC'
        }
        /// <summary>
        /// Test the property 'POC'
        /// </summary>
        [Test]
        public void POCTest()
        {
            // TODO unit test for the property 'POC'
        }
        /// <summary>
        /// Test the property 'PTB'
        /// </summary>
        [Test]
        public void PTBTest()
        {
            // TODO unit test for the property 'PTB'
        }
        /// <summary>
        /// Test the property 'ReleasesAmount'
        /// </summary>
        [Test]
        public void ReleasesAmountTest()
        {
            // TODO unit test for the property 'ReleasesAmount'
        }
        /// <summary>
        /// Test the property 'SellerPaidAmount'
        /// </summary>
        [Test]
        public void SellerPaidAmountTest()
        {
            // TODO unit test for the property 'SellerPaidAmount'
        }
        /// <summary>
        /// Test the property 'Use4Decimals'
        /// </summary>
        [Test]
        public void Use4DecimalsTest()
        {
            // TODO unit test for the property 'Use4Decimals'
        }

    }

}
