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
    ///  Class for testing LoanContractTQLReports
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LoanContractTQLReportsTests
    {
        // TODO uncomment below to declare an instance variable for LoanContractTQLReports
        //private LoanContractTQLReports instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LoanContractTQLReports
            //instance = new LoanContractTQLReports();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoanContractTQLReports
        /// </summary>
        [Test]
        public void LoanContractTQLReportsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LoanContractTQLReports
            //Assert.IsInstanceOfType<LoanContractTQLReports> (instance, "variable 'instance' is a LoanContractTQLReports");
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
        /// Test the property 'AltId'
        /// </summary>
        [Test]
        public void AltIdTest()
        {
            // TODO unit test for the property 'AltId'
        }
        /// <summary>
        /// Test the property 'BorrowerID1'
        /// </summary>
        [Test]
        public void BorrowerID1Test()
        {
            // TODO unit test for the property 'BorrowerID1'
        }
        /// <summary>
        /// Test the property 'BorrowerID2'
        /// </summary>
        [Test]
        public void BorrowerID2Test()
        {
            // TODO unit test for the property 'BorrowerID2'
        }
        /// <summary>
        /// Test the property 'BorrowerID3'
        /// </summary>
        [Test]
        public void BorrowerID3Test()
        {
            // TODO unit test for the property 'BorrowerID3'
        }
        /// <summary>
        /// Test the property 'BorrowerID4'
        /// </summary>
        [Test]
        public void BorrowerID4Test()
        {
            // TODO unit test for the property 'BorrowerID4'
        }
        /// <summary>
        /// Test the property 'CompletedDate'
        /// </summary>
        [Test]
        public void CompletedDateTest()
        {
            // TODO unit test for the property 'CompletedDate'
        }
        /// <summary>
        /// Test the property 'Investor'
        /// </summary>
        [Test]
        public void InvestorTest()
        {
            // TODO unit test for the property 'Investor'
        }
        /// <summary>
        /// Test the property 'OrderDate'
        /// </summary>
        [Test]
        public void OrderDateTest()
        {
            // TODO unit test for the property 'OrderDate'
        }
        /// <summary>
        /// Test the property 'OrderNumber'
        /// </summary>
        [Test]
        public void OrderNumberTest()
        {
            // TODO unit test for the property 'OrderNumber'
        }
        /// <summary>
        /// Test the property 'OrderStatus'
        /// </summary>
        [Test]
        public void OrderStatusTest()
        {
            // TODO unit test for the property 'OrderStatus'
        }
        /// <summary>
        /// Test the property 'PercentVariance1'
        /// </summary>
        [Test]
        public void PercentVariance1Test()
        {
            // TODO unit test for the property 'PercentVariance1'
        }
        /// <summary>
        /// Test the property 'PercentVariance2'
        /// </summary>
        [Test]
        public void PercentVariance2Test()
        {
            // TODO unit test for the property 'PercentVariance2'
        }
        /// <summary>
        /// Test the property 'PercentVariance3'
        /// </summary>
        [Test]
        public void PercentVariance3Test()
        {
            // TODO unit test for the property 'PercentVariance3'
        }
        /// <summary>
        /// Test the property 'PercentVariance4'
        /// </summary>
        [Test]
        public void PercentVariance4Test()
        {
            // TODO unit test for the property 'PercentVariance4'
        }
        /// <summary>
        /// Test the property 'ProductsOrdered'
        /// </summary>
        [Test]
        public void ProductsOrderedTest()
        {
            // TODO unit test for the property 'ProductsOrdered'
        }
        /// <summary>
        /// Test the property 'ReportYear1'
        /// </summary>
        [Test]
        public void ReportYear1Test()
        {
            // TODO unit test for the property 'ReportYear1'
        }
        /// <summary>
        /// Test the property 'ReportYear2'
        /// </summary>
        [Test]
        public void ReportYear2Test()
        {
            // TODO unit test for the property 'ReportYear2'
        }
        /// <summary>
        /// Test the property 'ReportYear3'
        /// </summary>
        [Test]
        public void ReportYear3Test()
        {
            // TODO unit test for the property 'ReportYear3'
        }
        /// <summary>
        /// Test the property 'ReportYear4'
        /// </summary>
        [Test]
        public void ReportYear4Test()
        {
            // TODO unit test for the property 'ReportYear4'
        }
        /// <summary>
        /// Test the property 'TotalIncome1'
        /// </summary>
        [Test]
        public void TotalIncome1Test()
        {
            // TODO unit test for the property 'TotalIncome1'
        }
        /// <summary>
        /// Test the property 'TotalIncome2'
        /// </summary>
        [Test]
        public void TotalIncome2Test()
        {
            // TODO unit test for the property 'TotalIncome2'
        }
        /// <summary>
        /// Test the property 'TotalIncome3'
        /// </summary>
        [Test]
        public void TotalIncome3Test()
        {
            // TODO unit test for the property 'TotalIncome3'
        }
        /// <summary>
        /// Test the property 'TotalIncome4'
        /// </summary>
        [Test]
        public void TotalIncome4Test()
        {
            // TODO unit test for the property 'TotalIncome4'
        }
        /// <summary>
        /// Test the property 'TranscriptType'
        /// </summary>
        [Test]
        public void TranscriptTypeTest()
        {
            // TODO unit test for the property 'TranscriptType'
        }
        /// <summary>
        /// Test the property 'UserID'
        /// </summary>
        [Test]
        public void UserIDTest()
        {
            // TODO unit test for the property 'UserID'
        }

    }

}
