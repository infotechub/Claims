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
    
    public partial class BatchJob
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BatchJob()
        {
            this.BatchRunResults = new HashSet<BatchRunResult>();
        }
    
        public int Id { get; set; }
        public string discriminator { get; set; }
        public string Data { get; set; }
        public Nullable<int> Tries { get; set; }
        public string Status { get; set; }
        public System.Guid Guid { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> BatchId { get; set; }
        public Nullable<int> SiteId { get; set; }
        public string IndexName { get; set; }
        public string UrlSegment { get; set; }
    
        public virtual Batch Batch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BatchRunResult> BatchRunResults { get; set; }
    }
}
