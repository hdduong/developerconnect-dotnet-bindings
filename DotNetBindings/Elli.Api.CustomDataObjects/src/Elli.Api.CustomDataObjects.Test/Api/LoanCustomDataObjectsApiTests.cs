/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/

/* 
 * Elli.Services
 *
 * Elli.CDO.Services
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Elli.Api.CustomDataObjects.Client;
using Elli.Api.CustomDataObjects.Api;
using Elli.Api.CustomDataObjects.Model;

namespace Elli.Api.CustomDataObjects.Test
{
    /// <summary>
    ///  Class for testing LoanCustomDataObjectsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LoanCustomDataObjectsApiTests
    {
        private LoanCustomDataObjectsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LoanCustomDataObjectsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoanCustomDataObjectsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LoanCustomDataObjectsApi
            //Assert.IsInstanceOfType(typeof(LoanCustomDataObjectsApi), instance, "instance is a LoanCustomDataObjectsApi");
        }

        
        /// <summary>
        /// Test AppendLoanCustomDataObject
        /// </summary>
        [Test]
        public void AppendLoanCustomDataObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loanId = null;
            //string objectName = null;
            //LoanCustomDataObjectContract customDataObjectContract = null;
            //var response = instance.AppendLoanCustomDataObject(loanId, objectName, customDataObjectContract);
            //Assert.IsInstanceOf<LoanCustomDataObjectContract> (response, "response is LoanCustomDataObjectContract");
        }
        
        /// <summary>
        /// Test CreateLoanCustomDataObject
        /// </summary>
        [Test]
        public void CreateLoanCustomDataObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loanId = null;
            //string objectName = null;
            //LoanCustomDataObjectContract customDataObjectContract = null;
            //var response = instance.CreateLoanCustomDataObject(loanId, objectName, customDataObjectContract);
            //Assert.IsInstanceOf<LoanCustomDataObjectContract> (response, "response is LoanCustomDataObjectContract");
        }
        
        /// <summary>
        /// Test DeleteLoanCustomDataObject
        /// </summary>
        [Test]
        public void DeleteLoanCustomDataObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loanId = null;
            //string objectName = null;
            //instance.DeleteLoanCustomDataObject(loanId, objectName);
            
        }
        
        /// <summary>
        /// Test GetLoanCustomDataObject
        /// </summary>
        [Test]
        public void GetLoanCustomDataObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loanId = null;
            //string objectName = null;
            //var response = instance.GetLoanCustomDataObject(loanId, objectName);
            //Assert.IsInstanceOf<LoanCustomDataObjectContract> (response, "response is LoanCustomDataObjectContract");
        }
        
        /// <summary>
        /// Test GetLoanCustomDataObjects
        /// </summary>
        [Test]
        public void GetLoanCustomDataObjectsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loanId = null;
            //var response = instance.GetLoanCustomDataObjects(loanId);
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
    }

}
