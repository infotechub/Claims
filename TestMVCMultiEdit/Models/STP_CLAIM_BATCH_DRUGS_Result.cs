//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestMVCMultiEdit.Models
{
    using System;
    
    public partial class STP_CLAIM_BATCH_DRUGS_Result
    {
        public int Id { get; set; }
        public string DrugName { get; set; }
        public string DrugDescription { get; set; }
        public string Quantity { get; set; }
        public string rate { get; set; }
        public Nullable<decimal> InitialAmount { get; set; }
        public Nullable<decimal> costofdrug { get; set; }
        public Nullable<bool> flagred { get; set; }
        public Nullable<int> DrugId { get; set; }
        public Nullable<decimal> VettedAmount { get; set; }
        public string VettingComment { get; set; }
        public string status { get; set; }
        public System.Guid Guid { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> ClaimId { get; set; }
        public Nullable<int> SiteId { get; set; }
        public Nullable<int> Id1 { get; set; }
        public Nullable<int> ProviderId { get; set; }
        public Nullable<int> Enrolleeid { get; set; }
        public string enrolleeFullname { get; set; }
        public string enrolleeGender { get; set; }
        public string enrolleeCompanyName { get; set; }
        public Nullable<int> enrolleeCompanyId { get; set; }
        public string enrolleePolicyNumber { get; set; }
        public string EnrolleePlan { get; set; }
        public string ClaimsSerialNo { get; set; }
        public string EVSCode { get; set; }
        public string DoctorsName { get; set; }
        public string DoctorsId { get; set; }
        public string AreaOfSpecialty { get; set; }
        public string Signature { get; set; }
        public Nullable<bool> DoctorSigned { get; set; }
        public Nullable<System.DateTime> DoctorSignecDate { get; set; }
        public string specialistName { get; set; }
        public string AreaOfSpecialtyforspecialist { get; set; }
        public string specialistphonenumber { get; set; }
        public Nullable<bool> specialistSigned { get; set; }
        public Nullable<System.DateTime> specialistSignecDate { get; set; }
        public Nullable<System.DateTime> ServiceDate { get; set; }
        public Nullable<System.DateTime> AdmissionDate { get; set; }
        public Nullable<System.DateTime> DischargeDate { get; set; }
        public string Durationoftreatment { get; set; }
        public string Diagnosis { get; set; }
        public string TreatmentGiven { get; set; }
        public string TreatmentCode { get; set; }
        public string referalCode { get; set; }
        public Nullable<bool> enrolleeSigned { get; set; }
        public Nullable<System.DateTime> EnrolleeSignDate { get; set; }
        public Nullable<bool> AllprescibedDrugs { get; set; }
        public Nullable<bool> LaboratoryInvestigation { get; set; }
        public Nullable<bool> Admission { get; set; }
        public Nullable<bool> Feeding { get; set; }
        public string Note { get; set; }
        public string Tag { get; set; }
        public Nullable<int> capturedBy { get; set; }
        public string capturedName { get; set; }
        public Nullable<int> vettedBy { get; set; }
        public Nullable<int> RevettedBy { get; set; }
        public Nullable<System.DateTime> VettedDate { get; set; }
        public Nullable<System.DateTime> ReVettedDate { get; set; }
        public string status1 { get; set; }
        public Nullable<System.Guid> Guid1 { get; set; }
        public Nullable<System.DateTime> CreatedOn1 { get; set; }
        public Nullable<System.DateTime> UpdatedOn1 { get; set; }
        public Nullable<bool> IsDeleted1 { get; set; }
        public Nullable<int> ClaimBatchId { get; set; }
        public Nullable<int> SiteId1 { get; set; }
        public string enrolleeage { get; set; }
        public string ClientsideID { get; set; }
        public string diagnosticsIDString { get; set; }
        public Nullable<bool> SubmitByProvider { get; set; }
        public string ipaddressofprovider { get; set; }
        public Nullable<int> MyUserId { get; set; }
        public string vettedName { get; set; }
    }
}
