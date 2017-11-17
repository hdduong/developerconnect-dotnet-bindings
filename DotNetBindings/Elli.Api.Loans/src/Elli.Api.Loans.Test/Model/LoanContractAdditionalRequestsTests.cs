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
    ///  Class for testing LoanContractAdditionalRequests
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LoanContractAdditionalRequestsTests
    {
        // TODO uncomment below to declare an instance variable for LoanContractAdditionalRequests
        //private LoanContractAdditionalRequests instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LoanContractAdditionalRequests
            //instance = new LoanContractAdditionalRequests();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoanContractAdditionalRequests
        /// </summary>
        [Test]
        public void LoanContractAdditionalRequestsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LoanContractAdditionalRequests
            //Assert.IsInstanceOfType<LoanContractAdditionalRequests> (instance, "variable 'instance' is a LoanContractAdditionalRequests");
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
        /// Test the property 'AppraisalContactCellPhone'
        /// </summary>
        [Test]
        public void AppraisalContactCellPhoneTest()
        {
            // TODO unit test for the property 'AppraisalContactCellPhone'
        }
        /// <summary>
        /// Test the property 'AppraisalContactEmail'
        /// </summary>
        [Test]
        public void AppraisalContactEmailTest()
        {
            // TODO unit test for the property 'AppraisalContactEmail'
        }
        /// <summary>
        /// Test the property 'AppraisalContactForEntry'
        /// </summary>
        [Test]
        public void AppraisalContactForEntryTest()
        {
            // TODO unit test for the property 'AppraisalContactForEntry'
        }
        /// <summary>
        /// Test the property 'AppraisalContactHomePhone'
        /// </summary>
        [Test]
        public void AppraisalContactHomePhoneTest()
        {
            // TODO unit test for the property 'AppraisalContactHomePhone'
        }
        /// <summary>
        /// Test the property 'AppraisalContactName'
        /// </summary>
        [Test]
        public void AppraisalContactNameTest()
        {
            // TODO unit test for the property 'AppraisalContactName'
        }
        /// <summary>
        /// Test the property 'AppraisalContactWorkPhone'
        /// </summary>
        [Test]
        public void AppraisalContactWorkPhoneTest()
        {
            // TODO unit test for the property 'AppraisalContactWorkPhone'
        }
        /// <summary>
        /// Test the property 'AppraisalDateOrdered'
        /// </summary>
        [Test]
        public void AppraisalDateOrderedTest()
        {
            // TODO unit test for the property 'AppraisalDateOrdered'
        }
        /// <summary>
        /// Test the property 'AppraisalDescription1'
        /// </summary>
        [Test]
        public void AppraisalDescription1Test()
        {
            // TODO unit test for the property 'AppraisalDescription1'
        }
        /// <summary>
        /// Test the property 'AppraisalDescription2'
        /// </summary>
        [Test]
        public void AppraisalDescription2Test()
        {
            // TODO unit test for the property 'AppraisalDescription2'
        }
        /// <summary>
        /// Test the property 'AppraisalDescription3'
        /// </summary>
        [Test]
        public void AppraisalDescription3Test()
        {
            // TODO unit test for the property 'AppraisalDescription3'
        }
        /// <summary>
        /// Test the property 'AppraisalKeyPickUp'
        /// </summary>
        [Test]
        public void AppraisalKeyPickUpTest()
        {
            // TODO unit test for the property 'AppraisalKeyPickUp'
        }
        /// <summary>
        /// Test the property 'AppraisalLockBox'
        /// </summary>
        [Test]
        public void AppraisalLockBoxTest()
        {
            // TODO unit test for the property 'AppraisalLockBox'
        }
        /// <summary>
        /// Test the property 'AppraisalVacant'
        /// </summary>
        [Test]
        public void AppraisalVacantTest()
        {
            // TODO unit test for the property 'AppraisalVacant'
        }
        /// <summary>
        /// Test the property 'FloodDescription1'
        /// </summary>
        [Test]
        public void FloodDescription1Test()
        {
            // TODO unit test for the property 'FloodDescription1'
        }
        /// <summary>
        /// Test the property 'FloodDescription2'
        /// </summary>
        [Test]
        public void FloodDescription2Test()
        {
            // TODO unit test for the property 'FloodDescription2'
        }
        /// <summary>
        /// Test the property 'FloodDescription3'
        /// </summary>
        [Test]
        public void FloodDescription3Test()
        {
            // TODO unit test for the property 'FloodDescription3'
        }
        /// <summary>
        /// Test the property 'FloodInsuranceEscrowed'
        /// </summary>
        [Test]
        public void FloodInsuranceEscrowedTest()
        {
            // TODO unit test for the property 'FloodInsuranceEscrowed'
        }
        /// <summary>
        /// Test the property 'FloodReplacementValue'
        /// </summary>
        [Test]
        public void FloodReplacementValueTest()
        {
            // TODO unit test for the property 'FloodReplacementValue'
        }
        /// <summary>
        /// Test the property 'HazardDescription1'
        /// </summary>
        [Test]
        public void HazardDescription1Test()
        {
            // TODO unit test for the property 'HazardDescription1'
        }
        /// <summary>
        /// Test the property 'HazardDescription2'
        /// </summary>
        [Test]
        public void HazardDescription2Test()
        {
            // TODO unit test for the property 'HazardDescription2'
        }
        /// <summary>
        /// Test the property 'HazardDescription3'
        /// </summary>
        [Test]
        public void HazardDescription3Test()
        {
            // TODO unit test for the property 'HazardDescription3'
        }
        /// <summary>
        /// Test the property 'HazardInsuranceEscrowed'
        /// </summary>
        [Test]
        public void HazardInsuranceEscrowedTest()
        {
            // TODO unit test for the property 'HazardInsuranceEscrowed'
        }
        /// <summary>
        /// Test the property 'HazardReplacementValue'
        /// </summary>
        [Test]
        public void HazardReplacementValueTest()
        {
            // TODO unit test for the property 'HazardReplacementValue'
        }
        /// <summary>
        /// Test the property 'TitleContract'
        /// </summary>
        [Test]
        public void TitleContractTest()
        {
            // TODO unit test for the property 'TitleContract'
        }
        /// <summary>
        /// Test the property 'TitleDescription1'
        /// </summary>
        [Test]
        public void TitleDescription1Test()
        {
            // TODO unit test for the property 'TitleDescription1'
        }
        /// <summary>
        /// Test the property 'TitleDescription2'
        /// </summary>
        [Test]
        public void TitleDescription2Test()
        {
            // TODO unit test for the property 'TitleDescription2'
        }
        /// <summary>
        /// Test the property 'TitleDescription3'
        /// </summary>
        [Test]
        public void TitleDescription3Test()
        {
            // TODO unit test for the property 'TitleDescription3'
        }
        /// <summary>
        /// Test the property 'TitleInsRequirements'
        /// </summary>
        [Test]
        public void TitleInsRequirementsTest()
        {
            // TODO unit test for the property 'TitleInsRequirements'
        }
        /// <summary>
        /// Test the property 'TitleMailAway'
        /// </summary>
        [Test]
        public void TitleMailAwayTest()
        {
            // TODO unit test for the property 'TitleMailAway'
        }
        /// <summary>
        /// Test the property 'TitlePriorTitlePolicy'
        /// </summary>
        [Test]
        public void TitlePriorTitlePolicyTest()
        {
            // TODO unit test for the property 'TitlePriorTitlePolicy'
        }
        /// <summary>
        /// Test the property 'TitleSurvey'
        /// </summary>
        [Test]
        public void TitleSurveyTest()
        {
            // TODO unit test for the property 'TitleSurvey'
        }
        /// <summary>
        /// Test the property 'TitleTypeOfProperty'
        /// </summary>
        [Test]
        public void TitleTypeOfPropertyTest()
        {
            // TODO unit test for the property 'TitleTypeOfProperty'
        }
        /// <summary>
        /// Test the property 'TitleWarrantyDeed'
        /// </summary>
        [Test]
        public void TitleWarrantyDeedTest()
        {
            // TODO unit test for the property 'TitleWarrantyDeed'
        }
        /// <summary>
        /// Test the property 'MaximumDeductibleHazardPercentage'
        /// </summary>
        [Test]
        public void MaximumDeductibleHazardPercentageTest()
        {
            // TODO unit test for the property 'MaximumDeductibleHazardPercentage'
        }
        /// <summary>
        /// Test the property 'MaximumDeductibleHazardAmount'
        /// </summary>
        [Test]
        public void MaximumDeductibleHazardAmountTest()
        {
            // TODO unit test for the property 'MaximumDeductibleHazardAmount'
        }
        /// <summary>
        /// Test the property 'MaximumDeductibleFloodPercentage'
        /// </summary>
        [Test]
        public void MaximumDeductibleFloodPercentageTest()
        {
            // TODO unit test for the property 'MaximumDeductibleFloodPercentage'
        }
        /// <summary>
        /// Test the property 'MaximumDeductibleFloodAmount'
        /// </summary>
        [Test]
        public void MaximumDeductibleFloodAmountTest()
        {
            // TODO unit test for the property 'MaximumDeductibleFloodAmount'
        }

    }

}
