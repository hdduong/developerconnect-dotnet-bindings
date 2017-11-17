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
    ///  Class for testing LoanContractClosingCostLoanEstimate3
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LoanContractClosingCostLoanEstimate3Tests
    {
        // TODO uncomment below to declare an instance variable for LoanContractClosingCostLoanEstimate3
        //private LoanContractClosingCostLoanEstimate3 instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LoanContractClosingCostLoanEstimate3
            //instance = new LoanContractClosingCostLoanEstimate3();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoanContractClosingCostLoanEstimate3
        /// </summary>
        [Test]
        public void LoanContractClosingCostLoanEstimate3InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LoanContractClosingCostLoanEstimate3
            //Assert.IsInstanceOfType<LoanContractClosingCostLoanEstimate3> (instance, "variable 'instance' is a LoanContractClosingCostLoanEstimate3");
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
        /// Test the property 'LenderLicenseID'
        /// </summary>
        [Test]
        public void LenderLicenseIDTest()
        {
            // TODO unit test for the property 'LenderLicenseID'
        }
        /// <summary>
        /// Test the property 'LenderEmail'
        /// </summary>
        [Test]
        public void LenderEmailTest()
        {
            // TODO unit test for the property 'LenderEmail'
        }
        /// <summary>
        /// Test the property 'LenderPhone'
        /// </summary>
        [Test]
        public void LenderPhoneTest()
        {
            // TODO unit test for the property 'LenderPhone'
        }
        /// <summary>
        /// Test the property 'LenderLoanOfficer'
        /// </summary>
        [Test]
        public void LenderLoanOfficerTest()
        {
            // TODO unit test for the property 'LenderLoanOfficer'
        }
        /// <summary>
        /// Test the property 'LenderLoanOfficerNMLSId'
        /// </summary>
        [Test]
        public void LenderLoanOfficerNMLSIdTest()
        {
            // TODO unit test for the property 'LenderLoanOfficerNMLSId'
        }
        /// <summary>
        /// Test the property 'MortgageBrokerLicenseID'
        /// </summary>
        [Test]
        public void MortgageBrokerLicenseIDTest()
        {
            // TODO unit test for the property 'MortgageBrokerLicenseID'
        }
        /// <summary>
        /// Test the property 'MortgageBrokerEmail'
        /// </summary>
        [Test]
        public void MortgageBrokerEmailTest()
        {
            // TODO unit test for the property 'MortgageBrokerEmail'
        }
        /// <summary>
        /// Test the property 'MortgageBrokerPhone'
        /// </summary>
        [Test]
        public void MortgageBrokerPhoneTest()
        {
            // TODO unit test for the property 'MortgageBrokerPhone'
        }
        /// <summary>
        /// Test the property 'MortgageBrokerLoanOfficer'
        /// </summary>
        [Test]
        public void MortgageBrokerLoanOfficerTest()
        {
            // TODO unit test for the property 'MortgageBrokerLoanOfficer'
        }
        /// <summary>
        /// Test the property 'MortgageBrokerLoanOfficerNMLSId'
        /// </summary>
        [Test]
        public void MortgageBrokerLoanOfficerNMLSIdTest()
        {
            // TODO unit test for the property 'MortgageBrokerLoanOfficerNMLSId'
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
        /// Test the property 'Assumption'
        /// </summary>
        [Test]
        public void AssumptionTest()
        {
            // TODO unit test for the property 'Assumption'
        }
        /// <summary>
        /// Test the property 'HomeownerInsurance'
        /// </summary>
        [Test]
        public void HomeownerInsuranceTest()
        {
            // TODO unit test for the property 'HomeownerInsurance'
        }
        /// <summary>
        /// Test the property 'Servicing'
        /// </summary>
        [Test]
        public void ServicingTest()
        {
            // TODO unit test for the property 'Servicing'
        }
        /// <summary>
        /// Test the property 'ConstructionLoan'
        /// </summary>
        [Test]
        public void ConstructionLoanTest()
        {
            // TODO unit test for the property 'ConstructionLoan'
        }
        /// <summary>
        /// Test the property 'TotalInterestPercentage'
        /// </summary>
        [Test]
        public void TotalInterestPercentageTest()
        {
            // TODO unit test for the property 'TotalInterestPercentage'
        }
        /// <summary>
        /// Test the property 'In5YearsTotalYouWillHavePaid'
        /// </summary>
        [Test]
        public void In5YearsTotalYouWillHavePaidTest()
        {
            // TODO unit test for the property 'In5YearsTotalYouWillHavePaid'
        }
        /// <summary>
        /// Test the property 'In5YearsPrincipalYouWillHavePaidOff'
        /// </summary>
        [Test]
        public void In5YearsPrincipalYouWillHavePaidOffTest()
        {
            // TODO unit test for the property 'In5YearsPrincipalYouWillHavePaidOff'
        }
        /// <summary>
        /// Test the property 'SignatureType'
        /// </summary>
        [Test]
        public void SignatureTypeTest()
        {
            // TODO unit test for the property 'SignatureType'
        }
        /// <summary>
        /// Test the property 'LenderLicenseState'
        /// </summary>
        [Test]
        public void LenderLicenseStateTest()
        {
            // TODO unit test for the property 'LenderLicenseState'
        }
        /// <summary>
        /// Test the property 'LenderLoanOfficerLicenseState'
        /// </summary>
        [Test]
        public void LenderLoanOfficerLicenseStateTest()
        {
            // TODO unit test for the property 'LenderLoanOfficerLicenseState'
        }
        /// <summary>
        /// Test the property 'MortgageBrokerLicenseState'
        /// </summary>
        [Test]
        public void MortgageBrokerLicenseStateTest()
        {
            // TODO unit test for the property 'MortgageBrokerLicenseState'
        }
        /// <summary>
        /// Test the property 'MortgageBrokerLoanOfficerLicenseState'
        /// </summary>
        [Test]
        public void MortgageBrokerLoanOfficerLicenseStateTest()
        {
            // TODO unit test for the property 'MortgageBrokerLoanOfficerLicenseState'
        }
        /// <summary>
        /// Test the property 'MortgageLenderLoanOfficerLicenseID'
        /// </summary>
        [Test]
        public void MortgageLenderLoanOfficerLicenseIDTest()
        {
            // TODO unit test for the property 'MortgageLenderLoanOfficerLicenseID'
        }
        /// <summary>
        /// Test the property 'MortgageBrokerLoanOfficerLicenseID'
        /// </summary>
        [Test]
        public void MortgageBrokerLoanOfficerLicenseIDTest()
        {
            // TODO unit test for the property 'MortgageBrokerLoanOfficerLicenseID'
        }

    }

}
