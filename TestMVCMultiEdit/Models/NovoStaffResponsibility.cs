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
    
    public partial class NovoStaffResponsibility
    {
        public int Id { get; set; }
        public Nullable<int> Staff_Id { get; set; }
        public string Staff_Resp { get; set; }
        public System.Guid Guid { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> SiteId { get; set; }
    }
}
