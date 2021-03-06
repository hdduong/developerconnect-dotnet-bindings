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
 * Credit
 *
 * Credit APIs
 *
 * OpenAPI spec version: 1.2.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Elli.Api.Services.Client.SwaggerDateConverter;

namespace Elli.Api.Services.Model
{
    /// <summary>
    /// Login credentials for the service provider.
    /// </summary>
    [DataContract]
    public partial class ProductCredentials :  IEquatable<ProductCredentials>, IValidatableObject
    {
    
        
        /// <summary>
        /// Username for the Lender users account with Fannie Mae&#39;s underwriting service.
        /// </summary>
        /// <value>Username for the Lender users account with Fannie Mae&#39;s underwriting service.</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Password for the Lender users account with Fannie Mae&#39;s underwriting service.
        /// </summary>
        /// <value>Password for the Lender users account with Fannie Mae&#39;s underwriting service.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// The associated insitution ID of the Lending organization with respect to the Fannie Mae&#39;s underwriting platforms.
        /// </summary>
        /// <value>The associated insitution ID of the Lending organization with respect to the Fannie Mae&#39;s underwriting platforms.</value>
        [DataMember(Name="institutionId", EmitDefaultValue=false)]
        public string InstitutionId { get; set; }

        /// <summary>
        /// Lender users username with their Credit provider
        /// </summary>
        /// <value>Lender users username with their Credit provider</value>
        [DataMember(Name="creditProviderUserName", EmitDefaultValue=false)]
        public string CreditProviderUserName { get; set; }

        /// <summary>
        /// Lenders users password with their Credit provider
        /// </summary>
        /// <value>Lenders users password with their Credit provider</value>
        [DataMember(Name="creditProviderPassword", EmitDefaultValue=false)]
        public string CreditProviderPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductCredentials {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  InstitutionId: ").Append(InstitutionId).Append("\n");
            sb.Append("  CreditProviderUserName: ").Append(CreditProviderUserName).Append("\n");
            sb.Append("  CreditProviderPassword: ").Append(CreditProviderPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductCredentials);
        }

        /// <summary>
        /// Returns true if ProductCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductCredentials input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.InstitutionId == input.InstitutionId ||
                    (this.InstitutionId != null &&
                    this.InstitutionId.Equals(input.InstitutionId))
                ) && 
                (
                    this.CreditProviderUserName == input.CreditProviderUserName ||
                    (this.CreditProviderUserName != null &&
                    this.CreditProviderUserName.Equals(input.CreditProviderUserName))
                ) && 
                (
                    this.CreditProviderPassword == input.CreditProviderPassword ||
                    (this.CreditProviderPassword != null &&
                    this.CreditProviderPassword.Equals(input.CreditProviderPassword))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.InstitutionId != null)
                    hashCode = hashCode * 59 + this.InstitutionId.GetHashCode();
                if (this.CreditProviderUserName != null)
                    hashCode = hashCode * 59 + this.CreditProviderUserName.GetHashCode();
                if (this.CreditProviderPassword != null)
                    hashCode = hashCode * 59 + this.CreditProviderPassword.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
