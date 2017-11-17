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
    ///  Class for testing LoanContractInterimServicingPaymentTransactions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LoanContractInterimServicingPaymentTransactionsTests
    {
        // TODO uncomment below to declare an instance variable for LoanContractInterimServicingPaymentTransactions
        //private LoanContractInterimServicingPaymentTransactions instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LoanContractInterimServicingPaymentTransactions
            //instance = new LoanContractInterimServicingPaymentTransactions();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoanContractInterimServicingPaymentTransactions
        /// </summary>
        [Test]
        public void LoanContractInterimServicingPaymentTransactionsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LoanContractInterimServicingPaymentTransactions
            //Assert.IsInstanceOfType<LoanContractInterimServicingPaymentTransactions> (instance, "variable 'instance' is a LoanContractInterimServicingPaymentTransactions");
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
        /// Test the property 'AccountHolder'
        /// </summary>
        [Test]
        public void AccountHolderTest()
        {
            // TODO unit test for the property 'AccountHolder'
        }
        /// <summary>
        /// Test the property 'AccountNumber'
        /// </summary>
        [Test]
        public void AccountNumberTest()
        {
            // TODO unit test for the property 'AccountNumber'
        }
        /// <summary>
        /// Test the property 'AdditionalEscrow'
        /// </summary>
        [Test]
        public void AdditionalEscrowTest()
        {
            // TODO unit test for the property 'AdditionalEscrow'
        }
        /// <summary>
        /// Test the property 'AdditionalPrincipal'
        /// </summary>
        [Test]
        public void AdditionalPrincipalTest()
        {
            // TODO unit test for the property 'AdditionalPrincipal'
        }
        /// <summary>
        /// Test the property 'BuydownSubsidyAmount'
        /// </summary>
        [Test]
        public void BuydownSubsidyAmountTest()
        {
            // TODO unit test for the property 'BuydownSubsidyAmount'
        }
        /// <summary>
        /// Test the property 'CheckNumber'
        /// </summary>
        [Test]
        public void CheckNumberTest()
        {
            // TODO unit test for the property 'CheckNumber'
        }
        /// <summary>
        /// Test the property 'Comments'
        /// </summary>
        [Test]
        public void CommentsTest()
        {
            // TODO unit test for the property 'Comments'
        }
        /// <summary>
        /// Test the property 'CommonAmount'
        /// </summary>
        [Test]
        public void CommonAmountTest()
        {
            // TODO unit test for the property 'CommonAmount'
        }
        /// <summary>
        /// Test the property 'CommonDate'
        /// </summary>
        [Test]
        public void CommonDateTest()
        {
            // TODO unit test for the property 'CommonDate'
        }
        /// <summary>
        /// Test the property 'CreatedById'
        /// </summary>
        [Test]
        public void CreatedByIdTest()
        {
            // TODO unit test for the property 'CreatedById'
        }
        /// <summary>
        /// Test the property 'CreatedByName'
        /// </summary>
        [Test]
        public void CreatedByNameTest()
        {
            // TODO unit test for the property 'CreatedByName'
        }
        /// <summary>
        /// Test the property 'CreatedDateTimeUtc'
        /// </summary>
        [Test]
        public void CreatedDateTimeUtcTest()
        {
            // TODO unit test for the property 'CreatedDateTimeUtc'
        }
        /// <summary>
        /// Test the property 'Escrow'
        /// </summary>
        [Test]
        public void EscrowTest()
        {
            // TODO unit test for the property 'Escrow'
        }
        /// <summary>
        /// Test the property 'Guid'
        /// </summary>
        [Test]
        public void GuidTest()
        {
            // TODO unit test for the property 'Guid'
        }
        /// <summary>
        /// Test the property 'IndexRate'
        /// </summary>
        [Test]
        public void IndexRateTest()
        {
            // TODO unit test for the property 'IndexRate'
        }
        /// <summary>
        /// Test the property 'InstitutionName'
        /// </summary>
        [Test]
        public void InstitutionNameTest()
        {
            // TODO unit test for the property 'InstitutionName'
        }
        /// <summary>
        /// Test the property 'InstitutionRouting'
        /// </summary>
        [Test]
        public void InstitutionRoutingTest()
        {
            // TODO unit test for the property 'InstitutionRouting'
        }
        /// <summary>
        /// Test the property 'Interest'
        /// </summary>
        [Test]
        public void InterestTest()
        {
            // TODO unit test for the property 'Interest'
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
        /// Test the property 'LateFee'
        /// </summary>
        [Test]
        public void LateFeeTest()
        {
            // TODO unit test for the property 'LateFee'
        }
        /// <summary>
        /// Test the property 'LateFeeIfLate'
        /// </summary>
        [Test]
        public void LateFeeIfLateTest()
        {
            // TODO unit test for the property 'LateFeeIfLate'
        }
        /// <summary>
        /// Test the property 'LatePaymentDate'
        /// </summary>
        [Test]
        public void LatePaymentDateTest()
        {
            // TODO unit test for the property 'LatePaymentDate'
        }
        /// <summary>
        /// Test the property 'MiscFee'
        /// </summary>
        [Test]
        public void MiscFeeTest()
        {
            // TODO unit test for the property 'MiscFee'
        }
        /// <summary>
        /// Test the property 'ModifiedById'
        /// </summary>
        [Test]
        public void ModifiedByIdTest()
        {
            // TODO unit test for the property 'ModifiedById'
        }
        /// <summary>
        /// Test the property 'ModifiedByName'
        /// </summary>
        [Test]
        public void ModifiedByNameTest()
        {
            // TODO unit test for the property 'ModifiedByName'
        }
        /// <summary>
        /// Test the property 'ModifiedDateTimeUtc'
        /// </summary>
        [Test]
        public void ModifiedDateTimeUtcTest()
        {
            // TODO unit test for the property 'ModifiedDateTimeUtc'
        }
        /// <summary>
        /// Test the property 'PaymentDepositedDate'
        /// </summary>
        [Test]
        public void PaymentDepositedDateTest()
        {
            // TODO unit test for the property 'PaymentDepositedDate'
        }
        /// <summary>
        /// Test the property 'PaymentDueDate'
        /// </summary>
        [Test]
        public void PaymentDueDateTest()
        {
            // TODO unit test for the property 'PaymentDueDate'
        }
        /// <summary>
        /// Test the property 'PaymentIndexDate'
        /// </summary>
        [Test]
        public void PaymentIndexDateTest()
        {
            // TODO unit test for the property 'PaymentIndexDate'
        }
        /// <summary>
        /// Test the property 'PaymentNumber'
        /// </summary>
        [Test]
        public void PaymentNumberTest()
        {
            // TODO unit test for the property 'PaymentNumber'
        }
        /// <summary>
        /// Test the property 'PaymentReceivedDate'
        /// </summary>
        [Test]
        public void PaymentReceivedDateTest()
        {
            // TODO unit test for the property 'PaymentReceivedDate'
        }
        /// <summary>
        /// Test the property 'Principal'
        /// </summary>
        [Test]
        public void PrincipalTest()
        {
            // TODO unit test for the property 'Principal'
        }
        /// <summary>
        /// Test the property 'Reference'
        /// </summary>
        [Test]
        public void ReferenceTest()
        {
            // TODO unit test for the property 'Reference'
        }
        /// <summary>
        /// Test the property 'ServicingPaymentMethod'
        /// </summary>
        [Test]
        public void ServicingPaymentMethodTest()
        {
            // TODO unit test for the property 'ServicingPaymentMethod'
        }
        /// <summary>
        /// Test the property 'ServicingTransactionType'
        /// </summary>
        [Test]
        public void ServicingTransactionTypeTest()
        {
            // TODO unit test for the property 'ServicingTransactionType'
        }
        /// <summary>
        /// Test the property 'StatementDate'
        /// </summary>
        [Test]
        public void StatementDateTest()
        {
            // TODO unit test for the property 'StatementDate'
        }
        /// <summary>
        /// Test the property 'TotalAmountDue'
        /// </summary>
        [Test]
        public void TotalAmountDueTest()
        {
            // TODO unit test for the property 'TotalAmountDue'
        }
        /// <summary>
        /// Test the property 'TotalAmountReceived'
        /// </summary>
        [Test]
        public void TotalAmountReceivedTest()
        {
            // TODO unit test for the property 'TotalAmountReceived'
        }
        /// <summary>
        /// Test the property 'TransactionAmount'
        /// </summary>
        [Test]
        public void TransactionAmountTest()
        {
            // TODO unit test for the property 'TransactionAmount'
        }
        /// <summary>
        /// Test the property 'TransactionDate'
        /// </summary>
        [Test]
        public void TransactionDateTest()
        {
            // TODO unit test for the property 'TransactionDate'
        }
        /// <summary>
        /// Test the property 'EscrowUSDAMonthlyPremium'
        /// </summary>
        [Test]
        public void EscrowUSDAMonthlyPremiumTest()
        {
            // TODO unit test for the property 'EscrowUSDAMonthlyPremium'
        }
        /// <summary>
        /// Test the property 'SchedulePayLogMiscFee'
        /// </summary>
        [Test]
        public void SchedulePayLogMiscFeeTest()
        {
            // TODO unit test for the property 'SchedulePayLogMiscFee'
        }
        /// <summary>
        /// Test the property 'EscrowTax'
        /// </summary>
        [Test]
        public void EscrowTaxTest()
        {
            // TODO unit test for the property 'EscrowTax'
        }
        /// <summary>
        /// Test the property 'EscrowMortgageInsurance'
        /// </summary>
        [Test]
        public void EscrowMortgageInsuranceTest()
        {
            // TODO unit test for the property 'EscrowMortgageInsurance'
        }
        /// <summary>
        /// Test the property 'EscrowHazardInsurance'
        /// </summary>
        [Test]
        public void EscrowHazardInsuranceTest()
        {
            // TODO unit test for the property 'EscrowHazardInsurance'
        }
        /// <summary>
        /// Test the property 'EscrowFloodInsurance'
        /// </summary>
        [Test]
        public void EscrowFloodInsuranceTest()
        {
            // TODO unit test for the property 'EscrowFloodInsurance'
        }
        /// <summary>
        /// Test the property 'EscrowCityPropertyTax'
        /// </summary>
        [Test]
        public void EscrowCityPropertyTaxTest()
        {
            // TODO unit test for the property 'EscrowCityPropertyTax'
        }
        /// <summary>
        /// Test the property 'EscrowOther1'
        /// </summary>
        [Test]
        public void EscrowOther1Test()
        {
            // TODO unit test for the property 'EscrowOther1'
        }
        /// <summary>
        /// Test the property 'EscrowOther2'
        /// </summary>
        [Test]
        public void EscrowOther2Test()
        {
            // TODO unit test for the property 'EscrowOther2'
        }
        /// <summary>
        /// Test the property 'EscrowOther3'
        /// </summary>
        [Test]
        public void EscrowOther3Test()
        {
            // TODO unit test for the property 'EscrowOther3'
        }

    }

}
