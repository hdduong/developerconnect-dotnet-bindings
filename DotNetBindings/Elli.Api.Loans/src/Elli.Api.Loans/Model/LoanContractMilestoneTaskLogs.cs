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
 * OpenAPI spec version: 1.0.0
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
    /// LoanContractMilestoneTaskLogs
    /// </summary>
    [DataContract]
    public partial class LoanContractMilestoneTaskLogs :  IEquatable<LoanContractMilestoneTaskLogs>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AddedBy
        /// </summary>
        [DataMember(Name="addedBy", EmitDefaultValue=false)]
        public string AddedBy { get; set; }

        /// <summary>
        /// Gets or Sets AddedByUserId
        /// </summary>
        [DataMember(Name="addedByUserId", EmitDefaultValue=false)]
        public string AddedByUserId { get; set; }

        /// <summary>
        /// Gets or Sets Alerts
        /// </summary>
        [DataMember(Name="alerts", EmitDefaultValue=false)]
        public List<LoanContractAlerts> Alerts { get; set; }

        /// <summary>
        /// Gets or Sets CommentList
        /// </summary>
        [DataMember(Name="commentList", EmitDefaultValue=false)]
        public List<LoanContractLogRecordCommentList> CommentList { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets CompletedBy
        /// </summary>
        [DataMember(Name="completedBy", EmitDefaultValue=false)]
        public string CompletedBy { get; set; }

        /// <summary>
        /// Gets or Sets CompletedByUserId
        /// </summary>
        [DataMember(Name="completedByUserId", EmitDefaultValue=false)]
        public string CompletedByUserId { get; set; }

        /// <summary>
        /// Gets or Sets CompletedDateUtc
        /// </summary>
        [DataMember(Name="completedDateUtc", EmitDefaultValue=false)]
        public DateTime? CompletedDateUtc { get; set; }

        /// <summary>
        /// Gets or Sets Contacts
        /// </summary>
        [DataMember(Name="contacts", EmitDefaultValue=false)]
        public List<LoanContractContacts1> Contacts { get; set; }

        /// <summary>
        /// Gets or Sets DateUtc
        /// </summary>
        [DataMember(Name="dateUtc", EmitDefaultValue=false)]
        public DateTime? DateUtc { get; set; }

        /// <summary>
        /// Gets or Sets DaysToComplete
        /// </summary>
        [DataMember(Name="daysToComplete", EmitDefaultValue=false)]
        public int? DaysToComplete { get; set; }

        /// <summary>
        /// Gets or Sets DaysToCompleteFromSetting
        /// </summary>
        [DataMember(Name="daysToCompleteFromSetting", EmitDefaultValue=false)]
        public int? DaysToCompleteFromSetting { get; set; }

        /// <summary>
        /// Gets or Sets FileAttachmentsMigrated
        /// </summary>
        [DataMember(Name="fileAttachmentsMigrated", EmitDefaultValue=false)]
        public bool? FileAttachmentsMigrated { get; set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or Sets IsRequiredIndicator
        /// </summary>
        [DataMember(Name="isRequiredIndicator", EmitDefaultValue=false)]
        public bool? IsRequiredIndicator { get; set; }

        /// <summary>
        /// Gets or Sets IsSystemSpecificIndicator
        /// </summary>
        [DataMember(Name="isSystemSpecificIndicator", EmitDefaultValue=false)]
        public bool? IsSystemSpecificIndicator { get; set; }

        /// <summary>
        /// Gets or Sets LogRecordIndex
        /// </summary>
        [DataMember(Name="logRecordIndex", EmitDefaultValue=false)]
        public int? LogRecordIndex { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public string Priority { get; set; }

        /// <summary>
        /// Gets or Sets Stage
        /// </summary>
        [DataMember(Name="stage", EmitDefaultValue=false)]
        public string Stage { get; set; }

        /// <summary>
        /// Gets or Sets SystemId
        /// </summary>
        [DataMember(Name="systemId", EmitDefaultValue=false)]
        public string SystemId { get; set; }

        /// <summary>
        /// Gets or Sets TaskDescription
        /// </summary>
        [DataMember(Name="taskDescription", EmitDefaultValue=false)]
        public string TaskDescription { get; set; }

        /// <summary>
        /// Gets or Sets TaskGuid
        /// </summary>
        [DataMember(Name="taskGuid", EmitDefaultValue=false)]
        public string TaskGuid { get; set; }

        /// <summary>
        /// Gets or Sets TaskName
        /// </summary>
        [DataMember(Name="taskName", EmitDefaultValue=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name="completed", EmitDefaultValue=false)]
        public bool? Completed { get; set; }

        /// <summary>
        /// Gets or Sets ContactCount
        /// </summary>
        [DataMember(Name="contactCount", EmitDefaultValue=false)]
        public int? ContactCount { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedDate
        /// </summary>
        [DataMember(Name="expectedDate", EmitDefaultValue=false)]
        public DateTime? ExpectedDate { get; set; }

        /// <summary>
        /// Gets or Sets AddDate
        /// </summary>
        [DataMember(Name="addDate", EmitDefaultValue=false)]
        public DateTime? AddDate { get; set; }

        /// <summary>
        /// Gets or Sets MilestoneTaskLogDateUtc
        /// </summary>
        [DataMember(Name="milestoneTaskLogDateUtc", EmitDefaultValue=false)]
        public DateTime? MilestoneTaskLogDateUtc { get; set; }

        /// <summary>
        /// Gets or Sets ContactsXml
        /// </summary>
        [DataMember(Name="contactsXml", EmitDefaultValue=false)]
        public string ContactsXml { get; set; }

        /// <summary>
        /// Gets or Sets AlertsXml
        /// </summary>
        [DataMember(Name="alertsXml", EmitDefaultValue=false)]
        public string AlertsXml { get; set; }

        /// <summary>
        /// Gets or Sets CommentListXml
        /// </summary>
        [DataMember(Name="commentListXml", EmitDefaultValue=false)]
        public string CommentListXml { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractMilestoneTaskLogs {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AddedBy: ").Append(AddedBy).Append("\n");
            sb.Append("  AddedByUserId: ").Append(AddedByUserId).Append("\n");
            sb.Append("  Alerts: ").Append(Alerts).Append("\n");
            sb.Append("  CommentList: ").Append(CommentList).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  CompletedBy: ").Append(CompletedBy).Append("\n");
            sb.Append("  CompletedByUserId: ").Append(CompletedByUserId).Append("\n");
            sb.Append("  CompletedDateUtc: ").Append(CompletedDateUtc).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  DateUtc: ").Append(DateUtc).Append("\n");
            sb.Append("  DaysToComplete: ").Append(DaysToComplete).Append("\n");
            sb.Append("  DaysToCompleteFromSetting: ").Append(DaysToCompleteFromSetting).Append("\n");
            sb.Append("  FileAttachmentsMigrated: ").Append(FileAttachmentsMigrated).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  IsRequiredIndicator: ").Append(IsRequiredIndicator).Append("\n");
            sb.Append("  IsSystemSpecificIndicator: ").Append(IsSystemSpecificIndicator).Append("\n");
            sb.Append("  LogRecordIndex: ").Append(LogRecordIndex).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Stage: ").Append(Stage).Append("\n");
            sb.Append("  SystemId: ").Append(SystemId).Append("\n");
            sb.Append("  TaskDescription: ").Append(TaskDescription).Append("\n");
            sb.Append("  TaskGuid: ").Append(TaskGuid).Append("\n");
            sb.Append("  TaskName: ").Append(TaskName).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  ContactCount: ").Append(ContactCount).Append("\n");
            sb.Append("  ExpectedDate: ").Append(ExpectedDate).Append("\n");
            sb.Append("  AddDate: ").Append(AddDate).Append("\n");
            sb.Append("  MilestoneTaskLogDateUtc: ").Append(MilestoneTaskLogDateUtc).Append("\n");
            sb.Append("  ContactsXml: ").Append(ContactsXml).Append("\n");
            sb.Append("  AlertsXml: ").Append(AlertsXml).Append("\n");
            sb.Append("  CommentListXml: ").Append(CommentListXml).Append("\n");
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
            return this.Equals(input as LoanContractMilestoneTaskLogs);
        }

        /// <summary>
        /// Returns true if LoanContractMilestoneTaskLogs instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractMilestoneTaskLogs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractMilestoneTaskLogs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AddedBy == input.AddedBy ||
                    (this.AddedBy != null &&
                    this.AddedBy.Equals(input.AddedBy))
                ) && 
                (
                    this.AddedByUserId == input.AddedByUserId ||
                    (this.AddedByUserId != null &&
                    this.AddedByUserId.Equals(input.AddedByUserId))
                ) && 
                (
                    this.Alerts == input.Alerts ||
                    this.Alerts != null &&
                    this.Alerts.SequenceEqual(input.Alerts)
                ) && 
                (
                    this.CommentList == input.CommentList ||
                    this.CommentList != null &&
                    this.CommentList.SequenceEqual(input.CommentList)
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.CompletedBy == input.CompletedBy ||
                    (this.CompletedBy != null &&
                    this.CompletedBy.Equals(input.CompletedBy))
                ) && 
                (
                    this.CompletedByUserId == input.CompletedByUserId ||
                    (this.CompletedByUserId != null &&
                    this.CompletedByUserId.Equals(input.CompletedByUserId))
                ) && 
                (
                    this.CompletedDateUtc == input.CompletedDateUtc ||
                    (this.CompletedDateUtc != null &&
                    this.CompletedDateUtc.Equals(input.CompletedDateUtc))
                ) && 
                (
                    this.Contacts == input.Contacts ||
                    this.Contacts != null &&
                    this.Contacts.SequenceEqual(input.Contacts)
                ) && 
                (
                    this.DateUtc == input.DateUtc ||
                    (this.DateUtc != null &&
                    this.DateUtc.Equals(input.DateUtc))
                ) && 
                (
                    this.DaysToComplete == input.DaysToComplete ||
                    (this.DaysToComplete != null &&
                    this.DaysToComplete.Equals(input.DaysToComplete))
                ) && 
                (
                    this.DaysToCompleteFromSetting == input.DaysToCompleteFromSetting ||
                    (this.DaysToCompleteFromSetting != null &&
                    this.DaysToCompleteFromSetting.Equals(input.DaysToCompleteFromSetting))
                ) && 
                (
                    this.FileAttachmentsMigrated == input.FileAttachmentsMigrated ||
                    (this.FileAttachmentsMigrated != null &&
                    this.FileAttachmentsMigrated.Equals(input.FileAttachmentsMigrated))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.IsRequiredIndicator == input.IsRequiredIndicator ||
                    (this.IsRequiredIndicator != null &&
                    this.IsRequiredIndicator.Equals(input.IsRequiredIndicator))
                ) && 
                (
                    this.IsSystemSpecificIndicator == input.IsSystemSpecificIndicator ||
                    (this.IsSystemSpecificIndicator != null &&
                    this.IsSystemSpecificIndicator.Equals(input.IsSystemSpecificIndicator))
                ) && 
                (
                    this.LogRecordIndex == input.LogRecordIndex ||
                    (this.LogRecordIndex != null &&
                    this.LogRecordIndex.Equals(input.LogRecordIndex))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Stage == input.Stage ||
                    (this.Stage != null &&
                    this.Stage.Equals(input.Stage))
                ) && 
                (
                    this.SystemId == input.SystemId ||
                    (this.SystemId != null &&
                    this.SystemId.Equals(input.SystemId))
                ) && 
                (
                    this.TaskDescription == input.TaskDescription ||
                    (this.TaskDescription != null &&
                    this.TaskDescription.Equals(input.TaskDescription))
                ) && 
                (
                    this.TaskGuid == input.TaskGuid ||
                    (this.TaskGuid != null &&
                    this.TaskGuid.Equals(input.TaskGuid))
                ) && 
                (
                    this.TaskName == input.TaskName ||
                    (this.TaskName != null &&
                    this.TaskName.Equals(input.TaskName))
                ) && 
                (
                    this.Completed == input.Completed ||
                    (this.Completed != null &&
                    this.Completed.Equals(input.Completed))
                ) && 
                (
                    this.ContactCount == input.ContactCount ||
                    (this.ContactCount != null &&
                    this.ContactCount.Equals(input.ContactCount))
                ) && 
                (
                    this.ExpectedDate == input.ExpectedDate ||
                    (this.ExpectedDate != null &&
                    this.ExpectedDate.Equals(input.ExpectedDate))
                ) && 
                (
                    this.AddDate == input.AddDate ||
                    (this.AddDate != null &&
                    this.AddDate.Equals(input.AddDate))
                ) && 
                (
                    this.MilestoneTaskLogDateUtc == input.MilestoneTaskLogDateUtc ||
                    (this.MilestoneTaskLogDateUtc != null &&
                    this.MilestoneTaskLogDateUtc.Equals(input.MilestoneTaskLogDateUtc))
                ) && 
                (
                    this.ContactsXml == input.ContactsXml ||
                    (this.ContactsXml != null &&
                    this.ContactsXml.Equals(input.ContactsXml))
                ) && 
                (
                    this.AlertsXml == input.AlertsXml ||
                    (this.AlertsXml != null &&
                    this.AlertsXml.Equals(input.AlertsXml))
                ) && 
                (
                    this.CommentListXml == input.CommentListXml ||
                    (this.CommentListXml != null &&
                    this.CommentListXml.Equals(input.CommentListXml))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AddedBy != null)
                    hashCode = hashCode * 59 + this.AddedBy.GetHashCode();
                if (this.AddedByUserId != null)
                    hashCode = hashCode * 59 + this.AddedByUserId.GetHashCode();
                if (this.Alerts != null)
                    hashCode = hashCode * 59 + this.Alerts.GetHashCode();
                if (this.CommentList != null)
                    hashCode = hashCode * 59 + this.CommentList.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.CompletedBy != null)
                    hashCode = hashCode * 59 + this.CompletedBy.GetHashCode();
                if (this.CompletedByUserId != null)
                    hashCode = hashCode * 59 + this.CompletedByUserId.GetHashCode();
                if (this.CompletedDateUtc != null)
                    hashCode = hashCode * 59 + this.CompletedDateUtc.GetHashCode();
                if (this.Contacts != null)
                    hashCode = hashCode * 59 + this.Contacts.GetHashCode();
                if (this.DateUtc != null)
                    hashCode = hashCode * 59 + this.DateUtc.GetHashCode();
                if (this.DaysToComplete != null)
                    hashCode = hashCode * 59 + this.DaysToComplete.GetHashCode();
                if (this.DaysToCompleteFromSetting != null)
                    hashCode = hashCode * 59 + this.DaysToCompleteFromSetting.GetHashCode();
                if (this.FileAttachmentsMigrated != null)
                    hashCode = hashCode * 59 + this.FileAttachmentsMigrated.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.IsRequiredIndicator != null)
                    hashCode = hashCode * 59 + this.IsRequiredIndicator.GetHashCode();
                if (this.IsSystemSpecificIndicator != null)
                    hashCode = hashCode * 59 + this.IsSystemSpecificIndicator.GetHashCode();
                if (this.LogRecordIndex != null)
                    hashCode = hashCode * 59 + this.LogRecordIndex.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Stage != null)
                    hashCode = hashCode * 59 + this.Stage.GetHashCode();
                if (this.SystemId != null)
                    hashCode = hashCode * 59 + this.SystemId.GetHashCode();
                if (this.TaskDescription != null)
                    hashCode = hashCode * 59 + this.TaskDescription.GetHashCode();
                if (this.TaskGuid != null)
                    hashCode = hashCode * 59 + this.TaskGuid.GetHashCode();
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.Completed != null)
                    hashCode = hashCode * 59 + this.Completed.GetHashCode();
                if (this.ContactCount != null)
                    hashCode = hashCode * 59 + this.ContactCount.GetHashCode();
                if (this.ExpectedDate != null)
                    hashCode = hashCode * 59 + this.ExpectedDate.GetHashCode();
                if (this.AddDate != null)
                    hashCode = hashCode * 59 + this.AddDate.GetHashCode();
                if (this.MilestoneTaskLogDateUtc != null)
                    hashCode = hashCode * 59 + this.MilestoneTaskLogDateUtc.GetHashCode();
                if (this.ContactsXml != null)
                    hashCode = hashCode * 59 + this.ContactsXml.GetHashCode();
                if (this.AlertsXml != null)
                    hashCode = hashCode * 59 + this.AlertsXml.GetHashCode();
                if (this.CommentListXml != null)
                    hashCode = hashCode * 59 + this.CommentListXml.GetHashCode();
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
