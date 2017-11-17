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
    ///  Class for testing LoanContractClosingDocumentAntiSteeringLoanOptions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LoanContractClosingDocumentAntiSteeringLoanOptionsTests
    {
        // TODO uncomment below to declare an instance variable for LoanContractClosingDocumentAntiSteeringLoanOptions
        //private LoanContractClosingDocumentAntiSteeringLoanOptions instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LoanContractClosingDocumentAntiSteeringLoanOptions
            //instance = new LoanContractClosingDocumentAntiSteeringLoanOptions();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoanContractClosingDocumentAntiSteeringLoanOptions
        /// </summary>
        [Test]
        public void LoanContractClosingDocumentAntiSteeringLoanOptionsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LoanContractClosingDocumentAntiSteeringLoanOptions
            //Assert.IsInstanceOfType<LoanContractClosingDocumentAntiSteeringLoanOptions> (instance, "variable 'instance' is a LoanContractClosingDocumentAntiSteeringLoanOptions");
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
        /// Test the property 'AntiSteeringLoanOptionIndex'
        /// </summary>
        [Test]
        public void AntiSteeringLoanOptionIndexTest()
        {
            // TODO unit test for the property 'AntiSteeringLoanOptionIndex'
        }
        /// <summary>
        /// Test the property 'BrokerCompensationFeeAmount'
        /// </summary>
        [Test]
        public void BrokerCompensationFeeAmountTest()
        {
            // TODO unit test for the property 'BrokerCompensationFeeAmount'
        }
        /// <summary>
        /// Test the property 'BrokerCompensationFeeBorPaidAmount'
        /// </summary>
        [Test]
        public void BrokerCompensationFeeBorPaidAmountTest()
        {
            // TODO unit test for the property 'BrokerCompensationFeeBorPaidAmount'
        }
        /// <summary>
        /// Test the property 'BrokerCompensationFeePercentage'
        /// </summary>
        [Test]
        public void BrokerCompensationFeePercentageTest()
        {
            // TODO unit test for the property 'BrokerCompensationFeePercentage'
        }
        /// <summary>
        /// Test the property 'BrokerFeeAmount'
        /// </summary>
        [Test]
        public void BrokerFeeAmountTest()
        {
            // TODO unit test for the property 'BrokerFeeAmount'
        }
        /// <summary>
        /// Test the property 'BrokerFeeBorPaidAmount'
        /// </summary>
        [Test]
        public void BrokerFeeBorPaidAmountTest()
        {
            // TODO unit test for the property 'BrokerFeeBorPaidAmount'
        }
        /// <summary>
        /// Test the property 'BrokerFeePercentage'
        /// </summary>
        [Test]
        public void BrokerFeePercentageTest()
        {
            // TODO unit test for the property 'BrokerFeePercentage'
        }
        /// <summary>
        /// Test the property 'BrokerFeeSellerPaidAmount'
        /// </summary>
        [Test]
        public void BrokerFeeSellerPaidAmountTest()
        {
            // TODO unit test for the property 'BrokerFeeSellerPaidAmount'
        }
        /// <summary>
        /// Test the property 'CreditorName'
        /// </summary>
        [Test]
        public void CreditorNameTest()
        {
            // TODO unit test for the property 'CreditorName'
        }
        /// <summary>
        /// Test the property 'DiscountAdditionalAmount'
        /// </summary>
        [Test]
        public void DiscountAdditionalAmountTest()
        {
            // TODO unit test for the property 'DiscountAdditionalAmount'
        }
        /// <summary>
        /// Test the property 'DiscountAmount'
        /// </summary>
        [Test]
        public void DiscountAmountTest()
        {
            // TODO unit test for the property 'DiscountAmount'
        }
        /// <summary>
        /// Test the property 'DiscountFeeBorPaidAmount'
        /// </summary>
        [Test]
        public void DiscountFeeBorPaidAmountTest()
        {
            // TODO unit test for the property 'DiscountFeeBorPaidAmount'
        }
        /// <summary>
        /// Test the property 'DiscountFeeSellerPaidAmount'
        /// </summary>
        [Test]
        public void DiscountFeeSellerPaidAmountTest()
        {
            // TODO unit test for the property 'DiscountFeeSellerPaidAmount'
        }
        /// <summary>
        /// Test the property 'DiscountPercentage'
        /// </summary>
        [Test]
        public void DiscountPercentageTest()
        {
            // TODO unit test for the property 'DiscountPercentage'
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
        /// Test the property 'FixedRatePeriod'
        /// </summary>
        [Test]
        public void FixedRatePeriodTest()
        {
            // TODO unit test for the property 'FixedRatePeriod'
        }
        /// <summary>
        /// Test the property 'HaveDemandFeature'
        /// </summary>
        [Test]
        public void HaveDemandFeatureTest()
        {
            // TODO unit test for the property 'HaveDemandFeature'
        }
        /// <summary>
        /// Test the property 'HavePrepaymentPenalty'
        /// </summary>
        [Test]
        public void HavePrepaymentPenaltyTest()
        {
            // TODO unit test for the property 'HavePrepaymentPenalty'
        }
        /// <summary>
        /// Test the property 'InspectionFeeBorPaidAmount'
        /// </summary>
        [Test]
        public void InspectionFeeBorPaidAmountTest()
        {
            // TODO unit test for the property 'InspectionFeeBorPaidAmount'
        }
        /// <summary>
        /// Test the property 'InspectionFeeSellerPaidAmount'
        /// </summary>
        [Test]
        public void InspectionFeeSellerPaidAmountTest()
        {
            // TODO unit test for the property 'InspectionFeeSellerPaidAmount'
        }
        /// <summary>
        /// Test the property 'InterestRate'
        /// </summary>
        [Test]
        public void InterestRateTest()
        {
            // TODO unit test for the property 'InterestRate'
        }
        /// <summary>
        /// Test the property 'IsBalloonPaymentIn7Years'
        /// </summary>
        [Test]
        public void IsBalloonPaymentIn7YearsTest()
        {
            // TODO unit test for the property 'IsBalloonPaymentIn7Years'
        }
        /// <summary>
        /// Test the property 'IsInterestOnlyLoan'
        /// </summary>
        [Test]
        public void IsInterestOnlyLoanTest()
        {
            // TODO unit test for the property 'IsInterestOnlyLoan'
        }
        /// <summary>
        /// Test the property 'IsNegativeAmortization'
        /// </summary>
        [Test]
        public void IsNegativeAmortizationTest()
        {
            // TODO unit test for the property 'IsNegativeAmortization'
        }
        /// <summary>
        /// Test the property 'LoanTerm'
        /// </summary>
        [Test]
        public void LoanTermTest()
        {
            // TODO unit test for the property 'LoanTerm'
        }
        /// <summary>
        /// Test the property 'LoanType'
        /// </summary>
        [Test]
        public void LoanTypeTest()
        {
            // TODO unit test for the property 'LoanType'
        }
        /// <summary>
        /// Test the property 'OriginationFeeBorPaidAmount'
        /// </summary>
        [Test]
        public void OriginationFeeBorPaidAmountTest()
        {
            // TODO unit test for the property 'OriginationFeeBorPaidAmount'
        }
        /// <summary>
        /// Test the property 'OriginationFeePercentage'
        /// </summary>
        [Test]
        public void OriginationFeePercentageTest()
        {
            // TODO unit test for the property 'OriginationFeePercentage'
        }
        /// <summary>
        /// Test the property 'OriginationFeeSellerPaidAmount'
        /// </summary>
        [Test]
        public void OriginationFeeSellerPaidAmountTest()
        {
            // TODO unit test for the property 'OriginationFeeSellerPaidAmount'
        }
        /// <summary>
        /// Test the property 'OriginationPointsFees'
        /// </summary>
        [Test]
        public void OriginationPointsFeesTest()
        {
            // TODO unit test for the property 'OriginationPointsFees'
        }
        /// <summary>
        /// Test the property 'OriginationPointsPercetange'
        /// </summary>
        [Test]
        public void OriginationPointsPercetangeTest()
        {
            // TODO unit test for the property 'OriginationPointsPercetange'
        }
        /// <summary>
        /// Test the property 'ProcessingFeeBorPaidAmount'
        /// </summary>
        [Test]
        public void ProcessingFeeBorPaidAmountTest()
        {
            // TODO unit test for the property 'ProcessingFeeBorPaidAmount'
        }
        /// <summary>
        /// Test the property 'ProcessingFeeSellerPaidAmount'
        /// </summary>
        [Test]
        public void ProcessingFeeSellerPaidAmountTest()
        {
            // TODO unit test for the property 'ProcessingFeeSellerPaidAmount'
        }
        /// <summary>
        /// Test the property 'TotalOriginationDiscountAmount'
        /// </summary>
        [Test]
        public void TotalOriginationDiscountAmountTest()
        {
            // TODO unit test for the property 'TotalOriginationDiscountAmount'
        }
        /// <summary>
        /// Test the property 'UnderwritingFeeBorPaidAmount'
        /// </summary>
        [Test]
        public void UnderwritingFeeBorPaidAmountTest()
        {
            // TODO unit test for the property 'UnderwritingFeeBorPaidAmount'
        }
        /// <summary>
        /// Test the property 'UnderwritingFeeSellerPaidAmount'
        /// </summary>
        [Test]
        public void UnderwritingFeeSellerPaidAmountTest()
        {
            // TODO unit test for the property 'UnderwritingFeeSellerPaidAmount'
        }
        /// <summary>
        /// Test the property 'UserDefinedFee1BorPaidAmount'
        /// </summary>
        [Test]
        public void UserDefinedFee1BorPaidAmountTest()
        {
            // TODO unit test for the property 'UserDefinedFee1BorPaidAmount'
        }
        /// <summary>
        /// Test the property 'UserDefinedFee1Description'
        /// </summary>
        [Test]
        public void UserDefinedFee1DescriptionTest()
        {
            // TODO unit test for the property 'UserDefinedFee1Description'
        }
        /// <summary>
        /// Test the property 'UserDefinedFee1SellerPaidAmount'
        /// </summary>
        [Test]
        public void UserDefinedFee1SellerPaidAmountTest()
        {
            // TODO unit test for the property 'UserDefinedFee1SellerPaidAmount'
        }
        /// <summary>
        /// Test the property 'UserDefinedFee2BorPaidAmount'
        /// </summary>
        [Test]
        public void UserDefinedFee2BorPaidAmountTest()
        {
            // TODO unit test for the property 'UserDefinedFee2BorPaidAmount'
        }
        /// <summary>
        /// Test the property 'UserDefinedFee2Description'
        /// </summary>
        [Test]
        public void UserDefinedFee2DescriptionTest()
        {
            // TODO unit test for the property 'UserDefinedFee2Description'
        }
        /// <summary>
        /// Test the property 'UserDefinedFee2SellerPaidAmount'
        /// </summary>
        [Test]
        public void UserDefinedFee2SellerPaidAmountTest()
        {
            // TODO unit test for the property 'UserDefinedFee2SellerPaidAmount'
        }
        /// <summary>
        /// Test the property 'UserDefinedFee3BorPaidAmount'
        /// </summary>
        [Test]
        public void UserDefinedFee3BorPaidAmountTest()
        {
            // TODO unit test for the property 'UserDefinedFee3BorPaidAmount'
        }
        /// <summary>
        /// Test the property 'UserDefinedFee3Description'
        /// </summary>
        [Test]
        public void UserDefinedFee3DescriptionTest()
        {
            // TODO unit test for the property 'UserDefinedFee3Description'
        }
        /// <summary>
        /// Test the property 'UserDefinedFee3SellerPaidAmount'
        /// </summary>
        [Test]
        public void UserDefinedFee3SellerPaidAmountTest()
        {
            // TODO unit test for the property 'UserDefinedFee3SellerPaidAmount'
        }
        /// <summary>
        /// Test the property 'UserDefinedFee4BorPaidAmount'
        /// </summary>
        [Test]
        public void UserDefinedFee4BorPaidAmountTest()
        {
            // TODO unit test for the property 'UserDefinedFee4BorPaidAmount'
        }
        /// <summary>
        /// Test the property 'UserDefinedFee4Description'
        /// </summary>
        [Test]
        public void UserDefinedFee4DescriptionTest()
        {
            // TODO unit test for the property 'UserDefinedFee4Description'
        }
        /// <summary>
        /// Test the property 'UserDefinedFee4SellerPaidAmount'
        /// </summary>
        [Test]
        public void UserDefinedFee4SellerPaidAmountTest()
        {
            // TODO unit test for the property 'UserDefinedFee4SellerPaidAmount'
        }
        /// <summary>
        /// Test the property 'UserDefinedFee5BorPaidAmount'
        /// </summary>
        [Test]
        public void UserDefinedFee5BorPaidAmountTest()
        {
            // TODO unit test for the property 'UserDefinedFee5BorPaidAmount'
        }
        /// <summary>
        /// Test the property 'UserDefinedFee5Description'
        /// </summary>
        [Test]
        public void UserDefinedFee5DescriptionTest()
        {
            // TODO unit test for the property 'UserDefinedFee5Description'
        }
        /// <summary>
        /// Test the property 'UserDefinedFee5SellerPaidAmount'
        /// </summary>
        [Test]
        public void UserDefinedFee5SellerPaidAmountTest()
        {
            // TODO unit test for the property 'UserDefinedFee5SellerPaidAmount'
        }

    }

}
