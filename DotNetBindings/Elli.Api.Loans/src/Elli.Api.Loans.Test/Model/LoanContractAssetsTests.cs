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
    ///  Class for testing LoanContractAssets
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LoanContractAssetsTests
    {
        // TODO uncomment below to declare an instance variable for LoanContractAssets
        //private LoanContractAssets instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LoanContractAssets
            //instance = new LoanContractAssets();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoanContractAssets
        /// </summary>
        [Test]
        public void LoanContractAssetsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LoanContractAssets
            //Assert.IsInstanceOfType<LoanContractAssets> (instance, "variable 'instance' is a LoanContractAssets");
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
        /// Test the property 'EntityDeleted'
        /// </summary>
        [Test]
        public void EntityDeletedTest()
        {
            // TODO unit test for the property 'EntityDeleted'
        }
        /// <summary>
        /// Test the property 'AccountIdentifier'
        /// </summary>
        [Test]
        public void AccountIdentifierTest()
        {
            // TODO unit test for the property 'AccountIdentifier'
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
        /// Test the property 'AssetIndex'
        /// </summary>
        [Test]
        public void AssetIndexTest()
        {
            // TODO unit test for the property 'AssetIndex'
        }
        /// <summary>
        /// Test the property 'AssetType'
        /// </summary>
        [Test]
        public void AssetTypeTest()
        {
            // TODO unit test for the property 'AssetType'
        }
        /// <summary>
        /// Test the property 'Attention'
        /// </summary>
        [Test]
        public void AttentionTest()
        {
            // TODO unit test for the property 'Attention'
        }
        /// <summary>
        /// Test the property 'BorrowerId'
        /// </summary>
        [Test]
        public void BorrowerIdTest()
        {
            // TODO unit test for the property 'BorrowerId'
        }
        /// <summary>
        /// Test the property 'CashOrMarketValueAmount'
        /// </summary>
        [Test]
        public void CashOrMarketValueAmountTest()
        {
            // TODO unit test for the property 'CashOrMarketValueAmount'
        }
        /// <summary>
        /// Test the property 'DepositoryAccountName'
        /// </summary>
        [Test]
        public void DepositoryAccountNameTest()
        {
            // TODO unit test for the property 'DepositoryAccountName'
        }
        /// <summary>
        /// Test the property 'DepositoryRequestDate'
        /// </summary>
        [Test]
        public void DepositoryRequestDateTest()
        {
            // TODO unit test for the property 'DepositoryRequestDate'
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
        /// Test the property 'HolderAddressCity'
        /// </summary>
        [Test]
        public void HolderAddressCityTest()
        {
            // TODO unit test for the property 'HolderAddressCity'
        }
        /// <summary>
        /// Test the property 'HolderAddressPostalCode'
        /// </summary>
        [Test]
        public void HolderAddressPostalCodeTest()
        {
            // TODO unit test for the property 'HolderAddressPostalCode'
        }
        /// <summary>
        /// Test the property 'HolderAddressState'
        /// </summary>
        [Test]
        public void HolderAddressStateTest()
        {
            // TODO unit test for the property 'HolderAddressState'
        }
        /// <summary>
        /// Test the property 'HolderAddressStreetLine1'
        /// </summary>
        [Test]
        public void HolderAddressStreetLine1Test()
        {
            // TODO unit test for the property 'HolderAddressStreetLine1'
        }
        /// <summary>
        /// Test the property 'HolderComments'
        /// </summary>
        [Test]
        public void HolderCommentsTest()
        {
            // TODO unit test for the property 'HolderComments'
        }
        /// <summary>
        /// Test the property 'HolderEmail'
        /// </summary>
        [Test]
        public void HolderEmailTest()
        {
            // TODO unit test for the property 'HolderEmail'
        }
        /// <summary>
        /// Test the property 'HolderFax'
        /// </summary>
        [Test]
        public void HolderFaxTest()
        {
            // TODO unit test for the property 'HolderFax'
        }
        /// <summary>
        /// Test the property 'HolderName'
        /// </summary>
        [Test]
        public void HolderNameTest()
        {
            // TODO unit test for the property 'HolderName'
        }
        /// <summary>
        /// Test the property 'HolderPhone'
        /// </summary>
        [Test]
        public void HolderPhoneTest()
        {
            // TODO unit test for the property 'HolderPhone'
        }
        /// <summary>
        /// Test the property 'IsEmpty'
        /// </summary>
        [Test]
        public void IsEmptyTest()
        {
            // TODO unit test for the property 'IsEmpty'
        }
        /// <summary>
        /// Test the property 'IsVod'
        /// </summary>
        [Test]
        public void IsVodTest()
        {
            // TODO unit test for the property 'IsVod'
        }
        /// <summary>
        /// Test the property 'LifeInsuranceFaceValueAmount'
        /// </summary>
        [Test]
        public void LifeInsuranceFaceValueAmountTest()
        {
            // TODO unit test for the property 'LifeInsuranceFaceValueAmount'
        }
        /// <summary>
        /// Test the property 'NameInAccount'
        /// </summary>
        [Test]
        public void NameInAccountTest()
        {
            // TODO unit test for the property 'NameInAccount'
        }
        /// <summary>
        /// Test the property 'NoLinkToDocTrackIndicator'
        /// </summary>
        [Test]
        public void NoLinkToDocTrackIndicatorTest()
        {
            // TODO unit test for the property 'NoLinkToDocTrackIndicator'
        }
        /// <summary>
        /// Test the property 'Owner'
        /// </summary>
        [Test]
        public void OwnerTest()
        {
            // TODO unit test for the property 'Owner'
        }
        /// <summary>
        /// Test the property 'PrintAttachmentIndicator'
        /// </summary>
        [Test]
        public void PrintAttachmentIndicatorTest()
        {
            // TODO unit test for the property 'PrintAttachmentIndicator'
        }
        /// <summary>
        /// Test the property 'PrintUserNameIndicator'
        /// </summary>
        [Test]
        public void PrintUserNameIndicatorTest()
        {
            // TODO unit test for the property 'PrintUserNameIndicator'
        }
        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Test]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'TitleFax'
        /// </summary>
        [Test]
        public void TitleFaxTest()
        {
            // TODO unit test for the property 'TitleFax'
        }
        /// <summary>
        /// Test the property 'TitlePhone'
        /// </summary>
        [Test]
        public void TitlePhoneTest()
        {
            // TODO unit test for the property 'TitlePhone'
        }
        /// <summary>
        /// Test the property 'Total'
        /// </summary>
        [Test]
        public void TotalTest()
        {
            // TODO unit test for the property 'Total'
        }
        /// <summary>
        /// Test the property 'VodIndex'
        /// </summary>
        [Test]
        public void VodIndexTest()
        {
            // TODO unit test for the property 'VodIndex'
        }

    }

}
