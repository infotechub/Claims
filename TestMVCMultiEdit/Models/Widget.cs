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
    
    public partial class Widget
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Widget()
        {
            this.HiddenWidgets = new HashSet<HiddenWidget>();
            this.HiddenWidgets1 = new HashSet<HiddenWidget>();
            this.PageWidgetSorts = new HashSet<PageWidgetSort>();
            this.ShownWidgets = new HashSet<ShownWidget>();
            this.ShownWidgets1 = new HashSet<ShownWidget>();
            this.Users = new HashSet<User>();
            this.Users1 = new HashSet<User>();
        }
    
        public int Id { get; set; }
        public string WidgetType { get; set; }
        public string Name { get; set; }
        public string CustomLayout { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public Nullable<bool> Cache { get; set; }
        public Nullable<int> CacheLength { get; set; }
        public string CacheExpiryType { get; set; }
        public Nullable<bool> IsRecursive { get; set; }
        public System.Guid Guid { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> LayoutAreaId { get; set; }
        public Nullable<int> WebpageId { get; set; }
        public Nullable<int> SiteId { get; set; }
        public Nullable<bool> ShowNameAsTitle { get; set; }
        public Nullable<int> ArticleListId { get; set; }
        public Nullable<int> NumberOfArticles { get; set; }
        public Nullable<int> RelatedNewsListId { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public Nullable<bool> IncludeChildren { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Image1 { get; set; }
        public string Link1 { get; set; }
        public string Description1 { get; set; }
        public string Image2 { get; set; }
        public string Link2 { get; set; }
        public string Description2 { get; set; }
        public string Image3 { get; set; }
        public string Link3 { get; set; }
        public string Description3 { get; set; }
        public Nullable<int> FaqId { get; set; }
        public string Title { get; set; }
    
        public virtual Document Document { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HiddenWidget> HiddenWidgets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HiddenWidget> HiddenWidgets1 { get; set; }
        public virtual LayoutArea LayoutArea { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PageWidgetSort> PageWidgetSorts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShownWidget> ShownWidgets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShownWidget> ShownWidgets1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users1 { get; set; }
    }
}
