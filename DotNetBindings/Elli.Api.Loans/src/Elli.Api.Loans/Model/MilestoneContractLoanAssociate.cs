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
 * Loan
 *
 * Returns the entire loan or specific entities of a loan.
 *
 * OpenAPI spec version: 1.2.0
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
using SwaggerDateConverter = Elli.Api.Loans.Client.SwaggerDateConverter;

namespace Elli.Api.Loans.Model
{
    /// <summary>
    /// MilestoneContractLoanAssociate
    /// </summary>
    [DataContract]
    public partial class MilestoneContractLoanAssociate :  IEquatable<MilestoneContractLoanAssociate>, IValidatableObject
    {
    
        
        /// <summary>
        /// Type of loan associate
        /// </summary>
        /// <value>Type of loan associate</value>
        [DataMember(Name="loanAssociateType", EmitDefaultValue=false)]
        public string LoanAssociateType { get; set; }

        /// <summary>
        /// Unique indentifier of an user or group. In case of group, if id is provided then id will be used to associate group else name will be used. It is manadatory field while associating user to milestone or milestone free role.
        /// </summary>
        /// <value>Unique indentifier of an user or group. In case of group, if id is provided then id will be used to associate group else name will be used. It is manadatory field while associating user to milestone or milestone free role.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of a user or group. In case of group, if id is not provided in a request then name will be used to associate group. Associate name can not be updated. It will be extracted from user&#39;s profile while associating user to milestone or milestone free role.
        /// </summary>
        /// <value>Name of a user or group. In case of group, if id is not provided in a request then name will be used to associate group. Associate name can not be updated. It will be extracted from user&#39;s profile while associating user to milestone or milestone free role.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Phone number of user or group
        /// </summary>
        /// <value>Phone number of user or group</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Cellphone of user or group
        /// </summary>
        /// <value>Cellphone of user or group</value>
        [DataMember(Name="cellPhone", EmitDefaultValue=false)]
        public string CellPhone { get; set; }

        /// <summary>
        /// Fax number of user or group
        /// </summary>
        /// <value>Fax number of user or group</value>
        [DataMember(Name="fax", EmitDefaultValue=false)]
        public string Fax { get; set; }

        /// <summary>
        /// EmailId of user or group
        /// </summary>
        /// <value>EmailId of user or group</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Name of Role assigned to user or group
        /// </summary>
        /// <value>Name of Role assigned to user or group</value>
        [DataMember(Name="roleName", EmitDefaultValue=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// Unique indentifier of Role assigned to user or group
        /// </summary>
        /// <value>Unique indentifier of Role assigned to user or group</value>
        [DataMember(Name="roleId", EmitDefaultValue=false)]
        public string RoleId { get; set; }

        /// <summary>
        /// Write access indicator of the milestone free role.
        /// </summary>
        /// <value>Write access indicator of the milestone free role.</value>
        [DataMember(Name="writeAccess", EmitDefaultValue=false)]
        public bool? WriteAccess { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MilestoneContractLoanAssociate {\n");
            sb.Append("  LoanAssociateType: ").Append(LoanAssociateType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  CellPhone: ").Append(CellPhone).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  WriteAccess: ").Append(WriteAccess).Append("\n");
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
            return this.Equals(input as MilestoneContractLoanAssociate);
        }

        /// <summary>
        /// Returns true if MilestoneContractLoanAssociate instances are equal
        /// </summary>
        /// <param name="input">Instance of MilestoneContractLoanAssociate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MilestoneContractLoanAssociate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LoanAssociateType == input.LoanAssociateType ||
                    (this.LoanAssociateType != null &&
                    this.LoanAssociateType.Equals(input.LoanAssociateType))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.CellPhone == input.CellPhone ||
                    (this.CellPhone != null &&
                    this.CellPhone.Equals(input.CellPhone))
                ) && 
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.RoleName == input.RoleName ||
                    (this.RoleName != null &&
                    this.RoleName.Equals(input.RoleName))
                ) && 
                (
                    this.RoleId == input.RoleId ||
                    (this.RoleId != null &&
                    this.RoleId.Equals(input.RoleId))
                ) && 
                (
                    this.WriteAccess == input.WriteAccess ||
                    (this.WriteAccess != null &&
                    this.WriteAccess.Equals(input.WriteAccess))
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
                if (this.LoanAssociateType != null)
                    hashCode = hashCode * 59 + this.LoanAssociateType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.CellPhone != null)
                    hashCode = hashCode * 59 + this.CellPhone.GetHashCode();
                if (this.Fax != null)
                    hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.RoleName != null)
                    hashCode = hashCode * 59 + this.RoleName.GetHashCode();
                if (this.RoleId != null)
                    hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.WriteAccess != null)
                    hashCode = hashCode * 59 + this.WriteAccess.GetHashCode();
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
