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
    
    public partial class ProviderAccount
    {
        public int Id { get; set; }
        public Nullable<int> Providerid { get; set; }
        public Nullable<int> BankId { get; set; }
        public string Bankaccountname { get; set; }
        public string Bankaccountnum { get; set; }
        public string Bankbranch { get; set; }
        public string Note { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> AuthorizationStatus { get; set; }
        public string AuthorizationNote { get; set; }
        public string DisapprovalNote { get; set; }
        public Nullable<int> AuthorizedBy { get; set; }
        public Nullable<int> DisapprovedBy { get; set; }
        public Nullable<System.DateTime> AuthorizedDate { get; set; }
        public Nullable<System.DateTime> DisapprovalDate { get; set; }
        public System.Guid Guid { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> SiteId { get; set; }
    }
}
