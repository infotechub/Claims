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
    
    public partial class ConnectcarePaymentDetail
    {
        public int Id { get; set; }
        public string paymentid { get; set; }
        public Nullable<int> sponsorID { get; set; }
        public string sponsorIDString { get; set; }
        public string beneficiaryID { get; set; }
        public string policyid { get; set; }
        public Nullable<decimal> amountpaid { get; set; }
        public string planpurchased { get; set; }
        public Nullable<bool> addon { get; set; }
        public Nullable<System.DateTime> paymentDate { get; set; }
        public System.Guid Guid { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> SiteId { get; set; }
    }
}
