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
    using System.Collections.Generic;
    
    public partial class AuthorizationCode
    {
        public int Id { get; set; }
        public string authorizationCode1 { get; set; }
        public string policyNumber { get; set; }
        public string enrolleeName { get; set; }
        public string EnrolleeCompany { get; set; }
        public string Diagnosis { get; set; }
        public string TypeofAuthorization { get; set; }
        public Nullable<int> enrolleeAge { get; set; }
        public Nullable<int> enrolleeID { get; set; }
        public string Plan { get; set; }
        public string Note { get; set; }
        public string requestername { get; set; }
        public string requesterphone { get; set; }
        public Nullable<int> provider { get; set; }
        public Nullable<int> generatedby { get; set; }
        public Nullable<int> Authorizedby { get; set; }
        public Nullable<bool> AcknowledgedByAuthorizer { get; set; }
        public System.Guid Guid { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> SiteId { get; set; }
        public Nullable<bool> Isadmission { get; set; }
        public Nullable<System.DateTime> AdmissionDate { get; set; }
        public Nullable<int> DaysApprovded { get; set; }
        public Nullable<System.DateTime> DischargeDate { get; set; }
        public string admissionStatus { get; set; }
        public Nullable<bool> IsNHIS { get; set; }
        public Nullable<bool> isdelivery { get; set; }
        public Nullable<bool> deliverysmssent { get; set; }
        public string treatmentAuthorized { get; set; }
    }
}
